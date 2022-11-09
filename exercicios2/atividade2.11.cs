/* 
11.	Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos 
do vetor e após escrever os elementos na ordem inversa.
*/
using System;
using System.Collections.Generic;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tam = 5;
            int[] vetor = new int[tam];

            // inserir valores que serão adicionados ao vetorA
            for (int x = 0; x < tam; x++)
            {
                Console.Write("Digite o " + (x + 1) + "º nº: ");
                vetor[x] = int.Parse(Console.ReadLine() + "");
            }

            // visualização dos elementos do vetor 
            for (int i = tam-1; i >= 0; i--)
            {
                Console.Write( vetor[i]+ " ; ");
                
            }
        }
    }
}