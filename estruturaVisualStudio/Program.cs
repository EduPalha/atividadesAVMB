/* Criando, consultando, editando arquivos */

using System.IO;

namespace ImersaoAVMB
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVisualStudio\\emails.txt");
            try
            {  
                sw.WriteLine("Olá;");
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
