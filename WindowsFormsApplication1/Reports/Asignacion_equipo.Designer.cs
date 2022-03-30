namespace WindowsFormsApplication1.Reports
{
    partial class Asignacion_equipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnioAntig = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label103 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDetalladoAE = new System.Windows.Forms.RadioButton();
            this.rbResumenAE = new System.Windows.Forms.RadioButton();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx4 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rbUnidadOrganicaArea = new System.Windows.Forms.RadioButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx3 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rbEquip = new System.Windows.Forms.RadioButton();
            this.btGenerarRepReg1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rbRegPorsona = new System.Windows.Forms.RadioButton();
            this.rbRegTodos = new System.Windows.Forms.RadioButton();
            this.rbRegSedeInstancia = new System.Windows.Forms.RadioButton();
            this.rbRegCategoria = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rvAsignacionEquipo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAnioAntig);
            this.groupBox1.Controls.Add(this.label103);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.comboBoxEx4);
            this.groupBox1.Controls.Add(this.rbUnidadOrganicaArea);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.comboBoxEx3);
            this.groupBox1.Controls.Add(this.rbEquip);
            this.groupBox1.Controls.Add(this.btGenerarRepReg1);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.comboBoxEx2);
            this.groupBox1.Controls.Add(this.comboBoxEx1);
            this.groupBox1.Controls.Add(this.rbRegPorsona);
            this.groupBox1.Controls.Add(this.rbRegTodos);
            this.groupBox1.Controls.Add(this.rbRegSedeInstancia);
            this.groupBox1.Controls.Add(this.rbRegCategoria);
            this.groupBox1.Location = new System.Drawing.Point(1, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 373;
            this.label1.Text = "años a mas";
            // 
            // tbAnioAntig
            // 
            // 
            // 
            // 
            this.tbAnioAntig.Border.Class = "TextBoxBorder";
            this.tbAnioAntig.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAnioAntig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAnioAntig.Location = new System.Drawing.Point(330, 103);
            this.tbAnioAntig.Name = "tbAnioAntig";
            this.tbAnioAntig.PreventEnterBeep = true;
            this.tbAnioAntig.Size = new System.Drawing.Size(33, 20);
            this.tbAnioAntig.TabIndex = 371;
            this.tbAnioAntig.Text = "0";
            this.tbAnioAntig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnioAntig_KeyPress);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(213, 107);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(108, 13);
            this.label103.TabIndex = 372;
            this.label103.Text = "Años de auntiguedad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDetalladoAE);
            this.panel1.Controls.Add(this.rbResumenAE);
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 26);
            this.panel1.TabIndex = 148;
            // 
            // rbDetalladoAE
            // 
            this.rbDetalladoAE.AutoSize = true;
            this.rbDetalladoAE.Location = new System.Drawing.Point(14, 4);
            this.rbDetalladoAE.Name = "rbDetalladoAE";
            this.rbDetalladoAE.Size = new System.Drawing.Size(89, 17);
            this.rbDetalladoAE.TabIndex = 6;
            this.rbDetalladoAE.TabStop = true;
            this.rbDetalladoAE.Text = "DETALLADO";
            this.rbDetalladoAE.UseVisualStyleBackColor = true;
            this.rbDetalladoAE.Click += new System.EventHandler(this.rbDetalladoAE_Click);
            // 
            // rbResumenAE
            // 
            this.rbResumenAE.AutoSize = true;
            this.rbResumenAE.Location = new System.Drawing.Point(115, 4);
            this.rbResumenAE.Name = "rbResumenAE";
            this.rbResumenAE.Size = new System.Drawing.Size(79, 17);
            this.rbResumenAE.TabIndex = 5;
            this.rbResumenAE.TabStop = true;
            this.rbResumenAE.Text = "RESUMEN";
            this.rbResumenAE.UseVisualStyleBackColor = true;
            this.rbResumenAE.Click += new System.EventHandler(this.rbResumenAE_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(445, 89);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(137, 23);
            this.labelX4.TabIndex = 143;
            this.labelX4.Text = "labelX4";
            this.labelX4.Visible = false;
            // 
            // comboBoxEx4
            // 
            this.comboBoxEx4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEx4.DisplayMember = "Text";
            this.comboBoxEx4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx4.DropDownWidth = 800;
            this.comboBoxEx4.FormattingEnabled = true;
            this.comboBoxEx4.ItemHeight = 15;
            this.comboBoxEx4.Location = new System.Drawing.Point(601, 97);
            this.comboBoxEx4.Name = "comboBoxEx4";
            this.comboBoxEx4.Size = new System.Drawing.Size(470, 21);
            this.comboBoxEx4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx4.TabIndex = 142;
            this.comboBoxEx4.Visible = false;
            // 
            // rbUnidadOrganicaArea
            // 
            this.rbUnidadOrganicaArea.AutoSize = true;
            this.rbUnidadOrganicaArea.Location = new System.Drawing.Point(27, 82);
            this.rbUnidadOrganicaArea.Name = "rbUnidadOrganicaArea";
            this.rbUnidadOrganicaArea.Size = new System.Drawing.Size(188, 17);
            this.rbUnidadOrganicaArea.TabIndex = 141;
            this.rbUnidadOrganicaArea.TabStop = true;
            this.rbUnidadOrganicaArea.Text = "Por Sede, Unidad Orgánica y Area";
            this.rbUnidadOrganicaArea.UseVisualStyleBackColor = true;
            this.rbUnidadOrganicaArea.Click += new System.EventHandler(this.rbUnidadOrganicaArea_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(445, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(137, 23);
            this.labelX3.TabIndex = 140;
            this.labelX3.Text = "labelX3";
            this.labelX3.Visible = false;
            // 
            // comboBoxEx3
            // 
            this.comboBoxEx3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEx3.DisplayMember = "Text";
            this.comboBoxEx3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx3.DropDownWidth = 800;
            this.comboBoxEx3.FormattingEnabled = true;
            this.comboBoxEx3.ItemHeight = 15;
            this.comboBoxEx3.Location = new System.Drawing.Point(601, 69);
            this.comboBoxEx3.Name = "comboBoxEx3";
            this.comboBoxEx3.Size = new System.Drawing.Size(470, 21);
            this.comboBoxEx3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx3.TabIndex = 139;
            this.comboBoxEx3.Visible = false;
            // 
            // rbEquip
            // 
            this.rbEquip.AutoSize = true;
            this.rbEquip.Location = new System.Drawing.Point(216, 83);
            this.rbEquip.Name = "rbEquip";
            this.rbEquip.Size = new System.Drawing.Size(77, 17);
            this.rbEquip.TabIndex = 138;
            this.rbEquip.TabStop = true;
            this.rbEquip.Text = "Por Equipo";
            this.rbEquip.UseVisualStyleBackColor = true;
            this.rbEquip.Click += new System.EventHandler(this.rbCpuComponentes_Click);
            // 
            // btGenerarRepReg1
            // 
            this.btGenerarRepReg1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGenerarRepReg1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGenerarRepReg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenerarRepReg1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btGenerarRepReg1.Location = new System.Drawing.Point(26, 103);
            this.btGenerarRepReg1.Name = "btGenerarRepReg1";
            this.btGenerarRepReg1.Size = new System.Drawing.Size(83, 21);
            this.btGenerarRepReg1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.btGenerarRepReg1.TabIndex = 137;
            this.btGenerarRepReg1.Text = "Generar";
            this.btGenerarRepReg1.Click += new System.EventHandler(this.btGenerarRepReg1_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(445, 39);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(137, 23);
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
            this.labelX1.Location = new System.Drawing.Point(445, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(137, 23);
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
            this.comboBoxEx2.DropDownWidth = 800;
            this.comboBoxEx2.FormattingEnabled = true;
            this.comboBoxEx2.ItemHeight = 15;
            this.comboBoxEx2.Location = new System.Drawing.Point(601, 41);
            this.comboBoxEx2.Name = "comboBoxEx2";
            this.comboBoxEx2.Size = new System.Drawing.Size(470, 21);
            this.comboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx2.TabIndex = 9;
            this.comboBoxEx2.Visible = false;
            this.comboBoxEx2.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx2_SelectedIndexChanged);
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEx1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownWidth = 800;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Location = new System.Drawing.Point(601, 15);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(470, 21);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 8;
            this.comboBoxEx1.Visible = false;
            this.comboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
            this.comboBoxEx1.TextChanged += new System.EventHandler(this.comboBoxEx1_TextChanged);
            this.comboBoxEx1.Click += new System.EventHandler(this.comboBoxEx1_Click);
            this.comboBoxEx1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxEx1_KeyUp);
            // 
            // rbRegPorsona
            // 
            this.rbRegPorsona.AutoSize = true;
            this.rbRegPorsona.Location = new System.Drawing.Point(216, 42);
            this.rbRegPorsona.Name = "rbRegPorsona";
            this.rbRegPorsona.Size = new System.Drawing.Size(83, 17);
            this.rbRegPorsona.TabIndex = 7;
            this.rbRegPorsona.TabStop = true;
            this.rbRegPorsona.Text = "Por Persona";
            this.rbRegPorsona.UseVisualStyleBackColor = true;
            this.rbRegPorsona.Click += new System.EventHandler(this.rbRegPorsona_Click);
            // 
            // rbRegTodos
            // 
            this.rbRegTodos.AutoSize = true;
            this.rbRegTodos.Location = new System.Drawing.Point(27, 39);
            this.rbRegTodos.Name = "rbRegTodos";
            this.rbRegTodos.Size = new System.Drawing.Size(122, 17);
            this.rbRegTodos.TabIndex = 4;
            this.rbRegTodos.TabStop = true;
            this.rbRegTodos.Text = "Todos Los Registros";
            this.rbRegTodos.UseVisualStyleBackColor = true;
            this.rbRegTodos.Click += new System.EventHandler(this.rbRegTodos_Click);
            // 
            // rbRegSedeInstancia
            // 
            this.rbRegSedeInstancia.AutoSize = true;
            this.rbRegSedeInstancia.Location = new System.Drawing.Point(27, 60);
            this.rbRegSedeInstancia.Name = "rbRegSedeInstancia";
            this.rbRegSedeInstancia.Size = new System.Drawing.Size(124, 17);
            this.rbRegSedeInstancia.TabIndex = 3;
            this.rbRegSedeInstancia.TabStop = true;
            this.rbRegSedeInstancia.Text = "Por Sede e Instancia";
            this.rbRegSedeInstancia.UseVisualStyleBackColor = true;
            this.rbRegSedeInstancia.Click += new System.EventHandler(this.rbRegSedeInstancia_Click);
            // 
            // rbRegCategoria
            // 
            this.rbRegCategoria.AutoSize = true;
            this.rbRegCategoria.Location = new System.Drawing.Point(216, 64);
            this.rbRegCategoria.Name = "rbRegCategoria";
            this.rbRegCategoria.Size = new System.Drawing.Size(89, 17);
            this.rbRegCategoria.TabIndex = 2;
            this.rbRegCategoria.TabStop = true;
            this.rbRegCategoria.Text = "Por Categoria";
            this.rbRegCategoria.UseVisualStyleBackColor = true;
            this.rbRegCategoria.Click += new System.EventHandler(this.rbRegCategoria_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rvAsignacionEquipo);
            this.groupBox2.Location = new System.Drawing.Point(1, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1247, 416);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rvAsignacionEquipo
            // 
            this.rvAsignacionEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvAsignacionEquipo.Location = new System.Drawing.Point(16, 37);
            this.rvAsignacionEquipo.Name = "rvAsignacionEquipo";
            this.rvAsignacionEquipo.Size = new System.Drawing.Size(1209, 361);
            this.rvAsignacionEquipo.TabIndex = 0;
            // 
            // Asignacion_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Asignacion_equipo";
            this.Text = "asignacion_equipo";
            this.Load += new System.EventHandler(this.Asignacion_equipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public Microsoft.Reporting.WinForms.ReportViewer rvAsignacionEquipo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.RadioButton rbRegPorsona;
        private System.Windows.Forms.RadioButton rbRegTodos;
        private System.Windows.Forms.RadioButton rbRegSedeInstancia;
        private System.Windows.Forms.RadioButton rbRegCategoria;
        private DevComponents.DotNetBar.ButtonX btGenerarRepReg1;
        private System.Windows.Forms.RadioButton rbEquip;
        public System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx3;
        private System.Windows.Forms.RadioButton rbUnidadOrganicaArea;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDetalladoAE;
        private System.Windows.Forms.RadioButton rbResumenAE;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAnioAntig;
        private System.Windows.Forms.Label label103;
    }
}