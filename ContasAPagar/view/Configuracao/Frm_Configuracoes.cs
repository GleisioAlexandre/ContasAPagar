using ContasAPagar.Config;
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
    public partial class Frm_Configuracoes : Form
    {
        ClasseGlobal global = new ClasseGlobal();
        public Frm_Configuracoes()
        {
            InitializeComponent();
        }

        private void Frm_Configuracoes_Load(object sender, EventArgs e)
        {
            txtServidor.Text = global.dataSourc;
            txtPorta.Text = global.porta.ToString();
            txtCaminho.Text = global.dataBase;
            txtUsuario.Text = global.usuario;
            txtSenha.Text = global.senha;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Configuracao.Default.DataSource = txtServidor.Text;
                Configuracao.Default.Porta = Convert.ToInt32(txtPorta.Text);
                Configuracao.Default.DataBase = txtCaminho.Text;
                Configuracao.Default.User = txtUsuario.Text;
                Configuracao.Default.Password = txtSenha.Text;
                Configuracao.Default.Save();
                MessageBox.Show("Configuração atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar armazenar as informações do banco de dados! \n\f Erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            // Cria uma instância do OpenFileDialog
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Selecione o arquivo do banco de dados";
                dialog.Filter = "Arquivos de banco de dados (*.fdb;*.db)|*.fdb;*.db|Todos os arquivos (*.*)|*.*"; // Filtro para extensões específicas
                dialog.InitialDirectory = @"C:\"; // Pasta inicial

                // Exibe o diálogo e verifica se o usuário selecionou um arquivo
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Insere o caminho completo do arquivo no TextBox
                    txtCaminho.Text = dialog.FileName;
                }
            }
        }
    }
}
