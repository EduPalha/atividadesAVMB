namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oi mundo!"); // saida, ou seja, apresentar os resultados
            Console.Write("Oi mundo!\n");
            //Console.Write(" não quebrou a linha");
            int n1 = 2, n2 = 3;
            n2 = (-n2) * n1;
            string linha = Console.ReadLine();
           
            
            Console.WriteLine("O que foi digitado: "+linha);

            int c = Console.Read();
            Console.WriteLine("Tecla: "+(char)(c));

            ConsoleKeyInfo tecla = Console.ReadKey();

            if(tecla.Key.ToString() == "Enter") 
            {
                Console.WriteLine("é enter");
            }
            Console.WriteLine("\ntecla digitada foi:"+tecla.Key);


        }
    }
}