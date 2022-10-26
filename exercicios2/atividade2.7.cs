/*
7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e 
escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|
*/

using System;
using System.Collections.Generic;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tam = 6;
            int auxiliar;
            List<int> listaPar = new List<int>();
            List<int> listaImpar = new List<int>();
            

            for (int i = 0; i < tam; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º nº: ");
                auxiliar = int.Parse(Console.ReadLine() + "");
                if (auxiliar % 2 == 0)
                {
                    listaPar.Add(auxiliar);
                }
                else
                {
                    listaImpar.Add(auxiliar);
                }
            }

            listaPar.AddRange(listaImpar);
            Console.WriteLine(String.Join(",", listaPar));

        }
    }
}
