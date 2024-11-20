using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAPagar.view
{
    public partial class FrmLancamentoContasAReceber : Form
    {
        public FrmLancamentoContasAReceber()
        {
            InitializeComponent();
        }

        private void FrmLancamentoContasAReceber_Load(object sender, EventArgs e)
        {
            // lblLancamento.TabStop = false;
            gpbSituacao.TabStop = true;
        }
    }
}
