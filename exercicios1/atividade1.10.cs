/*
10 - Faça um programa que leia um número e apresente a tabuada deste número.
*/
using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("(-1 P/ Sair)Digite um número para descobrir a taubuada: ");
                int numero = int.Parse(Console.ReadLine() + "");
                if (numero == -1)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }
                Console.WriteLine(" 1 x " + numero + " = " + numero * 1 +
                                "\n 2 x " + numero + " = " + numero * 2 +
                                "\n 3 x " + numero + " = " + numero * 3 +
                                "\n 4 x " + numero + " = " + numero * 4 +
                                "\n 5 x " + numero + " = " + numero * 5 +
                                "\n 6 x " + numero + " = " + numero * 6 +
                                "\n 7 x " + numero + " = " + numero * 7 +
                                "\n 8 x " + numero + " = " + numero * 8 +
                                "\n 9 x " + numero + " = " + numero * 9 +
                                "\n 10 x " + numero + " = " + numero * 10);
            }
        }
    }
}