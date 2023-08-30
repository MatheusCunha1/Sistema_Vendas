using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá Mundo");
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
    }
}
