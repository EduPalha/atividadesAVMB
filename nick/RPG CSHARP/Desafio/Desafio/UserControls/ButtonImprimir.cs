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
    public partial class ButtonImprimir : Button
    {
        public ButtonImprimir()
        {
            InitializeComponent();
            ConfigurarComponente();

        }

        private void ConfigurarComponente()
        {
            this.Size = new System.Drawing.Size(64, 42);
            this.ImageAlign = ContentAlignment.TopCenter;
            this.TextAlign = ContentAlignment.BottomCenter;
            this.Image = Properties.Resources.print_32x32;
        }

        public override string Text {
            get
            {
                return "Imprimir";
            }
        }

        protected override void OnCreateControl()
        {
            ConfigurarComponente();
        }
    }
}
