/* 
15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos 
do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do 
primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por 
exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.
*/
using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();

            // inserir valores que serão adicionados a lista
            while(x <= 10)
            {
                Console.Write("Digite o " + x + "º nº: ");
                int numero = int.Parse(Console.ReadLine() + "");
                lista1.Add(numero);
                x++;
            }

            Console.WriteLine("Ordenado...");
            for (x = 0; x < lista1.Count; x++)
            {
                Console.Write(lista1[x] + " ; ");
                lista2.Add(lista1[x]);
            }
        
            Console.WriteLine("\nOrdem Inversa...");
            for (x = lista2.Count - 1; x >= 0 ; x--)
            {
                Console.Write(lista2[x] + " ; ");
            }          
        }
    }
}