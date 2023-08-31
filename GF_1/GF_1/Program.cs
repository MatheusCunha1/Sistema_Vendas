using System;
using System.Collections.Generic;

namespace GF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            List<Categoria> listaCategorias = new List<Categoria>();
            List<Produto> listaProdutos = new List<Produto>();

            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("|======|Sistema MAPA|=======|");
                Console.WriteLine("| [1] Adicionar Cliente     |");
                Console.WriteLine("| [2] Mostrar Cliente       |");
                Console.WriteLine("| [3] Adicionar Categoria   |");
                Console.WriteLine("| [4] Mostrar Categorias    |");  
                Console.WriteLine("| [5] Adicionar Produto     |");  
                Console.WriteLine("| [6] Mostrar Produto       |");  
                Console.WriteLine("|===========================|");
                Console.Write("Digite a opção desejada: ");

                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Opção 1 selecionada: Adicionar Cliente");
                            Console.ResetColor();
                            do
                            {
                                Console.Write("Nome: ");
                                string nome = Console.ReadLine();

                                Console.Write("Sobrenome: ");
                                string sobrenome = Console.ReadLine();

                                Console.Write("Endereço: ");
                                string endereco = Console.ReadLine();

                                Console.Write("Número de Telefone: ");
                                string numeroTelefone = Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                Cliente.AdicionarCliente(listaClientes, nome, sobrenome, endereco, numeroTelefone);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Pressione Enter para continuar!");
                                Console.ReadKey();
                                Console.ResetColor();

                                Console.Clear();
                                Console.WriteLine("Deseja adicionar mais um cliente? (S/N)");
                            } while (Console.ReadLine().Trim().ToUpper() == "S");
                            
                            break;
                        case 2:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Opção 2 selecionada: Mostrar Clientes");
                            Console.ResetColor();

                            Cliente.ExibirClientes(listaClientes);
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Opção 3 selecionada: Adicionar Categoria");
                            Console.ResetColor();

                            Console.Write("Nome da Categoria: ");
                            string nomeCategoria = Console.ReadLine();

                            Console.Write("Descrição da Categoria: ");
                            string descricaoCategoria = Console.ReadLine();

                            listaCategorias.Add(new Categoria { Nome = nomeCategoria, Descricao = descricaoCategoria });
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Categoria adicionada com sucesso!");
                            Console.ResetColor();
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Opção 4 selecionada: Mostrar Categorias");
                            Console.ResetColor();

                            Categoria.ExibirCategorias(listaCategorias);
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Opção 5 selecionada: Adicionar Produto");
                            Console.ResetColor();

                            Console.Write("Nome do Produto: ");
                            string nomeProduto = Console.ReadLine();

                            Console.Write("Descrição do Produto: ");
                            string descricaoProduto = Console.ReadLine();

                            Console.Write("Preço do Produto: ");
                            decimal precoProduto;
                            while (!decimal.TryParse(Console.ReadLine(), out precoProduto))
                            {
                                Console.WriteLine("Preço inválido. Digite um número válido.");
                                Console.Write("Preço do Produto: ");
                            }

                            
                            Console.WriteLine("Categorias disponíveis:");
                            for (int i = 0; i < listaCategorias.Count; i++)
                            {
                                Console.WriteLine($"[{i + 1}] {listaCategorias[i].Nome}");
                            }

                            int categoriaSelecionada;
                            while (true)
                            {
                                Console.Write("Selecione o número da categoria para associar ao produto: ");
                                if (int.TryParse(Console.ReadLine(), out categoriaSelecionada) && categoriaSelecionada >= 1 && categoriaSelecionada <= listaCategorias.Count)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Seleção inválida. Digite um número válido.");
                                }
                            }

                            Categoria categoriaAssociada = listaCategorias[categoriaSelecionada - 1];

                            int novoProdutoId = listaProdutos.Count + 1;
                            Produto.AdicionarProduto(listaProdutos, novoProdutoId, nomeProduto, descricaoProduto, precoProduto);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Produto '{nomeProduto}' associado à categoria '{categoriaAssociada.Nome}' com sucesso.");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Pressione Enter para continuar!");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        // Dentro do loop do menu (antes do while(op != 6))
                        case 7:
                            if (Venda.RealizarVenda(listaClientes, listaProdutos))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Venda realizada com sucesso!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Erro ao realizar a venda.");
                            }
                            Console.ResetColor();
                            Console.WriteLine("Pressione Enter para continuar.");
                            Console.ReadLine();
                            break;

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                }

            } while (op != 6);

            Console.WriteLine("Saindo do programa.");
            Console.ReadKey();

        }
    }
}
