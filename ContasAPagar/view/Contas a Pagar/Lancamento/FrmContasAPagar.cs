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
            FrmLancamentoContasAReceber lancamento = new FrmLancamentoContasAReceber(this);
            lancamento.ShowDialog();
        }
       
        private void FrmContasAPagar_Load(object sender, EventArgs e)
        {
            CarregaGridContasAPagar();
        }

        private void dtgContasAPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(dtgContasAPagar.Rows[e.RowIndex].Cells[0].Value);
                    DateTime lancamento = Convert.ToDateTime(dtgContasAPagar.Rows[e.RowIndex].Cells[1].Value);
                    string fornecedor = dtgContasAPagar.Rows[e.RowIndex].Cells[2].Value.ToString();

                    FrmLancamentoContasAReceber lancamentoContasAReceber = new FrmLancamentoContasAReceber(this, id, lancamento, fornecedor);
                    lancamentoContasAReceber.ShowDialog();
                    Console.WriteLine("Id:" + id + " Fornecedor: " + fornecedor);

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
