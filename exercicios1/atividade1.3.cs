/*
3 - Escreva um programa que pede para o usuário digitar um valor 
entre 1 e 12, e então mostre na tela o mês correspondente. Caso o usuário 
digite um valor fora do intervalo, mostre uma mensagem indicando que é um 
mês inválido.
*/

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
