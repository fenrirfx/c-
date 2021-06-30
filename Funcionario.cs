using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;
        public double Percentagem;

        public double Liquido()
        {
            return Salario - Imposto;
        }
        public double Aumento()
        {
            Percentagem = Salario* (Percentagem / 100);
            return Salario + Percentagem;
        }
    }
}
