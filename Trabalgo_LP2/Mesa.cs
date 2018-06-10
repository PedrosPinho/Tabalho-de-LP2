using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class Mesa
    {
        int num_mesa, num_pessoas;

        public Mesa()
        { }
        public Mesa(int numero_mesa, int numero_pessoas)
        {
            this.num_mesa = numero_mesa;
            this.num_pessoas = numero_pessoas;
        }

        public int Num_mesa
        {
            get
            {
                return num_mesa;
            }

            set
            {
                num_mesa = value;
            }
        }

        public int Num_pessoas
        {
            get
            {
                return num_pessoas;
            }

            set
            {
                num_pessoas = value;
            }
        }
    }
}
