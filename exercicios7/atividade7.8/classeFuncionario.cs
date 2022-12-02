using System;

namespace ImersaoAVMB
{
    public class Funcionario: Pessoa
    {
        private string cargo;
        private string funcao;
        private string login;
        private string senha;

        public Funcionario(string nome, long cpf, string endereco, long telefone, 
        string cargo, string funcao, string login, string senha)
        {
            this.nomePessoa = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.cargo = cargo;
            this.funcao = funcao;
            this.login = login;
            this.senha = senha;

            Console.WriteLine("Funcionario cadastrado no sistema!");
            //Console.WriteLine("Hash gerado a partir da senha digitada: " + senha);
        }

    }
}