/*
13 - Crie uma classe abstrata Conta Bancaria que contém como atributos o 
numero da conta e o saldo, e como métodos abstratos sacar e depositar 
que recebem um parâmetro do tipo double.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaFisica conta = new ContaFisica();
            Console.Write("Digite o saldo inicial da conta:   ");
            conta.saldo = double.Parse(Console.ReadLine() + "");
            double valor;

            while (true)
            {
                Console.Write("Digite o número da conta:    ");
                int numeroConta = int.Parse(Console.ReadLine() + "");
                if (numeroConta == conta.numeroConta)
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Digite o operção desejada\n1-Deposito\n2-Saque\n3-Sair");
                int opcao = int.Parse(Console.ReadLine() + "");

                if (opcao == 3)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor a ser depositado:  ");
                        valor = double.Parse(Console.ReadLine() + "");
                        conta.saldo = conta.depositar(conta.saldo, valor);
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor a ser sacado:  ");
                        valor = double.Parse(Console.ReadLine() + "");
                        conta.saldo = conta.sacar(conta.saldo, valor);
                        break;
                        // case default:
                        //     Console.WriteLine("Opção inválida!");
                }


                Console.WriteLine("\nSaldo atual: " + conta.saldo + "\n");
            }
        }
    }
}
