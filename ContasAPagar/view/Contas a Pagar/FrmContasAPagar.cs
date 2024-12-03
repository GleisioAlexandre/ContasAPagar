using ContasAPagar.controller;
using ContasAPagar.model;
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
        ClasseContasAPagar contAPagar = new ClasseContasAPagar();
        public FrmContasAPagar()
        {
            InitializeComponent();
        }
        private void CarregaGridContasAPagar()
        {
            try
            {
                var lista = contAPagar.CarregaGridContasAPagar();
                bindingSource.DataSource = new BindingList<ClasseContAPagar>(lista);
                dtgContasAPagar.DataSource = bindingSource;
                bindingNavigator.BindingSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Carregar os dados! \n\f Erro: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            FrmLancamentoContasAReceber lancamento = new FrmLancamentoContasAReceber();
            lancamento.ShowDialog();
        }
       
        private void FrmContasAPagar_Load(object sender, EventArgs e)
        {
            CarregaGridContasAPagar();
        }
    }
}
