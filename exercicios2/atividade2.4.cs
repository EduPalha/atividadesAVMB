/*
4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação 
dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor 
resultante.
*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamVetor = 10;
            int[] vetorA = new int[tamVetor];
            int[] vetorB = new int[tamVetor];
            int[] vetorC = new int[tamVetor];
            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º nº A: ");
                vetorA[i] = int.Parse(Console.ReadLine() + "");
                Console.Write("Digite o " + (i + 1) + "º nº B: ");
                vetorB[i] = int.Parse(Console.ReadLine() + "");
                vetorC[i] = vetorA[i] * vetorB[i];

            }
            Console.WriteLine("Valores do vetor C...");
            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Posição " + (i + 1) + "º: " + vetorC[i]);
            }

        }
    }
}
