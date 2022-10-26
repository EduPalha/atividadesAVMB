/*
20 - Faça um algoritmo para calcular e mostrar o resultado dos 50 primeiros elementos da série
1000/1   -   997/2   +   994/3   -   991/4   +   ...
*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0;
            double valorInicial = 1000;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    soma = soma + valorInicial/i;
                }
                else
                {
                    soma = soma - valorInicial / i;
                }
                valorInicial = valorInicial - 3;
            }
            Console.WriteLine("O somatório dos primeiros 50 elementos da série é " + soma*(-1) + " !");
        }
    }
}
