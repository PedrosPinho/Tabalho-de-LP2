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
    public partial class Form_cliente : Form
    {
        public Form_cliente()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_cadastroCliente form = new Form_cadastroCliente(1);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.ListAll();
            this.Visible = true;

        }


        private void btn_alterar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_confirma entrada = new Form_confirma("CPF do Cliente", "Digite o CPF do Cliente:");
            entrada.ShowDialog();

            if (entrada.Valor != null)
            {
                // abrindo a janela de alunos no modo 3 (alterar)
                Form_cadastroCliente janelaCliente = new Form_cadastroCliente(3);
                janelaCliente.CpfCliente = entrada.Valor;
                if (janelaCliente.exibirCliente())
                {
                    janelaCliente.StartPosition = FormStartPosition.CenterParent;
                    janelaCliente.ShowDialog();
                }
            }
            this.Visible = true;

            /*Form_cadastroCliente form = new Form_cadastroCliente(2);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.ListAll();*/
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_cliente_Load(object sender, EventArgs e)
        {
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.ListAll();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            //Quando pressionado remove um cliente usando o cpf
            ClienteDAO clienteDAO = new ClienteDAO();
            if (txt_cpf_rmv.Text.Equals(""))
            {
                MessageBox.Show("Certifique-se de que a aba remover está preenchida", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(clienteDAO.ValidaDelecao(txt_cpf_rmv.Text) == false)
            {
                MessageBox.Show("Cliente inexistente!", "Aviso!", MessageBoxButtons.OK);
                txt_cpf_rmv.Text = null;
            }
            else
            {
                
                clienteDAO.Delete(txt_cpf_rmv.Text);
                MessageBox.Show("Cliente removido com sucesso!", "Cliente removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cpf_rmv.Text = null;
            }
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.ListAll();
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            ClienteDAO clientedao = new ClienteDAO();
            dataGridView_cliente.DataSource = clientedao.FindByName(txt_filtrar.Text);
        }

        private void dataGridView_cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            var cell = dataGridView_cliente.Rows[e.RowIndex].Cells[1].Value;
            txt_cpf_rmv.Text = cell.ToString();
            }
            catch (System.Exception){
            }
        }
    }
}
