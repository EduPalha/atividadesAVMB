/*
18 - Utilize o comando break no código abaixo de modo que o laço pare em 5.
*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Volta numero :" + i);
                if(i == 5)
                {
                    break;
                }
            }
        }
    }
}