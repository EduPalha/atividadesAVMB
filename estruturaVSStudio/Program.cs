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
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string IsActive { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var fileName = @"C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\arquivo.csv";
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8, // Our file uses UTF-8 encoding.
                Delimiter = "," // The delimiter is a comma.
            };

            using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    var data = csv.GetRecords<Person>();

                    foreach (var person in data)
                    {
                        Console.WriteLine(person);
                    }
                }
            }

        }
    }
}