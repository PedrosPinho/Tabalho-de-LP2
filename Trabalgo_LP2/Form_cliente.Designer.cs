namespace Trabalgo_LP2
{
    partial class Form_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cliente));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.dataGridView_cliente = new System.Windows.Forms.DataGridView();
            this.Column_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.txt_cpf_rmv = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.pictureBox_logo);
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbl_cliente);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 106);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.Logonovo1;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 9);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(126, 97);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 16;
            this.pictureBox_logo.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Black;
            this.btn_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_voltar.BackgroundImage")));
            this.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(518, 32);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(65, 34);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Trabalgo_LP2.Properties.Resources.student;
            this.pictureBox3.Location = new System.Drawing.Point(230, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(271, 26);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(159, 47);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Cliente";
            // 
            // dataGridView_cliente
            // 
            this.dataGridView_cliente.AllowUserToAddRows = false;
            this.dataGridView_cliente.AllowUserToDeleteRows = false;
            this.dataGridView_cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Nome,
            this.Column_cpf,
            this.Column_telefone,
            this.Column_frequencia});
            this.dataGridView_cliente.Location = new System.Drawing.Point(12, 143);
            this.dataGridView_cliente.Name = "dataGridView_cliente";
            this.dataGridView_cliente.ReadOnly = true;
            this.dataGridView_cliente.Size = new System.Drawing.Size(440, 313);
            this.dataGridView_cliente.TabIndex = 3;
            this.dataGridView_cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cliente_CellDoubleClick);
            // 
            // Column_Nome
            // 
            this.Column_Nome.DataPropertyName = "Nome";
            this.Column_Nome.HeaderText = "Nome";
            this.Column_Nome.Name = "Column_Nome";
            this.Column_Nome.ReadOnly = true;
            // 
            // Column_cpf
            // 
            this.Column_cpf.DataPropertyName = "Cpf";
            this.Column_cpf.HeaderText = "CPF";
            this.Column_cpf.Name = "Column_cpf";
            this.Column_cpf.ReadOnly = true;
            // 
            // Column_telefone
            // 
            this.Column_telefone.DataPropertyName = "Telefone";
            this.Column_telefone.HeaderText = "Telefone";
            this.Column_telefone.Name = "Column_telefone";
            this.Column_telefone.ReadOnly = true;
            // 
            // Column_frequencia
            // 
            this.Column_frequencia.DataPropertyName = "Frequencia";
            this.Column_frequencia.HeaderText = "Frequência";
            this.Column_frequencia.Name = "Column_frequencia";
            this.Column_frequencia.ReadOnly = true;
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtrar.Location = new System.Drawing.Point(68, 115);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(384, 26);
            this.txt_filtrar.TabIndex = 12;
            this.txt_filtrar.TextChanged += new System.EventHandler(this.txt_filtrar_TextChanged);
            // 
            // lbl_filtrar
            // 
            this.lbl_filtrar.AutoSize = true;
            this.lbl_filtrar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrar.Location = new System.Drawing.Point(8, 116);
            this.lbl_filtrar.Name = "lbl_filtrar";
            this.lbl_filtrar.Size = new System.Drawing.Size(54, 23);
            this.lbl_filtrar.TabIndex = 13;
            this.lbl_filtrar.Text = "Filtrar";
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_remover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_remover.BackgroundImage")));
            this.btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remover.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.Color.White;
            this.btn_remover.Location = new System.Drawing.Point(475, 361);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(122, 46);
            this.btn_remover.TabIndex = 15;
            this.btn_remover.Text = "Remover";
            this.btn_remover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(475, 143);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(122, 46);
            this.btn_adicionar.TabIndex = 11;
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
            this.btn_alterar.Location = new System.Drawing.Point(475, 252);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(122, 46);
            this.btn_alterar.TabIndex = 10;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // txt_cpf_rmv
            // 
            this.txt_cpf_rmv.Location = new System.Drawing.Point(475, 413);
            this.txt_cpf_rmv.Mask = "00000000000";
            this.txt_cpf_rmv.Name = "txt_cpf_rmv";
            this.txt_cpf_rmv.Size = new System.Drawing.Size(122, 20);
            this.txt_cpf_rmv.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "(Para remover digite o cpf)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(179)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 10);
            this.panel1.TabIndex = 20;
            // 
            // Form_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cpf_rmv);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.lbl_filtrar);
            this.Controls.Add(this.txt_filtrar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.dataGridView_cliente);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cliente";
            this.Text = "Form_cliente";
            this.Load += new System.EventHandler(this.Form_cliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.DataGridView dataGridView_cliente;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_frequencia;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.MaskedTextBox txt_cpf_rmv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}