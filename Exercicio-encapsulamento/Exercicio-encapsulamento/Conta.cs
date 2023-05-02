using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_encapsulamento {
    internal class Conta {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular) {
            Saldo = 0;
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo += saldo;
        }

        public void setSaldo (double saldo) {
            if(saldo > 0) {
                Saldo += saldo;
            }
        }

        public void deposito(double saldo) {
            if(saldo > 0) {
                Saldo += saldo;
            }
        }

        public void saque(double saldo) {
            if (saldo > 0) {
                Saldo -= saldo;
            }
        }
        public override string ToString() {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: " + Saldo;
        }
    }
}
