/*
4 - Crie uma classe chamada Pessoa com seus atributos conforme sua 
preferência (Nome, CPF, data de nascimento, RG etc). Crie métodos para 
cadastrar e apresentar na tela os dados desta classe.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {

        static void Main(string[] args)
        {
            //Cadastrar PESSOA
            Pessoa p = new Pessoa();

            int id = 1;
            string nome = Console.ReadLine() + "";
            long cpf = long.Parse(Console.ReadLine() + "");
            long rg = long.Parse(Console.ReadLine() + "");
            string data = Console.ReadLine() + "";
            
            if(p.cadastrar(nome, cpf, rg, data)) Console.WriteLine("Pessoa cadastrada com SUCESSO!");

            //CONSULTAR PESSOA CADASTRADA
            p.consultar();
        }
    }
}