namespace Trabalgo_LP2
{
    partial class Form_confirmaFuncionario
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
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.lbl_confirmaRegistro = new System.Windows.Forms.Label();
            this.txt_registro = new System.Windows.Forms.MaskedTextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.Logonovo1;
            this.pictureBox_logo.Location = new System.Drawing.Point(1, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(176, 160);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 24;
            this.pictureBox_logo.TabStop = false;
            // 
            // lbl_confirmaRegistro
            // 
            this.lbl_confirmaRegistro.AutoSize = true;
            this.lbl_confirmaRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmaRegistro.Location = new System.Drawing.Point(183, 39);
            this.lbl_confirmaRegistro.Name = "lbl_confirmaRegistro";
            this.lbl_confirmaRegistro.Size = new System.Drawing.Size(337, 19);
            this.lbl_confirmaRegistro.TabIndex = 25;
            this.lbl_confirmaRegistro.Text = "Digite o número de registro do funcionário:";
            // 
            // txt_registro
            // 
            this.txt_registro.BeepOnError = true;
            this.txt_registro.Location = new System.Drawing.Point(187, 73);
            this.txt_registro.Mask = "0000000000";
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(177, 20);
            this.txt_registro.TabIndex = 26;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(322, 113);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(89, 34);
            this.btn_ok.TabIndex = 42;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(431, 113);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 34);
            this.btn_cancelar.TabIndex = 43;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Form_confirmaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(538, 159);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_registro);
            this.Controls.Add(this.lbl_confirmaRegistro);
            this.Controls.Add(this.pictureBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_confirmaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmação";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label lbl_confirmaRegistro;
        private System.Windows.Forms.MaskedTextBox txt_registro;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancelar;
    }
}