using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool clienteAdicionado1 = Cliente.AdicionarCliente(clientes, "João", "Silva", "Rua A, 123", "(11) 1234-5678");
            int op;
            Console.WriteLine("|======|Sistema MAPA|=======|");
            Console.WriteLine("| [1] Adicionar Cliente     |");
            Console.WriteLine("| [2] Adicionar Produto     |");
            Console.WriteLine("| [3] Adicionar Categoria   |");
            Console.WriteLine("| [4] Realizar Venda        |");
            Console.WriteLine("|===========================|");
            Console.Write("Digite a opção desejada: ");
            if (int.TryParse(Console.ReadLine(), out op))
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Opção 1 selecionada: Adicionar Cliente");
                        List<Cliente> clientes = new List<Cliente>();
                        if (clienteAdicionado1)
                        {
                            Console.WriteLine("Cliente 1 foi adicionado com sucesso.");
                        }

                        if (clienteAdicionado2)
                        {
                            Console.WriteLine("Cliente 2 foi adicionado com sucesso.");
                        }

                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }
        }
    }

}
}
