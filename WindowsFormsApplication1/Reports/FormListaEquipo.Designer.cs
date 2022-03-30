namespace WindowsFormsApplication1.Reports
{
    partial class FormListaEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.cod_equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip_equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_control_patrimonial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_orden_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscarEquipo = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipo.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_equipo,
            this.nombre,
            this.ip_equipo,
            this.marca,
            this.modelo,
            this.procesador,
            this.nro_serie,
            this.nro_control_patrimonial,
            this.anio_adquisicion,
            this.nro_orden_compra,
            this.observacion,
            this.activo,
            this.cod_categoria,
            this.Column2,
            this.Column56,
            this.Column57});
            this.dgvEquipo.Location = new System.Drawing.Point(-2, 129);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            this.dgvEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipo.Size = new System.Drawing.Size(1007, 317);
            this.dgvEquipo.TabIndex = 12;
            this.dgvEquipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellDoubleClick);
            // 
            // cod_equipo
            // 
            this.cod_equipo.DataPropertyName = "cod_equipo";
            this.cod_equipo.HeaderText = "Cod Equipo";
            this.cod_equipo.Name = "cod_equipo";
            this.cod_equipo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "equipo";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // ip_equipo
            // 
            this.ip_equipo.DataPropertyName = "ip_equipo";
            this.ip_equipo.HeaderText = "IP equipo";
            this.ip_equipo.Name = "ip_equipo";
            this.ip_equipo.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // procesador
            // 
            this.procesador.DataPropertyName = "procesador";
            this.procesador.HeaderText = "Procesador";
            this.procesador.Name = "procesador";
            this.procesador.ReadOnly = true;
            // 
            // nro_serie
            // 
            this.nro_serie.DataPropertyName = "nro_serie";
            this.nro_serie.HeaderText = "Nro_serie";
            this.nro_serie.Name = "nro_serie";
            this.nro_serie.ReadOnly = true;
            // 
            // nro_control_patrimonial
            // 
            this.nro_control_patrimonial.DataPropertyName = "nro_control_patrimonial";
            this.nro_control_patrimonial.HeaderText = "Nro Control Patrimonial";
            this.nro_control_patrimonial.Name = "nro_control_patrimonial";
            this.nro_control_patrimonial.ReadOnly = true;
            // 
            // anio_adquisicion
            // 
            this.anio_adquisicion.DataPropertyName = "anio_adquisicion";
            this.anio_adquisicion.HeaderText = "Año Adquisicion";
            this.anio_adquisicion.Name = "anio_adquisicion";
            this.anio_adquisicion.ReadOnly = true;
            // 
            // nro_orden_compra
            // 
            this.nro_orden_compra.DataPropertyName = "nro_orden_compra";
            this.nro_orden_compra.HeaderText = "Nro orden compra";
            this.nro_orden_compra.Name = "nro_orden_compra";
            this.nro_orden_compra.ReadOnly = true;
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Observación";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Visible = false;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "Asignado";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            // 
            // cod_categoria
            // 
            this.cod_categoria.DataPropertyName = "cod_categoria";
            this.cod_categoria.HeaderText = "Cod_categoria";
            this.cod_categoria.Name = "cod_categoria";
            this.cod_categoria.ReadOnly = true;
            this.cod_categoria.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "equipoPadreCod";
            this.Column2.HeaderText = "equipoPadreCod";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column56
            // 
            this.Column56.DataPropertyName = "estado";
            this.Column56.HeaderText = "estadoEquipo";
            this.Column56.Name = "Column56";
            this.Column56.ReadOnly = true;
            // 
            // Column57
            // 
            this.Column57.DataPropertyName = "service_tag";
            this.Column57.HeaderText = "service_tag";
            this.Column57.Name = "Column57";
            this.Column57.ReadOnly = true;
            this.Column57.Visible = false;
            // 
            // tbBuscarEquipo
            // 
            // 
            // 
            // 
            this.tbBuscarEquipo.Border.Class = "TextBoxBorder";
            this.tbBuscarEquipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbBuscarEquipo.Location = new System.Drawing.Point(79, 71);
            this.tbBuscarEquipo.Name = "tbBuscarEquipo";
            this.tbBuscarEquipo.PreventEnterBeep = true;
            this.tbBuscarEquipo.Size = new System.Drawing.Size(247, 20);
            this.tbBuscarEquipo.TabIndex = 90;
            this.tbBuscarEquipo.TextChanged += new System.EventHandler(this.tbBuscarEquipo_TextChanged);
            // 
            // FormListaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 458);
            this.Controls.Add(this.tbBuscarEquipo);
            this.Controls.Add(this.dgvEquipo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormListaEquipo";
            this.Text = "FormListaEquipo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListaEquipo_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaEquipo_FormClosed);
            this.Load += new System.EventHandler(this.FormListaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvEquipo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuscarEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn procesador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_control_patrimonial;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_orden_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column56;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column57;
    }
}