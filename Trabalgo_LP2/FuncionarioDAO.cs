using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Trabalgo_LP2
{
    class FuncionarioDAO
    {
        public void Create(Funcionario f)
        {
            Database VannerBD = Database.GetInstance();

            string qry =
            string.Format("INSERT INTO Funcionario (REGISTRO, NOME, CPF, FUNCAO, DATA_INICIO, TELEFONE) VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}')",
                f.Registro, f.Nome, f.Cpf, f.Funcao, f.Data_inicio, f.Telefone);
            VannerBD.ExecuteSQL(qry);
        }

        public Funcionario Read(int registro)
        {
            Funcionario funcionario = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT Registro, Nome, Cpf, Funcao, Data_inicio, Telefone FROM Funcionario WHERE Registro = " +
                         registro;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read()) // A busca por chave primária só retorna um objeto
            {
                // Cria um objeto Funcionario para transferir os dados 
                // do banco para a aplicação (DTO)
                funcionario = new Funcionario();
                funcionario.Registro = dr.GetString(0);
                funcionario.Nome = dr.GetString(1);
                funcionario.Cpf = dr.GetString(2);
                funcionario.Funcao = dr.GetString(3);
                funcionario.Data_inicio = dr.GetDateTime(4);
                funcionario.Telefone = dr.GetString(5);
            }

            dr.Close();  // precisa fechar o datareader para nao dar database locked
            conexao.Close();

            return funcionario;
        }

        public List<Funcionario> ListAll()
        {
            List<Funcionario> lista = new List<Funcionario>();
            Funcionario funcionario = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT Registro, Nome, Cpf, Funcao, Data_inicio, Telefone FROM Funcionario";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto Funcionario para transferir os dados 
                // do banco para a aplicação (DTO)
                funcionario = new Funcionario();
                funcionario.Registro = dr.GetString(0);
                funcionario.Nome = dr.GetString(1);
                funcionario.Cpf = dr.GetString(2);
                funcionario.Funcao = dr.GetString(3);
                funcionario.Data_inicio = dr.GetDateTime(4);
                funcionario.Telefone = dr.GetString(5);

                lista.Add(funcionario); // Adiciona o objeto na lista de resultados
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return lista;
        }
    }
}
