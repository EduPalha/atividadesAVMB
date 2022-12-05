using System;

namespace ImersaoAVMB
{
    public class PessoaFisica : Pessoa
    {
        private long cpf;

        public void cadastrarPessoa(string n, long c)
        {
            this.nome = n;
            this.cpf = c;

            Console.WriteLine("Pessoa Física: " + nome + " tem o CPF: " + cpf);
        }
    }
}