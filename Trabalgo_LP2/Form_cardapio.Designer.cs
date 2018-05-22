namespace Trabalgo_LP2
{
    partial class Form_cardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cardapio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_cardapio = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_item_cardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_item_cardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_item_cardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_item_cardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_procurar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_remover_adicionar = new System.Windows.Forms.Button();
            this.btn_adicionar_adicionar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_descricao_adicionar = new System.Windows.Forms.Label();
            this.txt_preco_adicionar = new System.Windows.Forms.TextBox();
            this.lbl_preco_adicionar = new System.Windows.Forms.Label();
            this.txt_nome_adicionar = new System.Windows.Forms.TextBox();
            this.lbl_nome_adicionar = new System.Windows.Forms.Label();
            this.txt_id_adicionar = new System.Windows.Forms.TextBox();
            this.lbl_id_adicionar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_adicionar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_cardapio);
            this.panel1.Controls.Add(this.pictureBox_logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 103);
            this.panel1.TabIndex = 8;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Black;
            this.btn_voltar.BackgroundImage = global::Trabalgo_LP2.Properties.Resources._2018_05_11_11_13_45_Quant_UX___Prototype__Test_and_Learn___1_6;
            this.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(600, 26);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(74, 34);
            this.btn_voltar.TabIndex = 14;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_cardapio
            // 
            this.lbl_cardapio.AutoSize = true;
            this.lbl_cardapio.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardapio.Location = new System.Drawing.Point(292, 31);
            this.lbl_cardapio.Name = "lbl_cardapio";
            this.lbl_cardapio.Size = new System.Drawing.Size(144, 42);
            this.lbl_cardapio.TabIndex = 2;
            this.lbl_cardapio.Text = "Cardápio";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 6);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(109, 97);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_item_cardapio,
            this.nome_item_cardapio,
            this.preco_item_cardapio,
            this.descricao_item_cardapio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 301);
            this.dataGridView1.TabIndex = 9;
            // 
            // id_item_cardapio
            // 
            this.id_item_cardapio.HeaderText = "ID";
            this.id_item_cardapio.Name = "id_item_cardapio";
            this.id_item_cardapio.ReadOnly = true;
            // 
            // nome_item_cardapio
            // 
            this.nome_item_cardapio.HeaderText = "Nome";
            this.nome_item_cardapio.Name = "nome_item_cardapio";
            this.nome_item_cardapio.ReadOnly = true;
            // 
            // preco_item_cardapio
            // 
            this.preco_item_cardapio.HeaderText = "Preço";
            this.preco_item_cardapio.Name = "preco_item_cardapio";
            this.preco_item_cardapio.ReadOnly = true;
            // 
            // descricao_item_cardapio
            // 
            this.descricao_item_cardapio.HeaderText = "Descrição";
            this.descricao_item_cardapio.Name = "descricao_item_cardapio";
            this.descricao_item_cardapio.ReadOnly = true;
            // 
            // lbl_procurar
            // 
            this.lbl_procurar.AutoSize = true;
            this.lbl_procurar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_procurar.Location = new System.Drawing.Point(9, 122);
            this.lbl_procurar.Name = "lbl_procurar";
            this.lbl_procurar.Size = new System.Drawing.Size(63, 20);
            this.lbl_procurar.TabIndex = 10;
            this.lbl_procurar.Text = "Procurar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 26);
            this.textBox1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.btn_remover_adicionar);
            this.panel2.Controls.Add(this.btn_adicionar_adicionar);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.lbl_descricao_adicionar);
            this.panel2.Controls.Add(this.txt_preco_adicionar);
            this.panel2.Controls.Add(this.lbl_preco_adicionar);
            this.panel2.Controls.Add(this.txt_nome_adicionar);
            this.panel2.Controls.Add(this.lbl_nome_adicionar);
            this.panel2.Controls.Add(this.txt_id_adicionar);
            this.panel2.Controls.Add(this.lbl_id_adicionar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(470, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 345);
            this.panel2.TabIndex = 12;
            // 
            // btn_remover_adicionar
            // 
            this.btn_remover_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_remover_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remover_adicionar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_remover_adicionar.Location = new System.Drawing.Point(116, 308);
            this.btn_remover_adicionar.Name = "btn_remover_adicionar";
            this.btn_remover_adicionar.Size = new System.Drawing.Size(89, 34);
            this.btn_remover_adicionar.TabIndex = 13;
            this.btn_remover_adicionar.Text = "Remover";
            this.btn_remover_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_adicionar_adicionar
            // 
            this.btn_adicionar_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_adicionar_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionar_adicionar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar_adicionar.Location = new System.Drawing.Point(3, 308);
            this.btn_adicionar_adicionar.Name = "btn_adicionar_adicionar";
            this.btn_adicionar_adicionar.Size = new System.Drawing.Size(89, 34);
            this.btn_adicionar_adicionar.TabIndex = 12;
            this.btn_adicionar_adicionar.Text = "Adicionar";
            this.btn_adicionar_adicionar.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(31, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 26);
            this.textBox4.TabIndex = 11;
            // 
            // lbl_descricao_adicionar
            // 
            this.lbl_descricao_adicionar.AutoSize = true;
            this.lbl_descricao_adicionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao_adicionar.Location = new System.Drawing.Point(27, 228);
            this.lbl_descricao_adicionar.Name = "lbl_descricao_adicionar";
            this.lbl_descricao_adicionar.Size = new System.Drawing.Size(74, 20);
            this.lbl_descricao_adicionar.TabIndex = 10;
            this.lbl_descricao_adicionar.Text = "Descrição:";
            // 
            // txt_preco_adicionar
            // 
            this.txt_preco_adicionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco_adicionar.Location = new System.Drawing.Point(31, 190);
            this.txt_preco_adicionar.Name = "txt_preco_adicionar";
            this.txt_preco_adicionar.Size = new System.Drawing.Size(149, 26);
            this.txt_preco_adicionar.TabIndex = 9;
            // 
            // lbl_preco_adicionar
            // 
            this.lbl_preco_adicionar.AutoSize = true;
            this.lbl_preco_adicionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco_adicionar.Location = new System.Drawing.Point(27, 167);
            this.lbl_preco_adicionar.Name = "lbl_preco_adicionar";
            this.lbl_preco_adicionar.Size = new System.Drawing.Size(49, 20);
            this.lbl_preco_adicionar.TabIndex = 8;
            this.lbl_preco_adicionar.Text = "Preço:";
            // 
            // txt_nome_adicionar
            // 
            this.txt_nome_adicionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_adicionar.Location = new System.Drawing.Point(31, 128);
            this.txt_nome_adicionar.Name = "txt_nome_adicionar";
            this.txt_nome_adicionar.Size = new System.Drawing.Size(149, 26);
            this.txt_nome_adicionar.TabIndex = 7;
            // 
            // lbl_nome_adicionar
            // 
            this.lbl_nome_adicionar.AutoSize = true;
            this.lbl_nome_adicionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_adicionar.Location = new System.Drawing.Point(27, 105);
            this.lbl_nome_adicionar.Name = "lbl_nome_adicionar";
            this.lbl_nome_adicionar.Size = new System.Drawing.Size(49, 20);
            this.lbl_nome_adicionar.TabIndex = 6;
            this.lbl_nome_adicionar.Text = "Nome:";
            // 
            // txt_id_adicionar
            // 
            this.txt_id_adicionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_adicionar.Location = new System.Drawing.Point(31, 67);
            this.txt_id_adicionar.Name = "txt_id_adicionar";
            this.txt_id_adicionar.Size = new System.Drawing.Size(149, 26);
            this.txt_id_adicionar.TabIndex = 5;
            // 
            // lbl_id_adicionar
            // 
            this.lbl_id_adicionar.AutoSize = true;
            this.lbl_id_adicionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_adicionar.Location = new System.Drawing.Point(27, 44);
            this.lbl_id_adicionar.Name = "lbl_id_adicionar";
            this.lbl_id_adicionar.Size = new System.Drawing.Size(60, 20);
            this.lbl_id_adicionar.TabIndex = 1;
            this.lbl_id_adicionar.Text = "Item (id)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.panel3.Controls.Add(this.lbl_adicionar);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 35);
            this.panel3.TabIndex = 0;
            // 
            // lbl_adicionar
            // 
            this.lbl_adicionar.AutoSize = true;
            this.lbl_adicionar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_adicionar.Location = new System.Drawing.Point(15, 6);
            this.lbl_adicionar.Name = "lbl_adicionar";
            this.lbl_adicionar.Size = new System.Drawing.Size(189, 25);
            this.lbl_adicionar.TabIndex = 13;
            this.lbl_adicionar.Text = "Adicionar e Remover";
            this.lbl_adicionar.Click += new System.EventHandler(this.lbl_adicao_Click);
            // 
            // Form_cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_procurar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cardapio";
            this.Text = "Form_cardapio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_cardapio;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item_cardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_item_cardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_item_cardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_item_cardapio;
        private System.Windows.Forms.Label lbl_procurar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_adicionar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_descricao_adicionar;
        private System.Windows.Forms.TextBox txt_preco_adicionar;
        private System.Windows.Forms.Label lbl_preco_adicionar;
        private System.Windows.Forms.TextBox txt_nome_adicionar;
        private System.Windows.Forms.Label lbl_nome_adicionar;
        private System.Windows.Forms.TextBox txt_id_adicionar;
        private System.Windows.Forms.Label lbl_id_adicionar;
        private System.Windows.Forms.Button btn_remover_adicionar;
        private System.Windows.Forms.Button btn_adicionar_adicionar;
        private System.Windows.Forms.Button btn_voltar;
    }
}