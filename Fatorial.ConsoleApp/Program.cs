using System;

namespace Fatorial.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número a ser calculado no fatorial: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int fat = 1;
            for (int i = 0; i < a; i++)
            {
                fat = (a - i) * fat;
            }
            Console.WriteLine("O fatorial de "+a+" é: "+fat);
            Console.ReadLine(); 
        }
    }
}