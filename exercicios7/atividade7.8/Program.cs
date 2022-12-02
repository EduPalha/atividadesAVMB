/*
8 - Crie uma classe chamada Funcionario com seus atributos (Nome, CPF, 
data de nascimento, RG e endereço) com construtor. Crie métodos para 
cadastrar e apresentar na tela os dados desta classe.
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
            Console.Write("Nome: ");
            string nome = Console.ReadLine() + "";

            Console.Write("CPF: ");
            long cpf = long.Parse(Console.ReadLine() + "");

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine() + "";

            Console.Write("Telefone: ");
            long telefone = long.Parse(Console.ReadLine() + "");

            Console.Write("Cargo: ");
            string cargo = Console.ReadLine() + "";

            Console.Write("Função: ");
            string funcao = Console.ReadLine() + "";

            Console.Write("Login: ");
            string login = Console.ReadLine() + "";

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

            Funcionario f = new Funcionario(nome, cpf, endereco, telefone, cargo, funcao, login, senha1);

        }
    }
}
