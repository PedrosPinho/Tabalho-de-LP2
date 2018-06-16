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
using System.IO;

namespace Trabalgo_LP2
{
    public partial class Form_cadastroCliente : Form
    {
        private int cpfCliente;

        public int CpfCliente { get { return cpfCliente; } set { cpfCliente = value; } }

        public Form_cadastroCliente(int modo)
        {
            InitializeComponent();

            switch (modo)//FORM INICIA DE DUAS FORMAS 1 PARA CRIAR CLIENTE 2 PARA ATUALIZAR
            {
                case 1://ADICIONAR
                    btn_atualizar.Hide();
                    break;
                case 2://ATUALIZAR
                    btn_confirmar.Hide();
                    break;
            } 
        }

        public bool exibirCliente()
        {
            ClienteDAO clientedao = new ClienteDAO();
            Cliente a = clientedao.Read(cpfCliente);

            if (a == null)
            {
                MessageBox.Show("Este cliente não existe!", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                SetDTO(a);
                return true;
            }
        }

        private Cliente GetDTO()
        {
            Cliente cliente = new Cliente();

            cliente.Cpf = txt_cpf.Text;
            cliente.Nome = txt_nome.Text;
            cliente.Telefone = txt_telefone.Text;
                
            return cliente;
        }
        
        private void SetDTO(Cliente c)
        {
            txt_nome.Text = c.Nome;
            txt_telefone.Text = c.Telefone.ToString();
            txt_cpf.Text = c.Cpf.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_cliente form = new Form_cliente();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void Form_cadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            //ADICIONAR EXCESSÃO AQUI, VLW
            if (txt_nome.Text.Equals("") || txt_cpf.Text.Equals("") ||
                txt_telefone.Text.Equals(""))
                MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                Cliente cliente = GetDTO();
                clienteDAO.Create(cliente);

                MessageBox.Show("Cliente criado com sucesso!", "Cliente criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text.Equals("") || txt_cpf.Text.Equals("") ||
                txt_telefone.Text.Equals(""))
                MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                Cliente cliente = GetDTO();
                clienteDAO.Update(cliente);
                MessageBox.Show("Cliente alterado com sucesso!", "Cliente alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                Form_cliente form = new Form_cliente();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }
    }
}
