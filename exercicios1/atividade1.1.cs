using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[4];
            int i = 0;
            for(i = 0; i < 4; i++)
            {
                Console.Write("Digite o " + (i+1) + " º número inteiro?");
                int numero = int.Parse(Console.ReadLine());
                vetor[i] = numero;
            }

            int media = vetor.Sum();
            Console.WriteLine("Media dos números do vetor: " + media/vetor.Length);

            Console.WriteLine("Números acima da média: ");
            i = 0;
            do
            {
                if (vetor[i] > media / vetor.Length)
                {
                    Console.WriteLine("" + vetor[i]);
                }
                i++;
            } while (i < 4);

        }
    }
}
