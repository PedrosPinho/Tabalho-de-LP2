namespace Trabalgo_LP2
{
    partial class Form_pessoas_mesa
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
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.comboBox_num = new System.Windows.Forms.ComboBox();
            this.txt_num_mesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(168, 76);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(89, 34);
            this.btn_confirmar.TabIndex = 16;
            this.btn_confirmar.Text = "Cofirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(144, 49);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(65, 20);
            this.lbl_info.TabIndex = 15;
            this.lbl_info.Text = "Pessoas:";
            // 
            // comboBox_num
            // 
            this.comboBox_num.FormattingEnabled = true;
            this.comboBox_num.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.comboBox_num.Location = new System.Drawing.Point(213, 48);
            this.comboBox_num.Name = "comboBox_num";
            this.comboBox_num.Size = new System.Drawing.Size(56, 21);
            this.comboBox_num.TabIndex = 14;
            // 
            // txt_num_mesa
            // 
            this.txt_num_mesa.Location = new System.Drawing.Point(213, 18);
            this.txt_num_mesa.Name = "txt_num_mesa";
            this.txt_num_mesa.Size = new System.Drawing.Size(28, 20);
            this.txt_num_mesa.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mesa:";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.Logonovo1;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 11);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(126, 97);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 19;
            this.pictureBox_logo.TabStop = false;
            // 
            // Form_pessoas_mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(296, 120);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num_mesa);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.comboBox_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_pessoas_mesa";
            this.Text = "Form_pessoas_mesa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ComboBox comboBox_num;
        private System.Windows.Forms.TextBox txt_num_mesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_logo;
    }
}