/*
2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então 
realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamVetor = 20;
            int[] vetorA = new int[tamVetor];
            int[] vetorB = new int[tamVetor];
            int[] vetorC = new int[tamVetor];
            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º nº A: ");
                vetorA[i] = int.Parse(Console.ReadLine() + "");
                Console.Write("Digite o " + (i + 1) + "º nº B: ");
                vetorB[i] = int.Parse(Console.ReadLine() + "");
                vetorC[i] = vetorA[i] + vetorB[i];

            }
            Console.WriteLine("Valores do vetor C...");
            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Posição " + (i + 1) + "º: " + vetorC[i]);
            }

        }
    }
}
