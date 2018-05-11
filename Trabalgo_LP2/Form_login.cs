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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_menu form = new Form_menu();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            Close();
        }

        private void linklbl_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_cadastroFuncionario form = new Form_cadastroFuncionario();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
