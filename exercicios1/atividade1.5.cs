/*
5 - Escreva um programa que peça para o usuário digitar uma letra, e então 
o programa imprime na tela se a letra é uma vogal ou consoante. Utilize no 
máximo 6 cases em um switch-case para resolver esse exercício.
*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] vocabulario = { "a", "e", "i", "o", "u", "b",
                    "c", "d", "f", "g", "h", "j", "k", "l", "m", "n",
                    "p", "q", "r", "s", "t", "v", "x", "y", "z" };

                Console.Write("(0 Sair)Digite uma letra? ");
                string entradaDado = Console.ReadLine() + "";
                entradaDado = entradaDado.ToLower();

                if (entradaDado.Equals("0"))
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }

                int tamanho = vocabulario.Length;
                for(int i = 0; i < tamanho; i++)
                {
                    if (!entradaDado.Equals(vocabulario[i]))
                    {
                        //Console.WriteLine("Posição " + i + " da letra "+ vocabulario[i]);
                        Console.WriteLine("Entrada inválida");
                        break;
                    }
                }
                
                char opcao = char.Parse(entradaDado);
                switch (opcao)
                {
                    case 'a':
                        Console.WriteLine("---> a é VOGAL!");
                        break;
                    case 'e':
                        Console.WriteLine("---> e é VOGAL!");
                        break;
                    case 'i':
                        Console.WriteLine("---> i é VOGAL!");
                        break;
                    case 'o':
                        Console.WriteLine("---> o é VOGAL!");
                        break;
                    case 'u':
                        Console.WriteLine("---> u é VOGAL!");
                        break;
                    default:
                        Console.WriteLine("---> " + opcao + " é CONSOANTE!");
                        break;
                }
            }

        }
    }
}
