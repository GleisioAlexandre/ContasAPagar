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
        public Frm_CadTipoDocumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text.Trim();
            ClasseDoc doc = new ClasseDoc();
            doc.InsertDoc(descricao);
            this.Close();
        }
    }
}
