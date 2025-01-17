﻿using ContasAPagar.controller;
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
        private FrmContasAPagar ContasAPagar;
        private int? idConta;
        private int? fornecedorId;
        private int? documentoId;
        private int? planoDeContasId;
        ClasseDoc tipodoc = new ClasseDoc();
        ClassePContas planoDeContas = new ClassePContas();
        ClasseFornecedores fornecedores = new ClasseFornecedores();
        ClasseContasAPagar contAPagar = new ClasseContasAPagar();
        public FrmLancamentoContasAReceber(FrmContasAPagar contAPAgar)
        {
            InitializeComponent();
            ContasAPagar = contAPAgar;
            idConta = null;
            fornecedorId = -1;
            documentoId = -1;
            planoDeContasId = -1;
        }
        public FrmLancamentoContasAReceber(FrmContasAPagar contAPagar, int id)
        {
            idConta = id;
        }

        public FrmLancamentoContasAReceber(FrmContasAPagar contAPAgar, int id, DateTime lancamento, int idFornecedor, int idDocumetno, int idPlanoDeContas, double valor, DateTime vencimento, DateTime pagamento, int idSituacao, string documento, string obs) : this(contAPAgar)
        {
            fornecedorId = idFornecedor;
            documentoId = idDocumetno;
            planoDeContasId = idPlanoDeContas;
            idConta = id;
            txtLancamento.Text = lancamento.ToString();
            cbxFornecedor.SelectedValue = fornecedorId;
            cbxTipoDoc.SelectedValue = idDocumetno;
            cbxPlanoDeContas.SelectedValue = idPlanoDeContas;
            txtValor.Text = valor.ToString();
            txtVencimento.Text = vencimento.ToString();
            txtPagamento.Text = pagamento.ToString();
            rbPago.Checked = (idSituacao == 1);
            txtDocumento.Text = documento;
            rbPago.Checked = (idSituacao == 1);
            rbApagar.Checked = !rbPago.Checked;
            txtObs.Text = obs;
        }

       private void CarregaComboBoxDocumento(int documentoIdSelecionado)
        {
            documentoId = documentoIdSelecionado;
            var tipoDocumento = tipodoc.CarregaGridTipoDoc();
            cbxTipoDoc.DataSource = tipoDocumento;
            cbxTipoDoc.DisplayMember = "Descricao";
            cbxTipoDoc.ValueMember = "Id";
            cbxTipoDoc.SelectedValue = documentoIdSelecionado;
        }
        private void CarregaComboBoxFornecedor(int fornecedorIdSelecionado)
        {
            fornecedorId = fornecedorIdSelecionado;
            var listaFornecedores = fornecedores.CarregaComboxFornecedor();
            cbxFornecedor.DataSource = listaFornecedores;
            cbxFornecedor.DisplayMember = "Nome";
            cbxFornecedor.ValueMember = "Id";
            cbxFornecedor.SelectedValue = fornecedorIdSelecionado;

        }
        private void CarregaComboxPlanoDeContas(int documentoIdSelecionado)
        {
            documentoId = documentoIdSelecionado;
            var listaPlanoDeContas = planoDeContas.CarregaGridPDContas();
            cbxPlanoDeContas.DataSource = listaPlanoDeContas;
            cbxPlanoDeContas.DisplayMember = "Descricao";
            cbxPlanoDeContas.ValueMember = "Id";
            cbxPlanoDeContas.SelectedValue = documentoIdSelecionado;
            
        }
       
        private void IncluirLancamento()
        {
            
            try
            {
                int situacao = rbPago.Checked ? 1 : 2;
                DateTime lancamento = Convert.ToDateTime(txtLancamento.Text.Trim()).Date;
                DateTime pagamento = Convert.ToDateTime(txtPagamento.Text.Trim()).Date;
                DateTime vencimento = Convert.ToDateTime(txtVencimento.Text.Trim()).Date;
                int idFornecedor = Convert.ToInt32(cbxFornecedor.SelectedValue);
                int idplanoDeContas = Convert.ToInt32(cbxPlanoDeContas.SelectedValue);
                int idTipoDocumento = Convert.ToInt32(cbxTipoDoc.SelectedValue);
                string documento = txtDocumento.Text.Trim();
                string obs = txtObs.Text.Trim();
                double valor = double.TryParse(txtValor.Text.Trim(), out double n) ? n : 0;
                contAPagar.InserirContas(lancamento, idFornecedor, valor, documento, idTipoDocumento, idplanoDeContas, situacao, vencimento, pagamento, obs);
                MessageBox.Show("Dados Inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ContasAPagar.CarregaGridContasAPagar();
                this.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Erro {ex}");
            }
        }
        private void EditarLancamento()
        {
            try
            {
                int situacao = rbPago.Checked ? 1 : 2;
                DateTime lancamento = Convert.ToDateTime(txtLancamento.Text.Trim()).Date;
                DateTime pagamento = Convert.ToDateTime(txtPagamento.Text.Trim()).Date;
                DateTime vencimento = Convert.ToDateTime(txtVencimento.Text.Trim()).Date;
                int idFornecedor = Convert.ToInt32(cbxFornecedor.SelectedValue);
                int idplanoDeContas = Convert.ToInt32(cbxPlanoDeContas.SelectedValue);
                int idTipoDocumento = Convert.ToInt32(cbxTipoDoc.SelectedValue);
                string documento = txtDocumento.Text.Trim();
                string obs = txtObs.Text.Trim();
                double valor = Convert.ToDouble(txtValor.Text.Trim());
                contAPagar.EditarContas(lancamento, idFornecedor, idplanoDeContas, documento, valor, idTipoDocumento, vencimento, pagamento, obs, situacao, idConta.Value);
                MessageBox.Show("Dados Atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ContasAPagar.CarregaGridContasAPagar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex}");
            }
        }
        private void FrmLancamentoContasAReceber_Load(object sender, EventArgs e)
        {
            CarregaComboBoxDocumento(documentoId.Value);
            CarregaComboxPlanoDeContas(planoDeContasId.Value);
            CarregaComboBoxFornecedor(fornecedorId.Value);
            btnEditarLancamento.Enabled = idConta != null;
            btnIncluirLancamento.Enabled = idConta == null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluirLancamento_Click(object sender, EventArgs e)
        {
            IncluirLancamento();
        }

        private void btnEditarLancamento_Click(object sender, EventArgs e)
        {
            EditarLancamento();
        }
    }
}


