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
    public partial class Form_relatorio : Form
    {
        public Form_relatorio()
        {
            InitializeComponent();
        }

        private void Form_relatorio_Load(object sender, EventArgs e)
        {
            List<Cliente> lista = new ClienteDAO().ListAll();
            Report_cliente report = new Report_cliente();
            report.SetDataSource(lista);
            cvcliente.ReportSource = report;
        }
    }
}
