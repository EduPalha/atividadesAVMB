/* 
3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //popular matriz
            int k = 4, l = 4;
            int i, j;
            int[,] matriz = new int[k,l];
            
            for(i = 0; i < k; i++)
            {
                for(j = 0; j < l; j++)
                {
                    Console.Write("Digite um nº: ");
                    matriz[i,j] = int.Parse(Console.ReadLine() + "");
                }
            }

            //visualização
            for(i = 0; i < k; i++){
                for(j = 0; j < l; j++)
                { 
                    if(i == j)
                    {
                        Console.WriteLine("Valor " + i + "" + j + " é " + matriz[i,j]);
                    }
                }
            }
        }
    }
}
