/*
17 - Modifique a questão anterior de modo que seja perguntado para o usuário se ele 
quer que os números apareçam em ordem crescente ou decrescente.

*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um intervalo de valores que fique entre A - B!");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine() + "");
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine() + "");
            Console.Write("Você quer ondem crescente(+) ou decrescente(-): ");
            string ordem = (Console.ReadLine() + "");
            
            var selecao = new List<int>();

            for (int i = a; i <= b; i++)
            {
                selecao.Add(i);
            }

            try 
            { 
                if (ordem.Equals("+"))
                {
                    for (int i = 0; i < selecao.Count; i++)
                    {
                        Console.WriteLine(selecao[i]);
                    }
                }
                else if (ordem.Equals("-"))
                {
                    int qtd = selecao.Count - 1;
                    for (int i = qtd; i >= 0; i--)
                    {
                        Console.WriteLine(selecao[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }
            catch
            {
                Console.WriteLine("Erro!");
            }

        }
    }
}
