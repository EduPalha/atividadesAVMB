/* Criando, consultando, editando arquivos 

    3. nos arquivos .csv. por exemplo, arquivo de figurinhas repetidas, faltantes.csv
        codigo figurinha;seleçao;nome do jogador 
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
            int numero;
            string linha;
            string selecao;
            string nomeJogador;
            string arquivoRepetidas = "C:\\Users\\xicuexuxi\\Desktop\\repositorios\\atividadesAVMB\\estruturaVSStudio\\figurinhasRepetidas.csv";
            string arquivoFaltantes = "C:\\Users\\xicuexuxi\\Desktop\\repositorios\\atividadesAVMB\\estruturaVSStudio\\figurinhasFaltantes.csv";
            // string arquivoRepetidas = "C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\figurinhasRepetidas.csv";
            // string arquivoFaltantes = "C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\figurinhasFaltantes.csv";
            StreamWriter sw;
            StreamReader sr;

            try
            {
                while (true)
                {
                    if (opcao == 5)
                    {
                        break;
                    }
                    Console.WriteLine("--------------Menu Figurinhas COPA22-------------");
                    Console.WriteLine("1 - Cadastrar figurinha repetida");
                    Console.WriteLine("2 - Cadastrar figurinha faltante");
                    Console.WriteLine("3 - Listar figurinhas repetidas");
                    Console.WriteLine("4 - Listar figurinhas faltantes");
                    Console.WriteLine("5 - Sair");
                    Console.Write("Digite sua opcao: ");
                    opcao = int.Parse(Console.ReadLine() + "");

                    switch (opcao)
                    {
                        case 1:
                            Console.Write("\n");
                            while (true)
                            {
                                Console.Write("(-1 p/ SAIR)Figurinha REPETIDA nº: ");
                                numero = int.Parse(Console.ReadLine() + "");
                                if (numero == -1)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("Seleção: ");
                                    selecao = Console.ReadLine() + "";
                                    Console.Write("Nome Jogador: ");
                                    nomeJogador = Console.ReadLine() + "";
                                    sw = new StreamWriter(arquivoRepetidas, true, Encoding.UTF8);
                                    sw.WriteLine(numero + ";" + selecao + ";" + nomeJogador);
                                    sw.Close();
                                }
                            }

                            break;
                        case 2:
                            Console.Write("\n");
                            while (true)
                            {
                                Console.Write("(-1 p/ SAIR)Figurinha FALTANTE nº: ");
                                numero = int.Parse(Console.ReadLine() + "");
                                if (numero == -1)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("Seleção: ");
                                    selecao = Console.ReadLine() + "";
                                    Console.Write("Nome Jogador: ");
                                    nomeJogador = Console.ReadLine() + "";
                                    sw = new StreamWriter(arquivoRepetidas, true, Encoding.UTF8);
                                    sw.WriteLine(numero + ";" + selecao + ";" + nomeJogador);
                                    sw.Close();
                                }
                            }

                            break;
                        case 3:
                            sr = new StreamReader(arquivoRepetidas);
                            Console.WriteLine("\n--Figurinhas Repetidas Armazenadas no Arquivo:--\n");
                            //linha = sr.ReadLine() + "";
                            while (!sr.EndOfStream)
                            {
                                linha = sr.ReadLine() + "";
                                Console.WriteLine(linha);
                            }
                            sr.Close();
                            Console.WriteLine("________________________________________________\n");


                            break;
                        case 4:
                            sr = new StreamReader(arquivoFaltantes);
                            Console.WriteLine("\n--Figurinhas Faltantes Armazenadas no Arquivo:--\n");
                            //linha = sr.ReadLine() + "";
                            while (!sr.EndOfStream)
                            {
                                linha = sr.ReadLine() + "";
                                Console.WriteLine(linha);
                            }
                            sr.Close();
                            Console.WriteLine("_______________________________________________\n");

                            break;
                        case 5:

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
                Console.WriteLine("Saindo do sistema...");
            }
        }
    }
}