namespace Main
{
    partial class formMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_Principal = new System.Windows.Forms.MenuStrip();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Principal
            // 
            this.menuStrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.menuStrip_Principal.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Principal.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuStrip_Principal.Name = "menuStrip_Principal";
            this.menuStrip_Principal.Size = new System.Drawing.Size(909, 24);
            this.menuStrip_Principal.TabIndex = 0;
            this.menuStrip_Principal.Text = "menuStrip1";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endereçosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.estoqueToolStripMenuItem1});
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // endereçosToolStripMenuItem
            // 
            this.endereçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem1,
            this.novoToolStripMenuItem1});
            this.endereçosToolStripMenuItem.Name = "endereçosToolStripMenuItem";
            this.endereçosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.endereçosToolStripMenuItem.Text = "Endereços";
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.listaToolStripMenuItem1.Text = "Lista";
            this.listaToolStripMenuItem1.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem1.Text = "Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem3,
            this.novoToolStripMenuItem3});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // listaToolStripMenuItem3
            // 
            this.listaToolStripMenuItem3.Name = "listaToolStripMenuItem3";
            this.listaToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.listaToolStripMenuItem3.Text = "Lista";
            this.listaToolStripMenuItem3.Click += new System.EventHandler(this.listaToolStripMenuItem3_Click);
            // 
            // novoToolStripMenuItem3
            // 
            this.novoToolStripMenuItem3.Name = "novoToolStripMenuItem3";
            this.novoToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem3.Text = "Novo";
            this.novoToolStripMenuItem3.Click += new System.EventHandler(this.novoToolStripMenuItem3_Click);
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem4,
            this.itemToolStripMenuItem,
            this.toolStripSeparator1,
            this.marcasToolStripMenuItem,
            this.modelosToolStripMenuItem1});
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            // 
            // listaToolStripMenuItem4
            // 
            this.listaToolStripMenuItem4.Name = "listaToolStripMenuItem4";
            this.listaToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.listaToolStripMenuItem4.Text = "Lista";
            this.listaToolStripMenuItem4.Click += new System.EventHandler(this.listaToolStripMenuItem4_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemToolStripMenuItem.Text = "Novo";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem5,
            this.novoToolStripMenuItem4});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // listaToolStripMenuItem5
            // 
            this.listaToolStripMenuItem5.Name = "listaToolStripMenuItem5";
            this.listaToolStripMenuItem5.Size = new System.Drawing.Size(103, 22);
            this.listaToolStripMenuItem5.Text = "Lista";
            this.listaToolStripMenuItem5.Click += new System.EventHandler(this.listaToolStripMenuItem5_Click);
            // 
            // novoToolStripMenuItem4
            // 
            this.novoToolStripMenuItem4.Name = "novoToolStripMenuItem4";
            this.novoToolStripMenuItem4.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem4.Text = "Novo";
            this.novoToolStripMenuItem4.Click += new System.EventHandler(this.novoToolStripMenuItem4_Click);
            // 
            // modelosToolStripMenuItem1
            // 
            this.modelosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem6,
            this.novoToolStripMenuItem5});
            this.modelosToolStripMenuItem1.Name = "modelosToolStripMenuItem1";
            this.modelosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.modelosToolStripMenuItem1.Text = "Modelos";
            // 
            // listaToolStripMenuItem6
            // 
            this.listaToolStripMenuItem6.Name = "listaToolStripMenuItem6";
            this.listaToolStripMenuItem6.Size = new System.Drawing.Size(103, 22);
            this.listaToolStripMenuItem6.Text = "Lista";
            this.listaToolStripMenuItem6.Click += new System.EventHandler(this.listaToolStripMenuItem6_Click);
            // 
            // novoToolStripMenuItem5
            // 
            this.novoToolStripMenuItem5.Name = "novoToolStripMenuItem5";
            this.novoToolStripMenuItem5.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem5.Text = "Novo";
            this.novoToolStripMenuItem5.Click += new System.EventHandler(this.novoToolStripMenuItem5_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 623);
            this.Controls.Add(this.menuStrip_Principal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_Principal;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOLIDfy - Main";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip_Principal.ResumeLayout(false);
            this.menuStrip_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Principal;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

