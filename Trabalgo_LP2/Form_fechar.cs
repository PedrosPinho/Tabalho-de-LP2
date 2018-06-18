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
        public Form_fechar(int mesa)
        {
            InitializeComponent();
            label2.Text = mesa.ToString();

        }

        private void Form_fechar_Load(object sender, EventArgs e)
        {
            ConsumidosDAO c = new ConsumidosDAO();
            MesaDAO m = new MesaDAO();
            txt_total.Text = c.GetConsumidos(Convert.ToInt32(label2.Text)).ToString();
            //int num_pessoas = m.NumPessoas(Convert.ToInt32(label2.Text));
            //double precopessoa = (Convert.ToDouble(txt_total.Text)) / num_pessoas;
            //txt_val_pessoa.Text = precopessoa.ToString();
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
            try
            {
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
            catch (System.Exception)
            {
                MessageBox.Show("Certifique que os campos 'Total' e 'Dividir conta' estão preenchidos", "Aviso!", MessageBoxButtons.OK);
            }

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float total;
            int num_pessoas;
            try
            {
                total = float.Parse(txt_total.Text);
                num_pessoas = int.Parse(txt_num_pessoas.Text);

                txt_val_pessoa.Text = (total / num_pessoas).ToString();
                btn_calcular.Hide();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Certifique que os campos 'Total' e 'Dividir conta' estão preenchidos", "Aviso!", MessageBoxButtons.OK);
            }
        }
    }
}
