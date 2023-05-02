
using Exercicio_encapsulamento;

namespace exercicios {

    class Program {
        static void Main(string[] args) {

            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (S/N)");
            char dep = char.Parse(Console.ReadLine());

            if (dep == 'S') {
                Console.Write("Entre o com o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                conta = new Conta(numero, titular, saldo);

            } else {

                conta = new Conta(numero, titular);
            }

            Console.WriteLine(conta);

            Console.WriteLine("quer depositar? (S/N)");
            dep = char.Parse(Console.ReadLine());

            if (dep == 'S') {
                Console.WriteLine("Entre com o valor a depositar: ");
                double saldo = double.Parse(Console.ReadLine());
                conta.deposito(saldo);
            }

            Console.WriteLine("Quer sacar? (S/N)");
            dep = char.Parse(Console.ReadLine());
            if (dep == 'S') {
                Console.WriteLine("Entre com o valor a Sacar: ");
                double saldo = double.Parse(Console.ReadLine());
                conta.saque(saldo);
            }

            Console.WriteLine(conta);

        }
    }
}
