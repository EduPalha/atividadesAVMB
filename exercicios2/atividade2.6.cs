/*
6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de 
leitura. Exemplo:
a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|

*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamVetor = 10;
            int[] vetor = new int[tamVetor];
            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º nº A: ");
                vetor[i] = int.Parse(Console.ReadLine() + "");
            }
            for (int i = tamVetor-1; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
