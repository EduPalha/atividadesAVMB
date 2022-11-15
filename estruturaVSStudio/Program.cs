/* Criando, consultando, editando arquivos */

using System;
using System.IO;

namespace ImersaoAVMB
{
    class Program
    {

        static void Main(string[] args)
        {
            int opcao = 0;
            string arquivo = "C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVisualStudio\\emails.txt";
            StreamWriter sw = new StreamWriter(arquivo, true);
         
            StreamReader sr;
            try
            {
                while (true)
                {
                    if (opcao == 3){
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
                            Console.Write("Email: ");
                            sw.WriteLine(Console.ReadLine() + "");
                            break;

                        case 2:
                            Console.WriteLine("\nEmails armazenados: ");
                            sr = new StreamReader(arquivo);
                            string linha = sr.ReadLine();
                            while(linha != null){
                                Console.WriteLine(linha);
                                sr.Close();
                            }
                            Console.WriteLine("\n____________________");
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
                sw.Close();
            }

        }
    }
}
