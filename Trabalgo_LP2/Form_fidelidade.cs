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
    public partial class Form_fidelidade : Form
    {
        public Form_fidelidade()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_fidelidade_Load(object sender, EventArgs e)
        {
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_fidelidade.DataSource = clientedao.Fidelidade();
        }
    }
}
