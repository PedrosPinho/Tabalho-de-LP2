namespace Trabalgo_LP2
{
    partial class Form_login
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
            this.panel_login = new System.Windows.Forms.Panel();
            this.linklbl_cadastrar = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.txt_registro = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_login = new System.Windows.Forms.PictureBox();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel_login.Controls.Add(this.linklbl_cadastrar);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.lbl_registro);
            this.panel_login.Controls.Add(this.txt_registro);
            this.panel_login.Controls.Add(this.pictureBox_login);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login.Location = new System.Drawing.Point(0, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(559, 279);
            this.panel_login.TabIndex = 0;
            // 
            // linklbl_cadastrar
            // 
            this.linklbl_cadastrar.AutoSize = true;
            this.linklbl_cadastrar.Font = new System.Drawing.Font("Arial", 10F);
            this.linklbl_cadastrar.LinkColor = System.Drawing.Color.Black;
            this.linklbl_cadastrar.Location = new System.Drawing.Point(467, 175);
            this.linklbl_cadastrar.Name = "linklbl_cadastrar";
            this.linklbl_cadastrar.Size = new System.Drawing.Size(71, 16);
            this.linklbl_cadastrar.TabIndex = 5;
            this.linklbl_cadastrar.TabStop = true;
            this.linklbl_cadastrar.Text = "Cadastrar";
            this.linklbl_cadastrar.VisitedLinkColor = System.Drawing.Color.Black;
            this.linklbl_cadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_cadastrar_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_login.Location = new System.Drawing.Point(357, 132);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(181, 28);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(354, 85);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(73, 18);
            this.lbl_registro.TabIndex = 2;
            this.lbl_registro.Text = "Registro:";
            // 
            // txt_registro
            // 
            this.txt_registro.BeepOnError = true;
            this.txt_registro.Location = new System.Drawing.Point(357, 106);
            this.txt_registro.Mask = "0000000000";
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(181, 20);
            this.txt_registro.TabIndex = 1;
            // 
            // pictureBox_login
            // 
            this.pictureBox_login.Image = global::Trabalgo_LP2.Properties.Resources.Logonovo1;
            this.pictureBox_login.Location = new System.Drawing.Point(3, 12);
            this.pictureBox_login.Name = "pictureBox_login";
            this.pictureBox_login.Size = new System.Drawing.Size(330, 255);
            this.pictureBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_login.TabIndex = 0;
            this.pictureBox_login.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 279);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.PictureBox pictureBox_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.MaskedTextBox txt_registro;
        private System.Windows.Forms.LinkLabel linklbl_cadastrar;
    }
}

