/* 
13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes 
aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando for 
digitado -1 ou quando atingir o máximo de posições do vetor.
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

            while(x <= 100)
            {
                // inserir valores que serão adicionados a lista
                Console.Write("(-1 p/ SAIR) Digite o " + x + "º nº: ");
                int numero = int.Parse(Console.ReadLine() + "");
                //modo de saida
                if(numero == -1){
                    Console.WriteLine("Saindo do sistema...");
                    break;        
                }
                // apenas numero positivo itera e incrementa o i
                if(numero > 0){
                    lista.Add(numero);
                    x++;
                }
            }

            // visualização dos elementos da lista
            for (x = 0; x < lista.Count; x++)
            {
                if(lista[x] == 2 || lista[x] == 4 || lista[x] == 8)
                {
                    Console.WriteLine("Na posição " + x + " aparece o " + lista[x] + " !");
                }
            }
            
        }
    }
}