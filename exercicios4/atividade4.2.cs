/* Criando, consultando, editando arquivos 

    2.FIGURINHAS COPA DO MUNDO
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
            string arquivoRepetidas = "C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\figurinhasRepetidas.txt";
            string arquivoFaltantes = "C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\figurinhasFaltantes.txt";
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
                                    sw = new StreamWriter(arquivoRepetidas, true, Encoding.UTF8);
                                    sw.WriteLine(Console.ReadLine() + "");
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
                                    sw = new StreamWriter(arquivoFaltantes, true, Encoding.UTF8);
                                    sw.WriteLine(numero);
                                    sw.Close();
                                }
                            }
                            break;

                        case 3:
                            sr = new StreamReader(arquivoRepetidas);
                            Console.WriteLine("\n--Figurinhas Repetidas Armazenadas no Arquivo:--\n");
                            linha = sr.ReadLine();
                            while (linha != null)
                            {
                                Console.WriteLine(linha);
                                linha = sr.ReadLine();
                            }
                            sr.Close();
                            Console.WriteLine("________________________________________________\n");

                            break;
                        case 4:
                            sr = new StreamReader(arquivoFaltantes);
                            Console.WriteLine("\n--Figurinhas Faltantes Armazenadas no Arquivo:--\n");
                            linha = sr.ReadLine();
                            while (linha != null)
                            {
                                Console.WriteLine(linha);
                                linha = sr.ReadLine();
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