namespace Desafio
{
    partial class FrmConsultaClasses
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
            this.PnGrid = new System.Windows.Forms.Panel();
            this.DgvListaRegistros = new Desafio.UserControls.DataGridCustomizada();
            this.PnRodape = new System.Windows.Forms.Panel();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clForca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDestresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDefesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRegistros)).BeginInit();
            this.PnRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnGrid
            // 
            this.PnGrid.Controls.Add(this.DgvListaRegistros);
            this.PnGrid.Location = new System.Drawing.Point(12, 12);
            this.PnGrid.Name = "PnGrid";
            this.PnGrid.Size = new System.Drawing.Size(776, 385);
            this.PnGrid.TabIndex = 0;
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
            this.DgvListaRegistros.Location = new System.Drawing.Point(4, 4);
            this.DgvListaRegistros.Name = "DgvListaRegistros";
            this.DgvListaRegistros.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.DgvListaRegistros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaRegistros.Size = new System.Drawing.Size(769, 381);
            this.DgvListaRegistros.TabIndex = 0;
            // 
            // PnRodape
            // 
            this.PnRodape.Controls.Add(this.BtnInserir);
            this.PnRodape.Controls.Add(this.BtnAlterar);
            this.PnRodape.Controls.Add(this.BtnExcluir);
            this.PnRodape.Controls.Add(this.BtnSair);
            this.PnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnRodape.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnRodape.Location = new System.Drawing.Point(0, 403);
            this.PnRodape.Name = "PnRodape";
            this.PnRodape.Size = new System.Drawing.Size(800, 47);
            this.PnRodape.TabIndex = 1;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnInserir.Location = new System.Drawing.Point(500, 0);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 47);
            this.BtnInserir.TabIndex = 3;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAlterar.Location = new System.Drawing.Point(575, 0);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 47);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExcluir.Location = new System.Drawing.Point(650, 0);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 47);
            this.BtnExcluir.TabIndex = 1;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
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
            // FrmConsultaClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnRodape);
            this.Controls.Add(this.PnGrid);
            this.Name = "FrmConsultaClasses";
            this.Text = "FrmConsultaClasses";
            this.Load += new System.EventHandler(this.FrmConsultaClasses_Load);
            this.PnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRegistros)).EndInit();
            this.PnRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnGrid;
        private System.Windows.Forms.Panel PnRodape;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private UserControls.DataGridCustomizada DgvListaRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clForca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDestresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDefesa;
    }
}