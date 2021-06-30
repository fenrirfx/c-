using System;
using System.Collections.Generic;
using System.Text;

namespace ex4
{
    class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double Quantidade;
        public static double tax;
        public static double qtd;
        static double IOF = 0.06;

        public static double Conversao()
        {
            qtd = Quantidade * Cotacao;
            return qtd;
        }
        public static double Taxa()
        {
            tax = qtd * IOF;
            qtd += tax; 
            return qtd;
        }

    }
}
