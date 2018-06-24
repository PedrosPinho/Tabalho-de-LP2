using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalgo_LP2
{
    public partial class Form_mesa : Form
    {
        public Form_mesa()
        {
            InitializeComponent();
        }

        private void dataGridView_mesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //RETORNA O NUMERO D MESA PARA O FORM CONTAS
            var cell = dataGridView_mesas.Rows[e.RowIndex].Cells[0].Value;

            //SE NUM PESSOAS FOR > 0 SAIR DAQ
            this.Visible = false;
            if (Convert.ToInt32(dataGridView_mesas.Rows[e.RowIndex].Cells[1].Value) == 0)
            {
                Form_pessoas_mesa form = new Form_pessoas_mesa(Convert.ToInt32(cell));
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
            else
            {
                Form_contas form = new Form_contas(Convert.ToInt32(cell));
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
            MesaDAO mesadao = new MesaDAO();
            dataGridView_mesas.DataSource = mesadao.ListAll();
            this.Visible = true;
        }

        private void Form_mesa_Load(object sender, EventArgs e)
        {
            MesaDAO mesadao = new MesaDAO();
            dataGridView_mesas.DataSource = mesadao.ListAll();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
