using BaseDados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Desafio.Cadastros;

namespace Desafio
{
    public partial class FrmConsultaClasses : Form
    {
        private  Classe Selecionada;

        public FrmConsultaClasses()
        {
            InitializeComponent();
        }

        private void FrmConsultaClasses_Load(object sender, EventArgs e)
        {
            this.DgvListaRegistros.AutoGenerateColumns = false;
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            try
            {
                List<Classe> listaRegistros = new Conexao().ListarClasses();
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
                    this.Selecionada = (Classe)this.DgvListaRegistros.CurrentRow.DataBoundItem;
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
            FrmCadClasses frm = new FrmCadClasses();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
                CarregarRegistros();
        }

        private void AlterarRegistro()
        {
            if (SelecionarRegistro())
            {
                FrmCadClasses frm = new FrmCadClasses(this.Selecionada);
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
                    _db.ExcluirClasse(this.Selecionada);
                    CarregarRegistros();
                    MessageBox.Show("Classe Deletada Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    if (ex.Message.StartsWith("Cannot delete or update a parent row: a foreign key constraint fails "))
                        MessageBox.Show("Não é possivel deletar, porque a classe está associada a um livro.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
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
    }
}
