namespace Desafio
{
    partial class FrmCadPersonagens
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblMstCodLivro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCodGenero = new System.Windows.Forms.Label();
            this.PnRodape = new System.Windows.Forms.Panel();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtClasse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPClasse = new System.Windows.Forms.Button();
            this.TxtCodClasse = new System.Windows.Forms.TextBox();
            this.txtForca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDestresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDefesa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNivel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtXP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtRestante = new System.Windows.Forms.TextBox();
            this.SomaForca = new System.Windows.Forms.Button();
            this.DiminuiForca = new System.Windows.Forms.Button();
            this.DiminuiDestresa = new System.Windows.Forms.Button();
            this.SomaDestresa = new System.Windows.Forms.Button();
            this.DiminuiHP = new System.Windows.Forms.Button();
            this.SomaHP = new System.Windows.Forms.Button();
            this.DiminuiDefesa = new System.Windows.Forms.Button();
            this.SomaDefesa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPontosLivres = new System.Windows.Forms.Label();
            this.PnRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtNome.Location = new System.Drawing.Point(12, 76);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(185, 20);
            this.TxtNome.TabIndex = 43;
            // 
            // LblMstCodLivro
            // 
            this.LblMstCodLivro.BackColor = System.Drawing.SystemColors.Control;
            this.LblMstCodLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMstCodLivro.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblMstCodLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblMstCodLivro.Location = new System.Drawing.Point(12, 27);
            this.LblMstCodLivro.Name = "LblMstCodLivro";
            this.LblMstCodLivro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblMstCodLivro.Size = new System.Drawing.Size(185, 17);
            this.LblMstCodLivro.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nome";
            // 
            // labelCodGenero
            // 
            this.labelCodGenero.AutoSize = true;
            this.labelCodGenero.Location = new System.Drawing.Point(12, 14);
            this.labelCodGenero.Name = "labelCodGenero";
            this.labelCodGenero.Size = new System.Drawing.Size(40, 13);
            this.labelCodGenero.TabIndex = 37;
            this.labelCodGenero.Text = "Código";
            // 
            // PnRodape
            // 
            this.PnRodape.Controls.Add(this.BtnConfirmar);
            this.PnRodape.Controls.Add(this.BtnSair);
            this.PnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnRodape.Location = new System.Drawing.Point(0, 403);
            this.PnRodape.Name = "PnRodape";
            this.PnRodape.Size = new System.Drawing.Size(800, 47);
            this.PnRodape.TabIndex = 44;
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
            // TxtClasse
            // 
            this.TxtClasse.BackColor = System.Drawing.SystemColors.Control;
            this.TxtClasse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtClasse.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtClasse.Location = new System.Drawing.Point(138, 119);
            this.TxtClasse.Name = "TxtClasse";
            this.TxtClasse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtClasse.Size = new System.Drawing.Size(185, 17);
            this.TxtClasse.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Classe";
            // 
            // BtnPClasse
            // 
            this.BtnPClasse.Location = new System.Drawing.Point(57, 115);
            this.BtnPClasse.Name = "BtnPClasse";
            this.BtnPClasse.Size = new System.Drawing.Size(75, 23);
            this.BtnPClasse.TabIndex = 53;
            this.BtnPClasse.Text = "Pesquisar";
            this.BtnPClasse.UseVisualStyleBackColor = true;
            this.BtnPClasse.Click += new System.EventHandler(this.BtnPClasse_Click);
            // 
            // TxtCodClasse
            // 
            this.TxtCodClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtCodClasse.Location = new System.Drawing.Point(12, 118);
            this.TxtCodClasse.Name = "TxtCodClasse";
            this.TxtCodClasse.Size = new System.Drawing.Size(32, 20);
            this.TxtCodClasse.TabIndex = 54;
            // 
            // txtForca
            // 
            this.txtForca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtForca.Location = new System.Drawing.Point(12, 196);
            this.txtForca.Name = "txtForca";
            this.txtForca.Size = new System.Drawing.Size(64, 20);
            this.txtForca.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Força";
            // 
            // TxtHP
            // 
            this.TxtHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtHP.Location = new System.Drawing.Point(12, 274);
            this.TxtHP.Name = "TxtHP";
            this.TxtHP.Size = new System.Drawing.Size(64, 20);
            this.TxtHP.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "HP";
            // 
            // TxtDestresa
            // 
            this.TxtDestresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDestresa.Location = new System.Drawing.Point(12, 235);
            this.TxtDestresa.Name = "TxtDestresa";
            this.TxtDestresa.Size = new System.Drawing.Size(64, 20);
            this.TxtDestresa.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Destresa";
            // 
            // txtDefesa
            // 
            this.txtDefesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDefesa.Location = new System.Drawing.Point(12, 313);
            this.txtDefesa.Name = "txtDefesa";
            this.txtDefesa.Size = new System.Drawing.Size(64, 20);
            this.txtDefesa.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Defesa";
            // 
            // TxtNivel
            // 
            this.TxtNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtNivel.Location = new System.Drawing.Point(12, 352);
            this.TxtNivel.Name = "TxtNivel";
            this.TxtNivel.Size = new System.Drawing.Size(64, 20);
            this.TxtNivel.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Nivel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "XP";
            // 
            // TxtXP
            // 
            this.TxtXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtXP.Location = new System.Drawing.Point(81, 352);
            this.TxtXP.Name = "TxtXP";
            this.TxtXP.Size = new System.Drawing.Size(64, 20);
            this.TxtXP.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "Restante";
            // 
            // TxtRestante
            // 
            this.TxtRestante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtRestante.Location = new System.Drawing.Point(151, 352);
            this.TxtRestante.Name = "TxtRestante";
            this.TxtRestante.Size = new System.Drawing.Size(64, 20);
            this.TxtRestante.TabIndex = 67;
            // 
            // SomaForca
            // 
            this.SomaForca.Location = new System.Drawing.Point(81, 195);
            this.SomaForca.Name = "SomaForca";
            this.SomaForca.Size = new System.Drawing.Size(31, 20);
            this.SomaForca.TabIndex = 69;
            this.SomaForca.Text = "+";
            this.SomaForca.UseVisualStyleBackColor = true;
            this.SomaForca.Click += new System.EventHandler(this.SomaForca_Click);
            // 
            // DiminuiForca
            // 
            this.DiminuiForca.Location = new System.Drawing.Point(114, 195);
            this.DiminuiForca.Name = "DiminuiForca";
            this.DiminuiForca.Size = new System.Drawing.Size(31, 20);
            this.DiminuiForca.TabIndex = 70;
            this.DiminuiForca.Text = "-";
            this.DiminuiForca.UseVisualStyleBackColor = true;
            this.DiminuiForca.Click += new System.EventHandler(this.DiminuiForca_Click);
            // 
            // DiminuiDestresa
            // 
            this.DiminuiDestresa.Location = new System.Drawing.Point(114, 234);
            this.DiminuiDestresa.Name = "DiminuiDestresa";
            this.DiminuiDestresa.Size = new System.Drawing.Size(31, 20);
            this.DiminuiDestresa.TabIndex = 72;
            this.DiminuiDestresa.Text = "-";
            this.DiminuiDestresa.UseVisualStyleBackColor = true;
            this.DiminuiDestresa.Click += new System.EventHandler(this.DiminuiDestresa_Click);
            // 
            // SomaDestresa
            // 
            this.SomaDestresa.Location = new System.Drawing.Point(82, 234);
            this.SomaDestresa.Name = "SomaDestresa";
            this.SomaDestresa.Size = new System.Drawing.Size(31, 20);
            this.SomaDestresa.TabIndex = 71;
            this.SomaDestresa.Text = "+";
            this.SomaDestresa.UseVisualStyleBackColor = true;
            this.SomaDestresa.Click += new System.EventHandler(this.SomaDestresa_Click);
            // 
            // DiminuiHP
            // 
            this.DiminuiHP.Location = new System.Drawing.Point(114, 273);
            this.DiminuiHP.Name = "DiminuiHP";
            this.DiminuiHP.Size = new System.Drawing.Size(31, 20);
            this.DiminuiHP.TabIndex = 74;
            this.DiminuiHP.Text = "-";
            this.DiminuiHP.UseVisualStyleBackColor = true;
            this.DiminuiHP.Click += new System.EventHandler(this.DiminuiHP_Click);
            // 
            // SomaHP
            // 
            this.SomaHP.Location = new System.Drawing.Point(81, 273);
            this.SomaHP.Name = "SomaHP";
            this.SomaHP.Size = new System.Drawing.Size(31, 20);
            this.SomaHP.TabIndex = 73;
            this.SomaHP.Text = "+";
            this.SomaHP.UseVisualStyleBackColor = true;
            this.SomaHP.Click += new System.EventHandler(this.SomaHP_Click);
            // 
            // DiminuiDefesa
            // 
            this.DiminuiDefesa.Location = new System.Drawing.Point(114, 312);
            this.DiminuiDefesa.Name = "DiminuiDefesa";
            this.DiminuiDefesa.Size = new System.Drawing.Size(31, 20);
            this.DiminuiDefesa.TabIndex = 76;
            this.DiminuiDefesa.Text = "-";
            this.DiminuiDefesa.UseVisualStyleBackColor = true;
            this.DiminuiDefesa.Click += new System.EventHandler(this.DiminuiDefesa_Click);
            // 
            // SomaDefesa
            // 
            this.SomaDefesa.Location = new System.Drawing.Point(81, 312);
            this.SomaDefesa.Name = "SomaDefesa";
            this.SomaDefesa.Size = new System.Drawing.Size(31, 20);
            this.SomaDefesa.TabIndex = 75;
            this.SomaDefesa.Text = "+";
            this.SomaDefesa.UseVisualStyleBackColor = true;
            this.SomaDefesa.Click += new System.EventHandler(this.SomaDefesa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Pontos";
            // 
            // TxtPontosLivres
            // 
            this.TxtPontosLivres.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPontosLivres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtPontosLivres.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtPontosLivres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPontosLivres.Location = new System.Drawing.Point(12, 163);
            this.TxtPontosLivres.Name = "TxtPontosLivres";
            this.TxtPontosLivres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPontosLivres.Size = new System.Drawing.Size(185, 17);
            this.TxtPontosLivres.TabIndex = 78;
            // 
            // FrmCadPersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPontosLivres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiminuiDefesa);
            this.Controls.Add(this.SomaDefesa);
            this.Controls.Add(this.DiminuiHP);
            this.Controls.Add(this.SomaHP);
            this.Controls.Add(this.DiminuiDestresa);
            this.Controls.Add(this.SomaDestresa);
            this.Controls.Add(this.DiminuiForca);
            this.Controls.Add(this.SomaForca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtRestante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtXP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNivel);
            this.Controls.Add(this.txtDefesa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDestresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtForca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodClasse);
            this.Controls.Add(this.BtnPClasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtClasse);
            this.Controls.Add(this.PnRodape);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblMstCodLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCodGenero);
            this.Name = "FrmCadPersonagens";
            this.Text = "FrmCadPersonagens";
            this.Load += new System.EventHandler(this.FrmCadPersonagens_Load);
            this.PnRodape.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNome;
        public System.Windows.Forms.Label LblMstCodLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCodGenero;
        private System.Windows.Forms.Panel PnRodape;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnSair;
        public System.Windows.Forms.Label TxtClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPClasse;
        private System.Windows.Forms.TextBox TxtCodClasse;
        private System.Windows.Forms.TextBox txtForca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDestresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDefesa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtXP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtRestante;
        private System.Windows.Forms.Button SomaForca;
        private System.Windows.Forms.Button DiminuiForca;
        private System.Windows.Forms.Button DiminuiDestresa;
        private System.Windows.Forms.Button SomaDestresa;
        private System.Windows.Forms.Button DiminuiHP;
        private System.Windows.Forms.Button SomaHP;
        private System.Windows.Forms.Button DiminuiDefesa;
        private System.Windows.Forms.Button SomaDefesa;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label TxtPontosLivres;
    }
}

