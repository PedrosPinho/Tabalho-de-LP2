namespace Trabalgo_LP2
{
    partial class Form_cadastro
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
            this.panel_cadastro = new System.Windows.Forms.Panel();
            this.pictureBox_cadastro = new System.Windows.Forms.PictureBox();
            this.lbl_Cadastro = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_registro = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.panel_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cadastro
            // 
            this.panel_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_cadastro.Controls.Add(this.txt_cpf);
            this.panel_cadastro.Controls.Add(this.btn_cancelar);
            this.panel_cadastro.Controls.Add(this.btn_confirmar);
            this.panel_cadastro.Controls.Add(this.txt_registro);
            this.panel_cadastro.Controls.Add(this.txt_nome);
            this.panel_cadastro.Controls.Add(this.lbl_registro);
            this.panel_cadastro.Controls.Add(this.lbl_cpf);
            this.panel_cadastro.Controls.Add(this.lbl_nome);
            this.panel_cadastro.Controls.Add(this.lbl_Cadastro);
            this.panel_cadastro.Controls.Add(this.pictureBox_cadastro);
            this.panel_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cadastro.Location = new System.Drawing.Point(0, 0);
            this.panel_cadastro.Name = "panel_cadastro";
            this.panel_cadastro.Size = new System.Drawing.Size(389, 180);
            this.panel_cadastro.TabIndex = 0;
            // 
            // pictureBox_cadastro
            // 
            this.pictureBox_cadastro.Image = global::Trabalgo_LP2.Properties.Resources.logo;
            this.pictureBox_cadastro.Location = new System.Drawing.Point(291, 52);
            this.pictureBox_cadastro.Name = "pictureBox_cadastro";
            this.pictureBox_cadastro.Size = new System.Drawing.Size(86, 98);
            this.pictureBox_cadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cadastro.TabIndex = 0;
            this.pictureBox_cadastro.TabStop = false;
            // 
            // lbl_Cadastro
            // 
            this.lbl_Cadastro.AutoSize = true;
            this.lbl_Cadastro.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadastro.Location = new System.Drawing.Point(78, 9);
            this.lbl_Cadastro.Name = "lbl_Cadastro";
            this.lbl_Cadastro.Size = new System.Drawing.Size(256, 26);
            this.lbl_Cadastro.TabIndex = 1;
            this.lbl_Cadastro.Text = "Cadastro de funcionário";
            this.lbl_Cadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(14, 55);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(52, 16);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(14, 81);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(40, 16);
            this.lbl_cpf.TabIndex = 3;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(14, 107);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(72, 16);
            this.lbl_registro.TabIndex = 4;
            this.lbl_registro.Text = "Registro:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(83, 52);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(185, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_registro
            // 
            this.txt_registro.Location = new System.Drawing.Point(83, 104);
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(185, 20);
            this.txt_registro.TabIndex = 7;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.DimGray;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(193, 140);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 8;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(83, 140);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(83, 78);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(185, 20);
            this.txt_cpf.TabIndex = 10;
            // 
            // Form_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 180);
            this.Controls.Add(this.panel_cadastro);
            this.Name = "Form_cadastro";
            this.Text = "Form_cadastro";
            this.panel_cadastro.ResumeLayout(false);
            this.panel_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cadastro;
        private System.Windows.Forms.PictureBox pictureBox_cadastro;
        private System.Windows.Forms.Label lbl_Cadastro;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txt_registro;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
    }
}