using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalgo_LP2
{
    class Cardapio
    {
        int id;
        string nome, descricao;
        float preco;

        public Cardapio(int id, string nome, string descricao, float preco)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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
    }
}
