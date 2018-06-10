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
        public void Update(Cliente c)
        {
            //atualiza no banco um cliente especifico
            Database VannerDB = Database.GetInstance();

            string qry = string.Format("UPDATE Cliente SET Nome='{0}', Telefone='{1}' WHERE Cpf like '{2}'", c.Nome, c.Telefone, c.Cpf);

            VannerDB.ExecuteSQL(qry);

        }
    }
}
