using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x;
            x = new Funcionario();

            Console.Write("Insira o nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Insira o salário: ");
            x.Salario = double.Parse(Console.ReadLine());
            Console.Write("Insira o imposto: ");
            x.Imposto = double.Parse(Console.ReadLine());

            double liquido = x.Liquido();
            Console.WriteLine("Funcionário: " + x.Nome + ", Salario Liquido: " + liquido);
            Console.WriteLine();
            Console.Write("Digite a percentagem para aumentar: ");
            x.Percentagem = double.Parse(Console.ReadLine());
            double aumento = x.Aumento();
            Console.WriteLine("Dados Actualizados: "+ x.Nome + ", Salario Liquido " + aumento);
        }
    }
}
