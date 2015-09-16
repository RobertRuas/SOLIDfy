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

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Marca.Lista frmSHOW = new Formularios.Estoque.Marca.Lista();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Marca.Novo frmSHOW = new Formularios.Estoque.Marca.Novo();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void listaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Modelo.Lista frmSHOW = new Formularios.Estoque.Modelo.Lista();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Formularios.Estoque.Modelo.Novo frmSHOW = new Formularios.Estoque.Modelo.Novo();
            frmSHOW.MdiParent = this;
            frmSHOW.Show();
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
    }
}
