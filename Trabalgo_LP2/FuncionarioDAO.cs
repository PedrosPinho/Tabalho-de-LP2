using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

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
                funcionario = new Funcionario();
                funcionario.Registro = dr.GetString(0);
                funcionario.Nome = dr.GetString(1);
                funcionario.Cpf = dr.GetString(2);
                funcionario.Funcao = dr.GetString(3);
                funcionario.Data_inicio = dr.GetString(4);
                funcionario.Telefone = dr.GetString(5);

                lista.Add(funcionario);
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return lista;
        }

        public List<Funcionario> FindByName(string nome)
        {
            List<Funcionario> lista = new List<Funcionario>();
            Funcionario funcionario = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry;
            if (nome != "") // verifica se a consulta não é vazia
                qry = string.Format("SELECT Registro, Nome, Cpf, Funcao, Data_inicio, Telefone FROM Funcionario WHERE nome LIKE '%{0}%'", nome);
            else
                qry = "SELECT Registro, Nome, Cpf, Funcao, Data_inicio, Telefone FROM Funcionario";
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                funcionario = new Funcionario();
                funcionario.Registro = dr.GetString(0);
                funcionario.Nome = dr.GetString(1);
                funcionario.Cpf = dr.GetString(2);
                funcionario.Funcao = dr.GetString(3);
                funcionario.Data_inicio = dr.GetString(4);
                funcionario.Telefone = dr.GetString(5);

                lista.Add(funcionario);
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            return lista;
        }

        public Boolean ValidaLogin(string reg)
        {
            List<string> lista = new List<string>();
            Funcionario funcionario = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            //Seleciona todos registros do banco
            string qry = string.Format("SELECT Registro FROM Funcionario");
            
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();
            //coloca todos os registros na lista
            while (dr.Read())
            {
                funcionario = new Funcionario();
                funcionario.Registro = dr.GetString(0);
                lista.Add(funcionario.Registro);
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); // Não esqueça de fechar a conexão

            //compara o registro do usuario com a lista
            foreach (string l in lista)
                if(reg == l)
                    return true;

            return false;
        }

        public void Update(Funcionario f)
        {
            //atualiza no banco um cliente especifico
            Database VannerDB = Database.GetInstance();

            string qry = 
                string.Format("UPDATE Funcionario SET Nome='{0}', Cpf='{1}', Funcao='{2}', Data_inicio='{3}',  Telefone='{4}' WHERE Registro like '{5}'",
                    f.Nome, f.Cpf, f.Funcao, f.Data_inicio, f.Telefone, f.Registro);

            VannerDB.ExecuteSQL(qry);

        }
        public void Delete(string reg)
        {
            //deleta do banco um funcionario referente ao seu registro
            Database VannerDB = Database.GetInstance();

            string qry = string.Format("DELETE FROM Funcionario WHERE Registro = {0}", reg);

            VannerDB.ExecuteSQL(qry);
        }

        public Funcionario Read(int registro)
        {
            Funcionario funcionario = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT Registro, Nome, Cpf, Funcao, Data_inicio, Telefone FROM Funcionario WHERE registro = " +
                         registro;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read()) // A busca por chave primária só retorna um objeto
            {
                funcionario = new Funcionario();
                funcionario.Registro = dr.GetString(0);
                funcionario.Nome = dr.GetString(1);
                funcionario.Cpf = dr.GetString(2);
                funcionario.Funcao = dr.GetString(3);
                funcionario.Data_inicio = dr.GetString(4);
                funcionario.Telefone = dr.GetString(5);
            }

            dr.Close();  // precisa fechar o datareader para nao dar database locked
            conexao.Close();

            return funcionario;
        }
    }
}
