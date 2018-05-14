namespace Trabalgo_LP2
{
    partial class Form_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_funcionario));
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.dataGridView_funcionario = new System.Windows.Forms.DataGridView();
            this.Column_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_funcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_funcionario = new System.Windows.Forms.Label();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionario)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pesquisar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(422, 115);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(99, 26);
            this.btn_pesquisar.TabIndex = 20;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtrar.Location = new System.Drawing.Point(63, 115);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(353, 26);
            this.txt_filtrar.TabIndex = 19;
            // 
            // dataGridView_funcionario
            // 
            this.dataGridView_funcionario.AllowUserToAddRows = false;
            this.dataGridView_funcionario.AllowUserToDeleteRows = false;
            this.dataGridView_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_funcionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Nome,
            this.Column_cpf,
            this.Column_telefone,
            this.Column_registro,
            this.Column_funcao});
            this.dataGridView_funcionario.Location = new System.Drawing.Point(16, 147);
            this.dataGridView_funcionario.Name = "dataGridView_funcionario";
            this.dataGridView_funcionario.ReadOnly = true;
            this.dataGridView_funcionario.Size = new System.Drawing.Size(505, 315);
            this.dataGridView_funcionario.TabIndex = 16;
            // 
            // Column_Nome
            // 
            this.Column_Nome.HeaderText = "Nome";
            this.Column_Nome.Name = "Column_Nome";
            this.Column_Nome.ReadOnly = true;
            // 
            // Column_cpf
            // 
            this.Column_cpf.HeaderText = "CPF";
            this.Column_cpf.Name = "Column_cpf";
            this.Column_cpf.ReadOnly = true;
            // 
            // Column_telefone
            // 
            this.Column_telefone.HeaderText = "Telefone";
            this.Column_telefone.Name = "Column_telefone";
            this.Column_telefone.ReadOnly = true;
            // 
            // Column_registro
            // 
            this.Column_registro.HeaderText = "Registro";
            this.Column_registro.Name = "Column_registro";
            this.Column_registro.ReadOnly = true;
            // 
            // Column_funcao
            // 
            this.Column_funcao.HeaderText = "Função";
            this.Column_funcao.Name = "Column_funcao";
            this.Column_funcao.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.pictureBox_logo);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbl_funcionario);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 103);
            this.panel2.TabIndex = 15;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Black;
            this.btn_voltar.BackgroundImage = global::Trabalgo_LP2.Properties.Resources._2018_05_11_11_13_45_Quant_UX___Prototype__Test_and_Learn___1_6;
            this.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(559, 28);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(67, 34);
            this.btn_voltar.TabIndex = 22;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 6);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(109, 97);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 4;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(232, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_funcionario
            // 
            this.lbl_funcionario.AutoSize = true;
            this.lbl_funcionario.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcionario.Location = new System.Drawing.Point(268, 28);
            this.lbl_funcionario.Name = "lbl_funcionario";
            this.lbl_funcionario.Size = new System.Drawing.Size(211, 41);
            this.lbl_funcionario.TabIndex = 0;
            this.lbl_funcionario.Text = "Funcionário";
            // 
            // lbl_filtrar
            // 
            this.lbl_filtrar.AutoSize = true;
            this.lbl_filtrar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrar.Location = new System.Drawing.Point(12, 115);
            this.lbl_filtrar.Name = "lbl_filtrar";
            this.lbl_filtrar.Size = new System.Drawing.Size(54, 23);
            this.lbl_filtrar.TabIndex = 21;
            this.lbl_filtrar.Text = "Filtrar";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(537, 234);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(118, 46);
            this.btn_adicionar.TabIndex = 18;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_alterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_alterar.BackgroundImage")));
            this.btn_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(537, 335);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(118, 46);
            this.btn_alterar.TabIndex = 17;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // Form_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 468);
            this.Controls.Add(this.lbl_filtrar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txt_filtrar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.dataGridView_funcionario);
            this.Controls.Add(this.panel2);
            this.Name = "Form_funcionario";
            this.Text = "Form_funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.DataGridView dataGridView_funcionario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_funcao;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.Button btn_voltar;
    }
}