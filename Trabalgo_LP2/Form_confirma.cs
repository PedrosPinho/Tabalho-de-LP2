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
    public partial class Form_confirma : Form
    {
        private string valor = null;

        public string Valor { get { return valor; } set { valor = value; } }

        public Form_confirma(string titulo, string mensagem)
        {
            InitializeComponent();

            this.Text = titulo;
            lbl_confirmacao.Text = mensagem;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Valor = null;
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_confirmacao.Text.Equals(""))
                MessageBox.Show("Obrigatório informar um valor!", "ERRO!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Valor = txt_confirmacao.Text;
                this.Close();
            }
        }
    }
}
