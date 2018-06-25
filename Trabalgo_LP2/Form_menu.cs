using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalgo_LP2
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_login form = new Form_login(); 
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            
        }

        private void btn_funcionario_Click(object sender, EventArgs e)
        {
            Form_funcionario form = new Form_funcionario();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Form_cliente form = new Form_cliente();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_mesa_Click(object sender, EventArgs e)
        {
            Form_mesa form = new Form_mesa();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_cardapio_Click(object sender, EventArgs e)
        {
            Form_cardapio form = new Form_cardapio();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btn_fidelidade_Click(object sender, EventArgs e)
        {
            Form_fidelidade form = new Form_fidelidade();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void Form_menu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            int dia = DateTime.Now.Day;
            int ano = DateTime.Now.Year;

            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));

            lbl_Relogio.Text = DateTime.Now.ToLongTimeString();
            lbl_teste.Text = diasemana + ", " + dia + " de " + mes + " de " + ano;

        }
        
    }
}
