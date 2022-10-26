/*
12 - Dado um limite inferior e superior, calcule a soma de todos os números pares 
contidos nesse intervalo.

*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um intervalo de valores que fique entre A - B!");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine() + "");
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine() + "");

            int soma = 0;
            for (int i = a; i <= b; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                    soma = soma + i;
                }
            }
            Console.WriteLine("Somatório dos números pares do intervalo: " + soma);
            
        }
    }
}
