/* 
2) Solicite ao usuário, preencher uma Matriz 3x3
Informe ao usuário:
*A soma dos elementos de cada linha
	-Ex: Linha 1: 30
	     Linha 2: 17
*A soma dos elementos de cada coluna
	-Ex: Coluna 1: 23
	     Coluna 2: 36
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
            int soma1 = 0, soma2 = 0, soma3 = 0, 
                soma4 = 0, soma5 = 0, soma6 = 0;
            for(i = 0; i < k; i++){
                for(j = 0; j < l; j++)
                { 
                    if(i == 0)
                    {
                        soma1 = soma1 + matriz[0,j];
                    }
                    else if(i == 1)
                    {
                        soma2 = soma2 + matriz[1,j];
                    }
                    else if (i == 2)
                    {
                        soma3 = soma3 + matriz[2,j];
                    }
                    else
                    {
                        continue;
                    }

                    if(j == 0)
                    {
                        soma4 = soma4 + matriz[i,0];
                    }
                    else if(j == 1)
                    {
                        soma5 = soma5 + matriz[i,1];
                    }
                    else if(j == 2)
                    {
                        soma6 = soma6 + matriz[i,2];
                    }
                    else
                    {
                        continue;
                    }
                         
                }
            }

            Console.WriteLine("Soma Linha 1: " + soma1);
            Console.WriteLine("Soma Linha 2: " + soma2);
            Console.WriteLine("Soma Linha 3: " + soma3); 
            Console.WriteLine("Soma Coluna 1: " + soma4); 
            Console.WriteLine("Soma Coluna 2: " + soma5); 
            Console.WriteLine("Soma Coluna 3: " + soma6);

        }
    }
}
