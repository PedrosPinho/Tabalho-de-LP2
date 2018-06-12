using System;
using System.Collections.Generic;
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
    }
}
