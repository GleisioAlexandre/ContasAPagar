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

namespace ContasAPagar.view.Cadastros.Plano_de_Contas
{
    public partial class Frm_CadPlanoDeContas : Form
    {
        private Frm_PlanoDeContas frm_PlanoDeContas;
        private int? idTipoDoc;
        private ClassePContas classePContas = new ClassePContas();
        public Frm_CadPlanoDeContas(Frm_PlanoDeContas plano_De_Contas)
        {
            InitializeComponent();
            frm_PlanoDeContas = plano_De_Contas;
        }
        public void InserirPlanoDeContas()
        {
            try
            {
                string descricao = txtDescricao.Text.Trim();

                if (string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("O campos descrição é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                classePContas.InserirPlanoDeContas(descricao);
                MessageBox.Show("Registro inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_TipoDocumento frm_TipoDocumento = (Frm_TipoDocumento)Application.OpenForms["Frm_TipoDocumento"];
                frm_PlanoDeContas.CarregaGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inseir o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            InserirPlanoDeContas();
        }
    }
}
