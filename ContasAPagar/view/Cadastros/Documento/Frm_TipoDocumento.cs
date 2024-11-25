using ContasAPagar.controller;
using ContasAPagar.model;
using ContasAPagar.view.Cadastros.Documento;
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
    public partial class Frm_TipoDocumento : Form
    {
        private ClasseDoc classeDoc = new ClasseDoc();
       
        public Frm_TipoDocumento()
        {
            InitializeComponent();
        }
        public void CarregaGrid()
        {
            var lista = classeDoc.CarregaGridTipoDoc();
            bindingSource.DataSource = new BindingList<ClasseTipoDoc>(lista);
            dtgTipoDoc.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;
        }
        private void dtgTipoDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(dtgTipoDoc.Rows[e.RowIndex].Cells[0].Value);
                    string descricao = dtgTipoDoc.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(descricao))
                    {
                        Frm_CadTipoDocumento frm_CadTipo = new Frm_CadTipoDocumento(this, id, descricao);
                        frm_CadTipo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Descrição invalida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulario: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Frm_Documento_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Frm_CadTipoDocumento cadTipoDocumento = new Frm_CadTipoDocumento(this);
            cadTipoDocumento.ShowDialog();
        }

    }
}
