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
    public partial class DataGridCustomizada : DataGridView
    {
        public DataGridCustomizada()
        {
            InitializeComponent();
            ConfigurarComponente();
        }

        private void ConfigurarComponente()
        {
            this.AutoGenerateColumns = false;
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.RowsDefaultCellStyle.BackColor = Color.White;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
        }

        protected override void OnCreateControl()
        {
            ConfigurarComponente();
        }

    }
}
