namespace Trabalgo_LP2
{
    partial class Form_mesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mesa));
            this.txt_mesa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_mesa = new System.Windows.Forms.Label();
            this.dataGridView_mesas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mesa
            // 
            this.txt_mesa.AutoSize = true;
            this.txt_mesa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mesa.Location = new System.Drawing.Point(12, 115);
            this.txt_mesa.Name = "txt_mesa";
            this.txt_mesa.Size = new System.Drawing.Size(588, 25);
            this.txt_mesa.TabIndex = 8;
            this.txt_mesa.Text = "Para acessar, clique sob o número da mesa que desejar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.pictureBox_logo);
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbl_mesa);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 103);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.Logonovo1;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 6);
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
            this.btn_voltar.Location = new System.Drawing.Point(503, 28);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(72, 34);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Trabalgo_LP2.Properties.Resources.meeting;
            this.pictureBox3.Location = new System.Drawing.Point(206, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_mesa
            // 
            this.lbl_mesa.AutoSize = true;
            this.lbl_mesa.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mesa.Location = new System.Drawing.Point(261, 22);
            this.lbl_mesa.Name = "lbl_mesa";
            this.lbl_mesa.Size = new System.Drawing.Size(144, 47);
            this.lbl_mesa.TabIndex = 0;
            this.lbl_mesa.Text = "Mesas";
            // 
            // dataGridView_mesas
            // 
            this.dataGridView_mesas.AllowUserToAddRows = false;
            this.dataGridView_mesas.AllowUserToDeleteRows = false;
            this.dataGridView_mesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_mesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_mesas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_mesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_mesas.ColumnHeadersHeight = 25;
            this.dataGridView_mesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mesa,
            this.Pessoas});
            this.dataGridView_mesas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_mesas.Location = new System.Drawing.Point(12, 149);
            this.dataGridView_mesas.Name = "dataGridView_mesas";
            this.dataGridView_mesas.ReadOnly = true;
            this.dataGridView_mesas.Size = new System.Drawing.Size(301, 283);
            this.dataGridView_mesas.StandardTab = true;
            this.dataGridView_mesas.TabIndex = 6;
            this.dataGridView_mesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_mesas_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(179)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 11);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(353, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Pessoas
            // 
            this.Pessoas.DataPropertyName = "num_pessoas";
            this.Pessoas.HeaderText = "Pessoas";
            this.Pessoas.Name = "Pessoas";
            this.Pessoas.ReadOnly = true;
            // 
            // Mesa
            // 
            this.Mesa.DataPropertyName = "num_mesa";
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.Name = "Mesa";
            this.Mesa.ReadOnly = true;
            // 
            // Form_mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_mesa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_mesas);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_mesa";
            this.Text = "Form_mesa";
            this.Load += new System.EventHandler(this.Form_mesa_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_mesa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_mesa;
        private System.Windows.Forms.DataGridView dataGridView_mesas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessoas;
    }
}