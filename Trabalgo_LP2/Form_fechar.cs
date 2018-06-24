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
            txt_total.ReadOnly = true;
            txt_val_pessoa.ReadOnly = true;

        }

        private void Form_fechar_Load(object sender, EventArgs e)
        {
            ConsumidosDAO c = new ConsumidosDAO();
            MesaDAO m = new MesaDAO();
            txt_total.Text = /*"R$" +*/ c.GetConsumidos(Convert.ToInt32(label2.Text)).ToString();
            
            txt_num_pessoas.Text = m.NumPessoas(Convert.ToInt32(label2.Text)).ToString();
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
            double total, por_pessoa;
            int num_pessoas;
            MesaDAO mesa = new MesaDAO();
            ConsumidosDAO consumidos = new ConsumidosDAO();
            try
            {
                total = double.Parse(txt_total.Text);
                num_pessoas = int.Parse(txt_num_pessoas.Text);
                por_pessoa = double.Parse(txt_val_pessoa.Text);

                txt_total.Text = (total - por_pessoa).ToString();
                txt_num_pessoas.Text = (num_pessoas - 1).ToString();
                if (int.Parse(txt_num_pessoas.Text) == 0 && int.Parse(txt_total.Text) == 0)
                {
                    txt_val_pessoa.Text = "";
                    MessageBox.Show("Conta foi paga com sucesso!", "Aviso", MessageBoxButtons.OK);
                    consumidos.Clear(Convert.ToInt32(label2.Text));
                    mesa.UpdateF(Convert.ToInt32(label2.Text));
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
            double total;
            int num_pessoas;
            try
            {
                total = double.Parse(txt_total.Text);
                num_pessoas = int.Parse(txt_num_pessoas.Text);

                txt_val_pessoa.Text = (total / num_pessoas).ToString();
                btn_calcular.Hide();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Certifique que os campos 'Total' e 'Dividir conta' estão preenchidos", "Aviso!", MessageBoxButtons.OK);
            }
        }

        private void btn_nao_cadastrado_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_cadastroCliente form = new Form_cadastroCliente(1);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            this.Visible = true;
        }

        private void btn_cadastrado_Click(object sender, EventArgs e)
        {

            try
            {
                DescontoDAO d = new DescontoDAO();
                ClienteDAO c = new ClienteDAO();
                Cliente cliente = c.Read(txt_cpf_fechar.Text);
                double desconto = d.GetDesconto(cliente);

                MessageBox.Show("Desconto de " + desconto + "% concedido", "Aviso", MessageBoxButtons.OK);
                txt_cpf_fechar.Text = null;
                if (desconto > 0)
                {
                    double total = Convert.ToDouble(txt_total.Text);
                    total -= total * (desconto / 100);
                    txt_total.Text = total.ToString();
                    c.UpdateF(cliente, true);
                }
                else c.UpdateF(cliente, false);


            }
            catch(System.Exception)
            {
                MessageBox.Show("Certifique-se que CPF esta corretamente preenchido", "Errou", MessageBoxButtons.OK);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
