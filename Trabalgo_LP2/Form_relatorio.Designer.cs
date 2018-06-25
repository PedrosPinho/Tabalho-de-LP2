namespace Trabalgo_LP2
{
    partial class Form_relatorio
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
            this.cvcliente = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report_cliente1 = new Trabalgo_LP2.Report_cliente();
            this.SuspendLayout();
            // 
            // cvcliente
            // 
            this.cvcliente.ActiveViewIndex = 0;
            this.cvcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvcliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.cvcliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvcliente.Location = new System.Drawing.Point(0, 0);
            this.cvcliente.Name = "cvcliente";
            this.cvcliente.ReportSource = this.Report_cliente1;
            this.cvcliente.Size = new System.Drawing.Size(751, 276);
            this.cvcliente.TabIndex = 0;
            this.cvcliente.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 276);
            this.Controls.Add(this.cvcliente);
            this.Name = "Form_relatorio";
            this.Text = "Form_relatorio";
            this.Load += new System.EventHandler(this.Form_relatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cvcliente;
        private Report_cliente Report_cliente1;
    }
}