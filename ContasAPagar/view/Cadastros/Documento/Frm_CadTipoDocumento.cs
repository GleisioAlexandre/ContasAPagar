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

namespace ContasAPagar.view.Cadastros.Documento
{
    public partial class Frm_CadTipoDocumento : Form
    {
        private Frm_TipoDocumento Frm_TipoDocumento;
        private int? idTipoDoc;
        private ClasseDoc classeDoc = new ClasseDoc();
       
        public Frm_CadTipoDocumento(Frm_TipoDocumento tipo_Documento)
        {
            InitializeComponent();
            Frm_TipoDocumento = tipo_Documento;
            idTipoDoc = null;
        }
        public Frm_CadTipoDocumento(Frm_TipoDocumento tipoDocumento, int id, string descricao) : this(tipoDocumento)
        {
            idTipoDoc = id;
            txtDescricao.Text = descricao;
        }
        private void InserirDados()
        {
            try
            {
                string descricao = txtDescricao.Text.Trim();

                if (string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("O campos descrição é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                classeDoc.InserirDoc(descricao);
                MessageBox.Show("Registro inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_TipoDocumento frm_TipoDocumento = (Frm_TipoDocumento)Application.OpenForms["Frm_TipoDocumento"];
                frm_TipoDocumento.CarregaGrid();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inseir o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarDados()
        {
            try
            {
                string descricao = txtDescricao.Text;
                if (string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("O campo Descrição é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (idTipoDoc.HasValue)
                {
                    classeDoc.EditarDoc(idTipoDoc.Value, descricao);
                    MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Frm_TipoDocumento.CarregaGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Editar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarRegistro()
        {
            string descricao = txtDescricao.Text;
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("O campos Descrição é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idTipoDoc.HasValue)
            {
                classeDoc.DeletarDoc(idTipoDoc.Value);
                MessageBox.Show("Registro removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
            Frm_TipoDocumento.CarregaGrid();
            this.Close();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            InserirDados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarDados();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeletarRegistro();
            }
        }

        private void Frm_CadTipoDocumento_Load(object sender, EventArgs e)
        {

        }
    }
}
