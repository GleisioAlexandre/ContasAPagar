using ContasAPagar.view.Cadastros.Documento;
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
    public partial class Frm_Documento : Form
    {
        public Frm_Documento()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Frm_CadTipoDocumento cadTipoDocumento = new Frm_CadTipoDocumento();
            cadTipoDocumento.ShowDialog();
        }
    }
}
