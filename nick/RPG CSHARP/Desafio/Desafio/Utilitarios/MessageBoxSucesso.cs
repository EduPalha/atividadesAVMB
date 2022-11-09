using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desafio.Utilitarios
{
    public static class MessageBoxSucesso
    {
        public static void Show(string message)
        {
            MessageBox.Show(message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
