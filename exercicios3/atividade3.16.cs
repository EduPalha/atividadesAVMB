/*
16) Escreva um algoritmo para transpor uma matriz 
4x3 para outra 3x4. Transpor uma matriz significa 
transformar suas linhas em colunas e vice-versa.
*/

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[,] mA = new double[4, 3];
            double[,] mB = new double[3, 4];

            // populando matriz 
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mA[i, j] = random.Next(0, 10);
                    Console.Write(mA[i, j] + "        ");
                }
                Console.WriteLine("\t");
            }

            // transpondo matriz

            mB[0, 0] = mA[0, 0];
            mB[0, 1] = mA[1, 0];
            mB[0, 2] = mA[2, 0];
            mB[0, 3] = mA[3, 0];

            mB[1, 0] = mA[0, 1];
            mB[1, 1] = mA[1, 1];
            mB[1, 2] = mA[2, 1];
            mB[1, 3] = mA[3, 1];

            mB[2, 0] = mA[0, 2];
            mB[2, 1] = mA[1, 2];
            mB[2, 2] = mA[2, 2];
            mB[2, 3] = mA[3, 2];

            // visualização da matriz transposta
            Console.WriteLine("\nMatrizes TRANSPOSTA:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(mB[i, j] + "        ");
                }
                Console.WriteLine("\t");
            }
        }
    }
}
