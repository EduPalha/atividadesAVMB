using BaseDados;
using Entidades;
using Utilitarios;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Desafio.Utilitarios;
using Utilitarios;
using Desafio.Utilitarios;
using System.Globalization;

namespace Desafio
{
    public partial class FrmCadPersonagens : Form
    {
        private bool IsNovo;
        private Personagem Cadastro;

        public FrmCadPersonagens()
        {
            this.IsNovo = true;
            InitializeComponent();
        }

        public FrmCadPersonagens(Personagem Personagem)
        {
            InitializeComponent();
            this.Cadastro = Personagem;
            IsNovo = false;
        }

        private void FrmCadPersonagens_Load(object sender, EventArgs e)
        {
            if (IsNovo)
                this.Cadastro = new Personagem();
            Bind();
        }


        private void Bind() {
            this.txtForca.DataBindings.Clear();
            this.TxtDestresa.DataBindings.Clear();
            this.TxtHP.DataBindings.Clear();
            this.txtDefesa.DataBindings.Clear();
            this.TxtPontosLivres.DataBindings.Clear();
            this.TxtNome.DataBindings.Clear();

            this.txtForca.DataBindings.Add("Text", this.Cadastro, "Forca", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtDestresa.DataBindings.Add("Text", this.Cadastro, "Destresa", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtHP.DataBindings.Add("Text", this.Cadastro, "HP", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtDefesa.DataBindings.Add("Text", this.Cadastro, "Defesa", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtPontosLivres.DataBindings.Add("Text", this.Cadastro, "PontosLivres", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtNome.DataBindings.Add("Text", this.Cadastro, "Nome", false, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void Inserir()
        {
            try
            {
                Conexao _bd = new Conexao();
                _bd.InserirPersonagem(this.Cadastro);
                MessageBox.Show("Personagem Inserido Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
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
                _bd.AlterarPersonagem(this.Cadastro);
                MessageBox.Show("Personagem Alterado Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salvar()
        {
            Bind();
            if (IsNovo)
                Inserir();
            else
                Alterar();
        }

        //Validacoes
        private bool ValidarNome()
        {
            if (TxtNome.Text == string.Empty)
            {
                MessageBox.Show("Os campos devem ser preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                TxtNome.SelectAll();
                return false;
            }
            return true;
        }


        private void ProcurarClasse()
        {
            Conexao _db = new Conexao();
            List<Classe> listaRegistros = _db.ListarClasses();
            FrmPesquisaClasse frm = new FrmPesquisaClasse(listaRegistros.ConvertAll(x => x).ToList<Classe>());
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cadastro.Classe = (Classe)frm.RetornaSelecionado();
                TxtClasse.Text = Cadastro.ClassePersonagem;
                TxtCodClasse.Text = Cadastro.Classe.Codigo.ToString();

                ResetarAtributos();
            }
            else
            {
                MessageBox.Show("Não foram encontradas Classes com este código", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtClasse.Text = string.Empty;
                TxtCodClasse.Text = string.Empty;
            }
        }

        private void ResetarAtributos()
        {   if ((this.Cadastro.Forca - this.Cadastro.Classe.Forca) + (this.Cadastro.HP - this.Cadastro.Classe.HP) + (this.Cadastro.Destresa - this.Cadastro.Classe.Destresa) + (this.Cadastro.Defesa - this.Cadastro.Classe.Defesa) > 0)
                this.Cadastro.PontosLivres = (this.Cadastro.Forca - this.Cadastro.Classe.Forca) + (this.Cadastro.HP - this.Cadastro.Classe.HP) + (this.Cadastro.Destresa - this.Cadastro.Classe.Destresa) + (this.Cadastro.Defesa - this.Cadastro.Classe.Defesa);
            else
                this.Cadastro.PontosLivres = 10;

            this.Cadastro.Forca = this.Cadastro.Classe.Forca;
            this.Cadastro.HP = this.Cadastro.Classe.HP;
            this.Cadastro.Destresa = this.Cadastro.Classe.Destresa;
            this.Cadastro.Defesa = this.Cadastro.Classe.Defesa;

            Bind();
        }

        //Buttons

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void BtnPClasse_Click(object sender, EventArgs e)
        {
            ProcurarClasse();
        }

        private void BtnPGenero_Click(object sender, EventArgs e)
        {
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SomaForca_Click(object sender, EventArgs e)
        {
            this.Cadastro.Forca = SomarAtributo(Cadastro.Forca);
            this.txtForca.Text = Cadastro.Forca.ToString();
        }

        private int SomarAtributo(int Atributo)
        {
            try
            {
                if (this.Cadastro.PontosLivres > 0)
                {
                    Atributo++;
                    this.Cadastro.PontosLivres--;
                    this.TxtPontosLivres.Text = Cadastro.PontosLivres.ToString();
                }
                else
                    MessageBox.Show("O personagem não tem mais pontos restantes");
                return Atributo;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Atributo;
            }
        }

        private void SomaDestresa_Click(object sender, EventArgs e)
        {
            this.Cadastro.Destresa = SomarAtributo(Cadastro.Destresa);
            this.TxtDestresa.Text = Cadastro.Destresa.ToString();
        }

        private void SomaHP_Click(object sender, EventArgs e)
        {
            this.Cadastro.HP = SomarAtributo(Cadastro.HP);
            this.TxtHP.Text = Cadastro.HP.ToString();
        }

        private void SomaDefesa_Click(object sender, EventArgs e)
        {
            this.Cadastro.Defesa = SomarAtributo(Cadastro.Defesa);
            this.txtDefesa.Text = Cadastro.Defesa.ToString();
        }
        private int SubtrairAtributo(int Atributo)
        {
            try
            {
                Atributo--;
                this.Cadastro.PontosLivres++;
                this.TxtPontosLivres.Text = Cadastro.PontosLivres.ToString();
                return Atributo;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Atributo;
            }
        }
        private int ValidarSubtracao(int AtributoPersonagem , int AtributoClasse)
        {
            if ((AtributoPersonagem - 1) >= AtributoClasse)
                AtributoPersonagem = SubtrairAtributo(AtributoPersonagem);
            else
                MessageBox.Show("Não é possível diminuir mais pontos nesse atributo, pois o personagem atingiu o mínimo para sua classe");
            return AtributoPersonagem;
        }

        private void DiminuiForca_Click(object sender, EventArgs e)
        {

            this.Cadastro.Forca = ValidarSubtracao(this.Cadastro.Forca, this.Cadastro.Classe.Forca);
            this.txtForca.Text = Cadastro.Forca.ToString();
        }
        private void DiminuiDestresa_Click(object sender, EventArgs e)
        {
            this.Cadastro.Destresa = ValidarSubtracao(this.Cadastro.Destresa, this.Cadastro.Classe.Destresa);
            this.TxtDestresa.Text = Cadastro.Destresa.ToString();
        }

        private void DiminuiHP_Click(object sender, EventArgs e)
        {
            this.Cadastro.HP = ValidarSubtracao(this.Cadastro.HP, this.Cadastro.Classe.HP);
            this.TxtHP.Text = Cadastro.HP.ToString();
        }

        private void DiminuiDefesa_Click(object sender, EventArgs e)
        {
            this.Cadastro.Defesa = ValidarSubtracao(this.Cadastro.Defesa, this.Cadastro.Classe.Defesa);
            this.TxtDestresa.Text = Cadastro.Defesa.ToString();
        }
    }
}

