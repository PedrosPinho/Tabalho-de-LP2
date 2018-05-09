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
        private long cpf, registro, telefone, data_inicio;

        public Funcionario(string nome, string funcao, long cpf, long registro, long telefone, long data_inicio)
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

        public long Registro
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

        public long Data_inicio
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
