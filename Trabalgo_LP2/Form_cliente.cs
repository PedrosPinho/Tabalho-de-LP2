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
            Form_cadastroCliente form = new Form_cadastroCliente();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Form_cadastroCliente form = new Form_cadastroCliente();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
