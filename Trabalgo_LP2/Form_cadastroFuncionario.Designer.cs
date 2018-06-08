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
            this.txt_funcaoFunc = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_Cadastro = new System.Windows.Forms.Label();
            this.txt_cpfFunc = new System.Windows.Forms.TextBox();
            this.txt_telefoneFunc = new System.Windows.Forms.TextBox();
            this.txt_dataFunc = new System.Windows.Forms.TextBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_cadastro
            // 
            this.pictureBox_cadastro.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cadastro.Image")));
            this.pictureBox_cadastro.Location = new System.Drawing.Point(282, 135);
            this.pictureBox_cadastro.Name = "pictureBox_cadastro";
            this.pictureBox_cadastro.Size = new System.Drawing.Size(227, 179);
            this.pictureBox_cadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cadastro.TabIndex = 0;
            this.pictureBox_cadastro.TabStop = false;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(26, 73);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(52, 16);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(26, 115);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(40, 16);
            this.lbl_cpf.TabIndex = 3;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(26, 157);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(72, 16);
            this.lbl_registro.TabIndex = 4;
            this.lbl_registro.Text = "Registro:";
            // 
            // txt_nomeFunc
            // 
            this.txt_nomeFunc.Location = new System.Drawing.Point(29, 92);
            this.txt_nomeFunc.Name = "txt_nomeFunc";
            this.txt_nomeFunc.Size = new System.Drawing.Size(294, 20);
            this.txt_nomeFunc.TabIndex = 5;
            // 
            // txt_registroFunc
            // 
            this.txt_registroFunc.Location = new System.Drawing.Point(29, 176);
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
            this.btn_confirmar.Location = new System.Drawing.Point(160, 344);
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
            this.btn_cancelar.Location = new System.Drawing.Point(29, 344);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 34);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_funcaoFunc
            // 
            this.txt_funcaoFunc.Location = new System.Drawing.Point(29, 302);
            this.txt_funcaoFunc.Name = "txt_funcaoFunc";
            this.txt_funcaoFunc.Size = new System.Drawing.Size(185, 20);
            this.txt_funcaoFunc.TabIndex = 13;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(26, 199);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(73, 16);
            this.lbl_telefone.TabIndex = 14;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(26, 241);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(103, 16);
            this.lbl_data.TabIndex = 15;
            this.lbl_data.Text = "Ano de Inicio:";
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcao.Location = new System.Drawing.Point(29, 283);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(64, 16);
            this.lbl_funcao.TabIndex = 16;
            this.lbl_funcao.Text = "Função:";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.Logonovo1;
            this.pictureBox_logo.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(124, 64);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 35;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Trabalgo_LP2.Properties.Resources._030_manager;
            this.pictureBox3.Location = new System.Drawing.Point(129, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_Cadastro
            // 
            this.lbl_Cadastro.AutoSize = true;
            this.lbl_Cadastro.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadastro.Location = new System.Drawing.Point(168, 9);
            this.lbl_Cadastro.Name = "lbl_Cadastro";
            this.lbl_Cadastro.Size = new System.Drawing.Size(341, 32);
            this.lbl_Cadastro.TabIndex = 37;
            this.lbl_Cadastro.Text = "Cadastro de Funcionário";
            // 
            // txt_cpfFunc
            // 
            this.txt_cpfFunc.Location = new System.Drawing.Point(29, 135);
            this.txt_cpfFunc.Name = "txt_cpfFunc";
            this.txt_cpfFunc.Size = new System.Drawing.Size(185, 20);
            this.txt_cpfFunc.TabIndex = 38;
            // 
            // txt_telefoneFunc
            // 
            this.txt_telefoneFunc.Location = new System.Drawing.Point(29, 219);
            this.txt_telefoneFunc.Name = "txt_telefoneFunc";
            this.txt_telefoneFunc.Size = new System.Drawing.Size(185, 20);
            this.txt_telefoneFunc.TabIndex = 39;
            // 
            // txt_dataFunc
            // 
            this.txt_dataFunc.Location = new System.Drawing.Point(29, 261);
            this.txt_dataFunc.Name = "txt_dataFunc";
            this.txt_dataFunc.Size = new System.Drawing.Size(185, 20);
            this.txt_dataFunc.TabIndex = 40;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_atualizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Location = new System.Drawing.Point(160, 344);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(89, 34);
            this.btn_atualizar.TabIndex = 41;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // Form_cadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(539, 404);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.txt_dataFunc);
            this.Controls.Add(this.txt_telefoneFunc);
            this.Controls.Add(this.pictureBox_cadastro);
            this.Controls.Add(this.txt_cpfFunc);
            this.Controls.Add(this.lbl_Cadastro);
            this.Controls.Add(this.lbl_funcao);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_nomeFunc);
            this.Controls.Add(this.txt_funcaoFunc);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.txt_registroFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cadastroFuncionario";
            this.Text = "Form_cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txt_funcaoFunc;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_Cadastro;
        private System.Windows.Forms.TextBox txt_cpfFunc;
        private System.Windows.Forms.TextBox txt_telefoneFunc;
        private System.Windows.Forms.TextBox txt_dataFunc;
        private System.Windows.Forms.Button btn_atualizar;
    }
}