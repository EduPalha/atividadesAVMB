/*
11) Leia uma matriz A de tipo double de dimensão 3x3, 
crie uma nova matriz resultante da divisão dos elementos 
da matriz A pela soma dos seus indices.
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
            double[,] mAuxiliar = new double[ordem, ordem];

            // popular matriz mA
            Console.WriteLine("\nMatriz A:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mA[i, j] = random.Next(0, 10);
                    Console.Write(mA[i,j] + "         ");
                }
                Console.WriteLine("\t");
            }

            // nova matriz
            Console.WriteLine("\n\nNova matriz: ");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mAuxiliar[i,j] = mA[i,j]/(i+j);
                    Console.Write(mAuxiliar[i,j] + "               "); 
                }
                Console.WriteLine("\t");
            }

        }
    }
}
