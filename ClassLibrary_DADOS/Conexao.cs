using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLibrary_DADOS
{
    public class Conexao
    {
        // DECLARANDO VARIAVEIS DE CONEXÃO
        protected MySqlConnection conn;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string conexaoString;

        // Contrutores --------------->>>
        public Conexao()
        {
            Server = "localhost";
            Database = "solidfy";
            Uid = "root";
            Password = "";
        }

        public Conexao(string _server, string _database, string _uid, string _password) 
        {
            server = _server;
            database = _database;
            uid = _uid;
            password = _password;
        }
        // Contrutores ---------------<<<

        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool TestarConexao()
        {
            conexaoString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            // Se houver alguma conexão, esta é enserrada.
            if (conn != null)
            { conn.Close(); }

            try
            {
                conn = new MySqlConnection(conexaoString);
                conn.Open();

                return true;
            }
            catch (Exception ex)
            {
                string e = ex.Message; ;
                return false;
            }
            finally
            { }
        }

        public MySqlConnection Conectar()
        {
            conexaoString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            // Se houver alguma conexão, esta é enserrada.
            if (conn != null)
            { conn.Close(); }

            try
            {
                conn = new MySqlConnection(conexaoString);
                conn.Open();

                return conn;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao tentar efetuar conexão com banco de dodos: " + ex.Message);
            }
            finally
            { }
        }

        public void Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao tentar efetuar conexão com banco de dodos: " + ex.Message);
            }
            finally
            { }
        }
    }
}
