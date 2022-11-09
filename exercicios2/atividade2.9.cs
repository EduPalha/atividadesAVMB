/* 
9. Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida 
ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.
*/
using System;
using System.Collections.Generic;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tam = 10;
            int[] vetor = new int[tam];

            // inserir valores que serão adicionados ao vetor
            for (int x = 0; x < tam; x++)
            {
                Console.Write("Dxgite o " + (x + 1) + "º nº: ");
                vetor[x] = int.Parse(Console.ReadLine() + "");
            }

            // mecanismo de ordenação
            int controleSequencia = 0;
            int i = 1;
            while(controleSequencia <= tam)
            {
                if(i > 0 && i < tam && vetor[i] < vetor[i-1])
                {
                    //Console.WriteLine("troca " + vetor[i] + "->" + vetor[i-1]);
                    int aux = vetor[i];
                    vetor[i] = vetor[i-1];
                    vetor[i-1] = aux;
                } 
                else
                {
                    if(i>=tam)
                    {
                        i = 1;
                        controleSequencia++;
                        continue;
                    }
                }
                i++;
            }
            // visualização dos elementos do vetor ordenado
            for (i = 0; i < tam; i++)
            {
                Console.Write(vetor[i] + " ; ");
            }
            
            
        }
    }
}