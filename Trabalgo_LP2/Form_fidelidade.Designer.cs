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
            this.dataGridView_fidelidade = new System.Windows.Forms.DataGridView();
            this.Column_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_fidelidade = new System.Windows.Forms.Label();
            this.panel_fidelidade = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fidelidade)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_fidelidade
            // 
            this.dataGridView_fidelidade.AllowUserToAddRows = false;
            this.dataGridView_fidelidade.AllowUserToDeleteRows = false;
            this.dataGridView_fidelidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fidelidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Nome,
            this.Column_telefone,
            this.Column_frequencia});
            this.dataGridView_fidelidade.Location = new System.Drawing.Point(253, 137);
            this.dataGridView_fidelidade.Name = "dataGridView_fidelidade";
            this.dataGridView_fidelidade.ReadOnly = true;
            this.dataGridView_fidelidade.Size = new System.Drawing.Size(344, 319);
            this.dataGridView_fidelidade.TabIndex = 5;
            // 
            // Column_Nome
            // 
            this.Column_Nome.HeaderText = "Nome";
            this.Column_Nome.Name = "Column_Nome";
            this.Column_Nome.ReadOnly = true;
            // 
            // Column_telefone
            // 
            this.Column_telefone.HeaderText = "Telefone";
            this.Column_telefone.Name = "Column_telefone";
            this.Column_telefone.ReadOnly = true;
            // 
            // Column_frequencia
            // 
            this.Column_frequencia.HeaderText = "Frequência";
            this.Column_frequencia.Name = "Column_frequencia";
            this.Column_frequencia.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.pictureBox_logo);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbl_fidelidade);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 103);
            this.panel2.TabIndex = 4;
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
            this.pictureBox3.Location = new System.Drawing.Point(217, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_fidelidade
            // 
            this.lbl_fidelidade.AutoSize = true;
            this.lbl_fidelidade.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fidelidade.Location = new System.Drawing.Point(265, 30);
            this.lbl_fidelidade.Name = "lbl_fidelidade";
            this.lbl_fidelidade.Size = new System.Drawing.Size(186, 41);
            this.lbl_fidelidade.TabIndex = 0;
            this.lbl_fidelidade.Text = "Fidelidade";
            // 
            // panel_fidelidade
            // 
            this.panel_fidelidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(3)))), ((int)(((byte)(1)))));
            this.panel_fidelidade.Location = new System.Drawing.Point(12, 137);
            this.panel_fidelidade.Name = "panel_fidelidade";
            this.panel_fidelidade.Size = new System.Drawing.Size(218, 319);
            this.panel_fidelidade.TabIndex = 6;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Black;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(496, 30);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(89, 34);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Form_fidelidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.panel_fidelidade);
            this.Controls.Add(this.dataGridView_fidelidade);
            this.Controls.Add(this.panel2);
            this.Name = "Form_fidelidade";
            this.Text = "Form_fidelidade";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fidelidade)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_fidelidade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_fidelidade;
        private System.Windows.Forms.Panel panel_fidelidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_frequencia;
        private System.Windows.Forms.Button btn_voltar;
    }
}