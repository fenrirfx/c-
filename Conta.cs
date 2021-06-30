using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FinalEx
{
    class Conta
    {
        public int NumeroConta{ get; private set; }
        private string _nome;
        public double Saldo { get; private set; }

        public Conta(int conta, string nome)
        {
            NumeroConta = conta;
            _nome = nome;
        }
        public Conta(int conta, string nome, double valor) : this(conta, nome)
        {
            Saldo = valor;
        }

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1)
                    _nome = value;
            }
        }
        public void Levantamento(double valor)
        {
            Saldo -= valor + 5.00;
        }
        public void Deposit(double valor)
        {
            Saldo += valor;
        }
        public override string ToString()
        {
            return "Conta " 
                + NumeroConta
                + ", Titular: "
                + _nome
                + ", Saldo: $"
                +Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
