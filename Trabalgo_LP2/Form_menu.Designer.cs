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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_logoff = new System.Windows.Forms.Button();
            this.btn_fidelidade = new System.Windows.Forms.Button();
            this.btn_cardapio = new System.Windows.Forms.Button();
            this.btn_mesa = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_funcionario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_menu);
            this.panel1.Controls.Add(this.btn_logoff);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 103);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalgo_LP2.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(504, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_menu
            // 
            this.lbl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_menu.Location = new System.Drawing.Point(566, 10);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(208, 77);
            this.lbl_menu.TabIndex = 2;
            this.lbl_menu.Text = "Menu";
            // 
            // btn_logoff
            // 
            this.btn_logoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_logoff.BackColor = System.Drawing.Color.Black;
            this.btn_logoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logoff.BackgroundImage")));
            this.btn_logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logoff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logoff.ForeColor = System.Drawing.Color.White;
            this.btn_logoff.Location = new System.Drawing.Point(1088, 34);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(113, 36);
            this.btn_logoff.TabIndex = 3;
            this.btn_logoff.Text = "Logoff";
            this.btn_logoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logoff.UseVisualStyleBackColor = false;
            this.btn_logoff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // btn_fidelidade
            // 
            this.btn_fidelidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fidelidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_fidelidade.BackgroundImage = global::Trabalgo_LP2.Properties.Resources.fidelidade;
            this.btn_fidelidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fidelidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fidelidade.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fidelidade.ForeColor = System.Drawing.Color.White;
            this.btn_fidelidade.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_fidelidade.Location = new System.Drawing.Point(471, 406);
            this.btn_fidelidade.Name = "btn_fidelidade";
            this.btn_fidelidade.Size = new System.Drawing.Size(245, 108);
            this.btn_fidelidade.TabIndex = 12;
            this.btn_fidelidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fidelidade.UseVisualStyleBackColor = false;
            this.btn_fidelidade.Click += new System.EventHandler(this.btn_fidelidade_Click);
            // 
            // btn_cardapio
            // 
            this.btn_cardapio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cardapio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_cardapio.BackgroundImage = global::Trabalgo_LP2.Properties.Resources.cardapio;
            this.btn_cardapio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cardapio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cardapio.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cardapio.ForeColor = System.Drawing.Color.White;
            this.btn_cardapio.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cardapio.Location = new System.Drawing.Point(635, 269);
            this.btn_cardapio.Name = "btn_cardapio";
            this.btn_cardapio.Size = new System.Drawing.Size(245, 108);
            this.btn_cardapio.TabIndex = 11;
            this.btn_cardapio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cardapio.UseVisualStyleBackColor = false;
            this.btn_cardapio.Click += new System.EventHandler(this.btn_cardapio_Click);
            // 
            // btn_mesa
            // 
            this.btn_mesa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_mesa.BackgroundImage = global::Trabalgo_LP2.Properties.Resources.mesas;
            this.btn_mesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_mesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mesa.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mesa.ForeColor = System.Drawing.Color.White;
            this.btn_mesa.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_mesa.Location = new System.Drawing.Point(312, 269);
            this.btn_mesa.Name = "btn_mesa";
            this.btn_mesa.Size = new System.Drawing.Size(245, 108);
            this.btn_mesa.TabIndex = 10;
            this.btn_mesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mesa.UseVisualStyleBackColor = false;
            this.btn_mesa.Click += new System.EventHandler(this.btn_mesa_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_cliente.BackgroundImage = global::Trabalgo_LP2.Properties.Resources.cliente;
            this.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cliente.Location = new System.Drawing.Point(635, 135);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(245, 108);
            this.btn_cliente.TabIndex = 9;
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_funcionario
            // 
            this.btn_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btn_funcionario.BackgroundImage = global::Trabalgo_LP2.Properties.Resources.funcionario;
            this.btn_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_funcionario.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_funcionario.FlatAppearance.BorderSize = 10;
            this.btn_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_funcionario.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_funcionario.ForeColor = System.Drawing.Color.White;
            this.btn_funcionario.Location = new System.Drawing.Point(312, 135);
            this.btn_funcionario.Margin = new System.Windows.Forms.Padding(1);
            this.btn_funcionario.Name = "btn_funcionario";
            this.btn_funcionario.Size = new System.Drawing.Size(245, 108);
            this.btn_funcionario.TabIndex = 8;
            this.btn_funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_funcionario.UseVisualStyleBackColor = false;
            this.btn_funcionario.Click += new System.EventHandler(this.btn_funcionario_Click);
            // 
            // Form_menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_fidelidade);
            this.Controls.Add(this.btn_cardapio);
            this.Controls.Add(this.btn_mesa);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_funcionario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_menu";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_fidelidade;
        private System.Windows.Forms.Button btn_cardapio;
        private System.Windows.Forms.Button btn_mesa;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_funcionario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}