using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{

    public class Validacoes
    {
        public static bool ValidarInteiro(String txt)
        {
            int number;
            if (Int32.TryParse(txt, out number))
            {
                return true;
            }
            else
                return false;
        }
    }


}
