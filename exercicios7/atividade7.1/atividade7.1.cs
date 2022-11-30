/*
1. Criar uma classe Livro que represente os dados básicos de um livro.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l = new Livro();
            l.idLivro = 1;
            Console.Write("Titulo: ");
            l.titulo = (Console.ReadLine() + "");
            Console.Write("Autor: ");
            l.nomeAutor = (Console.ReadLine() + "");
            Console.Write("Nº Páginas: ");
            l.nPaginas = int.Parse(Console.ReadLine() + "");
            Console.Write("Ano Publicação: ");
            l.anoPublicacao = int.Parse(Console.ReadLine() + "");
            Console.Write("ISBN: ");
            l.isbn = long.Parse(Console.ReadLine() + "");
            Console.WriteLine("Editoras:\n1-Viva\n2-Papel&Caneta\n3-Conhecimento");
            l.idEditora = int.Parse(Console.ReadLine() + "");
            Console.WriteLine("Categoria:\n1-Drama\n2-Suspense\n3-Infantil");
            l.idCategoria = int.Parse(Console.ReadLine() + "");

        }
    }
}