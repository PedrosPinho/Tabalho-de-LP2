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

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            int mesa = Convert.ToInt32(label2.Text);

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
                //DA PRA 'ADICIONAR' ID INEXISTENTE, ELE NAO DA AVISO OK?
            }
            catch (System.Exception)
            {
                MessageBox.Show("Erro", "Errroou", MessageBoxButtons.OK);
            }
            finally
            {
                txt_id_item.Text = null;
                txt_qtd.Text = null;
            }
            
            

        }
    }
}
