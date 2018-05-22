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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_cadastroCliente_Load(object sender, EventArgs e)
        {
            if (!File.Exists(nomebanco))
            {
                SQLiteConnection.CreateFile(nomebanco);
                SQLiteConnection conn = new SQLiteConnection(conexao);
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS Cliente ([Cpf] INTEGER PRIMARY KEY NOT NULL UNIQUE,");
                sql.AppendLine("[Nome] TEXT, [Telefone] INTEGER)");

                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
                }
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            //CRIAR CLIENTE OK?

        }
    }
}
