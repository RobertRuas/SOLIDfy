using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "É recomendado que seja alterado o modo de exibição desta janela para 'Maximizado' para melhor experiência. \n\nDeseja aplicar recomendações?", "SOLIDfy", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formularios.Endereco.Lista frmSHOW = new Formularios.Endereco.Lista();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formularios.Endereco.Novo frmSHOW = new Formularios.Endereco.Novo();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void listaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Formularios.Fornecedor.Lista frmSHOW = new Formularios.Fornecedor.Lista();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Formularios.Fornecedor.Novo frmSHOW = new Formularios.Fornecedor.Novo();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void listaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Marca.Lista frmSHOW = new Formularios.Estoque.Marca.Lista();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Marca.Novo frmSHOW = new Formularios.Estoque.Marca.Novo();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void listaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Modelo.Lista frmSHOW = new Formularios.Estoque.Modelo.Lista();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void novoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Modelo.Novo frmSHOW = new Formularios.Estoque.Modelo.Novo();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void listaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Item.Lista frmSHOW = new Formularios.Estoque.Item.Lista();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Item.Novo frmSHOW = new Formularios.Estoque.Item.Novo();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void barraDeFerramntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Configuracoes.BarraFerramentasMain frmSHOW = new Formularios.Configuracoes.BarraFerramentasMain(this);
            frmSHOW.Show();
        }
    }
}
