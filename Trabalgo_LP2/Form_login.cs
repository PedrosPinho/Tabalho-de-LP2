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
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            if (txt_registro.Text == "")
            {
                MessageBox.Show("Certifique que o campo regitro esta preenchido!", "Aviso!", MessageBoxButtons.OK);
            }
            else if (funcionariodao.ValidaLogin(txt_registro.Text) == false)
            {
                MessageBox.Show("Funcionario inexistente!", "Aviso!", MessageBoxButtons.OK);
                txt_registro.Text = null;
            }
            else
            {
                this.Hide();
                Form_menu form = new Form_menu();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                Close();
            }
        }

        private void linklbl_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_cadastroFuncionario form = new Form_cadastroFuncionario(1);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
