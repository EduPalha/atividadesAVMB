/*
13 - Escreva um algoritmo que pergunte ao usuário qual o valor inicial da contagem, 
qual o valor final, e se ele deseja pular os valores pares ou os valores ímpares. 
Após, faça um laço de repetição que mostre os valores desejados.
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
            Console.Write("Deseja pular os valores pares(Digite 2) ou ímpares(Digite 1)? Digite 0 caso não queira!  ");
            int escolha = int.Parse(Console.ReadLine() + "");

            var selecao = new List<int>();

            for (int i = a; i <= b; i++)
            {
                if (escolha == 0)
                {
                    Console.WriteLine("escolha = 0");
                    selecao.Add(i);
                }
                else if (escolha == 1)
                {
                    if(i % 2 != 0)
                    {
                        Console.WriteLine("escolha = 1");
                        selecao.Add(i);
                    }
                }
                else if (escolha == 2)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("escolha = 2");
                        selecao.Add(i);
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    break;
                }

            }

            for (int i = 0; i < selecao.Count; i++)
            {
                Console.WriteLine(selecao[i]);   
            }

        }
    }
}
