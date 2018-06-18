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

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbl_Mdesconto.Visible = !this.lbl_Mdesconto.Visible;
            this.lbl_Mfreq.Visible = !this.lbl_Mfreq.Visible;
            this.txt_Mdesconto.Visible = !this.txt_Mdesconto.Visible;
            this.txt_Mfreq.Visible = !this.txt_Mfreq.Visible;
            this.btn_criar.Visible = !this.btn_criar.Visible;
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            //TA MEIO MERDA MAS eh o que tem pra hj, jaja arrumo ¯\_(ツ)_/¯
            try
            { 
                int desc = Convert.ToInt32(txt_Mdesconto.Text);
                int freq = Convert.ToInt32(txt_Mfreq.Text);
                DescontoDAO desconto = new DescontoDAO();
                desconto.Create(desc, freq);
                this.label3.Text = txt_Mdesconto.Text + '%';
                this.label4.Text = txt_Mfreq.Text;
            }
            catch(System.Exception)
            {
                MessageBox.Show("Certifique-se que todos os campos estao preenchidos corretamente", "Erro", MessageBoxButtons.OK);
            }
            finally
            {
                this.lbl_Mdesconto.Visible = !this.lbl_Mdesconto.Visible;
                this.lbl_Mfreq.Visible = !this.lbl_Mfreq.Visible;
                this.txt_Mdesconto.Visible = !this.txt_Mdesconto.Visible;
                this.txt_Mfreq.Visible = !this.txt_Mfreq.Visible;
                this.btn_criar.Visible = !this.btn_criar.Visible;
            }


}
    }
}
