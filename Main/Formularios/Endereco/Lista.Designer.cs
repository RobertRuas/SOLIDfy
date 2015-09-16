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
            this.linkLabel_Ajuda = new System.Windows.Forms.LinkLabel();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_ImprimirExportar = new System.Windows.Forms.Button();
            this.groupBox_Lista = new System.Windows.Forms.GroupBox();
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
            this.groupBox_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_Ajuda
            // 
            this.linkLabel_Ajuda.AutoSize = true;
            this.linkLabel_Ajuda.Location = new System.Drawing.Point(6, 380);
            this.linkLabel_Ajuda.Name = "linkLabel_Ajuda";
            this.linkLabel_Ajuda.Size = new System.Drawing.Size(34, 13);
            this.linkLabel_Ajuda.TabIndex = 12;
            this.linkLabel_Ajuda.TabStop = true;
            this.linkLabel_Ajuda.Text = "Ajuda";
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(425, 383);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(70, 23);
            this.button_Editar.TabIndex = 10;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            // 
            // button_ImprimirExportar
            // 
            this.button_ImprimirExportar.Location = new System.Drawing.Point(315, 383);
            this.button_ImprimirExportar.Name = "button_ImprimirExportar";
            this.button_ImprimirExportar.Size = new System.Drawing.Size(104, 23);
            this.button_ImprimirExportar.TabIndex = 11;
            this.button_ImprimirExportar.Text = "Imprimir/Exportar";
            this.button_ImprimirExportar.UseVisualStyleBackColor = true;
            // 
            // groupBox_Lista
            // 
            this.groupBox_Lista.Controls.Add(this.dataGridView_Lista);
            this.groupBox_Lista.Location = new System.Drawing.Point(9, 52);
            this.groupBox_Lista.Name = "groupBox_Lista";
            this.groupBox_Lista.Size = new System.Drawing.Size(492, 325);
            this.groupBox_Lista.TabIndex = 9;
            this.groupBox_Lista.TabStop = false;
            this.groupBox_Lista.Text = "Lista de Endereços";
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
            this.dataGridView_Lista.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Lista.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Lista.Name = "dataGridView_Lista";
            this.dataGridView_Lista.ReadOnly = true;
            this.dataGridView_Lista.RowHeadersWidth = 25;
            this.dataGridView_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Lista.Size = new System.Drawing.Size(480, 300);
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
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Busca";
            // 
            // comboBox_buscarPor
            // 
            this.comboBox_buscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_buscarPor.FormattingEnabled = true;
            this.comboBox_buscarPor.Location = new System.Drawing.Point(9, 25);
            this.comboBox_buscarPor.Name = "comboBox_buscarPor";
            this.comboBox_buscarPor.Size = new System.Drawing.Size(130, 21);
            this.comboBox_buscarPor.TabIndex = 14;
            // 
            // textBox_buscaValor
            // 
            this.textBox_buscaValor.Location = new System.Drawing.Point(145, 25);
            this.textBox_buscaValor.Name = "textBox_buscaValor";
            this.textBox_buscaValor.Size = new System.Drawing.Size(274, 20);
            this.textBox_buscaValor.TabIndex = 15;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(425, 23);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(70, 23);
            this.button_Buscar.TabIndex = 10;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.AcceptButton = this.button_Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 412);
            this.Controls.Add(this.textBox_buscaValor);
            this.Controls.Add(this.comboBox_buscarPor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_Ajuda);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.button_ImprimirExportar);
            this.Controls.Add(this.groupBox_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço > Lista";
            this.groupBox_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_Ajuda;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_ImprimirExportar;
        private System.Windows.Forms.GroupBox groupBox_Lista;
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
    }
}