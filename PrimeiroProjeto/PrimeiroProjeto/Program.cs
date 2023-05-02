using System;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            int x;
            int y;
            Funcionario func;

            x = 0;
            y = 0;
            Console.WriteLine(x + " " + y);

            func = new Funcionario();
            Console.Write("Digite o nome do Funcionario:");
            func.nome = Console.ReadLine();

            Console.Write("digite o Salário do Funcionario:");
            func.salario_bruto = float.Parse(Console.ReadLine());

            func.aumentarSalario(10);

            Console.WriteLine(func);
        }
    }
}