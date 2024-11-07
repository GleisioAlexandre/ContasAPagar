namespace ContasAPagar.view
{
    partial class Frm_Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecdorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentoToolStripMenuItem,
            this.fornecdorToolStripMenuItem,
            this.planoDeContasToolStripMenuItem,
            this.situaçãoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // fornecdorToolStripMenuItem
            // 
            this.fornecdorToolStripMenuItem.Name = "fornecdorToolStripMenuItem";
            this.fornecdorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecdorToolStripMenuItem.Text = "Fornecdor";
            // 
            // planoDeContasToolStripMenuItem
            // 
            this.planoDeContasToolStripMenuItem.Name = "planoDeContasToolStripMenuItem";
            this.planoDeContasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planoDeContasToolStripMenuItem.Text = "Plano de Contas";
            // 
            // situaçãoToolStripMenuItem
            // 
            this.situaçãoToolStripMenuItem.Name = "situaçãoToolStripMenuItem";
            this.situaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.situaçãoToolStripMenuItem.Text = "Situação";
            this.situaçãoToolStripMenuItem.Click += new System.EventHandler(this.situaçãoToolStripMenuItem_Click);
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentoToolStripMenuItem.Text = "Documento";
            this.documentoToolStripMenuItem.Click += new System.EventHandler(this.documentoToolStripMenuItem_Click);
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 607);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecdorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
    }
}