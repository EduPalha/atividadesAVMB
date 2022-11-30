/*
3 - Crie uma classe chamada Personagem. Defina seus atributos, mas 
dentre eles deve conter: Nome, posição e itens coletados, no mínimo. 
Crie métodos que representem seu comportamento, ou seja, o que o seu 
personagem vai fazer no jogo.
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
            int opcao = 0;
            string arquivo = "C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\personagens.txt";
            StreamWriter sw;
            StreamReader sr;

            try
            {
                while (true)
                {
                    if (opcao == 4)
                    {
                        break;
                    }
                    Console.WriteLine("----SUPER TRUNFO SUPER HERÓIS----");
                    Console.WriteLine("1 - JOGAR");
                    Console.WriteLine("2 - Cadastrar");
                    Console.WriteLine("3 - Listar");
                    Console.WriteLine("4 - Sair");
                    Console.Write("Digite sua opcao: ");
                    opcao = int.Parse(Console.ReadLine() + "");

                    switch (opcao)
                    {
                        case 1:
                            break;
                        case 2:
                            sw = new StreamWriter(arquivo, true, Encoding.UTF8);
                            Personagem p = new Personagem();
                            try
                            {
                                Console.Write("\nPersonagem: ");
                                p.nomePersonagem = (Console.ReadLine() + "").ToUpper();
                                Console.Write("Lealdade: ");
                                p.lealdade = int.Parse(Console.ReadLine() + "");
                                Console.Write("Força: ");
                                p.forca = int.Parse(Console.ReadLine() + "");
                                Console.Write("Heroismo: ");
                                p.heroismo = int.Parse(Console.ReadLine() + "");
                                Console.Write("Poder: ");
                                p.poder = int.Parse(Console.ReadLine() + "");
                                Console.Write("Pontuação Geral: ");
                                p.pontuacaoGeral = int.Parse(Console.ReadLine() + "");
                                sw.WriteLine(p.nomePersonagem + ";" + p.lealdade + ";"
                                            + p.forca + ";" + p.heroismo + ";" +
                                            p.poder + ";" + p.pontuacaoGeral);
                                sw.Close();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Problema ao gravar o personagem no arquivo;");
                            }

                            break;

                        case 3:
                            Console.WriteLine("\n-------Personagens cadastrados--------\n");
                            Personagem p1 = new Personagem();
                            
                            try{
                                sr = new StreamReader(arquivo);

                                String linha = sr.ReadLine();
                                string[] auxiliar = new string[6]; //usada para splitar

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
                            catch(Exception e){
                                Console.WriteLine("Erro: " + e);
                            }
                            
                            Console.WriteLine("_______________________________________\n");
                            break;

                        case 4:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e);
            }
            finally
            {
                Console.WriteLine("Saindo do jogo...");
            }
        }
    }
}