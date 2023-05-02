using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class Funcionario {

        public string nome;
        public float salario_bruto;
        public float imposto;

        public void aumentarSalario (float aumento) {

            salario_bruto += (salario_bruto / 100) * aumento;
        }

        public override string ToString () {
            return nome + " $" + salario_bruto;
        }
    }
}
