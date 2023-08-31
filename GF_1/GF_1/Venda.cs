using System;
using System.Collections.Generic;

namespace GF_1
{
    public class Venda
    {
        public Cliente Cliente { get; set; }
        public List<Produto> ProdutosVendidos { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }

        public Venda(Cliente cliente, List<Produto> produtos, DateTime dataVenda)
        {
            Cliente = cliente;
            ProdutosVendidos = produtos;
            DataVenda = dataVenda;
            ValorTotal = CalcularValorTotal();
        }

        private decimal CalcularValorTotal()
        {
            decimal total = 0;
            foreach (var produto in ProdutosVendidos)
            {
                total += produto.Preco;
            }
            return total;
        }

        public static bool RealizarVenda(List<Cliente> listaClientes, List<Produto> listaProdutos)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Opção 7 selecionada: Realizar Venda");
            Console.ResetColor();

            // Solicitar o nome do cliente
            Console.Write("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            // Procurar o cliente na lista de clientes
            Cliente cliente = listaClientes.Find(c => c.GetNome().Equals(nomeCliente, StringComparison.OrdinalIgnoreCase));

            if (cliente == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cliente não encontrado.");
                Console.ResetColor();
                Console.ReadLine();
                return false;
            }

            List<Produto> produtosVendidos = new List<Produto>();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Produtos disponíveis:");

                foreach (var produto in listaProdutos)
                {
                    Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}");
                }

                Console.Write("Digite o ID do produto que deseja adicionar à venda (ou 0 para sair): ");
                if (int.TryParse(Console.ReadLine(), out int idProduto))
                {
                    if (idProduto == 0)
                    {
                        continuar = false;
                    }
                    else
                    {
                        Produto produtoSelecionado = listaProdutos.Find(p => p.Id == idProduto);
                        if (produtoSelecionado != null)
                        {
                            produtosVendidos.Add(produtoSelecionado);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{produtoSelecionado.Nome} adicionado à venda.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Produto não encontrado.");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ID de produto inválido. Tente novamente.");
                }

            }

            // Registrar a venda
            DateTime dataVenda = DateTime.Now;
            Venda venda = new Venda(cliente, produtosVendidos, dataVenda);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Venda registrada com sucesso!");
            Console.ResetColor();
            Console.WriteLine($"Data da Venda: {venda.DataVenda}");
            Console.WriteLine("Produtos Vendidos:");
            foreach (var produto in venda.ProdutosVendidos)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
            }
            Console.WriteLine($"Valor Total: {venda.ValorTotal}");
            Console.ReadLine();
            return true;
        }
    }
}
