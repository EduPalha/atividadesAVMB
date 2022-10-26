/*
19 - Utilize o comando continue de modo que as voltas de número 5 e 7 sejam puladas 
no código da questão anterior.
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
                if(i == 5 || i == 7)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Volta numero :" + i);
                }
                
            }
        }
    }
}
