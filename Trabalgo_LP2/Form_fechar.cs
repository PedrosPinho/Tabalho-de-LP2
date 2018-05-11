using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalgo_LP2
{
    public partial class Form_fechar : Form
    {
        public Form_fechar()
        {
            InitializeComponent();
        }

        private void Form_fechar_Load(object sender, EventArgs e)
        {

        }

        private void lbl_cpf_fechar_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_nao_quer_cadastrar_Click(object sender, EventArgs e)
        {
            float total, por_pessoa;
            int num_pessoas;

            total = float.Parse(txt_total.Text);
            num_pessoas = int.Parse(txt_num_pessoas.Text);
            por_pessoa = float.Parse(txt_val_pessoa.Text);

            txt_total.Text = (total - por_pessoa).ToString();
            txt_num_pessoas.Text = (num_pessoas - 1).ToString();
            if (int.Parse(txt_num_pessoas.Text) == 0)
            {
                MessageBox.Show("Conta foi paga com sucesso!", "Aviso", MessageBoxButtons.OK);
                Close();
            }

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float total;
            int num_pessoas;

            total = float.Parse(txt_total.Text);
            num_pessoas = int.Parse(txt_num_pessoas.Text);

            txt_val_pessoa.Text = (total / num_pessoas).ToString();
        }
    }
}
