using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_1
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string NumeroTelefone { get; set; }

        public Cliente(string nome, string sobrenome, string endereco, string numeroTelefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Endereco = endereco;
            NumeroTelefone = numeroTelefone;
        }
        
        public static bool AdicionarCliente(List<Cliente> listaClientes, string nome, string sobrenome, string endereco, string numeroTelefone)
        {
            try
            {
                Cliente novoCliente = new Cliente(nome, sobrenome, endereco, numeroTelefone);
                listaClientes.Add(novoCliente);
                Console.WriteLine("Cliente adicionado com sucesso.");
                return true;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Erro ao adicionar cliente: " + e.Message);
                return false;
            }
        }





    }

}

            
