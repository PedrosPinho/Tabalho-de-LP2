using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Trabalgo_LP2
{
    public partial class Form_cliente : Form
    {
        public Form_cliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Form_cadastroCliente form = new Form_cadastroCliente(1);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.ListAll();
        }


        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Form_cadastroCliente form = new Form_cadastroCliente(2);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.ListAll();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_cliente_Load(object sender, EventArgs e)
        {
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.ListAll();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.FindByName(txt_filtrar.Text);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            //Quando pressionado remove um cliente usando o cpf
            if (txt_filtrar.Text.Equals(""))
            {
                MessageBox.Show("Certifique-se de que a aba 'Filtrar' está preenchida", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                clienteDAO.Delete(Convert.ToInt32(txt_filtrar.Text));
                MessageBox.Show("Cliente removido com sucesso!", "Cliente removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.ListAll();
        }
    }
}
