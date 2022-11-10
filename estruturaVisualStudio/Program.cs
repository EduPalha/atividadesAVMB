/*
14) Escreva um programa que leia uma matriz de ordem 5 
e verifique se os elementos da diagonal principal (da 
esquerda para a direita) são os mesmos da diagonal 
secundária (direita pra esquerda).
*/

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ordem = 5;
            double[,] mA = new double[ordem, ordem];

            // populando matriz 
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mA[i, j] = random.Next(0, 10);
                    Console.Write(mA[i,j] + "         ");
                }
                Console.WriteLine("\t");
            }

            // comparando diagonal principal e secundaria
            if(mA[0,0] == mA[0,4])
            {
                Console.WriteLine("A posição m00 e m04 tem o mesmo valor " + mA[0,0]);
            }
            else if(mA[1,1] == mA[1,3])
            {
                Console.WriteLine("A posição m11 e m13 tem o mesmo valor " + mA[0,0]);
            }
            else if(mA[3,3] == mA[3,1])
            {
                Console.WriteLine("A posição m33 e m31 tem o mesmo valor " + mA[0,0]);
            }
            else if(mA[4,0] == mA[4,4])
            {
                Console.WriteLine("A posição m40 e m44 tem o mesmo valor " + mA[0,0]);
            }
            else
            {
                Console.WriteLine("Não existem valores da matriz principal = a matriz secundária na mesma posição da diagonal!");
            }
            
        }
    }
}
