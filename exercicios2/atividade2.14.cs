/* 
14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de 
números. Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem 
em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o 
primeiro.
*/
using System;
using System.Collections.Generic;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            List<int> lista = new List<int>();

            // inserir valores que serão adicionados a lista
            while(x <= 50)
            {
                Console.Write("Digite o " + x + "º nº: ");
                int numero = int.Parse(Console.ReadLine() + "");
                lista.Add(numero);
                x++;
            }

            // escolha das opções do MENU
            while(true)
            {
                Console.Write("\nMENU \n 0 - Sair do sistema \n 1 - Mostrar vetor na ordem \n 2 - Mostrar vetor na ordem inversa \n Opção: ");
                int numero = int.Parse(Console.ReadLine() + "");
                //modo de saida
                if(numero == 0)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;        
                }
                else if (numero == 1)
                {
                    for (x = 0; x < lista.Count; x++)
                    {
                    Console.WriteLine("Posição " + x + " aparece o " + lista[x]);
                    }
                
                }
                else if (numero == 2)
                {
                    for (x = lista.Count - 1; x >= 0 ; x--)
                    {
                    Console.WriteLine("Posição " + x + " aparece o " + lista[x]);
                    }
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }
            
        }
    }
}