using System;

namespace ImersaoAVMB
{
    public class Carro : Proprietario
    {
        private string marca;
        // private string modelo;
        // private string cor;
        // private int ano;
        // private string tipo;
        // private string chassi;
        // private int odometro;
        // private int portas;
        // private int nMarchas;
        // private string cambio;
        // private int tanque;
        public int velMax;
        public int vel;
        public int marcha;

        public Carro(string prop)
        {
            this.nome = prop;
            Console.WriteLine("Nome proprietário: " + prop);
        }

        public int posicaoMarcha(int velocidade)
        {
            if (velocidade >= 20 && velocidade < 40) return marcha = 2;
            else if (velocidade >= 40 && velocidade < 70) return marcha = 3;
            else if (velocidade >= 70 && velocidade < 100) return marcha = 4;
            else if (velocidade >= 100) return marcha = 5;

            return marcha = 1;
        }

        public int acelera(int velocidade, int velMaxima)
        {
            velocidade = (velocidade + 1);
            return velocidade;
        }

        public int desacelera(int velocidade)
        {
            velocidade = (velocidade - 1);
            return velocidade;
        }
    }
}