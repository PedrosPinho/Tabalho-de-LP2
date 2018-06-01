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
        public Form_cadastroCliente()
        {
            InitializeComponent();
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
    }
}
