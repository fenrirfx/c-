using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o numero de linhas:");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Insira o numerode colunas:");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];

            Console.WriteLine("Insira os numeros da matriz:");
            for (int i = 0; i < l; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Insira um numero:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (mat[i, j] == num)
                    {
                        if (j >= 1)
                            Console.WriteLine("Esquerda:" + mat[i, j - 1]);
                        if (i >= 1)
                            Console.WriteLine("Acima:" + mat[i - 1, j]);
                        if (j < c - 1)
                            Console.WriteLine("Direita:" + mat[i, j + 1]);
                        if (i < l - 1)
                            Console.WriteLine("Abaixo:" + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}
