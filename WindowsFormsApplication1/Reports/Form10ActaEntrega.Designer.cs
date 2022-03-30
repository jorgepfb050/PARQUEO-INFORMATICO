namespace WindowsFormsApplication1.Reports
{
    partial class Form10ActaEntrega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaAsignacionDesde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnActaEntrega = new DevComponents.DotNetBar.ButtonX();
            this.rbtnAllAsg = new System.Windows.Forms.RadioButton();
            this.rbtnTime = new System.Windows.Forms.RadioButton();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbtActaRetiro = new System.Windows.Forms.RadioButton();
            this.rbtnActaEntrega = new System.Windows.Forms.RadioButton();
            this.gbActaRetiro = new System.Windows.Forms.GroupBox();
            this.btnActaRetiro = new DevComponents.DotNetBar.ButtonX();
            this.DGVEqActa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.rbtnActaRetiroFecha = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtActaRetiro = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.rbtnActaRetiroTodos = new System.Windows.Forms.RadioButton();
            this.gbActaEntrega = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAsignacionDesde)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.gbActaRetiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEqActa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActaRetiro)).BeginInit();
            this.gbActaEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 229;
            this.label1.Text = "Fecha de asignación";
            // 
            // dtFechaAsignacionDesde
            // 
            // 
            // 
            // 
            this.dtFechaAsignacionDesde.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaAsignacionDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionDesde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaAsignacionDesde.ButtonDropDown.Visible = true;
            this.dtFechaAsignacionDesde.IsPopupCalendarOpen = false;
            this.dtFechaAsignacionDesde.Location = new System.Drawing.Point(56, 69);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaAsignacionDesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionDesde.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaAsignacionDesde.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaAsignacionDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaAsignacionDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaAsignacionDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaAsignacionDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaAsignacionDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaAsignacionDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaAsignacionDesde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionDesde.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaAsignacionDesde.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaAsignacionDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaAsignacionDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaAsignacionDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaAsignacionDesde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionDesde.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaAsignacionDesde.Name = "dtFechaAsignacionDesde";
            this.dtFechaAsignacionDesde.Size = new System.Drawing.Size(172, 20);
            this.dtFechaAsignacionDesde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaAsignacionDesde.TabIndex = 228;
            // 
            // btnActaEntrega
            // 
            this.btnActaEntrega.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActaEntrega.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActaEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActaEntrega.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnActaEntrega.Location = new System.Drawing.Point(461, 104);
            this.btnActaEntrega.Name = "btnActaEntrega";
            this.btnActaEntrega.Size = new System.Drawing.Size(160, 21);
            this.btnActaEntrega.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.btnActaEntrega.TabIndex = 230;
            this.btnActaEntrega.Text = "Generar";
            this.btnActaEntrega.Visible = false;
            this.btnActaEntrega.Click += new System.EventHandler(this.btGenerarRepReg1_Click);
            // 
            // rbtnAllAsg
            // 
            this.rbtnAllAsg.AutoSize = true;
            this.rbtnAllAsg.Checked = true;
            this.rbtnAllAsg.Location = new System.Drawing.Point(284, 28);
            this.rbtnAllAsg.Name = "rbtnAllAsg";
            this.rbtnAllAsg.Size = new System.Drawing.Size(162, 17);
            this.rbtnAllAsg.TabIndex = 231;
            this.rbtnAllAsg.TabStop = true;
            this.rbtnAllAsg.Text = "Todos los equipos asignados";
            this.rbtnAllAsg.UseVisualStyleBackColor = true;
            // 
            // rbtnTime
            // 
            this.rbtnTime.AutoSize = true;
            this.rbtnTime.BackColor = System.Drawing.Color.Transparent;
            this.rbtnTime.Location = new System.Drawing.Point(35, 28);
            this.rbtnTime.Name = "rbtnTime";
            this.rbtnTime.Size = new System.Drawing.Size(141, 17);
            this.rbtnTime.TabIndex = 232;
            this.rbtnTime.Text = "Por fecha de Asignación";
            this.rbtnTime.UseVisualStyleBackColor = false;
            this.rbtnTime.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.rbtActaRetiro);
            this.groupPanel1.Controls.Add(this.rbtnActaEntrega);
            this.groupPanel1.Controls.Add(this.gbActaRetiro);
            this.groupPanel1.Controls.Add(this.gbActaEntrega);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(694, 504);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 234;
            // 
            // rbtActaRetiro
            // 
            this.rbtActaRetiro.AutoSize = true;
            this.rbtActaRetiro.BackColor = System.Drawing.Color.Transparent;
            this.rbtActaRetiro.Location = new System.Drawing.Point(10, 162);
            this.rbtActaRetiro.Name = "rbtActaRetiro";
            this.rbtActaRetiro.Size = new System.Drawing.Size(93, 17);
            this.rbtActaRetiro.TabIndex = 236;
            this.rbtActaRetiro.TabStop = true;
            this.rbtActaRetiro.Text = "Acta de Retiro";
            this.rbtActaRetiro.UseVisualStyleBackColor = false;
            this.rbtActaRetiro.Click += new System.EventHandler(this.rbtActaRetiro_Click);
            // 
            // rbtnActaEntrega
            // 
            this.rbtnActaEntrega.AutoSize = true;
            this.rbtnActaEntrega.BackColor = System.Drawing.Color.Transparent;
            this.rbtnActaEntrega.Location = new System.Drawing.Point(10, 4);
            this.rbtnActaEntrega.Name = "rbtnActaEntrega";
            this.rbtnActaEntrega.Size = new System.Drawing.Size(102, 17);
            this.rbtnActaEntrega.TabIndex = 235;
            this.rbtnActaEntrega.TabStop = true;
            this.rbtnActaEntrega.Text = "Acta de Entrega";
            this.rbtnActaEntrega.UseVisualStyleBackColor = false;
            this.rbtnActaEntrega.Click += new System.EventHandler(this.rbtnActaEntrega_Click);
            // 
            // gbActaRetiro
            // 
            this.gbActaRetiro.BackColor = System.Drawing.Color.Transparent;
            this.gbActaRetiro.Controls.Add(this.btnActaRetiro);
            this.gbActaRetiro.Controls.Add(this.DGVEqActa);
            this.gbActaRetiro.Controls.Add(this.rbtnActaRetiroFecha);
            this.gbActaRetiro.Controls.Add(this.label2);
            this.gbActaRetiro.Controls.Add(this.dtActaRetiro);
            this.gbActaRetiro.Controls.Add(this.rbtnActaRetiroTodos);
            this.gbActaRetiro.Location = new System.Drawing.Point(33, 183);
            this.gbActaRetiro.Name = "gbActaRetiro";
            this.gbActaRetiro.Size = new System.Drawing.Size(627, 312);
            this.gbActaRetiro.TabIndex = 234;
            this.gbActaRetiro.TabStop = false;
            // 
            // btnActaRetiro
            // 
            this.btnActaRetiro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActaRetiro.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActaRetiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActaRetiro.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnActaRetiro.Location = new System.Drawing.Point(461, 285);
            this.btnActaRetiro.Name = "btnActaRetiro";
            this.btnActaRetiro.Size = new System.Drawing.Size(160, 21);
            this.btnActaRetiro.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.btnActaRetiro.TabIndex = 237;
            this.btnActaRetiro.Text = "Generar";
            this.btnActaRetiro.Visible = false;
            this.btnActaRetiro.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // DGVEqActa
            // 
            this.DGVEqActa.AllowUserToAddRows = false;
            this.DGVEqActa.AllowUserToDeleteRows = false;
            this.DGVEqActa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.DGVEqActa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVEqActa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVEqActa.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVEqActa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGVEqActa.Location = new System.Drawing.Point(5, 96);
            this.DGVEqActa.Name = "DGVEqActa";
            this.DGVEqActa.ReadOnly = true;
            this.DGVEqActa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVEqActa.Size = new System.Drawing.Size(615, 183);
            this.DGVEqActa.TabIndex = 237;
            // 
            // rbtnActaRetiroFecha
            // 
            this.rbtnActaRetiroFecha.AutoSize = true;
            this.rbtnActaRetiroFecha.BackColor = System.Drawing.Color.Transparent;
            this.rbtnActaRetiroFecha.Location = new System.Drawing.Point(35, 29);
            this.rbtnActaRetiroFecha.Name = "rbtnActaRetiroFecha";
            this.rbtnActaRetiroFecha.Size = new System.Drawing.Size(117, 17);
            this.rbtnActaRetiroFecha.TabIndex = 236;
            this.rbtnActaRetiroFecha.Text = "Por fecha de Retiro";
            this.rbtnActaRetiroFecha.UseVisualStyleBackColor = false;
            this.rbtnActaRetiroFecha.Click += new System.EventHandler(this.rbtnActaRetiroFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 234;
            this.label2.Text = "Fecha de retiro";
            // 
            // dtActaRetiro
            // 
            // 
            // 
            // 
            this.dtActaRetiro.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtActaRetiro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtActaRetiro.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtActaRetiro.ButtonDropDown.Visible = true;
            this.dtActaRetiro.IsPopupCalendarOpen = false;
            this.dtActaRetiro.Location = new System.Drawing.Point(56, 70);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtActaRetiro.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtActaRetiro.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtActaRetiro.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtActaRetiro.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtActaRetiro.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtActaRetiro.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtActaRetiro.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtActaRetiro.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtActaRetiro.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtActaRetiro.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtActaRetiro.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtActaRetiro.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtActaRetiro.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtActaRetiro.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtActaRetiro.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtActaRetiro.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtActaRetiro.MonthCalendar.TodayButtonVisible = true;
            this.dtActaRetiro.Name = "dtActaRetiro";
            this.dtActaRetiro.Size = new System.Drawing.Size(172, 20);
            this.dtActaRetiro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtActaRetiro.TabIndex = 233;
            this.dtActaRetiro.Visible = false;
            this.dtActaRetiro.Leave += new System.EventHandler(this.dtActaRetiro_Leave);
            // 
            // rbtnActaRetiroTodos
            // 
            this.rbtnActaRetiroTodos.AutoSize = true;
            this.rbtnActaRetiroTodos.Location = new System.Drawing.Point(284, 29);
            this.rbtnActaRetiroTodos.Name = "rbtnActaRetiroTodos";
            this.rbtnActaRetiroTodos.Size = new System.Drawing.Size(159, 17);
            this.rbtnActaRetiroTodos.TabIndex = 235;
            this.rbtnActaRetiroTodos.Text = "Todos los equipos Retirados";
            this.rbtnActaRetiroTodos.UseVisualStyleBackColor = true;
            this.rbtnActaRetiroTodos.Click += new System.EventHandler(this.rbtnActaRetiroTodos_Click);
            // 
            // gbActaEntrega
            // 
            this.gbActaEntrega.BackColor = System.Drawing.Color.Transparent;
            this.gbActaEntrega.Controls.Add(this.rbtnTime);
            this.gbActaEntrega.Controls.Add(this.label1);
            this.gbActaEntrega.Controls.Add(this.dtFechaAsignacionDesde);
            this.gbActaEntrega.Controls.Add(this.rbtnAllAsg);
            this.gbActaEntrega.Controls.Add(this.btnActaEntrega);
            this.gbActaEntrega.Location = new System.Drawing.Point(33, 25);
            this.gbActaEntrega.Name = "gbActaEntrega";
            this.gbActaEntrega.Size = new System.Drawing.Size(627, 131);
            this.gbActaEntrega.TabIndex = 233;
            this.gbActaEntrega.TabStop = false;
            this.gbActaEntrega.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form10ActaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 504);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form10ActaEntrega";
            this.Text = "Acta de Entrega y Retiro";
            this.Load += new System.EventHandler(this.Form10ActaEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAsignacionDesde)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.gbActaRetiro.ResumeLayout(false);
            this.gbActaRetiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEqActa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActaRetiro)).EndInit();
            this.gbActaEntrega.ResumeLayout(false);
            this.gbActaEntrega.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaAsignacionDesde;
        private DevComponents.DotNetBar.ButtonX btnActaEntrega;
        private System.Windows.Forms.RadioButton rbtnAllAsg;
        private System.Windows.Forms.RadioButton rbtnTime;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.GroupBox gbActaRetiro;
        private System.Windows.Forms.GroupBox gbActaEntrega;
        private System.Windows.Forms.RadioButton rbtActaRetiro;
        private System.Windows.Forms.RadioButton rbtnActaEntrega;
        private System.Windows.Forms.RadioButton rbtnActaRetiroFecha;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtActaRetiro;
        private System.Windows.Forms.RadioButton rbtnActaRetiroTodos;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGVEqActa;
        private DevComponents.DotNetBar.ButtonX btnActaRetiro;

    }
}