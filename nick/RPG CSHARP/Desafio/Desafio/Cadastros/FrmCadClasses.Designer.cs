namespace Desafio.Cadastros
{
    partial class FrmCadClasses
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
            this.label8 = new System.Windows.Forms.Label();
            this.TxtHP = new System.Windows.Forms.TextBox();
            this.TxtDestresa = new System.Windows.Forms.TextBox();
            this.TxtForça = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PnRodape = new System.Windows.Forms.Panel();
            this.TxtCodigo = new System.Windows.Forms.Label();
            this.labelCodGenero = new System.Windows.Forms.Label();
            this.TxtDefesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PnRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "label8";
            // 
            // TxtHP
            // 
            this.TxtHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtHP.Location = new System.Drawing.Point(60, 129);
            this.TxtHP.Name = "TxtHP";
            this.TxtHP.Size = new System.Drawing.Size(42, 20);
            this.TxtHP.TabIndex = 2;
            // 
            // TxtDestresa
            // 
            this.TxtDestresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDestresa.Location = new System.Drawing.Point(12, 187);
            this.TxtDestresa.Name = "TxtDestresa";
            this.TxtDestresa.Size = new System.Drawing.Size(42, 20);
            this.TxtDestresa.TabIndex = 3;
            // 
            // TxtForça
            // 
            this.TxtForça.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtForça.Location = new System.Drawing.Point(12, 129);
            this.TxtForça.Name = "TxtForça";
            this.TxtForça.Size = new System.Drawing.Size(42, 20);
            this.TxtForça.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDescricao.Location = new System.Drawing.Point(12, 71);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(185, 20);
            this.TxtDescricao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Destresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Força";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConfirmar.Location = new System.Drawing.Point(650, 0);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 47);
            this.BtnConfirmar.TabIndex = 0;
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
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "HP";
            // 
            // PnRodape
            // 
            this.PnRodape.Controls.Add(this.BtnConfirmar);
            this.PnRodape.Controls.Add(this.BtnSair);
            this.PnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnRodape.Location = new System.Drawing.Point(0, 403);
            this.PnRodape.Name = "PnRodape";
            this.PnRodape.Size = new System.Drawing.Size(800, 47);
            this.PnRodape.TabIndex = 5;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCodigo.Location = new System.Drawing.Point(12, 27);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCodigo.Size = new System.Drawing.Size(185, 17);
            this.TxtCodigo.TabIndex = 72;
            // 
            // labelCodGenero
            // 
            this.labelCodGenero.AutoSize = true;
            this.labelCodGenero.Location = new System.Drawing.Point(12, 14);
            this.labelCodGenero.Name = "labelCodGenero";
            this.labelCodGenero.Size = new System.Drawing.Size(40, 13);
            this.labelCodGenero.TabIndex = 70;
            this.labelCodGenero.Text = "Código";
            // 
            // TxtDefesa
            // 
            this.TxtDefesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDefesa.Location = new System.Drawing.Point(60, 187);
            this.TxtDefesa.Name = "TxtDefesa";
            this.TxtDefesa.Size = new System.Drawing.Size(42, 20);
            this.TxtDefesa.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Defesa";
            // 
            // FrmCadClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDefesa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtHP);
            this.Controls.Add(this.TxtDestresa);
            this.Controls.Add(this.TxtForça);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PnRodape);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.labelCodGenero);
            this.Name = "FrmCadClasses";
            this.Text = "5";
            this.Load += new System.EventHandler(this.FrmCadClasses_Load);
            this.PnRodape.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtHP;
        private System.Windows.Forms.TextBox TxtDestresa;
        private System.Windows.Forms.TextBox TxtForça;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PnRodape;
        public System.Windows.Forms.Label TxtCodigo;
        private System.Windows.Forms.Label labelCodGenero;
        private System.Windows.Forms.TextBox TxtDefesa;
        private System.Windows.Forms.Label label6;
    }
}