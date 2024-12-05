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
            var fornecedor = fornecedores.CarregaComboxFornecedor();
            cbxFornecedor.DataSource = new BindingList<ClasseFornecedor>(fornecedores.CarregaComboxFornecedor());

            cbxFornecedor.DisplayMember = "Nome";
            cbxFornecedor.ValueMember = "Id";
           
        }
        private void FrmLancamentoContasAReceber_Load(object sender, EventArgs e)
        {
            CarregaComboBoxDocumento();
            CarregaComboBoxFornecedor();
        }
    }
}
