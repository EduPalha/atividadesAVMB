using System;

namespace atividadeAVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j; //quantidade de valores em i
            int[,] matriz = new int[5,3];
            
            for(i = 0; i < 5; i++){
                for(j = 0; j < 3; j++){
		    // visualizar cada uma das posições da matriz
                    Console.WriteLine("[" + i + " , " + j + "]");
                }
            }
   
        }
    }
}