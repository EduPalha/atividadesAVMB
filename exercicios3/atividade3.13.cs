/*
13) Escreva um programa que leia uma matriz de ordem 5 
(ou seja, 5x5) e verifique se a soma dos elementos da 
diagonal principal é igual a soma dos elementos da 
diagonal secundária.
*/

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ordem = 3;
            double[,] mA = new double[ordem, ordem];
            double soma1 = 0, soma2 = 0;

            // para calcular diagonal secundaria a soma de i + j em uma matriz de ordem 5 é 4
            // para outras matrizes de ordens diferentes basta ser ordem - 1
            int auxiliar = ordem - 1;


            // popular matriz mA e somando diagonal principal e secundaria enquanto popula
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mA[i, j] = random.Next(0, 10);
                    Console.Write(mA[i,j] + "         ");
                    if(i == j)
                    {
                        soma1 = soma1 + mA[i,j];
                    }

                    if((i + j) == auxiliar)
                    {
                        soma2 = soma2 + mA[i,j];
                    }
                }
                Console.WriteLine("\t");
            }

            Console.WriteLine("\nSoma da Diagonal Principal: " + soma1 + " !");
            Console.WriteLine("Soma da Diagonal Secundária: " + soma2 + " !");

        }
    }
}
