using System;

namespace ImersaoAVMB
{
    public class MetodosLivro : Livro
    {
        //Pega os dados do sistema(banco) e mando para o usuario
        public int getLivro()
        {
            return this.idLivro = 22222;
        }

        //Pegos os dados inseridos pelo usuário e mando para o sistema(banco)
        public int setLivro(int id)
        {
            this.idLivro = id;
            Console.WriteLine("Id Livro: " + idLivro);
            return 0;
        }


    }

}