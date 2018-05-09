namespace Trabalgo_LP2
{
    partial class Form_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logoff = new System.Windows.Forms.Button();
            this.lbl_home = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_fornecedor = new System.Windows.Forms.Button();
            this.btn_fidelidade = new System.Windows.Forms.Button();
            this.btn_cardapio = new System.Windows.Forms.Button();
            this.btn_mesa = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_funcionario = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.lbl_home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_logoff);
            this.panel1.Controls.Add(this.pictureBox_logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 103);
            this.panel1.TabIndex = 0;
            // 
            // btn_logoff
            // 
            this.btn_logoff.BackColor = System.Drawing.Color.Black;
            this.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logoff.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_logoff.ForeColor = System.Drawing.Color.White;
            this.btn_logoff.Location = new System.Drawing.Point(489, 31);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(109, 39);
            this.btn_logoff.TabIndex = 3;
            this.btn_logoff.Text = "Logoff";
            this.btn_logoff.UseVisualStyleBackColor = false;
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.Location = new System.Drawing.Point(292, 31);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(99, 42);
            this.lbl_home.TabIndex = 2;
            this.lbl_home.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_fornecedor);
            this.panel2.Controls.Add(this.btn_fidelidade);
            this.panel2.Controls.Add(this.btn_cardapio);
            this.panel2.Controls.Add(this.btn_mesa);
            this.panel2.Controls.Add(this.btn_cliente);
            this.panel2.Controls.Add(this.btn_funcionario);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 470);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_fornecedor
            // 
            this.btn_fornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fornecedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fornecedor.ForeColor = System.Drawing.Color.White;
            this.btn_fornecedor.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_fornecedor.Location = new System.Drawing.Point(312, 374);
            this.btn_fornecedor.Name = "btn_fornecedor";
            this.btn_fornecedor.Size = new System.Drawing.Size(164, 65);
            this.btn_fornecedor.TabIndex = 6;
            this.btn_fornecedor.Text = "Fornecedor";
            this.btn_fornecedor.UseVisualStyleBackColor = false;
            // 
            // btn_fidelidade
            // 
            this.btn_fidelidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_fidelidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fidelidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fidelidade.ForeColor = System.Drawing.Color.White;
            this.btn_fidelidade.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_fidelidade.Location = new System.Drawing.Point(106, 374);
            this.btn_fidelidade.Name = "btn_fidelidade";
            this.btn_fidelidade.Size = new System.Drawing.Size(164, 65);
            this.btn_fidelidade.TabIndex = 5;
            this.btn_fidelidade.Text = "Fidelidade";
            this.btn_fidelidade.UseVisualStyleBackColor = false;
            // 
            // btn_cardapio
            // 
            this.btn_cardapio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_cardapio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cardapio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cardapio.ForeColor = System.Drawing.Color.White;
            this.btn_cardapio.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cardapio.Location = new System.Drawing.Point(312, 272);
            this.btn_cardapio.Name = "btn_cardapio";
            this.btn_cardapio.Size = new System.Drawing.Size(164, 65);
            this.btn_cardapio.TabIndex = 4;
            this.btn_cardapio.Text = "Cardápio";
            this.btn_cardapio.UseVisualStyleBackColor = false;
            // 
            // btn_mesa
            // 
            this.btn_mesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_mesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mesa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mesa.ForeColor = System.Drawing.Color.White;
            this.btn_mesa.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_mesa.Location = new System.Drawing.Point(106, 271);
            this.btn_mesa.Name = "btn_mesa";
            this.btn_mesa.Size = new System.Drawing.Size(164, 65);
            this.btn_mesa.TabIndex = 3;
            this.btn_mesa.Text = "Mesa";
            this.btn_mesa.UseVisualStyleBackColor = false;
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cliente.Location = new System.Drawing.Point(312, 165);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(164, 65);
            this.btn_cliente.TabIndex = 2;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_funcionario
            // 
            this.btn_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_funcionario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_funcionario.ForeColor = System.Drawing.Color.White;
            this.btn_funcionario.Location = new System.Drawing.Point(106, 165);
            this.btn_funcionario.Margin = new System.Windows.Forms.Padding(1);
            this.btn_funcionario.Name = "btn_funcionario";
            this.btn_funcionario.Size = new System.Drawing.Size(164, 65);
            this.btn_funcionario.TabIndex = 1;
            this.btn_funcionario.Text = "Funcionário";
            this.btn_funcionario.UseVisualStyleBackColor = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Trabalgo_LP2.Properties.Resources.logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 6);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(109, 97);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 470);
            this.Controls.Add(this.panel2);
            this.Name = "Form_menu";
            this.Text = "Form_menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.Button btn_fidelidade;
        private System.Windows.Forms.Button btn_cardapio;
        private System.Windows.Forms.Button btn_mesa;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_funcionario;
        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.Button btn_fornecedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}