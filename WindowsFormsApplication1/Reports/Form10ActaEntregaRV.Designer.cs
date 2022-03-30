namespace WindowsFormsApplication1.Reports
{
    partial class Form10ActaEntregaRV
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
            this.RVActaEntrega = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RVActaEntrega
            // 
            this.RVActaEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RVActaEntrega.Location = new System.Drawing.Point(0, 0);
            this.RVActaEntrega.Name = "RVActaEntrega";
            this.RVActaEntrega.Size = new System.Drawing.Size(886, 475);
            this.RVActaEntrega.TabIndex = 0;
            // 
            // Form10ActaEntregaRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 475);
            this.Controls.Add(this.RVActaEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form10ActaEntregaRV";
            this.Load += new System.EventHandler(this.Form10ActaEntregaRV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RVActaEntrega;


    }
}