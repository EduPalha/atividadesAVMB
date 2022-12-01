/*
5 - Crie uma classe Livro que represente os dados básicos de um livro.
Faça a leitura pelo teclado dos atributos e crie um construtor para 
fazer o instanciamento.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {

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


            var li = new Livro(tituloLivro, nomeAutor, nPaginas, anoPublicacao, isbn, idEditora, idCategoria);            
        }
    }
}