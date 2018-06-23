using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class ConsumidosDAO
    {
        public List<Consumidos> listAll(int i)
        {
            //Lista todos os itens do banco no grid
            List<Consumidos> lista = new List<Consumidos>();
            Consumidos consumido= null;

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM Consumidos{0}", i);

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto Cliente para transferir os dados 
                // do banco para a aplicação (DTO)
                consumido = new Consumidos();
                consumido.Id = dr.GetInt32(0);
                consumido.Quantidade = dr.GetInt32(1);

                lista.Add(consumido); // Adiciona o objeto na lista de resultados
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return lista;
        }

        public Boolean AlreadyIn(int mesa, int id)
        {
            if (listAll(mesa) != null)
            {
                List<Consumidos> lista = listAll(mesa);

                foreach (Consumidos c in lista)
                {
                    if (c.Id == id)
                        return true;
                }
            }
            return false;
        }

        public float GetConsumidos(int i)
        {
            List<Consumidos> listaCons = new List<Consumidos>();
            CardapioDAO cardapio = new CardapioDAO();
            Consumidos consumido = null;
            float total = 0;
            List<Cardapio> lista = cardapio.listAll();

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry =
            string.Format( "SELECT co.id, co.quantidade, c.preco FROM Consumidos{0} co inner join Cardapio c on c.id = co.id", i);

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto Cliente para transferir os dados 
                // do banco para a aplicação (DTO)
                consumido = new Consumidos();
                consumido.Id = dr.GetInt32(0);
                consumido.Quantidade = dr.GetInt32(1);
                consumido.Preco = dr.GetFloat(2);

                listaCons.Add(consumido);                
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            foreach(Consumidos c in listaCons)
            {
                total += (c.Preco * c.Quantidade);
            }

            return total;

        }

        public void Clear(int id)
        {
            //JA OUVIU FALAR NO UPDATE SEM WHERE??? TO USANDO A MESMA PREMISSA AQUI COM ESSE DELETE SEM WHERE HEHE
            Database VannerDB = Database.GetInstance();

            string qry = string.Format("DELETE FROM Consumidos{0}", id);

            VannerDB.ExecuteSQL(qry);
        }

        public void Add(int id, int qtd, int mesa)
        {
            Database VannerDB = Database.GetInstance();
            CardapioDAO cardapioDAO = new CardapioDAO();
            List<Cardapio> cardapio = cardapioDAO.listAll();
            //verifica se o item existe no cardapio, se sim, adiciona no banco
            foreach(Cardapio c in cardapio)
            {
                if (c.Id == id && !AlreadyIn(mesa, id))
                {
                    string qry = string.Format("INSERT INTO Consumidos{1} (id, quantidade) VALUES ('{0}', '{2}')", id, mesa, qtd);
                    VannerDB.ExecuteSQL(qry);
                    return;   
                }
                else if(c.Id == id && AlreadyIn(mesa, id))
                {
                    string qry0 = string.Format("UPDATE Consumidos{1} SET quantidade = '{2}'+quantidade WHERE id = '{0}'", id, mesa, qtd);
                    VannerDB.ExecuteSQL(qry0);
                    return;
                }
            }
        }
    }
}

