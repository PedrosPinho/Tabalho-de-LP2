using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class FuncionarioDAO
    {
        public void Create(Funcionario f)
        {
            Database VannerDB = Database.GetInstance();

            string qry =
            string.Format("INSERT INTO Funcionario (REGISTRO, NOME, CPF, FUNCAO, DATAINICIO, TELEFONE) VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}')",
                f.Registro, f.Nome, f.Cpf, f.Funcao, f.Data_inicio, f.Telefone);
            VannerDB.ExecuteSQL(qry);
        }
    }
}
