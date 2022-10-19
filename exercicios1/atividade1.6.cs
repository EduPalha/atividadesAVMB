using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                    Console.Write("Digite a hora? ");
                    int hora = int.Parse(Console.ReadLine() + "");
                    if (hora < 0 || hora > 23)
                    {
                        Console.WriteLine("Hora Inválida");
                        break;
                    }
                    Console.Write("Digite os minutos? ");
                    int minuto = int.Parse(Console.ReadLine() + "");
                    if (minuto < 0 || minuto > 59)
                    {
                        Console.WriteLine("Minuto Inválidos");
                        break;
                    }
                    Console.Write("Digite os segundos? ");
                    int segundo = int.Parse(Console.ReadLine() + "");
                    if (segundo < 0 || segundo > 59)
                    {
                        Console.WriteLine("Segundos Inválidos");
                        break;
                    }

                    Console.WriteLine("Horário digitado: " + hora + ":" + minuto + ":" + segundo);
            }
        }
    }
}
