/*
17) Desafio: Fazer um algoritmo que leia uma 
matriz de 10 linhas por 10 colunas e escreva 
o elemento minimax, ou seja,o menor elemento 
da linha onde se encontra o maior elemento da 
matriz. Escreva também a linha e a coluna 
onde foi encontrado.
*/

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ordem = 10;
            double min = 999999, max = -999999, linha = 11;
            double[,] mA = new double[ordem, ordem];

            // populando matriz 
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    mA[i, j] = random.Next(0, 50);
                    if (mA[i, j] > max)
                    {
                        max = mA[i, j];
                        linha = i;
                    }
                    Console.Write(mA[i, j] + "     ");
                }
                Console.WriteLine("\t");
            }

            // achando o menor elemento da linha            
            Console.WriteLine("\nMenor elemento da linha onde se encontra o maior valor M: ");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    if (linha == i){
                        if (mA[i,j] < min){
                            min = mA[i,j];
                        }
                    }
                }
            }
            Console.WriteLine("Maior valor da Matriz: " + max);
            Console.WriteLine("Menor elemento da linha " + linha + ": " + min);

        }
    }
}
