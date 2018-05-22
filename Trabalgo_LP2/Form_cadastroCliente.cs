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
        private static string conexao = "Data Source = VannerBD.db";
        private static string nomebanco = "VannerBD.db";

        public Form_cadastroCliente()
        {
            InitializeComponent();
        }

        private Cliente GetDTO()
        {
            Cliente cliente = new Cliente();

            cliente.Cpf = maskedTextBox_cpf.Text;
            cliente.Nome = txt_nome.Text;
            cliente.Telefone = maskedTextBox_telefone.Text;
                
            return cliente;
        }
        
        private void SetDTO(Cliente c)
        {
            txt_nome.Text = c.Nome;
            maskedTextBox_telefone.Text = c.Telefone.ToString();
            maskedTextBox_cpf.Text = c.Cpf.ToString();
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
            if (txt_nome.Text.Equals("") || maskedTextBox_cpf.Text.Equals("") ||
                maskedTextBox_telefone.Text.Equals(""))
                MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                Cliente cliente = GetDTO();
                clienteDAO.Create(cliente);
                this.Close();
            }
            
        }
    }
}
