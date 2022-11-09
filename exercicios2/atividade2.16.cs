/* 
16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um 
vetor para cada uma das operações:
•	A união de X com Y
•	A diferença entre X e Y
•	A interseção entre X e Y
Escreva o vetor resultado de cada uma das operações.
*/
using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int qtd = 10; //quantidade de valores na lista/vetor
            List<int> listaX = new List<int>();
            List<int> listaY = new List<int>();
            List<int> listaZ = new List<int>(); //usada apenas para interseção

            int i = 1;
            // inserir valores que serão adicionados a lista
            while(i <= qtd)
            {
                Console.Write("Digite o " + i + " X º nº: ");
                listaX.Add(int.Parse(Console.ReadLine() + ""));
                Console.Write("Digite o " + i + " Y º nº: ");
                listaY.Add(int.Parse(Console.ReadLine() + ""));
                i++;
            }

            Console.WriteLine("União dos vetores...");
            for (i = 0; i < listaX.Count; i++)
            {
                Console.Write((listaX[i] + listaY[i]) + " ; ");
                listaY.Add(listaX[i]);
            }
        
            Console.WriteLine("\nDiferenção dos vetores...");
            for (i = 0; i < listaX.Count; i++)
            {
                Console.Write((listaX[i] - listaY[i]) + " ; ");
            }    

            
            // i = 0;       
            // int y = 0;
            // int contador = 1; 
            
            // while(contador <= qtd){
            //     if(listaX[i] == listaY[y]){
            //         listaZ.Add(listaX[i]); 
            //     }
                
            //     if (i == qtd-1){
            //         contador++;
            //         i = 1;
            //         y++;
            //         continue;
            //     }
            //     i++;
            // }

            for (i = 0; i < listaX.Count; i++)
            {
                if(listaX[i] == listaY[i]){
                    listaZ.Add(listaX[i]); 
                }
            }

            Console.WriteLine("\nInterseção dos vetores...");
            for (i = 0; i < listaZ.Count; i++)
            {
                Console.Write((listaZ[i]) + " ; ");
            }




        }
    }
}