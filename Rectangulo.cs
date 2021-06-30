using System;
using System.Collections.Generic;
using System.Text;

namespace Projecto
{
    class Rectangulo
    {
        public double Largura;
        public double Altura;

        public static double Area(double Largura, double Altura)
        {
            return Largura * Altura;
        }
        public static double Perimetro(double Largura, double Altura)
        {
            return 2 * (Altura + Largura);
        }
        public static double Diagonal(double Largura, double Altura)
        {
            double hipotenusa = Math.Pow(Altura, 2) + Math.Pow(Largura, 2);
            return Math.Sqrt(hipotenusa);
        }

    }
}
