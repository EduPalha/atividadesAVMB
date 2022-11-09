/* 
4) Popule uma matriz 5x5 e informe:
-Quantos números são pares
-Quantos números são impares
-Quantos números são positivos
-Quantos números são negativos
-Quantos zeros existem!
*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //popular matriz
            int k = 3, l = 3;
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
            int par = 0, impar = 0, zero = 0, 
                positivo = 0, negativo = 0;
            for(i = 0; i < k; i++){
                for(j = 0; j < l; j++)
                { 
                    if(matriz[i,j] % 2 == 0 )
                    {
                        par++;
                    }
                    else {
                        impar++;
                    }

                    if(matriz[i,j] > 0){
                        positivo++;
                    }
                    else if(matriz[i,j] == 0){
                        zero++;
                    }
                    else {
                        negativo++;
                    }
                }
            }
            Console.WriteLine("\nNºs PARES: " + par);
            Console.WriteLine("Nºs IMPARES: " + impar);
            Console.WriteLine("Nºs POSITIVOS: " + positivo);
            Console.WriteLine("Nºs ZEROS: " + zero);
            Console.WriteLine("Nºs NEGATIVOS: " + negativo);
            
        }
    }
}
