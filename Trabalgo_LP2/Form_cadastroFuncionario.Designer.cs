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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cadastroFuncionario));
            this.pictureBox_cadastro = new System.Windows.Forms.PictureBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.txt_nomeFunc = new System.Windows.Forms.TextBox();
            this.txt_registroFunc = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.maskedTextBox_cpfFunc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefoneFunc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_dataFunc = new System.Windows.Forms.MaskedTextBox();
            this.txt_funcaoFunc = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_cadastro = new System.Windows.Forms.Panel();
            this.lbl_Cadastro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_cadastro
            // 
            this.pictureBox_cadastro.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cadastro.Image")));
            this.pictureBox_cadastro.Location = new System.Drawing.Point(277, 144);
            this.pictureBox_cadastro.Name = "pictureBox_cadastro";
            this.pictureBox_cadastro.Size = new System.Drawing.Size(227, 179);
            this.pictureBox_cadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cadastro.TabIndex = 0;
            this.pictureBox_cadastro.TabStop = false;
            this.pictureBox_cadastro.Click += new System.EventHandler(this.pictureBox_cadastro_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 70);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(52, 16);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(12, 112);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(40, 16);
            this.lbl_cpf.TabIndex = 3;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(12, 154);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(72, 16);
            this.lbl_registro.TabIndex = 4;
            this.lbl_registro.Text = "Registro:";
            // 
            // txt_nomeFunc
            // 
            this.txt_nomeFunc.Location = new System.Drawing.Point(15, 89);
            this.txt_nomeFunc.Name = "txt_nomeFunc";
            this.txt_nomeFunc.Size = new System.Drawing.Size(294, 20);
            this.txt_nomeFunc.TabIndex = 5;
            // 
            // txt_registroFunc
            // 
            this.txt_registroFunc.Location = new System.Drawing.Point(15, 173);
            this.txt_registroFunc.Name = "txt_registroFunc";
            this.txt_registroFunc.Size = new System.Drawing.Size(185, 20);
            this.txt_registroFunc.TabIndex = 7;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(150, 352);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(89, 34);
            this.btn_confirmar.TabIndex = 8;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(15, 352);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 34);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // maskedTextBox_cpfFunc
            // 
            this.maskedTextBox_cpfFunc.Location = new System.Drawing.Point(15, 131);
            this.maskedTextBox_cpfFunc.Mask = "000.000.000-00";
            this.maskedTextBox_cpfFunc.Name = "maskedTextBox_cpfFunc";
            this.maskedTextBox_cpfFunc.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBox_cpfFunc.TabIndex = 10;
            this.maskedTextBox_cpfFunc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_cpf_MaskInputRejected);
            // 
            // maskedTextBox_telefoneFunc
            // 
            this.maskedTextBox_telefoneFunc.Location = new System.Drawing.Point(15, 215);
            this.maskedTextBox_telefoneFunc.Mask = "(00) 00000-0000";
            this.maskedTextBox_telefoneFunc.Name = "maskedTextBox_telefoneFunc";
            this.maskedTextBox_telefoneFunc.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBox_telefoneFunc.TabIndex = 11;
            // 
            // maskedTextBox_dataFunc
            // 
            this.maskedTextBox_dataFunc.Location = new System.Drawing.Point(15, 257);
            this.maskedTextBox_dataFunc.Mask = "00/00/0000";
            this.maskedTextBox_dataFunc.Name = "maskedTextBox_dataFunc";
            this.maskedTextBox_dataFunc.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBox_dataFunc.TabIndex = 12;
            // 
            // txt_funcaoFunc
            // 
            this.txt_funcaoFunc.Location = new System.Drawing.Point(15, 299);
            this.txt_funcaoFunc.Name = "txt_funcaoFunc";
            this.txt_funcaoFunc.Size = new System.Drawing.Size(185, 20);
            this.txt_funcaoFunc.TabIndex = 13;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(12, 196);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(73, 16);
            this.lbl_telefone.TabIndex = 14;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(12, 238);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(107, 16);
            this.lbl_data.TabIndex = 15;
            this.lbl_data.Text = "Data de inicio:";
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcao.Location = new System.Drawing.Point(15, 280);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(64, 16);
            this.lbl_funcao.TabIndex = 16;
            this.lbl_funcao.Text = "Função:";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(124, 54);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 35;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(130, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // panel_cadastro
            // 
            this.panel_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel_cadastro.Controls.Add(this.lbl_Cadastro);
            this.panel_cadastro.Controls.Add(this.pictureBox3);
            this.panel_cadastro.Controls.Add(this.pictureBox_logo);
            this.panel_cadastro.Controls.Add(this.lbl_funcao);
            this.panel_cadastro.Controls.Add(this.lbl_data);
            this.panel_cadastro.Controls.Add(this.lbl_telefone);
            this.panel_cadastro.Controls.Add(this.txt_funcaoFunc);
            this.panel_cadastro.Controls.Add(this.maskedTextBox_dataFunc);
            this.panel_cadastro.Controls.Add(this.maskedTextBox_telefoneFunc);
            this.panel_cadastro.Controls.Add(this.maskedTextBox_cpfFunc);
            this.panel_cadastro.Controls.Add(this.btn_cancelar);
            this.panel_cadastro.Controls.Add(this.btn_confirmar);
            this.panel_cadastro.Controls.Add(this.txt_registroFunc);
            this.panel_cadastro.Controls.Add(this.txt_nomeFunc);
            this.panel_cadastro.Controls.Add(this.lbl_registro);
            this.panel_cadastro.Controls.Add(this.lbl_cpf);
            this.panel_cadastro.Controls.Add(this.lbl_nome);
            this.panel_cadastro.Controls.Add(this.pictureBox_cadastro);
            this.panel_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cadastro.Location = new System.Drawing.Point(0, 0);
            this.panel_cadastro.Name = "panel_cadastro";
            this.panel_cadastro.Size = new System.Drawing.Size(539, 404);
            this.panel_cadastro.TabIndex = 0;
            this.panel_cadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cadastro_Paint);
            // 
            // lbl_Cadastro
            // 
            this.lbl_Cadastro.AutoSize = true;
            this.lbl_Cadastro.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadastro.Location = new System.Drawing.Point(169, 16);
            this.lbl_Cadastro.Name = "lbl_Cadastro";
            this.lbl_Cadastro.Size = new System.Drawing.Size(341, 32);
            this.lbl_Cadastro.TabIndex = 37;
            this.lbl_Cadastro.Text = "Cadastro de Funcionário";
            // 
            // Form_cadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 404);
            this.Controls.Add(this.panel_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cadastroFuncionario";
            this.Text = "Form_cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_cadastro.ResumeLayout(false);
            this.panel_cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_cadastro;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.TextBox txt_nomeFunc;
        private System.Windows.Forms.TextBox txt_registroFunc;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpfFunc;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefoneFunc;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dataFunc;
        private System.Windows.Forms.TextBox txt_funcaoFunc;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_cadastro;
        private System.Windows.Forms.Label lbl_Cadastro;
    }
}