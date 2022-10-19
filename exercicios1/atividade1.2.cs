using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] horas = new int[2];
            int[] valor = new int[2];
            int i = 0;
            for(i = 0; i < horas.Length; i++)
            {
                Console.Write("Digite quantas horas o professor " + (i + 1) + " trabalhou?");
                int aux = int.Parse(Console.ReadLine());
                horas[i] = aux;
                Console.Write("Digite valor recebido pelo professor " + (i + 1) + " por hora trabalhada?"); 
                aux = int.Parse(Console.ReadLine());
                valor[i] = aux;
            }

            int prof1 = horas[0]*valor[0];
            int prof2 = horas[1]*valor[1];  

            if(prof1 > prof2)
            {
                Console.WriteLine("Professor 1 ganhou " + prof1 + " reais e tem o maior salário entre os professores!");
            }
            else
            {
                Console.WriteLine("Professor 2 ganhou " + prof2 + " reais e tem o maior salário entre os professores!");
            }

        }
    }
}