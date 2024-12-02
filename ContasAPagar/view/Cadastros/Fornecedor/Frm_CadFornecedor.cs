using ContasAPagar.controller;
using ContasAPagar.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAPagar.view.Cadastros.Fornecedor
{
    public partial class Frm_CadFornecedor : Form
    {
        private Frm_Fornecedor Frm_Fornecedor;
        private int? idFornecedor;
        private ClasseFornecedores fornecedores = new ClasseFornecedores();

        private void BuscaCep()
        {
            try
            {
                BuscaCep buscaCep = new BuscaCep();

                txtCep.Text = buscaCep.ConsultaCep(txtCep.Text.Trim()).Cep;
                txtLogradouro.Text = buscaCep.ConsultaCep(txtCep.Text.Trim()).Logradouro;
                txtBairro.Text = buscaCep.ConsultaCep(txtCep.Text.Trim()).Bairro;
                txtCidade.Text = buscaCep.ConsultaCep(txtCep.Text.Trim()).Localidade;
                txtEstado.Text = buscaCep.ConsultaCep(txtCep.Text.Trim()).uf;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o CEP: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InseirirFornecedor()
        {
            try
            {
                string nome = txtNome.Text.Trim();
                string cadastroPessoa = txt_Cpf_Cnpj.Text.Trim();
                string cep = txtCep.Text.Trim();
                string logradouro = txtLogradouro.Text.Trim();
                int numero = Convert.ToInt32(txtNumero.Text.Trim());
                string complemento = txtComplemento.Text.Trim();
                string bairro = txtBairro.Text.Trim();
                string cidade = txtCidade.Text.Trim();
                string estado = txtEstado.Text.Trim();
                string telefone = txtTelefone.Text.Trim();
                string celular = txtCelular.Text.Trim();
                string email = txtEmail.Text.Trim();
                string obs = txtObs.Text.Trim();
                fornecedores.InserirFornecedor(nome, cadastroPessoa, cep, logradouro, numero, complemento, bairro, cidade, estado, telefone, celular, email, obs);
                Frm_Fornecedor.CarregaGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inseir o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarFornecedor()
        {
            try
            {
                string nome = txtNome.Text.Trim();
                string cadatroPessoa = txt_Cpf_Cnpj.Text.Trim();
                string cep = txtCep.Text.Trim();
                string logradouro = txtLogradouro.Text.Trim();
                int numero = Convert.ToInt32(txtNumero.Text.Trim());
                string complemento = txtComplemento.Text.Trim();
                string bairro = txtBairro.Text.Trim();
                string cidade = txtCidade.Text.Trim();
                string estado = txtEstado.Text.Trim();
                string telefone = txtTelefone.Text.Trim();
                string celular = txtCelular.Text.Trim();
                string email = txtEmail.Text.Trim();
                string obs = txtObs.Text.Trim();

                fornecedores.EditarFornecedor(idFornecedor.Value, nome, cadatroPessoa, cep, logradouro, numero, complemento, bairro, cidade, estado, telefone, celular, email, obs );
                Frm_Fornecedor.CarregaGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Editar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarFornecedor()
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja remover o registro", "Alerte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    fornecedores.DeletarFornecedor(idFornecedor.Value);
                    Frm_Fornecedor.CarregaGrid();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Remover o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Frm_CadFornecedor(Frm_Fornecedor fornecedor)
        {
            InitializeComponent();
            Frm_Fornecedor = fornecedor;
            idFornecedor = null;
        }
        public Frm_CadFornecedor(Frm_Fornecedor fornecedor, int id, string nome, string cadastroPessoa, string cep, string logradouro, int numero, string complemento, string bairro, string cidade, string estado, string telefone, string celular, string email, string obs): this(fornecedor)
        {
            idFornecedor = id;
            txtNome.Text = nome.Trim();
            txt_Cpf_Cnpj.Text = cadastroPessoa.Trim();
            txtCep.Text = cep.Trim();
            txtLogradouro.Text = logradouro.Trim();
            txtNumero.Text = numero.ToString().Trim();
            txtComplemento.Text = complemento.Trim();
            txtBairro.Text = bairro.Trim();
            txtCidade.Text = cidade.Trim();
            txtEstado.Text = estado.Trim();
            txtTelefone.Text = telefone.Trim();
            txtCelular.Text = celular.Trim();
            txtEmail.Text = email.Trim();
            txtObs.Text = obs.Trim();
        }

        private void cbx_Pj_Pf_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Pj_Pf.Checked != true)
            {
                lbl_Nome_RasaoSocial.Text = "Nome";
                lbl_Cpf_Cnpj.Text = "CPF";
                txt_Cpf_Cnpj.Mask = "###,###,###-##";
                txt_Cpf_Cnpj.Size = new Size(83,20);
            }
            else
            {
                lbl_Nome_RasaoSocial.Text = "Razão Social";
                lbl_Cpf_Cnpj.Text = "CNP";
                txt_Cpf_Cnpj.Mask = "##,###,###/####-##";
                txt_Cpf_Cnpj.Size = new Size(107,20);
            }
        }

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            BuscaCep();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            InseirirFornecedor();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarFornecedor();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarFornecedor();
        }
    }
}

