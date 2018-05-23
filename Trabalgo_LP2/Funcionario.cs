using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class Funcionario
    {
        private String nome, funcao;
        private String cpf, registro, telefone;
        private String data_inicio;

        public Funcionario()
        {
        }

        public Funcionario(string nome, string funcao, string cpf, string registro, string telefone, string data_inicio)
        {
            this.nome = nome;
            this.funcao = funcao;
            this.cpf = cpf;
            this.registro = registro;
            this.telefone = telefone;
            this.data_inicio = data_inicio;
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

        public string Funcao
        {
            get
            {
                return funcao;
            }

            set
            {
                funcao = value;
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

        public string Registro
        {
            get
            {
                return registro;
            }

            set
            {
                registro = value;
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

        public string Data_inicio
        {
            get
            {
                return data_inicio;
            }

            set
            {
                data_inicio = value;
            }
        }
    }
}
