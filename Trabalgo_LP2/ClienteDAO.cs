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
            Database VannerDB = Database.GetInstance();

            string qry =
            string.Format("INSERT INTO Cliente (CPF, NOME, TELEFONE) VALUES ('{0}','{1}', '{2}')",
                c.Cpf, c.Nome, c.Telefone);
            VannerDB.ExecuteSQL(qry);
        }
    }
}
