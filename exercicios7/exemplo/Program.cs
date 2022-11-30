/*
Exemplo usando uma classe Livro que represente os dados básicos de um livro.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {

        static void Main(string[] args)
        {
            //->Classe sempre começa com maiúsculo
            //->Namespace tem que ser colocado em todas as classes de um 
            //  projeto com o mesmo o nome, caso contrário o sistema não reconhece

            Livro l = new Livro();
            l.idLivroPublico = 11111;
            Console.WriteLine("Id Livro: " + l.idLivroPublico);

            MetodosLivro ml = new MetodosLivro();
            int idLivro = ml.getLivro();
            Console.WriteLine("Id Livro: " + idLivro);
            ml.setLivro(33333);

            
            



        }
    }
}