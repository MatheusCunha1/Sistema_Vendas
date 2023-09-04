using System;
using System.Collections.Generic;


namespace GF_1
{

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id,string nome, string descricao , decimal preco)
        {

            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
        public static bool AdicionarProduto(List<Produto> listaProduto, int id, string nome, string descricao, decimal preco)
        {
            try
            {
                Produto novoProduto = new Produto(id, nome, descricao, preco);
                listaProduto.Add(novoProduto);
                Console.WriteLine("Produto adicionado com sucesso.");
                return true;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Erro ao adicionar Produto: " + e.Message);
                return false;
            }
        }

    }

}
