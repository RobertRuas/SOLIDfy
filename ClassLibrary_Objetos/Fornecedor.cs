using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Objetos
{
    public class Fornecedor : CamposComuns
    {
        private string nome_fantasia;
        private string razao_social;
        private string cnjp;
        private string seguimento;
        private string tel_principal;
        private string tel_alternativo;
        private string email;
        private string webpage;
        private int endereco_codigo;

        private string representanteNome;
        private string representanteSexo;
        private string representanteTel1;
        private string representanteTel2;
        private string representanteEmail;

        private string obsevacoes;
        private string status;

        public string Nome_fantasia
        {
            get { return nome_fantasia; }
            set { nome_fantasia = value; }
        }

        public string Razao_social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }

        public string Cnjp
        {
            get { return cnjp; }
            set { cnjp = value; }
        }

        public string Seguimento
        {
            get { return seguimento; }
            set { seguimento = value; }
        }

        public string Tel_principal
        {
            get { return tel_principal; }
            set { tel_principal = value; }
        }

        public string Tel_alternativo
        {
            get { return tel_alternativo; }
            set { tel_alternativo = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Webpage
        {
            get { return webpage; }
            set { webpage = value; }
        }

        public int Endereco_codigo
        {
            get { return endereco_codigo; }
            set { endereco_codigo = value; }
        }

        public string RepresentanteNome
        {
            get { return representanteNome; }
            set { representanteNome = value; }
        }

        public string RepresentanteSexo
        {
            get { return representanteSexo; }
            set { representanteSexo = value; }
        }

        public string RepresentanteTel1
        {
            get { return representanteTel1; }
            set { representanteTel1 = value; }
        }

        public string RepresentanteTel2
        {
            get { return representanteTel2; }
            set { representanteTel2 = value; }
        }

        public string RepresentanteEmail
        {
            get { return representanteEmail; }
            set { representanteEmail = value; }
        }

        public string Obsevacoes
        {
            get { return obsevacoes; }
            set { obsevacoes = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
