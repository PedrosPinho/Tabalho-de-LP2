using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalgo_LP2
{
    class Database
    {
        private static SQLiteConnection conexao;
        private static Database instance;
        private const string URL = "Data Source=VannerBD.db";

        private Database()
        {
            // se o arquivo não existe, vamos criar
            if (!File.Exists("VannerBD.db"))
                GerarBD();

            conexao = new SQLiteConnection(URL);
        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public SQLiteConnection GetConnection()
        {
            return conexao;
        }

        public void ExecuteSQL(string qry)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }
            //PROBLEMAS AQUI NA LINHA DE COMANDO TA DA DANDO EXCESSÃO ARRUMAR
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            comm.ExecuteNonQuery();
            conexao.Close();
        }

        private void GerarBD()
        {
            SQLiteConnection.CreateFile("VannerBD.db");
            SQLiteConnection conn = new SQLiteConnection(URL);
            conn.Open();

            //CRIA TABELA CLIENTE

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Cliente (");
            sql.AppendLine("[Cpf] TEXT PRIMARY KEY NOT NULL UNIQUE,");
            sql.AppendLine("[Nome] TEXT,");
            sql.AppendLine("[Telefone] TEXT);");

            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            // CRIA TABELA FUNCIONARIO

            sql.Clear();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Funcionario (");
            sql.AppendLine("[Registro] TEXT PRIMARY KEY NOT NULL UNIQUE,");
            sql.AppendLine("[Nome] TEXT,");
            sql.AppendLine("[Cpf] TEXT UNIQUE,");
            sql.AppendLine("[Funcao] TEXT,");
            sql.AppendLine("[Data_inicio] TEXT,");
            sql.AppendLine("[Telefone] TEXT);");

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            //CRIA TABELA CARDÁPIO
            sql.Clear();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Cardapio (");
            sql.AppendLine("[Id] INTERGER PRIMARY KEY NOT NULL UNIQUE,");
            sql.AppendLine("[Nome] TEXT,");
            sql.AppendLine("[Descricao] TEXT,");
            sql.AppendLine("[preco] REAL,");
            

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }
            conn.Close();
        }
    }
}
