using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Objetos
{
    public class ItemEstoqueCategoria : CamposComuns
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
