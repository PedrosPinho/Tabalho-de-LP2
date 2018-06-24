using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
namespace Trabalgo_LP2
{
    class CardapioDAO
    {
        public void Create(Cardapio c)
        {
            //Insere um item no cardapio
            Database VannerDB = Database.GetInstance();
            
            string qry =
            string.Format("INSERT INTO Cardapio (ID, NOME, DESCRICAO, PRECO) VALUES ('{0}','{1}','{2}','{3}')",
                c.Id, c.Nome, c.Descricao, c.Preco);
            VannerDB.ExecuteSQL(qry);
        }

        public void Update(Cardapio c)
        {
            //Atualiza um item no cardapio usando o ID como referencia
            Database VannerDB = Database.GetInstance();

            string qry = string.Format("UPDATE Cardapio SET Nome='{0}', Descricao='{1}', Preco='{2}' WHERE Id like '{3}'",
                c.Nome, c.Descricao, c.Preco, c.Id);

            VannerDB.ExecuteSQL(qry);

        }

        public void Delete(int id)
        {
            //deleta do banco um item referente ao seu id
            Database VannerDB = Database.GetInstance();

            string qry = string.Format("DELETE FROM Cardapio WHERE id = {0}", id);

            VannerDB.ExecuteSQL(qry);
        }

        public List<Cardapio> listAll()
        {
            //Lista todos os itens do banco no grid
            List<Cardapio> lista = new List<Cardapio>();
            Cardapio cardapio = null;

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT * FROM Cardapio";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto Cliente para transferir os dados 
                // do banco para a aplicação (DTO)
                cardapio = new Cardapio();
                cardapio.Id = dr.GetInt32(0);
                cardapio.Nome = dr.GetString(1);
                cardapio.Descricao = dr.GetString(2);
                cardapio.Preco = dr.GetDouble(3);

                lista.Add(cardapio); // Adiciona o objeto na lista de resultados
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return lista;
        }
        public List<Cardapio> Find(string nome)
        {
            //Lista os itens buscados por nome
            List<Cardapio> lista = new List<Cardapio>();
            Cardapio cardapio = null;

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry;

            if (nome != "") // verifica se a consulta não é vazia
                qry = string.Format("SELECT * FROM Cardapio WHERE nome LIKE '%{0}%'", nome);
            else
                qry = "SELECT * FROM Cardapio";
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto Cliente para transferir os dados 
                // do banco para a aplicação (DTO)
                cardapio = new Cardapio();
                cardapio.Id = dr.GetInt32(0);
                cardapio.Nome = dr.GetString(1);
                cardapio.Descricao = dr.GetString(2);
                cardapio.Preco = dr.GetDouble(3);

                lista.Add(cardapio); // Adiciona o objeto na lista de resultados
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão


            return lista;
        }

        //SOBRECARGA DO METODO FIND(STRING NOME)
        public List<Cardapio> Find(int id)
        {
            //Lista os itens buscados por ID
            List<Cardapio> lista = new List<Cardapio>();
            Cardapio cardapio = null;

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry;

            if (id.ToString() != "") // verifica se a consulta não é vazia
                qry = string.Format("SELECT * FROM Cardapio WHERE id = '{0}'", id);
            else
                qry = "SELECT * FROM Cardapio";
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto Cliente para transferir os dados 
                // do banco para a aplicação (DTO)
                cardapio = new Cardapio();
                cardapio.Id = dr.GetInt32(0);
                cardapio.Nome = dr.GetString(1);
                cardapio.Descricao = dr.GetString(2);
                cardapio.Preco = dr.GetDouble(3);

                lista.Add(cardapio); // Adiciona o objeto na lista de resultados
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão


            return lista;
        }

        public List<Cardapio> listItens()
        {
            List<Cardapio> itens = new List<Cardapio>();
            Cardapio cardapio = null;

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT Id, Nome FROM Cardapio ORDER BY Id ASC";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cardapio = new Cardapio();
                cardapio.Id = dr.GetInt32(0);
                cardapio.Nome = dr.GetString(1);

                itens.Add(cardapio); // Adiciona o objeto na lista de resultados
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return itens;
        }
    }
}
