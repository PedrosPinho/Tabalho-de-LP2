﻿namespace Trabalgo_LP2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_mesa = new System.Windows.Forms.Label();
            this.grid_mesas = new System.Windows.Forms.DataGridView();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_mesa = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_mesa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grid_mesas);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 468);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.pictureBox_logo);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbl_mesa);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 103);
            this.panel2.TabIndex = 1;
            // 
            // lbl_mesa
            // 
            this.lbl_mesa.AutoSize = true;
            this.lbl_mesa.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mesa.Location = new System.Drawing.Point(280, 30);
            this.lbl_mesa.Name = "lbl_mesa";
            this.lbl_mesa.Size = new System.Drawing.Size(123, 41);
            this.lbl_mesa.TabIndex = 0;
            this.lbl_mesa.Text = "Mesas";
            // 
            // grid_mesas
            // 
            this.grid_mesas.AllowUserToDeleteRows = false;
            this.grid_mesas.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.grid_mesas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_mesas.ColumnHeadersHeight = 25;
            this.grid_mesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mesa,
            this.Pessoas});
            this.grid_mesas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid_mesas.Location = new System.Drawing.Point(46, 159);
            this.grid_mesas.Name = "grid_mesas";
            this.grid_mesas.Size = new System.Drawing.Size(244, 283);
            this.grid_mesas.StandardTab = true;
            this.grid_mesas.TabIndex = 2;
            this.grid_mesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Mesa
            // 
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.Name = "Mesa";
            // 
            // Pessoas
            // 
            this.Pessoas.HeaderText = "Pessoas";
            this.Pessoas.Name = "Pessoas";
            // 
            // txt_mesa
            // 
            this.txt_mesa.AutoSize = true;
            this.txt_mesa.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mesa.Location = new System.Drawing.Point(41, 116);
            this.txt_mesa.Name = "txt_mesa";
            this.txt_mesa.Size = new System.Drawing.Size(534, 29);
            this.txt_mesa.TabIndex = 4;
            this.txt_mesa.Text = "Para acessar, clique sob o número da mesa que desejar";
            this.txt_mesa.Click += new System.EventHandler(this.txt_mesa_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(232, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(325, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            // Form_mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.panel1);
            this.Name = "Form_mesa";
            this.Text = "Form_mesa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_mesa;
        private System.Windows.Forms.DataGridView grid_mesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessoas;
        private System.Windows.Forms.Label txt_mesa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_logo;
    }
}