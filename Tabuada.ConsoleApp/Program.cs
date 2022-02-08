using System;

namespace Tabuada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para Tabuada: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int soma = i * n;
                Console.WriteLine(i+" x "+n+" = "+soma);
            }
        }
    }
}
