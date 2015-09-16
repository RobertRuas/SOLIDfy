using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Objetos
{
    public class ItemEstoque : CamposComuns
    {
        private string codigo_de_barras;
        private string nome;
        private string descricao;
        private string detalhes;
        private string categria;

        private string endereco_estoque;
        private string unidade_medida;
        private float quantidade;
        private float quantidade_maxima;
        private float quantidade_minima;

        private float dimessao_x;
        private float dimessao_y;
        private float dimessao_z;
        private float peso;

        private float juros_icms;
        private float juros_ipi;
        private float juros_outros;

        private float desconto;

        private float valor_fornecedor;
        private float valor_integral;
        private float valor_final;

        private string fornecedor_principal;

        private string marca;
        private string modelo;
        private string lote;
        private DateTime data_vencimento;

        public string Codigo_de_barras
        {
            get { return codigo_de_barras; }
            set { codigo_de_barras = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Detalhes
        {
            get { return detalhes; }
            set { detalhes = value; }
        }

        public string Categria
        {
            get { return categria; }
            set { categria = value; }
        }

        public string Endereco_estoque
        {
            get { return endereco_estoque; }
            set { endereco_estoque = value; }
        }

        public string Unidade_medida
        {
            get { return unidade_medida; }
            set { unidade_medida = value; }
        }

        public float Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public float Quantidade_maxima
        {
            get { return quantidade_maxima; }
            set { quantidade_maxima = value; }
        }

        public float Quantidade_minima
        {
            get { return quantidade_minima; }
            set { quantidade_minima = value; }
        }

        public float Dimessao_x
        {
            get { return dimessao_x; }
            set { dimessao_x = value; }
        }

        public float Dimessao_y
        {
            get { return dimessao_y; }
            set { dimessao_y = value; }
        }

        public float Dimessao_z
        {
            get { return dimessao_z; }
            set { dimessao_z = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public float Juros_icms
        {
            get { return juros_icms; }
            set { juros_icms = value; }
        }

        public float Juros_ipi
        {
            get { return juros_ipi; }
            set { juros_ipi = value; }
        }

        public float Juros_outros
        {
            get { return juros_outros; }
            set { juros_outros = value; }
        }

        public float Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        public float Valor_fornecedor
        {
            get { return valor_fornecedor; }
            set { valor_fornecedor = value; }
        }

        public float Valor_integral
        {
            get { return valor_integral; }
            set { valor_integral = value; }
        }

        public float Valor_final
        {
            get { return valor_final; }
            set { valor_final = value; }
        }

        public string Fornecedor_principal
        {
            get { return fornecedor_principal; }
            set { fornecedor_principal = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Lote
        {
            get { return lote; }
            set { lote = value; }
        }

        public DateTime Data_vencimento
        {
            get { return data_vencimento; }
            set { data_vencimento = value; }
        }

    }
}
