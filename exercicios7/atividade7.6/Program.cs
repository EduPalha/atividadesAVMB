/*
6 - Escreva uma classe Aluno contendo todos os atributos de um aluno. 
Faça métodos para apresentar os dados. Faça a leitura pelo teclado dos 
atributos e crie um construtor para fazer o instanciamento.
*/
using System;
using System.Text;
using System.Security.Cryptography;

namespace ImersaoAVMB
{
    class Program
    {

        static string converterMD5(string senha)
        {
            StringBuilder sb = new StringBuilder();

            // Inicializando criptografia MD5
            using (MD5 md5 = MD5.Create())
            {
                // Criando o hash
                byte[] valorHash = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));

                // Converter bits de array em string
                foreach (byte b in valorHash)
                {
                    sb.Append($"{b:X2}");
                }
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Nome Aluno: ");
            string nomeAluno = Console.ReadLine() + "";

            Console.Write("Data de Nascimento: ");
            string dataNascimento = Console.ReadLine() + "";

            Console.Write("CPF: ");
            long cpf = long.Parse(Console.ReadLine() + "");

            Console.Write("RG: ");
            long rg = long.Parse(Console.ReadLine() + "");

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine() + "";

            Console.Write("Telefone: ");
            long telefone = long.Parse(Console.ReadLine() + "");

            Console.Write("Email: ");
            string email = Console.ReadLine() + "";

            string senha1, senha2;
            while (true)
            {
                Console.Write("Senha acesso: ");
                senha1 = Console.ReadLine() + "";

                Console.Write("Repita Senha: ");
                senha2 = Console.ReadLine() + "";

                if (senha1 == senha2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Senhas não conhecidem!");
                }
            }
            senha1 = converterMD5(senha1);

            Aluno aluno = new Aluno(nomeAluno, dataNascimento, cpf, rg, endereco, telefone, email, senha1);

        }
    }
}
