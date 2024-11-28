using ContasAPagar.view.Cadastros.Plano_de_Contas;
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

        private void documentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoDocumento documento = new Frm_TipoDocumento();
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

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PlanoDeContas planoDeContas = new Frm_PlanoDeContas();
            planoDeContas.MdiParent = this;
            planoDeContas.Show();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Configuracoes configuracoes = new Frm_Configuracoes();
            configuracoes.MdiParent = this;
            configuracoes.Show();
        }
    }
}
