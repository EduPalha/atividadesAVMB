using System;

namespace ImersaoAVMB
{
    public class Livro
    {
        //Mecanismos de proteção:
        //Protected permite que classe externa chame os atributos
        //Private só permite que os atributos sejam chamados dentro da classe
        // em que eles foram criados
        public int idLivroPublico;
        protected int idLivro;
        protected string nomeLivro;
        protected long isbn;
        protected string anoPublicacao;
        protected string idEditora;
        protected string idCategoria;

        public Livro()
        {
            Console.WriteLine("Iniciando Classe Livro: ");
        }




    }
}