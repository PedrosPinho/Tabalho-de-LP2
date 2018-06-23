using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class Desconto
    {
        int porcentagem, frequencia;

        public int Frequencia
        {
            get
            {
                return frequencia;
            }

            set
            {
                frequencia = value;
            }
        }

        public int Porcentagem
        {
            get
            {
                return porcentagem;
            }

            set
            {
                porcentagem = value;
            }
        }
    }
}
