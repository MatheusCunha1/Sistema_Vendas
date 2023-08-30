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
            
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("|======|Sistema MAPA|=======|");
                Console.WriteLine("| [1] Adicionar Cliente     |");
                Console.WriteLine("| [2] Mostrar Cliente       |");
                Console.WriteLine("| [3] Adicionar Categoria   |");
                Console.WriteLine("| [4] Mostrar Categorias    |");  
                Console.WriteLine("| [5] Realizar Venda        |");
                Console.WriteLine("| [6] Sair                  |");  
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
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida");
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
