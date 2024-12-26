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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasAPagar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgContasAPagar = new System.Windows.Forms.DataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlanoDeContas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFiltroDescricao = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.cbxFornecedor = new System.Windows.Forms.CheckBox();
            this.cbxPlanoDeContas = new System.Windows.Forms.CheckBox();
            this.cbxDocumento = new System.Windows.Forms.CheckBox();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDataFim = new System.Windows.Forms.MaskedTextBox();
            this.rbVencimento = new System.Windows.Forms.RadioButton();
            this.rbPagamento = new System.Windows.Forms.RadioButton();
            this.rbLancamento = new System.Windows.Forms.RadioButton();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanoDeConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxTipoPagamento = new System.Windows.Forms.CheckBox();
            this.txtTipoPagamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSituacao = new System.Windows.Forms.CheckBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasAPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgContasAPagar
            // 
            this.dtgContasAPagar.AllowUserToAddRows = false;
            this.dtgContasAPagar.AllowUserToDeleteRows = false;
            this.dtgContasAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgContasAPagar.AutoGenerateColumns = false;
            this.dtgContasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContasAPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.lancamento,
            this.fornecedor,
            this.valor,
            this.descricao,
            this.documento,
            this.tipo,
            this.vencimento,
            this.pagamento,
            this.situacao,
            this.obs,
            this.id_Fornecedor,
            this.idDocumento,
            this.idPlanoDeConta,
            this.idSituicao});
            this.dtgContasAPagar.DataSource = this.bindingSource;
            this.dtgContasAPagar.Location = new System.Drawing.Point(12, 192);
            this.dtgContasAPagar.Name = "dtgContasAPagar";
            this.dtgContasAPagar.ReadOnly = true;
            this.dtgContasAPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContasAPagar.Size = new System.Drawing.Size(1081, 359);
            this.dtgContasAPagar.TabIndex = 0;
            this.dtgContasAPagar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContasAPagar_CellDoubleClick);
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoLancamento.Location = new System.Drawing.Point(12, 567);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(89, 44);
            this.btnNovoLancamento.TabIndex = 1;
            this.btnNovoLancamento.Text = "Novo Lançamento";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1004, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1,
            this.btnPesquisar,
            this.toolStripSeparator,
            this.btnSalvar,
            this.toolStripSeparator2});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(1105, 25);
            this.bindingNavigator.TabIndex = 3;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPesquisar.Image = global::ContasAPagar.Properties.Resources.lupa;
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(23, 22);
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxSituacao);
            this.groupBox1.Controls.Add(this.txtSituacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxTipoPagamento);
            this.groupBox1.Controls.Add(this.txtTipoPagamento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbLancamento);
            this.groupBox1.Controls.Add(this.rbPagamento);
            this.groupBox1.Controls.Add(this.rbVencimento);
            this.groupBox1.Controls.Add(this.txtDataFim);
            this.groupBox1.Controls.Add(this.txtDataInicio);
            this.groupBox1.Controls.Add(this.cbxDocumento);
            this.groupBox1.Controls.Add(this.cbxPlanoDeContas);
            this.groupBox1.Controls.Add(this.cbxFornecedor);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlanoDeContas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFim);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Controls.Add(this.txtFornecedor);
            this.groupBox1.Controls.Add(this.lblFiltroDescricao);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(97, 67);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(231, 20);
            this.txtDocumento.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Documento";
            // 
            // txtPlanoDeContas
            // 
            this.txtPlanoDeContas.Enabled = false;
            this.txtPlanoDeContas.Location = new System.Drawing.Point(97, 41);
            this.txtPlanoDeContas.Name = "txtPlanoDeContas";
            this.txtPlanoDeContas.Size = new System.Drawing.Size(231, 20);
            this.txtPlanoDeContas.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Plano de Contas";
            // 
            // lblFim
            // 
            this.lblFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(973, 44);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(23, 13);
            this.lblFim.TabIndex = 12;
            this.lblFim.Text = "Fim";
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(964, 18);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 10;
            this.lblInicio.Text = "Inicio";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(97, 15);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(231, 20);
            this.txtFornecedor.TabIndex = 9;
            // 
            // lblFiltroDescricao
            // 
            this.lblFiltroDescricao.AutoSize = true;
            this.lblFiltroDescricao.Location = new System.Drawing.Point(6, 18);
            this.lblFiltroDescricao.Name = "lblFiltroDescricao";
            this.lblFiltroDescricao.Size = new System.Drawing.Size(61, 13);
            this.lblFiltroDescricao.TabIndex = 8;
            this.lblFiltroDescricao.Text = "Fornecedor";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(131, 583);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(21, 13);
            this.lblValorTotal.TabIndex = 5;
            this.lblValorTotal.Text = "R$";
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.AutoSize = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(343, 18);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(15, 14);
            this.cbxFornecedor.TabIndex = 20;
            this.cbxFornecedor.UseVisualStyleBackColor = true;
            this.cbxFornecedor.CheckedChanged += new System.EventHandler(this.cbxFornecedor_CheckedChanged);
            // 
            // cbxPlanoDeContas
            // 
            this.cbxPlanoDeContas.AutoSize = true;
            this.cbxPlanoDeContas.Location = new System.Drawing.Point(343, 44);
            this.cbxPlanoDeContas.Name = "cbxPlanoDeContas";
            this.cbxPlanoDeContas.Size = new System.Drawing.Size(15, 14);
            this.cbxPlanoDeContas.TabIndex = 21;
            this.cbxPlanoDeContas.UseVisualStyleBackColor = true;
            this.cbxPlanoDeContas.CheckedChanged += new System.EventHandler(this.cbxPlanoDeContas_CheckedChanged);
            // 
            // cbxDocumento
            // 
            this.cbxDocumento.AutoSize = true;
            this.cbxDocumento.Location = new System.Drawing.Point(343, 70);
            this.cbxDocumento.Name = "cbxDocumento";
            this.cbxDocumento.Size = new System.Drawing.Size(15, 14);
            this.cbxDocumento.TabIndex = 22;
            this.cbxDocumento.UseVisualStyleBackColor = true;
            this.cbxDocumento.CheckedChanged += new System.EventHandler(this.cbxDocumento_CheckedChanged);
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(1002, 15);
            this.txtDataInicio.Mask = "00/00/0000";
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(73, 20);
            this.txtDataInicio.TabIndex = 23;
            this.txtDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataFim
            // 
            this.txtDataFim.Location = new System.Drawing.Point(1002, 42);
            this.txtDataFim.Mask = "00/00/0000";
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(73, 20);
            this.txtDataFim.TabIndex = 24;
            this.txtDataFim.ValidatingType = typeof(System.DateTime);
            // 
            // rbVencimento
            // 
            this.rbVencimento.AutoSize = true;
            this.rbVencimento.Checked = true;
            this.rbVencimento.Location = new System.Drawing.Point(990, 69);
            this.rbVencimento.Name = "rbVencimento";
            this.rbVencimento.Size = new System.Drawing.Size(81, 17);
            this.rbVencimento.TabIndex = 25;
            this.rbVencimento.TabStop = true;
            this.rbVencimento.Text = "Vencimento";
            this.rbVencimento.UseVisualStyleBackColor = true;
            // 
            // rbPagamento
            // 
            this.rbPagamento.AutoSize = true;
            this.rbPagamento.Location = new System.Drawing.Point(990, 93);
            this.rbPagamento.Name = "rbPagamento";
            this.rbPagamento.Size = new System.Drawing.Size(79, 17);
            this.rbPagamento.TabIndex = 26;
            this.rbPagamento.Text = "Pagamento";
            this.rbPagamento.UseVisualStyleBackColor = true;
            // 
            // rbLancamento
            // 
            this.rbLancamento.AutoSize = true;
            this.rbLancamento.Location = new System.Drawing.Point(990, 117);
            this.rbLancamento.Name = "rbLancamento";
            this.rbLancamento.Size = new System.Drawing.Size(84, 17);
            this.rbLancamento.TabIndex = 27;
            this.rbLancamento.Text = "Lançamento";
            this.rbLancamento.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            this.codigo.Width = 50;
            // 
            // lancamento
            // 
            this.lancamento.DataPropertyName = "Lancamento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.lancamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.lancamento.HeaderText = "Lançamento";
            this.lancamento.Name = "lancamento";
            this.lancamento.ReadOnly = true;
            this.lancamento.Width = 80;
            // 
            // fornecedor
            // 
            this.fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fornecedor.DataPropertyName = "NOME";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 86;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 80;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "DESCRICAO1";
            this.descricao.HeaderText = "Plano de Contas";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 110;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "Documento";
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "DESCRICAO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipo.DefaultCellStyle = dataGridViewCellStyle4;
            this.tipo.HeaderText = "Tipo Pagamento";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 120;
            // 
            // vencimento
            // 
            this.vencimento.DataPropertyName = "DataVenc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.vencimento.DefaultCellStyle = dataGridViewCellStyle5;
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.ReadOnly = true;
            this.vencimento.Width = 80;
            // 
            // pagamento
            // 
            this.pagamento.DataPropertyName = "DataPg";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.pagamento.DefaultCellStyle = dataGridViewCellStyle6;
            this.pagamento.HeaderText = "Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Width = 80;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "DESCRICAO2";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.situacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.situacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.situacao.Width = 70;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "OBS";
            this.obs.HeaderText = "Observações";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            // 
            // id_Fornecedor
            // 
            this.id_Fornecedor.DataPropertyName = "ID_FORNECEDOR";
            this.id_Fornecedor.HeaderText = "IdFornecedor";
            this.id_Fornecedor.Name = "id_Fornecedor";
            this.id_Fornecedor.ReadOnly = true;
            this.id_Fornecedor.Visible = false;
            // 
            // idDocumento
            // 
            this.idDocumento.DataPropertyName = "ID_TIPODOCUMENTO";
            this.idDocumento.HeaderText = "IDDOCUMENTO";
            this.idDocumento.Name = "idDocumento";
            this.idDocumento.ReadOnly = true;
            this.idDocumento.Visible = false;
            // 
            // idPlanoDeConta
            // 
            this.idPlanoDeConta.DataPropertyName = "ID_PLANODECONTAS";
            this.idPlanoDeConta.HeaderText = "IDPLANODECONTAS";
            this.idPlanoDeConta.Name = "idPlanoDeConta";
            this.idPlanoDeConta.ReadOnly = true;
            this.idPlanoDeConta.Visible = false;
            // 
            // idSituicao
            // 
            this.idSituicao.DataPropertyName = "ID_SITUACAO";
            this.idSituicao.HeaderText = "IDSITUACAO";
            this.idSituicao.Name = "idSituicao";
            this.idSituicao.ReadOnly = true;
            this.idSituicao.Visible = false;
            // 
            // cbxTipoPagamento
            // 
            this.cbxTipoPagamento.AutoSize = true;
            this.cbxTipoPagamento.Location = new System.Drawing.Point(343, 96);
            this.cbxTipoPagamento.Name = "cbxTipoPagamento";
            this.cbxTipoPagamento.Size = new System.Drawing.Size(15, 14);
            this.cbxTipoPagamento.TabIndex = 30;
            this.cbxTipoPagamento.UseVisualStyleBackColor = true;
            this.cbxTipoPagamento.CheckedChanged += new System.EventHandler(this.cbxTipoPagamento_CheckedChanged);
            // 
            // txtTipoPagamento
            // 
            this.txtTipoPagamento.Enabled = false;
            this.txtTipoPagamento.Location = new System.Drawing.Point(97, 93);
            this.txtTipoPagamento.Name = "txtTipoPagamento";
            this.txtTipoPagamento.Size = new System.Drawing.Size(231, 20);
            this.txtTipoPagamento.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tipo Pagamento";
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.AutoSize = true;
            this.cbxSituacao.Location = new System.Drawing.Point(343, 122);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(15, 14);
            this.cbxSituacao.TabIndex = 33;
            this.cbxSituacao.UseVisualStyleBackColor = true;
            this.cbxSituacao.CheckedChanged += new System.EventHandler(this.cbxSituacao_CheckedChanged);
            // 
            // txtSituacao
            // 
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Location = new System.Drawing.Point(97, 119);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(231, 20);
            this.txtSituacao.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Situação";
            // 
            // FrmContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 623);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.dtgContasAPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmContasAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.FrmContasAPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasAPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgContasAPagar;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblFiltroDescricao;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlanoDeContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxFornecedor;
        private System.Windows.Forms.CheckBox cbxDocumento;
        private System.Windows.Forms.CheckBox cbxPlanoDeContas;
        private System.Windows.Forms.RadioButton rbLancamento;
        private System.Windows.Forms.RadioButton rbPagamento;
        private System.Windows.Forms.RadioButton rbVencimento;
        private System.Windows.Forms.MaskedTextBox txtDataFim;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanoDeConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituicao;
        private System.Windows.Forms.CheckBox cbxTipoPagamento;
        private System.Windows.Forms.TextBox txtTipoPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxSituacao;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label4;
    }
}