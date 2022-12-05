/*
12 - Crie uma classe Personagem com os atributos nome, posição x, 
posição y, HP entre outros de sua preferência.
Além disso, deve possuir o método RetornaPosiçao que retorna a posição x 
e y do personagem. Faça também com que possua os métodos abstratos 
Movimentar, Atacar.
Crie uma classe NPC e PersonagemJogavel que implemente os métodos 
abstratos.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            float posicaoPX, posicaoPY, posicaoNX, posicaoNY;

            Console.Write("Nome Personagem");
            string nome = Console.ReadLine() + "";
            Personagem p = new Personagem(nome);

            NPC npc = new NPC();
            npc.nome = "BOT" + npc.nBot;

            while (true)
            {
                Console.Write("BATALHA\n0-Sair\n1-Personagem\n2-BOT");
                opcao = int.Parse(Console.ReadLine() + "");
                if (opcao == 0) break;
                else if (opcao == 1)
                {
                    Console.Write("Digite a posição X do personagem: ");
                    posicaoPX = float.Parse(Console.ReadLine() + "");
                    Console.Write("Digite a posição Y do personagem: ");
                    posicaoPY = float.Parse(Console.ReadLine() + "");
                    p.retornaPosicao(posicaoPX, posicaoPY);
                }
                else
                {
                    posicaoNX = npc.movimentarX;
                    posicaoNY = npc.movimentarY;
                }

                if(posicaoPX == posicaoNX && posicaoPY == posicaoNY)
                {
                    Console.WriteLine("0-Faca\n1-Tiro\n2-Chute\n3-Soco\n4-KameHameHa");
                    Console.Write("Ataque do personagem: ");
                    int movimento = int.Parse(Console.ReadLine() + "");
                    Console.WriteLine("RETORNO Personagem: " + p.atacar(movimento));

                    Console.WriteLine("PERSONAGEM: " + p.atacar);
                    Console.WriteLine("NPC: " + npc.atacar);
                }
                else
                {
                    Console.WriteLine("Não teve combate!");
                }
            }
            Console.WriteLine("Saindo do sistema...");
        }
    }
}
