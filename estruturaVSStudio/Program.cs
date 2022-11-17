/* Criando, consultando, editando arquivos 

    3. nos arquivos .csv. por exemplo, arquivo de figurinhas repetidas, faltantes.csv
        codigo figurinha;seleçao;nome do jogador 
*/
using CsvHelper.configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            var arquivo = @"C:\\Users\\eduardo.palharini\\Desktop\\atividadesAVMB\\estruturaVSStudio\\arquivo.csv";
            var configuracao = new CsvReader(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8, // Our file uses UTF-8 encoding.
                Delimiter = "," // The delimiter is a comma.
            };

            using (var fs = File.Open(arquivo, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuracao))
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