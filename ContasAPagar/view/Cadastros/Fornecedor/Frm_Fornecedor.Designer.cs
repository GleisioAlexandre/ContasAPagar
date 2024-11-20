namespace ContasAPagar.view
{
    partial class Frm_Fornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastropessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.cadastropessoa,
            this.cep,
            this.logradouro,
            this.numero,
            this.complemento,
            this.bairro,
            this.cidade,
            this.estado,
            this.uf,
            this.obs});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 403);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(776, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cadastropessoa
            // 
            this.cadastropessoa.HeaderText = "CPF / CNPJ";
            this.cadastropessoa.Name = "cadastropessoa";
            this.cadastropessoa.ReadOnly = true;
            // 
            // cep
            // 
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // logradouro
            // 
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Nº";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // complemento
            // 
            this.complemento.HeaderText = "Complemento";
            this.complemento.Name = "complemento";
            this.complemento.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // uf
            // 
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // obs
            // 
            this.obs.HeaderText = "OBS";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            // 
            // Frm_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Frm_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastropessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    }
}