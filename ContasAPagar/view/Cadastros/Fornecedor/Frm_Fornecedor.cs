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
        public void CarregaGrid()
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
            Frm_CadFornecedor cadFornecedor = new Frm_CadFornecedor(this);
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
                    int id = Convert.ToInt32(dtgFornecedor.Rows[e.RowIndex].Cells[0].Value);
                    string nome = dtgFornecedor.Rows[e.RowIndex].Cells[1].Value?.ToString();
                   string cadastroPessoa = dtgFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                   string cep = dtgFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                   string logradouro = dtgFornecedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                   int numero = Convert.ToInt32(dtgFornecedor.Rows[e.RowIndex].Cells[5].Value);
                   string complemento = dtgFornecedor.Rows[e.RowIndex].Cells[6].Value.ToString();
                   string bairro = dtgFornecedor.Rows[e.RowIndex].Cells[7].Value.ToString();
                   string cidade = dtgFornecedor.Rows[e.RowIndex].Cells[8].Value.ToString();
                   string estado = dtgFornecedor.Rows[e.RowIndex].Cells[9].Value.ToString();
                   string telefone = dtgFornecedor.Rows[e.RowIndex].Cells[10].Value.ToString();
                   string celular = dtgFornecedor.Rows[e.RowIndex].Cells[11].Value.ToString();
                   string email = dtgFornecedor.Rows[e.RowIndex].Cells[12].Value.ToString();
                   string obs = dtgFornecedor.Rows[e.RowIndex].Cells[13].Value.ToString();
                   if (!string.IsNullOrWhiteSpace(nome))
                    {

                        Frm_CadFornecedor cadFornecedor = new Frm_CadFornecedor(this, id, nome, cadastroPessoa, cep, logradouro, numero, complemento, bairro, cidade, estado, telefone, celular, email, obs);
                        cadFornecedor.ShowDialog();
                   }
                   else
                   {
                       MessageBox.Show("Nome invalida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Erro: {ex}");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dtgFornecedor[1,0].Value);
        }
    }
}
