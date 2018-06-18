using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class MesaDAO
    {
        public List<Mesa> ListAll()
        {
            //cria e retorna uma lista com todos os clientes
            List<Mesa> lista = new List<Mesa>();
            Mesa mesa = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT num_mesa, num_pessoas FROM Mesa";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto Cliente para transferir os dados 
                // do banco para a aplicação (DTO)
                mesa = new Mesa();
                mesa.Num_mesa = dr.GetInt32(0);
                mesa.Num_pessoas = dr.GetInt32(1);

                lista.Add(mesa); // Adiciona o objeto na lista de resultados
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return lista;
        }
        public void Update(Mesa m)
        {
            Database VannerDB = Database.GetInstance();

            string qry = string.Format("UPDATE Mesa SET Num_pessoas='{0}' WHERE Num_mesa = '{1}'", m.Num_pessoas, m.Num_mesa);

            VannerDB.ExecuteSQL(qry);

        }
        public void UpdateF(int num_mesa)
        {
            Database VannerDB = Database.GetInstance();

            string qry = string.Format("UPDATE Mesa SET Num_pessoas='{0}' WHERE Num_mesa = '{1}'", 0, num_mesa);

            VannerDB.ExecuteSQL(qry);
        }
        public int NumPessoas(int i)
        {
            int num_pessoas = 0;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            string qry = string.Format("SELECT num_pessoas FROM Mesa WHERE num_mesa = {0}", i);

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                num_pessoas = dr.GetInt32(0);
            }
            
            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return num_pessoas;
        }
    }
}
