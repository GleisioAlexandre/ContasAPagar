namespace ContasAPagar.view
{
    partial class FrmLancamentoContasAReceber
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.rbApagar = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluirLancamento = new System.Windows.Forms.Button();
            this.gpbSituacao = new System.Windows.Forms.GroupBox();
            this.txtPagamento = new System.Windows.Forms.MaskedTextBox();
            this.txtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.txtLancamento = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cbxPlanoDeContas = new System.Windows.Forms.ComboBox();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.bindingSourceFornecedor = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditarLancamento = new System.Windows.Forms.Button();
            this.gpbSituacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Documento";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(11, 112);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(72, 20);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vencimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Plano de Contas";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(633, 56);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(151, 20);
            this.txtDocumento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fornecedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lançamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pagamento";
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.Checked = true;
            this.rbPago.Location = new System.Drawing.Point(6, 19);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(50, 17);
            this.rbPago.TabIndex = 0;
            this.rbPago.TabStop = true;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
            // 
            // rbApagar
            // 
            this.rbApagar.AutoSize = true;
            this.rbApagar.Location = new System.Drawing.Point(83, 19);
            this.rbApagar.Name = "rbApagar";
            this.rbApagar.Size = new System.Drawing.Size(63, 17);
            this.rbApagar.TabIndex = 1;
            this.rbApagar.Text = "A Pagar";
            this.rbApagar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(655, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 43);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluirLancamento
            // 
            this.btnIncluirLancamento.Location = new System.Drawing.Point(11, 198);
            this.btnIncluirLancamento.Name = "btnIncluirLancamento";
            this.btnIncluirLancamento.Size = new System.Drawing.Size(129, 43);
            this.btnIncluirLancamento.TabIndex = 11;
            this.btnIncluirLancamento.Text = "Incluir Lançamento";
            this.btnIncluirLancamento.UseVisualStyleBackColor = true;
            this.btnIncluirLancamento.Click += new System.EventHandler(this.btnIncluirLancamento_Click);
            // 
            // gpbSituacao
            // 
            this.gpbSituacao.Controls.Add(this.rbPago);
            this.gpbSituacao.Controls.Add(this.rbApagar);
            this.gpbSituacao.Location = new System.Drawing.Point(633, 112);
            this.gpbSituacao.Name = "gpbSituacao";
            this.gpbSituacao.Size = new System.Drawing.Size(152, 49);
            this.gpbSituacao.TabIndex = 9;
            this.gpbSituacao.TabStop = false;
            this.gpbSituacao.Text = "Situação";
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(331, 112);
            this.txtPagamento.Mask = "00/00/0000";
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(72, 20);
            this.txtPagamento.TabIndex = 7;
            this.txtPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // txtVencimento
            // 
            this.txtVencimento.Location = new System.Drawing.Point(237, 112);
            this.txtVencimento.Mask = "00/00/0000";
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(72, 20);
            this.txtVencimento.TabIndex = 6;
            this.txtVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtLancamento
            // 
            this.txtLancamento.Location = new System.Drawing.Point(11, 56);
            this.txtLancamento.Mask = "00/00/0000";
            this.txtLancamento.Name = "txtLancamento";
            this.txtLancamento.Size = new System.Drawing.Size(72, 20);
            this.txtLancamento.TabIndex = 0;
            this.txtLancamento.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "OBS";
            // 
            // cbxTipoDoc
            // 
            this.cbxTipoDoc.FormattingEnabled = true;
            this.cbxTipoDoc.Location = new System.Drawing.Point(105, 112);
            this.cbxTipoDoc.Name = "cbxTipoDoc";
            this.cbxTipoDoc.Size = new System.Drawing.Size(110, 21);
            this.cbxTipoDoc.TabIndex = 5;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(425, 112);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(184, 49);
            this.txtObs.TabIndex = 26;
            // 
            // cbxPlanoDeContas
            // 
            this.cbxPlanoDeContas.FormattingEnabled = true;
            this.cbxPlanoDeContas.Location = new System.Drawing.Point(391, 55);
            this.cbxPlanoDeContas.Name = "cbxPlanoDeContas";
            this.cbxPlanoDeContas.Size = new System.Drawing.Size(218, 21);
            this.cbxPlanoDeContas.TabIndex = 27;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(105, 56);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(226, 21);
            this.cbxFornecedor.TabIndex = 28;
            // 
            // btnEditarLancamento
            // 
            this.btnEditarLancamento.Location = new System.Drawing.Point(333, 198);
            this.btnEditarLancamento.Name = "btnEditarLancamento";
            this.btnEditarLancamento.Size = new System.Drawing.Size(129, 43);
            this.btnEditarLancamento.TabIndex = 29;
            this.btnEditarLancamento.Text = "Editar Lançamento";
            this.btnEditarLancamento.UseVisualStyleBackColor = true;
            // 
            // FrmLancamentoContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 253);
            this.Controls.Add(this.btnEditarLancamento);
            this.Controls.Add(this.cbxFornecedor);
            this.Controls.Add(this.cbxPlanoDeContas);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.cbxTipoDoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLancamento);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.gpbSituacao);
            this.Controls.Add(this.btnIncluirLancamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLancamentoContasAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Despesas";
            this.Load += new System.EventHandler(this.FrmLancamentoContasAReceber_Load);
            this.gpbSituacao.ResumeLayout(false);
            this.gpbSituacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPago;
        private System.Windows.Forms.RadioButton rbApagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluirLancamento;
        private System.Windows.Forms.GroupBox gpbSituacao;
        private System.Windows.Forms.MaskedTextBox txtPagamento;
        private System.Windows.Forms.MaskedTextBox txtVencimento;
        private System.Windows.Forms.MaskedTextBox txtLancamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTipoDoc;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cbxPlanoDeContas;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.BindingSource bindingSourceFornecedor;
        private System.Windows.Forms.Button btnEditarLancamento;
    }
}