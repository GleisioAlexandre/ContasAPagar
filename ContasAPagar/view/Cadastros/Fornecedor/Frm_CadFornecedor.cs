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
        private readonly BuscaCep buscaCep;
        public Frm_CadFornecedor()
        {
            InitializeComponent();
            buscaCep = new BuscaCep();
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
    }
}

