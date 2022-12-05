/*
11 - Crie uma classe Pessoa que possua os seguintes métodos abstratos: 
CadastrarPessoa.
Crie uma classe PessoaJuridica e PessoaFisica que implemente este método.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string nome;
            long numero;
            while (true)
            {
                Console.WriteLine("Digite a opção desejada\n0-Sair\n1-Pessoa Física\n2-Pessoa Jurídica");
                opcao = int.Parse(Console.ReadLine() + "");
                if (opcao == 0) break;
                else if (opcao == 1)
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine() + "";
                    Console.Write("Nº CPF: ");
                    numero = long.Parse(Console.ReadLine() + "");
                    PessoaFisica pf = new PessoaFisica();
                    pf.cadastrarPessoa(nome, numero);
                }
                else
                {
                    Console.Write("Razão Social: ");
                    nome = Console.ReadLine() + "";
                    Console.Write("Nº CNPJ: ");
                    numero = long.Parse(Console.ReadLine() + "");
                    PessoaJuridica pj = new PessoaJuridica();
                    pj.cadastrarPessoa(nome, numero);
                }
            }
            Console.WriteLine("Saindo do sistema...");
        }
    }
}
