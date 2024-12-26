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
            // Filtros individuais
            string filtroFornecedor = string.Empty;
            string filtroPlanoDeContas = string.Empty;
            string filtroDocumento = string.Empty;
            string filtroTipoPagamento = string.Empty;
            string filtroSituacao = string.Empty;
            string filtroDatas = string.Empty;

            // Combinação final de filtros
            List<string> filtros = new List<string>();

            // Filtro por fornecedor
            if (cbxFornecedor.Checked && !string.IsNullOrEmpty(txtFornecedor.Text))
            {
                filtroFornecedor = $"NOME LIKE '%{txtFornecedor.Text}%'";
                filtros.Add(filtroFornecedor);
            }

            // Filtro por plano de contas
            if (cbxPlanoDeContas.Checked && !string.IsNullOrEmpty(txtPlanoDeContas.Text))
            {
                filtroPlanoDeContas = $"DESCRICAO1 LIKE '%{txtPlanoDeContas.Text}%'";
                filtros.Add(filtroPlanoDeContas);
            }

            // Filtro por documento
            if (cbxDocumento.Checked && !string.IsNullOrEmpty(txtDocumento.Text))
            {
                filtroDocumento = $"DOCUMENTO LIKE '%{txtDocumento.Text}%'";
                filtros.Add(filtroDocumento);
            }

            // Filtro por tipo de pagamento
            if (cbxTipoPagamento.Checked && !string.IsNullOrEmpty(txtTipoPagamento.Text))
            {
                filtroTipoPagamento = $"DESCRICAO LIKE '%{txtTipoPagamento.Text}%'";
                filtros.Add(filtroTipoPagamento);
            }

            // Filtro por situação
            if (cbxSituacao.Checked && !string.IsNullOrEmpty(txtSituacao.Text))
            {
                filtroSituacao = $"DESCRICAO2 LIKE '%{txtSituacao.Text}%'";
                filtros.Add(filtroSituacao);
            }

            // Filtro por datas (controlado pelos RadioButtons)
            if (!string.IsNullOrEmpty(txtDataInicio.Text) && !string.IsNullOrEmpty(txtDataFim.Text))
            {
                if (DateTime.TryParse(txtDataInicio.Text, out DateTime dataInicio) && DateTime.TryParse(txtDataFim.Text, out DateTime dataFim))
                {
                    string colunaData = string.Empty;

                    if (rbLancamento.Checked)
                        colunaData = "LANCAMENTO";
                    else if (rbVencimento.Checked)
                        colunaData = "DATAVENC";
                    else if (rbPagamento.Checked)
                        colunaData = "DATAPG";

                    if (!string.IsNullOrEmpty(colunaData))
                    {
                        filtroDatas = $"{colunaData} >= #{dataInicio:MM/dd/yyyy}# AND {colunaData} <= #{dataFim:MM/dd/yyyy}#";
                        filtros.Add(filtroDatas);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha as datas corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bindingSource.Filter = null;
                    return;
                }
            }

            // Combina todos os filtros com AND
            bindingSource.Filter = filtros.Count > 0 ? string.Join(" AND ", filtros) : null;

            // Recalcula valores, se necessário
            CalculoarValor();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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

      
        private void cbxFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFornecedor.Checked)
            {
                txtFornecedor.Enabled = true;
            }
            else
            {
                txtFornecedor.Enabled = false;
            }
        }

        private void cbxPlanoDeContas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPlanoDeContas.Checked)
            {
                txtPlanoDeContas.Enabled = true;
            }
            else
            {
                txtPlanoDeContas.Enabled = false;
            }
        }

        private void cbxDocumento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDocumento.Checked)
            {
                txtDocumento.Enabled = true;
            }
            else
            {
                txtDocumento.Enabled = false;
            }
        }

        private void cbxTipoPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTipoPagamento.Checked)
            {
                txtTipoPagamento.Enabled = true;
            }
            else
            {
                txtTipoPagamento.Enabled = false;
            }
        }

        private void cbxSituacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSituacao.Checked)
            {
                txtSituacao.Enabled = true;
            }
            else
            {
                txtSituacao.Enabled = false;
            }
        }
    }
}
