using System;

namespace ImersaoAVMB
{
    public class Aluno
    {
        private string nomeAluno;
        private string dataNascimento;
        private long cpf;
        private long rg;
        private string endereco;
        private long telefone;
        private string email;
        private string senha;

        public Aluno(string nome, string data, long cpf, long rg, string endereco,
        long telefone, string email, string senha)
        {
            this.nomeAluno = nome;
            this.dataNascimento = data;
            this.cpf = cpf;
            this.rg = rg;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
            this.senha = senha;

            Console.WriteLine("Aluno cadastrado no sistema!");
            Console.WriteLine("Hash gerado a partir da senha digitada: " + senha);
        }

    }
}