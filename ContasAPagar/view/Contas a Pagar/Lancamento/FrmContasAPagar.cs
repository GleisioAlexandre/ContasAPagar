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
        private int? idFornecedor;
        ClasseContasAPagar contAPagar = new ClasseContasAPagar();
        public FrmContasAPagar()
        {
            InitializeComponent();
            idFornecedor = null;
        }
        private void FormataTextbox()
        {
            string data = txtDados.Text.Replace("/", "");
                if (data.Length > 8) data = data.Substring(0, 8);

            if (data.Length >= 2)
                data = data.Insert(2, "/");
            if (data.Length >= 5)
                data = data.Insert(5, "/");

            txtDados.Text = data;
            txtDados.SelectionStart = data.Length;
        }
            public void CalculoarValor()
        {
            double soma = 0;
            foreach (DataGridViewRow row in dtgContasAPagar.Rows)
            {
                if (row.Cells["Valor"].Value != null && !row.IsNewRow)
                {
                    if (double.TryParse(row.Cells["Valor"].Value.ToString(), out double valor))
                    {
                        soma += valor;
                    }
                }
            }
            lblValor.Text = $"{soma:C2}";
        }
        public void CarregaGridContasAPagar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = contAPagar.CarregaGridContasAPagar();
                bindingSource.DataSource = dt;
                idFornecedor = Convert.ToInt32(dtgContasAPagar.SelectedRows[0].Cells["ID_FORNECEDOR"].Value);
                dtgContasAPagar.DataSource = bindingSource;
                bindingNavigator.BindingSource = bindingSource;

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        Console.WriteLine($"Coluna: {column.ColumnName}, Valor: {row[column]}");
                    }

                }
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
            CalculoarValor();
        }
        private void dtgContasAPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(dtgContasAPagar.Rows[e.RowIndex].Cells[0].Value);
                    DateTime lancamento = Convert.ToDateTime(dtgContasAPagar.Rows[e.RowIndex].Cells[1].Value);
                    double valor = Convert.ToDouble(dtgContasAPagar.Rows[e.RowIndex].Cells[3].Value);
                    string documento = dtgContasAPagar.Rows[e.RowIndex].Cells[5].Value.ToString();
                    DateTime vencimento = Convert.ToDateTime(dtgContasAPagar.Rows[e.RowIndex].Cells[7].Value);
                    DateTime pagamento = Convert.ToDateTime(dtgContasAPagar.Rows[e.RowIndex].Cells[8].Value);
                    string obs = dtgContasAPagar.Rows[e.RowIndex].Cells[10].Value.ToString();
                    int idFornecedorSelecionado = Convert.ToInt32(dtgContasAPagar.Rows[e.RowIndex].Cells[11].Value);
                    int idDocumentoSelecionado = Convert.ToInt32(dtgContasAPagar.Rows[e.RowIndex].Cells[12].Value);
                    int idPlanoDeContasSelecionado = Convert.ToInt32(dtgContasAPagar.Rows[e.RowIndex].Cells[13].Value);
                    int idSituacao = Convert.ToInt32(dtgContasAPagar.Rows[e.RowIndex].Cells[14].Value);
                    FrmLancamentoContasAReceber lancamentoContasAReceber = new FrmLancamentoContasAReceber(this, id, lancamento, idFornecedorSelecionado, idDocumentoSelecionado, idPlanoDeContasSelecionado, valor, vencimento, pagamento, idSituacao, documento, obs);
                    lancamentoContasAReceber.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
            }
        }
       
        private void rbLancamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLancamento.Checked)
            {
                lblDescricaoPesquisa.Text = "Pesquisa por Lançamento";
                txtDados.Clear();
            }
        }

        private void rbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFornecedor.Checked)
            {
                lblDescricaoPesquisa.Text = "Pesquisa por Fornecedor";
                txtDados.Clear();
            }
        }

        private void rbPlanoDeContas_CheckedChanged(object sender, EventArgs e)
        {

            if (rbPlanoDeContas.Checked)
            {
                lblDescricaoPesquisa.Text = "Pesquisa por Plano de Contas";
                txtDados.Clear();
            }
        }

        private void rbDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDoc.Checked)
            {
                lblDescricaoPesquisa.Text = "Pesquisa por Documento";
                txtDados.Clear();
            }
        }

        private void rbTipoPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoPagamento.Checked)
            {
                lblDescricaoPesquisa.Text = "Pesquisa por Tipo de Pagamento";
                txtDados.Clear();
            }

        }

        private void rbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVencimento.Checked)
            {
                lblDescricaoPesquisa.Text = "Pesquisa por Vencimento";
                txtDados.Clear();
            }
        }
        private void rbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagamento.Checked)
            {
                lblDescricaoPesquisa.Text = "Pesquisa por Pagamento";
                txtDados.Clear();
            }
        }
        private void rbsituacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsituacao.Checked)
            {
                lblDescricaoPesquisa.Text = "Pesquisa por Situação";
                txtDados.Clear();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
             if (rbLancamento.Checked)
            {
                if (txtDados.Text != "")
                {

                    bindingSource.Filter = $"LANCAMENTO = #{Convert.ToDateTime(txtDados.Text).ToString("MM/dd/yyyy")}#";
                    CalculoarValor();
                    return;
                }
                else
                {
                    bindingSource.Filter = null;
                    CalculoarValor();
                }
            }
            else if (rbFornecedor.Checked)
            {
                bindingSource.Filter = $"NOME LIKE '%{txtDados.Text}%'";
                CalculoarValor();
            }
            else if (rbPlanoDeContas.Checked)
            {
                bindingSource.Filter = $"DESCRICAO1 LIKE '%{txtDados.Text}%'";
                CalculoarValor();
            }
            else if (rbDoc.Checked)
            {
                bindingSource.Filter = $"DOCUMENTO LIKE '%{txtDados.Text}%'";
                CalculoarValor();
            }
             else if (rbTipoPagamento.Checked)
            {
                bindingSource.Filter = $"DESCRICAO LIKE '%{txtDados.Text}%'";
                CalculoarValor();
            }
            else if (rbVencimento.Checked)
            {
                if (txtDados.Text != "")
                {
                    bindingSource.Filter = $"DATAVENC = #{Convert.ToDateTime(txtDados.Text).ToString("MM/dd/yyyy")}#";
                    CalculoarValor();
                    return;
                }
                else
                {
                    bindingSource.Filter = null;
                    CalculoarValor();
                }
            }
             else if (rbPagamento.Checked)
            {
                if (txtDados.Text != "")
                {
                    bindingSource.Filter = $"DATAPG = #{Convert.ToDateTime(txtDados.Text).ToString("MM/dd/yyyy")}#";
                    CalculoarValor();
                    return;
                }
                else
                {
                    bindingSource.Filter = null;
                    CalculoarValor();
                }
            }
           
            else if (rbsituacao.Checked)
            {
                bindingSource.Filter = $"DESCRICAO2 LIKE '%{txtDados.Text}%'";
                CalculoarValor();
            }
            else 
            {
                bindingSource.Filter = null;
                CalculoarValor();
            }
          
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            Prints print = new Prints();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Salvar PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                print.ExportarDataGridViewParaPDF(dtgContasAPagar, saveFileDialog.FileName);
            }
        }

        private void txtDados_TextChanged(object sender, EventArgs e)
        {
            if (rbLancamento.Checked) FormataTextbox();
            else if (rbVencimento.Checked) FormataTextbox();
            else if (rbPagamento.Checked) FormataTextbox();

           
        }
    }
}
