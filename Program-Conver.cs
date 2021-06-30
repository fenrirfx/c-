using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o valor do dólar: ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade que vai comprar: ");
            ConversorDeMoeda.Quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor: "+ ConversorDeMoeda.Conversao());
            Console.WriteLine("Valor a ser pago em Reais: "+ ConversorDeMoeda.Taxa());
        }
    }
}
