using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número de quartos a alugar:");
            int n = int.Parse(Console.ReadLine());

            Rent[] vect = new Rent[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent#" + (i + 1));
                Console.Write("Insira o Nome:");
                string nome = Console.ReadLine();
                Console.Write("Insira o Email:");
                string email = Console.ReadLine();
                Console.Write("Número do Quarto:");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Rent { Nome = nome, Email = email, NumeroQuarto = quarto };
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                    Console.WriteLine(vect[i]);
            }
        }
        
    }
}
