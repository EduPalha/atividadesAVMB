/*
9 - Crie uma classe chamada Motor que possua três atributos visíveis 
apenas na própria classe, são eles: nomeFabricante, potência e tipo.

Também deverão ser criados dois métodos visíveis a qualquer classe, 
sendo que um desses métodos deverá associar valores aos atributos e 
outro método deverá retornar o conteúdo desses atributos. 

Em uma outra classe deverá ser instanciada a classe Motor e apresentado na tela os 
valores dos atributos retornados pelo método correspondente da classe 
Motor
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome Fabricante: ");
            string nome = Console.ReadLine() + "";

            Console.Write("Potência em CV: ");
            int potencia = int.Parse(Console.ReadLine() + "");

            Console.Write("Tipo de veículo: ");
            string tipo = Console.ReadLine() + "";

            Motor m = new Motor(nome, potencia, tipo);
            m.setMotor(nome, potencia, tipo);

        }
    }
}
