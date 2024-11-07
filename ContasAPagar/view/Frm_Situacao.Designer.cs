namespace ContasAPagar.view
{
    partial class Frm_Situacao
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
            this.dtgSituacao = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNSituacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSituacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSituacao
            // 
            this.dtgSituacao.AllowUserToAddRows = false;
            this.dtgSituacao.AllowUserToDeleteRows = false;
            this.dtgSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSituacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSituacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao});
            this.dtgSituacao.Location = new System.Drawing.Point(12, 70);
            this.dtgSituacao.Name = "dtgSituacao";
            this.dtgSituacao.ReadOnly = true;
            this.dtgSituacao.Size = new System.Drawing.Size(776, 313);
            this.dtgSituacao.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // btnNSituacao
            // 
            this.btnNSituacao.Location = new System.Drawing.Point(12, 403);
            this.btnNSituacao.Name = "btnNSituacao";
            this.btnNSituacao.Size = new System.Drawing.Size(776, 23);
            this.btnNSituacao.TabIndex = 1;
            this.btnNSituacao.Text = "Novo";
            this.btnNSituacao.UseVisualStyleBackColor = true;
            this.btnNSituacao.Click += new System.EventHandler(this.btnNSituacao_Click);
            // 
            // Frm_Cad_Situacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNSituacao);
            this.Controls.Add(this.dtgSituacao);
            this.MaximizeBox = false;
            this.Name = "Frm_Cad_Situacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Situações";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSituacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Button btnNSituacao;
    }
}