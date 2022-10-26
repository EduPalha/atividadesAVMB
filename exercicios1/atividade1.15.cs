/*
15 - Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. 
Considere que Polegada = Centímetro * 2,54.
*/

using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var selecao = new List<double>();

            double auxiliar = 0.00;
            for (int i = 1; i <= 20; i++)
            {
                auxiliar = i * 2.54;
                selecao.Add(auxiliar);
            }

            for (int i = 0; i < selecao.Count; i++)
            {
                Console.WriteLine(i + 1 + " Polegada é igual a " + selecao[i] + " Centímetros!");
            }
        }
    }
}
