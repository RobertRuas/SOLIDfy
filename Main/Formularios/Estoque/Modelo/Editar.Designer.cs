namespace Main.Formularios.Estoque.Modelo
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.groupBox_DadosModelos = new System.Windows.Forms.GroupBox();
            this.linkLabel_AbrirFormMarcas = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.groupBox_DadosModelos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DadosModelos
            // 
            this.groupBox_DadosModelos.Controls.Add(this.button_Excluir);
            this.groupBox_DadosModelos.Controls.Add(this.linkLabel_AbrirFormMarcas);
            this.groupBox_DadosModelos.Controls.Add(this.linkLabel1);
            this.groupBox_DadosModelos.Controls.Add(this.comboBox_Marca);
            this.groupBox_DadosModelos.Controls.Add(this.button_Confirmar);
            this.groupBox_DadosModelos.Controls.Add(this.label3);
            this.groupBox_DadosModelos.Controls.Add(this.textBox_Nome);
            this.groupBox_DadosModelos.Controls.Add(this.label2);
            this.groupBox_DadosModelos.Location = new System.Drawing.Point(9, 9);
            this.groupBox_DadosModelos.Name = "groupBox_DadosModelos";
            this.groupBox_DadosModelos.Size = new System.Drawing.Size(301, 128);
            this.groupBox_DadosModelos.TabIndex = 3;
            this.groupBox_DadosModelos.TabStop = false;
            this.groupBox_DadosModelos.Text = "Editar Item";
            // 
            // linkLabel_AbrirFormMarcas
            // 
            this.linkLabel_AbrirFormMarcas.AutoSize = true;
            this.linkLabel_AbrirFormMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel_AbrirFormMarcas.Location = new System.Drawing.Point(277, 58);
            this.linkLabel_AbrirFormMarcas.Name = "linkLabel_AbrirFormMarcas";
            this.linkLabel_AbrirFormMarcas.Size = new System.Drawing.Size(18, 20);
            this.linkLabel_AbrirFormMarcas.TabIndex = 7;
            this.linkLabel_AbrirFormMarcas.TabStop = true;
            this.linkLabel_AbrirFormMarcas.Text = "+";
            this.linkLabel_AbrirFormMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 107);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ajuda";
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Items.AddRange(new object[] {
            "NULL"});
            this.comboBox_Marca.Location = new System.Drawing.Point(49, 60);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(225, 21);
            this.comboBox_Marca.TabIndex = 2;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(191, 87);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(104, 33);
            this.button_Confirmar.TabIndex = 0;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marca";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(49, 34);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(246, 20);
            this.textBox_Nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // button_Excluir
            // 
            this.button_Excluir.Location = new System.Drawing.Point(81, 87);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(104, 33);
            this.button_Excluir.TabIndex = 8;
            this.button_Excluir.Text = "Excluir";
            this.button_Excluir.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 142);
            this.Controls.Add(this.groupBox_DadosModelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo > Editar";
            this.groupBox_DadosModelos.ResumeLayout(false);
            this.groupBox_DadosModelos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DadosModelos;
        private System.Windows.Forms.LinkLabel linkLabel_AbrirFormMarcas;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox_Marca;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Excluir;
    }
}