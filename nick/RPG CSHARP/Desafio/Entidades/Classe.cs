using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Classe
    {
        public Classe()
        {

        }

        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public int Forca { get; set; }

        public int HP { get; set; }

        public int Destresa { get; set; }

        public int Defesa { get; set; }

        public bool IsSelecionado { get; set; }
    }
}
