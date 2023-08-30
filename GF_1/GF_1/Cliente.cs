using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_1
{
    
    public class Cliente
    {
        private string nome;
        private string sobrenome;
        private string endereco;
        private string numeroTelefone;

        public Cliente(string nome, string sobrenome, string endereco, string numeroTelefone)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.endereco = endereco;
            this.numeroTelefone = numeroTelefone;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetSobrenome()
        {
            return sobrenome;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public string GetNumeroTelefone()
        {
            return numeroTelefone;
        }

        public void MostrarCliente()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Endereço: " + endereco);
            Console.WriteLine("Número de Telefone: " + numeroTelefone);
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



            
