/*
2 - Crie uma classe chamada Televisao que represente os seus dados. 
Ainda, crie métodos que represente o comportamento dela.
*/
using System;

namespace ImersaoAVMB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados publicos da classe televisao
            Televisao t = new Televisao();
            t.idTelevisao = 1;
            t.numeroCanal = 12;
            t.nomeCanal = "Globo";
            t.tipo = 1;


            //Dados privados da classe Programas
            Programas p = new Programas();
            int idPrograma = 1;
            string nomePrograma = "Conversa com o Bial";
            string apresentador = "Pedro Bial";
            int tematica = 4;
            string horarioInicio = "00:00";
            string horarioFim = "01:00";

            //Chamando o método setProgramas() e passando as variaveis
            // e esperando retorno de confirmação
            if(p.setProgramas(idPrograma, nomePrograma, apresentador,
                            tematica, horarioInicio, horarioFim))
            {
                Console.WriteLine("");
            }
            else{
                Console.WriteLine("Erro na inserção de dados do programa!");
            }

            Console.WriteLine(p.getProgramas());

        }
    }
}