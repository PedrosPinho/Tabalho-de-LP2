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
using System.Text.RegularExpressions;

namespace Trabalgo_LP2
{
    public partial class Form_cadastroFuncionario : Form
    {
        //private static string conexao = "Data Source = VannerBD.db";
        //private static string nomebanco = "VannerBD.db";

        private int registroFunc;

        public int RegistroFunc { get { return registroFunc; } set { registroFunc = value; } }

        public Form_cadastroFuncionario(int modo)
        {
            InitializeComponent();
            switch (modo)//FORM INICIA DE DUAS FORMAS 1 PARA CRIAR CLIENTE 2 PARA ATUALIZAR
            {
                case 1://ADICIONAR
                    btn_atualizar.Hide();
                    txt_cpfFunc.Enabled = true;
                    txt_registroFunc.Enabled = true;
                    break;
                case 2://ATUALIZAR
                    btn_confirmar.Hide();
                    txt_registroFunc.Hide();
                    txt_cpfFunc.Enabled = false;
                    txt_registroFunc.Enabled = false;
                    break;
            }
        }

        public bool exibirFuncionario()
        {
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            Funcionario a = funcionariodao.Read(registroFunc);

            if (a == null)
            {
                MessageBox.Show("Este funcionário não existe!", "Ops",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return false;
            }
            else
            {
                SetDTO(a);
                return true;
            }
        }

        private Funcionario GetDTO()
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Registro = txt_registroFunc.Text;
            funcionario.Nome = txt_nomeFunc.Text;
            funcionario.Cpf = txt_cpfFunc.Text;
            funcionario.Funcao = txt_funcaoFunc.Text;
            funcionario.Data_inicio = txt_dataFunc.Text;
            funcionario.Telefone = txt_telefoneFunc.Text;
            

            return funcionario;
        }

        private void SetDTO(Funcionario f)
        {
            txt_registroFunc.Text = f.Registro;
            txt_nomeFunc.Text = f.Nome;
            txt_cpfFunc.Text = f.Cpf;
            txt_funcaoFunc.Text = f.Funcao;
            txt_dataFunc.Text = f.Data_inicio;
            txt_telefoneFunc.Text = f.Telefone;

        }
    

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_registroFunc.Text.Equals("") || txt_cpfFunc.Text.Equals("") ||
                    txt_telefoneFunc.Text.Equals("") || txt_funcaoFunc.Text.Equals("") ||
                    txt_nomeFunc.Text.Equals("") || txt_dataFunc.Text.Equals(""))
                    MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!Validar.ValCPF(txt_cpfFunc.Text))
                {
                    MessageBox.Show("CPF Inválido! Verifique novamente!", "ERRO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.Match(txt_telefoneFunc.Text, @"^\([1-9]\d\)\s\d{8,9}$").Success)
                {
                    MessageBox.Show("Erro: O telefone deve ter o formato (XX)XXXXXXXX!" +
                                    " O DDD não pode começar com zero e o número deve ter oito ou nove dígitos!\n", "ERRO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.Match(txt_nomeFunc.Text, @"^([\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+((\s[\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+)?$").Success)
                {
                    MessageBox.Show("Erro: A primeira letra do nome deve ser maiúscula! Somente letras são permitidas!", "ERRO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.Match(txt_dataFunc.Text, @"^\d{4}$").Success || Convert.ToInt32(txt_dataFunc.Text) > DateTime.Now.Year || Convert.ToInt32(txt_dataFunc.Text) < 2010)
                {
                    MessageBox.Show("O ano deve possuir exatamente 4 dígitos, e nao pode ser maior que o ano atual", "ERRO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                    Funcionario funcionario = GetDTO();
                    funcionarioDAO.Create(funcionario);
                    MessageBox.Show("Funcionario cadastrado", "Aviso", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Já existe o CPF/Registro digitado em nosso Banco de Dados", "ERRO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_registroFunc.Text.Equals("") || txt_cpfFunc.Text.Equals("") ||
                txt_telefoneFunc.Text.Equals("") || txt_funcaoFunc.Text.Equals("") ||
                txt_nomeFunc.Text.Equals("") || txt_dataFunc.Text.Equals(""))
                MessageBox.Show("Todos os campos precisam estar preenchidos!", "Ops",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!Regex.Match(txt_telefoneFunc.Text, @"^\([1-9]\d\)\s\d{8,9}$").Success)
            {
                MessageBox.Show("Erro: O telefone deve ter o formato (XX)XXXXXXXX!" +
                                " O DDD não pode começar com zero e o número deve ter oito ou nove dígitos!\n", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(txt_nomeFunc.Text, @"^([\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+((\s[\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+)?$").Success)
            {
                MessageBox.Show("Erro: A primeira letra do nome deve ser maiúscula! Somente letras são permitidas!", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(txt_dataFunc.Text, @"^\d{4}$").Success)
            {
                MessageBox.Show("O ano deve possuir exatamente 4 dígitos!", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                Funcionario funcionario = GetDTO();
                funcionarioDAO.Update(funcionario);
                MessageBox.Show("Funcionario atualizado", "Aviso", MessageBoxButtons.OK);
                this.Close();

                Form_funcionario form = new Form_funcionario();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                
            }
        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {

        }

        private void Form_cadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
