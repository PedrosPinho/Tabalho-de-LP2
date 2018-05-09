using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class Mesa
    {
        int numero_mesa, numero_pessoas;

        public Mesa(int numero_mesa, int numero_pessoas)
        {
            this.numero_mesa = numero_mesa;
            this.numero_pessoas = numero_pessoas;
        }

        public int Numero_mesa
        {
            get
            {
                return numero_mesa;
            }

            set
            {
                numero_mesa = value;
            }
        }

        public int Numero_pessoas
        {
            get
            {
                return numero_pessoas;
            }

            set
            {
                numero_pessoas = value;
            }
        }
    }
}
