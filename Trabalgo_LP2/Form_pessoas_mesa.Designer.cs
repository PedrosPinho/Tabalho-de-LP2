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
            this.SuspendLayout();
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(115, 48);
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
            this.lbl_info.Location = new System.Drawing.Point(12, 20);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(255, 20);
            this.lbl_info.TabIndex = 15;
            this.lbl_info.Text = "Informe o numero de pessoas da mesa:";
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
            this.comboBox_num.Location = new System.Drawing.Point(16, 56);
            this.comboBox_num.Name = "comboBox_num";
            this.comboBox_num.Size = new System.Drawing.Size(69, 21);
            this.comboBox_num.TabIndex = 14;
            // 
            // txt_num_mesa
            // 
            this.txt_num_mesa.Location = new System.Drawing.Point(273, 22);
            this.txt_num_mesa.Name = "txt_num_mesa";
            this.txt_num_mesa.Size = new System.Drawing.Size(28, 20);
            this.txt_num_mesa.TabIndex = 17;
            // 
            // Form_pessoas_mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 120);
            this.Controls.Add(this.txt_num_mesa);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.comboBox_num);
            this.Name = "Form_pessoas_mesa";
            this.Text = "Form_pessoas_mesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ComboBox comboBox_num;
        private System.Windows.Forms.TextBox txt_num_mesa;
    }
}