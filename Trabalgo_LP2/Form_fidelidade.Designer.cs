namespace Trabalgo_LP2
{
    partial class Form_fidelidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_fidelidade));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_fidelidade = new System.Windows.Forms.Label();
            this.panel_fidelidade = new System.Windows.Forms.Panel();
            this.btn_criar = new System.Windows.Forms.Button();
            this.lbl_Mfreq = new System.Windows.Forms.Label();
            this.lbl_Mdesconto = new System.Windows.Forms.Label();
            this.txt_Mfreq = new System.Windows.Forms.TextBox();
            this.txt_Mdesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_fidelidade = new System.Windows.Forms.DataGridView();
            this.Column_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_fidelidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fidelidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.pictureBox_logo);
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbl_fidelidade);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 106);
            this.panel2.TabIndex = 4;
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
            this.btn_voltar.Location = new System.Drawing.Point(516, 30);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(69, 34);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Trabalgo_LP2.Properties.Resources._039_tag;
            this.pictureBox3.Location = new System.Drawing.Point(210, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_fidelidade
            // 
            this.lbl_fidelidade.AutoSize = true;
            this.lbl_fidelidade.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fidelidade.Location = new System.Drawing.Point(255, 30);
            this.lbl_fidelidade.Name = "lbl_fidelidade";
            this.lbl_fidelidade.Size = new System.Drawing.Size(186, 41);
            this.lbl_fidelidade.TabIndex = 0;
            this.lbl_fidelidade.Text = "Fidelidade";
            // 
            // panel_fidelidade
            // 
            this.panel_fidelidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(3)))), ((int)(((byte)(1)))));
            this.panel_fidelidade.Controls.Add(this.btn_criar);
            this.panel_fidelidade.Controls.Add(this.lbl_Mfreq);
            this.panel_fidelidade.Controls.Add(this.lbl_Mdesconto);
            this.panel_fidelidade.Controls.Add(this.txt_Mfreq);
            this.panel_fidelidade.Controls.Add(this.txt_Mdesconto);
            this.panel_fidelidade.Controls.Add(this.label4);
            this.panel_fidelidade.Controls.Add(this.label3);
            this.panel_fidelidade.Controls.Add(this.btn_novo);
            this.panel_fidelidade.Controls.Add(this.label2);
            this.panel_fidelidade.Controls.Add(this.label1);
            this.panel_fidelidade.Location = new System.Drawing.Point(12, 129);
            this.panel_fidelidade.Name = "panel_fidelidade";
            this.panel_fidelidade.Size = new System.Drawing.Size(136, 316);
            this.panel_fidelidade.TabIndex = 6;
            this.panel_fidelidade.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_fidelidade_Paint);
            // 
            // btn_criar
            // 
            this.btn_criar.BackColor = System.Drawing.Color.Black;
            this.btn_criar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_criar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_criar.Location = new System.Drawing.Point(3, 277);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(130, 36);
            this.btn_criar.TabIndex = 9;
            this.btn_criar.Text = "Confirmar";
            this.btn_criar.UseVisualStyleBackColor = false;
            this.btn_criar.Visible = false;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // lbl_Mfreq
            // 
            this.lbl_Mfreq.AutoSize = true;
            this.lbl_Mfreq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mfreq.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Mfreq.Location = new System.Drawing.Point(4, 222);
            this.lbl_Mfreq.Name = "lbl_Mfreq";
            this.lbl_Mfreq.Size = new System.Drawing.Size(96, 18);
            this.lbl_Mfreq.TabIndex = 8;
            this.lbl_Mfreq.Text = "Frequência:";
            this.lbl_Mfreq.Visible = false;
            // 
            // lbl_Mdesconto
            // 
            this.lbl_Mdesconto.AutoSize = true;
            this.lbl_Mdesconto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mdesconto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Mdesconto.Location = new System.Drawing.Point(4, 171);
            this.lbl_Mdesconto.Name = "lbl_Mdesconto";
            this.lbl_Mdesconto.Size = new System.Drawing.Size(82, 18);
            this.lbl_Mdesconto.TabIndex = 7;
            this.lbl_Mdesconto.Text = "Desconto:";
            this.lbl_Mdesconto.Visible = false;
            // 
            // txt_Mfreq
            // 
            this.txt_Mfreq.Location = new System.Drawing.Point(7, 241);
            this.txt_Mfreq.Name = "txt_Mfreq";
            this.txt_Mfreq.Size = new System.Drawing.Size(100, 20);
            this.txt_Mfreq.TabIndex = 6;
            this.txt_Mfreq.Visible = false;
            // 
            // txt_Mdesconto
            // 
            this.txt_Mdesconto.Location = new System.Drawing.Point(7, 190);
            this.txt_Mdesconto.Name = "txt_Mdesconto";
            this.txt_Mdesconto.Size = new System.Drawing.Size(100, 20);
            this.txt_Mdesconto.TabIndex = 5;
            this.txt_Mdesconto.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(98, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(3)))), ((int)(((byte)(1)))));
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(98, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(98, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(3)))), ((int)(((byte)(1)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(92, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "...";
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Black;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_novo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_novo.Location = new System.Drawing.Point(0, 85);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(133, 68);
            this.btn_novo.TabIndex = 2;
            this.btn_novo.Text = "Novo desconto";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frequência:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desconto:";
            // 
            // dataGridView_fidelidade
            // 
            this.dataGridView_fidelidade.AllowUserToAddRows = false;
            this.dataGridView_fidelidade.AllowUserToDeleteRows = false;
            this.dataGridView_fidelidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fidelidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Nome,
            this.Column_cpf,
            this.Column_frequencia,
            this.Telefone});
            this.dataGridView_fidelidade.Location = new System.Drawing.Point(154, 129);
            this.dataGridView_fidelidade.Name = "dataGridView_fidelidade";
            this.dataGridView_fidelidade.ReadOnly = true;
            this.dataGridView_fidelidade.Size = new System.Drawing.Size(443, 313);
            this.dataGridView_fidelidade.TabIndex = 7;
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
            // Column_frequencia
            // 
            this.Column_frequencia.DataPropertyName = "Frequencia";
            this.Column_frequencia.HeaderText = "Frequência";
            this.Column_frequencia.Name = "Column_frequencia";
            this.Column_frequencia.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(179)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(-1, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 13);
            this.panel1.TabIndex = 21;
            // 
            // Form_fidelidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_fidelidade);
            this.Controls.Add(this.panel_fidelidade);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_fidelidade";
            this.Text = "Form_fidelidade";
            this.Load += new System.EventHandler(this.Form_fidelidade_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_fidelidade.ResumeLayout(false);
            this.panel_fidelidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fidelidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_fidelidade;
        private System.Windows.Forms.Panel panel_fidelidade;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.DataGridView dataGridView_fidelidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_frequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Mfreq;
        private System.Windows.Forms.Label lbl_Mdesconto;
        private System.Windows.Forms.TextBox txt_Mfreq;
        private System.Windows.Forms.TextBox txt_Mdesconto;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Panel panel1;
    }
}