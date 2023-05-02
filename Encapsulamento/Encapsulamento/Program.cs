using System;
using System.Globalization;
namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {
            
            Produto produto = new Produto("TV", 500.0);

            Console.WriteLine(produto.getNome());
            Console.WriteLine(produto.getPreco());

            Console.WriteLine(produto);
        }
    }
}