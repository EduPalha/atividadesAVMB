/*
16) Escreva um algoritmo para transpor uma matriz 
3x4 para outra 4x3. Transpor uma matriz significa 
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
                    Console.Write(mA[i,j] + "        ");
                }
                Console.WriteLine("\t");
            }
            // transpondo matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i)
                   
                }
            }

            // visualização da matriz transposta
            Console.WriteLine("\nMatrizes TRANSPOSTA:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(mA[i,j] + "        ");
                }
                Console.WriteLine("\t");
            }
        }
    }
}
