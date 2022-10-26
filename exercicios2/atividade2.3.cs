/*
3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então 
mostre na tela o índice da posição dos valores correspondentes a números primos.
*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {

        private static int ehPrimo(int numero)
        {
            int divisores = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
                return 1;
            else
                return 0;
        
         }

        static void Main(string[] args)
        {
            int tamVetor = 5;
            int[] vetor = new int[tamVetor];
            List<int> selecionados = new List<int>();

            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º nº A: ");
                vetor[i] = int.Parse(Console.ReadLine() + "");

                if (ehPrimo(vetor[i]) == 1)
                {
                    selecionados.Add(i);

                }
            }
            Console.WriteLine("");
            for (int i = 0; i < selecionados.Count; i++)
            {
                Console.WriteLine(selecionados[i]);
            }


        }
    }
 }