using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Trabalgo_LP2
{
    class ClienteDAO
    {
        public void Create(Cliente c)
        {
            //insere na tabela um cliente
            Database VannerDB = Database.GetInstance();

            string qry =
            string.Format("INSERT INTO Cliente (CPF, NOME, TELEFONE) VALUES ('{0}','{1}', '{2}')",
                c.Cpf, c.Nome, c.Telefone);
            VannerDB.ExecuteSQL(qry);
        }

        public Cliente Read(int cpf)
        {
            //retorna a partir do cpf um cliente
            Cliente cliente = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT Cpf, Nome, Telefone FROM Cliente WHERE Cpf = " +
                         cpf ;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read()) // A busca por chave primária só retorna um objeto
            {
                // Cria um objeto Cliente para transferir os dados 
                // do banco para a aplicação (DTO)
                cliente = new Cliente();
                cliente.Cpf = dr.GetString(0);
                cliente.Nome = dr.GetString(1);
                cliente.Telefone = dr.GetString(2);
            }

            dr.Close();  // precisa fechar o datareader para nao dar database locked
            conexao.Close();

            return cliente;
        }

        public void Update(Cliente c)
        {
            //atualiza no banco um cliente especifico
            Database VannerDB = Database.GetInstance();

            string qry = string.Format("UPDATE Cliente SET Nome='{0}', Telefone='{1}' WHERE Cpf like '{2}'", c.Nome, c.Telefone, c.Cpf);
            
            VannerDB.ExecuteSQL(qry);

        }

        public List<Cliente> ListAll()
        {
            //cria e retorna uma lista com todos os clientes
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT Cpf, Nome, Telefone FROM Cliente";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto Cliente para transferir os dados 
                // do banco para a aplicação (DTO)
                cliente = new Cliente();
                cliente.Cpf = dr.GetString(0);
                cliente.Nome = dr.GetString(1);
                cliente.Telefone = dr.GetString(2);

                lista.Add(cliente); // Adiciona o objeto na lista de resultados
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return lista;
        }

        public List<Cliente> FindByName(string nome)
        {
            //lista e retorna uma lista com todos os clientes que 
            //tiverem a STRING NOME em seu nome
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry;

            if (nome != "") // verifica se a consulta não é vazia
                qry = string.Format("SELECT Cpf, Nome, Telefone FROM Cliente WHERE nome LIKE '%{0}%'", nome);
            else
                qry = "SELECT Cpf, Nome, Telefone FROM Cliente";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cliente = new Cliente();
                cliente.Cpf = dr.GetString(0);
                cliente.Nome = dr.GetString(1);
                cliente.Telefone = dr.GetString(2);

                lista.Add(cliente);

            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close();
            return lista;

        }

    }
}
