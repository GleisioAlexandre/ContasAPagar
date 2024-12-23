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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasAPagar));
            this.dtgContasAPagar = new System.Windows.Forms.DataGridView();
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataFim = new System.Windows.Forms.MaskedTextBox();
            this.lblFim = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.lblFiltroDescricao = new System.Windows.Forms.Label();
            this.rbTipoPagamento = new System.Windows.Forms.RadioButton();
            this.rbPlanoDeContas = new System.Windows.Forms.RadioButton();
            this.rbPagamento = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.rbsituacao = new System.Windows.Forms.RadioButton();
            this.rbVencimento = new System.Windows.Forms.RadioButton();
            this.rbLancamento = new System.Windows.Forms.RadioButton();
            this.rbDoc = new System.Windows.Forms.RadioButton();
            this.lblValorTotal = new System.Windows.Forms.Label();
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
            this.dtgContasAPagar.Location = new System.Drawing.Point(12, 160);
            this.dtgContasAPagar.Name = "dtgContasAPagar";
            this.dtgContasAPagar.ReadOnly = true;
            this.dtgContasAPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContasAPagar.Size = new System.Drawing.Size(1045, 391);
            this.dtgContasAPagar.TabIndex = 0;
            this.dtgContasAPagar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContasAPagar_CellDoubleClick);
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
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
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
            this.button1.Location = new System.Drawing.Point(968, 567);
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
            this.toolStripButton1,
            this.toolStripSeparator,
            this.salvarToolStripButton,
            this.toolStripSeparator2});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(1069, 25);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ContasAPagar.Properties.Resources.lupa;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Pesquisa";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
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
            this.groupBox1.Controls.Add(this.txtDataFim);
            this.groupBox1.Controls.Add(this.lblFim);
            this.groupBox1.Controls.Add(this.txtDataInicio);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Controls.Add(this.txtDados);
            this.groupBox1.Controls.Add(this.lblFiltroDescricao);
            this.groupBox1.Controls.Add(this.rbTipoPagamento);
            this.groupBox1.Controls.Add(this.rbPlanoDeContas);
            this.groupBox1.Controls.Add(this.rbPagamento);
            this.groupBox1.Controls.Add(this.rbFornecedor);
            this.groupBox1.Controls.Add(this.rbsituacao);
            this.groupBox1.Controls.Add(this.rbVencimento);
            this.groupBox1.Controls.Add(this.rbLancamento);
            this.groupBox1.Controls.Add(this.rbDoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Enabled = false;
            this.txtDataFim.Location = new System.Drawing.Point(929, 81);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(100, 20);
            this.txtDataFim.TabIndex = 13;
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Enabled = false;
            this.lblFim.Location = new System.Drawing.Point(900, 84);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(23, 13);
            this.lblFim.TabIndex = 12;
            this.lblFim.Text = "Fim";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Enabled = false;
            this.txtDataInicio.Location = new System.Drawing.Point(785, 81);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicio.TabIndex = 11;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Enabled = false;
            this.lblInicio.Location = new System.Drawing.Point(747, 84);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 10;
            this.lblInicio.Text = "Inicio";
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(73, 77);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(231, 20);
            this.txtDados.TabIndex = 9;
            // 
            // lblFiltroDescricao
            // 
            this.lblFiltroDescricao.AutoSize = true;
            this.lblFiltroDescricao.Location = new System.Drawing.Point(6, 80);
            this.lblFiltroDescricao.Name = "lblFiltroDescricao";
            this.lblFiltroDescricao.Size = new System.Drawing.Size(61, 13);
            this.lblFiltroDescricao.TabIndex = 8;
            this.lblFiltroDescricao.Text = "Fornecedor";
            // 
            // rbTipoPagamento
            // 
            this.rbTipoPagamento.AutoSize = true;
            this.rbTipoPagamento.Location = new System.Drawing.Point(379, 31);
            this.rbTipoPagamento.Name = "rbTipoPagamento";
            this.rbTipoPagamento.Size = new System.Drawing.Size(118, 17);
            this.rbTipoPagamento.TabIndex = 7;
            this.rbTipoPagamento.Text = "Tipo de Pagamento";
            this.rbTipoPagamento.UseVisualStyleBackColor = true;
            this.rbTipoPagamento.CheckedChanged += new System.EventHandler(this.rbTipoPagamento_CheckedChanged);
            // 
            // rbPlanoDeContas
            // 
            this.rbPlanoDeContas.AutoSize = true;
            this.rbPlanoDeContas.Location = new System.Drawing.Point(122, 31);
            this.rbPlanoDeContas.Name = "rbPlanoDeContas";
            this.rbPlanoDeContas.Size = new System.Drawing.Size(103, 17);
            this.rbPlanoDeContas.TabIndex = 6;
            this.rbPlanoDeContas.Text = "Plano de Contas";
            this.rbPlanoDeContas.UseVisualStyleBackColor = true;
            this.rbPlanoDeContas.CheckedChanged += new System.EventHandler(this.rbPlanoDeContas_CheckedChanged);
            // 
            // rbPagamento
            // 
            this.rbPagamento.AutoSize = true;
            this.rbPagamento.Location = new System.Drawing.Point(929, 31);
            this.rbPagamento.Name = "rbPagamento";
            this.rbPagamento.Size = new System.Drawing.Size(105, 17);
            this.rbPagamento.TabIndex = 5;
            this.rbPagamento.Text = "Data Pagamento";
            this.rbPagamento.UseVisualStyleBackColor = true;
            this.rbPagamento.CheckedChanged += new System.EventHandler(this.rbPagamento_CheckedChanged);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Checked = true;
            this.rbFornecedor.Location = new System.Drawing.Point(6, 31);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(79, 17);
            this.rbFornecedor.TabIndex = 4;
            this.rbFornecedor.TabStop = true;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbFornecedor_CheckedChanged);
            // 
            // rbsituacao
            // 
            this.rbsituacao.AutoSize = true;
            this.rbsituacao.Location = new System.Drawing.Point(534, 31);
            this.rbsituacao.Name = "rbsituacao";
            this.rbsituacao.Size = new System.Drawing.Size(67, 17);
            this.rbsituacao.TabIndex = 3;
            this.rbsituacao.Text = "Situação";
            this.rbsituacao.UseVisualStyleBackColor = true;
            this.rbsituacao.CheckedChanged += new System.EventHandler(this.rbsituacao_CheckedChanged);
            // 
            // rbVencimento
            // 
            this.rbVencimento.AutoSize = true;
            this.rbVencimento.Location = new System.Drawing.Point(785, 31);
            this.rbVencimento.Name = "rbVencimento";
            this.rbVencimento.Size = new System.Drawing.Size(107, 17);
            this.rbVencimento.TabIndex = 2;
            this.rbVencimento.Text = "Data Vencimento";
            this.rbVencimento.UseVisualStyleBackColor = true;
            this.rbVencimento.CheckedChanged += new System.EventHandler(this.rbVencimento_CheckedChanged);
            // 
            // rbLancamento
            // 
            this.rbLancamento.AutoSize = true;
            this.rbLancamento.Location = new System.Drawing.Point(638, 31);
            this.rbLancamento.Name = "rbLancamento";
            this.rbLancamento.Size = new System.Drawing.Size(110, 17);
            this.rbLancamento.TabIndex = 1;
            this.rbLancamento.Text = "Data Lançamento";
            this.rbLancamento.UseVisualStyleBackColor = true;
            this.rbLancamento.CheckedChanged += new System.EventHandler(this.rbLancamento_CheckedChanged);
            // 
            // rbDoc
            // 
            this.rbDoc.AutoSize = true;
            this.rbDoc.Location = new System.Drawing.Point(262, 31);
            this.rbDoc.Name = "rbDoc";
            this.rbDoc.Size = new System.Drawing.Size(80, 17);
            this.rbDoc.TabIndex = 0;
            this.rbDoc.Text = "Documento";
            this.rbDoc.UseVisualStyleBackColor = true;
            this.rbDoc.CheckedChanged += new System.EventHandler(this.rbDoc_CheckedChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(131, 583);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(21, 13);
            this.lblValorTotal.TabIndex = 5;
            this.lblValorTotal.Text = "R$";
            // 
            // FrmContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 623);
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLancamento;
        private System.Windows.Forms.RadioButton rbDoc;
        private System.Windows.Forms.RadioButton rbsituacao;
        private System.Windows.Forms.RadioButton rbVencimento;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.RadioButton rbTipoPagamento;
        private System.Windows.Forms.RadioButton rbPlanoDeContas;
        private System.Windows.Forms.RadioButton rbPagamento;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblFiltroDescricao;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.MaskedTextBox txtDataFim;
        private System.Windows.Forms.Label lblFim;
    }
}