using System;
using System.Windows.Forms;
using Desafio.Cadastros;

namespace Desafio
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaClasses frm = new FrmConsultaClasses();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void personagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPersonagens frm = new FrmConsultaPersonagens();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
