using System;

namespace SomaMultiplosDe3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 0; i < 500; i++)
            {
                int resto_par = i % 2;
                int resto_impar = i % 3;

                if (resto_par != 0 && resto_impar == 0)
                {
                    soma = soma + i;
                }
            }
            Console.Write("Soma dos multiplos de 3 do 1 a 500: "+soma);
            Console.ReadLine();
        }
    }
}