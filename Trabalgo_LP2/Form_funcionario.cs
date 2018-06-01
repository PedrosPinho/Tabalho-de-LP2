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
    public partial class Form_funcionario : Form
    {
        public Form_funcionario()
        {
            InitializeComponent();
        }

        private void dataGridView_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Form_cadastroFuncionario form = new Form_cadastroFuncionario();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Form_cadastroFuncionario form = new Form_cadastroFuncionario();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_funcionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            dataGridView_funcionario.DataSource = funcionariodao.ListAll();
        }

    }
}
