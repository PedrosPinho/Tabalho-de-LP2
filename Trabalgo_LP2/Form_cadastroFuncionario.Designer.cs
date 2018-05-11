namespace Trabalgo_LP2
{
    partial class Form_cadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_cadastro = new System.Windows.Forms.Panel();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_funcao = new System.Windows.Forms.TextBox();
            this.maskedTextBox_data = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_registro = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_Cadastro = new System.Windows.Forms.Label();
            this.pictureBox_cadastro = new System.Windows.Forms.PictureBox();
            this.panel_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cadastro
            // 
            this.panel_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel_cadastro.Controls.Add(this.lbl_funcao);
            this.panel_cadastro.Controls.Add(this.lbl_data);
            this.panel_cadastro.Controls.Add(this.lbl_telefone);
            this.panel_cadastro.Controls.Add(this.txt_funcao);
            this.panel_cadastro.Controls.Add(this.maskedTextBox_data);
            this.panel_cadastro.Controls.Add(this.maskedTextBox_telefone);
            this.panel_cadastro.Controls.Add(this.maskedTextBox_cpf);
            this.panel_cadastro.Controls.Add(this.btn_cancelar);
            this.panel_cadastro.Controls.Add(this.btn_confirmar);
            this.panel_cadastro.Controls.Add(this.txt_registro);
            this.panel_cadastro.Controls.Add(this.txt_nome);
            this.panel_cadastro.Controls.Add(this.lbl_registro);
            this.panel_cadastro.Controls.Add(this.lbl_cpf);
            this.panel_cadastro.Controls.Add(this.lbl_nome);
            this.panel_cadastro.Controls.Add(this.lbl_Cadastro);
            this.panel_cadastro.Controls.Add(this.pictureBox_cadastro);
            this.panel_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cadastro.Location = new System.Drawing.Point(0, 0);
            this.panel_cadastro.Name = "panel_cadastro";
            this.panel_cadastro.Size = new System.Drawing.Size(554, 332);
            this.panel_cadastro.TabIndex = 0;
            this.panel_cadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cadastro_Paint);
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcao.Location = new System.Drawing.Point(12, 278);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(64, 16);
            this.lbl_funcao.TabIndex = 16;
            this.lbl_funcao.Text = "Função:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(12, 232);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(107, 16);
            this.lbl_data.TabIndex = 15;
            this.lbl_data.Text = "Data de inicio:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(12, 186);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(73, 16);
            this.lbl_telefone.TabIndex = 14;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // txt_funcao
            // 
            this.txt_funcao.Location = new System.Drawing.Point(12, 299);
            this.txt_funcao.Name = "txt_funcao";
            this.txt_funcao.Size = new System.Drawing.Size(185, 20);
            this.txt_funcao.TabIndex = 13;
            // 
            // maskedTextBox_data
            // 
            this.maskedTextBox_data.Location = new System.Drawing.Point(12, 253);
            this.maskedTextBox_data.Mask = "00/00/0000";
            this.maskedTextBox_data.Name = "maskedTextBox_data";
            this.maskedTextBox_data.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBox_data.TabIndex = 12;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(12, 207);
            this.maskedTextBox_telefone.Mask = "0000-0000";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBox_telefone.TabIndex = 11;
            // 
            // maskedTextBox_cpf
            // 
            this.maskedTextBox_cpf.Location = new System.Drawing.Point(12, 115);
            this.maskedTextBox_cpf.Mask = "000.000.000-00";
            this.maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            this.maskedTextBox_cpf.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBox_cpf.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(312, 285);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 34);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(450, 285);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(89, 34);
            this.btn_confirmar.TabIndex = 8;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_registro
            // 
            this.txt_registro.Location = new System.Drawing.Point(12, 161);
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(185, 20);
            this.txt_registro.TabIndex = 7;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 69);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(294, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(12, 140);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(72, 16);
            this.lbl_registro.TabIndex = 4;
            this.lbl_registro.Text = "Registro:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(12, 94);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(40, 16);
            this.lbl_cpf.TabIndex = 3;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 48);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(52, 16);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_Cadastro
            // 
            this.lbl_Cadastro.AutoSize = true;
            this.lbl_Cadastro.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadastro.Location = new System.Drawing.Point(145, 9);
            this.lbl_Cadastro.Name = "lbl_Cadastro";
            this.lbl_Cadastro.Size = new System.Drawing.Size(256, 26);
            this.lbl_Cadastro.TabIndex = 1;
            this.lbl_Cadastro.Text = "Cadastro de funcionário";
            this.lbl_Cadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_cadastro
            // 
            this.pictureBox_cadastro.Image = global::Trabalgo_LP2.Properties.Resources.logo;
            this.pictureBox_cadastro.Location = new System.Drawing.Point(312, 69);
            this.pictureBox_cadastro.Name = "pictureBox_cadastro";
            this.pictureBox_cadastro.Size = new System.Drawing.Size(227, 179);
            this.pictureBox_cadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cadastro.TabIndex = 0;
            this.pictureBox_cadastro.TabStop = false;
            // 
            // Form_cadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 332);
            this.Controls.Add(this.panel_cadastro);
            this.Name = "Form_cadastroFuncionario";
            this.Text = "Form_cadastro";
            this.panel_cadastro.ResumeLayout(false);
            this.panel_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cadastro;
        private System.Windows.Forms.PictureBox pictureBox_cadastro;
        private System.Windows.Forms.Label lbl_Cadastro;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txt_registro;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txt_funcao;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_data;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpf;
    }
}