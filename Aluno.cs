using System;
using System.Collections.Generic;
using System.Text;

namespace ex3
{
    class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;
        double notas;
        double falta;
        string Valida;

        public double Validacao()
        {
            notas = Nota1 + Nota2 + Nota3;
            return notas;
        }
        public string Aprovacao()
        {
            Validacao();
            if (notas >= 60)
            {
                Valida = "Aprovado";
                Console.WriteLine("Nota Final: "+ notas);
            }
            else
            {
                Valida = "Reprovado";
                Console.WriteLine("Nota Final: " + notas);
                Falta();
            }
            return Valida;
        }
        public void Falta()
        {
            falta = 60 - notas;
            Console.WriteLine("Faltaram "+falta+" Pontos");
        }
    }
}
