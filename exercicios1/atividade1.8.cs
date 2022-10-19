using System;

namespace atividade1AVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("(-1 P/ Sair)Valor da venda(R$): ");
                float valor = float.Parse(Console.ReadLine() + "");
                if (valor == -1)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }

                if (valor >0 && valor < 10)
                {
                    Console.WriteLine("Lucro de 70% sobre a venda, ou seja, R$ " + valor*0.7 + " de R$ " + valor + " !");
                }
                else if (valor >= 10 && valor < 30)
                {
                    Console.WriteLine("Lucro de 50% sobre a venda, ou seja, R$ " + valor * 0.5 + " de R$ " + valor + " !");
                }
                else if (valor >= 30 && valor < 50)
                {
                    Console.WriteLine("Lucro de 40% sobre a venda, ou seja, R$ " + valor * 0.4 + " de R$ " + valor + " !");
                }
                else if(valor >= 50)
                {
                    Console.WriteLine("Lucro de 30% sobre a venda, ou seja, R$ " + valor * 0.3 + " de R$ " + valor + " !");
                }
                else
                {
                    Console.WriteLine("Valor de venda 0, negativo ou inválido!");
                    break;
                }

            }
        }
    }
}
