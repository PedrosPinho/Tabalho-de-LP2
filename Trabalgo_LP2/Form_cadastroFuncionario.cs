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
    public partial class Form_cadastroFuncionario : Form
    {
        //private static string conexao = "Data Source = VannerBD.db";
        //private static string nomebanco = "VannerBD.db";

        public Form_cadastroFuncionario()
        {
            InitializeComponent();
        }

        private Funcionario GetDTO()
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Registro = txt_registroFunc.Text;
            funcionario.Nome = txt_nomeFunc.Text;
            funcionario.Cpf = txt_cpfFunc.Text;
            funcionario.Funcao = txt_funcaoFunc.Text;
            funcionario.Data_inicio = Convert.ToDateTime(txt_dataFunc.Text);
            funcionario.Telefone = txt_telefoneFunc.Text;
            

            return funcionario;
        }

        private void SetDTO(Funcionario f)
        {
            txt_registroFunc.Text = f.Registro;
            txt_nomeFunc.Text = f.Nome;
            txt_cpfFunc.Text = f.Cpf;
            txt_funcaoFunc.Text = f.Funcao;
            txt_dataFunc.Text = f.Data_inicio.ToString("dd/MM/yyyy");
            txt_telefoneFunc.Text = f.Telefone;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_cadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            //CADASTRAR FUNCIONARIO FAZER OK?
            if (txt_registroFunc.Text.Equals("") || txt_cpfFunc.Text.Equals("") ||
                txt_telefoneFunc.Text.Equals("") || txt_funcaoFunc.Text.Equals("") ||
                txt_nomeFunc.Text.Equals("") || txt_dataFunc.Text.Equals("")) 
                MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                Funcionario funcionario = GetDTO();
                funcionarioDAO.Create(funcionario);
                this.Close();
            }
        }

        private void pictureBox_cadastro_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
