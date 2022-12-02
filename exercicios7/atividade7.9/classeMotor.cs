using System;

namespace ImersaoAVMB
{
    public class Motor
    {
        private string nomeFabricante;
        private int potencia;
        private string tipo;

        public void getMotor()
        {
            Console.WriteLine("\nVeículo cadastrado com SUCESSO!");
        }
        public void setMotor(string nome, int potencia, string tipo)
        {
            this.nomeFabricante = nome;
            this.potencia = potencia;
            this.tipo = tipo;
        }

        public Motor(string nome, int potencia, string tipo)
        {
            Console.WriteLine("Nome Fabricante: " + nome + "\nPotência: " +
            potencia + "\nTipo de carroceria: " + tipo);
            
            if (potencia >= 0 && potencia < 120)
            {
                Console.WriteLine("Carro de PASSEIO");
            }
            else if (potencia >= 120 && potencia < 250)
            {
                Console.WriteLine("Carro PREMIUM");
            }
            else
            {
                Console.WriteLine("Carro LUXO");
            }
        }

    }
}