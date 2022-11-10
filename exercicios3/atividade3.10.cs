/*
10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, 
em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

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
            double[,] mB = new double[ordem, ordem];
            double[,] mAuxiliar = new double[ordem, ordem];
            int cimaA = 0, cimaB = 0, baixoA = 0, baixoB = 0;

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

            // popular matriz mB
            Console.WriteLine("\n\nMatriz B:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mB[i, j] = random.Next(0, 10);
                    Console.Write(mB[i,j] + "         ");
                }
                Console.WriteLine("\t");
            }

            // calcular média da mA + mB usando matriz auxiliar
            //Console.WriteLine("\n\nMédia das matrizes: ");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mAuxiliar[i,j] = (mA[i,j] + mB[i,j])/2;
                    //Console.Write(((mA[i,j] + mB[i,j])/2) + "            "); 
                }
                //Console.WriteLine("\t");
            }

            // calcular valores acima e abaixo da matriz A e B
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mAuxiliar[i,j] = (mA[i,j] + mB[i,j])/2;
                }
            }

            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    if(mAuxiliar[i,j] >= mA[i,j])
                    {
                        cimaA++;
                    }
                    else
                    {
                        baixoA++;
                    }

                    if(mAuxiliar[i,j] >= mB[i,j])
                    {
                        cimaB++;
                    }
                    else
                    {
                        baixoB++;
                    }
                    
                }
                
            }
            Console.WriteLine("\n " + cimaA + " valores acima da média na Matriz A!");
            Console.WriteLine(" " + baixoA + " valores abaixo da média na Matriz A!");
            Console.WriteLine(" " + cimaB + " valores acima da média na Matriz B!");
            Console.WriteLine(" " + baixoB + " valores abaixo da média na Matriz B!");

        }
    }
}
