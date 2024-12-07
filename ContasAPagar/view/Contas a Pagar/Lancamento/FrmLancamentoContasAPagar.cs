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
    public partial class FrmLancamentoContasAReceber : Form
    {
        FrmContasAPagar contasAPagar;
        private int? idConta;
        ClasseDoc tipodoc = new ClasseDoc();
        ClassePContas planoDeContas = new ClassePContas();
        ClasseFornecedores fornecedores = new ClasseFornecedores();
        ClasseContasAPagar contAPagar = new ClasseContasAPagar();
        public FrmLancamentoContasAReceber(FrmContasAPagar contAPAgar)
        {
            InitializeComponent();
            contasAPagar = contAPAgar;
            idConta = null;
        }

        public FrmLancamentoContasAReceber(FrmContasAPagar contAPAgar, int id, DateTime lancamento,string fornecedor) : this(contAPAgar)
        {
            idConta = id;
            txtLancamento.Text = lancamento.ToString();
            cbxFornecedor.Text = fornecedor;
        }

       private void CarregaComboBoxDocumento()
        {
            var tipoDocumento = tipodoc.CarregaGridTipoDoc();
            cbxTipoDoc.DataSource = tipoDocumento;
            cbxTipoDoc.DisplayMember = "Descricao";
            cbxTipoDoc.ValueMember = "Id";
            cbxTipoDoc.SelectedValue = -1;
        }
        private void CarregaComboBoxFornecedor()
        {
            foreach (var fornecedor in fornecedores.CarregaComboxFornecedor())
            {
                cbxFornecedor.Items.Add(fornecedor.Nome);
                cbxFornecedor.DisplayMember = fornecedor.Nome;
                cbxFornecedor.ValueMember = fornecedor.Id.ToString();
                Console.WriteLine($"Id: {cbxFornecedor.DisplayMember = fornecedor.Id.ToString()} \n\f Fornecedor: {cbxFornecedor.DisplayMember = fornecedor.Nome}"); 
            }
           
        }
        private void CarregaComboxPlanoDeContas()
        {
            var listaPlanoDeContas = planoDeContas.CarregaGridPDContas();
            cbxPlanoDeContas.DataSource = listaPlanoDeContas;
            cbxPlanoDeContas.DisplayMember = "Descricao";
            cbxPlanoDeContas.ValueMember = "Id";
            cbxPlanoDeContas.SelectedValue = -1;
            
        }
       
        private void IncluirLancamento()
        {
            
            try
            {
                int situacao;
                DateTime lancamento = Convert.ToDateTime(txtLancamento.Text.Trim()).Date;
                DateTime pagamento = Convert.ToDateTime(txtPagamento.Text.Trim()).Date;
                DateTime vencimento = Convert.ToDateTime(txtVencimento.Text.Trim()).Date;
                int idFornecedor = Convert.ToInt32(cbxFornecedor.SelectedValue);
                int idplanoDeContas = Convert.ToInt32(cbxPlanoDeContas.SelectedValue);
                int idTipoDocumento = Convert.ToInt32(cbxTipoDoc.SelectedValue.ToString());
                string documento = txtDocumento.Text.Trim();
                string obs = txtObs.Text.Trim();
                double valor = Convert.ToDouble(txtValor.Text.Trim());


                if (rbPago.Checked)
                {
                    situacao = 1;
                }
                else
                {
                    situacao = 2;
                }


                contAPagar.InserirContas(lancamento, idFornecedor, valor, documento, idTipoDocumento, idplanoDeContas, situacao, vencimento, pagamento, obs);

                MessageBox.Show("Dados Inseridos com sucesso!");
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Erro {ex}");
            }
        }
        private void EditarLancamento()
        {

        }
        private void FrmLancamentoContasAReceber_Load(object sender, EventArgs e)
        {
            CarregaComboBoxDocumento();
            CarregaComboxPlanoDeContas();
            CarregaComboBoxFornecedor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluirLancamento_Click(object sender, EventArgs e)
        {
            IncluirLancamento();
        }

        private void cbxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}


