/* 
12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, 
fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever 
a mensagem "O número fornecido não existe no vetor!".
*/
using System;
using System.Collections.Generic;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int tam = 5;
            int[] vetorV = new int[tam];

            // inserir valores que serão adicionados ao vetorV
            for (x = 0; x < tam; x++)
            {
                Console.Write("Digite o " + (x + 1) + "º nº: ");
                vetorV[x] = int.Parse(Console.ReadLine() + "");
            }

            //pergunta para o usuário
            Console.Write("Digite um nº para consultar a existência dele no vetorV: ");
            int numero = int.Parse(Console.ReadLine() + "");

            // visualização dos elementos do vetor 
            int aux = 0;
            for (x = 0; x < tam; x++)
            {
                if(numero == vetorV[x]){
                    Console.WriteLine("Número digitado está na posição: " + x);
                    aux++;
                    break;
                }
            }
            if(aux==0){
                Console.WriteLine("Número não encontrado no vetor!");
            }

        }
    }
}