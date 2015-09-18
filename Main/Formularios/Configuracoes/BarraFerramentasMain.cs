using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Formularios.Configuracoes
{
    public partial class BarraFerramentasMain : Form
    {
        formMain _formMain;

        public BarraFerramentasMain(formMain _formMain_)
        {
            InitializeComponent();

            _formMain = _formMain_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _formMain.toolStrip2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _formMain.toolStrip2.Visible = false;
        }
    }
}
