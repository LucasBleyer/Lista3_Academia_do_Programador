//Exercício 5:
//• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
//valores do cálculo de A! e o seu resultado.
//Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//• Pesquise sobre “fatorial”
using System;

namespace Fatorial.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quer saber o fatorial de qual numero ?");
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
