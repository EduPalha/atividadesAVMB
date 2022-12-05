using System;

namespace ImersaoAVMB
{
    public class PessoaJuridica : Pessoa
    {
        private long cnpj;

        public void cadastrarPessoa(string n, long c)
        {
            this.nome = n;
            this.cnpj = c;

            Console.WriteLine("Pessoa Juridica: " + nome + " tem o CPF: " + cnpj);
        }
    }
}