using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("(-1 P/ Sair)Digite a renda total da família somada: ");
                float renda = float.Parse(Console.ReadLine() + "");
                if (renda == -1)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }
                Console.Write("Digite quantos integrantes tem na família: ");
                float pessoas = float.Parse(Console.ReadLine() + "");

                Console.WriteLine("Renda per capita da família: " + renda/pessoas + "\n");
            }
        }
    }
}
