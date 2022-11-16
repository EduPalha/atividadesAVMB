/* Criando, consultando, editando arquivos 

    1. EMAILS
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
            string arquivo = "C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\emails.txt";
            StreamWriter sw;
            StreamReader sr;

            try
            {
                while (true)
                {
                    if (opcao == 3)
                    {
                        break;
                    }
                    Console.WriteLine("--------Menu--------");
                    Console.WriteLine("1 - Cadastrar email");
                    Console.WriteLine("2 - Listar emails");
                    Console.WriteLine("3 - Sair");
                    Console.Write("Digite sua opcao: ");
                    opcao = int.Parse(Console.ReadLine() + "");

                    switch (opcao)
                    {
                        case 1:
                            sw = new StreamWriter(arquivo, true, Encoding.UTF8);
                            Console.Write("\nEmail: ");
                            sw.WriteLine(Console.ReadLine() + "");
                            sw.Close();
                            break;

                        case 2:
                            sr = new StreamReader(arquivo);
                            Console.WriteLine("\n----Emails armazenados no arquivo:----\n");
                            String linha = sr.ReadLine();
                            while (linha != null){
                                Console.WriteLine(linha);
                                linha = sr.ReadLine();
                            }
                            sr.Close();
                            Console.WriteLine("__________________________________\n");
                            break;

                        case 3:
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