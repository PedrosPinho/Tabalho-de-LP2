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
        private string cpf, telefone;
        private int frequencia;

        public Cliente()
        { }
        public Cliente(string nome, string cpf, string telefone, int frequencia)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.frequencia = frequencia;
        }
        public Cliente(string nome, string cpf, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
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

        public string Cpf
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

        public string Telefone
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
