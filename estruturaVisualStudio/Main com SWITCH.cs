namespace Aula2010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomearquivo;
            int op;
            Arquivo a;
            Console.WriteLine("Digite o nome do arquivo: ");
            nomearquivo = Console.ReadLine();
            a = new Arquivo(nomearquivo);
            while (true)
            {
                Console.WriteLine("Digite:\n1 - para criar/abrir um arquivo\n" +
                    "2 - para gravar um texto no arquivo\n" +
                    "3 - para ler o arquivo\n" +
                    "0 - para sair do programa");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        a.criaAbreArquivo();
                        a.fechaArquivo();
                        break;
                    case 2:
                        a.criaAbreArquivo();
                        Console.WriteLine("Digite uma mensagem para o futuro: ");
                        string msg = Console.ReadLine();
                        a.gravaMensagem(msg);
                        a.fechaArquivo();
                        break;
                    case 3:
                        a.lerArquivo();
                        break;
                    case 0:
                        break;

                    default:
                        Console.WriteLine("digite um valor valido animalzinho s2");
                        break;
                }
            }


         /*
            a.gravaMensagem("Oi gente, vocês são 10!");
           // a.fechaArquivo();

           // a.criaAbreArquivo();
            a.gravaMensagem("Mas nao tenho certeza");
            a.gravaMensagem("pode sim gente, vocês são 100");
            a.gravaMensagem("e aqui posso escrever muito!");
            //a.fechaArquivo();*/
            
        

        }

    }
}