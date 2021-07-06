using System;
using System.Collections.Generic;


namespace ExListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Insira o número de Funcionários:");
            int q = int.Parse(Console.ReadLine());

            for (int i = 1; i <= q; i++)
            {
                Console.WriteLine("Numero de Empregado #"+i+":");
                Console.Write("Insira um numero:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("insira o nome:");
                string n = Console.ReadLine();
                Console.Write("Insira o salario:");
                double s = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(x,n,s));
            }
            Console.WriteLine();
            Console.Write("Insira o id do funcionario que pretende aumentar:");
            int num = int.Parse(Console.ReadLine());
            Funcionario emp = list.Find(x => x.Id == num);
            if (emp != null)
            {
                Console.Write("Escreva a Percentagem que pretende aumentar");
                double percentagem = double.Parse(Console.ReadLine());
                emp.Aumento(percentagem);
            }
            else
                Console.WriteLine("O utilizador nao existe!!");
            Console.WriteLine();
            Console.WriteLine("Lista actualizada:");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
