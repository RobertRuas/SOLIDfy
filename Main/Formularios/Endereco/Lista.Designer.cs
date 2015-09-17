namespace Main.Formularios.Endereco
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.dataGridView_Lista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_buscarPor = new System.Windows.Forms.ComboBox();
            this.textBox_buscaValor = new System.Windows.Forms.TextBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.panel_TOP = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.linkLabel_Ajuda = new System.Windows.Forms.LinkLabel();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_ImprimirExportar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).BeginInit();
            this.panel_TOP.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Lista
            // 
            this.dataGridView_Lista.AllowUserToAddRows = false;
            this.dataGridView_Lista.AllowUserToDeleteRows = false;
            this.dataGridView_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lista.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CEP,
            this.UF,
            this.Cidade,
            this.Bairro});
            this.dataGridView_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Lista.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Lista.Location = new System.Drawing.Point(0, 65);
            this.dataGridView_Lista.Name = "dataGridView_Lista";
            this.dataGridView_Lista.ReadOnly = true;
            this.dataGridView_Lista.RowHeadersWidth = 25;
            this.dataGridView_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Lista.Size = new System.Drawing.Size(584, 297);
            this.dataGridView_Lista.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Busca";
            // 
            // comboBox_buscarPor
            // 
            this.comboBox_buscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_buscarPor.FormattingEnabled = true;
            this.comboBox_buscarPor.Location = new System.Drawing.Point(11, 25);
            this.comboBox_buscarPor.Name = "comboBox_buscarPor";
            this.comboBox_buscarPor.Size = new System.Drawing.Size(130, 21);
            this.comboBox_buscarPor.TabIndex = 14;
            // 
            // textBox_buscaValor
            // 
            this.textBox_buscaValor.Location = new System.Drawing.Point(147, 25);
            this.textBox_buscaValor.Name = "textBox_buscaValor";
            this.textBox_buscaValor.Size = new System.Drawing.Size(274, 20);
            this.textBox_buscaValor.TabIndex = 15;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(427, 23);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(70, 23);
            this.button_Buscar.TabIndex = 10;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // panel_TOP
            // 
            this.panel_TOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_TOP.Controls.Add(this.label1);
            this.panel_TOP.Controls.Add(this.button_Buscar);
            this.panel_TOP.Controls.Add(this.textBox_buscaValor);
            this.panel_TOP.Controls.Add(this.comboBox_buscarPor);
            this.panel_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TOP.Location = new System.Drawing.Point(0, 0);
            this.panel_TOP.Name = "panel_TOP";
            this.panel_TOP.Size = new System.Drawing.Size(584, 65);
            this.panel_TOP.TabIndex = 16;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Bottom.Controls.Add(this.linkLabel_Ajuda);
            this.panel_Bottom.Controls.Add(this.button_Editar);
            this.panel_Bottom.Controls.Add(this.button_ImprimirExportar);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 272);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(584, 65);
            this.panel_Bottom.TabIndex = 16;
            // 
            // linkLabel_Ajuda
            // 
            this.linkLabel_Ajuda.AutoSize = true;
            this.linkLabel_Ajuda.Location = new System.Drawing.Point(11, 41);
            this.linkLabel_Ajuda.Name = "linkLabel_Ajuda";
            this.linkLabel_Ajuda.Size = new System.Drawing.Size(34, 13);
            this.linkLabel_Ajuda.TabIndex = 13;
            this.linkLabel_Ajuda.TabStop = true;
            this.linkLabel_Ajuda.Text = "Ajuda";
            // 
            // button_Editar
            // 
            this.button_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_Editar.Location = new System.Drawing.Point(136, 3);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(119, 35);
            this.button_Editar.TabIndex = 11;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            // 
            // button_ImprimirExportar
            // 
            this.button_ImprimirExportar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_ImprimirExportar.Location = new System.Drawing.Point(11, 3);
            this.button_ImprimirExportar.Name = "button_ImprimirExportar";
            this.button_ImprimirExportar.Size = new System.Drawing.Size(119, 35);
            this.button_ImprimirExportar.TabIndex = 12;
            this.button_ImprimirExportar.Text = "Imprimir/Exportar";
            this.button_ImprimirExportar.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 337);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 22);
            this.toolStripLabel1.Text = "Items encontrados 0";
            // 
            // Lista
            // 
            this.AcceptButton = this.button_Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView_Lista);
            this.Controls.Add(this.panel_TOP);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço > Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).EndInit();
            this.panel_TOP.ResumeLayout(false);
            this.panel_TOP.PerformLayout();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_buscarPor;
        private System.Windows.Forms.TextBox textBox_buscaValor;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Panel panel_TOP;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.LinkLabel linkLabel_Ajuda;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_ImprimirExportar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}