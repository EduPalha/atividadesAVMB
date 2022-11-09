namespace Desafio
{
    partial class FrmPesquisaClasse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnRodape = new System.Windows.Forms.Panel();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.DgvListaRegistros = new Desafio.UserControls.DataGridCustomizada();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clForca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDestresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDefesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // PnRodape
            // 
            this.PnRodape.Controls.Add(this.BtnConfirmar);
            this.PnRodape.Controls.Add(this.BtnSair);
            this.PnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnRodape.Location = new System.Drawing.Point(0, 403);
            this.PnRodape.Name = "PnRodape";
            this.PnRodape.Size = new System.Drawing.Size(800, 47);
            this.PnRodape.TabIndex = 45;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConfirmar.Location = new System.Drawing.Point(650, 0);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 47);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSair.Location = new System.Drawing.Point(725, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DgvListaRegistros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.DgvListaRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigo,
            this.clDescricao,
            this.clForca,
            this.clHP,
            this.clDestresa,
            this.clDefesa});
            this.DgvListaRegistros.Location = new System.Drawing.Point(0, 3);
            this.DgvListaRegistros.Name = "DgvListaRegistros";
            this.DgvListaRegistros.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.DgvListaRegistros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaRegistros.Size = new System.Drawing.Size(800, 394);
            this.DgvListaRegistros.TabIndex = 46;
            // 
            // ClCodigo
            // 
            this.ClCodigo.DataPropertyName = "Codigo";
            this.ClCodigo.HeaderText = "Codigo";
            this.ClCodigo.Name = "ClCodigo";
            // 
            // clDescricao
            // 
            this.clDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDescricao.DataPropertyName = "Descricao";
            this.clDescricao.HeaderText = "Descrição";
            this.clDescricao.Name = "clDescricao";
            // 
            // clForca
            // 
            this.clForca.DataPropertyName = "Forca";
            this.clForca.HeaderText = "Força";
            this.clForca.Name = "clForca";
            // 
            // clHP
            // 
            this.clHP.DataPropertyName = "HP";
            this.clHP.HeaderText = "HP";
            this.clHP.Name = "clHP";
            // 
            // clDestresa
            // 
            this.clDestresa.DataPropertyName = "Destresa";
            this.clDestresa.HeaderText = "Destresa";
            this.clDestresa.Name = "clDestresa";
            // 
            // clDefesa
            // 
            this.clDefesa.DataPropertyName = "Defesa";
            this.clDefesa.HeaderText = "Defesa";
            this.clDefesa.Name = "clDefesa";
            // 
            // FrmPesquisaClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvListaRegistros);
            this.Controls.Add(this.PnRodape);
            this.Name = "FrmPesquisaClasse";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPesquisaGenerica_Load);
            this.PnRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnRodape;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnSair;
        private UserControls.DataGridCustomizada DgvListaRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clForca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDestresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDefesa;
    }
}