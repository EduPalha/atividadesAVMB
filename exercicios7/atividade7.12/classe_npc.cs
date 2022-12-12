using System;

namespace ImersaoAVMB
{
    public abstract class NPC : Personagem
    {

        public string nome;

        private int opcao;

        public string nBot()
        {
            Random rnd = new Random();
            opcao = rnd.Next(0, 10);

            return opcao + "";
        }

        public float movimentarX()
        {
            Random rnd = new Random();
            opcao = rnd.Next(0, 20);
            posX = opcao;

            return posX;
        }

        public float movimentarY()
        {
            Random rnd = new Random();
            opcao = rnd.Next(-20, 20);
            posY = opcao;

            return posY;
        }
        public string atacar()
        {
            Random rnd = new Random();
            opcao = rnd.Next(0, 4);

            if (opcao == 0) return "Faca";
            else if (opcao == 1) return "Tiro";
            else if (opcao == 2) return "Chute";
            else if (opcao == 3) return "Soco";
            else return "KameHameHa";
        }

    }
}