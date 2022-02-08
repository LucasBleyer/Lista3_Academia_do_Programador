using System;

namespace Tabuada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 0 a 10 para Tabuada: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int tabuada = i * n;
                Console.WriteLine(i+" x "+n+" = "+tabuada);
            }
            Console.ReadLine();
        }
    }
}
