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
    public partial class Form_relatorio_func : Form
    {
        public Form_relatorio_func()
        {
            InitializeComponent();
        }

        private void Form_relatorio_func_Load(object sender, EventArgs e)
        {
            List<Funcionario> lista = new FuncionarioDAO().ListAll();
            Report_funcionario report = new Report_funcionario();
            report.SetDataSource(lista);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
