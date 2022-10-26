/*
21 - Faça um programa que leia um número n e imprima se ele é primo ou não. 
(um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)
*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {

        private static int ehPrimo(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                    return 0;
            }
            return 1;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("(-1 p/ SAIR) Digite um número para verificar se ele é primo ou não: ");
                int numero = int.Parse(Console.ReadLine() + "");
                if (numero == -1)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }

                for (int i = 2; i <= numero; i++)
                {
                    if (ehPrimo(i) == 1)
                    {
                        if(i == numero)
                        {
                            Console.WriteLine(i + " É primo!");
                            break;

                        }  
                    }
                    else
                    {
                        if (i == numero)
                        {
                            Console.WriteLine(i + " NÃO É primo!");
                            break;

                        }
                    }

                }
            }
        }
    }
}
