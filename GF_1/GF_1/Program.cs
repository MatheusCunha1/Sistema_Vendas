using System;
using System.Collections.Generic;

namespace GF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaClientes = new List<Cliente>();
        

            int op;
            Console.WriteLine("|======|Sistema MAPA|=======|");
            Console.WriteLine("| [1] Adicionar Cliente     |");
            Console.WriteLine("| [2] Mostrar Cliente       |");
            Console.WriteLine("| [3] Adicionar Categoria   |");
            Console.WriteLine("| [4] Realizar Venda        |");
            Console.WriteLine("| [5] Sair                  |");
            Console.WriteLine("|===========================|");
            Console.Write("Digite a opção desejada: ");
            if (int.TryParse(Console.ReadLine(), out op))
            {
                switch (op)
                {
                    case 1:
                        Console.Clear(); 
                        Console.WriteLine("Opção 1 selecionada: Adicionar Cliente");

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Sobrenome: ");
                        string sobrenome = Console.ReadLine();

                        Console.Write("Endereço: ");
                        string endereco = Console.ReadLine();

                        Console.Write("Número de Telefone: ");
                        string numeroTelefone = Console.ReadLine();

                        Cliente.AdicionarCliente(listaClientes, nome, sobrenome, endereco, numeroTelefone);

                        Console.WriteLine("Cliente adicionado com sucesso!");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear(); // Limpa a tela
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.Clear(); // Limpa a tela
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                Console.ReadKey();
            }
        }
    }
}
