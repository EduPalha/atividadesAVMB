/*
12) Escreva um programa que leia os valores de uma matriz 
4x3, e em seguida mostre na tela apenas os valores cuja 
soma dos índices (i+j) seja um número par.
*/

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[,] mA = new double[4, 3];

            // popular matriz mA
            Console.WriteLine("\nMatriz A:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mA[i, j] = random.Next(0, 10);
                    Console.Write(mA[i,j] + "         ");
                }
                Console.WriteLine("\t");
            }

            // nova matriz
            Console.WriteLine("\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if((i+j) %2 == 0){
                        Console.WriteLine(mA[i,j] + "            ");
                    }
                }
                Console.WriteLine("\t");
            }
        }
    }
}
