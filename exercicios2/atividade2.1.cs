/*
1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então 
mostre na tela a quantidade de números pares e ímpares.
*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdPar = 0;
            int qtdImpar = 0;
            int tamVetor = 10;
            int[] vetor = new int[tamVetor];
            for(int i = 0; i < tamVetor; i++)
            {
                Console.Write("Digite o " + (i+1) + "º número: ");
                vetor[i] = int.Parse(Console.ReadLine() + "");
                if(vetor[i] %2 == 0)
                {
                    qtdPar++;
                }
                else
                {
                    qtdImpar++;
                }
            }

            Console.WriteLine("Existem " + qtdPar + " números PARES!");
            Console.WriteLine("Existem " + qtdImpar + " números ÍMPARES!");



        }
    }
}
