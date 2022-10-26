/*
9 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), 
e então diga se esses lados podem ou não formar um triangulo. Para que os lados 
formem um triângulo, todos os lados devem ser menores a soma dos outros dois lados. 
Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos os lados 
iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
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
                Console.WriteLine("(-1 P/ Sair)Digite o tamanho dos lados de um triângulo!");
                Console.Write("Lado A: ");
                float ladoA = float.Parse(Console.ReadLine() + "");
                if (ladoA == -1)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }
                Console.Write("Lado B: ");
                float ladoB = float.Parse(Console.ReadLine() + "");
                Console.Write("Lado C: ");
                float ladoC = float.Parse(Console.ReadLine() + "");

                
                if (ladoA < ladoB+ladoC && ladoB < ladoA+ladoC && ladoC < ladoA+ladoB)
                {
                    if(ladoA == ladoB && ladoB == ladoC)
                    {
                        Console.WriteLine("Triângulo Equilátero!");
                    }
                    else if(ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    {
                        Console.WriteLine("Triângulo Isóceles!");
                    }
                    else
                    {
                        Console.WriteLine("Triângulo Escaleno!");
                    }
                }
                else
                {
                    Console.WriteLine("Não é um triângulo!");
                }

                

            }
        }
    }
}
