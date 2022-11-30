using System;

namespace ImersaoAVMB
{
    public class Programas : Televisao
    {
        private int idPrograma;
        private string nomePrograma;
        private string horarioInicio;
        private string horarioFim;
        private string apresentador;
        private int tematica;//1-Jornalismo;2-Novela;3-Infantil;4-Conversação;

        public Boolean setProgramas(int id, string nomeP, string apres,
                                    int tema, string hi, string hf)
        {
            try
            {
                this.idPrograma = id;
                this.nomePrograma = nomeP;
                this.apresentador = apres;
                this.horarioInicio = hi;
                this.horarioFim = hf;
                this.tematica = tema;
            }
            catch
            {
                return false;
            }

            return true;
        }

        public string getProgramas()
        {
            return "O Programa: " +  this.nomePrograma + " apresentado pelo " + 
                    this.apresentador + " inicia às " + this.horarioInicio + 
                    " e termina às " +this.horarioFim + " !";
        }

    }
}