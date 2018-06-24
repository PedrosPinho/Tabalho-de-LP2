namespace Trabalgo_LP2
{
    partial class Form_contas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_contas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_contas = new System.Windows.Forms.Label();
            this.grid_contas = new System.Windows.Forms.DataGridView();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_id_item = new System.Windows.Forms.Label();
            this.txt_id_item = new System.Windows.Forms.TextBox();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_itensTotais = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_contas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_itensTotais)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox_logo);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btn_voltar);
            this.panel3.Controls.Add(this.lbl_contas);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 104);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(179)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 41);
            this.label2.TabIndex = 19;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.Logonovo1;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 7);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(126, 97);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 17;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Trabalgo_LP2.Properties.Resources.meeting;
            this.pictureBox3.Location = new System.Drawing.Point(236, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Black;
            this.btn_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_voltar.BackgroundImage")));
            this.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(517, 27);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(57, 34);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_contas
            // 
            this.lbl_contas.AutoSize = true;
            this.lbl_contas.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contas.Location = new System.Drawing.Point(289, 20);
            this.lbl_contas.Name = "lbl_contas";
            this.lbl_contas.Size = new System.Drawing.Size(121, 41);
            this.lbl_contas.TabIndex = 0;
            this.lbl_contas.Text = "Conta";
            // 
            // grid_contas
            // 
            this.grid_contas.AllowUserToAddRows = false;
            this.grid_contas.AllowUserToDeleteRows = false;
            this.grid_contas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_contas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grid_contas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_contas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_contas.ColumnHeadersHeight = 25;
            this.grid_contas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.nome_item,
            this.preco_item,
            this.Column_quantidade});
            this.grid_contas.GridColor = System.Drawing.Color.Black;
            this.grid_contas.Location = new System.Drawing.Point(12, 160);
            this.grid_contas.Name = "grid_contas";
            this.grid_contas.ReadOnly = true;
            this.grid_contas.Size = new System.Drawing.Size(326, 164);
            this.grid_contas.TabIndex = 3;
            // 
            // column_id
            // 
            this.column_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.column_id.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.column_id.HeaderText = "Id ";
            this.column_id.Name = "column_id";
            this.column_id.ReadOnly = true;
            this.column_id.Width = 42;
            // 
            // nome_item
            // 
            this.nome_item.DataPropertyName = "Nome";
            this.nome_item.HeaderText = "Nome";
            this.nome_item.Name = "nome_item";
            this.nome_item.ReadOnly = true;
            // 
            // preco_item
            // 
            this.preco_item.DataPropertyName = "Preco";
            this.preco_item.HeaderText = "Preço";
            this.preco_item.Name = "preco_item";
            this.preco_item.ReadOnly = true;
            // 
            // Column_quantidade
            // 
            this.Column_quantidade.DataPropertyName = "quantidade";
            this.Column_quantidade.HeaderText = "Qtd";
            this.Column_quantidade.Name = "Column_quantidade";
            this.Column_quantidade.ReadOnly = true;
            // 
            // lbl_id_item
            // 
            this.lbl_id_item.AutoSize = true;
            this.lbl_id_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(179)))), ((int)(((byte)(48)))));
            this.lbl_id_item.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_item.Location = new System.Drawing.Point(12, 334);
            this.lbl_id_item.Name = "lbl_id_item";
            this.lbl_id_item.Size = new System.Drawing.Size(64, 20);
            this.lbl_id_item.TabIndex = 4;
            this.lbl_id_item.Text = "Item (id):";
            // 
            // txt_id_item
            // 
            this.txt_id_item.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_item.Location = new System.Drawing.Point(82, 332);
            this.txt_id_item.Name = "txt_id_item";
            this.txt_id_item.Size = new System.Drawing.Size(34, 26);
            this.txt_id_item.TabIndex = 5;
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(179)))), ((int)(((byte)(48)))));
            this.lbl_qtd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd.Location = new System.Drawing.Point(133, 334);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(84, 20);
            this.lbl_qtd.TabIndex = 6;
            this.lbl_qtd.Text = "Quantidade:";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtd.Location = new System.Drawing.Point(223, 332);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(34, 26);
            this.txt_qtd.TabIndex = 7;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(263, 328);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 34);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Black;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(479, 328);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(93, 34);
            this.btn_fechar.TabIndex = 11;
            this.btn_fechar.Text = "Fechar conta";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(179)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(1, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 11);
            this.panel1.TabIndex = 20;
            // 
            // grid_itensTotais
            // 
            this.grid_itensTotais.AllowUserToAddRows = false;
            this.grid_itensTotais.AllowUserToDeleteRows = false;
            this.grid_itensTotais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_itensTotais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grid_itensTotais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_itensTotais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome});
            this.grid_itensTotais.Location = new System.Drawing.Point(348, 160);
            this.grid_itensTotais.Name = "grid_itensTotais";
            this.grid_itensTotais.ReadOnly = true;
            this.grid_itensTotais.RowHeadersWidth = 20;
            this.grid_itensTotais.Size = new System.Drawing.Size(224, 164);
            this.grid_itensTotais.TabIndex = 21;
            this.grid_itensTotais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(179)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 41);
            this.label3.TabIndex = 21;
            this.label3.Text = "Itens Pedidos:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(348, 128);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(60, 27);
            this.btn_buscar.TabIndex = 22;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(414, 128);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(158, 26);
            this.txt_buscar.TabIndex = 23;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Form_contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 374);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_itensTotais);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.grid_contas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.lbl_id_item);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.txt_id_item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_contas";
            this.Text = "Form_Contas";
            this.Load += new System.EventHandler(this.Form_contas_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_contas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_itensTotais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_contas;
        private System.Windows.Forms.DataGridView grid_contas;
        private System.Windows.Forms.Label lbl_id_item;
        private System.Windows.Forms.TextBox txt_id_item;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_quantidade;
        private System.Windows.Forms.DataGridView grid_itensTotais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}