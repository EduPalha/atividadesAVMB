/*
5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre 
o menor elemento e a sua posição.
*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tamVetor = 5;
            int[] vetorA = new int[tamVetor];
            int auxiliar = 99999999;
            int posicao = 0;
            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º nº A: ");
                vetorA[i] = int.Parse(Console.ReadLine() + "");
                if (vetorA[i] < auxiliar)
                {
                    auxiliar = vetorA[i];
                    posicao = i;
                }
            }

            Console.WriteLine("Menor valor nesse vetor é " + auxiliar + " na posição " + posicao + " !");

        }
    }
}
