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
    public partial class Form_confirmaFuncionario : Form
    {
        private string valor = null;

        public string Valor { get { return valor; } set { valor = value; } }

        public Form_confirmaFuncionario(string titulo, string mensagem)
        {
            InitializeComponent();

            this.Text = titulo;
            lbl_confirmaRegistro.Text = mensagem;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Valor = null;
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_registro.Text.Equals(""))
                MessageBox.Show("Obrigatório informar um valor!", "ERRO!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Valor = txt_registro.Text;
                this.Close();
            }
        }
    }
}
