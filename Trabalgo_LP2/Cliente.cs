using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class Cliente
    {
        private string nome;
        private long cpf, telefone;
        private int frequencia;

        public Cliente(string nome, long cpf, long telefone, int frequencia)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.frequencia = frequencia;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public long Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

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
    }
}
