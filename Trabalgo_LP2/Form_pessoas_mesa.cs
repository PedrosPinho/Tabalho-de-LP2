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
    public partial class Form_pessoas_mesa : Form
    {
        public Form_pessoas_mesa(int cell)
        {
            InitializeComponent();
            this.txt_num_mesa.Text = cell.ToString();

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa(int.Parse(this.txt_num_mesa.Text), comboBox_num.SelectedIndex + 1);
            MesaDAO mesaDAO = new MesaDAO();
            mesaDAO.Update(mesa);
            this.Close();
        }
    }
}
