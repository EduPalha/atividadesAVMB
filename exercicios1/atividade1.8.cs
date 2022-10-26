/*
8 - Um comerciante calcula o lucro da venda baseado no valor da compra dos clientes 
de acordo com os itens a seguir:

•	Valor da Compra < R$ 10,00  então o Lucro é de 70% 
•	R$ 10,00 ≤ Valor da Compra < R$ 30,00 então o Lucro é de 50% 
•	R$ 30,00 ≤ Valor da Compra < R$ 50,00 então o Lucro é de 40% 
•	Valor da Compra ≥ R$ 50,00 então o Lucro é de 30% 

Criar um algoritmo que leia o valor da compra e imprima uma mensagem indicando de 
quantos % é o lucro e o valor.
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
