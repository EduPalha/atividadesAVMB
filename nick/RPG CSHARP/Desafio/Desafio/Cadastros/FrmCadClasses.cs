using BaseDados;
using Entidades;
using System;
using System.Windows.Forms;

namespace Desafio.Cadastros
{
    public partial class FrmCadClasses : Form
    {

        private bool IsNovo;
        private Classe Cadastro;
        public FrmCadClasses()
        {
            this.IsNovo = true;
            InitializeComponent();
        }

        private void FrmCadClasses_Load(object sender, EventArgs e)
        {
            if (IsNovo)
                this.Cadastro = new Classe();
            PopulaControles();
        }

        public FrmCadClasses(Classe Classe)
        {
            InitializeComponent();
            this.Cadastro = Classe;
            IsNovo = false;
        }

        private void PopulaControles()
        {
            TxtDescricao.Text = Cadastro.Descricao;
            TxtCodigo.Text = Cadastro.Codigo.ToString();
            TxtDefesa.Text = Cadastro.Defesa.ToString();
            TxtDestresa.Text = Cadastro.Destresa.ToString();
            TxtHP.Text = Cadastro.HP.ToString();
            TxtForça.Text = Cadastro.Forca.ToString();
        }

        private void PopulaObjeto()
        {
            this.Cadastro.Descricao = TxtDescricao.Text;
            this.Cadastro.Forca = Convert.ToInt32(TxtForça.Text);
            this.Cadastro.Defesa = Convert.ToInt32(TxtDefesa.Text);
            this.Cadastro.HP = Convert.ToInt32(TxtHP.Text);
            this.Cadastro.Destresa = Convert.ToInt32(TxtDestresa.Text);
        }

        private void LimparControles()
        {
            TxtDescricao.Text = string.Empty;
            TxtCodigo.Text = string.Empty;
            TxtDefesa.Text = string.Empty;
            TxtDestresa.Text = string.Empty;
            TxtHP.Text = string.Empty;
            TxtForça.Text = string.Empty;
        }

        private void Inserir()
        {
            try
            {
                Conexao _bd = new Conexao();
                _bd.InserirCLasse(this.Cadastro);

                MessageBox.Show("Classe Inserida Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Alterar()
        {
            try
            {
                Conexao _bd = new Conexao();
                _bd.AlterarClasse(this.Cadastro);

                MessageBox.Show("Classe Alterada Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salvar()
        {
            if (TxtDescricao.Text != "" && TxtForça.Text != "" && TxtHP.Text != "" && TxtDestresa.Text != "" && TxtDefesa.Text != "")
            {
                PopulaObjeto();
                if (IsNovo)
                    Inserir();
                else
                    Alterar();

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Buttons
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

                Salvar();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
