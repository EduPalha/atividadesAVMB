using BaseDados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desafio
{
    public partial class FrmConsultaPersonagens : Form
    {
        private Personagem Selecionado;

        public FrmConsultaPersonagens()
        {
            InitializeComponent();
        }

        private void FrmConsultaPersonagens_Load(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            try
            {
                Conexao _db = new Conexao();
                List<Personagem> listaRegistros = _db.ListarPersonagens();
                this.DgvListaRegistros.DataSource = listaRegistros;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SelecionarRegistro()
        {
            if (DgvListaRegistros.Rows.Count > 0 ){
                try
                {
                    this.Selecionado = (Personagem)this.DgvListaRegistros.CurrentRow.DataBoundItem;
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

        private void InserirRegistro()
        {
            FrmCadPersonagens frm = new FrmCadPersonagens();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
                CarregarRegistros();
        }

        private void AlterarRegistro()
        {
            if (SelecionarRegistro())
            {
                FrmCadPersonagens frm = new FrmCadPersonagens(this.Selecionado);
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregarRegistros();
            }
        }

        private void ExcluirRegistro()
        {
            if (SelecionarRegistro())
            {
                try
                {
                    Conexao _db = new Conexao();
                    _db.ExcluirPersonagem(this.Selecionado);
                    CarregarRegistros();
                    MessageBox.Show("Personagem Deletado Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Buttons
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            InserirRegistro();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            AlterarRegistro();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaRegistros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarRegistro();
        }
    }
}
