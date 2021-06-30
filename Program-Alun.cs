using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x;
            x = new Aluno();

            Console.Write("Insira a Nota: ");
            x.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Insira a Nota: ");
            x.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Insira a Nota: ");
            x.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("O Aluno está: "+ x.Aprovacao());
        }
    }
}
