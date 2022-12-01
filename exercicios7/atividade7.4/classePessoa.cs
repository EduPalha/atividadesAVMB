using System;


namespace ImersaoAVMB
{
    public class Pessoa
    {
        private string nome;
        private long cpf;
        private long rg;
        private string dataNascimento;

        public Boolean cadastrar(string nome, long cpf, long rg, string data)
        {
            try
            {
                this.nome = nome;
                this.cpf = cpf;
                this.rg = rg;
                this.dataNascimento = data;
            }
            catch(Exception e)
            {
                return false;
            }

            return true;
        }

        public void consultar()
        {
            Console.WriteLine(this.nome + " com CPF:" + this.cpf + " e RG:" +this.rg+ " nasceu em " + this.dataNascimento + " !");
        }





    }
}