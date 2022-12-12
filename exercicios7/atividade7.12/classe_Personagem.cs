using System;

namespace ImersaoAVMB
{
    public abstract class Personagem
    {
        protected string nome;
        protected float posX;
        protected float posY;
        protected string forca;

        public Personagem(string n)
        {
            this.nome = n;
            Console.WriteLine("O nome do seu personagem é: " + nome);
        }

        public string retornaPosicao(float posicaoX, float posicaoY)
        {
            this.posX = posicaoX;
            this.posY = posicaoY;

            return ("Posicao Atual: (" + posX + ";" + posY + ")");
        }

        public string atacar(int mov)
        {
            mov = movimento();
            if (mov == 0) return "Faca";
            else if (mov == 1) return "Tiro";
            else if (mov == 2) return "Chute";
            else if (mov == 3) return "Soco";
            else if (mov == 4) return "KameHameHa";
        }

    }
}