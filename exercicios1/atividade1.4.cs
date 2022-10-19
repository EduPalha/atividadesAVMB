using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {

                Console.Write("(-1 Sair)Digite um número entre 0 a 9? ");
                n = int.Parse(Console.ReadLine());
                if (n == -1)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }
                Console.WriteLine("1-Português\n2-Inglês\n3-Espanhol?");
                Console.Write("Idioma para descrever: ");
                int idioma = (int.Parse(Console.ReadLine()))*10;

                string[] nDescritivo = { 
                    "", "", "", "", "", "", "", "", "", "",
                    "Zero", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", 
                    "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", 
                    "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve" };

                if (n > -1)
                {
                    Console.WriteLine("A descrição do número é '" + nDescritivo[(n)+(idioma)] + "' !");
                }
                else
                {
                    Console.WriteLine("Número inválido!");
                    break;
                }
            }
            

        }
    }
}
