﻿namespace Main.Formularios.MODELOS
{
    partial class modeloLISTA
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_buscaValor = new System.Windows.Forms.TextBox();
            this.comboBox_buscarPor = new System.Windows.Forms.ComboBox();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.linkLabel_Ajuda = new System.Windows.Forms.LinkLabel();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_ImprimirExportar = new System.Windows.Forms.Button();
            this.dataGridView_Lista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel_Top.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Top.Controls.Add(this.groupBox1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(652, 62);
            this.panel_Top.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Buscar);
            this.groupBox1.Controls.Add(this.textBox_buscaValor);
            this.groupBox1.Controls.Add(this.comboBox_buscarPor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(422, 17);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(70, 23);
            this.button_Buscar.TabIndex = 16;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // textBox_buscaValor
            // 
            this.textBox_buscaValor.Location = new System.Drawing.Point(142, 19);
            this.textBox_buscaValor.Name = "textBox_buscaValor";
            this.textBox_buscaValor.Size = new System.Drawing.Size(274, 20);
            this.textBox_buscaValor.TabIndex = 19;
            // 
            // comboBox_buscarPor
            // 
            this.comboBox_buscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_buscarPor.FormattingEnabled = true;
            this.comboBox_buscarPor.Location = new System.Drawing.Point(6, 19);
            this.comboBox_buscarPor.Name = "comboBox_buscarPor";
            this.comboBox_buscarPor.Size = new System.Drawing.Size(130, 21);
            this.comboBox_buscarPor.TabIndex = 18;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Bottom.Controls.Add(this.linkLabel_Ajuda);
            this.panel_Bottom.Controls.Add(this.button_Editar);
            this.panel_Bottom.Controls.Add(this.button_ImprimirExportar);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 271);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(652, 66);
            this.panel_Bottom.TabIndex = 0;
            // 
            // linkLabel_Ajuda
            // 
            this.linkLabel_Ajuda.AutoSize = true;
            this.linkLabel_Ajuda.Location = new System.Drawing.Point(11, 43);
            this.linkLabel_Ajuda.Name = "linkLabel_Ajuda";
            this.linkLabel_Ajuda.Size = new System.Drawing.Size(34, 13);
            this.linkLabel_Ajuda.TabIndex = 10;
            this.linkLabel_Ajuda.TabStop = true;
            this.linkLabel_Ajuda.Text = "Ajuda";
            // 
            // button_Editar
            // 
            this.button_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_Editar.Location = new System.Drawing.Point(136, 5);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(119, 35);
            this.button_Editar.TabIndex = 8;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            // 
            // button_ImprimirExportar
            // 
            this.button_ImprimirExportar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_ImprimirExportar.Location = new System.Drawing.Point(11, 5);
            this.button_ImprimirExportar.Name = "button_ImprimirExportar";
            this.button_ImprimirExportar.Size = new System.Drawing.Size(119, 35);
            this.button_ImprimirExportar.TabIndex = 9;
            this.button_ImprimirExportar.Text = "Imprimir/Exportar";
            this.button_ImprimirExportar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Lista
            // 
            this.dataGridView_Lista.AllowUserToAddRows = false;
            this.dataGridView_Lista.AllowUserToDeleteRows = false;
            this.dataGridView_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lista.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Lista.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Lista.Location = new System.Drawing.Point(0, 62);
            this.dataGridView_Lista.Name = "dataGridView_Lista";
            this.dataGridView_Lista.ReadOnly = true;
            this.dataGridView_Lista.RowHeadersWidth = 25;
            this.dataGridView_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Lista.Size = new System.Drawing.Size(652, 300);
            this.dataGridView_Lista.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(652, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 22);
            this.toolStripLabel1.Text = "0 Items encontrados";
            // 
            // modeloLISTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 362);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView_Lista);
            this.Controls.Add(this.panel_Top);
            this.Name = "modeloLISTA";
            this.Text = "modeloLISTA";
            this.panel_Top.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.DataGridView dataGridView_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_ImprimirExportar;
        private System.Windows.Forms.LinkLabel linkLabel_Ajuda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_buscaValor;
        private System.Windows.Forms.ComboBox comboBox_buscarPor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}