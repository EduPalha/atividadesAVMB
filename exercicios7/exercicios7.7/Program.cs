/*
7 - Crie uma classe chamada Personagem. Defina seus atributos, mas 
dentre eles deve conter: Nome, posição e itens coletados, no mínimo. 
Crie construtor e faça a leitura dos atributos pelo teclado.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu = 0, opcaoJ1 = 0, opcaoJ2 = 1, atributo = 0, i = 0;

            //Classes que leem e gravam no arquivo
            string arquivo = "C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\personagens.txt";
            StreamWriter sw;
            //Iniciando as variáveis necessárias para auxiliar na leitura do arquivo, que depois serão chamadas no código em outros momentos
            String linha; // ler a linha
            string[] auxiliar; //usada para splitar a leitura do arquivo, o tamanho desse vetor será de 6 posições(0-5) por causa dos itens de cada um dos personagens
            int[] vetorAtributo; //usada para pegar o mesmo atributo de todos os super herois

            //Pontuação de cada um dos jogadores no jogo
            int pontosJ1 = 0, pontosJ2 = 0;

            //Instanciando a classe personagem para cada um dos 2 jogadores
            Personagem p0 = new Personagem();
            Personagem p1 = new Personagem();
            Personagem p2 = new Personagem();

            while (true)
            {
                if (opcaoMenu == 4)
                {
                    break;
                }

                //Menu principal
                Console.WriteLine("----SUPER TRUNFO SUPER HERÓIS----");
                Console.WriteLine("1 - JOGAR");
                Console.WriteLine("2 - Cadastrar");
                Console.WriteLine("3 - Listar");
                Console.WriteLine("4 - Sair");
                Console.Write("Digite sua opcao: ");
                opcaoMenu = int.Parse(Console.ReadLine() + "");

                switch (opcaoMenu)
                {
                    case 1:
                        //Mostrando os personagens cadastrados para escolha dos jogadores
                        Console.WriteLine("\n-------------PARTIDA--------------\n");
                        Console.WriteLine("    PERSONAGENS CADASTRADOS\n");

                        StreamReader sr = new StreamReader(arquivo);

                        // Console.WriteLine(lerArquivo(arquivo));

                        //Mostrando personagens cadastrados(apenas o nome)
                        try
                        {
                            i = 0;
                            linha = sr.ReadLine();
                            auxiliar = new string[i];
                            while (linha != null)
                            {
                                auxiliar = linha.Split(";");
                                p0.nomePersonagem = auxiliar[0];
                                Console.WriteLine("->" + i + ": " + p0.nomePersonagem);
                                linha = sr.ReadLine();
                                i++;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro na visualização dos personagens: " + e);
                        }

                        //Selecionando os personagens de cada um dos jogadores
                        Console.WriteLine("\n-------------JOGADOR 1-------------");
                        Console.Write("Escolha um nº de 0 a " + (i - 1)
                        + " para\nselecionar o seu personagem:  ");
                        opcaoJ1 = int.Parse(Console.ReadLine() + "");

                        Console.WriteLine("\n-------------JOGADOR 2-------------");
                        Console.Write("Escolha um nº de 0 a " + (i - 1)
                        + " para\nselecionar o seu personagem:  ");
                        opcaoJ2 = int.Parse(Console.ReadLine() + "");

                        Console.WriteLine("\n-------------ATRIBUTO--------------");
                        Console.WriteLine("\n1-Lealdade\n2-Força\n3-Heroismo\n4-Poder\n5-Pontuação Geral\n");
                        Console.Write("->Atributo para duelar: ");
                        atributo = int.Parse(Console.ReadLine() + "");
                        vetorAtributo = new int[i];

                        //Mostrando atributos do personagem escolhido
                        try
                        {
                            sr = new StreamReader(arquivo);
                            linha = sr.ReadLine();

                            i = 0;
                            while (linha != null)
                            {
                                auxiliar = linha.Split(";");
                                if (opcaoJ1 == i)
                                {
                                    p1.nomePersonagem = auxiliar[0];
                                }
                                else if (opcaoJ2 == i)
                                {
                                    p2.nomePersonagem = auxiliar[0];
                                }
                                vetorAtributo[i] = int.Parse(auxiliar[atributo]);
                                linha = sr.ReadLine();
                                i++;
                            }
                            sr.Close();

                            Console.WriteLine("\n" + p1.nomePersonagem + " tem " + vetorAtributo[opcaoJ1] + " pontos!");
                            Console.WriteLine(p2.nomePersonagem + " tem " + vetorAtributo[opcaoJ2] + " pontos!");
                            if (vetorAtributo[opcaoJ1] > vetorAtributo[opcaoJ2])
                            {
                                Console.WriteLine("JOGADOR 1 VENCEU!");
                                pontosJ1++;
                            }
                            else if (vetorAtributo[opcaoJ1] < vetorAtributo[opcaoJ2])
                            {
                                Console.WriteLine("JOGADOR 2 VENCEU!");
                                pontosJ2++;
                            }
                            else
                            {
                                Console.WriteLine("EMPATE!");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro na visualização dos personagens dos 2 jogadores: " + e);
                        }
                        Console.WriteLine("__________________________________\n");
                        break;

                    case 2:
                        sw = new StreamWriter(arquivo, true, Encoding.UTF8);
                        Console.WriteLine("\nCadastrando NOVO personagem\n");
                        try
                        {
                            Console.Write("\nPersonagem: ");
                            p0.nomePersonagem = (Console.ReadLine() + "").ToUpper();
                            Console.Write("Lealdade: ");
                            p0.lealdade = int.Parse(Console.ReadLine() + "");
                            Console.Write("Força: ");
                            p0.forca = int.Parse(Console.ReadLine() + "");
                            Console.Write("Heroismo: ");
                            p0.heroismo = int.Parse(Console.ReadLine() + "");
                            Console.Write("Poder: ");
                            p0.poder = int.Parse(Console.ReadLine() + "");
                            Console.Write("Pontuação Geral: ");
                            p0.pontuacaoGeral = int.Parse(Console.ReadLine() + "");
                            sw.WriteLine(p0.nomePersonagem + ";" + p0.lealdade + ";"
                                        + p0.forca + ";" + p0.heroismo + ";" +
                                        p0.poder + ";" + p0.pontuacaoGeral);
                            sw.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Problema ao gravar o personagem no arquivo;");
                        }
                        Console.WriteLine("Gravado com SUCESSO!");
                        break;

                    case 3:
                        Console.WriteLine("\n-------Personagens cadastrados--------\n");
                        try
                        {
                            sr = new StreamReader(arquivo);
                            linha = sr.ReadLine();
                            auxiliar = new string[6];

                            while (linha != null)
                            {
                                auxiliar = linha.Split(";");

                                p1.nomePersonagem = auxiliar[0];
                                p1.lealdade = int.Parse(auxiliar[1]);
                                p1.forca = int.Parse(auxiliar[2]);
                                p1.heroismo = int.Parse(auxiliar[3]);
                                p1.poder = int.Parse(auxiliar[4]);
                                p1.pontuacaoGeral = int.Parse(auxiliar[5]);

                                Console.WriteLine(p1.nomePersonagem + "\nLealdade: "
                                + p1.lealdade + "\nForça: " + p1.forca + "\nHeroismo: "
                                + p1.heroismo + "\nPoder: " + p1.poder + "\nPontuação Geral: "
                                + p1.pontuacaoGeral + "\n");

                                linha = sr.ReadLine() + "";
                            }
                            sr.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro: " + e);
                        }

                        Console.WriteLine("_______________________________________\n");
                        break;

                    case 4:
                        break;
                }
            }
            Console.WriteLine("\nRESULTADO FINAL:");
            if (pontosJ1 > pontosJ2)
            {
                Console.WriteLine("\nJogador 1 VENCEU mais partidas, " + pontosJ1 + " ao total!");
            }
            else if (pontosJ1 < pontosJ2)
            {
                Console.WriteLine("\nJogador 2 VENCEU mais partidas, " + pontosJ2 + " ao total!");
            }
            else
            {
                Console.WriteLine("\nEMPATE! Ambos ganharam " + pontosJ2 + " partidas ao total!");
            }
            Console.WriteLine("\nSaindo do jogo...");
        }
    }
}