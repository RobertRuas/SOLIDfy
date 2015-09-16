using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Objetos
{
    public class Marca : CamposComuns
    {
        private string nome;
        private string fornecedor_principal;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Fornecedor_principal
        {
            get { return fornecedor_principal; }
            set { fornecedor_principal = value; }
        }
    }
}
