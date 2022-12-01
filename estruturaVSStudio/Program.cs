/*
6 - Escreva uma classe Aluno contendo todos os atributos de um aluno. 
Faça métodos para apresentar os dados. Faça a leitura pelo teclado dos 
atributos e crie um construtor para fazer o instanciamento.
*/
using System;
using System.Security.Cryptography;

namespace ImersaoAVMB
{
    class Program
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        public string hashSenha()
        {
            byte[] salt = new byte[16];
            rngCsp.GetBytes(salt);

            string senha1, senha2;
            while (true)
            {
                Console.WriteLine("Informe a senha");
                senha1 = Console.ReadLine();

                Console.WriteLine("Repita a senha");
                senha2 = Console.ReadLine();
                if (senha1 == senha2) break;
            }

            var pbkdf2 = new Rfc2898DeriveBytes(senha1, salt, 1000);

            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string hashSenha = Convert.ToBase64String(hashBytes);

            Console.WriteLine($"\nHash da senha gerado : {hashSenha}");
            Console.ReadKey();

            return hashSenha;
        }

        static void Main(string[] args)
        {
            Console.Write("Titulo: ");
            string tituloLivro = Console.ReadLine() + "";

            Console.Write("Nome Autor: ");
            string nomeAutor = Console.ReadLine() + "";

            Console.Write("Número de páginas: ");
            int nPaginas = int.Parse(Console.ReadLine() + "");

            Console.Write("Ano Publicação: ");
            int anoPublicacao = int.Parse(Console.ReadLine() + "");

            Console.Write("ISBN: ");
            long isbn = long.Parse(Console.ReadLine() + "");

            Console.Write("ID Editora: ");
            int idEditora = int.Parse(Console.ReadLine() + "");

            Console.Write("ID Categoria: ");
            int idCategoria = int.Parse(Console.ReadLine() + "");

            string senha = hashSenha();

            //var li = new Livro(tituloLivro, nomeAutor, nPaginas, anoPublicacao, isbn, idEditora, idCategoria);
        }
    }
}