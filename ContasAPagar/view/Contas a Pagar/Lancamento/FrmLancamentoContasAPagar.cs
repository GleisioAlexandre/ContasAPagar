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
        ClasseDoc tipodoc = new ClasseDoc();
        ClassePContas planoDeContas = new ClassePContas();
        ClasseFornecedores fornecedores = new ClasseFornecedores();
        public FrmLancamentoContasAReceber()
        {
            InitializeComponent();
           
        }
       private void CarregaComboBoxDocumento()
        {
            var tipoDocumento = tipodoc.CarregaGridTipoDoc();
            cbxTipo.DataSource = tipoDocumento;
            cbxTipo.DisplayMember = "Descricao";
            cbxTipo.ValueMember = "Id";
        }
        private void CarregaComboBoxFornecedor()
        {
            cbxFornecedor.DataSource = new BindingList<ClasseFornecedor>(fornecedores.CarregaComboxFornecedor());
            cbxFornecedor.DisplayMember = "Nome";
            cbxFornecedor.ValueMember = "Id";
            cbxFornecedor.SelectedValue = -1;
        }
        private void CarregaComboxPlanoDeContas()
        {
            var listaPlanoDeContas = planoDeContas.CarregaGridPDContas();
            cbxPlanoDeContas.DataSource = listaPlanoDeContas;
            cbxPlanoDeContas.DisplayMember = "Descricao";
            cbxPlanoDeContas.ValueMember = "Id";
        }
       
        private void IncluirLancamento()
        {
           // DateTime lancamento = Convert.ToDateTime(txtLancamento.Text);
            //int idFornecedor = Convert.ToInt32(cbxFornecedor.SelectedValue.ToString());
            int PlanoDeContas = cbxPlanoDeContas.SelectedIndex;

            Console.WriteLine(planoDeContas);
            //ClassePContas planoDeContas = new ClassePContas();
            //planoDeContas.InserirPlanoDeContas();
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
    }
}
