namespace WindowsFormsApplication1.Reports
{
    partial class Form11MovEqRep
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
            this.ReportMovEqui = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportMovEqui
            // 
            this.ReportMovEqui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportMovEqui.Location = new System.Drawing.Point(0, 0);
            this.ReportMovEqui.Name = "ReportMovEqui";
            this.ReportMovEqui.Size = new System.Drawing.Size(897, 479);
            this.ReportMovEqui.TabIndex = 0;
            // 
            // Form11MovEqRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.ReportMovEqui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form11MovEqRep";
            this.Text = "Form11MovEqRep";
            this.Load += new System.EventHandler(this.Form11MovEqRep_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer ReportMovEqui;

    }
}