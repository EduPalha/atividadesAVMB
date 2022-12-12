/*
14 - Crie as classes Conta Corrente e Conta Poupança que herdam da Conta 
Bancaria. A primeira possui um atributo taxaDeOperação que é descontado 
sempre que um saque e um depósito são feitos. A segunda possui um 
atributo limite que dá crédito a mais para o correntista caso ele precise 
sacar mais que o saldo. Neste caso, o saldo pode ficar negativo desde que 
não ultrapasse o limite. Contudo isso não pode acontecer na classe Conta 
poupança.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int opcao2;

            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            Console.Write("Digite a taxa de operação da conta poupança:   ");
            cp.taxa = double.Parse(Console.ReadLine() + "");

            Console.Write("Digite o limite de crédito da conta corrente:   ");
            cc.limite = double.Parse(Console.ReadLine() + "");

            Console.Write("Digite o saldo inicial das conta corrente:   ");
            cc.saldo = double.Parse(Console.ReadLine() + "");

            Console.Write("Digite o saldo inicial das conta poupança:   ");
            cp.saldo = double.Parse(Console.ReadLine() + "");

            while (true)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Conta Corrente\n1-Deposito\n2-Saque");
                Console.WriteLine("\nConta Poupança\n3-Deposito\n4-Saque\n5-Sair");
                int opcao1 = int.Parse(Console.ReadLine() + "");

                if (opcao1 == 5)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }

                switch (opcao1)
                {
                    case 1:
                        Console.WriteLine("Digite o valor a ser depositado CC:  ");
                        valor = double.Parse(Console.ReadLine() + "");
                        cc.saldo = cc.depositar(cc.saldo, valor);
                        Console.WriteLine("\nSaldo CC: " + cc.saldo + "\n");
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor a ser sacado CC:  ");
                        valor = double.Parse(Console.ReadLine() + "");
                        if (valor > cc.saldo)
                        {
                            Console.WriteLine("Deseja utilizar o limite CC\n1-Sim\nNão");
                            opcao2 = int.Parse(Console.ReadLine() + "");
                            switch (opcao2)
                            {
                                case 1:
                                    if (cc.limite <= valor)
                                    {
                                        cc.saldo = cc.sacar(cc.saldo, valor);
                                        Console.WriteLine("\nSaldo CC: " + cc.saldo + "\n");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLimite não cobre o saque!");
                                        break;
                                    }
                                case 2:
                                    break;
                            }
                        }
                        else
                        {
                            cc.saldo = cc.sacar(cc.saldo, valor);
                            Console.WriteLine("\nSaldo CC: " + cc.saldo + "\n");
                        }
                        Console.WriteLine("\nSaldo atual CC: " + cc.saldo + "\n");
                        break;

                    case 3:
                        Console.WriteLine("Digite o valor a ser depositado CP:  ");
                        valor = double.Parse(Console.ReadLine() + "");
                        valor = valor - cp.taxa;
                        cp.saldo = cp.depositar(cp.saldo, valor);
                        Console.WriteLine("\nSaldo atual, já descontando a taxa de operação de " + cp.taxa + ": " + cp.saldo + "\n");
                        break;

                    case 4:
                        Console.WriteLine("Digite o valor a ser sacado CP:  ");
                        valor = double.Parse(Console.ReadLine() + "");
                        valor = valor + cp.taxa;
                        if (valor > cp.saldo)
                        {
                            Console.WriteLine("Saque não permitido!");
                            break;
                        }
                        else
                        {
                            cp.saldo = cp.sacar(cp.saldo, valor);
                            Console.WriteLine("\nsaldo atual: " + cp.saldo + "\n");
                        }
                        break;

                }


            }
        }
    }
}
