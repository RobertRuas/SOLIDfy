using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Objetos
{
    public class Modelo : CamposComuns
    {
        private string nome;
        private string marca;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
    }
}
