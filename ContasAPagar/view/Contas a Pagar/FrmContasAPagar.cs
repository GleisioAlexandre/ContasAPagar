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
    public partial class FrmContasAPagar : Form
    {
        public FrmContasAPagar()
        {
            InitializeComponent();
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            FrmLancamentoContasAReceber lancamento = new FrmLancamentoContasAReceber();
            lancamento.ShowDialog();
        }
    }
}
