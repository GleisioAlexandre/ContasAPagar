namespace ContasAPagar.view
{
    partial class FrmContasAPagar
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
            this.dtgContasAPagar = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasAPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgContasAPagar
            // 
            this.dtgContasAPagar.AllowUserToAddRows = false;
            this.dtgContasAPagar.AllowUserToDeleteRows = false;
            this.dtgContasAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgContasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContasAPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.valor,
            this.vencimento,
            this.pagamento,
            this.devedor,
            this.status});
            this.dtgContasAPagar.Location = new System.Drawing.Point(12, 160);
            this.dtgContasAPagar.Name = "dtgContasAPagar";
            this.dtgContasAPagar.ReadOnly = true;
            this.dtgContasAPagar.Size = new System.Drawing.Size(1309, 391);
            this.dtgContasAPagar.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.ReadOnly = true;
            // 
            // pagamento
            // 
            this.pagamento.HeaderText = "Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            // 
            // devedor
            // 
            this.devedor.HeaderText = "Devedor";
            this.devedor.Name = "devedor";
            this.devedor.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.dtgContasAPagar);
            this.Name = "FrmContasAPagar";
            this.Text = "FrmContasAPagar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasAPagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgContasAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn devedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}