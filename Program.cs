using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        private static object produtos1;

        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "Maionese";
            produto1.Preco = 6.0f;
            
            produtos.Add(produto1);

            produtos.Add(new Produto(2, "Chocolate", 4.69f));
            produtos.Add(new Produto(3, "Pão", 0.60f));
            produtos.Add(new Produto(4, "Chinelo", 17.50f));
            produtos.Add(new Produto(5, "Toalha bonitinha de ponei", 40.40f));
            produtos.Add(new Produto(6, "Almodafa", 10.00f));
            produtos.Add(new Produto(7, "Celular", 1500.000f));
            produtos.Add(new Produto(8, "Sabão", 2.00f));
            produtos.Add(new Produto(9, "Comidinha de gato", 50.00f));


            foreach (Produto item in produtos )
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine( $"R$ {item.Preco} - {item.Nome}");
                Console.ResetColor();
            };
            
            produtos.Remove(produto1);

            produtos.RemoveAt(2);

            produtos.RemoveAll(y => y.Nome == "Chocolate");
            
            foreach (Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine( $"R$ {item.Preco} - {item.Nome}");
                Console.ResetColor();
            }

            Produto Almodafa = produtos.Find(x => x.Codigo == 6);

            System.Console.WriteLine( "Almofada - R$" + Almodafa.Preco);



            
            
        }
    }
}
