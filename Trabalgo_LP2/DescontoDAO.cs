using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class DescontoDAO
    {
        public void Create(int porcentagem, int frequencia)
        {
            //insere na tabela um cliente
            Database VannerDB = Database.GetInstance();

            string qry =
            string.Format("UPDATE Desconto SET Porcentagem = '{0}', Frequencia = '{1}'",
                porcentagem, frequencia);
            VannerDB.ExecuteSQL(qry);
        }
        public int GetDesconto(Cliente c)
        {
            
            ClienteDAO clientedao = new ClienteDAO();
            Cliente cliente = clientedao.Read(c.Cpf);
            int porcentagem = 0;
            int frequencia = 9999;

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry =
            string.Format("SELECT porcentagem, frequencia from Desconto");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                porcentagem = dr.GetInt32(0);
                frequencia = dr.GetInt32(1);
            }

            dr.Close(); 
            conexao.Close();

            if (cliente.Frequencia > frequencia)
            {
                return porcentagem;
            }
            else
            {
                return 0;
            }
        }
    }
}
