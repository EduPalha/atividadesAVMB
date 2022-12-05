/*
10 - Criar uma classe Carro e declare os seguintes atributos na classe: 
Modelo, Cor, Ano Marca, Chassi, Proprietário, Velocidade máxima, 
Velocidade atual, Nr de portas, tem teto solar? Nr Marchas, tem câmbio 
automático? Volume de combustível
Faça o encapsulamento da classe Carro e seus atributos
Implemente o método acelera que aumenta a velocidade de 1 em 1 km/h e 
não ultrapassando o limite máximo.
Implemente o método freia que para o carro – Velocidade = 0 km/h
Implemente o método troca marcha
Implemente o método reduz a marcha;
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome Proprietário: ");
            string nome = Console.ReadLine() + "";
            Console.Write("Vel. Máxima: ");
            int velMax = int.Parse(Console.ReadLine() + "");

            Carro carro = new Carro(nome);

            int opcao = 0;
            int velocidade = 0;
            int marcha = 1;
            while (true)
            {
                Console.Write("(-1 p/ SAIR) O que pretende fazer? Acelerar(1) ou Desacelerar?(2)");
                opcao = int.Parse(Console.ReadLine() + "");
                if (opcao == -1)
                    break;
                else if (opcao == 1)
                {
                    if (velocidade == velMax)
                    {
                        break;
                    }
                    Console.WriteLine("Velocidade atual: " + carro.acelera(velocidade, velMax));
                }

                else
                {
                    if (velocidade == 0)
                    {
                        break;
                    }
                    Console.WriteLine("Velocidade atual: " + carro.desacelera(velocidade));
                }


                Console.WriteLine("Marcha atual: " + carro.posicaoMarcha(velocidade));
            }
            Console.WriteLine("Saindo do programa...");
        }
    }
}
