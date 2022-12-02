using System;

namespace ImersaoAVMB
{
    public class Personagem
    {
        // Peguei como referência as cartas do Super Trunfo dos Super Heróis
        // que utilizam valores que vai de 0 - 100 para cada uma das habilidades
        public string nomePersonagem;
        public int lealdade;
        public int forca;
        public int heroismo;
        public int poder;
        public int pontuacaoGeral;

        //Jogador1 e Jogador2 é a pontuacao de cada um no mesmo atributo
        private int atributo;
        private int jogador1;
        private int jogador2;

    }
}