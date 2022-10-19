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
                string letra= Console.ReadLine();

                //int sair = int.Parse(letra);
                //if (sair == 0)
                //{
                //    Console.WriteLine("Saindo do sistema...");
                //    break;
                //}
                
                for(int i = 0; i < vocabulario.Length; i++)
                {
                    if (letra.Equals(vocabulario[i]))
                    {
                        //Console.WriteLine(letra);
                        //Console.WriteLine("Não é um caractere, do tipo letra, válido!");
                        //break;
                    }
                }

                //letra = letra.ToLower();
                //char opcao = char.Parse(letra);

                //switch (opcao) 
                //{
                //    case 'a':
                //        Console.WriteLine("---> a é VOGAL!");
                //        break;
                //    case 'e':
                //        Console.WriteLine("---> e é VOGAL!");
                //        break;
                //    case 'i':
                //        Console.WriteLine("---> i é VOGAL!");
                //        break;
                //    case 'o':
                //        Console.WriteLine("---> o é VOGAL!");
                //        break;
                //    case 'u':
                //        Console.WriteLine("---> u é VOGAL!");
                //        break;
                //    default:
                //        Console.WriteLine("---> " + opcao + " é CONSOANTE!");
                //        break;
                //}
            }

        }
    }
}
