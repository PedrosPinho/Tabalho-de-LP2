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
    public partial class Form_contas : Form
    {
        public Form_contas(int num_mesa)
        {
            InitializeComponent();
            label2.Text = num_mesa.ToString();
        }

        private void Form_contas_Load(object sender, EventArgs e)
        {
            ConsumidosDAO c = new ConsumidosDAO();
            grid_contas.DataSource = c.listAll(Convert.ToInt32(label2.Text));

            CardapioDAO ca = new CardapioDAO();
            grid_itensTotais.DataSource = ca.listItens();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            int mesa = Convert.ToInt32(label2.Text);
            Close();

            Form_fechar form = new Form_fechar(mesa);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_id_item.Text);
                int qtd = Convert.ToInt32(txt_qtd.Text);
                int mesa = Convert.ToInt32(label2.Text);
                ConsumidosDAO consumido = new ConsumidosDAO();
                consumido.Add(id, qtd, mesa);
                ConsumidosDAO c = new ConsumidosDAO();
                grid_contas.DataSource = c.listAll(Convert.ToInt32(label2.Text));
                //DA PRA 'ADICIONAR' ID INEXISTENTE, ELE NAO DA AVISO OK?
            }
            catch (System.Exception)
            {
                MessageBox.Show("Certifique-se que os campos estao preenchidos coretamente", "Erro", MessageBoxButtons.OK);
            }
            finally
            {
                txt_id_item.Text = null;
                txt_qtd.Text = null;
            }
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
