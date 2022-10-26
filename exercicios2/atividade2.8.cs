/*
8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após 
escreva a posição de cada número menor que zero desse vetor. Exemplo:
a.	lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
b.	escreve: 	|3|5|6|7|9|10|14|. . .
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
            List<int> lista = new List<int>();

            for (int i = 0; i < tam; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º nº: ");
                auxiliar = int.Parse(Console.ReadLine() + "");
                if(auxiliar < 0)
                {
                    lista.Add(i);
                }
                
            }
            
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Posição nº " + lista[i] + " é menor que zero!");
            }

            

        }
    }
}
