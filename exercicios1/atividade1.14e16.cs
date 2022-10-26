/*
14 e 16- Escreva um programa que pergunte para o usuário os valores iniciais e finais 
da contagem, e então mostre todos os valores desse intervalo.
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

            var selecao = new List<int>();

            for (int i = a; i <= b; i++)
            {
                selecao.Add(i);
                
            }

            for (int i = 0; i < selecao.Count; i++)
            {
                Console.WriteLine(selecao[i]);   
            }

        }
    }
}
