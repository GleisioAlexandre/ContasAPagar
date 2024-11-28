using ContasAPagar.controller;
using ContasAPagar.model;
using ContasAPagar.view.Cadastros.Fornecedor;
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
    public partial class Frm_Fornecedor : Form
    {
        ClasseFornecedores fornecedores = new ClasseFornecedores();
        public Frm_Fornecedor()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            try
            {
                var lista = fornecedores.CarregaGRidFornecedor();
                bindingSource.DataSource = new BindingList<ClasseFornecedor>(lista);
                dtgFornecedor.DataSource = bindingSource;
                bindingNavigator.BindingSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Carregar os dados! \n\f Erro: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Frm_CadFornecedor cadFornecedor = new Frm_CadFornecedor();
            cadFornecedor.ShowDialog();
        }
        
        private void Frm_Fornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dtgFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(dtgFornecedor.Rows[e.RowIndex].Cells[0].Value?.ToString());
                    string descricao = dtgFornecedor.Rows[e.RowIndex].Cells[1].Value?.ToString();

                    Console.WriteLine(id + descricao);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
