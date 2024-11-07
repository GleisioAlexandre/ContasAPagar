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
    public partial class Frm_Situacao : Form
    {
        public Frm_Situacao()
        {
            InitializeComponent();
        }

        private void btnNSituacao_Click(object sender, EventArgs e)
        {
            FrmCadSituacao situacao = new FrmCadSituacao();
            situacao.ShowDialog();
        }
    }
}
