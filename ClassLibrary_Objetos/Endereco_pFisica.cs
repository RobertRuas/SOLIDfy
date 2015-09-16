using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Objetos
{
    public class Endereco_pFisica : CamposComuns
    {
        private string pais;
        private string uf;
        private string uf_regiao;
        private string cidade;
        private string cidade_regiao;
        private string bairro;
        private string logradouro;
        private string tipo_logradouro;
        private int numero;
        private string complemento;
        private string pontos_referencia;
        private string geo_localizacao;
        private string nome_proprietario;
        private string melhor_horario;

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public string Uf_regiao
        {
            get { return uf_regiao; }
            set { uf_regiao = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Cidade_regiao
        {
            get { return cidade_regiao; }
            set { cidade_regiao = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public string Tipo_logradouro
        {
            get { return tipo_logradouro; }
            set { tipo_logradouro = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Pontos_referencia
        {
            get { return pontos_referencia; }
            set { pontos_referencia = value; }
        }

        public string Geo_localizacao
        {
            get { return geo_localizacao; }
            set { geo_localizacao = value; }
        }

        public string Nome_proprietario
        {
            get { return nome_proprietario; }
            set { nome_proprietario = value; }
        }

        public string Melhor_horario
        {
            get { return melhor_horario; }
            set { melhor_horario = value; }
        }
    }
}
