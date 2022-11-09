using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class FrmPesquisaClasse : Form
    {

         private Classe selecionado;

        public FrmPesquisaClasse()
        {
            InitializeComponent();
        }

        public FrmPesquisaClasse(List<Classe> ListaClasses)
        {
            InitializeComponent();
            popularDataGrid(ListaClasses);
        }

        private void FrmPesquisaGenerica_Load(object sender, EventArgs e)
        {

        }

        private void popularDataGrid(List<Classe> ListaClasses)
        {
            this.DgvListaRegistros.DataSource = ListaClasses;
        }

        private bool SelecionarRegistro()
        {
            if (DgvListaRegistros.Rows.Count > 0)
            {
                try
                {
                    this.selecionado = (Classe)this.DgvListaRegistros.CurrentRow.DataBoundItem;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
                return false;
        }

        private void Confirmar()
        {
            if (SelecionarRegistro())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public Classe RetornaSelecionado()
        {
            return selecionado;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void DgvListaRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                Confirmar();
        }
    }
}
