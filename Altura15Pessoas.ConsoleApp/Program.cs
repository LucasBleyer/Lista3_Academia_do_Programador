using System;

namespace MenorMaiorAltura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] alturas = new double[3];
            double maior = 0;
            double menor = 0;

            for (int i = 0; i < alturas.Length; i++)
            {
                Console.Write("Digite a altura da pessoa "+i+": ");
                alturas[i] = Convert.ToDouble(Console.ReadLine());

                if (alturas[i]> maior)
                {
                    maior = alturas[i];
                }
                else
                {
                    menor = alturas[i];
                }
            }
            Console.WriteLine("A maior altura é: "+maior);
            Console.WriteLine("A menor altura é: "+menor);
        }
    }
}
