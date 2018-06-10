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
        public Form_contas(int num_mesa, int num_pessoas)
        {
            InitializeComponent();
        }

        private void Form_contas_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Form_fechar form = new Form_fechar();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
