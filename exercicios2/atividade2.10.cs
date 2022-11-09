/* 
10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, 
substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

*/
using System;
using System.Collections.Generic;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tam = 20;
            int[] vetorA = new int[tam];
            //int[] vetorB = new int[tam];

            // inserir valores que serão adicionados ao vetorA
            for (int x = 0; x < tam; x++)
            {
                Console.Write("Digite o " + (x + 1) + "º nº: ");
                vetorA[x] = int.Parse(Console.ReadLine() + "");
            }

            // visualização dos elementos do vetor 
            for (int i = 0; i < tam; i++)
            {
                if(vetorA[i] == 0){
                    vetorA[i] = 2;
                }
                Console.Write(vetorA[i] + " ; ");
            }
        }
    }
}