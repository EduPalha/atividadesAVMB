using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Personagem
    {
        public Personagem()
        {
            this.Classe = new Classe();
        }

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public int XP { get; set; }

        public int PontosLivres { get; set; }

        public int Nivel { get; set; }

        public int Forca { get; set; }

        public int XPRestante { get; set; }

        public int HP { get; set; }

        public int Destresa { get; set; }

        public int Defesa { get; set; }

        public Classe Classe = new Classe();

        public string ClassePersonagem
        {
            get
            {
                if (this.Classe != null)
                    return this.Classe.Descricao;
                else
                    return string.Empty;
            }
        }
    }
}
