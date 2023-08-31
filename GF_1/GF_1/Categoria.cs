using System;
using System.Collections.Generic;


namespace GF_1
{
    internal class Categoria
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public static void ExibirCategorias(List<Categoria> categorias)
        {
            Console.WriteLine("Categorias disponíveis:");
            foreach (var categoria in categorias)
            {
                Console.WriteLine($"Nome: {categoria.Nome}, Descrição: {categoria.Descricao}");
            }
        }
    }
}
