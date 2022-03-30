namespace WindowsFormsApplication1.Reports
{
    partial class Asignacion_equipo_Rsm
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
            this.rvAsignacionEquipo_Rsm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvAsignacionEquipo_Rsm
            // 
            this.rvAsignacionEquipo_Rsm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvAsignacionEquipo_Rsm.Location = new System.Drawing.Point(0, 0);
            this.rvAsignacionEquipo_Rsm.Name = "rvAsignacionEquipo_Rsm";
            this.rvAsignacionEquipo_Rsm.Size = new System.Drawing.Size(843, 273);
            this.rvAsignacionEquipo_Rsm.TabIndex = 0;
            // 
            // Asignacion_equipo_Rsm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 273);
            this.Controls.Add(this.rvAsignacionEquipo_Rsm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Asignacion_equipo_Rsm";
            this.Text = "Asignacion_equipo_Rsm";
            this.Load += new System.EventHandler(this.Asignacion_equipo_Rsm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rvAsignacionEquipo_Rsm;

    }
}