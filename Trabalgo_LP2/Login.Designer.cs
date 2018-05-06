namespace Trabalgo_LP2
{
    partial class Login
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
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.maskedTextBox_registro = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_login = new System.Windows.Forms.PictureBox();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_login.Controls.Add(this.btn_cadastrar);
            this.panel_login.Controls.Add(this.btn_confirmar);
            this.panel_login.Controls.Add(this.btn_cancelar);
            this.panel_login.Controls.Add(this.lbl_registro);
            this.panel_login.Controls.Add(this.maskedTextBox_registro);
            this.panel_login.Controls.Add(this.pictureBox_login);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login.Location = new System.Drawing.Point(0, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(559, 279);
            this.panel_login.TabIndex = 0;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.DimGray;
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cadastrar.Location = new System.Drawing.Point(357, 174);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(181, 23);
            this.btn_cadastrar.TabIndex = 5;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.DimGray;
            this.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_confirmar.Location = new System.Drawing.Point(463, 128);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 4;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar.Location = new System.Drawing.Point(356, 128);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(353, 64);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(73, 18);
            this.lbl_registro.TabIndex = 2;
            this.lbl_registro.Text = "Registro:";
            // 
            // maskedTextBox_registro
            // 
            this.maskedTextBox_registro.Location = new System.Drawing.Point(357, 87);
            this.maskedTextBox_registro.Mask = "0000000000";
            this.maskedTextBox_registro.Name = "maskedTextBox_registro";
            this.maskedTextBox_registro.Size = new System.Drawing.Size(181, 20);
            this.maskedTextBox_registro.TabIndex = 1;
            // 
            // pictureBox_login
            // 
            this.pictureBox_login.Image = global::Trabalgo_LP2.Properties.Resources.logo;
            this.pictureBox_login.Location = new System.Drawing.Point(3, 12);
            this.pictureBox_login.Name = "pictureBox_login";
            this.pictureBox_login.Size = new System.Drawing.Size(305, 255);
            this.pictureBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_login.TabIndex = 0;
            this.pictureBox_login.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 279);
            this.Controls.Add(this.panel_login);
            this.Name = "Login";
            this.Text = "Form_Login";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.PictureBox pictureBox_login;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_registro;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}

