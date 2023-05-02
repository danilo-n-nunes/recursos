using System;
using System.Globalization;
namespace Properties {
    class Program {
        static void Main(string[] args) {
            
            Produto produto = new Produto("TV", 500.0);

            produto.Nome = "TV";
            Console.WriteLine(produto.Preco);
        }
    }
}