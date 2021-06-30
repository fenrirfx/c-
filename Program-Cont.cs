using System;

namespace FinalEx
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Conta p;
            

            Console.Write("Insira o numero da conta:");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Insira o Nome:");
            string nome = (Console.ReadLine());
            Console.Write("Haverá depósito inicial?:");
            char deposito = char.Parse(Console.ReadLine());
            if (deposito == 'S' || deposito == 's')
            {
                Console.Write("Valor do Depósito (s/n):");
                double valor = double.Parse(Console.ReadLine());
                p = new Conta(conta, nome, valor);
            }
            else
            {
                p = new Conta(conta, nome);
            }
            
            
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(p);
            Console.WriteLine("Insira a quantia para depositar:");
            double valor1 = double.Parse(Console.ReadLine());
            p.Deposit(valor1);
            Console.WriteLine("Dados Actualizados: ");
            Console.WriteLine(p);
            Console.WriteLine("Insira a quantia a retirar:");
            valor1 = double.Parse(Console.ReadLine());
            p.Levantamento(valor1);
            Console.WriteLine("Dados Actualizados: ");
            Console.WriteLine(p);

        }
    }
}
