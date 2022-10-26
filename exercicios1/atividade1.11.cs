/*
11 - Escreva um programa que gera números entre 1000 e 1999 e mostra aqueles que 
divididos por 11 dão resto 5.
*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando número entre 1000 e 1999 divididos por 11 e resto 5:");

            for (int i = 1000; i < 2000; i++)
            {
                int auxiliar = i / 11;
                auxiliar = i - (auxiliar * 11);
                if(auxiliar == 5)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
