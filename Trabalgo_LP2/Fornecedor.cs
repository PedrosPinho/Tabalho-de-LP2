using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class Fornecedor
    {
        long cnpj, cep, telefone;
        string nome, produto;
        float preco;

        public Fornecedor(long cnpj, long cep, long telefone, string nome, string produto, float preco)
        {
            this.Cnpj = cnpj;
            this.Cep = cep;
            this.Telefone = telefone;
            this.Nome = nome;
            this.Produto = produto;
            this.Preco = preco;
        }

        public long Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public long Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
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

        public float Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public string Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
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
    }
}
