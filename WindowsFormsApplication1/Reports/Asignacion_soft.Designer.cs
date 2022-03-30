namespace WindowsFormsApplication1.Reports
{
    partial class Asignacion_soft
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGenerarRepSof = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rbRegTodos = new System.Windows.Forms.RadioButton();
            this.rbRegSedeInstancia = new System.Windows.Forms.RadioButton();
            this.rbRegEquipo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rvAsignacionSof = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btGenerarRepSof);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.comboBoxEx2);
            this.groupBox1.Controls.Add(this.comboBoxEx1);
            this.groupBox1.Controls.Add(this.rbRegTodos);
            this.groupBox1.Controls.Add(this.rbRegSedeInstancia);
            this.groupBox1.Controls.Add(this.rbRegEquipo);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btGenerarRepSof
            // 
            this.btGenerarRepSof.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGenerarRepSof.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btGenerarRepSof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenerarRepSof.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btGenerarRepSof.Image = global::WindowsFormsApplication1.Properties.Resources.enter;
            this.btGenerarRepSof.Location = new System.Drawing.Point(764, 19);
            this.btGenerarRepSof.Name = "btGenerarRepSof";
            this.btGenerarRepSof.Size = new System.Drawing.Size(101, 68);
            this.btGenerarRepSof.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btGenerarRepSof.TabIndex = 137;
            this.btGenerarRepSof.Click += new System.EventHandler(this.btGenerarRepSof_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(365, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "labelX2";
            this.labelX2.Visible = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(365, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "labelX1";
            this.labelX1.Visible = false;
            // 
            // comboBoxEx2
            // 
            this.comboBoxEx2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEx2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEx2.DisplayMember = "Text";
            this.comboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx2.FormattingEnabled = true;
            this.comboBoxEx2.ItemHeight = 15;
            this.comboBoxEx2.Location = new System.Drawing.Point(462, 58);
            this.comboBoxEx2.Name = "comboBoxEx2";
            this.comboBoxEx2.Size = new System.Drawing.Size(296, 21);
            this.comboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx2.TabIndex = 9;
            this.comboBoxEx2.Visible = false;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEx1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Location = new System.Drawing.Point(462, 28);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(296, 21);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 8;
            this.comboBoxEx1.Visible = false;
            // 
            // rbRegTodos
            // 
            this.rbRegTodos.AutoSize = true;
            this.rbRegTodos.Location = new System.Drawing.Point(16, 28);
            this.rbRegTodos.Name = "rbRegTodos";
            this.rbRegTodos.Size = new System.Drawing.Size(116, 17);
            this.rbRegTodos.TabIndex = 4;
            this.rbRegTodos.TabStop = true;
            this.rbRegTodos.Text = "Todos Los Rgistros";
            this.rbRegTodos.UseVisualStyleBackColor = true;
            this.rbRegTodos.Click += new System.EventHandler(this.rbRegTodos_Click);
            // 
            // rbRegSedeInstancia
            // 
            this.rbRegSedeInstancia.AutoSize = true;
            this.rbRegSedeInstancia.Location = new System.Drawing.Point(16, 55);
            this.rbRegSedeInstancia.Name = "rbRegSedeInstancia";
            this.rbRegSedeInstancia.Size = new System.Drawing.Size(122, 17);
            this.rbRegSedeInstancia.TabIndex = 3;
            this.rbRegSedeInstancia.TabStop = true;
            this.rbRegSedeInstancia.Text = "Por sede e Instancia";
            this.rbRegSedeInstancia.UseVisualStyleBackColor = true;
            this.rbRegSedeInstancia.Visible = false;
            this.rbRegSedeInstancia.Click += new System.EventHandler(this.rbRegSedeInstancia_Click);
            // 
            // rbRegEquipo
            // 
            this.rbRegEquipo.AutoSize = true;
            this.rbRegEquipo.Location = new System.Drawing.Point(150, 31);
            this.rbRegEquipo.Name = "rbRegEquipo";
            this.rbRegEquipo.Size = new System.Drawing.Size(77, 17);
            this.rbRegEquipo.TabIndex = 2;
            this.rbRegEquipo.TabStop = true;
            this.rbRegEquipo.Text = "Por Equipo";
            this.rbRegEquipo.UseVisualStyleBackColor = true;
            this.rbRegEquipo.Click += new System.EventHandler(this.rbRegEquipo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rvAsignacionSof);
            this.groupBox2.Location = new System.Drawing.Point(11, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1123, 331);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rvAsignacionSof
            // 
            this.rvAsignacionSof.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvAsignacionSof.Location = new System.Drawing.Point(13, 19);
            this.rvAsignacionSof.Name = "rvAsignacionSof";
            this.rvAsignacionSof.Size = new System.Drawing.Size(1091, 306);
            this.rvAsignacionSof.TabIndex = 0;
            // 
            // Asignacion_soft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Asignacion_soft";
            this.Text = "Asignacion_soft";
            this.Load += new System.EventHandler(this.Asignacion_soft_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btGenerarRepSof;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.RadioButton rbRegTodos;
        private System.Windows.Forms.RadioButton rbRegSedeInstancia;
        private System.Windows.Forms.RadioButton rbRegEquipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rvAsignacionSof;
    }
}