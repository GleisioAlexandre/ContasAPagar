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
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void situaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Situacao situacao = new Frm_Situacao();
            situacao.MdiParent = this;
            situacao.Show();
        }

        private void documentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Documento documento = new Frm_Documento();
            documento.MdiParent = this;
            documento.Show();
        }

        private void fornecdorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Fornecedor fornecedor = new Frm_Fornecedor();
            fornecedor.MdiParent = this;
            fornecedor.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasAPagar contasAPagar = new FrmContasAPagar();
            contasAPagar.MdiParent = this;
            contasAPagar.Show();
        }
    }
}
