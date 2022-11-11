/*
15) Escreva um programa em C# para ler os valores e somar 
duas matrizes 4 x 4. Mostrar a matriz resultante.
*/

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ordem = 4;
            double[,] mA = new double[ordem, ordem];
            double[,] mB = new double[ordem, ordem];

            // populando matriz A
            Console.WriteLine("\nMatriz A:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mA[i, j] = random.Next(0, 10);
                    Console.Write(mA[i,j] + "        ");
                }
                Console.WriteLine("\t");
            }
            // populando matriz B
            Console.WriteLine("\nMatriz B:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mB[i, j] = random.Next(0, 10);
                    Console.Write(mB[i,j] + "        ");
                }
                Console.WriteLine("\t");
            }

            // visualização da soma das matrizes 4x4
            Console.WriteLine("\nMatrizes SOMADAS:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    Console.Write((mA[i,j] + mB[i,j]) + "        ");
                }
                Console.WriteLine("\t");
            }
        }
    }
}
