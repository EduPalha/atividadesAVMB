/*
9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer 
ao usuário e pesquise na matriz se o número existe.  
Caso, seja verdade imprima a mensagem:  “O número existe no vetor” 
, caso contrário “Número inexistente”.

*/

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ordem = 3;
            double[,] m = new double[ordem, ordem];

            Console.Write("\nDigite um número: ");
            int numero = int.Parse(Console.ReadLine() + "");

            //popular matriz m
            Console.WriteLine("\n\nMatriz:\n");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    m[i, j] = random.Next(0, 10);
                    Console.Write(m[i,j] + "         ");
                }
                Console.WriteLine("\t");
            }

            int auxiliar = 0;
            //descobrir elemento na matriz
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    if(numero == m[i,j]){
                        Console.Write("\nExiste o número " + numero + " na posição M" + i + j + " !");
                        auxiliar++;
                    }
                }
            }

            if(auxiliar == 0){
                Console.WriteLine("\nNão existe o número na matriz!");
            }
            


        }
    }
}
