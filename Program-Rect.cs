using System;
using System.Globalization;

namespace Projecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a altura: ");
            double alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Insira a largura: ");
            double lar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = Rectangulo.Area(lar, alt);
            double perimetro = Rectangulo.Perimetro(lar, alt);
            double diagonal = Rectangulo.Diagonal(lar, alt);

            Console.WriteLine("a area é: " + area);
            Console.WriteLine("o perimetro é: " + perimetro);
            Console.WriteLine("a diagonal é: " + diagonal);
        }
    }
}
