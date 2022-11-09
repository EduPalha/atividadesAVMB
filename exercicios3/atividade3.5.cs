/* 
5) Leia duas matrizes 2x3 de números double. 
Imprima a soma destas duas matrizes.
*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //popular matriz
            int k = 2, l = 3;
            int i, j;
            double[,] matrizA = new double[k,l];
            double[,] matrizB = new double[k,l];
            
            for(i = 0; i < k; i++)
            {
                for(j = 0; j < l; j++)
                {
                    Console.Write("Digite um nº A: ");
                    matrizA[i,j] = int.Parse(Console.ReadLine() + "");
                    Console.Write("Digite um nº B: ");
                    matrizB[i,j] = int.Parse(Console.ReadLine() + "");
                }
            }

            //visualização
            Console.WriteLine("");
            for(i = 0; i < k; i++){
                for(j = 0; j < l; j++)
                { 
                    Console.Write(matrizA[i,j] + matrizB[i,j] + "       ");
                }
                Console.WriteLine("");
            }
        }
    }
}
