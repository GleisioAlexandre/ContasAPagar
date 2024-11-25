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

namespace ContasAPagar.view.Cadastros.Plano_de_Contas
{
    public partial class Frm_PlanoDeContas : Form
    {
        private ClassePContas classePContas = new ClassePContas();
        public Frm_PlanoDeContas()
        {
            InitializeComponent();
        }
        public void CarregaGrid()
        {
            var lista = classePContas.CarregaGridPDContas();
            bindingSource.DataSource = new BindingList<ClassePlanoDeContas>(lista);
            dtgPlanoDeContas.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Frm_CadPlanoDeContas cadPlanoDeContas = new Frm_CadPlanoDeContas(this);
            cadPlanoDeContas.ShowDialog();
        }

        private void Frm_PlanoDeContas_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dtgPlanoDeContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > 0)
                {
                    int id = Convert.ToInt32(dtgPlanoDeContas.Rows[e.RowIndex].Cells[0].Value);
                    string descricao = dtgPlanoDeContas.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (!string.IsNullOrWhiteSpace(descricao))
                    {
                        Frm_CadPlanoDeContas frm_CadPlanoDeContas = new Frm_CadPlanoDeContas(this, id, descricao);
                        frm_CadPlanoDeContas.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulario: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
