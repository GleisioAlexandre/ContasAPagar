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
        private void AplicarFiltro()
        {
            // Verifica o campo de texto e configura o filtro de forma genérica
            if (rbFornecedor.Checked)
            {
                AplicarFiltroTexto("NOME");
            }
            else if (rbPlanoDeContas.Checked)
            {
                AplicarFiltroTexto("DESCRICAO1");
            }
            else if (rbDoc.Checked)
            {
                AplicarFiltroTexto("DOCUMENTO");
            }
            else if (rbTipoPagamento.Checked)
            {
                AplicarFiltroTexto("DESCRICAO");
            }
            else if (rbsituacao.Checked)
            {
                AplicarFiltroTexto("DESCRICAO2");
            }
            else if (rbLancamento.Checked)
            {
                AplicarFiltroData("LANCAMENTO");
            }
            else if (rbVencimento.Checked)
            {
                AplicarFiltroData("DATAVENC");
            }
            else if (rbPagamento.Checked)
            {
                AplicarFiltroData("DATAPG");
            }
        }
        private void AplicarFiltroTexto(string coluna)
        {
            if (!string.IsNullOrEmpty(txtDados.Text))
            {
                bindingSource.Filter = $"{coluna} LIKE '%{txtDados.Text}%'";
                CalculoarValor();
            }
            else
            {
                bindingSource.Filter = null;
            }
        }

        // Método para aplicar filtro com base em datas
        private void AplicarFiltroData(string coluna)
        {
            if (string.IsNullOrEmpty(txtDataInicio.Text) || string.IsNullOrEmpty(txtDataFim.Text))
            {
                bindingSource.Filter = null;
            }
            else
            {
                bindingSource.Filter = $"{coluna} >= #{Convert.ToDateTime(txtDataInicio.Text):MM/dd/yyyy}# AND {coluna} <= #{Convert.ToDateTime(txtDataFim.Text):MM/dd/yyyy}#";
                CalculoarValor();
            }
        }
        private void CalculoarValor()
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
            lblValorTotal.Text = $"{soma:C2}";
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
                lblInicio.Enabled = true;
                lblFiltroDescricao.Enabled = false;
                txtDados.Enabled = false;
                txtDados.Enabled = false;
                txtDataInicio.Enabled = true;
                lblFim.Enabled = true;
                txtDataFim.Enabled = true;
                txtDados.Clear();
            }
        }
        private void rbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFornecedor.Checked)
            {
                lblFiltroDescricao.Text = "Fornecedor";
                txtDados.Location = new Point(73, 77);
                lblInicio.Enabled = false;
                lblFiltroDescricao.Enabled = true;
                txtDados.Enabled = true;
                txtDataInicio.Enabled = false;
                lblFim.Enabled = false;
                txtDataFim.Enabled = false;
                txtDados.Clear();
            }
        }
        private void rbPlanoDeContas_CheckedChanged(object sender, EventArgs e)
        {

            if (rbPlanoDeContas.Checked)
            {
                lblFiltroDescricao.Text = "Plano de Contas";
                txtDados.Location = new Point(97, 77);
                lblInicio.Enabled = false;
                lblFiltroDescricao.Enabled = true;
                txtDados.Enabled = true;
                txtDataInicio.Enabled = false;
                lblFim.Enabled = false;
                txtDataFim.Enabled = false;
                txtDados.Clear();
            }
        }
        private void rbDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDoc.Checked)
            {
                lblFiltroDescricao.Text = "Documento";
                txtDados.Location = new Point(74, 77);
                lblInicio.Enabled = false;
                lblFiltroDescricao.Enabled = true;
                txtDados.Enabled = true;
                txtDataInicio.Enabled = false;
                lblFim.Enabled = false;
                txtDataFim.Enabled = false;
                txtDados.Clear();
            }
        }
        private void rbTipoPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoPagamento.Checked)
            {
                lblFiltroDescricao.Text = "Tipo de Pagamento";
                txtDados.Location = new Point(112, 77);
                lblInicio.Enabled = false;
                lblFiltroDescricao.Enabled = true;
                txtDados.Enabled = true;
                txtDataInicio.Enabled = false;
                lblFim.Enabled = false;
                txtDataFim.Enabled = false;
                txtDados.Clear();
            }
        }
        private void rbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVencimento.Checked)
            {
                lblInicio.Enabled = true;
                lblFiltroDescricao.Enabled = false;
                txtDados.Enabled = false;
                txtDataInicio.Enabled = false;
                txtDataInicio.Enabled = true;
                lblFim.Enabled = true;
                txtDataFim.Enabled = true;
                txtDados.Clear();
            }
        }
        private void rbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagamento.Checked)
            {
                lblInicio.Enabled = true;
                lblFiltroDescricao.Enabled = false;
                txtDados.Enabled = false;
                txtDataInicio.Enabled = true;
                lblFim.Enabled = true;
                txtDataFim.Enabled = true;
                txtDados.Clear();
            }
        }
        private void rbsituacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsituacao.Checked)
            {
                lblFiltroDescricao.Text = "Situação";
                txtDados.Location = new Point(61, 77);
                lblInicio.Enabled = false;
                lblFiltroDescricao.Enabled = true;
                txtDados.Enabled = true;
                txtDataInicio.Enabled = false;
                lblFim.Enabled = false;
                txtDataFim.Enabled = false;
                txtDados.Clear();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }
        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            Prints print = new Prints();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Salvar PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                print.ExportarDataGridViewParaPDF(dtgContasAPagar, saveFileDialog.FileName, lblValorTotal.Text.Trim());
            }
        }
    }
}
