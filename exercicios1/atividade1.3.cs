using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o seu mês de aniversário(numero)?");
            int mes = int.Parse(Console.ReadLine());
            
            string[] mesDescritivo = { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            if (mes>0 && mes<13)
            {
                Console.WriteLine("Seu mês de aniversário é " + mesDescritivo[mes] + " !");
            }
            else
            {
                Console.WriteLine("Mês inválido!");
            }

        }
    }
}
