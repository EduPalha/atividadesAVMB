using System;

namespace ImersaoAVMB
{
    public class Livro
    {
        private string titulo;
        private string nomeAutor;
        private int nPaginas;
        private int anoPublicacao;
        private long isbn;
        private int idEditora;
        private int idCategoria;

        public Livro(string ti, string nome, int n, int ano, long i, int idE, int idC)
        {
            titulo = ti;
            nomeAutor = nome;
            nPaginas = n;
            anoPublicacao = ano;
            isbn = i;
            idEditora = idE;
            idCategoria = idC;
            
            Console.WriteLine("\nCadastrado com SUCESSO");
            Console.WriteLine("Livro " + titulo + " do autor " + nomeAutor);
            Console.WriteLine("Número de Páginas " + n);
            Console.WriteLine("Ano Publicação " + ano);
            Console.WriteLine("ISBN " + isbn);
            Console.WriteLine("ID Editora " + isbn);
            Console.WriteLine("ID Categoria " + isbn);
            
        }

    }
}