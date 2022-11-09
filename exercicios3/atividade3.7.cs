/* 
7) Leia duas matrizes A e B com 3x3 elementos. Construir uma 
matriz C, onde cada elemento de C é a subtração do elemento 
correspondente de A com B.
*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //popular matriz
            Random random = new Random();
            int k = 3, l = 3;
            int i, j;
            double[,] matrizA = new double[k,l];
            double[,] matrizB = new double[k,l];
            
            for(i = 0; i < k; i++)
            {
                for(j = 0; j < l; j++)
                {
                    matrizA[i,j] = random.Next(0, 100);
                    matrizB[i,j] = random.Next(0, 100);
                    //Console.WriteLine(matrizA[i,j] + " - " + matrizB[i,j]);
                }
            }

            //visualização
            for(i = 0; i < k; i++){
                for(j = 0; j < l; j++)
                { 
                    Console.Write(matrizA[i,j] - matrizB[i,j] + "         ");
                }
                Console.WriteLine("");
            }
        }
    }
}
