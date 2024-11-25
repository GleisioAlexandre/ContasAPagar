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
        private int? idContasAPagar;
        private ClassePContas classePContas = new ClassePContas();
        public Frm_CadPlanoDeContas(Frm_PlanoDeContas plano_De_Contas)
        {
            InitializeComponent();
            frm_PlanoDeContas = plano_De_Contas;
        }
        public Frm_CadPlanoDeContas(Frm_PlanoDeContas planoDeContas, int id, string descricao): this(planoDeContas)
        {
            idContasAPagar = id;
            txtDescricao.Text = descricao;
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
        public void EditarPlanoDeContas()
        {
            try
            {
                int id = idContasAPagar.Value;
                string descricao = txtDescricao.Text.Trim();
                if (string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("O campos descrição é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (idContasAPagar.HasValue)
                {
                    classePContas.EditarPlanoDeContas(id, descricao);
                    MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frm_PlanoDeContas.CarregaGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Editar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeletarPlanoDeContas()
        {
            try
            {
                int id = idContasAPagar.Value;
                string descricao = txtDescricao.Text.Trim();
                if (string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("O campos descrição é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (idContasAPagar.HasValue)
                {
                    if (MessageBox.Show("Tem certeza que deseja remover o registro", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        classePContas.DeletarPlanoDeContas(id);
                        MessageBox.Show("Registro removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                    frm_PlanoDeContas.CarregaGrid();
                    this.Close();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            InserirPlanoDeContas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPlanoDeContas();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarPlanoDeContas();
        }
    }
}
