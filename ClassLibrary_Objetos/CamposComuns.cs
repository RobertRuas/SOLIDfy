using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Objetos
{
    public class CamposComuns
    {
        private int id;
        private int codigo;
        private string cadastrado_por;
        private DateTime data_cadastro;
        private DateTime data_ultima_modificacao;
        private string usuarios_ultima_modificacao;
        private string status;
        private string status_motivo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Cadastrado_por
        {
            get { return cadastrado_por; }
            set { cadastrado_por = value; }
        }

        public DateTime Data_cadastro
        {
            get { return data_cadastro; }
            set { data_cadastro = value; }
        }

        public DateTime Data_ultima_modificacao
        {
            get { return data_ultima_modificacao; }
            set { data_ultima_modificacao = value; }
        }

        public string Usuarios_ultima_modificacao
        {
            get { return usuarios_ultima_modificacao; }
            set { usuarios_ultima_modificacao = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Status_motivo
        {
            get { return status_motivo; }
            set { status_motivo = value; }
        }
    }
}
