/* 
6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
Random random = new Random();
int randomNumber = random.Next(0, 100);
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
            int k = 4, l = 4;
            int i, j;
            double[,] matriz = new double[k,l];
            
            for(i = 0; i < k; i++)
            {
                for(j = 0; j < l; j++)
                {
                    matriz[i,j] = random.Next(0, 9);
                }
            }

            //visualização
            for(i = 0; i < k; i++){
                for(j = 0; j < l; j++)
                { 
                    Console.Write(matriz[i,j] + "       ");
                }
                Console.WriteLine("");
            }
        }
    }
}
