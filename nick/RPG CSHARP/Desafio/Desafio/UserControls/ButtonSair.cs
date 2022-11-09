using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Desafio.UserControls
{
    public partial class ButtonSair : Button
    {
        public ButtonSair()
        {
            InitializeComponent();
            ConfigurarComponente();
        }

        private void ConfigurarComponente()
        {
            this.Size = new System.Drawing.Size(64, 42);
            this.ImageAlign = ContentAlignment.TopCenter;
            this.TextAlign = ContentAlignment.BottomCenter;
            this.Image = Properties.Resources.est_exit_16x16;
        }

        public override string Text
        {
            get
            {
                return "Sair";
            }
        }

        protected override void OnCreateControl()
        {
            ConfigurarComponente();
        }
    }
}
