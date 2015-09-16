using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLibrary_DADOS
{
    public class ComandosSQL : Conexao
    {
        public void ExecutarComandoSQL(MySqlCommand objComando)
        {
            try
            {
                Conectar();

                objComando.Connection = conn;
                objComando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao tentar efetuar comando SQL: " + ex.Message);
            }
            finally
            { Desconectar(); }
        }

        public DataTable RetornarDataTable(string Tabela)
        {
            try
            {
                Conectar();

                DataTable dt = new DataTable();
                MySqlCommand objComando = new MySqlCommand();
                MySqlDataAdapter objDataAdapter = new MySqlDataAdapter();
                MySqlDataAdapter returnVal = new MySqlDataAdapter();

                objComando.Connection = conn;
                objComando.CommandText = "SELECT * FROM " + Tabela + " LIMIT 100";

                objDataAdapter.SelectCommand = objComando;

                objDataAdapter.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao tentar efetuar comando SQL: " + ex.Message);
            }
            finally
            { Desconectar(); }
        }

        public DataTable RetornarDataTable(int zero, string CommandText)
        {
            try
            {
                Conectar();

                DataTable dt = new DataTable();
                MySqlCommand objComando = new MySqlCommand();
                MySqlDataAdapter objDataAdapter = new MySqlDataAdapter();
                MySqlDataAdapter returnVal = new MySqlDataAdapter();

                objComando.Connection = conn;
                objComando.CommandText = CommandText;

                objDataAdapter.SelectCommand = objComando;

                objDataAdapter.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao tentar efetuar comando SQL: " + ex.Message);
            }
            finally
            { Desconectar(); }
        }
    }
}
