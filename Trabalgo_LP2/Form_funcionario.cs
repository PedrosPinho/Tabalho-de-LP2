using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Trabalgo_LP2
{
    public partial class Form_funcionario : Form
    {
        public Form_funcionario()
        {
            InitializeComponent();

        }

        private void dataGridView_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Form_cadastroFuncionario form = new Form_cadastroFuncionario(1);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            dataGridView_funcionario.DataSource = funcionariodao.ListAll();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Form_confirma entrada = new Form_confirma("Registro do funcionário", "Digite o registro:");
            entrada.ShowDialog();

            if (entrada.Valor != null)
            {
                // Dando erro de excessão aqui
                Form_cadastroFuncionario janelaFuncionario = new Form_cadastroFuncionario(3);
                janelaFuncionario.RegistroFunc = int.Parse(entrada.Valor);
                if (janelaFuncionario.exibirFuncionario())
                {
                    janelaFuncionario.StartPosition = FormStartPosition.CenterParent;
                    janelaFuncionario.ShowDialog();
                }
            }
            
            /*Form_cadastroFuncionario form = new Form_cadastroFuncionario(2);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            dataGridView_funcionario.DataSource = funcionariodao.ListAll();*/
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_funcionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            dataGridView_funcionario.DataSource = funcionariodao.ListAll();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            dataGridView_funcionario.DataSource = funcionarioDAO.FindByName(txt_filtrar.Text);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            //Quando pressionado remove um funcionario usando o registro
            if (txt_reg_rmv.Text.Equals(""))
            {
                MessageBox.Show("Certifique-se de que a aba remover está preenchida", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                funcionarioDAO.Delete(txt_reg_rmv.Text);
                MessageBox.Show("Funcionario removido com sucesso!", "Funcionario removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_reg_rmv.Text = null;
            }
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            dataGridView_funcionario.DataSource = funcionariodao.ListAll();
        }
    }
}
