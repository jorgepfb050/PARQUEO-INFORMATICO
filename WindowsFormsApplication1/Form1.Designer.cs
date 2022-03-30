using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btImpSoft = new DevComponents.DotNetBar.ButtonX();
            this.tbBuscarSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.DGVSoftware = new System.Windows.Forms.DataGridView();
            this.cod_software = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.software = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_orden_compra_sof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_aquisicion_sof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoSoft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionSoft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAnioAquisSoft = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbObservacionSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbNroOCSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCantUsuarios = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btListarSoft = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarSoft = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizarSoft = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiarSoft = new DevComponents.DotNetBar.ButtonX();
            this.btnRegistrarSoft = new DevComponents.DotNetBar.ButtonX();
            this.cbActivoSoft = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem16 = new DevComponents.Editors.ComboItem();
            this.comboItem17 = new DevComponents.Editors.ComboItem();
            this.tbVersionSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbSoftware = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.btImpEquipo = new DevComponents.DotNetBar.ButtonX();
            this.tbBuscarEquipo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.DGVComponentesPc = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btImpCat = new DevComponents.DotNetBar.ButtonX();
            this.tbBuscarCategoria = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.DGVCategoria = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btListarEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btEliminarEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btActualizarEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btLimpiarEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btRegistrarEquipo = new DevComponents.DotNetBar.ButtonX();
            this.label15 = new System.Windows.Forms.Label();
            this.btListarCategoria = new DevComponents.DotNetBar.ButtonX();
            this.btEliminarCat = new DevComponents.DotNetBar.ButtonX();
            this.btActualizarCat = new DevComponents.DotNetBar.ButtonX();
            this.btLimpiarCat = new DevComponents.DotNetBar.ButtonX();
            this.btREgistrarCat = new DevComponents.DotNetBar.ButtonX();
            this.cbActivoCat = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.tbDescripcionCat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNomCategoria = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label16 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btImpSede = new DevComponents.DotNetBar.ButtonX();
            this.DGVSede = new System.Windows.Forms.DataGridView();
            this.cod_sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcionSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionsede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activosede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscarSede = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btImpInstancia = new DevComponents.DotNetBar.ButtonX();
            this.tbInstancia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.DGVInstancia = new System.Windows.Forms.DataGridView();
            this.Column51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_instancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_instancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoInstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProvincia_Sede = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label62 = new System.Windows.Forms.Label();
            this.cbDistritoJud_sede = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label60 = new System.Windows.Forms.Label();
            this.tbDireccSede = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNombreSede = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbObservSede = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label28 = new System.Windows.Forms.Label();
            this.cbActivoSede = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem13 = new DevComponents.Editors.ComboItem();
            this.comboItem14 = new DevComponents.Editors.ComboItem();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btListarSede = new DevComponents.DotNetBar.ButtonX();
            this.btEliminarSede = new DevComponents.DotNetBar.ButtonX();
            this.btActualizarSede = new DevComponents.DotNetBar.ButtonX();
            this.btLimpiarSede = new DevComponents.DotNetBar.ButtonX();
            this.btRegistrarSede = new DevComponents.DotNetBar.ButtonX();
            this.label24 = new System.Windows.Forms.Label();
            this.tbDirInstancia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbSede_Instanc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label68 = new System.Windows.Forms.Label();
            this.tbNroInst = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbActivoInst = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem19 = new DevComponents.Editors.ComboItem();
            this.comboItem20 = new DevComponents.Editors.ComboItem();
            this.tbNombreInst = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btListarInst = new DevComponents.DotNetBar.ButtonX();
            this.btEliminarIns = new DevComponents.DotNetBar.ButtonX();
            this.btActualizarInst = new DevComponents.DotNetBar.ButtonX();
            this.btLimpiarInst = new DevComponents.DotNetBar.ButtonX();
            this.btRegistrarIns = new DevComponents.DotNetBar.ButtonX();
            this.btImpPerfil = new DevComponents.DotNetBar.ButtonX();
            this.DGVPerfil = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPerfil = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.label71 = new System.Windows.Forms.Label();
            this.cbInstanciaPersonal = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbSedePersonal = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label69 = new System.Windows.Forms.Label();
            this.cbPerfilPersonal = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbPaternoPersonal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label63 = new System.Windows.Forms.Label();
            this.dtPersonal = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbEstadoPersonal = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem25 = new DevComponents.Editors.ComboItem();
            this.comboItem26 = new DevComponents.Editors.ComboItem();
            this.tbDniPersonal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tbMaternoPersonal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNombrePersonal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.cbActivoPerfil = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem52 = new DevComponents.Editors.ComboItem();
            this.comboItem53 = new DevComponents.Editors.ComboItem();
            this.label32 = new System.Windows.Forms.Label();
            this.tbObservPerfil = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNombrePerfil = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.btListarPerfil = new DevComponents.DotNetBar.ButtonX();
            this.btEliminarPErfil = new DevComponents.DotNetBar.ButtonX();
            this.btActualizarPerfil = new DevComponents.DotNetBar.ButtonX();
            this.btLimpiarPerfil = new DevComponents.DotNetBar.ButtonX();
            this.btRegistrarPerfil = new DevComponents.DotNetBar.ButtonX();
            this.DGVAsignacionSoft = new System.Windows.Forms.DataGridView();
            this.Column39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAsignacionSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cbCodSoftAS = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.textBoxX8 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX9 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label59 = new System.Windows.Forms.Label();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.cbCodEquipoAS = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label57 = new System.Windows.Forms.Label();
            this.dtFechaCaducidadAS = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFechaInstalacionAS = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbObservacionAS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label50 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbInstancAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbSedeAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbDniAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNombreAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtFechaIngAE = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label67 = new System.Windows.Forms.Label();
            this.cbCodPersonalAE = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label54 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem12 = new DevComponents.Editors.ComboItem();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.toolTipListar = new System.Windows.Forms.ToolTip(this.components);
            this.btListaAE = new DevComponents.DotNetBar.ButtonX();
            this.btListaSoftAE = new DevComponents.DotNetBar.ButtonX();
            this.buttonX15 = new DevComponents.DotNetBar.ButtonX();
            this.btListaAECCom = new DevComponents.DotNetBar.ButtonX();
            this.btListarAS = new DevComponents.DotNetBar.ButtonX();
            this.toolTipRegistrar = new System.Windows.Forms.ToolTip(this.components);
            this.btRegistrarAE = new DevComponents.DotNetBar.ButtonX();
            this.btGrabarSoftAE = new DevComponents.DotNetBar.ButtonX();
            this.buttonX16 = new DevComponents.DotNetBar.ButtonX();
            this.btRegistrarAECCom = new DevComponents.DotNetBar.ButtonX();
            this.btRegistrarAS = new DevComponents.DotNetBar.ButtonX();
            this.toolTipLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.tbLimpiarAE = new DevComponents.DotNetBar.ButtonX();
            this.btLimpiarSoftAE = new DevComponents.DotNetBar.ButtonX();
            this.buttonX19 = new DevComponents.DotNetBar.ButtonX();
            this.tbLimpiarAECCom = new DevComponents.DotNetBar.ButtonX();
            this.btLimpiarAS = new DevComponents.DotNetBar.ButtonX();
            this.toolTipActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.tbActualizarAE = new DevComponents.DotNetBar.ButtonX();
            this.btActualizarSoftAE = new DevComponents.DotNetBar.ButtonX();
            this.buttonX17 = new DevComponents.DotNetBar.ButtonX();
            this.tbActualizarAECCom = new DevComponents.DotNetBar.ButtonX();
            this.btActualizarAS = new DevComponents.DotNetBar.ButtonX();
            this.toolTipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.tbEliminarAE = new DevComponents.DotNetBar.ButtonX();
            this.btEliminarSoftAE = new DevComponents.DotNetBar.ButtonX();
            this.buttonX18 = new DevComponents.DotNetBar.ButtonX();
            this.tbEliminarAECCom = new DevComponents.DotNetBar.ButtonX();
            this.btEliminarAS = new DevComponents.DotNetBar.ButtonX();
            this.toolTipSoft = new System.Windows.Forms.ToolTip(this.components);
            this.toolTioEquipo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPersonal = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAE = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAS = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReporte = new System.Windows.Forms.ToolTip(this.components);
            this.btReportEquipo = new DevComponents.DotNetBar.ButtonX();
            this.tbCerrarAE = new DevComponents.DotNetBar.ButtonX();
            this.btCerrarSoftAE = new DevComponents.DotNetBar.ButtonX();
            this.btReporteSoftAE = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX14 = new DevComponents.DotNetBar.ButtonX();
            this.tbCerrarAECCom = new DevComponents.DotNetBar.ButtonX();
            this.btReportEquipoCCom = new DevComponents.DotNetBar.ButtonX();
            this.btReporteSoft = new DevComponents.DotNetBar.ButtonX();
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.sideNav1 = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavPanel11 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelEx10 = new DevComponents.DotNetBar.PanelEx();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.sideNavPanel3 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelEx8 = new DevComponents.DotNetBar.PanelEx();
            this.btnConstAsg = new DevComponents.DotNetBar.ButtonX();
            this.superTabControl3 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel10 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.stiCPU = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel14 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.stiOtros = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.stiSistAudio = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel6 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.stiImpresora = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel7 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.stiEscaner = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.stiLaptop = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel11 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.cbCodEquipoAE = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.superTabControl2 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel15 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dtFechaAsignacionAESCCom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label174 = new System.Windows.Forms.Label();
            this.tbNombreEquipoCCom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem46 = new DevComponents.Editors.ComboItem();
            this.comboItem47 = new DevComponents.Editors.ComboItem();
            this.comboItem48 = new DevComponents.Editors.ComboItem();
            this.cbEquipoPadreCodCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbEstadoEquipoCCom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem43 = new DevComponents.Editors.ComboItem();
            this.comboItem44 = new DevComponents.Editors.ComboItem();
            this.comboItem45 = new DevComponents.Editors.ComboItem();
            this.cbAnioCompraCCom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbCatEqCCom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbCodEqCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label144 = new System.Windows.Forms.Label();
            this.cbAnioCompraCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCatEqCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFuncionamientoCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label145 = new System.Windows.Forms.Label();
            this.cbEstadoEquipoCComInf = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem38 = new DevComponents.Editors.ComboItem();
            this.comboItem39 = new DevComponents.Editors.ComboItem();
            this.comboItem40 = new DevComponents.Editors.ComboItem();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.tbObseracionCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label154 = new System.Windows.Forms.Label();
            this.tbIpCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label155 = new System.Windows.Forms.Label();
            this.tbProcesadorCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbModeloCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroOrdenCompraCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label156 = new System.Windows.Forms.Label();
            this.tbMarcaCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroSerieCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroControlPatrimonialCComInf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label143 = new System.Windows.Forms.Label();
            this.line15 = new DevComponents.DotNetBar.Controls.Line();
            this.label142 = new System.Windows.Forms.Label();
            this.line14 = new DevComponents.DotNetBar.Controls.Line();
            this.rbEditarAECCom = new System.Windows.Forms.RadioButton();
            this.rbNuevoAECCom = new System.Windows.Forms.RadioButton();
            this.tbFuncionamientoCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.tbServiceTagCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.cbAsignadoCCom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem41 = new DevComponents.Editors.ComboItem();
            this.comboItem42 = new DevComponents.Editors.ComboItem();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.tbObseracionCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label139 = new System.Windows.Forms.Label();
            this.tbIpCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label140 = new System.Windows.Forms.Label();
            this.tbProcesadorCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbModeloCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroOrdenCompraCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label141 = new System.Windows.Forms.Label();
            this.tbMarcaCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroSerieCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroControlPatrimonialCCom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DGVRegistroCCom = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stComponente = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dtFechaAsignacionAES = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label173 = new System.Windows.Forms.Label();
            this.rbEditarAE = new System.Windows.Forms.RadioButton();
            this.rbNuevoAE = new System.Windows.Forms.RadioButton();
            this.tbFuncionamiento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label29 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.tbServiceTag = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label86 = new System.Windows.Forms.Label();
            this.cbEstadoEquipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem18 = new DevComponents.Editors.ComboItem();
            this.comboItem23 = new DevComponents.Editors.ComboItem();
            this.comboItem24 = new DevComponents.Editors.ComboItem();
            this.label49 = new System.Windows.Forms.Label();
            this.cbAnioCompra = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbEquipoPadreCod = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAsignado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem27 = new DevComponents.Editors.ComboItem();
            this.comboItem28 = new DevComponents.Editors.ComboItem();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCatEq = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbObseracion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label13 = new System.Windows.Forms.Label();
            this.tbProcesador = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbModelo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroOrdenCompra = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNombreEquipo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label17 = new System.Windows.Forms.Label();
            this.tbMarca = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroSerie = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroControlPatrimonial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.tbAsignacionEq = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DGVRegistro = new System.Windows.Forms.DataGridView();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stFormEquipo = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel8 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.cbSoftware_SoftAE = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label109 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.line13 = new DevComponents.DotNetBar.Controls.Line();
            this.label108 = new System.Windows.Forms.Label();
            this.tbCodEquipoSofAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label107 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.dtFechaInstalacionSoftAE = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFechaCaducidadSoftAE = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label106 = new System.Windows.Forms.Label();
            this.rbEditarSofAE = new System.Windows.Forms.RadioButton();
            this.rbNuevoSofAE = new System.Windows.Forms.RadioButton();
            this.tbAnioCompraSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCatEqSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DGVSoftware_SodtAE = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAnioCompraSoftAE = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.line12 = new DevComponents.DotNetBar.Controls.Line();
            this.tbObsvSoftAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.tbOCSoftAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCantidadUsSoftAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbnombreSoftAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label103 = new System.Windows.Forms.Label();
            this.tbVersionSoftAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label104 = new System.Windows.Forms.Label();
            this.cbActivoSoftAE = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem32 = new DevComponents.Editors.ComboItem();
            this.comboItem33 = new DevComponents.Editors.ComboItem();
            this.tbFuncionamientoSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label61 = new System.Windows.Forms.Label();
            this.cbEstadoEquipoSoft = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem29 = new DevComponents.Editors.ComboItem();
            this.comboItem30 = new DevComponents.Editors.ComboItem();
            this.comboItem31 = new DevComponents.Editors.ComboItem();
            this.label64 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.tbObseracionSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label94 = new System.Windows.Forms.Label();
            this.tbIpSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label95 = new System.Windows.Forms.Label();
            this.tbProcesadorSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbModeloSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroOrdenCompraSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label96 = new System.Windows.Forms.Label();
            this.tbMarcaSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroSerieSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroControlPatrimonialSoft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.stSoftware = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel12 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel9 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tbPerfilAE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label90 = new System.Windows.Forms.Label();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNavPanel2 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.rbEditarEq = new System.Windows.Forms.RadioButton();
            this.rbNuevoEq = new System.Windows.Forms.RadioButton();
            this.tbFuncionamientoNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.tbServiceTagNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label159 = new System.Windows.Forms.Label();
            this.cbEstadoEquipoNA = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem51 = new DevComponents.Editors.ComboItem();
            this.comboItem54 = new DevComponents.Editors.ComboItem();
            this.comboItem55 = new DevComponents.Editors.ComboItem();
            this.label160 = new System.Windows.Forms.Label();
            this.cbAnioCompraNA = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbEquipoPadreCodNA = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label161 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.cbAsignadoNA = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem56 = new DevComponents.Editors.ComboItem();
            this.comboItem57 = new DevComponents.Editors.ComboItem();
            this.label164 = new System.Windows.Forms.Label();
            this.cbCatEqNA = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.tbObseracionNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label170 = new System.Windows.Forms.Label();
            this.tbIpNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label171 = new System.Windows.Forms.Label();
            this.tbProcesadorNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbModeloNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroOrdenCompraNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNombreEquipoNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label172 = new System.Windows.Forms.Label();
            this.tbMarcaNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroSerieNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroControlPatrimonialNA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.rbEditarCat = new System.Windows.Forms.RadioButton();
            this.rbNuevoCat = new System.Windows.Forms.RadioButton();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.Categorias = new DevComponents.DotNetBar.SuperTabItem();
            this.sideNavPanel9 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.buttonX20 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX12 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX13 = new DevComponents.DotNetBar.ButtonX();
            this.sideNavPanel13 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel6 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelEx6 = new DevComponents.DotNetBar.PanelEx();
            this.DGVPersonal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPerAdmi = new System.Windows.Forms.RadioButton();
            this.rbPerJur = new System.Windows.Forms.RadioButton();
            this.rbEditarPersonal = new System.Windows.Forms.RadioButton();
            this.rbNuevaPersonal = new System.Windows.Forms.RadioButton();
            this.label52 = new System.Windows.Forms.Label();
            this.tbArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label51 = new System.Windows.Forms.Label();
            this.tbUnOrganica = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chbFTerminoLaboral = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btLimpiarPersonal_ = new DevComponents.DotNetBar.ButtonX();
            this.btSalirPersonal_ = new DevComponents.DotNetBar.ButtonX();
            this.btEliminarPersonal_ = new DevComponents.DotNetBar.ButtonX();
            this.btEditarPersonal_ = new DevComponents.DotNetBar.ButtonX();
            this.btGrabarPersonal_ = new DevComponents.DotNetBar.ButtonX();
            this.dtFechaTerminoLaboral = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label65 = new System.Windows.Forms.Label();
            this.dtFechaIngresoLaboral = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label39 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.tbEscalafon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label92 = new System.Windows.Forms.Label();
            this.dtFechaNacPersonal = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label91 = new System.Windows.Forms.Label();
            this.line11 = new DevComponents.DotNetBar.Controls.Line();
            this.line10 = new DevComponents.DotNetBar.Controls.Line();
            this.line7 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNavPanel5 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.rbEditarPerfil = new System.Windows.Forms.RadioButton();
            this.rbNuevoPErfil = new System.Windows.Forms.RadioButton();
            this.line6 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNavPanel1 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelEx9 = new DevComponents.DotNetBar.PanelEx();
            this.rbEditarSof = new System.Windows.Forms.RadioButton();
            this.rbNuevoSof = new System.Windows.Forms.RadioButton();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNavPanel4 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelEx7 = new DevComponents.DotNetBar.PanelEx();
            this.line5 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNavPanel12 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.sideNavPanel10 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelDesktopCU = new System.Windows.Forms.Panel();
            this.sideNavPanel7 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.rbEditarSede = new System.Windows.Forms.RadioButton();
            this.rbNuevaSede = new System.Windows.Forms.RadioButton();
            this.line8 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNavPanel8 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.rbEditarInst = new System.Windows.Forms.RadioButton();
            this.rbNuevaInst = new System.Windows.Forms.RadioButton();
            this.line9 = new DevComponents.DotNetBar.Controls.Line();
            this.separator7 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem1 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem6Inicio = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator10 = new DevComponents.DotNetBar.Separator();
            this.SNIUsers = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem6 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.separator6 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem7 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.rbNuevaPerfil = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator2 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem9 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem8 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator3 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem2 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem5 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator4 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem3 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem4 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator5 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem10 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator8 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem11 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator9 = new DevComponents.DotNetBar.Separator();
            this.buttonX11 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX10 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX7 = new DevComponents.DotNetBar.ButtonX();
            this.comboItem50 = new DevComponents.Editors.ComboItem();
            this.comboItem49 = new DevComponents.Editors.ComboItem();
            this.comboItem22 = new DevComponents.Editors.ComboItem();
            this.comboItem21 = new DevComponents.Editors.ComboItem();
            this.comboItem15 = new DevComponents.Editors.ComboItem();
            this.cbAnioCompraComp = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel13 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbFuncionamientoComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.textBoxX7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label112 = new System.Windows.Forms.Label();
            this.cbEstadoEquipoComp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem34 = new DevComponents.Editors.ComboItem();
            this.comboItem35 = new DevComponents.Editors.ComboItem();
            this.label113 = new System.Windows.Forms.Label();
            this.cbAnioCompraCom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx3 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.comboBoxEx4 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem36 = new DevComponents.Editors.ComboItem();
            this.comboItem37 = new DevComponents.Editors.ComboItem();
            this.label117 = new System.Windows.Forms.Label();
            this.cbCatEqComp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.tbObseracionComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label123 = new System.Windows.Forms.Label();
            this.tbIpComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label124 = new System.Windows.Forms.Label();
            this.tbProcesadorComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbModeloComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroOrdenCompraComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNombreEquipoComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label125 = new System.Windows.Forms.Label();
            this.tbMarcaComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroSerieComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNroControlPatrimonialComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tbAsignacionEqComp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComponentesPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInstancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsignacionSoft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCaducidadAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInstalacionAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngAE)).BeginInit();
            this.sideNav1.SuspendLayout();
            this.sideNavPanel11.SuspendLayout();
            this.panelEx10.SuspendLayout();
            this.sideNavPanel3.SuspendLayout();
            this.panelEx8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl3)).BeginInit();
            this.superTabControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).BeginInit();
            this.superTabControl2.SuspendLayout();
            this.superTabControlPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAsignacionAESCCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistroCCom)).BeginInit();
            this.superTabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAsignacionAES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistro)).BeginInit();
            this.superTabControlPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInstalacionSoftAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCaducidadSoftAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSoftware_SodtAE)).BeginInit();
            this.sideNavPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.sideNavPanel9.SuspendLayout();
            this.sideNavPanel6.SuspendLayout();
            this.panelEx6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaTerminoLaboral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngresoLaboral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacPersonal)).BeginInit();
            this.sideNavPanel5.SuspendLayout();
            this.panelEx5.SuspendLayout();
            this.sideNavPanel1.SuspendLayout();
            this.panelEx9.SuspendLayout();
            this.sideNavPanel4.SuspendLayout();
            this.panelEx7.SuspendLayout();
            this.sideNavPanel12.SuspendLayout();
            this.sideNavPanel10.SuspendLayout();
            this.sideNavPanel7.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.sideNavPanel8.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.superTabControlPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dgvEquipo.Location = new System.Drawing.Point(11, 351);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            this.dgvEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipo.Size = new System.Drawing.Size(971, 214);
            this.dgvEquipo.TabIndex = 11;
            this.dgvEquipo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellClick);
            this.dgvEquipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellDoubleClick);
            // 
            // cod_equipo
            // 
            this.cod_equipo.DataPropertyName = "cod_equipo";
            this.cod_equipo.HeaderText = "Cod Equipo";
            this.cod_equipo.Name = "cod_equipo";
            this.cod_equipo.ReadOnly = true;
            this.cod_equipo.Visible = false;
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
            this.nro_control_patrimonial.Visible = false;
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
            this.nro_orden_compra.Visible = false;
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
            // btImpSoft
            // 
            this.btImpSoft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btImpSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImpSoft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btImpSoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImpSoft.Location = new System.Drawing.Point(943, 164);
            this.btImpSoft.Name = "btImpSoft";
            this.btImpSoft.Size = new System.Drawing.Size(53, 52);
            this.btImpSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btImpSoft.TabIndex = 140;
            this.btImpSoft.Text = "Imprimiir";
            this.toolTipListar.SetToolTip(this.btImpSoft, "Imprimir");
            this.btImpSoft.Click += new System.EventHandler(this.btImpSoft_Click);
            // 
            // tbBuscarSoft
            // 
            // 
            // 
            // 
            this.tbBuscarSoft.Border.Class = "TextBoxBorder";
            this.tbBuscarSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbBuscarSoft.Location = new System.Drawing.Point(55, 196);
            this.tbBuscarSoft.Name = "tbBuscarSoft";
            this.tbBuscarSoft.PreventEnterBeep = true;
            this.tbBuscarSoft.Size = new System.Drawing.Size(411, 20);
            this.tbBuscarSoft.TabIndex = 141;
            this.tbBuscarSoft.TextChanged += new System.EventHandler(this.tbBuscarSoft_TextChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(10, 193);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "Buscar";
            // 
            // DGVSoftware
            // 
            this.DGVSoftware.AllowUserToAddRows = false;
            this.DGVSoftware.AllowUserToDeleteRows = false;
            this.DGVSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVSoftware.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSoftware.BackgroundColor = System.Drawing.Color.White;
            this.DGVSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSoftware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_software,
            this.software,
            this.version,
            this.cantidad_usuarios,
            this.nro_orden_compra_sof,
            this.anio_aquisicion_sof,
            this.activoSoft,
            this.observacionSoft});
            this.DGVSoftware.Location = new System.Drawing.Point(5, 238);
            this.DGVSoftware.Name = "DGVSoftware";
            this.DGVSoftware.ReadOnly = true;
            this.DGVSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSoftware.Size = new System.Drawing.Size(989, 431);
            this.DGVSoftware.TabIndex = 14;
            this.DGVSoftware.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSoftware_CellClick);
            // 
            // cod_software
            // 
            this.cod_software.DataPropertyName = "cod_software";
            this.cod_software.HeaderText = "Cod Software";
            this.cod_software.Name = "cod_software";
            this.cod_software.ReadOnly = true;
            this.cod_software.Visible = false;
            // 
            // software
            // 
            this.software.DataPropertyName = "software";
            this.software.HeaderText = "Software";
            this.software.Name = "software";
            this.software.ReadOnly = true;
            // 
            // version
            // 
            this.version.DataPropertyName = "version";
            this.version.HeaderText = "Version";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            // 
            // cantidad_usuarios
            // 
            this.cantidad_usuarios.DataPropertyName = "cantidad_usuarios";
            this.cantidad_usuarios.HeaderText = "Cantidad Usuarios";
            this.cantidad_usuarios.Name = "cantidad_usuarios";
            this.cantidad_usuarios.ReadOnly = true;
            // 
            // nro_orden_compra_sof
            // 
            this.nro_orden_compra_sof.DataPropertyName = "nro_orden_compra";
            this.nro_orden_compra_sof.HeaderText = "Nro Orden Compra";
            this.nro_orden_compra_sof.Name = "nro_orden_compra_sof";
            this.nro_orden_compra_sof.ReadOnly = true;
            // 
            // anio_aquisicion_sof
            // 
            this.anio_aquisicion_sof.DataPropertyName = "anio_aquisicion";
            this.anio_aquisicion_sof.HeaderText = "Año Aquisición";
            this.anio_aquisicion_sof.Name = "anio_aquisicion_sof";
            this.anio_aquisicion_sof.ReadOnly = true;
            // 
            // activoSoft
            // 
            this.activoSoft.DataPropertyName = "activo";
            this.activoSoft.HeaderText = "Activo";
            this.activoSoft.Name = "activoSoft";
            this.activoSoft.ReadOnly = true;
            // 
            // observacionSoft
            // 
            this.observacionSoft.DataPropertyName = "observacion";
            this.observacionSoft.HeaderText = "Observación";
            this.observacionSoft.Name = "observacionSoft";
            this.observacionSoft.ReadOnly = true;
            // 
            // cbAnioAquisSoft
            // 
            this.cbAnioAquisSoft.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAnioAquisSoft.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnioAquisSoft.DisplayMember = "Text";
            this.cbAnioAquisSoft.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAnioAquisSoft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnioAquisSoft.Enabled = false;
            this.cbAnioAquisSoft.FormattingEnabled = true;
            this.cbAnioAquisSoft.ItemHeight = 15;
            this.cbAnioAquisSoft.Location = new System.Drawing.Point(16, 105);
            this.cbAnioAquisSoft.Name = "cbAnioAquisSoft";
            this.cbAnioAquisSoft.Size = new System.Drawing.Size(181, 21);
            this.cbAnioAquisSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAnioAquisSoft.TabIndex = 132;
            this.cbAnioAquisSoft.Click += new System.EventHandler(this.cbAnioAquisSoft_Click);
            this.cbAnioAquisSoft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAnioAquisSoft_KeyPress);
            // 
            // tbObservacionSoft
            // 
            // 
            // 
            // 
            this.tbObservacionSoft.Border.Class = "TextBoxBorder";
            this.tbObservacionSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObservacionSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservacionSoft.Enabled = false;
            this.tbObservacionSoft.Location = new System.Drawing.Point(232, 106);
            this.tbObservacionSoft.Name = "tbObservacionSoft";
            this.tbObservacionSoft.PreventEnterBeep = true;
            this.tbObservacionSoft.Size = new System.Drawing.Size(363, 20);
            this.tbObservacionSoft.TabIndex = 133;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 200;
            this.label19.Text = "Año de Aquisición";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(230, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 141;
            this.label20.Text = "Observación";
            // 
            // tbNroOCSoft
            // 
            // 
            // 
            // 
            this.tbNroOCSoft.Border.Class = "TextBoxBorder";
            this.tbNroOCSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroOCSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroOCSoft.Enabled = false;
            this.tbNroOCSoft.Location = new System.Drawing.Point(738, 55);
            this.tbNroOCSoft.Name = "tbNroOCSoft";
            this.tbNroOCSoft.PreventEnterBeep = true;
            this.tbNroOCSoft.Size = new System.Drawing.Size(231, 20);
            this.tbNroOCSoft.TabIndex = 131;
            // 
            // tbCantUsuarios
            // 
            // 
            // 
            // 
            this.tbCantUsuarios.Border.Class = "TextBoxBorder";
            this.tbCantUsuarios.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCantUsuarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCantUsuarios.Enabled = false;
            this.tbCantUsuarios.Location = new System.Drawing.Point(613, 55);
            this.tbCantUsuarios.Name = "tbCantUsuarios";
            this.tbCantUsuarios.PreventEnterBeep = true;
            this.tbCantUsuarios.Size = new System.Drawing.Size(109, 20);
            this.tbCantUsuarios.TabIndex = 130;
            this.tbCantUsuarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantUsuarios_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 300;
            this.label5.Text = "Cantidad de Usuarios";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(737, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 13);
            this.label18.TabIndex = 300;
            this.label18.Text = "Número de orden de compra";
            // 
            // btListarSoft
            // 
            this.btListarSoft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListarSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListarSoft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListarSoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btListarSoft.Location = new System.Drawing.Point(657, 164);
            this.btListarSoft.Name = "btListarSoft";
            this.btListarSoft.Size = new System.Drawing.Size(53, 52);
            this.btListarSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btListarSoft.TabIndex = 138;
            this.btListarSoft.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListarSoft, "listar");
            this.btListarSoft.Click += new System.EventHandler(this.btListarSoft_Click);
            this.btListarSoft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btListarSoft_MouseMove);
            // 
            // btnEliminarSoft
            // 
            this.btnEliminarSoft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarSoft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminarSoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarSoft.Location = new System.Drawing.Point(830, 164);
            this.btnEliminarSoft.Name = "btnEliminarSoft";
            this.btnEliminarSoft.Size = new System.Drawing.Size(53, 52);
            this.btnEliminarSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminarSoft.TabIndex = 137;
            this.btnEliminarSoft.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.btnEliminarSoft, "Eliminar");
            this.btnEliminarSoft.Click += new System.EventHandler(this.btnEliminarSoft_Click);
            // 
            // btnActualizarSoft
            // 
            this.btnActualizarSoft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizarSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarSoft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActualizarSoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarSoft.Enabled = false;
            this.btnActualizarSoft.Location = new System.Drawing.Point(771, 164);
            this.btnActualizarSoft.Name = "btnActualizarSoft";
            this.btnActualizarSoft.Size = new System.Drawing.Size(53, 52);
            this.btnActualizarSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActualizarSoft.TabIndex = 136;
            this.btnActualizarSoft.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.btnActualizarSoft, "Actualizar");
            this.btnActualizarSoft.Click += new System.EventHandler(this.btnActualizarSoft_Click);
            // 
            // btnLimpiarSoft
            // 
            this.btnLimpiarSoft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiarSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarSoft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiarSoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarSoft.Location = new System.Drawing.Point(888, 164);
            this.btnLimpiarSoft.Name = "btnLimpiarSoft";
            this.btnLimpiarSoft.Size = new System.Drawing.Size(53, 52);
            this.btnLimpiarSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiarSoft.TabIndex = 139;
            this.btnLimpiarSoft.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.btnLimpiarSoft, "Limpiar");
            this.btnLimpiarSoft.Click += new System.EventHandler(this.btnLimpiarSoft_Click);
            // 
            // btnRegistrarSoft
            // 
            this.btnRegistrarSoft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegistrarSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarSoft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegistrarSoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarSoft.Enabled = false;
            this.btnRegistrarSoft.Location = new System.Drawing.Point(713, 164);
            this.btnRegistrarSoft.Name = "btnRegistrarSoft";
            this.btnRegistrarSoft.Size = new System.Drawing.Size(53, 52);
            this.btnRegistrarSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegistrarSoft.TabIndex = 135;
            this.btnRegistrarSoft.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btnRegistrarSoft, "Registrar");
            this.btnRegistrarSoft.Click += new System.EventHandler(this.btnRegistrarSoft_Click_1);
            // 
            // cbActivoSoft
            // 
            this.cbActivoSoft.DisplayMember = "Text";
            this.cbActivoSoft.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActivoSoft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivoSoft.Enabled = false;
            this.cbActivoSoft.FormattingEnabled = true;
            this.cbActivoSoft.ItemHeight = 15;
            this.cbActivoSoft.Items.AddRange(new object[] {
            this.comboItem16,
            this.comboItem17});
            this.cbActivoSoft.Location = new System.Drawing.Point(619, 105);
            this.cbActivoSoft.Name = "cbActivoSoft";
            this.cbActivoSoft.Size = new System.Drawing.Size(175, 21);
            this.cbActivoSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbActivoSoft.TabIndex = 134;
            // 
            // comboItem16
            // 
            this.comboItem16.Text = "S";
            // 
            // comboItem17
            // 
            this.comboItem17.Text = "N";
            // 
            // tbVersionSoft
            // 
            // 
            // 
            // 
            this.tbVersionSoft.Border.Class = "TextBoxBorder";
            this.tbVersionSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbVersionSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbVersionSoft.Enabled = false;
            this.tbVersionSoft.Location = new System.Drawing.Point(232, 55);
            this.tbVersionSoft.Name = "tbVersionSoft";
            this.tbVersionSoft.PreventEnterBeep = true;
            this.tbVersionSoft.Size = new System.Drawing.Size(363, 20);
            this.tbVersionSoft.TabIndex = 129;
            // 
            // tbSoftware
            // 
            // 
            // 
            // 
            this.tbSoftware.Border.Class = "TextBoxBorder";
            this.tbSoftware.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSoftware.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSoftware.Enabled = false;
            this.tbSoftware.Location = new System.Drawing.Point(15, 55);
            this.tbSoftware.Name = "tbSoftware";
            this.tbSoftware.PreventEnterBeep = true;
            this.tbSoftware.Size = new System.Drawing.Size(197, 20);
            this.tbSoftware.TabIndex = 128;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(439, 11);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(124, 13);
            this.label35.TabIndex = 127;
            this.label35.Text = "Información del Software";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(617, 89);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(37, 13);
            this.label36.TabIndex = 126;
            this.label36.Text = "Activo";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(15, 38);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(113, 13);
            this.label37.TabIndex = 124;
            this.label37.Text = "Nombre del Software *";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(230, 38);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(49, 13);
            this.label38.TabIndex = 125;
            this.label38.Text = "Versión *";
            // 
            // btImpEquipo
            // 
            this.btImpEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btImpEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImpEquipo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btImpEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImpEquipo.Location = new System.Drawing.Point(927, 292);
            this.btImpEquipo.Name = "btImpEquipo";
            this.btImpEquipo.Size = new System.Drawing.Size(53, 52);
            this.btImpEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btImpEquipo.TabIndex = 88;
            this.btImpEquipo.Text = "Imprimir";
            this.toolTipListar.SetToolTip(this.btImpEquipo, "Imprimir");
            this.btImpEquipo.Click += new System.EventHandler(this.btImpEquipo_Click);
            // 
            // tbBuscarEquipo
            // 
            // 
            // 
            // 
            this.tbBuscarEquipo.Border.Class = "TextBoxBorder";
            this.tbBuscarEquipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbBuscarEquipo.Location = new System.Drawing.Point(76, 319);
            this.tbBuscarEquipo.Name = "tbBuscarEquipo";
            this.tbBuscarEquipo.PreventEnterBeep = true;
            this.tbBuscarEquipo.Size = new System.Drawing.Size(247, 20);
            this.tbBuscarEquipo.TabIndex = 89;
            this.tbBuscarEquipo.TextChanged += new System.EventHandler(this.tbBuscarEquipo_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(21, 316);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Buscar";
            // 
            // DGVComponentesPc
            // 
            this.DGVComponentesPc.AllowUserToAddRows = false;
            this.DGVComponentesPc.AllowUserToDeleteRows = false;
            this.DGVComponentesPc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVComponentesPc.BackgroundColor = System.Drawing.Color.White;
            this.DGVComponentesPc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVComponentesPc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column48});
            this.DGVComponentesPc.Location = new System.Drawing.Point(14, 587);
            this.DGVComponentesPc.Name = "DGVComponentesPc";
            this.DGVComponentesPc.ReadOnly = true;
            this.DGVComponentesPc.Size = new System.Drawing.Size(968, 82);
            this.DGVComponentesPc.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cod_equipo";
            this.Column3.HeaderText = "CodEquipo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "equipo";
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "marca";
            this.Column5.HeaderText = "Marca";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "modelo";
            this.Column6.HeaderText = "Modelo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nro_serie";
            this.Column1.HeaderText = "Nro de Serie";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column48
            // 
            this.Column48.DataPropertyName = "equipoPadreCod";
            this.Column48.HeaderText = "equipoPadreCod";
            this.Column48.Name = "Column48";
            this.Column48.ReadOnly = true;
            // 
            // btImpCat
            // 
            this.btImpCat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btImpCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImpCat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btImpCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImpCat.Location = new System.Drawing.Point(922, 191);
            this.btImpCat.Name = "btImpCat";
            this.btImpCat.Size = new System.Drawing.Size(53, 52);
            this.btImpCat.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btImpCat.TabIndex = 116;
            this.btImpCat.Text = "Imprimir";
            this.toolTipListar.SetToolTip(this.btImpCat, "Imprimir");
            this.btImpCat.Click += new System.EventHandler(this.btImpCat_Click);
            // 
            // tbBuscarCategoria
            // 
            this.tbBuscarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.tbBuscarCategoria.Border.Class = "TextBoxBorder";
            this.tbBuscarCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbBuscarCategoria.Location = new System.Drawing.Point(81, 223);
            this.tbBuscarCategoria.Name = "tbBuscarCategoria";
            this.tbBuscarCategoria.PreventEnterBeep = true;
            this.tbBuscarCategoria.Size = new System.Drawing.Size(223, 20);
            this.tbBuscarCategoria.TabIndex = 139;
            this.tbBuscarCategoria.TextChanged += new System.EventHandler(this.tbBuscarCategoria_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(13, 218);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 28);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Buscar";
            // 
            // DGVCategoria
            // 
            this.DGVCategoria.AllowUserToAddRows = false;
            this.DGVCategoria.AllowUserToDeleteRows = false;
            this.DGVCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategoria.BackgroundColor = System.Drawing.Color.White;
            this.DGVCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.categoria,
            this.descripcion,
            this.dataGridViewTextBoxColumn12});
            this.DGVCategoria.Location = new System.Drawing.Point(10, 269);
            this.DGVCategoria.Name = "DGVCategoria";
            this.DGVCategoria.ReadOnly = true;
            this.DGVCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCategoria.Size = new System.Drawing.Size(971, 389);
            this.DGVCategoria.TabIndex = 12;
            this.DGVCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategoria_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "cod_categoria";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Nombre de la Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "observacion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "activo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // btListarEquipo
            // 
            this.btListarEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListarEquipo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListarEquipo.Location = new System.Drawing.Point(636, 292);
            this.btListarEquipo.Name = "btListarEquipo";
            this.btListarEquipo.Size = new System.Drawing.Size(53, 52);
            this.btListarEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btListarEquipo.TabIndex = 83;
            this.btListarEquipo.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListarEquipo, "Listar");
            this.btListarEquipo.Click += new System.EventHandler(this.btListarEq_Click_1);
            // 
            // btEliminarEquipo
            // 
            this.btEliminarEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarEquipo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEliminarEquipo.Location = new System.Drawing.Point(809, 292);
            this.btEliminarEquipo.Name = "btEliminarEquipo";
            this.btEliminarEquipo.Size = new System.Drawing.Size(53, 52);
            this.btEliminarEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminarEquipo.TabIndex = 87;
            this.btEliminarEquipo.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.btEliminarEquipo, "Eliminar");
            this.btEliminarEquipo.Click += new System.EventHandler(this.btEliminar_Click_1);
            // 
            // btActualizarEquipo
            // 
            this.btActualizarEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualizarEquipo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btActualizarEquipo.Location = new System.Drawing.Point(751, 293);
            this.btActualizarEquipo.Name = "btActualizarEquipo";
            this.btActualizarEquipo.Size = new System.Drawing.Size(53, 52);
            this.btActualizarEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizarEquipo.TabIndex = 86;
            this.btActualizarEquipo.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.btActualizarEquipo, "Actualizar");
            this.btActualizarEquipo.Click += new System.EventHandler(this.btActualizar_Click_1);
            // 
            // btLimpiarEquipo
            // 
            this.btLimpiarEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpiarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiarEquipo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLimpiarEquipo.Location = new System.Drawing.Point(868, 292);
            this.btLimpiarEquipo.Name = "btLimpiarEquipo";
            this.btLimpiarEquipo.Size = new System.Drawing.Size(53, 52);
            this.btLimpiarEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btLimpiarEquipo.TabIndex = 85;
            this.btLimpiarEquipo.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.btLimpiarEquipo, "Limpiar");
            this.btLimpiarEquipo.Click += new System.EventHandler(this.btLimpiar_Click_1);
            // 
            // btRegistrarEquipo
            // 
            this.btRegistrarEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btRegistrarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarEquipo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btRegistrarEquipo.Location = new System.Drawing.Point(695, 292);
            this.btRegistrarEquipo.Name = "btRegistrarEquipo";
            this.btRegistrarEquipo.Size = new System.Drawing.Size(53, 52);
            this.btRegistrarEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btRegistrarEquipo.TabIndex = 84;
            this.btRegistrarEquipo.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btRegistrarEquipo, "Registrar");
            this.btRegistrarEquipo.Click += new System.EventHandler(this.btRegistrar_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(461, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Información del Equipo";
            // 
            // btListarCategoria
            // 
            this.btListarCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListarCategoria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListarCategoria.Location = new System.Drawing.Point(632, 191);
            this.btListarCategoria.Name = "btListarCategoria";
            this.btListarCategoria.Size = new System.Drawing.Size(53, 52);
            this.btListarCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btListarCategoria.TabIndex = 114;
            this.btListarCategoria.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListarCategoria, "Listar");
            this.btListarCategoria.Click += new System.EventHandler(this.btListarCategoria_Click_1);
            // 
            // btEliminarCat
            // 
            this.btEliminarCat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminarCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarCat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEliminarCat.Location = new System.Drawing.Point(808, 191);
            this.btEliminarCat.Name = "btEliminarCat";
            this.btEliminarCat.Size = new System.Drawing.Size(53, 52);
            this.btEliminarCat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminarCat.TabIndex = 113;
            this.btEliminarCat.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.btEliminarCat, "Eliminar");
            this.btEliminarCat.Click += new System.EventHandler(this.btEliminarCat_Click_1);
            // 
            // btActualizarCat
            // 
            this.btActualizarCat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizarCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualizarCat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btActualizarCat.Enabled = false;
            this.btActualizarCat.Location = new System.Drawing.Point(750, 191);
            this.btActualizarCat.Name = "btActualizarCat";
            this.btActualizarCat.Size = new System.Drawing.Size(53, 52);
            this.btActualizarCat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizarCat.TabIndex = 112;
            this.btActualizarCat.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.btActualizarCat, "Actualizar");
            this.btActualizarCat.Click += new System.EventHandler(this.btActualizarCat_Click_1);
            // 
            // btLimpiarCat
            // 
            this.btLimpiarCat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpiarCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiarCat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLimpiarCat.Location = new System.Drawing.Point(865, 192);
            this.btLimpiarCat.Name = "btLimpiarCat";
            this.btLimpiarCat.Size = new System.Drawing.Size(53, 52);
            this.btLimpiarCat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLimpiarCat.TabIndex = 115;
            this.btLimpiarCat.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.btLimpiarCat, "Limpiar");
            this.btLimpiarCat.Click += new System.EventHandler(this.btLimpiarCat_Click_1);
            // 
            // btREgistrarCat
            // 
            this.btREgistrarCat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btREgistrarCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btREgistrarCat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btREgistrarCat.Enabled = false;
            this.btREgistrarCat.Location = new System.Drawing.Point(691, 191);
            this.btREgistrarCat.Name = "btREgistrarCat";
            this.btREgistrarCat.Size = new System.Drawing.Size(53, 52);
            this.btREgistrarCat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btREgistrarCat.TabIndex = 111;
            this.btREgistrarCat.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btREgistrarCat, "Registrar");
            this.btREgistrarCat.Click += new System.EventHandler(this.btREgistrarCat_Click_1);
            // 
            // cbActivoCat
            // 
            this.cbActivoCat.DisplayMember = "Text";
            this.cbActivoCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActivoCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivoCat.FormattingEnabled = true;
            this.cbActivoCat.ItemHeight = 15;
            this.cbActivoCat.Items.AddRange(new object[] {
            this.comboItem7,
            this.comboItem8});
            this.cbActivoCat.Location = new System.Drawing.Point(25, 139);
            this.cbActivoCat.Name = "cbActivoCat";
            this.cbActivoCat.Size = new System.Drawing.Size(175, 21);
            this.cbActivoCat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbActivoCat.TabIndex = 110;
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "SI";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "NO";
            // 
            // tbDescripcionCat
            // 
            // 
            // 
            // 
            this.tbDescripcionCat.Border.Class = "TextBoxBorder";
            this.tbDescripcionCat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDescripcionCat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescripcionCat.Location = new System.Drawing.Point(25, 98);
            this.tbDescripcionCat.Name = "tbDescripcionCat";
            this.tbDescripcionCat.PreventEnterBeep = true;
            this.tbDescripcionCat.Size = new System.Drawing.Size(363, 20);
            this.tbDescripcionCat.TabIndex = 101;
            // 
            // tbNomCategoria
            // 
            // 
            // 
            // 
            this.tbNomCategoria.Border.Class = "TextBoxBorder";
            this.tbNomCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNomCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomCategoria.Location = new System.Drawing.Point(25, 59);
            this.tbNomCategoria.Name = "tbNomCategoria";
            this.tbNomCategoria.PreventEnterBeep = true;
            this.tbNomCategoria.Size = new System.Drawing.Size(175, 20);
            this.tbNomCategoria.TabIndex = 100;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(410, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(197, 13);
            this.label16.TabIndex = 98;
            this.label16.Text = "Información de las Categorias de Equipo";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 90;
            this.label25.Text = "Activo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 43);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(118, 13);
            this.label26.TabIndex = 86;
            this.label26.Text = "Nombre de la Categoria";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(25, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 87;
            this.label27.Text = "Descripción";
            // 
            // btImpSede
            // 
            this.btImpSede.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btImpSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImpSede.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btImpSede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImpSede.Location = new System.Drawing.Point(1035, 161);
            this.btImpSede.Name = "btImpSede";
            this.btImpSede.Size = new System.Drawing.Size(75, 23);
            this.btImpSede.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btImpSede.TabIndex = 131;
            this.btImpSede.Text = "Imprimir";
            this.toolTipListar.SetToolTip(this.btImpSede, "Imprimir");
            this.btImpSede.Click += new System.EventHandler(this.btImpSede_Click);
            // 
            // DGVSede
            // 
            this.DGVSede.AllowUserToAddRows = false;
            this.DGVSede.AllowUserToDeleteRows = false;
            this.DGVSede.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVSede.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSede.BackgroundColor = System.Drawing.Color.White;
            this.DGVSede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_sede,
            this.nombre_sede,
            this.direcionSede,
            this.observacionsede,
            this.activosede,
            this.Column45,
            this.Column46});
            this.DGVSede.Location = new System.Drawing.Point(9, 194);
            this.DGVSede.Name = "DGVSede";
            this.DGVSede.ReadOnly = true;
            this.DGVSede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSede.Size = new System.Drawing.Size(1197, 539);
            this.DGVSede.TabIndex = 14;
            this.DGVSede.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSede_CellClick);
            // 
            // cod_sede
            // 
            this.cod_sede.DataPropertyName = "c_sede";
            this.cod_sede.HeaderText = "Cod Sede";
            this.cod_sede.Name = "cod_sede";
            this.cod_sede.ReadOnly = true;
            this.cod_sede.Visible = false;
            // 
            // nombre_sede
            // 
            this.nombre_sede.DataPropertyName = "nombre_sede";
            this.nombre_sede.HeaderText = "Nombre Sede";
            this.nombre_sede.Name = "nombre_sede";
            this.nombre_sede.ReadOnly = true;
            // 
            // direcionSede
            // 
            this.direcionSede.DataPropertyName = "direccion";
            this.direcionSede.HeaderText = "Direccion";
            this.direcionSede.Name = "direcionSede";
            this.direcionSede.ReadOnly = true;
            // 
            // observacionsede
            // 
            this.observacionsede.DataPropertyName = "observacion";
            this.observacionsede.HeaderText = "Observación";
            this.observacionsede.Name = "observacionsede";
            this.observacionsede.ReadOnly = true;
            this.observacionsede.Visible = false;
            // 
            // activosede
            // 
            this.activosede.DataPropertyName = "activo";
            this.activosede.HeaderText = "Activo";
            this.activosede.Name = "activosede";
            this.activosede.ReadOnly = true;
            this.activosede.Visible = false;
            // 
            // Column45
            // 
            this.Column45.DataPropertyName = "c_distrito";
            this.Column45.HeaderText = "c_distrito";
            this.Column45.Name = "Column45";
            this.Column45.ReadOnly = true;
            this.Column45.Visible = false;
            // 
            // Column46
            // 
            this.Column46.DataPropertyName = "c_provincia";
            this.Column46.HeaderText = "c_provincia";
            this.Column46.Name = "Column46";
            this.Column46.ReadOnly = true;
            this.Column46.Visible = false;
            // 
            // tbBuscarSede
            // 
            // 
            // 
            // 
            this.tbBuscarSede.Border.Class = "TextBoxBorder";
            this.tbBuscarSede.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbBuscarSede.Location = new System.Drawing.Point(59, 164);
            this.tbBuscarSede.Name = "tbBuscarSede";
            this.tbBuscarSede.PreventEnterBeep = true;
            this.tbBuscarSede.Size = new System.Drawing.Size(206, 20);
            this.tbBuscarSede.TabIndex = 132;
            this.tbBuscarSede.TextChanged += new System.EventHandler(this.tbBuscarSede_TextChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(14, 161);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(44, 23);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "Buscar";
            // 
            // btImpInstancia
            // 
            this.btImpInstancia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btImpInstancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImpInstancia.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btImpInstancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImpInstancia.Location = new System.Drawing.Point(1045, 161);
            this.btImpInstancia.Name = "btImpInstancia";
            this.btImpInstancia.Size = new System.Drawing.Size(75, 23);
            this.btImpInstancia.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btImpInstancia.TabIndex = 150;
            this.btImpInstancia.Text = "Imprimir";
            this.toolTipListar.SetToolTip(this.btImpInstancia, "Imprimir");
            this.btImpInstancia.Click += new System.EventHandler(this.btImpInstancia_Click);
            // 
            // tbInstancia
            // 
            // 
            // 
            // 
            this.tbInstancia.Border.Class = "TextBoxBorder";
            this.tbInstancia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbInstancia.Location = new System.Drawing.Point(66, 154);
            this.tbInstancia.Name = "tbInstancia";
            this.tbInstancia.PreventEnterBeep = true;
            this.tbInstancia.Size = new System.Drawing.Size(287, 20);
            this.tbInstancia.TabIndex = 151;
            this.tbInstancia.TextChanged += new System.EventHandler(this.tbInstancia_TextChanged);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(15, 152);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(116, 23);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "Buscar";
            // 
            // DGVInstancia
            // 
            this.DGVInstancia.AllowUserToAddRows = false;
            this.DGVInstancia.AllowUserToDeleteRows = false;
            this.DGVInstancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVInstancia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVInstancia.BackgroundColor = System.Drawing.Color.White;
            this.DGVInstancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInstancia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column51,
            this.Column50,
            this.Column40,
            this.nombre_instancia,
            this.nro_instancia,
            this.Column47,
            this.activoInstancia});
            this.DGVInstancia.Location = new System.Drawing.Point(10, 195);
            this.DGVInstancia.Name = "DGVInstancia";
            this.DGVInstancia.ReadOnly = true;
            this.DGVInstancia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVInstancia.Size = new System.Drawing.Size(1196, 541);
            this.DGVInstancia.TabIndex = 12;
            this.DGVInstancia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInstancia_CellClick);
            // 
            // Column51
            // 
            this.Column51.DataPropertyName = "c_sede";
            this.Column51.HeaderText = "c_sede";
            this.Column51.Name = "Column51";
            this.Column51.ReadOnly = true;
            this.Column51.Visible = false;
            // 
            // Column50
            // 
            this.Column50.DataPropertyName = "c_instancia";
            this.Column50.HeaderText = "c_instancia";
            this.Column50.Name = "Column50";
            this.Column50.ReadOnly = true;
            this.Column50.Visible = false;
            // 
            // Column40
            // 
            this.Column40.DataPropertyName = "nombre_sede";
            this.Column40.HeaderText = "nombre_sede";
            this.Column40.Name = "Column40";
            this.Column40.ReadOnly = true;
            // 
            // nombre_instancia
            // 
            this.nombre_instancia.DataPropertyName = "nombre_instancia";
            this.nombre_instancia.HeaderText = "Nombre Instancia";
            this.nombre_instancia.Name = "nombre_instancia";
            this.nombre_instancia.ReadOnly = true;
            // 
            // nro_instancia
            // 
            this.nro_instancia.DataPropertyName = "nro_instancia";
            this.nro_instancia.HeaderText = "Nro Instancia";
            this.nro_instancia.Name = "nro_instancia";
            this.nro_instancia.ReadOnly = true;
            this.nro_instancia.Visible = false;
            // 
            // Column47
            // 
            this.Column47.DataPropertyName = "x_ubicacion_fisica";
            this.Column47.HeaderText = "Ubicación_Física";
            this.Column47.Name = "Column47";
            this.Column47.ReadOnly = true;
            this.Column47.Visible = false;
            // 
            // activoInstancia
            // 
            this.activoInstancia.DataPropertyName = "activo";
            this.activoInstancia.HeaderText = "Activo";
            this.activoInstancia.Name = "activoInstancia";
            this.activoInstancia.ReadOnly = true;
            this.activoInstancia.Visible = false;
            // 
            // cbProvincia_Sede
            // 
            this.cbProvincia_Sede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProvincia_Sede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProvincia_Sede.DisplayMember = "Text";
            this.cbProvincia_Sede.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProvincia_Sede.FormattingEnabled = true;
            this.cbProvincia_Sede.ItemHeight = 15;
            this.cbProvincia_Sede.Location = new System.Drawing.Point(842, 50);
            this.cbProvincia_Sede.Name = "cbProvincia_Sede";
            this.cbProvincia_Sede.Size = new System.Drawing.Size(176, 21);
            this.cbProvincia_Sede.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbProvincia_Sede.TabIndex = 123;
            this.cbProvincia_Sede.Visible = false;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(842, 34);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(51, 13);
            this.label62.TabIndex = 200;
            this.label62.Text = "Provincia";
            this.label62.Visible = false;
            // 
            // cbDistritoJud_sede
            // 
            this.cbDistritoJud_sede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDistritoJud_sede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDistritoJud_sede.DisplayMember = "Text";
            this.cbDistritoJud_sede.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDistritoJud_sede.FormattingEnabled = true;
            this.cbDistritoJud_sede.ItemHeight = 15;
            this.cbDistritoJud_sede.Location = new System.Drawing.Point(17, 93);
            this.cbDistritoJud_sede.Name = "cbDistritoJud_sede";
            this.cbDistritoJud_sede.Size = new System.Drawing.Size(336, 21);
            this.cbDistritoJud_sede.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDistritoJud_sede.TabIndex = 122;
            this.cbDistritoJud_sede.Visible = false;
            this.cbDistritoJud_sede.SelectedIndexChanged += new System.EventHandler(this.cbDistritoJud_sede_SelectedIndexChanged);
            this.cbDistritoJud_sede.Click += new System.EventHandler(this.cbDistritoJud_sede_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(14, 77);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(77, 13);
            this.label60.TabIndex = 800;
            this.label60.Text = "Distrito Judicial";
            this.label60.Visible = false;
            // 
            // tbDireccSede
            // 
            // 
            // 
            // 
            this.tbDireccSede.Border.Class = "TextBoxBorder";
            this.tbDireccSede.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDireccSede.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDireccSede.Enabled = false;
            this.tbDireccSede.Location = new System.Drawing.Point(368, 53);
            this.tbDireccSede.Name = "tbDireccSede";
            this.tbDireccSede.PreventEnterBeep = true;
            this.tbDireccSede.Size = new System.Drawing.Size(438, 20);
            this.tbDireccSede.TabIndex = 121;
            // 
            // tbNombreSede
            // 
            // 
            // 
            // 
            this.tbNombreSede.Border.Class = "TextBoxBorder";
            this.tbNombreSede.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNombreSede.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreSede.Enabled = false;
            this.tbNombreSede.Location = new System.Drawing.Point(15, 53);
            this.tbNombreSede.Name = "tbNombreSede";
            this.tbNombreSede.PreventEnterBeep = true;
            this.tbNombreSede.Size = new System.Drawing.Size(338, 20);
            this.tbNombreSede.TabIndex = 120;
            // 
            // tbObservSede
            // 
            // 
            // 
            // 
            this.tbObservSede.Border.Class = "TextBoxBorder";
            this.tbObservSede.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObservSede.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservSede.Location = new System.Drawing.Point(383, 93);
            this.tbObservSede.Name = "tbObservSede";
            this.tbObservSede.PreventEnterBeep = true;
            this.tbObservSede.Size = new System.Drawing.Size(132, 20);
            this.tbObservSede.TabIndex = 125;
            this.tbObservSede.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(383, 77);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 13);
            this.label28.TabIndex = 117;
            this.label28.Text = "Observación";
            this.label28.Visible = false;
            // 
            // cbActivoSede
            // 
            this.cbActivoSede.DisplayMember = "Text";
            this.cbActivoSede.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActivoSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivoSede.FormattingEnabled = true;
            this.cbActivoSede.ItemHeight = 15;
            this.cbActivoSede.Items.AddRange(new object[] {
            this.comboItem13,
            this.comboItem14});
            this.cbActivoSede.Location = new System.Drawing.Point(547, 91);
            this.cbActivoSede.Name = "cbActivoSede";
            this.cbActivoSede.Size = new System.Drawing.Size(80, 21);
            this.cbActivoSede.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbActivoSede.TabIndex = 124;
            this.cbActivoSede.Visible = false;
            // 
            // comboItem13
            // 
            this.comboItem13.Text = "S";
            // 
            // comboItem14
            // 
            this.comboItem14.Text = "N";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(566, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 113;
            this.label21.Text = "Activo";
            this.label21.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 13);
            this.label22.TabIndex = 111;
            this.label22.Text = "Nombre de la Sede *";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(365, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 112;
            this.label23.Text = "Dirección *";
            // 
            // btListarSede
            // 
            this.btListarSede.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListarSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListarSede.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListarSede.Location = new System.Drawing.Point(551, 161);
            this.btListarSede.Name = "btListarSede";
            this.btListarSede.Size = new System.Drawing.Size(75, 23);
            this.btListarSede.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btListarSede.TabIndex = 126;
            this.btListarSede.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListarSede, "Listar");
            this.btListarSede.Click += new System.EventHandler(this.btListarSede_Click_1);
            // 
            // btEliminarSede
            // 
            this.btEliminarSede.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminarSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarSede.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEliminarSede.Location = new System.Drawing.Point(840, 161);
            this.btEliminarSede.Name = "btEliminarSede";
            this.btEliminarSede.Size = new System.Drawing.Size(75, 23);
            this.btEliminarSede.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminarSede.TabIndex = 124;
            this.btEliminarSede.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.btEliminarSede, "Eliminar");
            this.btEliminarSede.Click += new System.EventHandler(this.btEliminarSede_Click_1);
            // 
            // btActualizarSede
            // 
            this.btActualizarSede.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizarSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualizarSede.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btActualizarSede.Enabled = false;
            this.btActualizarSede.Location = new System.Drawing.Point(743, 161);
            this.btActualizarSede.Name = "btActualizarSede";
            this.btActualizarSede.Size = new System.Drawing.Size(75, 23);
            this.btActualizarSede.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizarSede.TabIndex = 123;
            this.btActualizarSede.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.btActualizarSede, "Actualizar");
            this.btActualizarSede.Click += new System.EventHandler(this.btActualizarSede_Click_1);
            // 
            // btLimpiarSede
            // 
            this.btLimpiarSede.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpiarSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiarSede.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLimpiarSede.Location = new System.Drawing.Point(938, 161);
            this.btLimpiarSede.Name = "btLimpiarSede";
            this.btLimpiarSede.Size = new System.Drawing.Size(75, 23);
            this.btLimpiarSede.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLimpiarSede.TabIndex = 128;
            this.btLimpiarSede.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.btLimpiarSede, "Limpiar");
            this.btLimpiarSede.Click += new System.EventHandler(this.btLimpiarSede_Click_1);
            // 
            // btRegistrarSede
            // 
            this.btRegistrarSede.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btRegistrarSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarSede.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btRegistrarSede.Enabled = false;
            this.btRegistrarSede.Location = new System.Drawing.Point(649, 161);
            this.btRegistrarSede.Name = "btRegistrarSede";
            this.btRegistrarSede.Size = new System.Drawing.Size(75, 23);
            this.btRegistrarSede.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btRegistrarSede.TabIndex = 122;
            this.btRegistrarSede.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btRegistrarSede, "Registrar");
            this.btRegistrarSede.Click += new System.EventHandler(this.btRegistrarSede_Click_1);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(457, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 13);
            this.label24.TabIndex = 66;
            this.label24.Text = "Información de la Sede";
            // 
            // tbDirInstancia
            // 
            // 
            // 
            // 
            this.tbDirInstancia.Border.Class = "TextBoxBorder";
            this.tbDirInstancia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDirInstancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDirInstancia.Location = new System.Drawing.Point(230, 70);
            this.tbDirInstancia.Name = "tbDirInstancia";
            this.tbDirInstancia.PreventEnterBeep = true;
            this.tbDirInstancia.Size = new System.Drawing.Size(755, 20);
            this.tbDirInstancia.TabIndex = 143;
            this.tbDirInstancia.Visible = false;
            // 
            // cbSede_Instanc
            // 
            this.cbSede_Instanc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSede_Instanc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSede_Instanc.DisplayMember = "Text";
            this.cbSede_Instanc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSede_Instanc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSede_Instanc.Enabled = false;
            this.cbSede_Instanc.FormattingEnabled = true;
            this.cbSede_Instanc.ItemHeight = 15;
            this.cbSede_Instanc.Location = new System.Drawing.Point(14, 44);
            this.cbSede_Instanc.Name = "cbSede_Instanc";
            this.cbSede_Instanc.Size = new System.Drawing.Size(474, 21);
            this.cbSede_Instanc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSede_Instanc.TabIndex = 140;
            this.cbSede_Instanc.Click += new System.EventHandler(this.cbSede_Instanc_Click);
            this.cbSede_Instanc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSede_Instanc_KeyPress);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(14, 28);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(39, 13);
            this.label68.TabIndex = 139;
            this.label68.Text = "Sede *";
            // 
            // tbNroInst
            // 
            // 
            // 
            // 
            this.tbNroInst.Border.Class = "TextBoxBorder";
            this.tbNroInst.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroInst.Location = new System.Drawing.Point(231, 95);
            this.tbNroInst.Name = "tbNroInst";
            this.tbNroInst.PreventEnterBeep = true;
            this.tbNroInst.Size = new System.Drawing.Size(175, 20);
            this.tbNroInst.TabIndex = 142;
            this.tbNroInst.Visible = false;
            // 
            // cbActivoInst
            // 
            this.cbActivoInst.DisplayMember = "Text";
            this.cbActivoInst.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActivoInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivoInst.FormattingEnabled = true;
            this.cbActivoInst.ItemHeight = 15;
            this.cbActivoInst.Items.AddRange(new object[] {
            this.comboItem19,
            this.comboItem20});
            this.cbActivoInst.Location = new System.Drawing.Point(68, 69);
            this.cbActivoInst.Name = "cbActivoInst";
            this.cbActivoInst.Size = new System.Drawing.Size(67, 21);
            this.cbActivoInst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbActivoInst.TabIndex = 144;
            this.cbActivoInst.Visible = false;
            this.cbActivoInst.SelectedIndexChanged += new System.EventHandler(this.cbActivoInst_SelectedIndexChanged);
            // 
            // comboItem19
            // 
            this.comboItem19.Text = "S";
            // 
            // comboItem20
            // 
            this.comboItem20.Text = "N";
            // 
            // tbNombreInst
            // 
            // 
            // 
            // 
            this.tbNombreInst.Border.Class = "TextBoxBorder";
            this.tbNombreInst.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNombreInst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreInst.Enabled = false;
            this.tbNombreInst.Location = new System.Drawing.Point(524, 44);
            this.tbNombreInst.Name = "tbNombreInst";
            this.tbNombreInst.PreventEnterBeep = true;
            this.tbNombreInst.Size = new System.Drawing.Size(461, 20);
            this.tbNombreInst.TabIndex = 141;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(20, 72);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 128;
            this.label30.Text = "Activo";
            this.label30.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(521, 28);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(123, 13);
            this.label31.TabIndex = 126;
            this.label31.Text = "Nombre de la Instancia *";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(411, 8);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(134, 13);
            this.label33.TabIndex = 120;
            this.label33.Text = "Información de la Instancia";
            // 
            // btListarInst
            // 
            this.btListarInst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListarInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListarInst.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListarInst.Location = new System.Drawing.Point(611, 161);
            this.btListarInst.Name = "btListarInst";
            this.btListarInst.Size = new System.Drawing.Size(75, 23);
            this.btListarInst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btListarInst.TabIndex = 145;
            this.btListarInst.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListarInst, "Listar");
            this.btListarInst.Click += new System.EventHandler(this.btListarInst_Click_1);
            // 
            // btEliminarIns
            // 
            this.btEliminarIns.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminarIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarIns.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEliminarIns.Location = new System.Drawing.Point(874, 161);
            this.btEliminarIns.Name = "btEliminarIns";
            this.btEliminarIns.Size = new System.Drawing.Size(75, 23);
            this.btEliminarIns.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminarIns.TabIndex = 144;
            this.btEliminarIns.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.btEliminarIns, "Eliminar");
            this.btEliminarIns.Click += new System.EventHandler(this.btEliminarIns_Click_1);
            // 
            // btActualizarInst
            // 
            this.btActualizarInst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizarInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualizarInst.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btActualizarInst.Enabled = false;
            this.btActualizarInst.Location = new System.Drawing.Point(785, 161);
            this.btActualizarInst.Name = "btActualizarInst";
            this.btActualizarInst.Size = new System.Drawing.Size(75, 23);
            this.btActualizarInst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizarInst.TabIndex = 143;
            this.btActualizarInst.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.btActualizarInst, "Actualizar");
            this.btActualizarInst.Click += new System.EventHandler(this.btActualizarInst_Click_1);
            // 
            // btLimpiarInst
            // 
            this.btLimpiarInst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpiarInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiarInst.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLimpiarInst.Location = new System.Drawing.Point(961, 161);
            this.btLimpiarInst.Name = "btLimpiarInst";
            this.btLimpiarInst.Size = new System.Drawing.Size(75, 23);
            this.btLimpiarInst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLimpiarInst.TabIndex = 147;
            this.btLimpiarInst.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.btLimpiarInst, "Limpiar");
            this.btLimpiarInst.Click += new System.EventHandler(this.btLimpiarInst_Click_1);
            // 
            // btRegistrarIns
            // 
            this.btRegistrarIns.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btRegistrarIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarIns.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btRegistrarIns.Enabled = false;
            this.btRegistrarIns.Location = new System.Drawing.Point(696, 161);
            this.btRegistrarIns.Name = "btRegistrarIns";
            this.btRegistrarIns.Size = new System.Drawing.Size(75, 23);
            this.btRegistrarIns.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btRegistrarIns.TabIndex = 142;
            this.btRegistrarIns.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btRegistrarIns, "Registrar");
            this.btRegistrarIns.Click += new System.EventHandler(this.btRegistrarIns_Click_1);
            // 
            // btImpPerfil
            // 
            this.btImpPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btImpPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImpPerfil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btImpPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImpPerfil.Location = new System.Drawing.Point(832, 154);
            this.btImpPerfil.Name = "btImpPerfil";
            this.btImpPerfil.Size = new System.Drawing.Size(75, 23);
            this.btImpPerfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btImpPerfil.TabIndex = 136;
            this.btImpPerfil.Text = "Imprimir";
            this.toolTipListar.SetToolTip(this.btImpPerfil, "Imprimir");
            this.btImpPerfil.Click += new System.EventHandler(this.btImpPerfil_Click);
            // 
            // DGVPerfil
            // 
            this.DGVPerfil.AllowUserToAddRows = false;
            this.DGVPerfil.AllowUserToDeleteRows = false;
            this.DGVPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPerfil.BackgroundColor = System.Drawing.Color.White;
            this.DGVPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.DGVPerfil.Location = new System.Drawing.Point(9, 190);
            this.DGVPerfil.Name = "DGVPerfil";
            this.DGVPerfil.ReadOnly = true;
            this.DGVPerfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPerfil.Size = new System.Drawing.Size(985, 514);
            this.DGVPerfil.TabIndex = 16;
            this.DGVPerfil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "c_perfil";
            this.Column15.HeaderText = "cod_perfil";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "perfil";
            this.Column16.HeaderText = "perfil";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "observacion";
            this.Column17.HeaderText = "observacion";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "activo";
            this.Column18.HeaderText = "Activo";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            // 
            // tbPerfil
            // 
            // 
            // 
            // 
            this.tbPerfil.Border.Class = "TextBoxBorder";
            this.tbPerfil.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPerfil.Location = new System.Drawing.Point(93, 153);
            this.tbPerfil.Name = "tbPerfil";
            this.tbPerfil.PreventEnterBeep = true;
            this.tbPerfil.Size = new System.Drawing.Size(247, 20);
            this.tbPerfil.TabIndex = 139;
            this.tbPerfil.TextChanged += new System.EventHandler(this.tbPerfil_TextChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(48, 150);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 14;
            this.labelX7.Text = "Buscar";
            // 
            // label71
            // 
            this.label71.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(520, 420);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(57, 13);
            this.label71.TabIndex = 152;
            this.label71.Text = "Instancia *";
            this.label71.Visible = false;
            // 
            // cbInstanciaPersonal
            // 
            this.cbInstanciaPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbInstanciaPersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbInstanciaPersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbInstanciaPersonal.DisplayMember = "Text";
            this.cbInstanciaPersonal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInstanciaPersonal.DropDownHeight = 200;
            this.cbInstanciaPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstanciaPersonal.Enabled = false;
            this.cbInstanciaPersonal.FormattingEnabled = true;
            this.cbInstanciaPersonal.IntegralHeight = false;
            this.cbInstanciaPersonal.ItemHeight = 15;
            this.cbInstanciaPersonal.Location = new System.Drawing.Point(589, 412);
            this.cbInstanciaPersonal.Name = "cbInstanciaPersonal";
            this.cbInstanciaPersonal.Size = new System.Drawing.Size(380, 21);
            this.cbInstanciaPersonal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbInstanciaPersonal.TabIndex = 125;
            this.cbInstanciaPersonal.Visible = false;
            // 
            // cbSedePersonal
            // 
            this.cbSedePersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSedePersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSedePersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSedePersonal.DisplayMember = "Text";
            this.cbSedePersonal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSedePersonal.DropDownHeight = 200;
            this.cbSedePersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSedePersonal.Enabled = false;
            this.cbSedePersonal.FormattingEnabled = true;
            this.cbSedePersonal.IntegralHeight = false;
            this.cbSedePersonal.ItemHeight = 15;
            this.cbSedePersonal.Location = new System.Drawing.Point(47, 412);
            this.cbSedePersonal.Name = "cbSedePersonal";
            this.cbSedePersonal.Size = new System.Drawing.Size(448, 21);
            this.cbSedePersonal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSedePersonal.TabIndex = 124;
            this.cbSedePersonal.SelectedIndexChanged += new System.EventHandler(this.cbSedePersonal_SelectedIndexChanged);
            this.cbSedePersonal.Click += new System.EventHandler(this.cbSedePersonal_Click);
            // 
            // label69
            // 
            this.label69.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(3, 412);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(39, 13);
            this.label69.TabIndex = 147;
            this.label69.Text = "Sede *";
            // 
            // cbPerfilPersonal
            // 
            this.cbPerfilPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPerfilPersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPerfilPersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPerfilPersonal.DisplayMember = "Text";
            this.cbPerfilPersonal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPerfilPersonal.DropDownHeight = 200;
            this.cbPerfilPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerfilPersonal.Enabled = false;
            this.cbPerfilPersonal.FormattingEnabled = true;
            this.cbPerfilPersonal.IntegralHeight = false;
            this.cbPerfilPersonal.ItemHeight = 15;
            this.cbPerfilPersonal.Location = new System.Drawing.Point(47, 439);
            this.cbPerfilPersonal.Name = "cbPerfilPersonal";
            this.cbPerfilPersonal.Size = new System.Drawing.Size(448, 21);
            this.cbPerfilPersonal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbPerfilPersonal.TabIndex = 126;
            this.cbPerfilPersonal.SelectedIndexChanged += new System.EventHandler(this.cbPerfilPersonal_SelectedIndexChanged);
            this.cbPerfilPersonal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPerfilPersonal_MouseClick);
            // 
            // tbPaternoPersonal
            // 
            this.tbPaternoPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbPaternoPersonal.Border.Class = "TextBoxBorder";
            this.tbPaternoPersonal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPaternoPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPaternoPersonal.Enabled = false;
            this.tbPaternoPersonal.Location = new System.Drawing.Point(101, 139);
            this.tbPaternoPersonal.Name = "tbPaternoPersonal";
            this.tbPaternoPersonal.PreventEnterBeep = true;
            this.tbPaternoPersonal.Size = new System.Drawing.Size(352, 20);
            this.tbPaternoPersonal.TabIndex = 115;
            // 
            // label63
            // 
            this.label63.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(3, 139);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(91, 13);
            this.label63.TabIndex = 300;
            this.label63.Text = "Apellido Paterno *";
            // 
            // dtPersonal
            // 
            this.dtPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtPersonal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtPersonal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPersonal.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtPersonal.ButtonDropDown.Visible = true;
            this.dtPersonal.Enabled = false;
            this.dtPersonal.IsPopupCalendarOpen = false;
            this.dtPersonal.Location = new System.Drawing.Point(623, 142);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtPersonal.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPersonal.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtPersonal.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtPersonal.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtPersonal.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPersonal.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtPersonal.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtPersonal.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtPersonal.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtPersonal.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPersonal.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtPersonal.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtPersonal.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtPersonal.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPersonal.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtPersonal.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPersonal.MonthCalendar.TodayButtonVisible = true;
            this.dtPersonal.Name = "dtPersonal";
            this.dtPersonal.Size = new System.Drawing.Size(110, 20);
            this.dtPersonal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPersonal.TabIndex = 121;
            // 
            // cbEstadoPersonal
            // 
            this.cbEstadoPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEstadoPersonal.DisplayMember = "Text";
            this.cbEstadoPersonal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstadoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoPersonal.Enabled = false;
            this.cbEstadoPersonal.FormattingEnabled = true;
            this.cbEstadoPersonal.ItemHeight = 15;
            this.cbEstadoPersonal.Items.AddRange(new object[] {
            this.comboItem25,
            this.comboItem26});
            this.cbEstadoPersonal.Location = new System.Drawing.Point(623, 229);
            this.cbEstadoPersonal.Name = "cbEstadoPersonal";
            this.cbEstadoPersonal.Size = new System.Drawing.Size(110, 21);
            this.cbEstadoPersonal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstadoPersonal.TabIndex = 123;
            this.cbEstadoPersonal.SelectedIndexChanged += new System.EventHandler(this.cbActivoPersonal_SelectedIndexChanged);
            // 
            // comboItem25
            // 
            this.comboItem25.Text = "ACTIVO";
            this.comboItem25.Value = "";
            // 
            // comboItem26
            // 
            this.comboItem26.Text = "INACTIVO";
            this.comboItem26.Value = "";
            // 
            // tbDniPersonal
            // 
            this.tbDniPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbDniPersonal.Border.Class = "TextBoxBorder";
            this.tbDniPersonal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDniPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDniPersonal.Location = new System.Drawing.Point(101, 95);
            this.tbDniPersonal.MaxLength = 8;
            this.tbDniPersonal.Name = "tbDniPersonal";
            this.tbDniPersonal.PreventEnterBeep = true;
            this.tbDniPersonal.Size = new System.Drawing.Size(123, 20);
            this.tbDniPersonal.TabIndex = 114;
            this.tbDniPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniPersonal_KeyPress);
            this.tbDniPersonal.Leave += new System.EventHandler(this.tbDniPersonal_Leave);
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 102);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(33, 13);
            this.label43.TabIndex = 300;
            this.label43.Text = "DNI *";
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(2, 447);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(37, 13);
            this.label44.TabIndex = 300;
            this.label44.Text = "Perfil *";
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(512, 227);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(47, 13);
            this.label48.TabIndex = 300;
            this.label48.Text = "Estado *";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(512, 140);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 13);
            this.label34.TabIndex = 300;
            this.label34.Text = "Fecha de Ingreso";
            // 
            // tbMaternoPersonal
            // 
            this.tbMaternoPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbMaternoPersonal.Border.Class = "TextBoxBorder";
            this.tbMaternoPersonal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMaternoPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMaternoPersonal.Enabled = false;
            this.tbMaternoPersonal.Location = new System.Drawing.Point(101, 182);
            this.tbMaternoPersonal.Name = "tbMaternoPersonal";
            this.tbMaternoPersonal.PreventEnterBeep = true;
            this.tbMaternoPersonal.Size = new System.Drawing.Size(352, 20);
            this.tbMaternoPersonal.TabIndex = 116;
            // 
            // tbNombrePersonal
            // 
            this.tbNombrePersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbNombrePersonal.Border.Class = "TextBoxBorder";
            this.tbNombrePersonal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNombrePersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombrePersonal.Enabled = false;
            this.tbNombrePersonal.Location = new System.Drawing.Point(101, 229);
            this.tbNombrePersonal.Name = "tbNombrePersonal";
            this.tbNombrePersonal.PreventEnterBeep = true;
            this.tbNombrePersonal.Size = new System.Drawing.Size(352, 20);
            this.tbNombrePersonal.TabIndex = 117;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 231);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 13);
            this.label40.TabIndex = 111;
            this.label40.Text = "Nombres *";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 184);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(93, 13);
            this.label41.TabIndex = 112;
            this.label41.Text = "Apellido Materno *";
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(412, 15);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(212, 13);
            this.label42.TabIndex = 66;
            this.label42.Text = "REGISTRO DEL PERSONAL DE LA CSJU";
            // 
            // cbActivoPerfil
            // 
            this.cbActivoPerfil.DisplayMember = "Text";
            this.cbActivoPerfil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActivoPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivoPerfil.FormattingEnabled = true;
            this.cbActivoPerfil.ItemHeight = 15;
            this.cbActivoPerfil.Items.AddRange(new object[] {
            this.comboItem52,
            this.comboItem53});
            this.cbActivoPerfil.Location = new System.Drawing.Point(818, 49);
            this.cbActivoPerfil.Name = "cbActivoPerfil";
            this.cbActivoPerfil.Size = new System.Drawing.Size(75, 21);
            this.cbActivoPerfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbActivoPerfil.TabIndex = 132;
            this.cbActivoPerfil.Visible = false;
            // 
            // comboItem52
            // 
            this.comboItem52.Text = "S";
            // 
            // comboItem53
            // 
            this.comboItem53.Text = "N";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(821, 34);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 300;
            this.label32.Text = "Activo";
            this.label32.Visible = false;
            // 
            // tbObservPerfil
            // 
            // 
            // 
            // 
            this.tbObservPerfil.Border.Class = "TextBoxBorder";
            this.tbObservPerfil.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObservPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservPerfil.Enabled = false;
            this.tbObservPerfil.Location = new System.Drawing.Point(331, 50);
            this.tbObservPerfil.Name = "tbObservPerfil";
            this.tbObservPerfil.PreventEnterBeep = true;
            this.tbObservPerfil.Size = new System.Drawing.Size(457, 20);
            this.tbObservPerfil.TabIndex = 130;
            this.tbObservPerfil.Visible = false;
            // 
            // tbNombrePerfil
            // 
            // 
            // 
            // 
            this.tbNombrePerfil.Border.Class = "TextBoxBorder";
            this.tbNombrePerfil.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNombrePerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombrePerfil.Enabled = false;
            this.tbNombrePerfil.Location = new System.Drawing.Point(11, 50);
            this.tbNombrePerfil.Name = "tbNombrePerfil";
            this.tbNombrePerfil.PreventEnterBeep = true;
            this.tbNombrePerfil.Size = new System.Drawing.Size(284, 20);
            this.tbNombrePerfil.TabIndex = 129;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(11, 34);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(94, 13);
            this.label45.TabIndex = 126;
            this.label45.Text = "Nombre del Perfil *";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(331, 34);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(67, 13);
            this.label46.TabIndex = 127;
            this.label46.Text = "Observación";
            this.label46.Visible = false;
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(430, 12);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(104, 13);
            this.label47.TabIndex = 120;
            this.label47.Text = "Información del perfil";
            // 
            // btListarPerfil
            // 
            this.btListarPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListarPerfil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListarPerfil.Location = new System.Drawing.Point(385, 154);
            this.btListarPerfil.Name = "btListarPerfil";
            this.btListarPerfil.Size = new System.Drawing.Size(75, 23);
            this.btListarPerfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btListarPerfil.TabIndex = 134;
            this.btListarPerfil.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListarPerfil, "Listar");
            this.btListarPerfil.Click += new System.EventHandler(this.btListarPerfil_Click);
            // 
            // btEliminarPErfil
            // 
            this.btEliminarPErfil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminarPErfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarPErfil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEliminarPErfil.Location = new System.Drawing.Point(651, 154);
            this.btEliminarPErfil.Name = "btEliminarPErfil";
            this.btEliminarPErfil.Size = new System.Drawing.Size(75, 23);
            this.btEliminarPErfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminarPErfil.TabIndex = 133;
            this.btEliminarPErfil.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.btEliminarPErfil, "Eliminar");
            this.btEliminarPErfil.Click += new System.EventHandler(this.btEliminarPErfil_Click);
            // 
            // btActualizarPerfil
            // 
            this.btActualizarPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualizarPerfil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btActualizarPerfil.Enabled = false;
            this.btActualizarPerfil.Location = new System.Drawing.Point(562, 154);
            this.btActualizarPerfil.Name = "btActualizarPerfil";
            this.btActualizarPerfil.Size = new System.Drawing.Size(75, 23);
            this.btActualizarPerfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizarPerfil.TabIndex = 132;
            this.btActualizarPerfil.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.btActualizarPerfil, "Actualizar");
            this.btActualizarPerfil.Click += new System.EventHandler(this.btActualizarPerfil_Click);
            // 
            // btLimpiarPerfil
            // 
            this.btLimpiarPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpiarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiarPerfil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLimpiarPerfil.Location = new System.Drawing.Point(741, 154);
            this.btLimpiarPerfil.Name = "btLimpiarPerfil";
            this.btLimpiarPerfil.Size = new System.Drawing.Size(75, 23);
            this.btLimpiarPerfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLimpiarPerfil.TabIndex = 135;
            this.btLimpiarPerfil.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.btLimpiarPerfil, "Limpiar");
            this.btLimpiarPerfil.Click += new System.EventHandler(this.btLimpiarPerfil_Click);
            // 
            // btRegistrarPerfil
            // 
            this.btRegistrarPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btRegistrarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarPerfil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btRegistrarPerfil.Enabled = false;
            this.btRegistrarPerfil.Location = new System.Drawing.Point(470, 154);
            this.btRegistrarPerfil.Name = "btRegistrarPerfil";
            this.btRegistrarPerfil.Size = new System.Drawing.Size(75, 23);
            this.btRegistrarPerfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btRegistrarPerfil.TabIndex = 131;
            this.btRegistrarPerfil.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btRegistrarPerfil, "Registrar");
            this.btRegistrarPerfil.Click += new System.EventHandler(this.btRegistrarPerfil_Click);
            // 
            // DGVAsignacionSoft
            // 
            this.DGVAsignacionSoft.AllowUserToAddRows = false;
            this.DGVAsignacionSoft.AllowUserToDeleteRows = false;
            this.DGVAsignacionSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVAsignacionSoft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAsignacionSoft.BackgroundColor = System.Drawing.Color.White;
            this.DGVAsignacionSoft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAsignacionSoft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column39,
            this.Column32,
            this.Column33,
            this.Column34,
            this.Column35,
            this.Column36,
            this.Column37,
            this.Column38});
            this.DGVAsignacionSoft.Location = new System.Drawing.Point(8, 379);
            this.DGVAsignacionSoft.Name = "DGVAsignacionSoft";
            this.DGVAsignacionSoft.ReadOnly = true;
            this.DGVAsignacionSoft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAsignacionSoft.Size = new System.Drawing.Size(986, 325);
            this.DGVAsignacionSoft.TabIndex = 17;
            this.DGVAsignacionSoft.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAsignacionSoft_CellClick_1);
            // 
            // Column39
            // 
            this.Column39.DataPropertyName = "codSofEq";
            this.Column39.HeaderText = "codSofEq";
            this.Column39.Name = "Column39";
            this.Column39.ReadOnly = true;
            this.Column39.Visible = false;
            // 
            // Column32
            // 
            this.Column32.DataPropertyName = "codEqAS";
            this.Column32.HeaderText = "codEqAS";
            this.Column32.Name = "Column32";
            this.Column32.ReadOnly = true;
            this.Column32.Visible = false;
            // 
            // Column33
            // 
            this.Column33.DataPropertyName = "cod_software";
            this.Column33.HeaderText = "cod_software";
            this.Column33.Name = "Column33";
            this.Column33.ReadOnly = true;
            this.Column33.Visible = false;
            // 
            // Column34
            // 
            this.Column34.DataPropertyName = "software";
            this.Column34.HeaderText = "software";
            this.Column34.Name = "Column34";
            this.Column34.ReadOnly = true;
            // 
            // Column35
            // 
            this.Column35.DataPropertyName = "nomEquipoAS";
            this.Column35.HeaderText = "nomEquipoAS";
            this.Column35.Name = "Column35";
            this.Column35.ReadOnly = true;
            // 
            // Column36
            // 
            this.Column36.DataPropertyName = "finstalacion";
            this.Column36.HeaderText = "fecha instalación";
            this.Column36.Name = "Column36";
            this.Column36.ReadOnly = true;
            // 
            // Column37
            // 
            this.Column37.DataPropertyName = "fcaducidad";
            this.Column37.HeaderText = "fecha Caducidad";
            this.Column37.Name = "Column37";
            this.Column37.ReadOnly = true;
            // 
            // Column38
            // 
            this.Column38.DataPropertyName = "observ";
            this.Column38.HeaderText = "Observación";
            this.Column38.Name = "Column38";
            this.Column38.ReadOnly = true;
            // 
            // tbAsignacionSoft
            // 
            // 
            // 
            // 
            this.tbAsignacionSoft.Border.Class = "TextBoxBorder";
            this.tbAsignacionSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAsignacionSoft.Location = new System.Drawing.Point(79, 342);
            this.tbAsignacionSoft.Name = "tbAsignacionSoft";
            this.tbAsignacionSoft.PreventEnterBeep = true;
            this.tbAsignacionSoft.Size = new System.Drawing.Size(387, 20);
            this.tbAsignacionSoft.TabIndex = 357;
            this.tbAsignacionSoft.TextChanged += new System.EventHandler(this.tbAsignacionSoft_TextChanged);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(14, 339);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 15;
            this.labelX8.Text = "Buscar";
            // 
            // cbCodSoftAS
            // 
            this.cbCodSoftAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCodSoftAS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCodSoftAS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCodSoftAS.DisplayMember = "Text";
            this.cbCodSoftAS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCodSoftAS.FormattingEnabled = true;
            this.cbCodSoftAS.ItemHeight = 15;
            this.cbCodSoftAS.Location = new System.Drawing.Point(10, 58);
            this.cbCodSoftAS.Name = "cbCodSoftAS";
            this.cbCodSoftAS.Size = new System.Drawing.Size(456, 21);
            this.cbCodSoftAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCodSoftAS.TabIndex = 346;
            this.cbCodSoftAS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbCodSoftAS_KeyUp);
            this.cbCodSoftAS.Leave += new System.EventHandler(this.cbCodSoftAS2_Leave);
            // 
            // label88
            // 
            this.label88.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(10, 126);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(42, 13);
            this.label88.TabIndex = 344;
            this.label88.Text = "Versión";
            // 
            // label89
            // 
            this.label89.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(10, 96);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(49, 13);
            this.label89.TabIndex = 343;
            this.label89.Text = "Software";
            // 
            // textBoxX8
            // 
            this.textBoxX8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX8.Border.Class = "TextBoxBorder";
            this.textBoxX8.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX8.Enabled = false;
            this.textBoxX8.Location = new System.Drawing.Point(66, 119);
            this.textBoxX8.Name = "textBoxX8";
            this.textBoxX8.PreventEnterBeep = true;
            this.textBoxX8.Size = new System.Drawing.Size(402, 20);
            this.textBoxX8.TabIndex = 341;
            // 
            // textBoxX9
            // 
            this.textBoxX9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX9.Border.Class = "TextBoxBorder";
            this.textBoxX9.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX9.Enabled = false;
            this.textBoxX9.Location = new System.Drawing.Point(66, 89);
            this.textBoxX9.Name = "textBoxX9";
            this.textBoxX9.PreventEnterBeep = true;
            this.textBoxX9.Size = new System.Drawing.Size(402, 20);
            this.textBoxX9.TabIndex = 340;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Enabled = false;
            this.textBoxX2.Location = new System.Drawing.Point(548, 183);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(432, 20);
            this.textBoxX2.TabIndex = 339;
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(480, 219);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(68, 13);
            this.label59.TabIndex = 338;
            this.label59.Text = "C Patrimonial";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Enabled = false;
            this.textBoxX1.Location = new System.Drawing.Point(548, 216);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(432, 20);
            this.textBoxX1.TabIndex = 337;
            // 
            // label82
            // 
            this.label82.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(481, 186);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(31, 13);
            this.label82.TabIndex = 336;
            this.label82.Text = "Serie";
            // 
            // label83
            // 
            this.label83.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(481, 153);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(42, 13);
            this.label83.TabIndex = 335;
            this.label83.Text = "Modelo";
            // 
            // label84
            // 
            this.label84.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(481, 126);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(37, 13);
            this.label84.TabIndex = 334;
            this.label84.Text = "Marca";
            // 
            // label85
            // 
            this.label85.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(481, 96);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(40, 13);
            this.label85.TabIndex = 333;
            this.label85.Text = "Equipo";
            // 
            // textBoxX3
            // 
            this.textBoxX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.Enabled = false;
            this.textBoxX3.Location = new System.Drawing.Point(549, 151);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(432, 20);
            this.textBoxX3.TabIndex = 331;
            // 
            // textBoxX4
            // 
            this.textBoxX4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.Enabled = false;
            this.textBoxX4.Location = new System.Drawing.Point(549, 119);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.PreventEnterBeep = true;
            this.textBoxX4.Size = new System.Drawing.Size(432, 20);
            this.textBoxX4.TabIndex = 330;
            // 
            // textBoxX5
            // 
            this.textBoxX5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX5.Enabled = false;
            this.textBoxX5.Location = new System.Drawing.Point(549, 89);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.PreventEnterBeep = true;
            this.textBoxX5.Size = new System.Drawing.Size(432, 20);
            this.textBoxX5.TabIndex = 329;
            // 
            // label80
            // 
            this.label80.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(478, 37);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(325, 13);
            this.label80.TabIndex = 319;
            this.label80.Text = "BUSCAR POR: Equipo / Marca /  Modelo / Serie /  CodPatrimonial";
            // 
            // label81
            // 
            this.label81.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(639, 10);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(115, 13);
            this.label81.TabIndex = 318;
            this.label81.Text = "Información del Equipo";
            // 
            // cbCodEquipoAS
            // 
            this.cbCodEquipoAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCodEquipoAS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCodEquipoAS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCodEquipoAS.DisplayMember = "Text";
            this.cbCodEquipoAS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCodEquipoAS.FormattingEnabled = true;
            this.cbCodEquipoAS.ItemHeight = 15;
            this.cbCodEquipoAS.Location = new System.Drawing.Point(481, 58);
            this.cbCodEquipoAS.Name = "cbCodEquipoAS";
            this.cbCodEquipoAS.Size = new System.Drawing.Size(502, 21);
            this.cbCodEquipoAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCodEquipoAS.TabIndex = 347;
            this.cbCodEquipoAS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbCodEquipoAS_KeyUp);
            this.cbCodEquipoAS.Leave += new System.EventHandler(this.cbCodEquipoAS_Leave);
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(188, 236);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(91, 13);
            this.label57.TabIndex = 300;
            this.label57.Text = "Fecha Caducidad";
            // 
            // dtFechaCaducidadAS
            // 
            this.dtFechaCaducidadAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaCaducidadAS.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaCaducidadAS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCaducidadAS.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaCaducidadAS.ButtonDropDown.Visible = true;
            this.dtFechaCaducidadAS.IsPopupCalendarOpen = false;
            this.dtFechaCaducidadAS.Location = new System.Drawing.Point(191, 252);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaCaducidadAS.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCaducidadAS.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaCaducidadAS.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaCaducidadAS.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaCaducidadAS.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaCaducidadAS.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaCaducidadAS.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaCaducidadAS.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaCaducidadAS.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaCaducidadAS.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCaducidadAS.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaCaducidadAS.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaCaducidadAS.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaCaducidadAS.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaCaducidadAS.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaCaducidadAS.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCaducidadAS.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaCaducidadAS.Name = "dtFechaCaducidadAS";
            this.dtFechaCaducidadAS.Size = new System.Drawing.Size(177, 20);
            this.dtFechaCaducidadAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaCaducidadAS.TabIndex = 349;
            // 
            // dtFechaInstalacionAS
            // 
            this.dtFechaInstalacionAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaInstalacionAS.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInstalacionAS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInstalacionAS.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInstalacionAS.ButtonDropDown.Visible = true;
            this.dtFechaInstalacionAS.IsPopupCalendarOpen = false;
            this.dtFechaInstalacionAS.Location = new System.Drawing.Point(8, 252);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaInstalacionAS.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInstalacionAS.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaInstalacionAS.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaInstalacionAS.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaInstalacionAS.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInstalacionAS.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaInstalacionAS.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaInstalacionAS.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaInstalacionAS.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaInstalacionAS.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInstalacionAS.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaInstalacionAS.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaInstalacionAS.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaInstalacionAS.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInstalacionAS.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaInstalacionAS.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInstalacionAS.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaInstalacionAS.Name = "dtFechaInstalacionAS";
            this.dtFechaInstalacionAS.Size = new System.Drawing.Size(174, 20);
            this.dtFechaInstalacionAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInstalacionAS.TabIndex = 348;
            // 
            // tbObservacionAS
            // 
            this.tbObservacionAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbObservacionAS.Border.Class = "TextBoxBorder";
            this.tbObservacionAS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObservacionAS.Location = new System.Drawing.Point(398, 252);
            this.tbObservacionAS.Name = "tbObservacionAS";
            this.tbObservacionAS.PreventEnterBeep = true;
            this.tbObservacionAS.Size = new System.Drawing.Size(416, 20);
            this.tbObservacionAS.TabIndex = 350;
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(395, 236);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(67, 13);
            this.label50.TabIndex = 141;
            this.label50.Text = "Observación";
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(153, 10);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(124, 13);
            this.label53.TabIndex = 127;
            this.label53.Text = "Información del Software";
            this.label53.Click += new System.EventHandler(this.label53_Click);
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(5, 37);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(225, 13);
            this.label55.TabIndex = 124;
            this.label55.Text = "BUSCAR POR: Nombre del Software | Versión";
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(5, 236);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(151, 13);
            this.label56.TabIndex = 125;
            this.label56.Text = "Fecha Instalación del software";
            // 
            // label74
            // 
            this.label74.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(511, 108);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(50, 13);
            this.label74.TabIndex = 308;
            this.label74.Text = "Instancia";
            // 
            // label73
            // 
            this.label73.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(529, 86);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(32, 13);
            this.label73.TabIndex = 307;
            this.label73.Text = "Sede";
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(3, 59);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(26, 13);
            this.label58.TabIndex = 306;
            this.label58.Text = "DNI";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 305;
            this.label14.Text = "Nombre";
            // 
            // tbInstancAE
            // 
            this.tbInstancAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbInstancAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbInstancAE.Enabled = false;
            this.tbInstancAE.Location = new System.Drawing.Point(570, 113);
            this.tbInstancAE.Multiline = true;
            this.tbInstancAE.Name = "tbInstancAE";
            this.tbInstancAE.PreventEnterBeep = true;
            this.tbInstancAE.Size = new System.Drawing.Size(323, 14);
            this.tbInstancAE.TabIndex = 304;
            // 
            // tbSedeAE
            // 
            this.tbSedeAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbSedeAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSedeAE.Enabled = false;
            this.tbSedeAE.Location = new System.Drawing.Point(570, 87);
            this.tbSedeAE.Name = "tbSedeAE";
            this.tbSedeAE.PreventEnterBeep = true;
            this.tbSedeAE.Size = new System.Drawing.Size(323, 14);
            this.tbSedeAE.TabIndex = 303;
            // 
            // tbDniAE
            // 
            this.tbDniAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbDniAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDniAE.Location = new System.Drawing.Point(66, 61);
            this.tbDniAE.Name = "tbDniAE";
            this.tbDniAE.PreventEnterBeep = true;
            this.tbDniAE.Size = new System.Drawing.Size(146, 14);
            this.tbDniAE.TabIndex = 199;
            this.tbDniAE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniAE_KeyPress);
            this.tbDniAE.Leave += new System.EventHandler(this.tbDniAE_Leave);
            // 
            // tbNombreAE
            // 
            this.tbNombreAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbNombreAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNombreAE.Enabled = false;
            this.tbNombreAE.Location = new System.Drawing.Point(66, 81);
            this.tbNombreAE.Name = "tbNombreAE";
            this.tbNombreAE.PreventEnterBeep = true;
            this.tbNombreAE.Size = new System.Drawing.Size(354, 14);
            this.tbNombreAE.TabIndex = 301;
            // 
            // dtFechaIngAE
            // 
            this.dtFechaIngAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaIngAE.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaIngAE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaIngAE.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaIngAE.ButtonDropDown.Visible = true;
            this.dtFechaIngAE.Enabled = false;
            this.dtFechaIngAE.IsPopupCalendarOpen = false;
            this.dtFechaIngAE.Location = new System.Drawing.Point(117, 105);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaIngAE.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaIngAE.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaIngAE.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaIngAE.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaIngAE.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaIngAE.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaIngAE.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaIngAE.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaIngAE.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaIngAE.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaIngAE.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaIngAE.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaIngAE.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaIngAE.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaIngAE.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaIngAE.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaIngAE.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaIngAE.Name = "dtFechaIngAE";
            this.dtFechaIngAE.Size = new System.Drawing.Size(182, 20);
            this.dtFechaIngAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaIngAE.TabIndex = 160;
            // 
            // label67
            // 
            this.label67.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(3, 38);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(176, 13);
            this.label67.TabIndex = 300;
            this.label67.Text = "BUSCAR POR: Nombre o Dni ";
            // 
            // cbCodPersonalAE
            // 
            this.cbCodPersonalAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCodPersonalAE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCodPersonalAE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCodPersonalAE.DisplayMember = "Text";
            this.cbCodPersonalAE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCodPersonalAE.DropDownWidth = 900;
            this.cbCodPersonalAE.FormattingEnabled = true;
            this.cbCodPersonalAE.ItemHeight = 15;
            this.cbCodPersonalAE.Location = new System.Drawing.Point(193, 34);
            this.cbCodPersonalAE.Name = "cbCodPersonalAE";
            this.cbCodPersonalAE.Size = new System.Drawing.Size(267, 21);
            this.cbCodPersonalAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCodPersonalAE.TabIndex = 158;
            this.cbCodPersonalAE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbCodPersonalAE_KeyUp);
            this.cbCodPersonalAE.Leave += new System.EventHandler(this.cbCodPersonalAE_Leave);
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(357, 8);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(181, 13);
            this.label54.TabIndex = 154;
            this.label54.Text = "Información de asignación de equipo";
            // 
            // label66
            // 
            this.label66.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(3, 110);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(90, 13);
            this.label66.TabIndex = 125;
            this.label66.Text = "Fecha de Ingreso";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "No precisa";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "No";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Si";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "N/S";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "No";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "si";
            // 
            // comboItem12
            // 
            this.comboItem12.Text = "NS";
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "No";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "Si";
            // 
            // btListaAE
            // 
            this.btListaAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListaAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListaAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListaAE.Location = new System.Drawing.Point(909, 49);
            this.btListaAE.Name = "btListaAE";
            this.btListaAE.Size = new System.Drawing.Size(53, 52);
            this.btListaAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btListaAE.TabIndex = 219;
            this.btListaAE.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListaAE, "Listar");
            this.btListaAE.Click += new System.EventHandler(this.btListaAE_Click);
            // 
            // btListaSoftAE
            // 
            this.btListaSoftAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListaSoftAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListaSoftAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListaSoftAE.Location = new System.Drawing.Point(906, 48);
            this.btListaSoftAE.Name = "btListaSoftAE";
            this.btListaSoftAE.Size = new System.Drawing.Size(53, 52);
            this.btListaSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btListaSoftAE.TabIndex = 253;
            this.btListaSoftAE.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListaSoftAE, "Listar");
            this.btListaSoftAE.Click += new System.EventHandler(this.btListaSoftAE_Click);
            // 
            // buttonX15
            // 
            this.buttonX15.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX15.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX15.Location = new System.Drawing.Point(909, 50);
            this.buttonX15.Name = "buttonX15";
            this.buttonX15.Size = new System.Drawing.Size(53, 52);
            this.buttonX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX15.TabIndex = 263;
            this.buttonX15.Text = "Listar";
            this.toolTipListar.SetToolTip(this.buttonX15, "Listar");
            // 
            // btListaAECCom
            // 
            this.btListaAECCom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListaAECCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListaAECCom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btListaAECCom.Location = new System.Drawing.Point(909, 50);
            this.btListaAECCom.Name = "btListaAECCom";
            this.btListaAECCom.Size = new System.Drawing.Size(53, 52);
            this.btListaAECCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btListaAECCom.TabIndex = 255;
            this.btListaAECCom.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListaAECCom, "Listar");
            this.btListaAECCom.Click += new System.EventHandler(this.btListaAECCom_Click);
            // 
            // btListarAS
            // 
            this.btListarAS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btListarAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListarAS.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btListarAS.Image = ((System.Drawing.Image)(resources.GetObject("btListarAS.Image")));
            this.btListarAS.Location = new System.Drawing.Point(642, 313);
            this.btListarAS.Name = "btListarAS";
            this.btListarAS.Size = new System.Drawing.Size(53, 52);
            this.btListarAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btListarAS.TabIndex = 351;
            this.btListarAS.Text = "Listar";
            this.toolTipListar.SetToolTip(this.btListarAS, "Listar");
            this.btListarAS.Click += new System.EventHandler(this.btListarAS_Click);
            // 
            // btRegistrarAE
            // 
            this.btRegistrarAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btRegistrarAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btRegistrarAE.Enabled = false;
            this.btRegistrarAE.Location = new System.Drawing.Point(909, 109);
            this.btRegistrarAE.Name = "btRegistrarAE";
            this.btRegistrarAE.Size = new System.Drawing.Size(53, 52);
            this.btRegistrarAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btRegistrarAE.TabIndex = 216;
            this.btRegistrarAE.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btRegistrarAE, "Registrar");
            this.btRegistrarAE.Click += new System.EventHandler(this.btRegistrarAE_Click);
            // 
            // btGrabarSoftAE
            // 
            this.btGrabarSoftAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGrabarSoftAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGrabarSoftAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGrabarSoftAE.Enabled = false;
            this.btGrabarSoftAE.Location = new System.Drawing.Point(906, 108);
            this.btGrabarSoftAE.Name = "btGrabarSoftAE";
            this.btGrabarSoftAE.Size = new System.Drawing.Size(53, 52);
            this.btGrabarSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGrabarSoftAE.TabIndex = 250;
            this.btGrabarSoftAE.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btGrabarSoftAE, "Registrar");
            this.btGrabarSoftAE.Click += new System.EventHandler(this.btGrabarSoftAE_Click);
            // 
            // buttonX16
            // 
            this.buttonX16.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX16.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX16.Enabled = false;
            this.buttonX16.Location = new System.Drawing.Point(909, 110);
            this.buttonX16.Name = "buttonX16";
            this.buttonX16.Size = new System.Drawing.Size(53, 52);
            this.buttonX16.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX16.TabIndex = 259;
            this.buttonX16.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.buttonX16, "Registrar");
            // 
            // btRegistrarAECCom
            // 
            this.btRegistrarAECCom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btRegistrarAECCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarAECCom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btRegistrarAECCom.Enabled = false;
            this.btRegistrarAECCom.Location = new System.Drawing.Point(909, 110);
            this.btRegistrarAECCom.Name = "btRegistrarAECCom";
            this.btRegistrarAECCom.Size = new System.Drawing.Size(53, 52);
            this.btRegistrarAECCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btRegistrarAECCom.TabIndex = 252;
            this.btRegistrarAECCom.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btRegistrarAECCom, "Registrar");
            this.btRegistrarAECCom.Click += new System.EventHandler(this.btRegistrarAECCom_Click);
            // 
            // btRegistrarAS
            // 
            this.btRegistrarAS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btRegistrarAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarAS.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btRegistrarAS.Image = ((System.Drawing.Image)(resources.GetObject("btRegistrarAS.Image")));
            this.btRegistrarAS.Location = new System.Drawing.Point(700, 313);
            this.btRegistrarAS.Name = "btRegistrarAS";
            this.btRegistrarAS.Size = new System.Drawing.Size(53, 52);
            this.btRegistrarAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btRegistrarAS.TabIndex = 352;
            this.btRegistrarAS.Text = "Grabar";
            this.toolTipRegistrar.SetToolTip(this.btRegistrarAS, "Registrar");
            this.btRegistrarAS.Click += new System.EventHandler(this.btRegistrarAS_Click);
            // 
            // tbLimpiarAE
            // 
            this.tbLimpiarAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbLimpiarAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLimpiarAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbLimpiarAE.Location = new System.Drawing.Point(909, 295);
            this.tbLimpiarAE.Name = "tbLimpiarAE";
            this.tbLimpiarAE.Size = new System.Drawing.Size(53, 52);
            this.tbLimpiarAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbLimpiarAE.TabIndex = 220;
            this.tbLimpiarAE.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.tbLimpiarAE, "Limpiar");
            this.tbLimpiarAE.Click += new System.EventHandler(this.tbLimpiarAE_Click);
            // 
            // btLimpiarSoftAE
            // 
            this.btLimpiarSoftAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpiarSoftAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiarSoftAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLimpiarSoftAE.Location = new System.Drawing.Point(906, 294);
            this.btLimpiarSoftAE.Name = "btLimpiarSoftAE";
            this.btLimpiarSoftAE.Size = new System.Drawing.Size(53, 52);
            this.btLimpiarSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLimpiarSoftAE.TabIndex = 254;
            this.btLimpiarSoftAE.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.btLimpiarSoftAE, "Limpiar");
            this.btLimpiarSoftAE.Click += new System.EventHandler(this.btLimpiarSoftAE_Click);
            // 
            // buttonX19
            // 
            this.buttonX19.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX19.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX19.Location = new System.Drawing.Point(909, 296);
            this.buttonX19.Name = "buttonX19";
            this.buttonX19.Size = new System.Drawing.Size(53, 52);
            this.buttonX19.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX19.TabIndex = 264;
            this.buttonX19.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.buttonX19, "Limpiar");
            // 
            // tbLimpiarAECCom
            // 
            this.tbLimpiarAECCom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbLimpiarAECCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLimpiarAECCom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbLimpiarAECCom.Location = new System.Drawing.Point(909, 296);
            this.tbLimpiarAECCom.Name = "tbLimpiarAECCom";
            this.tbLimpiarAECCom.Size = new System.Drawing.Size(53, 52);
            this.tbLimpiarAECCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbLimpiarAECCom.TabIndex = 256;
            this.tbLimpiarAECCom.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.tbLimpiarAECCom, "Limpiar");
            this.tbLimpiarAECCom.Click += new System.EventHandler(this.tbLimpiarAECCom_Click);
            // 
            // btLimpiarAS
            // 
            this.btLimpiarAS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpiarAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiarAS.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btLimpiarAS.Image = ((System.Drawing.Image)(resources.GetObject("btLimpiarAS.Image")));
            this.btLimpiarAS.Location = new System.Drawing.Point(752, 313);
            this.btLimpiarAS.Name = "btLimpiarAS";
            this.btLimpiarAS.Size = new System.Drawing.Size(53, 52);
            this.btLimpiarAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLimpiarAS.TabIndex = 353;
            this.btLimpiarAS.Text = "Limpiar";
            this.toolTipLimpiar.SetToolTip(this.btLimpiarAS, "Limpiar");
            this.btLimpiarAS.Click += new System.EventHandler(this.btLimpiarAS_Click);
            // 
            // tbActualizarAE
            // 
            this.tbActualizarAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbActualizarAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbActualizarAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbActualizarAE.Enabled = false;
            this.tbActualizarAE.Location = new System.Drawing.Point(909, 168);
            this.tbActualizarAE.Name = "tbActualizarAE";
            this.tbActualizarAE.Size = new System.Drawing.Size(53, 52);
            this.tbActualizarAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbActualizarAE.TabIndex = 217;
            this.tbActualizarAE.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.tbActualizarAE, "Actualizar");
            this.tbActualizarAE.Click += new System.EventHandler(this.tbActualizarAE_Click);
            // 
            // btActualizarSoftAE
            // 
            this.btActualizarSoftAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizarSoftAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualizarSoftAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btActualizarSoftAE.Enabled = false;
            this.btActualizarSoftAE.Location = new System.Drawing.Point(906, 167);
            this.btActualizarSoftAE.Name = "btActualizarSoftAE";
            this.btActualizarSoftAE.Size = new System.Drawing.Size(53, 52);
            this.btActualizarSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizarSoftAE.TabIndex = 251;
            this.btActualizarSoftAE.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.btActualizarSoftAE, "Actualizar");
            this.btActualizarSoftAE.Click += new System.EventHandler(this.btActualizarSoftAE_Click);
            // 
            // buttonX17
            // 
            this.buttonX17.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX17.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX17.Enabled = false;
            this.buttonX17.Location = new System.Drawing.Point(909, 169);
            this.buttonX17.Name = "buttonX17";
            this.buttonX17.Size = new System.Drawing.Size(53, 52);
            this.buttonX17.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX17.TabIndex = 260;
            this.buttonX17.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.buttonX17, "Actualizar");
            // 
            // tbActualizarAECCom
            // 
            this.tbActualizarAECCom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbActualizarAECCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbActualizarAECCom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbActualizarAECCom.Enabled = false;
            this.tbActualizarAECCom.Location = new System.Drawing.Point(909, 169);
            this.tbActualizarAECCom.Name = "tbActualizarAECCom";
            this.tbActualizarAECCom.Size = new System.Drawing.Size(53, 52);
            this.tbActualizarAECCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbActualizarAECCom.TabIndex = 253;
            this.tbActualizarAECCom.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.tbActualizarAECCom, "Actualizar");
            this.tbActualizarAECCom.Click += new System.EventHandler(this.tbActualizarAECCom_Click);
            // 
            // btActualizarAS
            // 
            this.btActualizarAS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizarAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualizarAS.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btActualizarAS.Image = ((System.Drawing.Image)(resources.GetObject("btActualizarAS.Image")));
            this.btActualizarAS.Location = new System.Drawing.Point(817, 313);
            this.btActualizarAS.Name = "btActualizarAS";
            this.btActualizarAS.Size = new System.Drawing.Size(53, 52);
            this.btActualizarAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizarAS.TabIndex = 354;
            this.btActualizarAS.Text = "Actualizar";
            this.toolTipActualizar.SetToolTip(this.btActualizarAS, "Actualizar");
            this.btActualizarAS.Click += new System.EventHandler(this.btActualizarAS_Click);
            // 
            // tbEliminarAE
            // 
            this.tbEliminarAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbEliminarAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEliminarAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbEliminarAE.Location = new System.Drawing.Point(909, 234);
            this.tbEliminarAE.Name = "tbEliminarAE";
            this.tbEliminarAE.Size = new System.Drawing.Size(53, 52);
            this.tbEliminarAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbEliminarAE.TabIndex = 218;
            this.tbEliminarAE.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.tbEliminarAE, "Eliminar");
            this.tbEliminarAE.Click += new System.EventHandler(this.tbEliminarAE_Click);
            // 
            // btEliminarSoftAE
            // 
            this.btEliminarSoftAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminarSoftAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarSoftAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEliminarSoftAE.Location = new System.Drawing.Point(906, 233);
            this.btEliminarSoftAE.Name = "btEliminarSoftAE";
            this.btEliminarSoftAE.Size = new System.Drawing.Size(53, 52);
            this.btEliminarSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminarSoftAE.TabIndex = 252;
            this.btEliminarSoftAE.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.btEliminarSoftAE, "Eliminar");
            this.btEliminarSoftAE.Click += new System.EventHandler(this.btEliminarSoftAE_Click);
            // 
            // buttonX18
            // 
            this.buttonX18.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX18.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX18.Location = new System.Drawing.Point(909, 235);
            this.buttonX18.Name = "buttonX18";
            this.buttonX18.Size = new System.Drawing.Size(53, 52);
            this.buttonX18.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX18.TabIndex = 261;
            this.buttonX18.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.buttonX18, "Eliminar");
            // 
            // tbEliminarAECCom
            // 
            this.tbEliminarAECCom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbEliminarAECCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEliminarAECCom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbEliminarAECCom.Location = new System.Drawing.Point(909, 235);
            this.tbEliminarAECCom.Name = "tbEliminarAECCom";
            this.tbEliminarAECCom.Size = new System.Drawing.Size(53, 52);
            this.tbEliminarAECCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbEliminarAECCom.TabIndex = 254;
            this.tbEliminarAECCom.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.tbEliminarAECCom, "Eliminar");
            this.tbEliminarAECCom.Click += new System.EventHandler(this.tbEliminarAECCom_Click);
            // 
            // btEliminarAS
            // 
            this.btEliminarAS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminarAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarAS.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btEliminarAS.Image = ((System.Drawing.Image)(resources.GetObject("btEliminarAS.Image")));
            this.btEliminarAS.Location = new System.Drawing.Point(877, 313);
            this.btEliminarAS.Name = "btEliminarAS";
            this.btEliminarAS.Size = new System.Drawing.Size(53, 52);
            this.btEliminarAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminarAS.TabIndex = 355;
            this.btEliminarAS.Text = "Eliminar";
            this.toolTipEliminar.SetToolTip(this.btEliminarAS, "Eliminar");
            this.btEliminarAS.Click += new System.EventHandler(this.btEliminarAS_Click);
            // 
            // btReportEquipo
            // 
            this.btReportEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btReportEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReportEquipo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btReportEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReportEquipo.Location = new System.Drawing.Point(909, 354);
            this.btReportEquipo.Name = "btReportEquipo";
            this.btReportEquipo.Size = new System.Drawing.Size(53, 52);
            this.btReportEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btReportEquipo.TabIndex = 221;
            this.btReportEquipo.Text = "Reportes";
            this.toolTipReporte.SetToolTip(this.btReportEquipo, "Reportes");
            this.btReportEquipo.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // tbCerrarAE
            // 
            this.tbCerrarAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbCerrarAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCerrarAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbCerrarAE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCerrarAE.Location = new System.Drawing.Point(909, 413);
            this.tbCerrarAE.Name = "tbCerrarAE";
            this.tbCerrarAE.Size = new System.Drawing.Size(53, 52);
            this.tbCerrarAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.tbCerrarAE.TabIndex = 222;
            this.tbCerrarAE.Text = "Cerrar";
            this.toolTipReporte.SetToolTip(this.tbCerrarAE, "Reportes");
            this.tbCerrarAE.Click += new System.EventHandler(this.tbCerrarAE_Click);
            // 
            // btCerrarSoftAE
            // 
            this.btCerrarSoftAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCerrarSoftAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrarSoftAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCerrarSoftAE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrarSoftAE.Location = new System.Drawing.Point(906, 412);
            this.btCerrarSoftAE.Name = "btCerrarSoftAE";
            this.btCerrarSoftAE.Size = new System.Drawing.Size(53, 52);
            this.btCerrarSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btCerrarSoftAE.TabIndex = 256;
            this.btCerrarSoftAE.Text = "Cerrar";
            this.toolTipReporte.SetToolTip(this.btCerrarSoftAE, "Reportes");
            this.btCerrarSoftAE.Click += new System.EventHandler(this.btCerrarSoftAE_Click);
            // 
            // btReporteSoftAE
            // 
            this.btReporteSoftAE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btReporteSoftAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReporteSoftAE.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btReporteSoftAE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReporteSoftAE.Location = new System.Drawing.Point(906, 353);
            this.btReporteSoftAE.Name = "btReporteSoftAE";
            this.btReporteSoftAE.Size = new System.Drawing.Size(53, 52);
            this.btReporteSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btReporteSoftAE.TabIndex = 255;
            this.btReporteSoftAE.Text = "Reportes";
            this.toolTipReporte.SetToolTip(this.btReporteSoftAE, "Reportes");
            this.btReporteSoftAE.Click += new System.EventHandler(this.btReporteSoftAE_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX6.Location = new System.Drawing.Point(909, 414);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(53, 52);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.buttonX6.TabIndex = 266;
            this.buttonX6.Text = "Cerrar";
            this.toolTipReporte.SetToolTip(this.buttonX6, "Reportes");
            // 
            // buttonX14
            // 
            this.buttonX14.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX14.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX14.Location = new System.Drawing.Point(909, 355);
            this.buttonX14.Name = "buttonX14";
            this.buttonX14.Size = new System.Drawing.Size(53, 52);
            this.buttonX14.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.buttonX14.TabIndex = 265;
            this.buttonX14.Text = "Reportes";
            this.toolTipReporte.SetToolTip(this.buttonX14, "Reportes");
            // 
            // tbCerrarAECCom
            // 
            this.tbCerrarAECCom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbCerrarAECCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCerrarAECCom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbCerrarAECCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCerrarAECCom.Location = new System.Drawing.Point(909, 414);
            this.tbCerrarAECCom.Name = "tbCerrarAECCom";
            this.tbCerrarAECCom.Size = new System.Drawing.Size(53, 52);
            this.tbCerrarAECCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.tbCerrarAECCom.TabIndex = 258;
            this.tbCerrarAECCom.Text = "Cerrar";
            this.toolTipReporte.SetToolTip(this.tbCerrarAECCom, "Reportes");
            this.tbCerrarAECCom.Click += new System.EventHandler(this.tbCerrarAECCom_Click);
            // 
            // btReportEquipoCCom
            // 
            this.btReportEquipoCCom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btReportEquipoCCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReportEquipoCCom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btReportEquipoCCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReportEquipoCCom.Location = new System.Drawing.Point(909, 355);
            this.btReportEquipoCCom.Name = "btReportEquipoCCom";
            this.btReportEquipoCCom.Size = new System.Drawing.Size(53, 52);
            this.btReportEquipoCCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btReportEquipoCCom.TabIndex = 257;
            this.btReportEquipoCCom.Text = "Reportes";
            this.toolTipReporte.SetToolTip(this.btReportEquipoCCom, "Reportes");
            this.btReportEquipoCCom.Click += new System.EventHandler(this.btReportEquipoCCom_Click);
            // 
            // btReporteSoft
            // 
            this.btReporteSoft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btReporteSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReporteSoft.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btReporteSoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReporteSoft.Image = ((System.Drawing.Image)(resources.GetObject("btReporteSoft.Image")));
            this.btReporteSoft.Location = new System.Drawing.Point(936, 313);
            this.btReporteSoft.Name = "btReporteSoft";
            this.btReporteSoft.Size = new System.Drawing.Size(53, 52);
            this.btReporteSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btReporteSoft.TabIndex = 356;
            this.btReporteSoft.Text = "Reportes";
            this.toolTipReporte.SetToolTip(this.btReporteSoft, "Reportes");
            this.btReporteSoft.Click += new System.EventHandler(this.btReporteSoft_Click);
            // 
            // dotNetBarManager1
            // 
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManager1.BottomDockSite = this.dockSite4;
            this.dotNetBarManager1.EnableFullSizeDock = false;
            this.dotNetBarManager1.LeftDockSite = this.dockSite1;
            this.dotNetBarManager1.ParentForm = this;
            this.dotNetBarManager1.RightDockSite = this.dockSite2;
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite8;
            this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite5;
            this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite6;
            this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite7;
            this.dotNetBarManager1.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(0, 749);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(1220, 0);
            this.dockSite4.TabIndex = 44;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite1.Location = new System.Drawing.Point(0, 0);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 749);
            this.dockSite1.TabIndex = 41;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(1220, 0);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 749);
            this.dockSite2.TabIndex = 42;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 749);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(1220, 0);
            this.dockSite8.TabIndex = 48;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 0);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 749);
            this.dockSite5.TabIndex = 45;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(1220, 0);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 749);
            this.dockSite6.TabIndex = 46;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(1220, 0);
            this.dockSite7.TabIndex = 47;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 0);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(1220, 0);
            this.dockSite3.TabIndex = 43;
            this.dockSite3.TabStop = false;
            // 
            // sideNav1
            // 
            this.sideNav1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sideNav1.Controls.Add(this.sideNavPanel11);
            this.sideNav1.Controls.Add(this.sideNavPanel3);
            this.sideNav1.Controls.Add(this.sideNavPanel2);
            this.sideNav1.Controls.Add(this.sideNavPanel9);
            this.sideNav1.Controls.Add(this.sideNavPanel13);
            this.sideNav1.Controls.Add(this.sideNavPanel6);
            this.sideNav1.Controls.Add(this.sideNavPanel5);
            this.sideNav1.Controls.Add(this.sideNavPanel1);
            this.sideNav1.Controls.Add(this.sideNavPanel4);
            this.sideNav1.Controls.Add(this.sideNavPanel12);
            this.sideNav1.Controls.Add(this.sideNavPanel10);
            this.sideNav1.Controls.Add(this.sideNavPanel7);
            this.sideNav1.Controls.Add(this.sideNavPanel8);
            this.sideNav1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.separator7,
            this.sideNavItem1,
            this.separator1,
            this.sideNavItem6Inicio,
            this.separator10,
            this.SNIUsers,
            this.sideNavItem6,
            this.separator6,
            this.sideNavItem7,
            this.rbNuevaPerfil,
            this.separator2,
            this.sideNavItem9,
            this.sideNavItem8,
            this.separator3,
            this.sideNavItem2,
            this.sideNavItem5,
            this.separator4,
            this.sideNavItem3,
            this.sideNavItem4,
            this.separator5,
            this.sideNavItem10,
            this.separator8,
            this.sideNavItem11,
            this.separator9});
            this.sideNav1.Location = new System.Drawing.Point(0, 0);
            this.sideNav1.Name = "sideNav1";
            this.sideNav1.Padding = new System.Windows.Forms.Padding(1);
            this.sideNav1.Size = new System.Drawing.Size(1217, 749);
            this.sideNav1.TabIndex = 50;
            this.sideNav1.Text = "sideNav1";
            // 
            // sideNavPanel11
            // 
            this.sideNavPanel11.Controls.Add(this.panelEx10);
            this.sideNavPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel11.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel11.Name = "sideNavPanel11";
            this.sideNavPanel11.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel11.TabIndex = 81;
            // 
            // panelEx10
            // 
            this.panelEx10.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx10.Controls.Add(this.reflectionImage1);
            this.panelEx10.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx10.Location = new System.Drawing.Point(0, 0);
            this.panelEx10.Name = "panelEx10";
            this.panelEx10.Size = new System.Drawing.Size(1003, 711);
            this.panelEx10.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx10.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx10.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx10.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx10.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx10.Style.GradientAngle = 90;
            this.panelEx10.TabIndex = 56;
            this.panelEx10.Click += new System.EventHandler(this.panelEx10_Click);
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::WindowsFormsApplication1.Properties.Resources.logo_pj_removebg_preview;
            this.reflectionImage1.Location = new System.Drawing.Point(21, 199);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(946, 229);
            this.reflectionImage1.TabIndex = 0;
            this.reflectionImage1.Click += new System.EventHandler(this.reflectionImage1_Click);
            // 
            // sideNavPanel3
            // 
            this.sideNavPanel3.Controls.Add(this.panelEx8);
            this.sideNavPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel3.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel3.Name = "sideNavPanel3";
            this.sideNavPanel3.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel3.TabIndex = 14;
            this.sideNavPanel3.Visible = false;
            // 
            // panelEx8
            // 
            this.panelEx8.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx8.Controls.Add(this.btnConstAsg);
            this.panelEx8.Controls.Add(this.superTabControl3);
            this.panelEx8.Controls.Add(this.cbCodEquipoAE);
            this.panelEx8.Controls.Add(this.superTabControl2);
            this.panelEx8.Controls.Add(this.tbPerfilAE);
            this.panelEx8.Controls.Add(this.label90);
            this.panelEx8.Controls.Add(this.line3);
            this.panelEx8.Controls.Add(this.tbNombreAE);
            this.panelEx8.Controls.Add(this.label54);
            this.panelEx8.Controls.Add(this.cbCodPersonalAE);
            this.panelEx8.Controls.Add(this.label67);
            this.panelEx8.Controls.Add(this.tbDniAE);
            this.panelEx8.Controls.Add(this.tbSedeAE);
            this.panelEx8.Controls.Add(this.tbInstancAE);
            this.panelEx8.Controls.Add(this.label14);
            this.panelEx8.Controls.Add(this.dtFechaIngAE);
            this.panelEx8.Controls.Add(this.label74);
            this.panelEx8.Controls.Add(this.label58);
            this.panelEx8.Controls.Add(this.label73);
            this.panelEx8.Controls.Add(this.label66);
            this.panelEx8.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx8.Location = new System.Drawing.Point(0, 0);
            this.panelEx8.Name = "panelEx8";
            this.panelEx8.Size = new System.Drawing.Size(1003, 711);
            this.panelEx8.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx8.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx8.Style.GradientAngle = 90;
            this.panelEx8.TabIndex = 0;
            // 
            // btnConstAsg
            // 
            this.btnConstAsg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConstAsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConstAsg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConstAsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConstAsg.Location = new System.Drawing.Point(924, 77);
            this.btnConstAsg.Name = "btnConstAsg";
            this.btnConstAsg.Size = new System.Drawing.Size(53, 52);
            this.btnConstAsg.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnConstAsg.TabIndex = 361;
            this.btnConstAsg.Text = "Acta de Entrega y Retiro";
            this.btnConstAsg.Click += new System.EventHandler(this.btnConstAsg_Click);
            // 
            // superTabControl3
            // 
            this.superTabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl3.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl3.ControlBox.MenuBox.Name = "";
            this.superTabControl3.ControlBox.Name = "";
            this.superTabControl3.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl3.ControlBox.MenuBox,
            this.superTabControl3.ControlBox.CloseBox});
            this.superTabControl3.Controls.Add(this.superTabControlPanel10);
            this.superTabControl3.Controls.Add(this.superTabControlPanel14);
            this.superTabControl3.Controls.Add(this.superTabControlPanel4);
            this.superTabControl3.Controls.Add(this.superTabControlPanel6);
            this.superTabControl3.Controls.Add(this.superTabControlPanel7);
            this.superTabControl3.Controls.Add(this.superTabControlPanel5);
            this.superTabControl3.Controls.Add(this.superTabControlPanel11);
            this.superTabControl3.Location = new System.Drawing.Point(15, 152);
            this.superTabControl3.Name = "superTabControl3";
            this.superTabControl3.ReorderTabsEnabled = true;
            this.superTabControl3.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl3.SelectedTabIndex = 6;
            this.superTabControl3.Size = new System.Drawing.Size(974, 25);
            this.superTabControl3.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Bottom;
            this.superTabControl3.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl3.TabIndex = 360;
            this.superTabControl3.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stiCPU,
            this.stiSistAudio,
            this.stiLaptop,
            this.stiImpresora,
            this.stiEscaner,
            this.stiOtros,
            this.superTabItem2});
            // 
            // superTabControlPanel10
            // 
            this.superTabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel10.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel10.Name = "superTabControlPanel10";
            this.superTabControlPanel10.Size = new System.Drawing.Size(974, 0);
            this.superTabControlPanel10.TabIndex = 1;
            this.superTabControlPanel10.TabItem = this.stiCPU;
            // 
            // stiCPU
            // 
            this.stiCPU.AttachedControl = this.superTabControlPanel10;
            this.stiCPU.GlobalItem = false;
            this.stiCPU.Name = "stiCPU";
            this.stiCPU.Text = "CPU";
            this.stiCPU.Click += new System.EventHandler(this.stiCPU_Click);
            // 
            // superTabControlPanel14
            // 
            this.superTabControlPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel14.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel14.Name = "superTabControlPanel14";
            this.superTabControlPanel14.Size = new System.Drawing.Size(974, 0);
            this.superTabControlPanel14.TabIndex = 0;
            this.superTabControlPanel14.TabItem = this.stiOtros;
            // 
            // stiOtros
            // 
            this.stiOtros.AttachedControl = this.superTabControlPanel14;
            this.stiOtros.GlobalItem = false;
            this.stiOtros.Name = "stiOtros";
            this.stiOtros.Text = "OTROS";
            this.stiOtros.Click += new System.EventHandler(this.stiOtros_Click);
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(974, 0);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.stiSistAudio;
            // 
            // stiSistAudio
            // 
            this.stiSistAudio.AttachedControl = this.superTabControlPanel4;
            this.stiSistAudio.GlobalItem = false;
            this.stiSistAudio.Name = "stiSistAudio";
            this.stiSistAudio.Text = "SISTEMA DE AUDIO";
            this.stiSistAudio.Click += new System.EventHandler(this.stiSistAudio_Click);
            // 
            // superTabControlPanel6
            // 
            this.superTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel6.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel6.Name = "superTabControlPanel6";
            this.superTabControlPanel6.Size = new System.Drawing.Size(974, 0);
            this.superTabControlPanel6.TabIndex = 0;
            this.superTabControlPanel6.TabItem = this.stiImpresora;
            // 
            // stiImpresora
            // 
            this.stiImpresora.AttachedControl = this.superTabControlPanel6;
            this.stiImpresora.GlobalItem = false;
            this.stiImpresora.Name = "stiImpresora";
            this.stiImpresora.Text = "IMPRESORA";
            this.stiImpresora.Click += new System.EventHandler(this.stiImpresora_Click);
            // 
            // superTabControlPanel7
            // 
            this.superTabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel7.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel7.Name = "superTabControlPanel7";
            this.superTabControlPanel7.Size = new System.Drawing.Size(974, 0);
            this.superTabControlPanel7.TabIndex = 0;
            this.superTabControlPanel7.TabItem = this.stiEscaner;
            // 
            // stiEscaner
            // 
            this.stiEscaner.AttachedControl = this.superTabControlPanel7;
            this.stiEscaner.GlobalItem = false;
            this.stiEscaner.Name = "stiEscaner";
            this.stiEscaner.Text = "SCANEER";
            this.stiEscaner.Click += new System.EventHandler(this.stiEscaner_Click);
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(974, 0);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.stiLaptop;
            // 
            // stiLaptop
            // 
            this.stiLaptop.AttachedControl = this.superTabControlPanel5;
            this.stiLaptop.GlobalItem = false;
            this.stiLaptop.Name = "stiLaptop";
            this.stiLaptop.Text = "LAPTOP";
            this.stiLaptop.Click += new System.EventHandler(this.stiLaptop_Click);
            // 
            // superTabControlPanel11
            // 
            this.superTabControlPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel11.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel11.Name = "superTabControlPanel11";
            this.superTabControlPanel11.Size = new System.Drawing.Size(974, 0);
            this.superTabControlPanel11.TabIndex = 0;
            this.superTabControlPanel11.TabItem = this.superTabItem2;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel11;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Click += new System.EventHandler(this.superTabItem2_Click);
            // 
            // cbCodEquipoAE
            // 
            this.cbCodEquipoAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCodEquipoAE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCodEquipoAE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCodEquipoAE.DisplayMember = "Text";
            this.cbCodEquipoAE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCodEquipoAE.DropDownWidth = 900;
            this.cbCodEquipoAE.FormattingEnabled = true;
            this.cbCodEquipoAE.ItemHeight = 15;
            this.cbCodEquipoAE.Location = new System.Drawing.Point(589, 7);
            this.cbCodEquipoAE.Name = "cbCodEquipoAE";
            this.cbCodEquipoAE.Size = new System.Drawing.Size(293, 21);
            this.cbCodEquipoAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCodEquipoAE.TabIndex = 359;
            this.cbCodEquipoAE.Visible = false;
            // 
            // superTabControl2
            // 
            this.superTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl2.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl2.ControlBox.MenuBox.Name = "";
            this.superTabControl2.ControlBox.Name = "";
            this.superTabControl2.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl2.ControlBox.MenuBox,
            this.superTabControl2.ControlBox.CloseBox});
            this.superTabControl2.Controls.Add(this.superTabControlPanel15);
            this.superTabControl2.Controls.Add(this.superTabControlPanel3);
            this.superTabControl2.Controls.Add(this.superTabControlPanel8);
            this.superTabControl2.Controls.Add(this.superTabControlPanel12);
            this.superTabControl2.Controls.Add(this.superTabControlPanel9);
            this.superTabControl2.Location = new System.Drawing.Point(15, 178);
            this.superTabControl2.Name = "superTabControl2";
            this.superTabControl2.ReorderTabsEnabled = true;
            this.superTabControl2.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl2.SelectedTabIndex = 3;
            this.superTabControl2.Size = new System.Drawing.Size(974, 522);
            this.superTabControl2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl2.TabIndex = 358;
            this.superTabControl2.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stFormEquipo,
            this.stSoftware,
            this.stComponente,
            this.superTabItem3});
            // 
            // superTabControlPanel15
            // 
            this.superTabControlPanel15.Controls.Add(this.dtFechaAsignacionAESCCom);
            this.superTabControlPanel15.Controls.Add(this.label174);
            this.superTabControlPanel15.Controls.Add(this.tbNombreEquipoCCom);
            this.superTabControlPanel15.Controls.Add(this.cbEquipoPadreCodCCom);
            this.superTabControlPanel15.Controls.Add(this.cbEstadoEquipoCCom);
            this.superTabControlPanel15.Controls.Add(this.cbAnioCompraCCom);
            this.superTabControlPanel15.Controls.Add(this.cbCatEqCCom);
            this.superTabControlPanel15.Controls.Add(this.tbCodEqCComInf);
            this.superTabControlPanel15.Controls.Add(this.label144);
            this.superTabControlPanel15.Controls.Add(this.cbAnioCompraCComInf);
            this.superTabControlPanel15.Controls.Add(this.cbCatEqCComInf);
            this.superTabControlPanel15.Controls.Add(this.tbFuncionamientoCComInf);
            this.superTabControlPanel15.Controls.Add(this.label145);
            this.superTabControlPanel15.Controls.Add(this.cbEstadoEquipoCComInf);
            this.superTabControlPanel15.Controls.Add(this.label146);
            this.superTabControlPanel15.Controls.Add(this.label147);
            this.superTabControlPanel15.Controls.Add(this.label148);
            this.superTabControlPanel15.Controls.Add(this.label149);
            this.superTabControlPanel15.Controls.Add(this.label150);
            this.superTabControlPanel15.Controls.Add(this.label151);
            this.superTabControlPanel15.Controls.Add(this.label152);
            this.superTabControlPanel15.Controls.Add(this.label153);
            this.superTabControlPanel15.Controls.Add(this.tbObseracionCComInf);
            this.superTabControlPanel15.Controls.Add(this.label154);
            this.superTabControlPanel15.Controls.Add(this.tbIpCComInf);
            this.superTabControlPanel15.Controls.Add(this.label155);
            this.superTabControlPanel15.Controls.Add(this.tbProcesadorCComInf);
            this.superTabControlPanel15.Controls.Add(this.tbModeloCComInf);
            this.superTabControlPanel15.Controls.Add(this.tbNroOrdenCompraCComInf);
            this.superTabControlPanel15.Controls.Add(this.label156);
            this.superTabControlPanel15.Controls.Add(this.tbMarcaCComInf);
            this.superTabControlPanel15.Controls.Add(this.tbNroSerieCComInf);
            this.superTabControlPanel15.Controls.Add(this.tbNroControlPatrimonialCComInf);
            this.superTabControlPanel15.Controls.Add(this.label143);
            this.superTabControlPanel15.Controls.Add(this.line15);
            this.superTabControlPanel15.Controls.Add(this.label142);
            this.superTabControlPanel15.Controls.Add(this.line14);
            this.superTabControlPanel15.Controls.Add(this.tbCerrarAECCom);
            this.superTabControlPanel15.Controls.Add(this.rbEditarAECCom);
            this.superTabControlPanel15.Controls.Add(this.rbNuevoAECCom);
            this.superTabControlPanel15.Controls.Add(this.tbFuncionamientoCCom);
            this.superTabControlPanel15.Controls.Add(this.label126);
            this.superTabControlPanel15.Controls.Add(this.label127);
            this.superTabControlPanel15.Controls.Add(this.tbServiceTagCCom);
            this.superTabControlPanel15.Controls.Add(this.label128);
            this.superTabControlPanel15.Controls.Add(this.label129);
            this.superTabControlPanel15.Controls.Add(this.label130);
            this.superTabControlPanel15.Controls.Add(this.label131);
            this.superTabControlPanel15.Controls.Add(this.label132);
            this.superTabControlPanel15.Controls.Add(this.cbAsignadoCCom);
            this.superTabControlPanel15.Controls.Add(this.label133);
            this.superTabControlPanel15.Controls.Add(this.label134);
            this.superTabControlPanel15.Controls.Add(this.label135);
            this.superTabControlPanel15.Controls.Add(this.label136);
            this.superTabControlPanel15.Controls.Add(this.label137);
            this.superTabControlPanel15.Controls.Add(this.label138);
            this.superTabControlPanel15.Controls.Add(this.tbObseracionCCom);
            this.superTabControlPanel15.Controls.Add(this.label139);
            this.superTabControlPanel15.Controls.Add(this.tbIpCCom);
            this.superTabControlPanel15.Controls.Add(this.label140);
            this.superTabControlPanel15.Controls.Add(this.tbProcesadorCCom);
            this.superTabControlPanel15.Controls.Add(this.tbModeloCCom);
            this.superTabControlPanel15.Controls.Add(this.tbNroOrdenCompraCCom);
            this.superTabControlPanel15.Controls.Add(this.label141);
            this.superTabControlPanel15.Controls.Add(this.tbMarcaCCom);
            this.superTabControlPanel15.Controls.Add(this.tbNroSerieCCom);
            this.superTabControlPanel15.Controls.Add(this.tbNroControlPatrimonialCCom);
            this.superTabControlPanel15.Controls.Add(this.DGVRegistroCCom);
            this.superTabControlPanel15.Controls.Add(this.btReportEquipoCCom);
            this.superTabControlPanel15.Controls.Add(this.btListaAECCom);
            this.superTabControlPanel15.Controls.Add(this.btRegistrarAECCom);
            this.superTabControlPanel15.Controls.Add(this.tbActualizarAECCom);
            this.superTabControlPanel15.Controls.Add(this.tbEliminarAECCom);
            this.superTabControlPanel15.Controls.Add(this.tbLimpiarAECCom);
            this.superTabControlPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel15.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel15.Name = "superTabControlPanel15";
            this.superTabControlPanel15.Size = new System.Drawing.Size(974, 497);
            this.superTabControlPanel15.TabIndex = 0;
            this.superTabControlPanel15.TabItem = this.stComponente;
            // 
            // dtFechaAsignacionAESCCom
            // 
            this.dtFechaAsignacionAESCCom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaAsignacionAESCCom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaAsignacionAESCCom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionAESCCom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaAsignacionAESCCom.ButtonDropDown.Visible = true;
            this.dtFechaAsignacionAESCCom.Enabled = false;
            this.dtFechaAsignacionAESCCom.IsPopupCalendarOpen = false;
            this.dtFechaAsignacionAESCCom.Location = new System.Drawing.Point(526, 211);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaAsignacionAESCCom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionAESCCom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaAsignacionAESCCom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaAsignacionAESCCom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaAsignacionAESCCom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaAsignacionAESCCom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaAsignacionAESCCom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaAsignacionAESCCom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaAsignacionAESCCom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaAsignacionAESCCom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionAESCCom.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaAsignacionAESCCom.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaAsignacionAESCCom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaAsignacionAESCCom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaAsignacionAESCCom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaAsignacionAESCCom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionAESCCom.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaAsignacionAESCCom.Name = "dtFechaAsignacionAESCCom";
            this.dtFechaAsignacionAESCCom.Size = new System.Drawing.Size(190, 20);
            this.dtFechaAsignacionAESCCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaAsignacionAESCCom.TabIndex = 883;
            // 
            // label174
            // 
            this.label174.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(412, 216);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(111, 13);
            this.label174.TabIndex = 882;
            this.label174.Text = "Fecha de Asignación*";
            // 
            // tbNombreEquipoCCom
            // 
            this.tbNombreEquipoCCom.DisplayMember = "Text";
            this.tbNombreEquipoCCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbNombreEquipoCCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbNombreEquipoCCom.Enabled = false;
            this.tbNombreEquipoCCom.FormattingEnabled = true;
            this.tbNombreEquipoCCom.ItemHeight = 15;
            this.tbNombreEquipoCCom.Items.AddRange(new object[] {
            this.comboItem46,
            this.comboItem47,
            this.comboItem48});
            this.tbNombreEquipoCCom.Location = new System.Drawing.Point(11, 171);
            this.tbNombreEquipoCCom.Name = "tbNombreEquipoCCom";
            this.tbNombreEquipoCCom.Size = new System.Drawing.Size(179, 21);
            this.tbNombreEquipoCCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbNombreEquipoCCom.TabIndex = 239;
            // 
            // comboItem46
            // 
            this.comboItem46.Text = "MOUSE";
            // 
            // comboItem47
            // 
            this.comboItem47.Text = "MONITOR";
            // 
            // comboItem48
            // 
            this.comboItem48.Text = "TECLADO";
            // 
            // cbEquipoPadreCodCCom
            // 
            // 
            // 
            // 
            this.cbEquipoPadreCodCCom.Border.Class = "TextBoxBorder";
            this.cbEquipoPadreCodCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbEquipoPadreCodCCom.Enabled = false;
            this.cbEquipoPadreCodCCom.Location = new System.Drawing.Point(810, 173);
            this.cbEquipoPadreCodCCom.Name = "cbEquipoPadreCodCCom";
            this.cbEquipoPadreCodCCom.PreventEnterBeep = true;
            this.cbEquipoPadreCodCCom.Size = new System.Drawing.Size(93, 20);
            this.cbEquipoPadreCodCCom.TabIndex = 881;
            // 
            // cbEstadoEquipoCCom
            // 
            this.cbEstadoEquipoCCom.DisplayMember = "Text";
            this.cbEstadoEquipoCCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstadoEquipoCCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEquipoCCom.Enabled = false;
            this.cbEstadoEquipoCCom.FormattingEnabled = true;
            this.cbEstadoEquipoCCom.ItemHeight = 15;
            this.cbEstadoEquipoCCom.Items.AddRange(new object[] {
            this.comboItem43,
            this.comboItem44,
            this.comboItem45});
            this.cbEstadoEquipoCCom.Location = new System.Drawing.Point(215, 210);
            this.cbEstadoEquipoCCom.Name = "cbEstadoEquipoCCom";
            this.cbEstadoEquipoCCom.Size = new System.Drawing.Size(123, 21);
            this.cbEstadoEquipoCCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstadoEquipoCCom.TabIndex = 245;
            // 
            // comboItem43
            // 
            this.comboItem43.Text = "BUENO";
            // 
            // comboItem44
            // 
            this.comboItem44.Text = "MALO";
            // 
            // comboItem45
            // 
            this.comboItem45.Text = "REGULAR";
            // 
            // cbAnioCompraCCom
            // 
            this.cbAnioCompraCCom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAnioCompraCCom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnioCompraCCom.DisplayMember = "Text";
            this.cbAnioCompraCCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAnioCompraCCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnioCompraCCom.Enabled = false;
            this.cbAnioCompraCCom.FormattingEnabled = true;
            this.cbAnioCompraCCom.ItemHeight = 15;
            this.cbAnioCompraCCom.Location = new System.Drawing.Point(409, 170);
            this.cbAnioCompraCCom.Name = "cbAnioCompraCCom";
            this.cbAnioCompraCCom.Size = new System.Drawing.Size(108, 21);
            this.cbAnioCompraCCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAnioCompraCCom.TabIndex = 247;
            this.cbAnioCompraCCom.Click += new System.EventHandler(this.cbAnioCompraCCom_Click);
            this.cbAnioCompraCCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAnioCompraCCom_KeyPress);
            // 
            // cbCatEqCCom
            // 
            this.cbCatEqCCom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCatEqCCom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCatEqCCom.DisplayMember = "Text";
            this.cbCatEqCCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCatEqCCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatEqCCom.Enabled = false;
            this.cbCatEqCCom.FormattingEnabled = true;
            this.cbCatEqCCom.ItemHeight = 15;
            this.cbCatEqCCom.Location = new System.Drawing.Point(661, 170);
            this.cbCatEqCCom.Name = "cbCatEqCCom";
            this.cbCatEqCCom.Size = new System.Drawing.Size(100, 21);
            this.cbCatEqCCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCatEqCCom.TabIndex = 878;
            this.cbCatEqCCom.Click += new System.EventHandler(this.cbCatEqCCom_Click);
            // 
            // tbCodEqCComInf
            // 
            // 
            // 
            // 
            this.tbCodEqCComInf.Border.Class = "TextBoxBorder";
            this.tbCodEqCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCodEqCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodEqCComInf.Enabled = false;
            this.tbCodEqCComInf.Location = new System.Drawing.Point(784, 35);
            this.tbCodEqCComInf.Name = "tbCodEqCComInf";
            this.tbCodEqCComInf.PreventEnterBeep = true;
            this.tbCodEqCComInf.Size = new System.Drawing.Size(69, 20);
            this.tbCodEqCComInf.TabIndex = 876;
            this.tbCodEqCComInf.Visible = false;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(784, 21);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(63, 13);
            this.label144.TabIndex = 877;
            this.label144.Text = "cod_equipo";
            this.label144.Visible = false;
            // 
            // cbAnioCompraCComInf
            // 
            // 
            // 
            // 
            this.cbAnioCompraCComInf.Border.Class = "TextBoxBorder";
            this.cbAnioCompraCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbAnioCompraCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbAnioCompraCComInf.Enabled = false;
            this.cbAnioCompraCComInf.Location = new System.Drawing.Point(407, 77);
            this.cbAnioCompraCComInf.Name = "cbAnioCompraCComInf";
            this.cbAnioCompraCComInf.PreventEnterBeep = true;
            this.cbAnioCompraCComInf.Size = new System.Drawing.Size(121, 20);
            this.cbAnioCompraCComInf.TabIndex = 866;
            // 
            // cbCatEqCComInf
            // 
            // 
            // 
            // 
            this.cbCatEqCComInf.Border.Class = "TextBoxBorder";
            this.cbCatEqCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbCatEqCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCatEqCComInf.Enabled = false;
            this.cbCatEqCComInf.Location = new System.Drawing.Point(787, 115);
            this.cbCatEqCComInf.Name = "cbCatEqCComInf";
            this.cbCatEqCComInf.PreventEnterBeep = true;
            this.cbCatEqCComInf.Size = new System.Drawing.Size(100, 20);
            this.cbCatEqCComInf.TabIndex = 860;
            this.cbCatEqCComInf.Visible = false;
            this.cbCatEqCComInf.WordWrap = false;
            // 
            // tbFuncionamientoCComInf
            // 
            // 
            // 
            // 
            this.tbFuncionamientoCComInf.Border.Class = "TextBoxBorder";
            this.tbFuncionamientoCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFuncionamientoCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFuncionamientoCComInf.Enabled = false;
            this.tbFuncionamientoCComInf.Location = new System.Drawing.Point(591, 35);
            this.tbFuncionamientoCComInf.Name = "tbFuncionamientoCComInf";
            this.tbFuncionamientoCComInf.PreventEnterBeep = true;
            this.tbFuncionamientoCComInf.Size = new System.Drawing.Size(151, 20);
            this.tbFuncionamientoCComInf.TabIndex = 868;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(591, 21);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(82, 13);
            this.label145.TabIndex = 874;
            this.label145.Text = "Funcionamiento";
            // 
            // cbEstadoEquipoCComInf
            // 
            this.cbEstadoEquipoCComInf.DisplayMember = "Text";
            this.cbEstadoEquipoCComInf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstadoEquipoCComInf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEquipoCComInf.Enabled = false;
            this.cbEstadoEquipoCComInf.FormattingEnabled = true;
            this.cbEstadoEquipoCComInf.ItemHeight = 15;
            this.cbEstadoEquipoCComInf.Items.AddRange(new object[] {
            this.comboItem38,
            this.comboItem39,
            this.comboItem40});
            this.cbEstadoEquipoCComInf.Location = new System.Drawing.Point(218, 114);
            this.cbEstadoEquipoCComInf.Name = "cbEstadoEquipoCComInf";
            this.cbEstadoEquipoCComInf.Size = new System.Drawing.Size(179, 21);
            this.cbEstadoEquipoCComInf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstadoEquipoCComInf.TabIndex = 865;
            // 
            // comboItem38
            // 
            this.comboItem38.Text = "BUENO";
            // 
            // comboItem39
            // 
            this.comboItem39.Text = "MALO";
            // 
            // comboItem40
            // 
            this.comboItem40.Text = "REGULAR";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(218, 99);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(40, 13);
            this.label146.TabIndex = 873;
            this.label146.Text = "Estado";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(407, 99);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(68, 13);
            this.label147.TabIndex = 852;
            this.label147.Text = "IP de Equipo";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(13, 21);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(37, 13);
            this.label148.TabIndex = 851;
            this.label148.Text = "Marca";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(13, 99);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(42, 13);
            this.label149.TabIndex = 853;
            this.label149.Text = "Modelo";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(13, 61);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(84, 13);
            this.label150.TabIndex = 856;
            this.label150.Text = "Número de serie";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(218, 61);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(79, 13);
            this.label151.TabIndex = 855;
            this.label151.Text = "Cod patrimonial";
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(218, 21);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(61, 13);
            this.label152.TabIndex = 854;
            this.label152.Text = "Procesador";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(407, 61);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(97, 13);
            this.label153.TabIndex = 858;
            this.label153.Text = "Año de adquisición";
            // 
            // tbObseracionCComInf
            // 
            // 
            // 
            // 
            this.tbObseracionCComInf.Border.Class = "TextBoxBorder";
            this.tbObseracionCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObseracionCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObseracionCComInf.Enabled = false;
            this.tbObseracionCComInf.Location = new System.Drawing.Point(591, 77);
            this.tbObseracionCComInf.Name = "tbObseracionCComInf";
            this.tbObseracionCComInf.PreventEnterBeep = true;
            this.tbObseracionCComInf.Size = new System.Drawing.Size(242, 20);
            this.tbObseracionCComInf.TabIndex = 872;
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(407, 21);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(142, 13);
            this.label154.TabIndex = 857;
            this.label154.Text = "Numero de orden de compra";
            // 
            // tbIpCComInf
            // 
            // 
            // 
            // 
            this.tbIpCComInf.Border.Class = "TextBoxBorder";
            this.tbIpCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbIpCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIpCComInf.Enabled = false;
            this.tbIpCComInf.Location = new System.Drawing.Point(407, 114);
            this.tbIpCComInf.Name = "tbIpCComInf";
            this.tbIpCComInf.PreventEnterBeep = true;
            this.tbIpCComInf.Size = new System.Drawing.Size(121, 20);
            this.tbIpCComInf.TabIndex = 867;
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(591, 61);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(67, 13);
            this.label155.TabIndex = 859;
            this.label155.Text = "Observación";
            // 
            // tbProcesadorCComInf
            // 
            // 
            // 
            // 
            this.tbProcesadorCComInf.Border.Class = "TextBoxBorder";
            this.tbProcesadorCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProcesadorCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProcesadorCComInf.Enabled = false;
            this.tbProcesadorCComInf.Location = new System.Drawing.Point(218, 35);
            this.tbProcesadorCComInf.Name = "tbProcesadorCComInf";
            this.tbProcesadorCComInf.PreventEnterBeep = true;
            this.tbProcesadorCComInf.Size = new System.Drawing.Size(175, 20);
            this.tbProcesadorCComInf.TabIndex = 863;
            // 
            // tbModeloCComInf
            // 
            // 
            // 
            // 
            this.tbModeloCComInf.Border.Class = "TextBoxBorder";
            this.tbModeloCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbModeloCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbModeloCComInf.Enabled = false;
            this.tbModeloCComInf.Location = new System.Drawing.Point(13, 114);
            this.tbModeloCComInf.Name = "tbModeloCComInf";
            this.tbModeloCComInf.PreventEnterBeep = true;
            this.tbModeloCComInf.Size = new System.Drawing.Size(184, 20);
            this.tbModeloCComInf.TabIndex = 869;
            // 
            // tbNroOrdenCompraCComInf
            // 
            // 
            // 
            // 
            this.tbNroOrdenCompraCComInf.Border.Class = "TextBoxBorder";
            this.tbNroOrdenCompraCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroOrdenCompraCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroOrdenCompraCComInf.Enabled = false;
            this.tbNroOrdenCompraCComInf.Location = new System.Drawing.Point(407, 35);
            this.tbNroOrdenCompraCComInf.Name = "tbNroOrdenCompraCComInf";
            this.tbNroOrdenCompraCComInf.PreventEnterBeep = true;
            this.tbNroOrdenCompraCComInf.Size = new System.Drawing.Size(162, 20);
            this.tbNroOrdenCompraCComInf.TabIndex = 871;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(787, 99);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(52, 13);
            this.label156.TabIndex = 870;
            this.label156.Text = "Categoria";
            this.label156.Visible = false;
            // 
            // tbMarcaCComInf
            // 
            // 
            // 
            // 
            this.tbMarcaCComInf.Border.Class = "TextBoxBorder";
            this.tbMarcaCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMarcaCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMarcaCComInf.Enabled = false;
            this.tbMarcaCComInf.Location = new System.Drawing.Point(13, 35);
            this.tbMarcaCComInf.Name = "tbMarcaCComInf";
            this.tbMarcaCComInf.PreventEnterBeep = true;
            this.tbMarcaCComInf.Size = new System.Drawing.Size(184, 20);
            this.tbMarcaCComInf.TabIndex = 862;
            // 
            // tbNroSerieCComInf
            // 
            // 
            // 
            // 
            this.tbNroSerieCComInf.Border.Class = "TextBoxBorder";
            this.tbNroSerieCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroSerieCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroSerieCComInf.Enabled = false;
            this.tbNroSerieCComInf.Location = new System.Drawing.Point(13, 77);
            this.tbNroSerieCComInf.Name = "tbNroSerieCComInf";
            this.tbNroSerieCComInf.PreventEnterBeep = true;
            this.tbNroSerieCComInf.Size = new System.Drawing.Size(184, 20);
            this.tbNroSerieCComInf.TabIndex = 861;
            // 
            // tbNroControlPatrimonialCComInf
            // 
            // 
            // 
            // 
            this.tbNroControlPatrimonialCComInf.Border.Class = "TextBoxBorder";
            this.tbNroControlPatrimonialCComInf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroControlPatrimonialCComInf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroControlPatrimonialCComInf.Enabled = false;
            this.tbNroControlPatrimonialCComInf.Location = new System.Drawing.Point(218, 77);
            this.tbNroControlPatrimonialCComInf.Name = "tbNroControlPatrimonialCComInf";
            this.tbNroControlPatrimonialCComInf.PreventEnterBeep = true;
            this.tbNroControlPatrimonialCComInf.Size = new System.Drawing.Size(179, 20);
            this.tbNroControlPatrimonialCComInf.TabIndex = 864;
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(9, 139);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(142, 13);
            this.label143.TabIndex = 850;
            this.label143.Text = "Información del Componente";
            // 
            // line15
            // 
            this.line15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line15.Location = new System.Drawing.Point(3, 134);
            this.line15.Name = "line15";
            this.line15.Size = new System.Drawing.Size(896, 23);
            this.line15.TabIndex = 849;
            this.line15.Text = "line15";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(9, 10);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(115, 13);
            this.label142.TabIndex = 848;
            this.label142.Text = "Información del Equipo";
            // 
            // line14
            // 
            this.line14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line14.Location = new System.Drawing.Point(3, 3);
            this.line14.Name = "line14";
            this.line14.Size = new System.Drawing.Size(896, 23);
            this.line14.TabIndex = 847;
            this.line14.Text = "line14";
            // 
            // rbEditarAECCom
            // 
            this.rbEditarAECCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarAECCom.AutoSize = true;
            this.rbEditarAECCom.Location = new System.Drawing.Point(905, 27);
            this.rbEditarAECCom.Name = "rbEditarAECCom";
            this.rbEditarAECCom.Size = new System.Drawing.Size(52, 17);
            this.rbEditarAECCom.TabIndex = 238;
            this.rbEditarAECCom.TabStop = true;
            this.rbEditarAECCom.Text = "Editar";
            this.rbEditarAECCom.UseVisualStyleBackColor = true;
            this.rbEditarAECCom.Click += new System.EventHandler(this.rbEditarAECCom_Click);
            // 
            // rbNuevoAECCom
            // 
            this.rbNuevoAECCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevoAECCom.AutoSize = true;
            this.rbNuevoAECCom.Location = new System.Drawing.Point(905, 9);
            this.rbNuevoAECCom.Name = "rbNuevoAECCom";
            this.rbNuevoAECCom.Size = new System.Drawing.Size(57, 17);
            this.rbNuevoAECCom.TabIndex = 237;
            this.rbNuevoAECCom.Text = "Nuevo";
            this.rbNuevoAECCom.UseVisualStyleBackColor = true;
            this.rbNuevoAECCom.Click += new System.EventHandler(this.rbNuevoAECCom_Click);
            // 
            // tbFuncionamientoCCom
            // 
            // 
            // 
            // 
            this.tbFuncionamientoCCom.Border.Class = "TextBoxBorder";
            this.tbFuncionamientoCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFuncionamientoCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFuncionamientoCCom.Enabled = false;
            this.tbFuncionamientoCCom.Location = new System.Drawing.Point(215, 251);
            this.tbFuncionamientoCCom.Name = "tbFuncionamientoCCom";
            this.tbFuncionamientoCCom.PreventEnterBeep = true;
            this.tbFuncionamientoCCom.Size = new System.Drawing.Size(175, 20);
            this.tbFuncionamientoCCom.TabIndex = 249;
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(215, 234);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(82, 13);
            this.label126.TabIndex = 262;
            this.label126.Text = "Funcionamiento";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(811, 233);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(65, 13);
            this.label127.TabIndex = 258;
            this.label127.Text = "Service Tag";
            // 
            // tbServiceTagCCom
            // 
            // 
            // 
            // 
            this.tbServiceTagCCom.Border.Class = "TextBoxBorder";
            this.tbServiceTagCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbServiceTagCCom.Enabled = false;
            this.tbServiceTagCCom.Location = new System.Drawing.Point(811, 248);
            this.tbServiceTagCCom.Name = "tbServiceTagCCom";
            this.tbServiceTagCCom.PreventEnterBeep = true;
            this.tbServiceTagCCom.Size = new System.Drawing.Size(93, 20);
            this.tbServiceTagCCom.TabIndex = 256;
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(811, 157);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(93, 13);
            this.label128.TabIndex = 257;
            this.label128.Text = "Cod Padre Equipo";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(215, 193);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(47, 13);
            this.label129.TabIndex = 255;
            this.label129.Text = "Estado *";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(571, 157);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(68, 13);
            this.label130.TabIndex = 228;
            this.label130.Text = "IP de Equipo";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(11, 196);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(44, 13);
            this.label131.TabIndex = 227;
            this.label131.Text = "Marca *";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(11, 155);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(104, 13);
            this.label132.TabIndex = 226;
            this.label132.Text = "Nombre del Equipo *";
            // 
            // cbAsignadoCCom
            // 
            this.cbAsignadoCCom.DisplayMember = "Text";
            this.cbAsignadoCCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAsignadoCCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignadoCCom.Enabled = false;
            this.cbAsignadoCCom.FormattingEnabled = true;
            this.cbAsignadoCCom.ItemHeight = 15;
            this.cbAsignadoCCom.Items.AddRange(new object[] {
            this.comboItem41,
            this.comboItem42});
            this.cbAsignadoCCom.Location = new System.Drawing.Point(811, 209);
            this.cbAsignadoCCom.Name = "cbAsignadoCCom";
            this.cbAsignadoCCom.Size = new System.Drawing.Size(93, 21);
            this.cbAsignadoCCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAsignadoCCom.TabIndex = 253;
            // 
            // comboItem41
            // 
            this.comboItem41.Text = "S";
            // 
            // comboItem42
            // 
            this.comboItem42.Text = "N";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(811, 195);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(51, 13);
            this.label133.TabIndex = 230;
            this.label133.Text = "Asignado";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(11, 278);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(49, 13);
            this.label134.TabIndex = 229;
            this.label134.Text = "Modelo *";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(11, 234);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(91, 13);
            this.label135.TabIndex = 233;
            this.label135.Text = "Número de serie *";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(213, 155);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(79, 13);
            this.label136.TabIndex = 232;
            this.label136.Text = "Cod patrimonial";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(658, 234);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(64, 13);
            this.label137.TabIndex = 231;
            this.label137.Text = "Procesador ";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(410, 156);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(104, 13);
            this.label138.TabIndex = 235;
            this.label138.Text = "Año de adquisición *";
            // 
            // tbObseracionCCom
            // 
            // 
            // 
            // 
            this.tbObseracionCCom.Border.Class = "TextBoxBorder";
            this.tbObseracionCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObseracionCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObseracionCCom.Enabled = false;
            this.tbObseracionCCom.Location = new System.Drawing.Point(215, 292);
            this.tbObseracionCCom.Name = "tbObseracionCCom";
            this.tbObseracionCCom.PreventEnterBeep = true;
            this.tbObseracionCCom.Size = new System.Drawing.Size(303, 20);
            this.tbObseracionCCom.TabIndex = 250;
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(637, 271);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(142, 13);
            this.label139.TabIndex = 234;
            this.label139.Text = "Numero de orden de compra";
            // 
            // tbIpCCom
            // 
            // 
            // 
            // 
            this.tbIpCCom.Border.Class = "TextBoxBorder";
            this.tbIpCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbIpCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIpCCom.Enabled = false;
            this.tbIpCCom.Location = new System.Drawing.Point(561, 173);
            this.tbIpCCom.Name = "tbIpCCom";
            this.tbIpCCom.PreventEnterBeep = true;
            this.tbIpCCom.Size = new System.Drawing.Size(86, 20);
            this.tbIpCCom.TabIndex = 248;
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(215, 278);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(67, 13);
            this.label140.TabIndex = 236;
            this.label140.Text = "Observación";
            // 
            // tbProcesadorCCom
            // 
            // 
            // 
            // 
            this.tbProcesadorCCom.Border.Class = "TextBoxBorder";
            this.tbProcesadorCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProcesadorCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProcesadorCCom.Enabled = false;
            this.tbProcesadorCCom.Location = new System.Drawing.Point(661, 250);
            this.tbProcesadorCCom.Name = "tbProcesadorCCom";
            this.tbProcesadorCCom.PreventEnterBeep = true;
            this.tbProcesadorCCom.Size = new System.Drawing.Size(100, 20);
            this.tbProcesadorCCom.TabIndex = 243;
            // 
            // tbModeloCCom
            // 
            // 
            // 
            // 
            this.tbModeloCCom.Border.Class = "TextBoxBorder";
            this.tbModeloCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbModeloCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbModeloCCom.Enabled = false;
            this.tbModeloCCom.Location = new System.Drawing.Point(11, 292);
            this.tbModeloCCom.Name = "tbModeloCCom";
            this.tbModeloCCom.PreventEnterBeep = true;
            this.tbModeloCCom.Size = new System.Drawing.Size(184, 20);
            this.tbModeloCCom.TabIndex = 242;
            // 
            // tbNroOrdenCompraCCom
            // 
            // 
            // 
            // 
            this.tbNroOrdenCompraCCom.Border.Class = "TextBoxBorder";
            this.tbNroOrdenCompraCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroOrdenCompraCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroOrdenCompraCCom.Enabled = false;
            this.tbNroOrdenCompraCCom.Location = new System.Drawing.Point(661, 287);
            this.tbNroOrdenCompraCCom.Name = "tbNroOrdenCompraCCom";
            this.tbNroOrdenCompraCCom.PreventEnterBeep = true;
            this.tbNroOrdenCompraCCom.Size = new System.Drawing.Size(103, 20);
            this.tbNroOrdenCompraCCom.TabIndex = 246;
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(658, 156);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(52, 13);
            this.label141.TabIndex = 252;
            this.label141.Text = "Categoria";
            // 
            // tbMarcaCCom
            // 
            // 
            // 
            // 
            this.tbMarcaCCom.Border.Class = "TextBoxBorder";
            this.tbMarcaCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMarcaCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMarcaCCom.Enabled = false;
            this.tbMarcaCCom.Location = new System.Drawing.Point(11, 211);
            this.tbMarcaCCom.Name = "tbMarcaCCom";
            this.tbMarcaCCom.PreventEnterBeep = true;
            this.tbMarcaCCom.Size = new System.Drawing.Size(184, 20);
            this.tbMarcaCCom.TabIndex = 240;
            // 
            // tbNroSerieCCom
            // 
            // 
            // 
            // 
            this.tbNroSerieCCom.Border.Class = "TextBoxBorder";
            this.tbNroSerieCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroSerieCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroSerieCCom.Enabled = false;
            this.tbNroSerieCCom.Location = new System.Drawing.Point(11, 250);
            this.tbNroSerieCCom.Name = "tbNroSerieCCom";
            this.tbNroSerieCCom.PreventEnterBeep = true;
            this.tbNroSerieCCom.Size = new System.Drawing.Size(184, 20);
            this.tbNroSerieCCom.TabIndex = 241;
            this.tbNroSerieCCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroSerieCCom_KeyPress);
            this.tbNroSerieCCom.Leave += new System.EventHandler(this.tbNroSerieCCom_Leave);
            // 
            // tbNroControlPatrimonialCCom
            // 
            // 
            // 
            // 
            this.tbNroControlPatrimonialCCom.Border.Class = "TextBoxBorder";
            this.tbNroControlPatrimonialCCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroControlPatrimonialCCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroControlPatrimonialCCom.Enabled = false;
            this.tbNroControlPatrimonialCCom.Location = new System.Drawing.Point(216, 169);
            this.tbNroControlPatrimonialCCom.Name = "tbNroControlPatrimonialCCom";
            this.tbNroControlPatrimonialCCom.PreventEnterBeep = true;
            this.tbNroControlPatrimonialCCom.Size = new System.Drawing.Size(174, 20);
            this.tbNroControlPatrimonialCCom.TabIndex = 244;
            // 
            // DGVRegistroCCom
            // 
            this.DGVRegistroCCom.AllowUserToAddRows = false;
            this.DGVRegistroCCom.AllowUserToDeleteRows = false;
            this.DGVRegistroCCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVRegistroCCom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRegistroCCom.BackgroundColor = System.Drawing.Color.White;
            this.DGVRegistroCCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRegistroCCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68});
            this.DGVRegistroCCom.Location = new System.Drawing.Point(12, 331);
            this.DGVRegistroCCom.Name = "DGVRegistroCCom";
            this.DGVRegistroCCom.ReadOnly = true;
            this.DGVRegistroCCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRegistroCCom.Size = new System.Drawing.Size(887, 159);
            this.DGVRegistroCCom.TabIndex = 223;
            this.DGVRegistroCCom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRegistroCCom_CellClick);
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn47.HeaderText = "CodRegistro";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "cod_personal";
            this.dataGridViewTextBoxColumn48.HeaderText = "cod_personal";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Visible = false;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "cod_equipo";
            this.dataGridViewTextBoxColumn49.HeaderText = "cod_equipo";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Visible = false;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn50.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            this.dataGridViewTextBoxColumn50.Visible = false;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "nombre_per";
            this.dataGridViewTextBoxColumn51.HeaderText = "Usuario / Apellidos y nombres";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Visible = false;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "cod_sede";
            this.dataGridViewTextBoxColumn52.HeaderText = "cod_sede";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            this.dataGridViewTextBoxColumn52.Visible = false;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "nombre_sede";
            this.dataGridViewTextBoxColumn53.HeaderText = "Sede";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            this.dataGridViewTextBoxColumn53.Visible = false;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "cod_instancia";
            this.dataGridViewTextBoxColumn54.HeaderText = "cod_instancia";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Visible = false;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "nombre_instancia";
            this.dataGridViewTextBoxColumn55.HeaderText = "nombre_instancia";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Visible = false;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "nro_serie";
            this.dataGridViewTextBoxColumn56.HeaderText = "SerieEquipo";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            this.dataGridViewTextBoxColumn56.Visible = false;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "nro_control_patrimonial";
            this.dataGridViewTextBoxColumn57.HeaderText = "CodPatrimonial";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            this.dataGridViewTextBoxColumn57.Visible = false;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "nombre_equipo";
            this.dataGridViewTextBoxColumn58.HeaderText = "Equipo";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "fecha_registro";
            this.dataGridViewTextBoxColumn59.HeaderText = "FechaRegistro";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            this.dataGridViewTextBoxColumn59.Visible = false;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "fecha_sistema";
            this.dataGridViewTextBoxColumn60.HeaderText = "FechaSistema";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.Visible = false;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "observacion";
            this.dataGridViewTextBoxColumn61.HeaderText = "Observacion";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Visible = false;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn62.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "serie";
            this.dataGridViewTextBoxColumn63.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "procesador";
            this.dataGridViewTextBoxColumn64.HeaderText = "Procesador";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "cod_patrimonial";
            this.dataGridViewTextBoxColumn65.HeaderText = "Cod patrimonial";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn66.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "aniocompra";
            this.dataGridViewTextBoxColumn67.HeaderText = "Año compra";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "ip";
            this.dataGridViewTextBoxColumn68.HeaderText = "IP";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            this.dataGridViewTextBoxColumn68.Visible = false;
            // 
            // stComponente
            // 
            this.stComponente.AttachedControl = this.superTabControlPanel15;
            this.stComponente.GlobalItem = false;
            this.stComponente.Name = "stComponente";
            this.stComponente.Text = "Componente";
            this.stComponente.Visible = false;
            this.stComponente.Click += new System.EventHandler(this.stComponente_Click);
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.dtFechaAsignacionAES);
            this.superTabControlPanel3.Controls.Add(this.label173);
            this.superTabControlPanel3.Controls.Add(this.tbCerrarAE);
            this.superTabControlPanel3.Controls.Add(this.rbEditarAE);
            this.superTabControlPanel3.Controls.Add(this.rbNuevoAE);
            this.superTabControlPanel3.Controls.Add(this.tbFuncionamiento);
            this.superTabControlPanel3.Controls.Add(this.label29);
            this.superTabControlPanel3.Controls.Add(this.label87);
            this.superTabControlPanel3.Controls.Add(this.tbServiceTag);
            this.superTabControlPanel3.Controls.Add(this.label86);
            this.superTabControlPanel3.Controls.Add(this.cbEstadoEquipo);
            this.superTabControlPanel3.Controls.Add(this.label49);
            this.superTabControlPanel3.Controls.Add(this.cbAnioCompra);
            this.superTabControlPanel3.Controls.Add(this.cbEquipoPadreCod);
            this.superTabControlPanel3.Controls.Add(this.label3);
            this.superTabControlPanel3.Controls.Add(this.label2);
            this.superTabControlPanel3.Controls.Add(this.label4);
            this.superTabControlPanel3.Controls.Add(this.cbAsignado);
            this.superTabControlPanel3.Controls.Add(this.label7);
            this.superTabControlPanel3.Controls.Add(this.cbCatEq);
            this.superTabControlPanel3.Controls.Add(this.label6);
            this.superTabControlPanel3.Controls.Add(this.label10);
            this.superTabControlPanel3.Controls.Add(this.label9);
            this.superTabControlPanel3.Controls.Add(this.label8);
            this.superTabControlPanel3.Controls.Add(this.label12);
            this.superTabControlPanel3.Controls.Add(this.tbObseracion);
            this.superTabControlPanel3.Controls.Add(this.label11);
            this.superTabControlPanel3.Controls.Add(this.tbIp);
            this.superTabControlPanel3.Controls.Add(this.label13);
            this.superTabControlPanel3.Controls.Add(this.tbProcesador);
            this.superTabControlPanel3.Controls.Add(this.tbModelo);
            this.superTabControlPanel3.Controls.Add(this.tbNroOrdenCompra);
            this.superTabControlPanel3.Controls.Add(this.tbNombreEquipo);
            this.superTabControlPanel3.Controls.Add(this.label17);
            this.superTabControlPanel3.Controls.Add(this.tbMarca);
            this.superTabControlPanel3.Controls.Add(this.tbNroSerie);
            this.superTabControlPanel3.Controls.Add(this.tbNroControlPatrimonial);
            this.superTabControlPanel3.Controls.Add(this.labelX10);
            this.superTabControlPanel3.Controls.Add(this.tbAsignacionEq);
            this.superTabControlPanel3.Controls.Add(this.DGVRegistro);
            this.superTabControlPanel3.Controls.Add(this.btReportEquipo);
            this.superTabControlPanel3.Controls.Add(this.btListaAE);
            this.superTabControlPanel3.Controls.Add(this.btRegistrarAE);
            this.superTabControlPanel3.Controls.Add(this.tbActualizarAE);
            this.superTabControlPanel3.Controls.Add(this.tbEliminarAE);
            this.superTabControlPanel3.Controls.Add(this.tbLimpiarAE);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(974, 497);
            this.superTabControlPanel3.TabIndex = 1;
            this.superTabControlPanel3.TabItem = this.stFormEquipo;
            // 
            // dtFechaAsignacionAES
            // 
            this.dtFechaAsignacionAES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaAsignacionAES.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaAsignacionAES.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionAES.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaAsignacionAES.ButtonDropDown.Visible = true;
            this.dtFechaAsignacionAES.Enabled = false;
            this.dtFechaAsignacionAES.IsPopupCalendarOpen = false;
            this.dtFechaAsignacionAES.Location = new System.Drawing.Point(552, 171);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaAsignacionAES.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionAES.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaAsignacionAES.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaAsignacionAES.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaAsignacionAES.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaAsignacionAES.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaAsignacionAES.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaAsignacionAES.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaAsignacionAES.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaAsignacionAES.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionAES.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaAsignacionAES.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaAsignacionAES.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaAsignacionAES.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaAsignacionAES.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaAsignacionAES.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaAsignacionAES.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaAsignacionAES.Name = "dtFechaAsignacionAES";
            this.dtFechaAsignacionAES.Size = new System.Drawing.Size(190, 20);
            this.dtFechaAsignacionAES.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaAsignacionAES.TabIndex = 224;
            // 
            // label173
            // 
            this.label173.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(438, 176);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(111, 13);
            this.label173.TabIndex = 223;
            this.label173.Text = "Fecha de Asignación*";
            // 
            // rbEditarAE
            // 
            this.rbEditarAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarAE.AutoSize = true;
            this.rbEditarAE.Location = new System.Drawing.Point(905, 26);
            this.rbEditarAE.Name = "rbEditarAE";
            this.rbEditarAE.Size = new System.Drawing.Size(52, 17);
            this.rbEditarAE.TabIndex = 200;
            this.rbEditarAE.TabStop = true;
            this.rbEditarAE.Text = "Editar";
            this.rbEditarAE.UseVisualStyleBackColor = true;
            this.rbEditarAE.Click += new System.EventHandler(this.rbEditarAE_Click);
            // 
            // rbNuevoAE
            // 
            this.rbNuevoAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevoAE.AutoSize = true;
            this.rbNuevoAE.Location = new System.Drawing.Point(905, 8);
            this.rbNuevoAE.Name = "rbNuevoAE";
            this.rbNuevoAE.Size = new System.Drawing.Size(57, 17);
            this.rbNuevoAE.TabIndex = 199;
            this.rbNuevoAE.Text = "Nuevo";
            this.rbNuevoAE.UseVisualStyleBackColor = true;
            this.rbNuevoAE.Click += new System.EventHandler(this.rbNuevoAE_Click);
            // 
            // tbFuncionamiento
            // 
            // 
            // 
            // 
            this.tbFuncionamiento.Border.Class = "TextBoxBorder";
            this.tbFuncionamiento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFuncionamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFuncionamiento.Enabled = false;
            this.tbFuncionamiento.Location = new System.Drawing.Point(437, 101);
            this.tbFuncionamiento.Name = "tbFuncionamiento";
            this.tbFuncionamiento.PreventEnterBeep = true;
            this.tbFuncionamiento.Size = new System.Drawing.Size(303, 20);
            this.tbFuncionamiento.TabIndex = 210;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(437, 85);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 13);
            this.label29.TabIndex = 218;
            this.label29.Text = "Funcionamiento";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(759, 125);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(65, 13);
            this.label87.TabIndex = 216;
            this.label87.Text = "Service Tag";
            this.label87.Visible = false;
            // 
            // tbServiceTag
            // 
            // 
            // 
            // 
            this.tbServiceTag.Border.Class = "TextBoxBorder";
            this.tbServiceTag.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbServiceTag.Enabled = false;
            this.tbServiceTag.Location = new System.Drawing.Point(759, 141);
            this.tbServiceTag.Name = "tbServiceTag";
            this.tbServiceTag.PreventEnterBeep = true;
            this.tbServiceTag.Size = new System.Drawing.Size(132, 20);
            this.tbServiceTag.TabIndex = 215;
            this.tbServiceTag.Visible = false;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(759, 10);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(93, 13);
            this.label86.TabIndex = 215;
            this.label86.Text = "Cod Padre Equipo";
            this.label86.Visible = false;
            // 
            // cbEstadoEquipo
            // 
            this.cbEstadoEquipo.DisplayMember = "Text";
            this.cbEstadoEquipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstadoEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEquipo.Enabled = false;
            this.cbEstadoEquipo.FormattingEnabled = true;
            this.cbEstadoEquipo.ItemHeight = 15;
            this.cbEstadoEquipo.Items.AddRange(new object[] {
            this.comboItem18,
            this.comboItem23,
            this.comboItem24});
            this.cbEstadoEquipo.Location = new System.Drawing.Point(222, 99);
            this.cbEstadoEquipo.Name = "cbEstadoEquipo";
            this.cbEstadoEquipo.Size = new System.Drawing.Size(179, 21);
            this.cbEstadoEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstadoEquipo.TabIndex = 206;
            // 
            // comboItem18
            // 
            this.comboItem18.Text = "BUENO";
            // 
            // comboItem23
            // 
            this.comboItem23.Text = "MALO";
            // 
            // comboItem24
            // 
            this.comboItem24.Text = "REGULAR";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(222, 85);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(47, 13);
            this.label49.TabIndex = 214;
            this.label49.Text = "Estado *";
            // 
            // cbAnioCompra
            // 
            this.cbAnioCompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAnioCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnioCompra.DisplayMember = "Text";
            this.cbAnioCompra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAnioCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnioCompra.Enabled = false;
            this.cbAnioCompra.FormattingEnabled = true;
            this.cbAnioCompra.ItemHeight = 15;
            this.cbAnioCompra.Location = new System.Drawing.Point(437, 25);
            this.cbAnioCompra.Name = "cbAnioCompra";
            this.cbAnioCompra.Size = new System.Drawing.Size(129, 21);
            this.cbAnioCompra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAnioCompra.TabIndex = 208;
            this.cbAnioCompra.Click += new System.EventHandler(this.cbAnioCompra_Click_1);
            this.cbAnioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAnioCompra_KeyPress_1);
            // 
            // cbEquipoPadreCod
            // 
            this.cbEquipoPadreCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEquipoPadreCod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEquipoPadreCod.DisplayMember = "Text";
            this.cbEquipoPadreCod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEquipoPadreCod.Enabled = false;
            this.cbEquipoPadreCod.FormattingEnabled = true;
            this.cbEquipoPadreCod.ItemHeight = 15;
            this.cbEquipoPadreCod.Location = new System.Drawing.Point(759, 23);
            this.cbEquipoPadreCod.Name = "cbEquipoPadreCod";
            this.cbEquipoPadreCod.Size = new System.Drawing.Size(125, 21);
            this.cbEquipoPadreCod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEquipoPadreCod.TabIndex = 212;
            this.cbEquipoPadreCod.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 190;
            this.label3.Text = "IP de Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 189;
            this.label2.Text = "Marca *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 188;
            this.label4.Text = "Nombre del Equipo*";
            // 
            // cbAsignado
            // 
            this.cbAsignado.DisplayMember = "Text";
            this.cbAsignado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignado.Enabled = false;
            this.cbAsignado.FormattingEnabled = true;
            this.cbAsignado.ItemHeight = 15;
            this.cbAsignado.Items.AddRange(new object[] {
            this.comboItem27,
            this.comboItem28});
            this.cbAsignado.Location = new System.Drawing.Point(759, 62);
            this.cbAsignado.Name = "cbAsignado";
            this.cbAsignado.Size = new System.Drawing.Size(131, 21);
            this.cbAsignado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAsignado.TabIndex = 213;
            this.cbAsignado.Visible = false;
            // 
            // comboItem27
            // 
            this.comboItem27.Text = "S";
            // 
            // comboItem28
            // 
            this.comboItem28.Text = "N";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(759, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 192;
            this.label7.Text = "Asignado";
            this.label7.Visible = false;
            // 
            // cbCatEq
            // 
            this.cbCatEq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCatEq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCatEq.DisplayMember = "Text";
            this.cbCatEq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCatEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatEq.Enabled = false;
            this.cbCatEq.FormattingEnabled = true;
            this.cbCatEq.ItemHeight = 15;
            this.cbCatEq.Location = new System.Drawing.Point(579, 25);
            this.cbCatEq.Name = "cbCatEq";
            this.cbCatEq.Size = new System.Drawing.Size(132, 21);
            this.cbCatEq.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCatEq.TabIndex = 200;
            this.cbCatEq.Click += new System.EventHandler(this.cbCatEq_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 191;
            this.label6.Text = "Modelo *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 195;
            this.label10.Text = "Número de serie *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 194;
            this.label9.Text = "Cod patrimonial *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 193;
            this.label8.Text = "Procesador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 197;
            this.label12.Text = "Año de adquisición *";
            // 
            // tbObseracion
            // 
            // 
            // 
            // 
            this.tbObseracion.Border.Class = "TextBoxBorder";
            this.tbObseracion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObseracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObseracion.Enabled = false;
            this.tbObseracion.Location = new System.Drawing.Point(437, 140);
            this.tbObseracion.Name = "tbObseracion";
            this.tbObseracion.PreventEnterBeep = true;
            this.tbObseracion.Size = new System.Drawing.Size(303, 20);
            this.tbObseracion.TabIndex = 211;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 196;
            this.label11.Text = "Numero de orden de compra";
            // 
            // tbIp
            // 
            // 
            // 
            // 
            this.tbIp.Border.Class = "TextBoxBorder";
            this.tbIp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIp.Enabled = false;
            this.tbIp.Location = new System.Drawing.Point(437, 64);
            this.tbIp.Name = "tbIp";
            this.tbIp.PreventEnterBeep = true;
            this.tbIp.Size = new System.Drawing.Size(121, 20);
            this.tbIp.TabIndex = 209;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 198;
            this.label13.Text = "Observación";
            // 
            // tbProcesador
            // 
            // 
            // 
            // 
            this.tbProcesador.Border.Class = "TextBoxBorder";
            this.tbProcesador.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProcesador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProcesador.Enabled = false;
            this.tbProcesador.Location = new System.Drawing.Point(222, 25);
            this.tbProcesador.Name = "tbProcesador";
            this.tbProcesador.PreventEnterBeep = true;
            this.tbProcesador.Size = new System.Drawing.Size(175, 20);
            this.tbProcesador.TabIndex = 204;
            // 
            // tbModelo
            // 
            // 
            // 
            // 
            this.tbModelo.Border.Class = "TextBoxBorder";
            this.tbModelo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbModelo.Enabled = false;
            this.tbModelo.Location = new System.Drawing.Point(9, 141);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.PreventEnterBeep = true;
            this.tbModelo.Size = new System.Drawing.Size(184, 20);
            this.tbModelo.TabIndex = 203;
            // 
            // tbNroOrdenCompra
            // 
            // 
            // 
            // 
            this.tbNroOrdenCompra.Border.Class = "TextBoxBorder";
            this.tbNroOrdenCompra.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroOrdenCompra.Enabled = false;
            this.tbNroOrdenCompra.Location = new System.Drawing.Point(222, 141);
            this.tbNroOrdenCompra.Name = "tbNroOrdenCompra";
            this.tbNroOrdenCompra.PreventEnterBeep = true;
            this.tbNroOrdenCompra.Size = new System.Drawing.Size(179, 20);
            this.tbNroOrdenCompra.TabIndex = 207;
            // 
            // tbNombreEquipo
            // 
            // 
            // 
            // 
            this.tbNombreEquipo.Border.Class = "TextBoxBorder";
            this.tbNombreEquipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNombreEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreEquipo.Enabled = false;
            this.tbNombreEquipo.Location = new System.Drawing.Point(9, 25);
            this.tbNombreEquipo.Name = "tbNombreEquipo";
            this.tbNombreEquipo.PreventEnterBeep = true;
            this.tbNombreEquipo.Size = new System.Drawing.Size(184, 20);
            this.tbNombreEquipo.TabIndex = 200;
            this.tbNombreEquipo.TextChanged += new System.EventHandler(this.tbNombreEquipo_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(579, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 213;
            this.label17.Text = "Categoria *";
            // 
            // tbMarca
            // 
            // 
            // 
            // 
            this.tbMarca.Border.Class = "TextBoxBorder";
            this.tbMarca.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMarca.Enabled = false;
            this.tbMarca.Location = new System.Drawing.Point(9, 63);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.PreventEnterBeep = true;
            this.tbMarca.Size = new System.Drawing.Size(184, 20);
            this.tbMarca.TabIndex = 201;
            // 
            // tbNroSerie
            // 
            // 
            // 
            // 
            this.tbNroSerie.Border.Class = "TextBoxBorder";
            this.tbNroSerie.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroSerie.Enabled = false;
            this.tbNroSerie.Location = new System.Drawing.Point(9, 102);
            this.tbNroSerie.Name = "tbNroSerie";
            this.tbNroSerie.PreventEnterBeep = true;
            this.tbNroSerie.Size = new System.Drawing.Size(184, 20);
            this.tbNroSerie.TabIndex = 202;
            this.tbNroSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroSerie_KeyPress);
            this.tbNroSerie.Leave += new System.EventHandler(this.tbNroSerie_Leave);
            // 
            // tbNroControlPatrimonial
            // 
            // 
            // 
            // 
            this.tbNroControlPatrimonial.Border.Class = "TextBoxBorder";
            this.tbNroControlPatrimonial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroControlPatrimonial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroControlPatrimonial.Enabled = false;
            this.tbNroControlPatrimonial.Location = new System.Drawing.Point(222, 61);
            this.tbNroControlPatrimonial.Name = "tbNroControlPatrimonial";
            this.tbNroControlPatrimonial.PreventEnterBeep = true;
            this.tbNroControlPatrimonial.Size = new System.Drawing.Size(179, 20);
            this.tbNroControlPatrimonial.TabIndex = 205;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(19, 197);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(53, 23);
            this.labelX10.TabIndex = 15;
            this.labelX10.Text = "Buscar";
            // 
            // tbAsignacionEq
            // 
            // 
            // 
            // 
            this.tbAsignacionEq.Border.Class = "TextBoxBorder";
            this.tbAsignacionEq.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAsignacionEq.Location = new System.Drawing.Point(78, 198);
            this.tbAsignacionEq.Name = "tbAsignacionEq";
            this.tbAsignacionEq.PreventEnterBeep = true;
            this.tbAsignacionEq.Size = new System.Drawing.Size(302, 20);
            this.tbAsignacionEq.TabIndex = 168;
            this.tbAsignacionEq.TextChanged += new System.EventHandler(this.tbAsignacionEq_TextChanged);
            // 
            // DGVRegistro
            // 
            this.DGVRegistro.AllowUserToAddRows = false;
            this.DGVRegistro.AllowUserToDeleteRows = false;
            this.DGVRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRegistro.BackgroundColor = System.Drawing.Color.White;
            this.DGVRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column27,
            this.Column28,
            this.Column31,
            this.dni,
            this.Column19,
            this.Column29,
            this.Column20,
            this.Column21,
            this.Column30,
            this.Column22,
            this.Column55,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.DGVRegistro.Location = new System.Drawing.Point(12, 234);
            this.DGVRegistro.Name = "DGVRegistro";
            this.DGVRegistro.ReadOnly = true;
            this.DGVRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRegistro.Size = new System.Drawing.Size(887, 252);
            this.DGVRegistro.TabIndex = 14;
            this.DGVRegistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRegistro_CellClick);
            this.DGVRegistro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRegistro_CellDoubleClick);
            // 
            // Column27
            // 
            this.Column27.DataPropertyName = "id";
            this.Column27.HeaderText = "CodRegistro";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            this.Column27.Visible = false;
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "cod_personal";
            this.Column28.HeaderText = "cod_personal";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            this.Column28.Visible = false;
            // 
            // Column31
            // 
            this.Column31.DataPropertyName = "cod_equipo";
            this.Column31.HeaderText = "cod_equipo";
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            this.Column31.Visible = false;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Visible = false;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "nombre_per";
            this.Column19.HeaderText = "Usuario / Apellidos y nombres";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            // 
            // Column29
            // 
            this.Column29.DataPropertyName = "cod_sede";
            this.Column29.HeaderText = "cod_sede";
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            this.Column29.Visible = false;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "nombre_sede";
            this.Column20.HeaderText = "Sede";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "cod_instancia";
            this.Column21.HeaderText = "cod_instancia";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Visible = false;
            // 
            // Column30
            // 
            this.Column30.DataPropertyName = "nombre_instancia";
            this.Column30.HeaderText = "nombre_instancia";
            this.Column30.Name = "Column30";
            this.Column30.ReadOnly = true;
            this.Column30.Visible = false;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "nro_serie";
            this.Column22.HeaderText = "SerieEquipo";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Visible = false;
            // 
            // Column55
            // 
            this.Column55.DataPropertyName = "nro_control_patrimonial";
            this.Column55.HeaderText = "CodPatrimonial";
            this.Column55.Name = "Column55";
            this.Column55.ReadOnly = true;
            this.Column55.Visible = false;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "nombre_equipo";
            this.Column23.HeaderText = "Equipo";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column24
            // 
            this.Column24.DataPropertyName = "fecha_registro";
            this.Column24.HeaderText = "FechaRegistro";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Visible = false;
            // 
            // Column25
            // 
            this.Column25.DataPropertyName = "fecha_sistema";
            this.Column25.HeaderText = "FechaSistema";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Visible = false;
            // 
            // Column26
            // 
            this.Column26.DataPropertyName = "observacion";
            this.Column26.HeaderText = "Observacion";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "marca";
            this.Column8.HeaderText = "Marca";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "serie";
            this.Column9.HeaderText = "Serie";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "procesador";
            this.Column10.HeaderText = "Procesador";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "cod_patrimonial";
            this.Column11.HeaderText = "Cod patrimonial";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "estado";
            this.Column12.HeaderText = "Estado";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "aniocompra";
            this.Column13.HeaderText = "Año compra";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "ip";
            this.Column14.HeaderText = "IP";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // stFormEquipo
            // 
            this.stFormEquipo.AttachedControl = this.superTabControlPanel3;
            this.stFormEquipo.GlobalItem = false;
            this.stFormEquipo.Name = "stFormEquipo";
            this.stFormEquipo.Click += new System.EventHandler(this.stCPU_Click);
            // 
            // superTabControlPanel8
            // 
            this.superTabControlPanel8.Controls.Add(this.cbSoftware_SoftAE);
            this.superTabControlPanel8.Controls.Add(this.label109);
            this.superTabControlPanel8.Controls.Add(this.label102);
            this.superTabControlPanel8.Controls.Add(this.line13);
            this.superTabControlPanel8.Controls.Add(this.label108);
            this.superTabControlPanel8.Controls.Add(this.tbCodEquipoSofAE);
            this.superTabControlPanel8.Controls.Add(this.label107);
            this.superTabControlPanel8.Controls.Add(this.label105);
            this.superTabControlPanel8.Controls.Add(this.dtFechaInstalacionSoftAE);
            this.superTabControlPanel8.Controls.Add(this.dtFechaCaducidadSoftAE);
            this.superTabControlPanel8.Controls.Add(this.label106);
            this.superTabControlPanel8.Controls.Add(this.btCerrarSoftAE);
            this.superTabControlPanel8.Controls.Add(this.rbEditarSofAE);
            this.superTabControlPanel8.Controls.Add(this.rbNuevoSofAE);
            this.superTabControlPanel8.Controls.Add(this.btListaSoftAE);
            this.superTabControlPanel8.Controls.Add(this.btGrabarSoftAE);
            this.superTabControlPanel8.Controls.Add(this.btLimpiarSoftAE);
            this.superTabControlPanel8.Controls.Add(this.btActualizarSoftAE);
            this.superTabControlPanel8.Controls.Add(this.btEliminarSoftAE);
            this.superTabControlPanel8.Controls.Add(this.btReporteSoftAE);
            this.superTabControlPanel8.Controls.Add(this.tbAnioCompraSoft);
            this.superTabControlPanel8.Controls.Add(this.tbCatEqSoft);
            this.superTabControlPanel8.Controls.Add(this.DGVSoftware_SodtAE);
            this.superTabControlPanel8.Controls.Add(this.cbAnioCompraSoftAE);
            this.superTabControlPanel8.Controls.Add(this.line12);
            this.superTabControlPanel8.Controls.Add(this.tbObsvSoftAE);
            this.superTabControlPanel8.Controls.Add(this.label97);
            this.superTabControlPanel8.Controls.Add(this.label98);
            this.superTabControlPanel8.Controls.Add(this.label99);
            this.superTabControlPanel8.Controls.Add(this.label100);
            this.superTabControlPanel8.Controls.Add(this.label101);
            this.superTabControlPanel8.Controls.Add(this.tbOCSoftAE);
            this.superTabControlPanel8.Controls.Add(this.tbCantidadUsSoftAE);
            this.superTabControlPanel8.Controls.Add(this.tbnombreSoftAE);
            this.superTabControlPanel8.Controls.Add(this.label103);
            this.superTabControlPanel8.Controls.Add(this.tbVersionSoftAE);
            this.superTabControlPanel8.Controls.Add(this.label104);
            this.superTabControlPanel8.Controls.Add(this.cbActivoSoftAE);
            this.superTabControlPanel8.Controls.Add(this.tbFuncionamientoSoft);
            this.superTabControlPanel8.Controls.Add(this.label61);
            this.superTabControlPanel8.Controls.Add(this.cbEstadoEquipoSoft);
            this.superTabControlPanel8.Controls.Add(this.label64);
            this.superTabControlPanel8.Controls.Add(this.label70);
            this.superTabControlPanel8.Controls.Add(this.label72);
            this.superTabControlPanel8.Controls.Add(this.label75);
            this.superTabControlPanel8.Controls.Add(this.label76);
            this.superTabControlPanel8.Controls.Add(this.label77);
            this.superTabControlPanel8.Controls.Add(this.label78);
            this.superTabControlPanel8.Controls.Add(this.label79);
            this.superTabControlPanel8.Controls.Add(this.tbObseracionSoft);
            this.superTabControlPanel8.Controls.Add(this.label94);
            this.superTabControlPanel8.Controls.Add(this.tbIpSoft);
            this.superTabControlPanel8.Controls.Add(this.label95);
            this.superTabControlPanel8.Controls.Add(this.tbProcesadorSoft);
            this.superTabControlPanel8.Controls.Add(this.tbModeloSoft);
            this.superTabControlPanel8.Controls.Add(this.tbNroOrdenCompraSoft);
            this.superTabControlPanel8.Controls.Add(this.label96);
            this.superTabControlPanel8.Controls.Add(this.tbMarcaSoft);
            this.superTabControlPanel8.Controls.Add(this.tbNroSerieSoft);
            this.superTabControlPanel8.Controls.Add(this.tbNroControlPatrimonialSoft);
            this.superTabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel8.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel8.Name = "superTabControlPanel8";
            this.superTabControlPanel8.Size = new System.Drawing.Size(974, 497);
            this.superTabControlPanel8.TabIndex = 0;
            this.superTabControlPanel8.TabItem = this.stSoftware;
            // 
            // cbSoftware_SoftAE
            // 
            this.cbSoftware_SoftAE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSoftware_SoftAE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSoftware_SoftAE.DisplayMember = "Text";
            this.cbSoftware_SoftAE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoftware_SoftAE.DropDownWidth = 500;
            this.cbSoftware_SoftAE.Enabled = false;
            this.cbSoftware_SoftAE.FormattingEnabled = true;
            this.cbSoftware_SoftAE.ItemHeight = 15;
            this.cbSoftware_SoftAE.Location = new System.Drawing.Point(13, 185);
            this.cbSoftware_SoftAE.Name = "cbSoftware_SoftAE";
            this.cbSoftware_SoftAE.Size = new System.Drawing.Size(172, 21);
            this.cbSoftware_SoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSoftware_SoftAE.TabIndex = 241;
            this.cbSoftware_SoftAE.Click += new System.EventHandler(this.cbSoftware_SoftAE_Click_1);
            this.cbSoftware_SoftAE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSoftware_SoftAE_KeyPress);
            this.cbSoftware_SoftAE.Leave += new System.EventHandler(this.cbSoftware_SoftAE_Leave);
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(12, 170);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(113, 13);
            this.label109.TabIndex = 848;
            this.label109.Text = "Nombre del Software *";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(7, 8);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(115, 13);
            this.label102.TabIndex = 846;
            this.label102.Text = "Información del Equipo";
            // 
            // line13
            // 
            this.line13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line13.Location = new System.Drawing.Point(1, 1);
            this.line13.Name = "line13";
            this.line13.Size = new System.Drawing.Size(856, 23);
            this.line13.TabIndex = 845;
            this.line13.Text = "line13";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(5, 150);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(124, 13);
            this.label108.TabIndex = 844;
            this.label108.Text = "Información del Software";
            // 
            // tbCodEquipoSofAE
            // 
            // 
            // 
            // 
            this.tbCodEquipoSofAE.Border.Class = "TextBoxBorder";
            this.tbCodEquipoSofAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCodEquipoSofAE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodEquipoSofAE.Enabled = false;
            this.tbCodEquipoSofAE.Location = new System.Drawing.Point(781, 42);
            this.tbCodEquipoSofAE.Name = "tbCodEquipoSofAE";
            this.tbCodEquipoSofAE.PreventEnterBeep = true;
            this.tbCodEquipoSofAE.Size = new System.Drawing.Size(69, 20);
            this.tbCodEquipoSofAE.TabIndex = 842;
            this.tbCodEquipoSofAE.Visible = false;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(781, 28);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(63, 13);
            this.label107.TabIndex = 843;
            this.label107.Text = "cod_equipo";
            this.label107.Visible = false;
            // 
            // label105
            // 
            this.label105.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(428, 209);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(151, 13);
            this.label105.TabIndex = 840;
            this.label105.Text = "Fecha Instalación del software";
            this.label105.Visible = false;
            // 
            // dtFechaInstalacionSoftAE
            // 
            this.dtFechaInstalacionSoftAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaInstalacionSoftAE.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInstalacionSoftAE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInstalacionSoftAE.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInstalacionSoftAE.ButtonDropDown.Visible = true;
            this.dtFechaInstalacionSoftAE.Enabled = false;
            this.dtFechaInstalacionSoftAE.IsPopupCalendarOpen = false;
            this.dtFechaInstalacionSoftAE.Location = new System.Drawing.Point(428, 225);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaInstalacionSoftAE.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInstalacionSoftAE.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaInstalacionSoftAE.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaInstalacionSoftAE.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaInstalacionSoftAE.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInstalacionSoftAE.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaInstalacionSoftAE.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaInstalacionSoftAE.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaInstalacionSoftAE.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaInstalacionSoftAE.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInstalacionSoftAE.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaInstalacionSoftAE.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaInstalacionSoftAE.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaInstalacionSoftAE.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInstalacionSoftAE.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaInstalacionSoftAE.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInstalacionSoftAE.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaInstalacionSoftAE.Name = "dtFechaInstalacionSoftAE";
            this.dtFechaInstalacionSoftAE.Size = new System.Drawing.Size(148, 20);
            this.dtFechaInstalacionSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInstalacionSoftAE.TabIndex = 247;
            this.dtFechaInstalacionSoftAE.Visible = false;
            // 
            // dtFechaCaducidadSoftAE
            // 
            this.dtFechaCaducidadSoftAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaCaducidadSoftAE.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaCaducidadSoftAE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCaducidadSoftAE.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaCaducidadSoftAE.ButtonDropDown.Visible = true;
            this.dtFechaCaducidadSoftAE.Enabled = false;
            this.dtFechaCaducidadSoftAE.IsPopupCalendarOpen = false;
            this.dtFechaCaducidadSoftAE.Location = new System.Drawing.Point(609, 225);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaCaducidadSoftAE.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCaducidadSoftAE.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaCaducidadSoftAE.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaCaducidadSoftAE.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaCaducidadSoftAE.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaCaducidadSoftAE.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaCaducidadSoftAE.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaCaducidadSoftAE.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaCaducidadSoftAE.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaCaducidadSoftAE.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCaducidadSoftAE.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaCaducidadSoftAE.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaCaducidadSoftAE.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaCaducidadSoftAE.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaCaducidadSoftAE.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaCaducidadSoftAE.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCaducidadSoftAE.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaCaducidadSoftAE.Name = "dtFechaCaducidadSoftAE";
            this.dtFechaCaducidadSoftAE.Size = new System.Drawing.Size(137, 20);
            this.dtFechaCaducidadSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaCaducidadSoftAE.TabIndex = 248;
            this.dtFechaCaducidadSoftAE.Visible = false;
            // 
            // label106
            // 
            this.label106.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(606, 209);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(91, 13);
            this.label106.TabIndex = 841;
            this.label106.Text = "Fecha Caducidad";
            this.label106.Visible = false;
            // 
            // rbEditarSofAE
            // 
            this.rbEditarSofAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarSofAE.AutoSize = true;
            this.rbEditarSofAE.Location = new System.Drawing.Point(905, 25);
            this.rbEditarSofAE.Name = "rbEditarSofAE";
            this.rbEditarSofAE.Size = new System.Drawing.Size(52, 17);
            this.rbEditarSofAE.TabIndex = 832;
            this.rbEditarSofAE.TabStop = true;
            this.rbEditarSofAE.Text = "Editar";
            this.rbEditarSofAE.UseVisualStyleBackColor = true;
            this.rbEditarSofAE.Click += new System.EventHandler(this.rbEditarSofAE_Click);
            // 
            // rbNuevoSofAE
            // 
            this.rbNuevoSofAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevoSofAE.AutoSize = true;
            this.rbNuevoSofAE.Location = new System.Drawing.Point(905, 7);
            this.rbNuevoSofAE.Name = "rbNuevoSofAE";
            this.rbNuevoSofAE.Size = new System.Drawing.Size(57, 17);
            this.rbNuevoSofAE.TabIndex = 831;
            this.rbNuevoSofAE.Text = "Nuevo";
            this.rbNuevoSofAE.UseVisualStyleBackColor = true;
            this.rbNuevoSofAE.Click += new System.EventHandler(this.rbNuevoSofAE_Click);
            // 
            // tbAnioCompraSoft
            // 
            // 
            // 
            // 
            this.tbAnioCompraSoft.Border.Class = "TextBoxBorder";
            this.tbAnioCompraSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAnioCompraSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAnioCompraSoft.Enabled = false;
            this.tbAnioCompraSoft.Location = new System.Drawing.Point(411, 84);
            this.tbAnioCompraSoft.Name = "tbAnioCompraSoft";
            this.tbAnioCompraSoft.PreventEnterBeep = true;
            this.tbAnioCompraSoft.Size = new System.Drawing.Size(121, 20);
            this.tbAnioCompraSoft.TabIndex = 235;
            // 
            // tbCatEqSoft
            // 
            // 
            // 
            // 
            this.tbCatEqSoft.Border.Class = "TextBoxBorder";
            this.tbCatEqSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCatEqSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCatEqSoft.Enabled = false;
            this.tbCatEqSoft.Location = new System.Drawing.Point(784, 122);
            this.tbCatEqSoft.Name = "tbCatEqSoft";
            this.tbCatEqSoft.PreventEnterBeep = true;
            this.tbCatEqSoft.Size = new System.Drawing.Size(100, 20);
            this.tbCatEqSoft.TabIndex = 229;
            this.tbCatEqSoft.Visible = false;
            // 
            // DGVSoftware_SodtAE
            // 
            this.DGVSoftware_SodtAE.AllowUserToAddRows = false;
            this.DGVSoftware_SodtAE.AllowUserToDeleteRows = false;
            this.DGVSoftware_SodtAE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVSoftware_SodtAE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSoftware_SodtAE.BackgroundColor = System.Drawing.Color.White;
            this.DGVSoftware_SodtAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSoftware_SodtAE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DGVSoftware_SodtAE.Location = new System.Drawing.Point(11, 262);
            this.DGVSoftware_SodtAE.Name = "DGVSoftware_SodtAE";
            this.DGVSoftware_SodtAE.ReadOnly = true;
            this.DGVSoftware_SodtAE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSoftware_SodtAE.Size = new System.Drawing.Size(846, 225);
            this.DGVSoftware_SodtAE.TabIndex = 373;
            this.DGVSoftware_SodtAE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSoftwareAE_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_equipo_software";
            this.dataGridViewTextBoxColumn1.HeaderText = "codEqSoft";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cod_software";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodSoftware";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "cod_equipo";
            this.Column7.HeaderText = "CodEquipo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "software";
            this.dataGridViewTextBoxColumn4.HeaderText = "software";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha_instalacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha instalación";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_caducidad";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha Caducidad";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "observacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observación";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // cbAnioCompraSoftAE
            // 
            this.cbAnioCompraSoftAE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAnioCompraSoftAE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnioCompraSoftAE.DisplayMember = "Text";
            this.cbAnioCompraSoftAE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAnioCompraSoftAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnioCompraSoftAE.Enabled = false;
            this.cbAnioCompraSoftAE.FormattingEnabled = true;
            this.cbAnioCompraSoftAE.ItemHeight = 15;
            this.cbAnioCompraSoftAE.Location = new System.Drawing.Point(12, 224);
            this.cbAnioCompraSoftAE.Name = "cbAnioCompraSoftAE";
            this.cbAnioCompraSoftAE.Size = new System.Drawing.Size(107, 21);
            this.cbAnioCompraSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAnioCompraSoftAE.TabIndex = 245;
            this.cbAnioCompraSoftAE.Click += new System.EventHandler(this.tbAnioCompraSoftAE_Click);
            this.cbAnioCompraSoftAE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnioCompraSoftAE_KeyPress);
            // 
            // line12
            // 
            this.line12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line12.Location = new System.Drawing.Point(1, 143);
            this.line12.Name = "line12";
            this.line12.Size = new System.Drawing.Size(856, 23);
            this.line12.TabIndex = 372;
            this.line12.Text = "line12";
            // 
            // tbObsvSoftAE
            // 
            // 
            // 
            // 
            this.tbObsvSoftAE.Border.Class = "TextBoxBorder";
            this.tbObsvSoftAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObsvSoftAE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObsvSoftAE.Enabled = false;
            this.tbObsvSoftAE.Location = new System.Drawing.Point(135, 225);
            this.tbObsvSoftAE.Name = "tbObsvSoftAE";
            this.tbObsvSoftAE.PreventEnterBeep = true;
            this.tbObsvSoftAE.Size = new System.Drawing.Size(273, 20);
            this.tbObsvSoftAE.TabIndex = 246;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(738, 167);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(106, 13);
            this.label97.TabIndex = 357;
            this.label97.Text = "Nombre del Software";
            this.label97.Visible = false;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(12, 209);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(99, 13);
            this.label98.TabIndex = 369;
            this.label98.Text = "Año de Aquisición *";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(213, 170);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(42, 13);
            this.label99.TabIndex = 358;
            this.label99.Text = "Versión";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(133, 209);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(67, 13);
            this.label100.TabIndex = 368;
            this.label100.Text = "Observación";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(771, 208);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(37, 13);
            this.label101.TabIndex = 359;
            this.label101.Text = "Activo";
            this.label101.Visible = false;
            // 
            // tbOCSoftAE
            // 
            // 
            // 
            // 
            this.tbOCSoftAE.Border.Class = "TextBoxBorder";
            this.tbOCSoftAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbOCSoftAE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOCSoftAE.Enabled = false;
            this.tbOCSoftAE.Location = new System.Drawing.Point(541, 187);
            this.tbOCSoftAE.Name = "tbOCSoftAE";
            this.tbOCSoftAE.PreventEnterBeep = true;
            this.tbOCSoftAE.Size = new System.Drawing.Size(180, 20);
            this.tbOCSoftAE.TabIndex = 244;
            // 
            // tbCantidadUsSoftAE
            // 
            // 
            // 
            // 
            this.tbCantidadUsSoftAE.Border.Class = "TextBoxBorder";
            this.tbCantidadUsSoftAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCantidadUsSoftAE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCantidadUsSoftAE.Enabled = false;
            this.tbCantidadUsSoftAE.Location = new System.Drawing.Point(424, 187);
            this.tbCantidadUsSoftAE.Name = "tbCantidadUsSoftAE";
            this.tbCantidadUsSoftAE.PreventEnterBeep = true;
            this.tbCantidadUsSoftAE.Size = new System.Drawing.Size(109, 20);
            this.tbCantidadUsSoftAE.TabIndex = 243;
            this.tbCantidadUsSoftAE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidadUsSoftAE_KeyPress);
            // 
            // tbnombreSoftAE
            // 
            // 
            // 
            // 
            this.tbnombreSoftAE.Border.Class = "TextBoxBorder";
            this.tbnombreSoftAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbnombreSoftAE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbnombreSoftAE.Enabled = false;
            this.tbnombreSoftAE.Location = new System.Drawing.Point(738, 187);
            this.tbnombreSoftAE.Name = "tbnombreSoftAE";
            this.tbnombreSoftAE.PreventEnterBeep = true;
            this.tbnombreSoftAE.Size = new System.Drawing.Size(129, 20);
            this.tbnombreSoftAE.TabIndex = 849;
            this.tbnombreSoftAE.Visible = false;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(424, 170);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(108, 13);
            this.label103.TabIndex = 370;
            this.label103.Text = "Cantidad de Usuarios";
            // 
            // tbVersionSoftAE
            // 
            // 
            // 
            // 
            this.tbVersionSoftAE.Border.Class = "TextBoxBorder";
            this.tbVersionSoftAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbVersionSoftAE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbVersionSoftAE.Enabled = false;
            this.tbVersionSoftAE.Location = new System.Drawing.Point(208, 187);
            this.tbVersionSoftAE.Name = "tbVersionSoftAE";
            this.tbVersionSoftAE.PreventEnterBeep = true;
            this.tbVersionSoftAE.Size = new System.Drawing.Size(200, 20);
            this.tbVersionSoftAE.TabIndex = 242;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(541, 170);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(142, 13);
            this.label104.TabIndex = 371;
            this.label104.Text = "Número de orden de compra";
            // 
            // cbActivoSoftAE
            // 
            this.cbActivoSoftAE.DisplayMember = "Text";
            this.cbActivoSoftAE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActivoSoftAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivoSoftAE.Enabled = false;
            this.cbActivoSoftAE.FormattingEnabled = true;
            this.cbActivoSoftAE.ItemHeight = 15;
            this.cbActivoSoftAE.Items.AddRange(new object[] {
            this.comboItem32,
            this.comboItem33});
            this.cbActivoSoftAE.Location = new System.Drawing.Point(773, 223);
            this.cbActivoSoftAE.Name = "cbActivoSoftAE";
            this.cbActivoSoftAE.Size = new System.Drawing.Size(105, 21);
            this.cbActivoSoftAE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbActivoSoftAE.TabIndex = 249;
            this.cbActivoSoftAE.Visible = false;
            // 
            // comboItem32
            // 
            this.comboItem32.Text = "S";
            // 
            // comboItem33
            // 
            this.comboItem33.Text = "N";
            // 
            // tbFuncionamientoSoft
            // 
            // 
            // 
            // 
            this.tbFuncionamientoSoft.Border.Class = "TextBoxBorder";
            this.tbFuncionamientoSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFuncionamientoSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFuncionamientoSoft.Enabled = false;
            this.tbFuncionamientoSoft.Location = new System.Drawing.Point(588, 42);
            this.tbFuncionamientoSoft.Name = "tbFuncionamientoSoft";
            this.tbFuncionamientoSoft.PreventEnterBeep = true;
            this.tbFuncionamientoSoft.Size = new System.Drawing.Size(151, 20);
            this.tbFuncionamientoSoft.TabIndex = 237;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(588, 28);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(82, 13);
            this.label61.TabIndex = 242;
            this.label61.Text = "Funcionamiento";
            // 
            // cbEstadoEquipoSoft
            // 
            this.cbEstadoEquipoSoft.DisplayMember = "Text";
            this.cbEstadoEquipoSoft.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstadoEquipoSoft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEquipoSoft.Enabled = false;
            this.cbEstadoEquipoSoft.FormattingEnabled = true;
            this.cbEstadoEquipoSoft.ItemHeight = 15;
            this.cbEstadoEquipoSoft.Items.AddRange(new object[] {
            this.comboItem29,
            this.comboItem30,
            this.comboItem31});
            this.cbEstadoEquipoSoft.Location = new System.Drawing.Point(212, 121);
            this.cbEstadoEquipoSoft.Name = "cbEstadoEquipoSoft";
            this.cbEstadoEquipoSoft.Size = new System.Drawing.Size(179, 21);
            this.cbEstadoEquipoSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstadoEquipoSoft.TabIndex = 234;
            // 
            // comboItem29
            // 
            this.comboItem29.Text = "BUENO";
            // 
            // comboItem30
            // 
            this.comboItem30.Text = "MALO";
            // 
            // comboItem31
            // 
            this.comboItem31.Text = "REGULAR";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(212, 106);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(40, 13);
            this.label64.TabIndex = 240;
            this.label64.Text = "Estado";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(411, 106);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(68, 13);
            this.label70.TabIndex = 220;
            this.label70.Text = "IP de Equipo";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(10, 28);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(37, 13);
            this.label72.TabIndex = 219;
            this.label72.Text = "Marca";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(8, 106);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(42, 13);
            this.label75.TabIndex = 221;
            this.label75.Text = "Modelo";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(11, 68);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(84, 13);
            this.label76.TabIndex = 224;
            this.label76.Text = "Número de serie";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(212, 68);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(79, 13);
            this.label77.TabIndex = 223;
            this.label77.Text = "Cod patrimonial";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(215, 28);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(61, 13);
            this.label78.TabIndex = 222;
            this.label78.Text = "Procesador";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(411, 68);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(97, 13);
            this.label79.TabIndex = 226;
            this.label79.Text = "Año de adquisición";
            // 
            // tbObseracionSoft
            // 
            // 
            // 
            // 
            this.tbObseracionSoft.Border.Class = "TextBoxBorder";
            this.tbObseracionSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObseracionSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObseracionSoft.Enabled = false;
            this.tbObseracionSoft.Location = new System.Drawing.Point(588, 84);
            this.tbObseracionSoft.Name = "tbObseracionSoft";
            this.tbObseracionSoft.PreventEnterBeep = true;
            this.tbObseracionSoft.Size = new System.Drawing.Size(242, 20);
            this.tbObseracionSoft.TabIndex = 240;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(404, 28);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(142, 13);
            this.label94.TabIndex = 225;
            this.label94.Text = "Numero de orden de compra";
            // 
            // tbIpSoft
            // 
            // 
            // 
            // 
            this.tbIpSoft.Border.Class = "TextBoxBorder";
            this.tbIpSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbIpSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIpSoft.Enabled = false;
            this.tbIpSoft.Location = new System.Drawing.Point(411, 121);
            this.tbIpSoft.Name = "tbIpSoft";
            this.tbIpSoft.PreventEnterBeep = true;
            this.tbIpSoft.Size = new System.Drawing.Size(121, 20);
            this.tbIpSoft.TabIndex = 236;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(588, 68);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(67, 13);
            this.label95.TabIndex = 227;
            this.label95.Text = "Observación";
            // 
            // tbProcesadorSoft
            // 
            // 
            // 
            // 
            this.tbProcesadorSoft.Border.Class = "TextBoxBorder";
            this.tbProcesadorSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProcesadorSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProcesadorSoft.Enabled = false;
            this.tbProcesadorSoft.Location = new System.Drawing.Point(215, 42);
            this.tbProcesadorSoft.Name = "tbProcesadorSoft";
            this.tbProcesadorSoft.PreventEnterBeep = true;
            this.tbProcesadorSoft.Size = new System.Drawing.Size(175, 20);
            this.tbProcesadorSoft.TabIndex = 232;
            // 
            // tbModeloSoft
            // 
            // 
            // 
            // 
            this.tbModeloSoft.Border.Class = "TextBoxBorder";
            this.tbModeloSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbModeloSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbModeloSoft.Enabled = false;
            this.tbModeloSoft.Location = new System.Drawing.Point(8, 121);
            this.tbModeloSoft.Name = "tbModeloSoft";
            this.tbModeloSoft.PreventEnterBeep = true;
            this.tbModeloSoft.Size = new System.Drawing.Size(184, 20);
            this.tbModeloSoft.TabIndex = 238;
            this.tbModeloSoft.TextChanged += new System.EventHandler(this.tbModeloSoft_TextChanged);
            // 
            // tbNroOrdenCompraSoft
            // 
            // 
            // 
            // 
            this.tbNroOrdenCompraSoft.Border.Class = "TextBoxBorder";
            this.tbNroOrdenCompraSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroOrdenCompraSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroOrdenCompraSoft.Enabled = false;
            this.tbNroOrdenCompraSoft.Location = new System.Drawing.Point(404, 42);
            this.tbNroOrdenCompraSoft.Name = "tbNroOrdenCompraSoft";
            this.tbNroOrdenCompraSoft.PreventEnterBeep = true;
            this.tbNroOrdenCompraSoft.Size = new System.Drawing.Size(162, 20);
            this.tbNroOrdenCompraSoft.TabIndex = 239;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(784, 106);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(52, 13);
            this.label96.TabIndex = 238;
            this.label96.Text = "Categoria";
            this.label96.Visible = false;
            // 
            // tbMarcaSoft
            // 
            // 
            // 
            // 
            this.tbMarcaSoft.Border.Class = "TextBoxBorder";
            this.tbMarcaSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMarcaSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMarcaSoft.Enabled = false;
            this.tbMarcaSoft.Location = new System.Drawing.Point(10, 42);
            this.tbMarcaSoft.Name = "tbMarcaSoft";
            this.tbMarcaSoft.PreventEnterBeep = true;
            this.tbMarcaSoft.Size = new System.Drawing.Size(184, 20);
            this.tbMarcaSoft.TabIndex = 231;
            // 
            // tbNroSerieSoft
            // 
            // 
            // 
            // 
            this.tbNroSerieSoft.Border.Class = "TextBoxBorder";
            this.tbNroSerieSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroSerieSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroSerieSoft.Enabled = false;
            this.tbNroSerieSoft.Location = new System.Drawing.Point(11, 84);
            this.tbNroSerieSoft.Name = "tbNroSerieSoft";
            this.tbNroSerieSoft.PreventEnterBeep = true;
            this.tbNroSerieSoft.Size = new System.Drawing.Size(184, 20);
            this.tbNroSerieSoft.TabIndex = 230;
            // 
            // tbNroControlPatrimonialSoft
            // 
            // 
            // 
            // 
            this.tbNroControlPatrimonialSoft.Border.Class = "TextBoxBorder";
            this.tbNroControlPatrimonialSoft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroControlPatrimonialSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroControlPatrimonialSoft.Enabled = false;
            this.tbNroControlPatrimonialSoft.Location = new System.Drawing.Point(212, 84);
            this.tbNroControlPatrimonialSoft.Name = "tbNroControlPatrimonialSoft";
            this.tbNroControlPatrimonialSoft.PreventEnterBeep = true;
            this.tbNroControlPatrimonialSoft.Size = new System.Drawing.Size(179, 20);
            this.tbNroControlPatrimonialSoft.TabIndex = 233;
            // 
            // stSoftware
            // 
            this.stSoftware.AttachedControl = this.superTabControlPanel8;
            this.stSoftware.GlobalItem = false;
            this.stSoftware.Name = "stSoftware";
            this.stSoftware.Text = "Software";
            this.stSoftware.Visible = false;
            this.stSoftware.Click += new System.EventHandler(this.stSoftware_Click);
            // 
            // superTabControlPanel12
            // 
            this.superTabControlPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel12.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel12.Name = "superTabControlPanel12";
            this.superTabControlPanel12.Size = new System.Drawing.Size(974, 497);
            this.superTabControlPanel12.TabIndex = 0;
            this.superTabControlPanel12.TabItem = this.superTabItem3;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel12;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            // 
            // superTabControlPanel9
            // 
            this.superTabControlPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel9.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel9.Name = "superTabControlPanel9";
            this.superTabControlPanel9.Size = new System.Drawing.Size(974, 522);
            this.superTabControlPanel9.TabIndex = 0;
            // 
            // tbPerfilAE
            // 
            this.tbPerfilAE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbPerfilAE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPerfilAE.Enabled = false;
            this.tbPerfilAE.Location = new System.Drawing.Point(570, 59);
            this.tbPerfilAE.Name = "tbPerfilAE";
            this.tbPerfilAE.PreventEnterBeep = true;
            this.tbPerfilAE.Size = new System.Drawing.Size(323, 14);
            this.tbPerfilAE.TabIndex = 356;
            // 
            // label90
            // 
            this.label90.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(531, 61);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(30, 13);
            this.label90.TabIndex = 357;
            this.label90.Text = "Perfil";
            // 
            // line3
            // 
            this.line3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line3.Location = new System.Drawing.Point(3, 131);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1000, 23);
            this.line3.TabIndex = 355;
            this.line3.Text = "line3";
            // 
            // sideNavPanel2
            // 
            this.sideNavPanel2.Controls.Add(this.superTabControl1);
            this.sideNavPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel2.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel2.Name = "sideNavPanel2";
            this.sideNavPanel2.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel2.TabIndex = 6;
            this.sideNavPanel2.Visible = false;
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Location = new System.Drawing.Point(3, 3);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 1;
            this.superTabControl1.Size = new System.Drawing.Size(991, 697);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.Categorias});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.panelEx2);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(991, 672);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // panelEx2
            // 
            this.panelEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.rbEditarEq);
            this.panelEx2.Controls.Add(this.rbNuevoEq);
            this.panelEx2.Controls.Add(this.tbFuncionamientoNA);
            this.panelEx2.Controls.Add(this.label157);
            this.panelEx2.Controls.Add(this.label158);
            this.panelEx2.Controls.Add(this.tbServiceTagNA);
            this.panelEx2.Controls.Add(this.label159);
            this.panelEx2.Controls.Add(this.cbEstadoEquipoNA);
            this.panelEx2.Controls.Add(this.label160);
            this.panelEx2.Controls.Add(this.cbAnioCompraNA);
            this.panelEx2.Controls.Add(this.cbEquipoPadreCodNA);
            this.panelEx2.Controls.Add(this.label161);
            this.panelEx2.Controls.Add(this.label162);
            this.panelEx2.Controls.Add(this.label163);
            this.panelEx2.Controls.Add(this.cbAsignadoNA);
            this.panelEx2.Controls.Add(this.label164);
            this.panelEx2.Controls.Add(this.cbCatEqNA);
            this.panelEx2.Controls.Add(this.label165);
            this.panelEx2.Controls.Add(this.label166);
            this.panelEx2.Controls.Add(this.label167);
            this.panelEx2.Controls.Add(this.label168);
            this.panelEx2.Controls.Add(this.label169);
            this.panelEx2.Controls.Add(this.tbObseracionNA);
            this.panelEx2.Controls.Add(this.label170);
            this.panelEx2.Controls.Add(this.tbIpNA);
            this.panelEx2.Controls.Add(this.label171);
            this.panelEx2.Controls.Add(this.tbProcesadorNA);
            this.panelEx2.Controls.Add(this.tbModeloNA);
            this.panelEx2.Controls.Add(this.tbNroOrdenCompraNA);
            this.panelEx2.Controls.Add(this.tbNombreEquipoNA);
            this.panelEx2.Controls.Add(this.label172);
            this.panelEx2.Controls.Add(this.tbMarcaNA);
            this.panelEx2.Controls.Add(this.tbNroSerieNA);
            this.panelEx2.Controls.Add(this.tbNroControlPatrimonialNA);
            this.panelEx2.Controls.Add(this.label1);
            this.panelEx2.Controls.Add(this.DGVComponentesPc);
            this.panelEx2.Controls.Add(this.dgvEquipo);
            this.panelEx2.Controls.Add(this.tbBuscarEquipo);
            this.panelEx2.Controls.Add(this.btImpEquipo);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.btListarEquipo);
            this.panelEx2.Controls.Add(this.btEliminarEquipo);
            this.panelEx2.Controls.Add(this.btActualizarEquipo);
            this.panelEx2.Controls.Add(this.line2);
            this.panelEx2.Controls.Add(this.btLimpiarEquipo);
            this.panelEx2.Controls.Add(this.btRegistrarEquipo);
            this.panelEx2.Controls.Add(this.label15);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(991, 672);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 183;
            // 
            // rbEditarEq
            // 
            this.rbEditarEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarEq.AutoSize = true;
            this.rbEditarEq.Location = new System.Drawing.Point(568, 315);
            this.rbEditarEq.Name = "rbEditarEq";
            this.rbEditarEq.Size = new System.Drawing.Size(52, 17);
            this.rbEditarEq.TabIndex = 252;
            this.rbEditarEq.TabStop = true;
            this.rbEditarEq.Text = "Editar";
            this.rbEditarEq.UseVisualStyleBackColor = true;
            this.rbEditarEq.Click += new System.EventHandler(this.rbEditarEq_Click);
            // 
            // rbNuevoEq
            // 
            this.rbNuevoEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevoEq.AutoSize = true;
            this.rbNuevoEq.Location = new System.Drawing.Point(568, 293);
            this.rbNuevoEq.Name = "rbNuevoEq";
            this.rbNuevoEq.Size = new System.Drawing.Size(57, 17);
            this.rbNuevoEq.TabIndex = 251;
            this.rbNuevoEq.Text = "Nuevo";
            this.rbNuevoEq.UseVisualStyleBackColor = true;
            this.rbNuevoEq.Click += new System.EventHandler(this.rbNuevoEq_Click);
            // 
            // tbFuncionamientoNA
            // 
            // 
            // 
            // 
            this.tbFuncionamientoNA.Border.Class = "TextBoxBorder";
            this.tbFuncionamientoNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFuncionamientoNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFuncionamientoNA.Enabled = false;
            this.tbFuncionamientoNA.Location = new System.Drawing.Point(450, 138);
            this.tbFuncionamientoNA.Name = "tbFuncionamientoNA";
            this.tbFuncionamientoNA.PreventEnterBeep = true;
            this.tbFuncionamientoNA.Size = new System.Drawing.Size(303, 20);
            this.tbFuncionamientoNA.TabIndex = 241;
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(450, 122);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(82, 13);
            this.label157.TabIndex = 250;
            this.label157.Text = "Funcionamiento";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(772, 162);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(65, 13);
            this.label158.TabIndex = 249;
            this.label158.Text = "Service Tag";
            this.label158.Visible = false;
            // 
            // tbServiceTagNA
            // 
            // 
            // 
            // 
            this.tbServiceTagNA.Border.Class = "TextBoxBorder";
            this.tbServiceTagNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbServiceTagNA.Enabled = false;
            this.tbServiceTagNA.Location = new System.Drawing.Point(772, 178);
            this.tbServiceTagNA.Name = "tbServiceTagNA";
            this.tbServiceTagNA.PreventEnterBeep = true;
            this.tbServiceTagNA.Size = new System.Drawing.Size(132, 20);
            this.tbServiceTagNA.TabIndex = 248;
            this.tbServiceTagNA.Visible = false;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(739, 47);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(93, 13);
            this.label159.TabIndex = 247;
            this.label159.Text = "Cod Padre Equipo";
            // 
            // cbEstadoEquipoNA
            // 
            this.cbEstadoEquipoNA.DisplayMember = "Text";
            this.cbEstadoEquipoNA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstadoEquipoNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEquipoNA.Enabled = false;
            this.cbEstadoEquipoNA.FormattingEnabled = true;
            this.cbEstadoEquipoNA.ItemHeight = 15;
            this.cbEstadoEquipoNA.Items.AddRange(new object[] {
            this.comboItem51,
            this.comboItem54,
            this.comboItem55});
            this.cbEstadoEquipoNA.Location = new System.Drawing.Point(235, 136);
            this.cbEstadoEquipoNA.Name = "cbEstadoEquipoNA";
            this.cbEstadoEquipoNA.Size = new System.Drawing.Size(179, 21);
            this.cbEstadoEquipoNA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstadoEquipoNA.TabIndex = 237;
            // 
            // comboItem51
            // 
            this.comboItem51.Text = "BUENO";
            // 
            // comboItem54
            // 
            this.comboItem54.Text = "MALO";
            // 
            // comboItem55
            // 
            this.comboItem55.Text = "REGULAR";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(235, 122);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(47, 13);
            this.label160.TabIndex = 246;
            this.label160.Text = "Estado *";
            // 
            // cbAnioCompraNA
            // 
            this.cbAnioCompraNA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAnioCompraNA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnioCompraNA.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbAnioCompraNA.DisplayMember = "Text";
            this.cbAnioCompraNA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAnioCompraNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnioCompraNA.Enabled = false;
            this.cbAnioCompraNA.FormattingEnabled = true;
            this.cbAnioCompraNA.ItemHeight = 15;
            this.cbAnioCompraNA.Location = new System.Drawing.Point(450, 62);
            this.cbAnioCompraNA.Name = "cbAnioCompraNA";
            this.cbAnioCompraNA.Size = new System.Drawing.Size(129, 21);
            this.cbAnioCompraNA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAnioCompraNA.TabIndex = 239;
            // 
            // cbEquipoPadreCodNA
            // 
            this.cbEquipoPadreCodNA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEquipoPadreCodNA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEquipoPadreCodNA.DisplayMember = "Text";
            this.cbEquipoPadreCodNA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEquipoPadreCodNA.DropDownWidth = 300;
            this.cbEquipoPadreCodNA.Enabled = false;
            this.cbEquipoPadreCodNA.FormattingEnabled = true;
            this.cbEquipoPadreCodNA.ItemHeight = 15;
            this.cbEquipoPadreCodNA.Location = new System.Drawing.Point(737, 63);
            this.cbEquipoPadreCodNA.Name = "cbEquipoPadreCodNA";
            this.cbEquipoPadreCodNA.Size = new System.Drawing.Size(125, 21);
            this.cbEquipoPadreCodNA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEquipoPadreCodNA.TabIndex = 243;
            this.cbEquipoPadreCodNA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbEquipoPadreCodNA_KeyUp);
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(450, 84);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(68, 13);
            this.label161.TabIndex = 221;
            this.label161.Text = "IP de Equipo";
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(22, 85);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(44, 13);
            this.label162.TabIndex = 220;
            this.label162.Text = "Marca *";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(22, 47);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(101, 13);
            this.label163.TabIndex = 219;
            this.label163.Text = "Nombre del Equipo*";
            // 
            // cbAsignadoNA
            // 
            this.cbAsignadoNA.DisplayMember = "Text";
            this.cbAsignadoNA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAsignadoNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignadoNA.Enabled = false;
            this.cbAsignadoNA.FormattingEnabled = true;
            this.cbAsignadoNA.ItemHeight = 15;
            this.cbAsignadoNA.Items.AddRange(new object[] {
            this.comboItem56,
            this.comboItem57});
            this.cbAsignadoNA.Location = new System.Drawing.Point(592, 100);
            this.cbAsignadoNA.Name = "cbAsignadoNA";
            this.cbAsignadoNA.Size = new System.Drawing.Size(131, 21);
            this.cbAsignadoNA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAsignadoNA.TabIndex = 245;
            // 
            // comboItem56
            // 
            this.comboItem56.Text = "S";
            // 
            // comboItem57
            // 
            this.comboItem57.Text = "N";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Enabled = false;
            this.label164.Location = new System.Drawing.Point(592, 83);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(51, 13);
            this.label164.TabIndex = 223;
            this.label164.Text = "Asignado";
            // 
            // cbCatEqNA
            // 
            this.cbCatEqNA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCatEqNA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCatEqNA.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCatEqNA.DisplayMember = "Text";
            this.cbCatEqNA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCatEqNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatEqNA.Enabled = false;
            this.cbCatEqNA.FormattingEnabled = true;
            this.cbCatEqNA.ItemHeight = 15;
            this.cbCatEqNA.Location = new System.Drawing.Point(591, 62);
            this.cbCatEqNA.Name = "cbCatEqNA";
            this.cbCatEqNA.Size = new System.Drawing.Size(132, 21);
            this.cbCatEqNA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCatEqNA.TabIndex = 231;
            this.cbCatEqNA.Click += new System.EventHandler(this.cbCatEqNA_Click);
            this.cbCatEqNA.Leave += new System.EventHandler(this.cbCatEqNA_Leave);
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(22, 162);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(49, 13);
            this.label165.TabIndex = 222;
            this.label165.Text = "Modelo *";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(22, 123);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(91, 13);
            this.label166.TabIndex = 226;
            this.label166.Text = "Número de serie *";
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Location = new System.Drawing.Point(235, 83);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(86, 13);
            this.label167.TabIndex = 225;
            this.label167.Text = "Cod patrimonial *";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(235, 47);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(61, 13);
            this.label168.TabIndex = 224;
            this.label168.Text = "Procesador";
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(450, 47);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(104, 13);
            this.label169.TabIndex = 228;
            this.label169.Text = "Año de adquisición *";
            // 
            // tbObseracionNA
            // 
            // 
            // 
            // 
            this.tbObseracionNA.Border.Class = "TextBoxBorder";
            this.tbObseracionNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObseracionNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObseracionNA.Enabled = false;
            this.tbObseracionNA.Location = new System.Drawing.Point(450, 177);
            this.tbObseracionNA.Name = "tbObseracionNA";
            this.tbObseracionNA.PreventEnterBeep = true;
            this.tbObseracionNA.Size = new System.Drawing.Size(303, 20);
            this.tbObseracionNA.TabIndex = 242;
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(235, 164);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(142, 13);
            this.label170.TabIndex = 227;
            this.label170.Text = "Numero de orden de compra";
            // 
            // tbIpNA
            // 
            // 
            // 
            // 
            this.tbIpNA.Border.Class = "TextBoxBorder";
            this.tbIpNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbIpNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIpNA.Enabled = false;
            this.tbIpNA.Location = new System.Drawing.Point(450, 101);
            this.tbIpNA.Name = "tbIpNA";
            this.tbIpNA.PreventEnterBeep = true;
            this.tbIpNA.Size = new System.Drawing.Size(121, 20);
            this.tbIpNA.TabIndex = 240;
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(450, 161);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(67, 13);
            this.label171.TabIndex = 229;
            this.label171.Text = "Observación";
            // 
            // tbProcesadorNA
            // 
            // 
            // 
            // 
            this.tbProcesadorNA.Border.Class = "TextBoxBorder";
            this.tbProcesadorNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProcesadorNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProcesadorNA.Enabled = false;
            this.tbProcesadorNA.Location = new System.Drawing.Point(235, 62);
            this.tbProcesadorNA.Name = "tbProcesadorNA";
            this.tbProcesadorNA.PreventEnterBeep = true;
            this.tbProcesadorNA.Size = new System.Drawing.Size(175, 20);
            this.tbProcesadorNA.TabIndex = 235;
            // 
            // tbModeloNA
            // 
            // 
            // 
            // 
            this.tbModeloNA.Border.Class = "TextBoxBorder";
            this.tbModeloNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbModeloNA.Enabled = false;
            this.tbModeloNA.Location = new System.Drawing.Point(22, 178);
            this.tbModeloNA.Name = "tbModeloNA";
            this.tbModeloNA.PreventEnterBeep = true;
            this.tbModeloNA.Size = new System.Drawing.Size(184, 20);
            this.tbModeloNA.TabIndex = 234;
            // 
            // tbNroOrdenCompraNA
            // 
            // 
            // 
            // 
            this.tbNroOrdenCompraNA.Border.Class = "TextBoxBorder";
            this.tbNroOrdenCompraNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroOrdenCompraNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroOrdenCompraNA.Enabled = false;
            this.tbNroOrdenCompraNA.Location = new System.Drawing.Point(235, 178);
            this.tbNroOrdenCompraNA.Name = "tbNroOrdenCompraNA";
            this.tbNroOrdenCompraNA.PreventEnterBeep = true;
            this.tbNroOrdenCompraNA.Size = new System.Drawing.Size(179, 20);
            this.tbNroOrdenCompraNA.TabIndex = 238;
            // 
            // tbNombreEquipoNA
            // 
            // 
            // 
            // 
            this.tbNombreEquipoNA.Border.Class = "TextBoxBorder";
            this.tbNombreEquipoNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNombreEquipoNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreEquipoNA.Enabled = false;
            this.tbNombreEquipoNA.Location = new System.Drawing.Point(22, 62);
            this.tbNombreEquipoNA.Name = "tbNombreEquipoNA";
            this.tbNombreEquipoNA.PreventEnterBeep = true;
            this.tbNombreEquipoNA.Size = new System.Drawing.Size(184, 20);
            this.tbNombreEquipoNA.TabIndex = 230;
            this.tbNombreEquipoNA.TextChanged += new System.EventHandler(this.tbNombreEquipoNA_TextChanged);
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(592, 49);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(59, 13);
            this.label172.TabIndex = 244;
            this.label172.Text = "Categoria *";
            this.label172.UseWaitCursor = true;
            // 
            // tbMarcaNA
            // 
            // 
            // 
            // 
            this.tbMarcaNA.Border.Class = "TextBoxBorder";
            this.tbMarcaNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMarcaNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMarcaNA.Enabled = false;
            this.tbMarcaNA.Location = new System.Drawing.Point(22, 100);
            this.tbMarcaNA.Name = "tbMarcaNA";
            this.tbMarcaNA.PreventEnterBeep = true;
            this.tbMarcaNA.Size = new System.Drawing.Size(184, 20);
            this.tbMarcaNA.TabIndex = 232;
            // 
            // tbNroSerieNA
            // 
            // 
            // 
            // 
            this.tbNroSerieNA.Border.Class = "TextBoxBorder";
            this.tbNroSerieNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroSerieNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroSerieNA.Enabled = false;
            this.tbNroSerieNA.Location = new System.Drawing.Point(22, 139);
            this.tbNroSerieNA.Name = "tbNroSerieNA";
            this.tbNroSerieNA.PreventEnterBeep = true;
            this.tbNroSerieNA.Size = new System.Drawing.Size(184, 20);
            this.tbNroSerieNA.TabIndex = 233;
            // 
            // tbNroControlPatrimonialNA
            // 
            // 
            // 
            // 
            this.tbNroControlPatrimonialNA.Border.Class = "TextBoxBorder";
            this.tbNroControlPatrimonialNA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroControlPatrimonialNA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroControlPatrimonialNA.Enabled = false;
            this.tbNroControlPatrimonialNA.Location = new System.Drawing.Point(235, 98);
            this.tbNroControlPatrimonialNA.Name = "tbNroControlPatrimonialNA";
            this.tbNroControlPatrimonialNA.PreventEnterBeep = true;
            this.tbNroControlPatrimonialNA.Size = new System.Drawing.Size(179, 20);
            this.tbNroControlPatrimonialNA.TabIndex = 236;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 184;
            this.label1.Text = "Componentes del Equipo";
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line2.Location = new System.Drawing.Point(2, 263);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(991, 23);
            this.line2.TabIndex = 183;
            this.line2.Text = "line2";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Equipos";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.panelEx1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(991, 672);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.Categorias;
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.rbEditarCat);
            this.panelEx1.Controls.Add(this.rbNuevoCat);
            this.panelEx1.Controls.Add(this.btImpCat);
            this.panelEx1.Controls.Add(this.btListarCategoria);
            this.panelEx1.Controls.Add(this.tbBuscarCategoria);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.line1);
            this.panelEx1.Controls.Add(this.DGVCategoria);
            this.panelEx1.Controls.Add(this.btEliminarCat);
            this.panelEx1.Controls.Add(this.btActualizarCat);
            this.panelEx1.Controls.Add(this.label16);
            this.panelEx1.Controls.Add(this.btLimpiarCat);
            this.panelEx1.Controls.Add(this.label27);
            this.panelEx1.Controls.Add(this.btREgistrarCat);
            this.panelEx1.Controls.Add(this.label26);
            this.panelEx1.Controls.Add(this.label25);
            this.panelEx1.Controls.Add(this.cbActivoCat);
            this.panelEx1.Controls.Add(this.tbNomCategoria);
            this.panelEx1.Controls.Add(this.tbDescripcionCat);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(991, 672);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 125;
            // 
            // rbEditarCat
            // 
            this.rbEditarCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarCat.AutoSize = true;
            this.rbEditarCat.Location = new System.Drawing.Point(564, 211);
            this.rbEditarCat.Name = "rbEditarCat";
            this.rbEditarCat.Size = new System.Drawing.Size(52, 17);
            this.rbEditarCat.TabIndex = 834;
            this.rbEditarCat.TabStop = true;
            this.rbEditarCat.Text = "Editar";
            this.rbEditarCat.UseVisualStyleBackColor = true;
            this.rbEditarCat.Click += new System.EventHandler(this.rbEditarCat_Click);
            // 
            // rbNuevoCat
            // 
            this.rbNuevoCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevoCat.AutoSize = true;
            this.rbNuevoCat.Location = new System.Drawing.Point(564, 193);
            this.rbNuevoCat.Name = "rbNuevoCat";
            this.rbNuevoCat.Size = new System.Drawing.Size(57, 17);
            this.rbNuevoCat.TabIndex = 833;
            this.rbNuevoCat.Text = "Nuevo";
            this.rbNuevoCat.UseVisualStyleBackColor = true;
            this.rbNuevoCat.Click += new System.EventHandler(this.rbNuevoCat_Click);
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.Location = new System.Drawing.Point(2, 158);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(991, 23);
            this.line1.TabIndex = 156;
            this.line1.Text = "line1";
            // 
            // Categorias
            // 
            this.Categorias.AttachedControl = this.superTabControlPanel2;
            this.Categorias.GlobalItem = false;
            this.Categorias.Name = "Categorias";
            this.Categorias.Text = "Categorias";
            // 
            // sideNavPanel9
            // 
            this.sideNavPanel9.Controls.Add(this.buttonX20);
            this.sideNavPanel9.Controls.Add(this.buttonX5);
            this.sideNavPanel9.Controls.Add(this.buttonX4);
            this.sideNavPanel9.Controls.Add(this.buttonX12);
            this.sideNavPanel9.Controls.Add(this.buttonX13);
            this.sideNavPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel9.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel9.Name = "sideNavPanel9";
            this.sideNavPanel9.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel9.TabIndex = 46;
            this.sideNavPanel9.Visible = false;
            // 
            // buttonX20
            // 
            this.buttonX20.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX20.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX20.Location = new System.Drawing.Point(536, 363);
            this.buttonX20.Name = "buttonX20";
            this.buttonX20.Size = new System.Drawing.Size(132, 125);
            this.buttonX20.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX20.TabIndex = 59;
            this.buttonX20.Text = "Movimiento de Equipo";
            this.buttonX20.Click += new System.EventHandler(this.buttonX20_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Location = new System.Drawing.Point(373, 363);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(132, 125);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX5.TabIndex = 58;
            this.buttonX5.Text = "Perfil";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click_2);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(617, 218);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(132, 125);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX4.TabIndex = 57;
            this.buttonX4.Text = "Personal";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click_2);
            // 
            // buttonX12
            // 
            this.buttonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX12.Location = new System.Drawing.Point(455, 218);
            this.buttonX12.Name = "buttonX12";
            this.buttonX12.Size = new System.Drawing.Size(132, 125);
            this.buttonX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX12.TabIndex = 56;
            this.buttonX12.Text = "Equipo";
            this.buttonX12.Click += new System.EventHandler(this.buttonX12_Click);
            // 
            // buttonX13
            // 
            this.buttonX13.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX13.Location = new System.Drawing.Point(289, 218);
            this.buttonX13.Name = "buttonX13";
            this.buttonX13.Size = new System.Drawing.Size(132, 125);
            this.buttonX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX13.TabIndex = 55;
            this.buttonX13.Text = "Software";
            this.buttonX13.Click += new System.EventHandler(this.buttonX13_Click);
            // 
            // sideNavPanel13
            // 
            this.sideNavPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel13.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel13.Name = "sideNavPanel13";
            this.sideNavPanel13.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel13.TabIndex = 129;
            this.sideNavPanel13.Visible = false;
            // 
            // sideNavPanel6
            // 
            this.sideNavPanel6.Controls.Add(this.panelEx6);
            this.sideNavPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel6.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel6.Name = "sideNavPanel6";
            this.sideNavPanel6.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel6.TabIndex = 26;
            this.sideNavPanel6.Visible = false;
            // 
            // panelEx6
            // 
            this.panelEx6.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx6.Controls.Add(this.DGVPersonal);
            this.panelEx6.Controls.Add(this.groupBox1);
            this.panelEx6.Controls.Add(this.rbEditarPersonal);
            this.panelEx6.Controls.Add(this.rbNuevaPersonal);
            this.panelEx6.Controls.Add(this.label52);
            this.panelEx6.Controls.Add(this.tbArea);
            this.panelEx6.Controls.Add(this.label51);
            this.panelEx6.Controls.Add(this.tbUnOrganica);
            this.panelEx6.Controls.Add(this.chbFTerminoLaboral);
            this.panelEx6.Controls.Add(this.btLimpiarPersonal_);
            this.panelEx6.Controls.Add(this.btSalirPersonal_);
            this.panelEx6.Controls.Add(this.btEliminarPersonal_);
            this.panelEx6.Controls.Add(this.btEditarPersonal_);
            this.panelEx6.Controls.Add(this.btGrabarPersonal_);
            this.panelEx6.Controls.Add(this.dtFechaTerminoLaboral);
            this.panelEx6.Controls.Add(this.label65);
            this.panelEx6.Controls.Add(this.dtFechaIngresoLaboral);
            this.panelEx6.Controls.Add(this.label39);
            this.panelEx6.Controls.Add(this.label93);
            this.panelEx6.Controls.Add(this.tbEscalafon);
            this.panelEx6.Controls.Add(this.label92);
            this.panelEx6.Controls.Add(this.dtFechaNacPersonal);
            this.panelEx6.Controls.Add(this.label91);
            this.panelEx6.Controls.Add(this.line11);
            this.panelEx6.Controls.Add(this.line10);
            this.panelEx6.Controls.Add(this.line7);
            this.panelEx6.Controls.Add(this.label42);
            this.panelEx6.Controls.Add(this.label41);
            this.panelEx6.Controls.Add(this.label40);
            this.panelEx6.Controls.Add(this.label71);
            this.panelEx6.Controls.Add(this.cbInstanciaPersonal);
            this.panelEx6.Controls.Add(this.tbNombrePersonal);
            this.panelEx6.Controls.Add(this.tbMaternoPersonal);
            this.panelEx6.Controls.Add(this.label34);
            this.panelEx6.Controls.Add(this.cbSedePersonal);
            this.panelEx6.Controls.Add(this.label48);
            this.panelEx6.Controls.Add(this.label69);
            this.panelEx6.Controls.Add(this.label44);
            this.panelEx6.Controls.Add(this.cbPerfilPersonal);
            this.panelEx6.Controls.Add(this.tbPaternoPersonal);
            this.panelEx6.Controls.Add(this.label43);
            this.panelEx6.Controls.Add(this.label63);
            this.panelEx6.Controls.Add(this.tbDniPersonal);
            this.panelEx6.Controls.Add(this.dtPersonal);
            this.panelEx6.Controls.Add(this.cbEstadoPersonal);
            this.panelEx6.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx6.Location = new System.Drawing.Point(0, 0);
            this.panelEx6.Name = "panelEx6";
            this.panelEx6.Size = new System.Drawing.Size(1003, 711);
            this.panelEx6.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx6.Style.GradientAngle = 90;
            this.panelEx6.TabIndex = 0;
            this.panelEx6.Click += new System.EventHandler(this.panelEx6_Click);
            // 
            // DGVPersonal
            // 
            this.DGVPersonal.AllowUserToAddRows = false;
            this.DGVPersonal.AllowUserToDeleteRows = false;
            this.DGVPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPersonal.BackgroundColor = System.Drawing.Color.White;
            this.DGVPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.Column41,
            this.Column42,
            this.Column43,
            this.Column44,
            this.Column49,
            this.Column52,
            this.Column53,
            this.Column54,
            this.Column58});
            this.DGVPersonal.Location = new System.Drawing.Point(597, 468);
            this.DGVPersonal.Name = "DGVPersonal";
            this.DGVPersonal.ReadOnly = true;
            this.DGVPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPersonal.Size = new System.Drawing.Size(176, 87);
            this.DGVPersonal.TabIndex = 838;
            this.DGVPersonal.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "doc_entry_personal";
            this.dataGridViewTextBoxColumn3.HeaderText = "doc_entry_personal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "c_usuario";
            this.dataGridViewTextBoxColumn5.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "c_nombres";
            this.dataGridViewTextBoxColumn9.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "c_ape_paterno";
            this.dataGridViewTextBoxColumn10.HeaderText = "Paterno";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "c_ape_materno";
            this.dataGridViewTextBoxColumn11.HeaderText = "materno";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn13.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "fecha_ingreso";
            this.dataGridViewTextBoxColumn14.HeaderText = "fecha_ingreso";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "observacion";
            this.dataGridViewTextBoxColumn15.HeaderText = "observacion";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "c_perfil";
            this.dataGridViewTextBoxColumn16.HeaderText = "cod_perfil";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "activo";
            this.dataGridViewTextBoxColumn17.HeaderText = "activo";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn18.HeaderText = "dni";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "fecha_desactivacion";
            this.dataGridViewTextBoxColumn19.HeaderText = "fecha_desactivacion";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "motivo_desactivacion";
            this.dataGridViewTextBoxColumn20.HeaderText = "motivo_desactivacion";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "c_instancia";
            this.dataGridViewTextBoxColumn21.HeaderText = "cod_instancia";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "nombre_instancia";
            this.dataGridViewTextBoxColumn22.HeaderText = "nombre_instancia";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "c_sede";
            this.dataGridViewTextBoxColumn23.HeaderText = "cod_sede";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "nombre_sede";
            this.dataGridViewTextBoxColumn24.HeaderText = "nombre_sede";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // Column41
            // 
            this.Column41.DataPropertyName = "perfil";
            this.Column41.HeaderText = "perfil";
            this.Column41.Name = "Column41";
            this.Column41.ReadOnly = true;
            // 
            // Column42
            // 
            this.Column42.DataPropertyName = "estado";
            this.Column42.HeaderText = "estado";
            this.Column42.Name = "Column42";
            this.Column42.ReadOnly = true;
            // 
            // Column43
            // 
            this.Column43.DataPropertyName = "fecha_nacimiento";
            this.Column43.HeaderText = "fecha_nacimiento";
            this.Column43.Name = "Column43";
            this.Column43.ReadOnly = true;
            // 
            // Column44
            // 
            this.Column44.DataPropertyName = "escalafon";
            this.Column44.HeaderText = "escalafon";
            this.Column44.Name = "Column44";
            this.Column44.ReadOnly = true;
            // 
            // Column49
            // 
            this.Column49.DataPropertyName = "fecha_termino_lab";
            this.Column49.HeaderText = "fecha_termino_lab";
            this.Column49.Name = "Column49";
            this.Column49.ReadOnly = true;
            // 
            // Column52
            // 
            this.Column52.DataPropertyName = "unidad_organica";
            this.Column52.HeaderText = "unidad_organica";
            this.Column52.Name = "Column52";
            this.Column52.ReadOnly = true;
            // 
            // Column53
            // 
            this.Column53.DataPropertyName = "area";
            this.Column53.HeaderText = "area";
            this.Column53.Name = "Column53";
            this.Column53.ReadOnly = true;
            // 
            // Column54
            // 
            this.Column54.DataPropertyName = "tipo_personal";
            this.Column54.HeaderText = "tipo_personal";
            this.Column54.Name = "Column54";
            this.Column54.ReadOnly = true;
            // 
            // Column58
            // 
            this.Column58.DataPropertyName = "fecha_ingreso_lab";
            this.Column58.HeaderText = "fecha_ingreso_lab";
            this.Column58.Name = "Column58";
            this.Column58.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPerAdmi);
            this.groupBox1.Controls.Add(this.rbPerJur);
            this.groupBox1.Location = new System.Drawing.Point(14, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 36);
            this.groupBox1.TabIndex = 837;
            this.groupBox1.TabStop = false;
            // 
            // rbPerAdmi
            // 
            this.rbPerAdmi.AutoSize = true;
            this.rbPerAdmi.Checked = true;
            this.rbPerAdmi.Enabled = false;
            this.rbPerAdmi.Location = new System.Drawing.Point(12, 13);
            this.rbPerAdmi.Name = "rbPerAdmi";
            this.rbPerAdmi.Size = new System.Drawing.Size(90, 17);
            this.rbPerAdmi.TabIndex = 376;
            this.rbPerAdmi.TabStop = true;
            this.rbPerAdmi.Text = "Administrativo";
            this.rbPerAdmi.UseVisualStyleBackColor = true;
            this.rbPerAdmi.Click += new System.EventHandler(this.rbPerAdmi_Click);
            // 
            // rbPerJur
            // 
            this.rbPerJur.AutoSize = true;
            this.rbPerJur.Enabled = false;
            this.rbPerJur.Location = new System.Drawing.Point(129, 13);
            this.rbPerJur.Name = "rbPerJur";
            this.rbPerJur.Size = new System.Drawing.Size(88, 17);
            this.rbPerJur.TabIndex = 377;
            this.rbPerJur.Text = "Jurisdiccional";
            this.rbPerJur.UseVisualStyleBackColor = true;
            this.rbPerJur.Click += new System.EventHandler(this.rbPerJur_Click);
            // 
            // rbEditarPersonal
            // 
            this.rbEditarPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbEditarPersonal.AutoSize = true;
            this.rbEditarPersonal.Location = new System.Drawing.Point(356, 595);
            this.rbEditarPersonal.Name = "rbEditarPersonal";
            this.rbEditarPersonal.Size = new System.Drawing.Size(52, 17);
            this.rbEditarPersonal.TabIndex = 831;
            this.rbEditarPersonal.TabStop = true;
            this.rbEditarPersonal.Text = "Editar";
            this.rbEditarPersonal.UseVisualStyleBackColor = true;
            this.rbEditarPersonal.Click += new System.EventHandler(this.rbEditarPersonal_Click);
            // 
            // rbNuevaPersonal
            // 
            this.rbNuevaPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbNuevaPersonal.AutoSize = true;
            this.rbNuevaPersonal.Location = new System.Drawing.Point(281, 595);
            this.rbNuevaPersonal.Name = "rbNuevaPersonal";
            this.rbNuevaPersonal.Size = new System.Drawing.Size(57, 17);
            this.rbNuevaPersonal.TabIndex = 830;
            this.rbNuevaPersonal.Text = "Nuevo";
            this.rbNuevaPersonal.UseVisualStyleBackColor = true;
            this.rbNuevaPersonal.Click += new System.EventHandler(this.rbNuevaPersonal_Click);
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 306);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(36, 13);
            this.label52.TabIndex = 380;
            this.label52.Text = "Area *";
            // 
            // tbArea
            // 
            this.tbArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbArea.Border.Class = "TextBoxBorder";
            this.tbArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbArea.Enabled = false;
            this.tbArea.Location = new System.Drawing.Point(104, 304);
            this.tbArea.Name = "tbArea";
            this.tbArea.PreventEnterBeep = true;
            this.tbArea.Size = new System.Drawing.Size(352, 20);
            this.tbArea.TabIndex = 119;
            this.tbArea.TextChanged += new System.EventHandler(this.tbArea_TextChanged);
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(4, 267);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(94, 13);
            this.label51.TabIndex = 378;
            this.label51.Text = "Unidad Organica *";
            // 
            // tbUnOrganica
            // 
            this.tbUnOrganica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbUnOrganica.Border.Class = "TextBoxBorder";
            this.tbUnOrganica.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbUnOrganica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUnOrganica.Enabled = false;
            this.tbUnOrganica.Location = new System.Drawing.Point(102, 265);
            this.tbUnOrganica.Name = "tbUnOrganica";
            this.tbUnOrganica.PreventEnterBeep = true;
            this.tbUnOrganica.Size = new System.Drawing.Size(352, 20);
            this.tbUnOrganica.TabIndex = 118;
            this.tbUnOrganica.TextChanged += new System.EventHandler(this.tbUnOrganica_TextChanged);
            // 
            // chbFTerminoLaboral
            // 
            this.chbFTerminoLaboral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.chbFTerminoLaboral.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chbFTerminoLaboral.Enabled = false;
            this.chbFTerminoLaboral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFTerminoLaboral.Location = new System.Drawing.Point(29, 505);
            this.chbFTerminoLaboral.Name = "chbFTerminoLaboral";
            this.chbFTerminoLaboral.Size = new System.Drawing.Size(149, 23);
            this.chbFTerminoLaboral.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chbFTerminoLaboral.TabIndex = 128;
            this.chbFTerminoLaboral.Text = "Fecha de término laboral";
            this.chbFTerminoLaboral.TextColor = System.Drawing.Color.Black;
            this.chbFTerminoLaboral.Click += new System.EventHandler(this.chbFTerminoLaboral_Click);
            // 
            // btLimpiarPersonal_
            // 
            this.btLimpiarPersonal_.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLimpiarPersonal_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLimpiarPersonal_.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLimpiarPersonal_.Location = new System.Drawing.Point(573, 625);
            this.btLimpiarPersonal_.Name = "btLimpiarPersonal_";
            this.btLimpiarPersonal_.Size = new System.Drawing.Size(75, 23);
            this.btLimpiarPersonal_.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLimpiarPersonal_.TabIndex = 374;
            this.btLimpiarPersonal_.Text = "Limpiar";
            this.btLimpiarPersonal_.Click += new System.EventHandler(this.btLimpiarPersonal__Click);
            // 
            // btSalirPersonal_
            // 
            this.btSalirPersonal_.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSalirPersonal_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSalirPersonal_.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSalirPersonal_.Location = new System.Drawing.Point(673, 625);
            this.btSalirPersonal_.Name = "btSalirPersonal_";
            this.btSalirPersonal_.Size = new System.Drawing.Size(75, 23);
            this.btSalirPersonal_.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSalirPersonal_.TabIndex = 373;
            this.btSalirPersonal_.Text = "Salir";
            this.btSalirPersonal_.Click += new System.EventHandler(this.btSalirPersonal__Click);
            // 
            // btEliminarPersonal_
            // 
            this.btEliminarPersonal_.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminarPersonal_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btEliminarPersonal_.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEliminarPersonal_.Location = new System.Drawing.Point(477, 625);
            this.btEliminarPersonal_.Name = "btEliminarPersonal_";
            this.btEliminarPersonal_.Size = new System.Drawing.Size(75, 23);
            this.btEliminarPersonal_.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminarPersonal_.TabIndex = 132;
            this.btEliminarPersonal_.Text = "Eliminar";
            this.btEliminarPersonal_.Click += new System.EventHandler(this.btEliminarPersonal__Click);
            // 
            // btEditarPersonal_
            // 
            this.btEditarPersonal_.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEditarPersonal_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btEditarPersonal_.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEditarPersonal_.Enabled = false;
            this.btEditarPersonal_.Location = new System.Drawing.Point(378, 625);
            this.btEditarPersonal_.Name = "btEditarPersonal_";
            this.btEditarPersonal_.Size = new System.Drawing.Size(75, 23);
            this.btEditarPersonal_.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEditarPersonal_.TabIndex = 131;
            this.btEditarPersonal_.Text = "Actualizar";
            this.btEditarPersonal_.Click += new System.EventHandler(this.btEditarPersonal__Click);
            // 
            // btGrabarPersonal_
            // 
            this.btGrabarPersonal_.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGrabarPersonal_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btGrabarPersonal_.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGrabarPersonal_.Enabled = false;
            this.btGrabarPersonal_.Location = new System.Drawing.Point(281, 625);
            this.btGrabarPersonal_.Name = "btGrabarPersonal_";
            this.btGrabarPersonal_.Size = new System.Drawing.Size(75, 23);
            this.btGrabarPersonal_.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGrabarPersonal_.TabIndex = 130;
            this.btGrabarPersonal_.Text = "Grabar";
            this.btGrabarPersonal_.Click += new System.EventHandler(this.btGrabarPersonal__Click);
            // 
            // dtFechaTerminoLaboral
            // 
            this.dtFechaTerminoLaboral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaTerminoLaboral.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaTerminoLaboral.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaTerminoLaboral.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaTerminoLaboral.ButtonDropDown.Visible = true;
            this.dtFechaTerminoLaboral.IsPopupCalendarOpen = false;
            this.dtFechaTerminoLaboral.Location = new System.Drawing.Point(181, 505);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaTerminoLaboral.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaTerminoLaboral.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaTerminoLaboral.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaTerminoLaboral.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaTerminoLaboral.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaTerminoLaboral.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaTerminoLaboral.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaTerminoLaboral.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaTerminoLaboral.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaTerminoLaboral.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaTerminoLaboral.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaTerminoLaboral.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaTerminoLaboral.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaTerminoLaboral.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaTerminoLaboral.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaTerminoLaboral.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaTerminoLaboral.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaTerminoLaboral.Name = "dtFechaTerminoLaboral";
            this.dtFechaTerminoLaboral.Size = new System.Drawing.Size(112, 20);
            this.dtFechaTerminoLaboral.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaTerminoLaboral.TabIndex = 129;
            this.dtFechaTerminoLaboral.Visible = false;
            // 
            // label65
            // 
            this.label65.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 479);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(123, 13);
            this.label65.TabIndex = 367;
            this.label65.Text = "Fecha de ingreso laboral";
            // 
            // dtFechaIngresoLaboral
            // 
            this.dtFechaIngresoLaboral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaIngresoLaboral.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaIngresoLaboral.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaIngresoLaboral.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaIngresoLaboral.ButtonDropDown.Visible = true;
            this.dtFechaIngresoLaboral.Enabled = false;
            this.dtFechaIngresoLaboral.IsPopupCalendarOpen = false;
            this.dtFechaIngresoLaboral.Location = new System.Drawing.Point(180, 480);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaIngresoLaboral.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaIngresoLaboral.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaIngresoLaboral.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaIngresoLaboral.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaIngresoLaboral.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaIngresoLaboral.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaIngresoLaboral.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaIngresoLaboral.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaIngresoLaboral.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaIngresoLaboral.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaIngresoLaboral.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaIngresoLaboral.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaIngresoLaboral.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaIngresoLaboral.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaIngresoLaboral.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaIngresoLaboral.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaIngresoLaboral.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaIngresoLaboral.Name = "dtFechaIngresoLaboral";
            this.dtFechaIngresoLaboral.Size = new System.Drawing.Size(115, 20);
            this.dtFechaIngresoLaboral.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaIngresoLaboral.TabIndex = 127;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(14, 355);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(80, 13);
            this.label39.TabIndex = 365;
            this.label39.Text = "Datos laborales";
            // 
            // label93
            // 
            this.label93.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(512, 180);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(54, 13);
            this.label93.TabIndex = 363;
            this.label93.Text = "Escalafon";
            // 
            // tbEscalafon
            // 
            this.tbEscalafon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbEscalafon.Border.Class = "TextBoxBorder";
            this.tbEscalafon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEscalafon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEscalafon.Enabled = false;
            this.tbEscalafon.Location = new System.Drawing.Point(623, 183);
            this.tbEscalafon.Name = "tbEscalafon";
            this.tbEscalafon.PreventEnterBeep = true;
            this.tbEscalafon.Size = new System.Drawing.Size(296, 20);
            this.tbEscalafon.TabIndex = 122;
            // 
            // label92
            // 
            this.label92.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(512, 97);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(108, 13);
            this.label92.TabIndex = 362;
            this.label92.Text = "Fecha de Nacimiento";
            // 
            // dtFechaNacPersonal
            // 
            this.dtFechaNacPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtFechaNacPersonal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaNacPersonal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaNacPersonal.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaNacPersonal.ButtonDropDown.Visible = true;
            this.dtFechaNacPersonal.Enabled = false;
            this.dtFechaNacPersonal.IsPopupCalendarOpen = false;
            this.dtFechaNacPersonal.Location = new System.Drawing.Point(623, 97);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFechaNacPersonal.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaNacPersonal.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaNacPersonal.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaNacPersonal.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaNacPersonal.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaNacPersonal.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaNacPersonal.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaNacPersonal.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaNacPersonal.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaNacPersonal.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaNacPersonal.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtFechaNacPersonal.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFechaNacPersonal.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaNacPersonal.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaNacPersonal.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaNacPersonal.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaNacPersonal.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaNacPersonal.Name = "dtFechaNacPersonal";
            this.dtFechaNacPersonal.Size = new System.Drawing.Size(110, 20);
            this.dtFechaNacPersonal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaNacPersonal.TabIndex = 120;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(11, 43);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(96, 13);
            this.label91.TabIndex = 360;
            this.label91.Text = "Datos del Personal";
            // 
            // line11
            // 
            this.line11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line11.Location = new System.Drawing.Point(0, 576);
            this.line11.Name = "line11";
            this.line11.Size = new System.Drawing.Size(1000, 23);
            this.line11.TabIndex = 359;
            this.line11.Text = "line11";
            // 
            // line10
            // 
            this.line10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line10.Location = new System.Drawing.Point(0, 353);
            this.line10.Name = "line10";
            this.line10.Size = new System.Drawing.Size(1000, 23);
            this.line10.TabIndex = 358;
            this.line10.Text = "line10";
            // 
            // line7
            // 
            this.line7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line7.Location = new System.Drawing.Point(-4, 40);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(1000, 23);
            this.line7.TabIndex = 357;
            this.line7.Text = "line7";
            // 
            // sideNavPanel5
            // 
            this.sideNavPanel5.Controls.Add(this.panelEx5);
            this.sideNavPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel5.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel5.Name = "sideNavPanel5";
            this.sideNavPanel5.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel5.TabIndex = 22;
            this.sideNavPanel5.Visible = false;
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx5.Controls.Add(this.buttonX3);
            this.panelEx5.Controls.Add(this.rbEditarPerfil);
            this.panelEx5.Controls.Add(this.rbNuevoPErfil);
            this.panelEx5.Controls.Add(this.btImpPerfil);
            this.panelEx5.Controls.Add(this.btListarPerfil);
            this.panelEx5.Controls.Add(this.DGVPerfil);
            this.panelEx5.Controls.Add(this.cbActivoPerfil);
            this.panelEx5.Controls.Add(this.tbPerfil);
            this.panelEx5.Controls.Add(this.labelX7);
            this.panelEx5.Controls.Add(this.btEliminarPErfil);
            this.panelEx5.Controls.Add(this.line6);
            this.panelEx5.Controls.Add(this.btActualizarPerfil);
            this.panelEx5.Controls.Add(this.label32);
            this.panelEx5.Controls.Add(this.btLimpiarPerfil);
            this.panelEx5.Controls.Add(this.btRegistrarPerfil);
            this.panelEx5.Controls.Add(this.label47);
            this.panelEx5.Controls.Add(this.tbObservPerfil);
            this.panelEx5.Controls.Add(this.label46);
            this.panelEx5.Controls.Add(this.tbNombrePerfil);
            this.panelEx5.Controls.Add(this.label45);
            this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx5.Location = new System.Drawing.Point(0, 0);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(1003, 711);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 0;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(920, 154);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(75, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 830;
            this.buttonX3.Text = "Salir";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click_2);
            // 
            // rbEditarPerfil
            // 
            this.rbEditarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarPerfil.AutoSize = true;
            this.rbEditarPerfil.Location = new System.Drawing.Point(463, 124);
            this.rbEditarPerfil.Name = "rbEditarPerfil";
            this.rbEditarPerfil.Size = new System.Drawing.Size(52, 17);
            this.rbEditarPerfil.TabIndex = 829;
            this.rbEditarPerfil.TabStop = true;
            this.rbEditarPerfil.Text = "Editar";
            this.rbEditarPerfil.UseVisualStyleBackColor = true;
            this.rbEditarPerfil.Click += new System.EventHandler(this.rbEditarPerfil_Click);
            // 
            // rbNuevoPErfil
            // 
            this.rbNuevoPErfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevoPErfil.AutoSize = true;
            this.rbNuevoPErfil.Location = new System.Drawing.Point(388, 124);
            this.rbNuevoPErfil.Name = "rbNuevoPErfil";
            this.rbNuevoPErfil.Size = new System.Drawing.Size(57, 17);
            this.rbNuevoPErfil.TabIndex = 828;
            this.rbNuevoPErfil.Text = "Nuevo";
            this.rbNuevoPErfil.UseVisualStyleBackColor = true;
            this.rbNuevoPErfil.Click += new System.EventHandler(this.rbNuevoPErfil_Click);
            // 
            // line6
            // 
            this.line6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line6.Location = new System.Drawing.Point(2, 95);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(1001, 23);
            this.line6.TabIndex = 356;
            this.line6.Text = "line6";
            // 
            // sideNavPanel1
            // 
            this.sideNavPanel1.Controls.Add(this.panelEx9);
            this.sideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel1.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel1.Name = "sideNavPanel1";
            this.sideNavPanel1.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel1.TabIndex = 2;
            this.sideNavPanel1.Visible = false;
            // 
            // panelEx9
            // 
            this.panelEx9.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx9.Controls.Add(this.rbEditarSof);
            this.panelEx9.Controls.Add(this.rbNuevoSof);
            this.panelEx9.Controls.Add(this.btImpSoft);
            this.panelEx9.Controls.Add(this.btListarSoft);
            this.panelEx9.Controls.Add(this.tbBuscarSoft);
            this.panelEx9.Controls.Add(this.cbAnioAquisSoft);
            this.panelEx9.Controls.Add(this.labelX3);
            this.panelEx9.Controls.Add(this.DGVSoftware);
            this.panelEx9.Controls.Add(this.btnEliminarSoft);
            this.panelEx9.Controls.Add(this.line4);
            this.panelEx9.Controls.Add(this.btnActualizarSoft);
            this.panelEx9.Controls.Add(this.tbObservacionSoft);
            this.panelEx9.Controls.Add(this.btnLimpiarSoft);
            this.panelEx9.Controls.Add(this.label37);
            this.panelEx9.Controls.Add(this.btnRegistrarSoft);
            this.panelEx9.Controls.Add(this.label19);
            this.panelEx9.Controls.Add(this.label38);
            this.panelEx9.Controls.Add(this.label20);
            this.panelEx9.Controls.Add(this.label36);
            this.panelEx9.Controls.Add(this.tbNroOCSoft);
            this.panelEx9.Controls.Add(this.label35);
            this.panelEx9.Controls.Add(this.tbCantUsuarios);
            this.panelEx9.Controls.Add(this.tbSoftware);
            this.panelEx9.Controls.Add(this.label5);
            this.panelEx9.Controls.Add(this.tbVersionSoft);
            this.panelEx9.Controls.Add(this.label18);
            this.panelEx9.Controls.Add(this.cbActivoSoft);
            this.panelEx9.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx9.Location = new System.Drawing.Point(0, 0);
            this.panelEx9.Name = "panelEx9";
            this.panelEx9.Size = new System.Drawing.Size(1003, 711);
            this.panelEx9.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx9.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx9.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx9.Style.GradientAngle = 90;
            this.panelEx9.TabIndex = 137;
            // 
            // rbEditarSof
            // 
            this.rbEditarSof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarSof.AutoSize = true;
            this.rbEditarSof.Location = new System.Drawing.Point(587, 185);
            this.rbEditarSof.Name = "rbEditarSof";
            this.rbEditarSof.Size = new System.Drawing.Size(52, 17);
            this.rbEditarSof.TabIndex = 836;
            this.rbEditarSof.TabStop = true;
            this.rbEditarSof.Text = "Editar";
            this.rbEditarSof.UseVisualStyleBackColor = true;
            this.rbEditarSof.Click += new System.EventHandler(this.rbEditarSof_Click);
            // 
            // rbNuevoSof
            // 
            this.rbNuevoSof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevoSof.AutoSize = true;
            this.rbNuevoSof.Location = new System.Drawing.Point(587, 167);
            this.rbNuevoSof.Name = "rbNuevoSof";
            this.rbNuevoSof.Size = new System.Drawing.Size(57, 17);
            this.rbNuevoSof.TabIndex = 835;
            this.rbNuevoSof.Text = "Nuevo";
            this.rbNuevoSof.UseVisualStyleBackColor = true;
            this.rbNuevoSof.Click += new System.EventHandler(this.rbNuevoSof_Click);
            // 
            // line4
            // 
            this.line4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line4.Location = new System.Drawing.Point(3, 135);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(1001, 23);
            this.line4.TabIndex = 356;
            this.line4.Text = "line4";
            // 
            // sideNavPanel4
            // 
            this.sideNavPanel4.Controls.Add(this.panelEx7);
            this.sideNavPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel4.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel4.Name = "sideNavPanel4";
            this.sideNavPanel4.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel4.TabIndex = 18;
            this.sideNavPanel4.Visible = false;
            // 
            // panelEx7
            // 
            this.panelEx7.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx7.Controls.Add(this.btReporteSoft);
            this.panelEx7.Controls.Add(this.tbObservacionAS);
            this.panelEx7.Controls.Add(this.DGVAsignacionSoft);
            this.panelEx7.Controls.Add(this.tbAsignacionSoft);
            this.panelEx7.Controls.Add(this.cbCodSoftAS);
            this.panelEx7.Controls.Add(this.labelX8);
            this.panelEx7.Controls.Add(this.label50);
            this.panelEx7.Controls.Add(this.label88);
            this.panelEx7.Controls.Add(this.btListarAS);
            this.panelEx7.Controls.Add(this.btEliminarAS);
            this.panelEx7.Controls.Add(this.line5);
            this.panelEx7.Controls.Add(this.btActualizarAS);
            this.panelEx7.Controls.Add(this.label89);
            this.panelEx7.Controls.Add(this.btLimpiarAS);
            this.panelEx7.Controls.Add(this.label56);
            this.panelEx7.Controls.Add(this.btRegistrarAS);
            this.panelEx7.Controls.Add(this.textBoxX8);
            this.panelEx7.Controls.Add(this.label55);
            this.panelEx7.Controls.Add(this.textBoxX9);
            this.panelEx7.Controls.Add(this.label53);
            this.panelEx7.Controls.Add(this.textBoxX2);
            this.panelEx7.Controls.Add(this.dtFechaInstalacionAS);
            this.panelEx7.Controls.Add(this.label59);
            this.panelEx7.Controls.Add(this.dtFechaCaducidadAS);
            this.panelEx7.Controls.Add(this.textBoxX1);
            this.panelEx7.Controls.Add(this.label57);
            this.panelEx7.Controls.Add(this.label82);
            this.panelEx7.Controls.Add(this.cbCodEquipoAS);
            this.panelEx7.Controls.Add(this.label83);
            this.panelEx7.Controls.Add(this.label81);
            this.panelEx7.Controls.Add(this.label84);
            this.panelEx7.Controls.Add(this.label80);
            this.panelEx7.Controls.Add(this.label85);
            this.panelEx7.Controls.Add(this.textBoxX5);
            this.panelEx7.Controls.Add(this.textBoxX3);
            this.panelEx7.Controls.Add(this.textBoxX4);
            this.panelEx7.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx7.Location = new System.Drawing.Point(0, 0);
            this.panelEx7.Name = "panelEx7";
            this.panelEx7.Size = new System.Drawing.Size(1003, 711);
            this.panelEx7.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx7.Style.GradientAngle = 90;
            this.panelEx7.TabIndex = 4;
            // 
            // line5
            // 
            this.line5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line5.Location = new System.Drawing.Point(3, 283);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(1000, 23);
            this.line5.TabIndex = 900;
            this.line5.Text = "line5";
            // 
            // sideNavPanel12
            // 
            this.sideNavPanel12.Controls.Add(this.panelDesktop);
            this.sideNavPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel12.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel12.Name = "sideNavPanel12";
            this.sideNavPanel12.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel12.TabIndex = 119;
            this.sideNavPanel12.Visible = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1003, 711);
            this.panelDesktop.TabIndex = 8;
            // 
            // sideNavPanel10
            // 
            this.sideNavPanel10.Controls.Add(this.panelDesktopCU);
            this.sideNavPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel10.Location = new System.Drawing.Point(209, 37);
            this.sideNavPanel10.Name = "sideNavPanel10";
            this.sideNavPanel10.Size = new System.Drawing.Size(1003, 711);
            this.sideNavPanel10.TabIndex = 85;
            this.sideNavPanel10.Visible = false;
            // 
            // panelDesktopCU
            // 
            this.panelDesktopCU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelDesktopCU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopCU.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopCU.Name = "panelDesktopCU";
            this.panelDesktopCU.Size = new System.Drawing.Size(1003, 711);
            this.panelDesktopCU.TabIndex = 9;
            // 
            // sideNavPanel7
            // 
            this.sideNavPanel7.Controls.Add(this.panelEx3);
            this.sideNavPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel7.Location = new System.Drawing.Point(1, 1);
            this.sideNavPanel7.Name = "sideNavPanel7";
            this.sideNavPanel7.Size = new System.Drawing.Size(1215, 747);
            this.sideNavPanel7.TabIndex = 30;
            this.sideNavPanel7.Visible = false;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.buttonX1);
            this.panelEx3.Controls.Add(this.rbEditarSede);
            this.panelEx3.Controls.Add(this.rbNuevaSede);
            this.panelEx3.Controls.Add(this.btImpSede);
            this.panelEx3.Controls.Add(this.btListarSede);
            this.panelEx3.Controls.Add(this.DGVSede);
            this.panelEx3.Controls.Add(this.cbProvincia_Sede);
            this.panelEx3.Controls.Add(this.tbBuscarSede);
            this.panelEx3.Controls.Add(this.labelX4);
            this.panelEx3.Controls.Add(this.btEliminarSede);
            this.panelEx3.Controls.Add(this.line8);
            this.panelEx3.Controls.Add(this.btActualizarSede);
            this.panelEx3.Controls.Add(this.label62);
            this.panelEx3.Controls.Add(this.btLimpiarSede);
            this.panelEx3.Controls.Add(this.tbNombreSede);
            this.panelEx3.Controls.Add(this.btRegistrarSede);
            this.panelEx3.Controls.Add(this.cbDistritoJud_sede);
            this.panelEx3.Controls.Add(this.label24);
            this.panelEx3.Controls.Add(this.label60);
            this.panelEx3.Controls.Add(this.label23);
            this.panelEx3.Controls.Add(this.tbDireccSede);
            this.panelEx3.Controls.Add(this.label22);
            this.panelEx3.Controls.Add(this.label21);
            this.panelEx3.Controls.Add(this.tbObservSede);
            this.panelEx3.Controls.Add(this.cbActivoSede);
            this.panelEx3.Controls.Add(this.label28);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1215, 747);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(1024, 161);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 826;
            this.buttonX1.Text = "Salir";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_2);
            // 
            // rbEditarSede
            // 
            this.rbEditarSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarSede.AutoSize = true;
            this.rbEditarSede.Location = new System.Drawing.Point(626, 142);
            this.rbEditarSede.Name = "rbEditarSede";
            this.rbEditarSede.Size = new System.Drawing.Size(52, 17);
            this.rbEditarSede.TabIndex = 825;
            this.rbEditarSede.TabStop = true;
            this.rbEditarSede.Text = "Editar";
            this.rbEditarSede.UseVisualStyleBackColor = true;
            this.rbEditarSede.Click += new System.EventHandler(this.rbEditarSede_Click);
            // 
            // rbNuevaSede
            // 
            this.rbNuevaSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevaSede.AutoSize = true;
            this.rbNuevaSede.Location = new System.Drawing.Point(551, 142);
            this.rbNuevaSede.Name = "rbNuevaSede";
            this.rbNuevaSede.Size = new System.Drawing.Size(57, 17);
            this.rbNuevaSede.TabIndex = 824;
            this.rbNuevaSede.Text = "Nuevo";
            this.rbNuevaSede.UseVisualStyleBackColor = true;
            this.rbNuevaSede.Click += new System.EventHandler(this.rbNuevaSede_Click);
            // 
            // line8
            // 
            this.line8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line8.Location = new System.Drawing.Point(4, 116);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(1211, 23);
            this.line8.TabIndex = 823;
            this.line8.Text = "line8";
            // 
            // sideNavPanel8
            // 
            this.sideNavPanel8.Controls.Add(this.panelEx4);
            this.sideNavPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel8.Location = new System.Drawing.Point(1, 1);
            this.sideNavPanel8.Name = "sideNavPanel8";
            this.sideNavPanel8.Size = new System.Drawing.Size(1215, 747);
            this.sideNavPanel8.TabIndex = 34;
            this.sideNavPanel8.Visible = false;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.buttonX2);
            this.panelEx4.Controls.Add(this.rbEditarInst);
            this.panelEx4.Controls.Add(this.rbNuevaInst);
            this.panelEx4.Controls.Add(this.btImpInstancia);
            this.panelEx4.Controls.Add(this.btListarInst);
            this.panelEx4.Controls.Add(this.tbInstancia);
            this.panelEx4.Controls.Add(this.btEliminarIns);
            this.panelEx4.Controls.Add(this.labelX5);
            this.panelEx4.Controls.Add(this.tbDirInstancia);
            this.panelEx4.Controls.Add(this.DGVInstancia);
            this.panelEx4.Controls.Add(this.btActualizarInst);
            this.panelEx4.Controls.Add(this.line9);
            this.panelEx4.Controls.Add(this.btLimpiarInst);
            this.panelEx4.Controls.Add(this.btRegistrarIns);
            this.panelEx4.Controls.Add(this.label33);
            this.panelEx4.Controls.Add(this.cbSede_Instanc);
            this.panelEx4.Controls.Add(this.label31);
            this.panelEx4.Controls.Add(this.label68);
            this.panelEx4.Controls.Add(this.label30);
            this.panelEx4.Controls.Add(this.tbNroInst);
            this.panelEx4.Controls.Add(this.tbNombreInst);
            this.panelEx4.Controls.Add(this.cbActivoInst);
            this.panelEx4.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx4.Location = new System.Drawing.Point(0, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(1215, 747);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.panelEx4.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            this.panelEx4.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.StyleMouseOver.BorderColor.Color = System.Drawing.Color.White;
            this.panelEx4.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.panelEx4.TabIndex = 0;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(1026, 161);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 828;
            this.buttonX2.Text = "Salir";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click_2);
            // 
            // rbEditarInst
            // 
            this.rbEditarInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditarInst.AutoSize = true;
            this.rbEditarInst.Location = new System.Drawing.Point(685, 137);
            this.rbEditarInst.Name = "rbEditarInst";
            this.rbEditarInst.Size = new System.Drawing.Size(52, 17);
            this.rbEditarInst.TabIndex = 827;
            this.rbEditarInst.TabStop = true;
            this.rbEditarInst.Text = "Editar";
            this.rbEditarInst.UseVisualStyleBackColor = true;
            this.rbEditarInst.Click += new System.EventHandler(this.rbEditarInst_Click);
            // 
            // rbNuevaInst
            // 
            this.rbNuevaInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNuevaInst.AutoSize = true;
            this.rbNuevaInst.Location = new System.Drawing.Point(610, 137);
            this.rbNuevaInst.Name = "rbNuevaInst";
            this.rbNuevaInst.Size = new System.Drawing.Size(57, 17);
            this.rbNuevaInst.TabIndex = 826;
            this.rbNuevaInst.Text = "Nuevo";
            this.rbNuevaInst.UseVisualStyleBackColor = true;
            this.rbNuevaInst.Click += new System.EventHandler(this.rbNuevaInst_Click);
            // 
            // line9
            // 
            this.line9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line9.Location = new System.Drawing.Point(3, 116);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(1213, 23);
            this.line9.TabIndex = 824;
            this.line9.Text = "line9";
            // 
            // separator7
            // 
            this.separator7.FixedSize = new System.Drawing.Size(3, 1);
            this.separator7.Name = "separator7";
            this.separator7.Padding.Bottom = 2;
            this.separator7.Padding.Left = 6;
            this.separator7.Padding.Right = 6;
            this.separator7.Padding.Top = 2;
            this.separator7.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem1
            // 
            this.sideNavItem1.IsSystemMenu = true;
            this.sideNavItem1.Name = "sideNavItem1";
            this.sideNavItem1.Symbol = "";
            this.sideNavItem1.Text = "Menu";
            this.sideNavItem1.Click += new System.EventHandler(this.sideNavItem1_Click);
            // 
            // separator1
            // 
            this.separator1.FixedSize = new System.Drawing.Size(3, 1);
            this.separator1.Name = "separator1";
            this.separator1.Padding.Bottom = 2;
            this.separator1.Padding.Left = 6;
            this.separator1.Padding.Right = 6;
            this.separator1.Padding.Top = 2;
            this.separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem6Inicio
            // 
            this.sideNavItem6Inicio.Checked = true;
            this.sideNavItem6Inicio.Name = "sideNavItem6Inicio";
            this.sideNavItem6Inicio.Panel = this.sideNavPanel11;
            this.sideNavItem6Inicio.Symbol = "";
            this.sideNavItem6Inicio.Text = "Inicio";
            this.sideNavItem6Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // separator10
            // 
            this.separator10.FixedSize = new System.Drawing.Size(3, 1);
            this.separator10.Name = "separator10";
            this.separator10.Padding.Bottom = 2;
            this.separator10.Padding.Left = 6;
            this.separator10.Padding.Right = 6;
            this.separator10.Padding.Top = 2;
            this.separator10.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // SNIUsers
            // 
            this.SNIUsers.Name = "SNIUsers";
            this.SNIUsers.Panel = this.sideNavPanel10;
            this.SNIUsers.Symbol = "";
            this.SNIUsers.Text = "Mi Cuenta de Usuario";
            this.SNIUsers.Click += new System.EventHandler(this.SNIUsers_Click);
            // 
            // sideNavItem6
            // 
            this.sideNavItem6.Name = "sideNavItem6";
            this.sideNavItem6.Panel = this.sideNavPanel12;
            this.sideNavItem6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1});
            this.sideNavItem6.Symbol = "";
            this.sideNavItem6.Text = "Lista de  Usuarios del Sistema";
            this.sideNavItem6.Click += new System.EventHandler(this.sideNavItem6_Click);
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            this.controlContainerItem1.Text = "controlContainerItem1";
            // 
            // separator6
            // 
            this.separator6.FixedSize = new System.Drawing.Size(3, 1);
            this.separator6.Name = "separator6";
            this.separator6.Padding.Bottom = 2;
            this.separator6.Padding.Left = 6;
            this.separator6.Padding.Right = 6;
            this.separator6.Padding.Top = 2;
            this.separator6.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem7
            // 
            this.sideNavItem7.Name = "sideNavItem7";
            this.sideNavItem7.Panel = this.sideNavPanel6;
            this.sideNavItem7.Symbol = "";
            this.sideNavItem7.Text = "Personal del PJ";
            this.sideNavItem7.Click += new System.EventHandler(this.sideNavItem7_Click);
            // 
            // rbNuevaPerfil
            // 
            this.rbNuevaPerfil.Name = "rbNuevaPerfil";
            this.rbNuevaPerfil.Panel = this.sideNavPanel5;
            this.rbNuevaPerfil.Symbol = "";
            this.rbNuevaPerfil.Text = "Perfil de Personal del PJ";
            this.rbNuevaPerfil.CheckedChanged += new System.EventHandler(this.rbNuevaPerfil_CheckedChanged);
            // 
            // separator2
            // 
            this.separator2.FixedSize = new System.Drawing.Size(3, 1);
            this.separator2.Name = "separator2";
            this.separator2.Padding.Bottom = 2;
            this.separator2.Padding.Left = 6;
            this.separator2.Padding.Right = 6;
            this.separator2.Padding.Top = 2;
            this.separator2.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem9
            // 
            this.sideNavItem9.Name = "sideNavItem9";
            this.sideNavItem9.Panel = this.sideNavPanel8;
            this.sideNavItem9.Symbol = "";
            this.sideNavItem9.Text = "Instancia";
            this.sideNavItem9.CheckedChanged += new System.EventHandler(this.sideNavItem9_CheckedChanged);
            // 
            // sideNavItem8
            // 
            this.sideNavItem8.Name = "sideNavItem8";
            this.sideNavItem8.Panel = this.sideNavPanel7;
            this.sideNavItem8.Symbol = "";
            this.sideNavItem8.Text = "Sede";
            this.sideNavItem8.CheckedChanged += new System.EventHandler(this.sideNavItem8_CheckedChanged);
            // 
            // separator3
            // 
            this.separator3.FixedSize = new System.Drawing.Size(3, 1);
            this.separator3.Name = "separator3";
            this.separator3.Padding.Bottom = 2;
            this.separator3.Padding.Left = 6;
            this.separator3.Padding.Right = 6;
            this.separator3.Padding.Top = 2;
            this.separator3.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem2
            // 
            this.sideNavItem2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sideNavItem2.Name = "sideNavItem2";
            this.sideNavItem2.Panel = this.sideNavPanel1;
            this.sideNavItem2.Symbol = "57556";
            this.sideNavItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem2.Text = "Software";
            this.sideNavItem2.CheckedChanged += new System.EventHandler(this.sideNavItem2_CheckedChanged);
            this.sideNavItem2.Click += new System.EventHandler(this.sideNavItem2_Click);
            // 
            // sideNavItem5
            // 
            this.sideNavItem5.Name = "sideNavItem5";
            this.sideNavItem5.Panel = this.sideNavPanel4;
            this.sideNavItem5.Symbol = "57566";
            this.sideNavItem5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem5.Text = "Asignación de Software";
            this.sideNavItem5.Visible = false;
            this.sideNavItem5.Click += new System.EventHandler(this.sideNavItem5_Click);
            // 
            // separator4
            // 
            this.separator4.FixedSize = new System.Drawing.Size(3, 1);
            this.separator4.Name = "separator4";
            this.separator4.Padding.Bottom = 2;
            this.separator4.Padding.Left = 6;
            this.separator4.Padding.Right = 6;
            this.separator4.Padding.Top = 2;
            this.separator4.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem3
            // 
            this.sideNavItem3.Name = "sideNavItem3";
            this.sideNavItem3.Panel = this.sideNavPanel3;
            this.sideNavItem3.Symbol = "58150";
            this.sideNavItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem3.Text = "Asignación de Equipo y Software";
            this.sideNavItem3.CheckedChanged += new System.EventHandler(this.sideNavItem3_CheckedChanged);
            this.sideNavItem3.Click += new System.EventHandler(this.sideNavItem3_Click);
            // 
            // sideNavItem4
            // 
            this.sideNavItem4.Name = "sideNavItem4";
            this.sideNavItem4.Panel = this.sideNavPanel2;
            this.sideNavItem4.Symbol = "58123";
            this.sideNavItem4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem4.Text = "Categoria y Equipos";
            this.sideNavItem4.CheckedChanged += new System.EventHandler(this.sideNavItem4_CheckedChanged);
            // 
            // separator5
            // 
            this.separator5.FixedSize = new System.Drawing.Size(3, 1);
            this.separator5.Name = "separator5";
            this.separator5.Padding.Bottom = 2;
            this.separator5.Padding.Left = 6;
            this.separator5.Padding.Right = 6;
            this.separator5.Padding.Top = 2;
            this.separator5.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem10
            // 
            this.sideNavItem10.Name = "sideNavItem10";
            this.sideNavItem10.Panel = this.sideNavPanel9;
            this.sideNavItem10.Symbol = "";
            this.sideNavItem10.Text = "Reportes";
            // 
            // separator8
            // 
            this.separator8.FixedSize = new System.Drawing.Size(3, 1);
            this.separator8.Name = "separator8";
            this.separator8.Padding.Bottom = 2;
            this.separator8.Padding.Left = 6;
            this.separator8.Padding.Right = 6;
            this.separator8.Padding.Top = 2;
            this.separator8.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem11
            // 
            this.sideNavItem11.Name = "sideNavItem11";
            this.sideNavItem11.Panel = this.sideNavPanel13;
            this.sideNavItem11.Symbol = "";
            this.sideNavItem11.Text = "Cerrar Sesión";
            this.sideNavItem11.Click += new System.EventHandler(this.sideNavItem11_Click);
            // 
            // separator9
            // 
            this.separator9.FixedSize = new System.Drawing.Size(3, 1);
            this.separator9.Name = "separator9";
            this.separator9.Padding.Bottom = 2;
            this.separator9.Padding.Left = 6;
            this.separator9.Padding.Right = 6;
            this.separator9.Padding.Top = 2;
            this.separator9.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // buttonX11
            // 
            this.buttonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX11.Location = new System.Drawing.Point(320, 93);
            this.buttonX11.Name = "buttonX11";
            this.buttonX11.Size = new System.Drawing.Size(158, 154);
            this.buttonX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX11.TabIndex = 53;
            this.buttonX11.Click += new System.EventHandler(this.buttonX11_Click);
            // 
            // buttonX10
            // 
            this.buttonX10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX10.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX10.Location = new System.Drawing.Point(577, 91);
            this.buttonX10.Name = "buttonX10";
            this.buttonX10.Size = new System.Drawing.Size(158, 154);
            this.buttonX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX10.TabIndex = 54;
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX9.Location = new System.Drawing.Point(323, 295);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Size = new System.Drawing.Size(158, 154);
            this.buttonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX9.TabIndex = 55;
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX8.Location = new System.Drawing.Point(577, 295);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Size = new System.Drawing.Size(158, 154);
            this.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX8.TabIndex = 56;
            // 
            // buttonX7
            // 
            this.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX7.Location = new System.Drawing.Point(459, 492);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(158, 154);
            this.buttonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX7.TabIndex = 57;
            // 
            // comboItem50
            // 
            this.comboItem50.Text = "N";
            // 
            // comboItem49
            // 
            this.comboItem49.Text = "S";
            // 
            // comboItem22
            // 
            this.comboItem22.Text = "Regular";
            // 
            // comboItem21
            // 
            this.comboItem21.Text = "Malo";
            // 
            // comboItem15
            // 
            this.comboItem15.Text = "Bueno";
            // 
            // cbAnioCompraComp
            // 
            this.cbAnioCompraComp.AttachedControl = this.superTabControlPanel13;
            this.cbAnioCompraComp.GlobalItem = false;
            this.cbAnioCompraComp.Name = "cbAnioCompraComp";
            this.cbAnioCompraComp.Text = "Componentes CPU";
            // 
            // superTabControlPanel13
            // 
            this.superTabControlPanel13.Controls.Add(this.buttonX6);
            this.superTabControlPanel13.Controls.Add(this.radioButton1);
            this.superTabControlPanel13.Controls.Add(this.radioButton2);
            this.superTabControlPanel13.Controls.Add(this.tbFuncionamientoComp);
            this.superTabControlPanel13.Controls.Add(this.label110);
            this.superTabControlPanel13.Controls.Add(this.label111);
            this.superTabControlPanel13.Controls.Add(this.textBoxX7);
            this.superTabControlPanel13.Controls.Add(this.label112);
            this.superTabControlPanel13.Controls.Add(this.cbEstadoEquipoComp);
            this.superTabControlPanel13.Controls.Add(this.label113);
            this.superTabControlPanel13.Controls.Add(this.cbAnioCompraCom);
            this.superTabControlPanel13.Controls.Add(this.comboBoxEx3);
            this.superTabControlPanel13.Controls.Add(this.label114);
            this.superTabControlPanel13.Controls.Add(this.label115);
            this.superTabControlPanel13.Controls.Add(this.label116);
            this.superTabControlPanel13.Controls.Add(this.comboBoxEx4);
            this.superTabControlPanel13.Controls.Add(this.label117);
            this.superTabControlPanel13.Controls.Add(this.cbCatEqComp);
            this.superTabControlPanel13.Controls.Add(this.label118);
            this.superTabControlPanel13.Controls.Add(this.label119);
            this.superTabControlPanel13.Controls.Add(this.label120);
            this.superTabControlPanel13.Controls.Add(this.label121);
            this.superTabControlPanel13.Controls.Add(this.label122);
            this.superTabControlPanel13.Controls.Add(this.tbObseracionComp);
            this.superTabControlPanel13.Controls.Add(this.label123);
            this.superTabControlPanel13.Controls.Add(this.tbIpComp);
            this.superTabControlPanel13.Controls.Add(this.label124);
            this.superTabControlPanel13.Controls.Add(this.tbProcesadorComp);
            this.superTabControlPanel13.Controls.Add(this.tbModeloComp);
            this.superTabControlPanel13.Controls.Add(this.tbNroOrdenCompraComp);
            this.superTabControlPanel13.Controls.Add(this.tbNombreEquipoComp);
            this.superTabControlPanel13.Controls.Add(this.label125);
            this.superTabControlPanel13.Controls.Add(this.tbMarcaComp);
            this.superTabControlPanel13.Controls.Add(this.tbNroSerieComp);
            this.superTabControlPanel13.Controls.Add(this.tbNroControlPatrimonialComp);
            this.superTabControlPanel13.Controls.Add(this.labelX6);
            this.superTabControlPanel13.Controls.Add(this.tbAsignacionEqComp);
            this.superTabControlPanel13.Controls.Add(this.dataGridView1);
            this.superTabControlPanel13.Controls.Add(this.buttonX14);
            this.superTabControlPanel13.Controls.Add(this.buttonX15);
            this.superTabControlPanel13.Controls.Add(this.buttonX16);
            this.superTabControlPanel13.Controls.Add(this.buttonX17);
            this.superTabControlPanel13.Controls.Add(this.buttonX18);
            this.superTabControlPanel13.Controls.Add(this.buttonX19);
            this.superTabControlPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel13.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel13.Name = "superTabControlPanel13";
            this.superTabControlPanel13.Size = new System.Drawing.Size(974, 25);
            this.superTabControlPanel13.TabIndex = 0;
            this.superTabControlPanel13.TabItem = this.cbAnioCompraComp;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(905, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 238;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Editar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(905, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 237;
            this.radioButton2.Text = "Nuevo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tbFuncionamientoComp
            // 
            // 
            // 
            // 
            this.tbFuncionamientoComp.Border.Class = "TextBoxBorder";
            this.tbFuncionamientoComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFuncionamientoComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFuncionamientoComp.Enabled = false;
            this.tbFuncionamientoComp.Location = new System.Drawing.Point(435, 66);
            this.tbFuncionamientoComp.Name = "tbFuncionamientoComp";
            this.tbFuncionamientoComp.PreventEnterBeep = true;
            this.tbFuncionamientoComp.Size = new System.Drawing.Size(303, 20);
            this.tbFuncionamientoComp.TabIndex = 249;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(435, 51);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(82, 13);
            this.label110.TabIndex = 262;
            this.label110.Text = "Funcionamiento";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(759, 136);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(65, 13);
            this.label111.TabIndex = 258;
            this.label111.Text = "Service Tag";
            this.label111.Visible = false;
            // 
            // textBoxX7
            // 
            // 
            // 
            // 
            this.textBoxX7.Border.Class = "TextBoxBorder";
            this.textBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX7.Enabled = false;
            this.textBoxX7.Location = new System.Drawing.Point(759, 151);
            this.textBoxX7.Name = "textBoxX7";
            this.textBoxX7.PreventEnterBeep = true;
            this.textBoxX7.Size = new System.Drawing.Size(132, 20);
            this.textBoxX7.TabIndex = 256;
            this.textBoxX7.Visible = false;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(759, 11);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(93, 13);
            this.label112.TabIndex = 257;
            this.label112.Text = "Cod Padre Equipo";
            // 
            // cbEstadoEquipoComp
            // 
            this.cbEstadoEquipoComp.DisplayMember = "Text";
            this.cbEstadoEquipoComp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstadoEquipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEquipoComp.Enabled = false;
            this.cbEstadoEquipoComp.FormattingEnabled = true;
            this.cbEstadoEquipoComp.ItemHeight = 15;
            this.cbEstadoEquipoComp.Items.AddRange(new object[] {
            this.comboItem9,
            this.comboItem34,
            this.comboItem35});
            this.cbEstadoEquipoComp.Location = new System.Drawing.Point(222, 65);
            this.cbEstadoEquipoComp.Name = "cbEstadoEquipoComp";
            this.cbEstadoEquipoComp.Size = new System.Drawing.Size(179, 21);
            this.cbEstadoEquipoComp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstadoEquipoComp.TabIndex = 245;
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "BUENO";
            // 
            // comboItem34
            // 
            this.comboItem34.Text = "MALO";
            // 
            // comboItem35
            // 
            this.comboItem35.Text = "REGULAR";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(222, 51);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(40, 13);
            this.label113.TabIndex = 255;
            this.label113.Text = "Estado";
            // 
            // cbAnioCompraCom
            // 
            this.cbAnioCompraCom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAnioCompraCom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnioCompraCom.DisplayMember = "Text";
            this.cbAnioCompraCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAnioCompraCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnioCompraCom.Enabled = false;
            this.cbAnioCompraCom.FormattingEnabled = true;
            this.cbAnioCompraCom.ItemHeight = 15;
            this.cbAnioCompraCom.Location = new System.Drawing.Point(222, 148);
            this.cbAnioCompraCom.Name = "cbAnioCompraCom";
            this.cbAnioCompraCom.Size = new System.Drawing.Size(129, 21);
            this.cbAnioCompraCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAnioCompraCom.TabIndex = 247;
            // 
            // comboBoxEx3
            // 
            this.comboBoxEx3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEx3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEx3.DisplayMember = "Text";
            this.comboBoxEx3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx3.Enabled = false;
            this.comboBoxEx3.FormattingEnabled = true;
            this.comboBoxEx3.ItemHeight = 15;
            this.comboBoxEx3.Location = new System.Drawing.Point(759, 24);
            this.comboBoxEx3.Name = "comboBoxEx3";
            this.comboBoxEx3.Size = new System.Drawing.Size(125, 21);
            this.comboBoxEx3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx3.TabIndex = 251;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(435, 12);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(68, 13);
            this.label114.TabIndex = 228;
            this.label114.Text = "IP de Equipo";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(13, 12);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(37, 13);
            this.label115.TabIndex = 227;
            this.label115.Text = "Marca";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(436, 133);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(97, 13);
            this.label116.TabIndex = 226;
            this.label116.Text = "Nombre del Equipo";
            // 
            // comboBoxEx4
            // 
            this.comboBoxEx4.DisplayMember = "Text";
            this.comboBoxEx4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx4.Enabled = false;
            this.comboBoxEx4.FormattingEnabled = true;
            this.comboBoxEx4.ItemHeight = 15;
            this.comboBoxEx4.Items.AddRange(new object[] {
            this.comboItem36,
            this.comboItem37});
            this.comboBoxEx4.Location = new System.Drawing.Point(759, 63);
            this.comboBoxEx4.Name = "comboBoxEx4";
            this.comboBoxEx4.Size = new System.Drawing.Size(131, 21);
            this.comboBoxEx4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx4.TabIndex = 253;
            this.comboBoxEx4.Visible = false;
            // 
            // comboItem36
            // 
            this.comboItem36.Text = "S";
            // 
            // comboItem37
            // 
            this.comboItem37.Text = "N";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(759, 47);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(51, 13);
            this.label117.TabIndex = 230;
            this.label117.Text = "Asignado";
            this.label117.Visible = false;
            // 
            // cbCatEqComp
            // 
            this.cbCatEqComp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCatEqComp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCatEqComp.DisplayMember = "Text";
            this.cbCatEqComp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCatEqComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatEqComp.Enabled = false;
            this.cbCatEqComp.FormattingEnabled = true;
            this.cbCatEqComp.ItemHeight = 15;
            this.cbCatEqComp.Location = new System.Drawing.Point(579, 26);
            this.cbCatEqComp.Name = "cbCatEqComp";
            this.cbCatEqComp.Size = new System.Drawing.Size(132, 21);
            this.cbCatEqComp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCatEqComp.TabIndex = 239;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(13, 93);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(42, 13);
            this.label118.TabIndex = 229;
            this.label118.Text = "Modelo";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(13, 51);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(84, 13);
            this.label119.TabIndex = 233;
            this.label119.Text = "Número de serie";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(222, 12);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(79, 13);
            this.label120.TabIndex = 232;
            this.label120.Text = "Cod patrimonial";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(13, 131);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(61, 13);
            this.label121.TabIndex = 231;
            this.label121.Text = "Procesador";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(222, 131);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(97, 13);
            this.label122.TabIndex = 235;
            this.label122.Text = "Año de adquisición";
            // 
            // tbObseracionComp
            // 
            // 
            // 
            // 
            this.tbObseracionComp.Border.Class = "TextBoxBorder";
            this.tbObseracionComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbObseracionComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObseracionComp.Enabled = false;
            this.tbObseracionComp.Location = new System.Drawing.Point(435, 107);
            this.tbObseracionComp.Name = "tbObseracionComp";
            this.tbObseracionComp.PreventEnterBeep = true;
            this.tbObseracionComp.Size = new System.Drawing.Size(303, 20);
            this.tbObseracionComp.TabIndex = 250;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(222, 93);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(142, 13);
            this.label123.TabIndex = 234;
            this.label123.Text = "Numero de orden de compra";
            // 
            // tbIpComp
            // 
            // 
            // 
            // 
            this.tbIpComp.Border.Class = "TextBoxBorder";
            this.tbIpComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbIpComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIpComp.Enabled = false;
            this.tbIpComp.Location = new System.Drawing.Point(435, 27);
            this.tbIpComp.Name = "tbIpComp";
            this.tbIpComp.PreventEnterBeep = true;
            this.tbIpComp.Size = new System.Drawing.Size(121, 20);
            this.tbIpComp.TabIndex = 248;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(435, 93);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(67, 13);
            this.label124.TabIndex = 236;
            this.label124.Text = "Observación";
            // 
            // tbProcesadorComp
            // 
            // 
            // 
            // 
            this.tbProcesadorComp.Border.Class = "TextBoxBorder";
            this.tbProcesadorComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProcesadorComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProcesadorComp.Enabled = false;
            this.tbProcesadorComp.Location = new System.Drawing.Point(13, 149);
            this.tbProcesadorComp.Name = "tbProcesadorComp";
            this.tbProcesadorComp.PreventEnterBeep = true;
            this.tbProcesadorComp.Size = new System.Drawing.Size(175, 20);
            this.tbProcesadorComp.TabIndex = 243;
            // 
            // tbModeloComp
            // 
            // 
            // 
            // 
            this.tbModeloComp.Border.Class = "TextBoxBorder";
            this.tbModeloComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbModeloComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbModeloComp.Enabled = false;
            this.tbModeloComp.Location = new System.Drawing.Point(13, 107);
            this.tbModeloComp.Name = "tbModeloComp";
            this.tbModeloComp.PreventEnterBeep = true;
            this.tbModeloComp.Size = new System.Drawing.Size(184, 20);
            this.tbModeloComp.TabIndex = 242;
            // 
            // tbNroOrdenCompraComp
            // 
            // 
            // 
            // 
            this.tbNroOrdenCompraComp.Border.Class = "TextBoxBorder";
            this.tbNroOrdenCompraComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroOrdenCompraComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroOrdenCompraComp.Enabled = false;
            this.tbNroOrdenCompraComp.Location = new System.Drawing.Point(222, 107);
            this.tbNroOrdenCompraComp.Name = "tbNroOrdenCompraComp";
            this.tbNroOrdenCompraComp.PreventEnterBeep = true;
            this.tbNroOrdenCompraComp.Size = new System.Drawing.Size(179, 20);
            this.tbNroOrdenCompraComp.TabIndex = 246;
            // 
            // tbNombreEquipoComp
            // 
            // 
            // 
            // 
            this.tbNombreEquipoComp.Border.Class = "TextBoxBorder";
            this.tbNombreEquipoComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNombreEquipoComp.Enabled = false;
            this.tbNombreEquipoComp.Location = new System.Drawing.Point(436, 148);
            this.tbNombreEquipoComp.Name = "tbNombreEquipoComp";
            this.tbNombreEquipoComp.PreventEnterBeep = true;
            this.tbNombreEquipoComp.Size = new System.Drawing.Size(129, 20);
            this.tbNombreEquipoComp.TabIndex = 254;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(579, 13);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(52, 13);
            this.label125.TabIndex = 252;
            this.label125.Text = "Categoria";
            // 
            // tbMarcaComp
            // 
            // 
            // 
            // 
            this.tbMarcaComp.Border.Class = "TextBoxBorder";
            this.tbMarcaComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMarcaComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMarcaComp.Enabled = false;
            this.tbMarcaComp.Location = new System.Drawing.Point(13, 27);
            this.tbMarcaComp.Name = "tbMarcaComp";
            this.tbMarcaComp.PreventEnterBeep = true;
            this.tbMarcaComp.Size = new System.Drawing.Size(184, 20);
            this.tbMarcaComp.TabIndex = 240;
            // 
            // tbNroSerieComp
            // 
            // 
            // 
            // 
            this.tbNroSerieComp.Border.Class = "TextBoxBorder";
            this.tbNroSerieComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroSerieComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroSerieComp.Enabled = false;
            this.tbNroSerieComp.Location = new System.Drawing.Point(13, 66);
            this.tbNroSerieComp.Name = "tbNroSerieComp";
            this.tbNroSerieComp.PreventEnterBeep = true;
            this.tbNroSerieComp.Size = new System.Drawing.Size(184, 20);
            this.tbNroSerieComp.TabIndex = 241;
            // 
            // tbNroControlPatrimonialComp
            // 
            // 
            // 
            // 
            this.tbNroControlPatrimonialComp.Border.Class = "TextBoxBorder";
            this.tbNroControlPatrimonialComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNroControlPatrimonialComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroControlPatrimonialComp.Enabled = false;
            this.tbNroControlPatrimonialComp.Location = new System.Drawing.Point(222, 27);
            this.tbNroControlPatrimonialComp.Name = "tbNroControlPatrimonialComp";
            this.tbNroControlPatrimonialComp.PreventEnterBeep = true;
            this.tbNroControlPatrimonialComp.Size = new System.Drawing.Size(179, 20);
            this.tbNroControlPatrimonialComp.TabIndex = 244;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(19, 198);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 224;
            this.labelX6.Text = "Buscar";
            // 
            // tbAsignacionEqComp
            // 
            // 
            // 
            // 
            this.tbAsignacionEqComp.Border.Class = "TextBoxBorder";
            this.tbAsignacionEqComp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAsignacionEqComp.Location = new System.Drawing.Point(78, 199);
            this.tbAsignacionEqComp.Name = "tbAsignacionEqComp";
            this.tbAsignacionEqComp.PreventEnterBeep = true;
            this.tbAsignacionEqComp.Size = new System.Drawing.Size(394, 20);
            this.tbAsignacionEqComp.TabIndex = 225;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46});
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(887, 234);
            this.dataGridView1.TabIndex = 223;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn25.HeaderText = "CodRegistro";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "cod_personal";
            this.dataGridViewTextBoxColumn26.HeaderText = "cod_personal";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "cod_equipo";
            this.dataGridViewTextBoxColumn27.HeaderText = "cod_equipo";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Visible = false;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn28.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Visible = false;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "nombre_per";
            this.dataGridViewTextBoxColumn29.HeaderText = "Usuario / Apellidos y nombres";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "cod_sede";
            this.dataGridViewTextBoxColumn30.HeaderText = "cod_sede";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "nombre_sede";
            this.dataGridViewTextBoxColumn31.HeaderText = "Sede";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Visible = false;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "cod_instancia";
            this.dataGridViewTextBoxColumn32.HeaderText = "cod_instancia";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "nombre_instancia";
            this.dataGridViewTextBoxColumn33.HeaderText = "nombre_instancia";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "nro_serie";
            this.dataGridViewTextBoxColumn34.HeaderText = "SerieEquipo";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "nro_control_patrimonial";
            this.dataGridViewTextBoxColumn35.HeaderText = "CodPatrimonial";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "nombre_equipo";
            this.dataGridViewTextBoxColumn36.HeaderText = "Equipo";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Visible = false;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "fecha_registro";
            this.dataGridViewTextBoxColumn37.HeaderText = "FechaRegistro";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Visible = false;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "fecha_sistema";
            this.dataGridViewTextBoxColumn38.HeaderText = "FechaSistema";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Visible = false;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "observacion";
            this.dataGridViewTextBoxColumn39.HeaderText = "Observacion";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Visible = false;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn40.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "serie";
            this.dataGridViewTextBoxColumn41.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "procesador";
            this.dataGridViewTextBoxColumn42.HeaderText = "Procesador";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "cod_patrimonial";
            this.dataGridViewTextBoxColumn43.HeaderText = "Cod patrimonial";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn44.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "aniocompra";
            this.dataGridViewTextBoxColumn45.HeaderText = "Año compra";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "ip";
            this.dataGridViewTextBoxColumn46.HeaderText = "IP";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Column";
            this.columnHeader1.Width.Absolute = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Column";
            this.columnHeader2.Width.Absolute = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Column";
            this.columnHeader3.Width.Absolute = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1220, 749);
            this.Controls.Add(this.sideNav1);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemaParqueo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComponentesPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInstancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsignacionSoft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCaducidadAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInstalacionAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngAE)).EndInit();
            this.sideNav1.ResumeLayout(false);
            this.sideNav1.PerformLayout();
            this.sideNavPanel11.ResumeLayout(false);
            this.panelEx10.ResumeLayout(false);
            this.sideNavPanel3.ResumeLayout(false);
            this.panelEx8.ResumeLayout(false);
            this.panelEx8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl3)).EndInit();
            this.superTabControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).EndInit();
            this.superTabControl2.ResumeLayout(false);
            this.superTabControlPanel15.ResumeLayout(false);
            this.superTabControlPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAsignacionAESCCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistroCCom)).EndInit();
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAsignacionAES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistro)).EndInit();
            this.superTabControlPanel8.ResumeLayout(false);
            this.superTabControlPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInstalacionSoftAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCaducidadSoftAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSoftware_SodtAE)).EndInit();
            this.sideNavPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.superTabControlPanel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.sideNavPanel9.ResumeLayout(false);
            this.sideNavPanel6.ResumeLayout(false);
            this.panelEx6.ResumeLayout(false);
            this.panelEx6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaTerminoLaboral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngresoLaboral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacPersonal)).EndInit();
            this.sideNavPanel5.ResumeLayout(false);
            this.panelEx5.ResumeLayout(false);
            this.panelEx5.PerformLayout();
            this.sideNavPanel1.ResumeLayout(false);
            this.panelEx9.ResumeLayout(false);
            this.panelEx9.PerformLayout();
            this.sideNavPanel4.ResumeLayout(false);
            this.panelEx7.ResumeLayout(false);
            this.panelEx7.PerformLayout();
            this.sideNavPanel12.ResumeLayout(false);
            this.sideNavPanel10.ResumeLayout(false);
            this.sideNavPanel7.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            this.sideNavPanel8.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.panelEx4.PerformLayout();
            this.superTabControlPanel13.ResumeLayout(false);
            this.superTabControlPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.DataGridView DGVCategoria;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuscarCategoria;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuscarSede;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbInstancia;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.DataGridView DGVInstancia;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObservSede;
        private System.Windows.Forms.Label label28;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbActivoSede;
        private DevComponents.Editors.ComboItem comboItem13;
        private DevComponents.Editors.ComboItem comboItem14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private DevComponents.DotNetBar.ButtonX btListarSede;
        private DevComponents.DotNetBar.ButtonX btEliminarSede;
        private DevComponents.DotNetBar.ButtonX btActualizarSede;
        private DevComponents.DotNetBar.ButtonX btLimpiarSede;
        private DevComponents.DotNetBar.ButtonX btRegistrarSede;
        private System.Windows.Forms.Label label24;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbActivoInst;
        private DevComponents.Editors.ComboItem comboItem19;
        private DevComponents.Editors.ComboItem comboItem20;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNombreInst;
        private System.Windows.Forms.Label label31;
        private DevComponents.DotNetBar.ButtonX btListarInst;
        private DevComponents.DotNetBar.ButtonX btEliminarIns;
        private DevComponents.DotNetBar.ButtonX btActualizarInst;
        private DevComponents.DotNetBar.ButtonX btLimpiarInst;
        private DevComponents.DotNetBar.ButtonX btRegistrarIns;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView DGVSede;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPerfil;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstadoPersonal;
        private DevComponents.Editors.ComboItem comboItem25;
        private DevComponents.Editors.ComboItem comboItem26;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDniPersonal;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label34;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMaternoPersonal;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNombrePersonal;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObservPerfil;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNombrePerfil;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private DevComponents.DotNetBar.ButtonX btListarPerfil;
        private DevComponents.DotNetBar.ButtonX btEliminarPErfil;
        private DevComponents.DotNetBar.ButtonX btActualizarPerfil;
        private DevComponents.DotNetBar.ButtonX btLimpiarPerfil;
        private DevComponents.DotNetBar.ButtonX btRegistrarPerfil;
        private System.Windows.Forms.Label label47;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPersonal;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAsignacionSoft;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObservacionAS;
        private System.Windows.Forms.Label label50;
        private DevComponents.DotNetBar.ButtonX btListarAS;
        private DevComponents.DotNetBar.ButtonX btEliminarAS;
        private DevComponents.DotNetBar.ButtonX btActualizarAS;
        private DevComponents.DotNetBar.ButtonX btLimpiarAS;
        private DevComponents.DotNetBar.ButtonX btRegistrarAS;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCodEquipoAS;
        private System.Windows.Forms.Label label57;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaCaducidadAS;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInstalacionAS;
        private System.Windows.Forms.Label label66;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuscarSoft;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridView DGVSoftware;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_software;
        private System.Windows.Forms.DataGridViewTextBoxColumn software;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_orden_compra_sof;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_aquisicion_sof;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoSoft;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObservacionSoft;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroOCSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCantUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private DevComponents.DotNetBar.ButtonX btListarSoft;
        private DevComponents.DotNetBar.ButtonX btnEliminarSoft;
        private DevComponents.DotNetBar.ButtonX btnActualizarSoft;
        private DevComponents.DotNetBar.ButtonX btnLimpiarSoft;
        private DevComponents.DotNetBar.ButtonX btnRegistrarSoft;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbActivoSoft;
        private DevComponents.Editors.ComboItem comboItem16;
        private DevComponents.Editors.ComboItem comboItem17;
        private DevComponents.DotNetBar.Controls.TextBoxX tbVersionSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSoftware;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label67;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCodPersonalAE;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.DataGridView DGVComponentesPc;
        private DevComponents.DotNetBar.ButtonX btListarEquipo;
        private DevComponents.DotNetBar.ButtonX btEliminarEquipo;
        private DevComponents.DotNetBar.ButtonX btActualizarEquipo;
        private DevComponents.DotNetBar.ButtonX btLimpiarEquipo;
        private DevComponents.DotNetBar.ButtonX btRegistrarEquipo;
        private System.Windows.Forms.Label label15;
        private DevComponents.DotNetBar.ButtonX btEliminarCat;
        private DevComponents.DotNetBar.ButtonX btActualizarCat;
        private DevComponents.DotNetBar.ButtonX btLimpiarCat;
        private DevComponents.DotNetBar.ButtonX btREgistrarCat;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbActivoCat;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDescripcionCat;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNomCategoria;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private DevComponents.Editors.ComboItem comboItem12;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.DotNetBar.ButtonX btListarCategoria;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroInst;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDireccSede;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNombreSede;
        private DataGridView DGVPerfil;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbActivoPerfil;
        private DevComponents.Editors.ComboItem comboItem52;
        private DevComponents.Editors.ComboItem comboItem53;
        private Label label32;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaIngAE;
        private DataGridView DGVAsignacionSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuscarEquipo;
        private ToolTip toolTipListar;
        private ToolTip toolTipEliminar;
        private ToolTip toolTipActualizar;
        private ToolTip toolTipLimpiar;
        private ToolTip toolTipRegistrar;
        private ToolTip toolTipAS;
        private ToolTip toolTipAE;
        private ToolTip toolTipPersonal;
        private ToolTip toolTioEquipo;
        private ToolTip toolTipSoft;
        private DataGridViewTextBoxColumn Column39;
        private DataGridViewTextBoxColumn Column32;
        private DataGridViewTextBoxColumn Column33;
        private DataGridViewTextBoxColumn Column34;
        private DataGridViewTextBoxColumn Column35;
        private DataGridViewTextBoxColumn Column36;
        private DataGridViewTextBoxColumn Column37;
        private DataGridViewTextBoxColumn Column38;
        private DevComponents.DotNetBar.ButtonX btImpSoft;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbProvincia_Sede;
        private Label label62;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbDistritoJud_sede;
        private Label label60;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaternoPersonal;
        private Label label63;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbPerfilPersonal;
        private ToolTip toolTipReporte;
        private DevComponents.DotNetBar.ButtonX btReporteSoft;
        private DevComponents.DotNetBar.ButtonX btImpEquipo;
        private DevComponents.DotNetBar.ButtonX btImpCat;
        private DevComponents.DotNetBar.ButtonX btImpSede;
        private DevComponents.DotNetBar.ButtonX btImpInstancia;
        private DevComponents.DotNetBar.ButtonX btImpPerfil;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAnioAquisSoft;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column48;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSedePersonal;
        private Label label69;
        private Label label71;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbInstanciaPersonal;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSede_Instanc;
        private Label label68;
        private Label label30;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDirInstancia;
        private Label label14;
        private DevComponents.DotNetBar.Controls.TextBoxX tbInstancAE;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSedeAE;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDniAE;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNombreAE;
        private Label label74;
        private Label label73;
        private Label label58;
        private Label label80;
        private Label label81;
        private Label label88;
        private Label label89;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX8;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX9;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private Label label59;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private Label label82;
        private Label label83;
        private Label label84;
        private Label label85;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCodSoftAS;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.Controls.SideNav sideNav1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx9;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel2;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.SuperTabItem Categorias;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel9;
        private DevComponents.DotNetBar.ButtonX buttonX12;
        private DevComponents.DotNetBar.ButtonX buttonX13;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel8;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.Controls.Line line9;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel7;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.Controls.Line line8;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel6;
        private DevComponents.DotNetBar.PanelEx panelEx6;
        private DevComponents.DotNetBar.Controls.Line line7;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel5;
        private DevComponents.DotNetBar.PanelEx panelEx5;
        private DevComponents.DotNetBar.Controls.Line line6;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel4;
        private DevComponents.DotNetBar.PanelEx panelEx7;
        private DevComponents.DotNetBar.Controls.Line line5;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel3;
        private DevComponents.DotNetBar.PanelEx panelEx8;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem1;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Separator separator6;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem4;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem3;
        private DevComponents.DotNetBar.Separator separator2;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem2;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem5;
        private DevComponents.DotNetBar.Separator separator3;
        private DevComponents.DotNetBar.Controls.SideNavItem rbNuevaPerfil;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem7;
        private DevComponents.DotNetBar.Separator separator4;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem8;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem9;
        private DevComponents.DotNetBar.Separator separator5;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem10;
        private Label label1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel11;
        private DevComponents.DotNetBar.PanelEx panelEx10;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem6Inicio;
        private DevComponents.DotNetBar.ButtonX buttonX11;
        private DevComponents.DotNetBar.ButtonX buttonX10;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.ButtonX buttonX8;
        private DevComponents.DotNetBar.ButtonX buttonX7;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPerfilAE;
        private Label label90;
        private Label label91;
        private DevComponents.DotNetBar.Controls.Line line11;
        private DevComponents.DotNetBar.Controls.Line line10;
        private DevComponents.DotNetBar.ButtonX btSalirPersonal_;
        private DevComponents.DotNetBar.ButtonX btEliminarPersonal_;
        private DevComponents.DotNetBar.ButtonX btEditarPersonal_;
        private DevComponents.DotNetBar.ButtonX btGrabarPersonal_;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaTerminoLaboral;
        private Label label65;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaIngresoLaboral;
        private Label label39;
        private Label label93;
        private DevComponents.DotNetBar.Controls.TextBoxX tbEscalafon;
        private Label label92;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaNacPersonal;
        private DevComponents.DotNetBar.ButtonX btLimpiarPersonal_;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbFTerminoLaboral;
        private DevComponents.DotNetBar.SuperTabControl superTabControl2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAsignacionEq;
        private DevComponents.DotNetBar.ButtonX btReportEquipo;
        private DevComponents.DotNetBar.ButtonX btListaAE;
        private DevComponents.DotNetBar.ButtonX btRegistrarAE;
        private DevComponents.DotNetBar.ButtonX tbEliminarAE;
        private DevComponents.DotNetBar.ButtonX tbActualizarAE;
        private DevComponents.DotNetBar.ButtonX tbLimpiarAE;
        private DevComponents.DotNetBar.SuperTabItem stFormEquipo;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel8;
        private DevComponents.DotNetBar.SuperTabItem stSoftware;
        private DevComponents.Editors.ComboItem comboItem50;
        private DevComponents.Editors.ComboItem comboItem49;
        private DevComponents.Editors.ComboItem comboItem22;
        private DevComponents.Editors.ComboItem comboItem21;
        private DevComponents.Editors.ComboItem comboItem15;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFuncionamiento;
        private Label label29;
        private Label label87;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServiceTag;
        private Label label86;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstadoEquipo;
        private Label label49;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAnioCompra;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEquipoPadreCod;
        private Label label3;
        private Label label2;
        private Label label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAsignado;
        private Label label7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCatEq;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObseracion;
        private Label label11;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIp;
        private Label label13;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProcesador;
        private DevComponents.DotNetBar.Controls.TextBoxX tbModelo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroOrdenCompra;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNombreEquipo;
        private Label label17;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMarca;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroSerie;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroControlPatrimonial;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCodEquipoAE;
        private DevComponents.Editors.ComboItem comboItem18;
        private DevComponents.Editors.ComboItem comboItem23;
        private DevComponents.Editors.ComboItem comboItem24;
        private DevComponents.Editors.ComboItem comboItem27;
        private DevComponents.Editors.ComboItem comboItem28;
        private Label label52;
        private DevComponents.DotNetBar.Controls.TextBoxX tbArea;
        private Label label51;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUnOrganica;
        private RadioButton rbPerJur;
        private RadioButton rbPerAdmi;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel9;
        private RadioButton rbEditarSede;
        private RadioButton rbNuevaSede;
        private RadioButton rbEditarInst;
        private RadioButton rbNuevaInst;
        private RadioButton rbEditarPerfil;
        private RadioButton rbNuevoPErfil;
        private RadioButton rbEditarPersonal;
        private RadioButton rbNuevaPersonal;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private GroupBox groupBox1;
        private RadioButton rbEditarAE;
        private RadioButton rbNuevoAE;
        private DevComponents.DotNetBar.ButtonX tbCerrarAE;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAnioCompraSoftAE;
        private DevComponents.DotNetBar.Controls.Line line12;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObsvSoftAE;
        private Label label97;
        private Label label98;
        private Label label99;
        private Label label100;
        private Label label101;
        private DevComponents.DotNetBar.Controls.TextBoxX tbOCSoftAE;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCantidadUsSoftAE;
        private DevComponents.DotNetBar.Controls.TextBoxX tbnombreSoftAE;
        private Label label103;
        private DevComponents.DotNetBar.Controls.TextBoxX tbVersionSoftAE;
        private Label label104;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbActivoSoftAE;
        private DevComponents.Editors.ComboItem comboItem32;
        private DevComponents.Editors.ComboItem comboItem33;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFuncionamientoSoft;
        private Label label61;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstadoEquipoSoft;
        private DevComponents.Editors.ComboItem comboItem29;
        private DevComponents.Editors.ComboItem comboItem30;
        private DevComponents.Editors.ComboItem comboItem31;
        private Label label64;
        private Label label70;
        private Label label72;
        private Label label75;
        private Label label76;
        private Label label77;
        private Label label78;
        private Label label79;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObseracionSoft;
        private Label label94;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIpSoft;
        private Label label95;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProcesadorSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbModeloSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroOrdenCompraSoft;
        private Label label96;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMarcaSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroSerieSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroControlPatrimonialSoft;
        private DataGridView DGVSoftware_SodtAE;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAnioCompraSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCatEqSoft;
        private DevComponents.DotNetBar.ButtonX btCerrarSoftAE;
        private RadioButton rbEditarSofAE;
        private RadioButton rbNuevoSofAE;
        private DevComponents.DotNetBar.ButtonX btReporteSoftAE;
        private DevComponents.DotNetBar.ButtonX btListaSoftAE;
        private DevComponents.DotNetBar.ButtonX btGrabarSoftAE;
        private DevComponents.DotNetBar.ButtonX btActualizarSoftAE;
        private DevComponents.DotNetBar.ButtonX btEliminarSoftAE;
        private DevComponents.DotNetBar.ButtonX btLimpiarSoftAE;
        private Label label105;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInstalacionSoftAE;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaCaducidadSoftAE;
        private Label label106;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCodEquipoSofAE;
        private Label label107;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label102;
        private DevComponents.DotNetBar.Controls.Line line13;
        private Label label108;
        private Label label109;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSoftware_SoftAE;
        private RadioButton rbEditarSof;
        private RadioButton rbNuevoSof;
        private RadioButton rbEditarCat;
        private RadioButton rbNuevoCat;
        private DataGridView DGVRegistro;
        private DevComponents.DotNetBar.SuperTabControl superTabControl3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel7;
        private DevComponents.DotNetBar.SuperTabItem stiEscaner;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel6;
        private DevComponents.DotNetBar.SuperTabItem stiImpresora;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.SuperTabItem stiLaptop;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem stiSistAudio;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel10;
        private DevComponents.DotNetBar.SuperTabItem stiCPU;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel11;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel12;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DataGridViewTextBoxColumn cod_sede;
        private DataGridViewTextBoxColumn nombre_sede;
        private DataGridViewTextBoxColumn direcionSede;
        private DataGridViewTextBoxColumn observacionsede;
        private DataGridViewTextBoxColumn activosede;
        private DataGridViewTextBoxColumn Column45;
        private DataGridViewTextBoxColumn Column46;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column51;
        private DataGridViewTextBoxColumn Column50;
        private DataGridViewTextBoxColumn Column40;
        private DataGridViewTextBoxColumn nombre_instancia;
        private DataGridViewTextBoxColumn nro_instancia;
        private DataGridViewTextBoxColumn Column47;
        private DataGridViewTextBoxColumn activoInstancia;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DataGridView DGVPersonal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn Column41;
        private DataGridViewTextBoxColumn Column42;
        private DataGridViewTextBoxColumn Column43;
        private DataGridViewTextBoxColumn Column44;
        private DataGridViewTextBoxColumn Column49;
        private DataGridViewTextBoxColumn Column52;
        private DataGridViewTextBoxColumn Column53;
        private DataGridViewTextBoxColumn Column54;
        private DataGridViewTextBoxColumn Column58;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel14;
        private DevComponents.DotNetBar.SuperTabItem stiOtros;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel13;
        private DevComponents.DotNetBar.SuperTabItem cbAnioCompraComp;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFuncionamientoComp;
        private Label label110;
        private Label label111;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX7;
        private Label label112;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstadoEquipoComp;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem34;
        private DevComponents.Editors.ComboItem comboItem35;
        private Label label113;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAnioCompraCom;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx3;
        private Label label114;
        private Label label115;
        private Label label116;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx4;
        private DevComponents.Editors.ComboItem comboItem36;
        private DevComponents.Editors.ComboItem comboItem37;
        private Label label117;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCatEqComp;
        private Label label118;
        private Label label119;
        private Label label120;
        private Label label121;
        private Label label122;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObseracionComp;
        private Label label123;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIpComp;
        private Label label124;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProcesadorComp;
        private DevComponents.DotNetBar.Controls.TextBoxX tbModeloComp;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroOrdenCompraComp;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNombreEquipoComp;
        private Label label125;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMarcaComp;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroSerieComp;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroControlPatrimonialComp;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAsignacionEqComp;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private DevComponents.DotNetBar.ButtonX buttonX14;
        private DevComponents.DotNetBar.ButtonX buttonX15;
        private DevComponents.DotNetBar.ButtonX buttonX16;
        private DevComponents.DotNetBar.ButtonX buttonX17;
        private DevComponents.DotNetBar.ButtonX buttonX18;
        private DevComponents.DotNetBar.ButtonX buttonX19;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel15;
        private DevComponents.DotNetBar.ButtonX tbCerrarAECCom;
        private RadioButton rbEditarAECCom;
        private RadioButton rbNuevoAECCom;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFuncionamientoCCom;
        private Label label126;
        private Label label127;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServiceTagCCom;
        private Label label128;
        private Label label129;
        private Label label130;
        private Label label131;
        private Label label132;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAsignadoCCom;
        private DevComponents.Editors.ComboItem comboItem41;
        private DevComponents.Editors.ComboItem comboItem42;
        private Label label133;
        private Label label134;
        private Label label135;
        private Label label136;
        private Label label137;
        private Label label138;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObseracionCCom;
        private Label label139;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIpCCom;
        private Label label140;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProcesadorCCom;
        private DevComponents.DotNetBar.Controls.TextBoxX tbModeloCCom;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroOrdenCompraCCom;
        private Label label141;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMarcaCCom;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroSerieCCom;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroControlPatrimonialCCom;
        private DataGridView DGVRegistroCCom;
        private DevComponents.DotNetBar.ButtonX btReportEquipoCCom;
        private DevComponents.DotNetBar.ButtonX btListaAECCom;
        private DevComponents.DotNetBar.ButtonX btRegistrarAECCom;
        private DevComponents.DotNetBar.ButtonX tbActualizarAECCom;
        private DevComponents.DotNetBar.ButtonX tbEliminarAECCom;
        private DevComponents.DotNetBar.ButtonX tbLimpiarAECCom;
        private DevComponents.DotNetBar.SuperTabItem stComponente;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCodEqCComInf;
        private Label label144;
        private DevComponents.DotNetBar.Controls.TextBoxX cbAnioCompraCComInf;
        private DevComponents.DotNetBar.Controls.TextBoxX cbCatEqCComInf;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFuncionamientoCComInf;
        private Label label145;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstadoEquipoCComInf;
        private DevComponents.Editors.ComboItem comboItem38;
        private DevComponents.Editors.ComboItem comboItem39;
        private DevComponents.Editors.ComboItem comboItem40;
        private Label label146;
        private Label label147;
        private Label label148;
        private Label label149;
        private Label label150;
        private Label label151;
        private Label label152;
        private Label label153;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObseracionCComInf;
        private Label label154;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIpCComInf;
        private Label label155;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProcesadorCComInf;
        private DevComponents.DotNetBar.Controls.TextBoxX tbModeloCComInf;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroOrdenCompraCComInf;
        private Label label156;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMarcaCComInf;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroSerieCComInf;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroControlPatrimonialCComInf;
        private Label label143;
        private DevComponents.DotNetBar.Controls.Line line15;
        private Label label142;
        private DevComponents.DotNetBar.Controls.Line line14;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstadoEquipoCCom;
        private DevComponents.Editors.ComboItem comboItem43;
        private DevComponents.Editors.ComboItem comboItem44;
        private DevComponents.Editors.ComboItem comboItem45;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAnioCompraCCom;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCatEqCCom;
        private DevComponents.DotNetBar.Controls.TextBoxX cbEquipoPadreCodCCom;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tbNombreEquipoCCom;
        private DevComponents.Editors.ComboItem comboItem46;
        private DevComponents.Editors.ComboItem comboItem47;
        private DevComponents.Editors.ComboItem comboItem48;
        private DataGridViewTextBoxColumn Column27;
        private DataGridViewTextBoxColumn Column28;
        private DataGridViewTextBoxColumn Column31;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column29;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column30;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column55;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column25;
        private DataGridViewTextBoxColumn Column26;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.AdvTree.ColumnHeader columnHeader3;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel10;
        private DevComponents.DotNetBar.Controls.SideNavItem SNIUsers;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel12;
        private DevComponents.DotNetBar.Separator separator7;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem6;
        private Panel panelDesktop;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private Panel panelDesktopCU;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel13;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem11;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFuncionamientoNA;
        private Label label157;
        private Label label158;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServiceTagNA;
        private Label label159;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstadoEquipoNA;
        private DevComponents.Editors.ComboItem comboItem51;
        private DevComponents.Editors.ComboItem comboItem54;
        private DevComponents.Editors.ComboItem comboItem55;
        private Label label160;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAnioCompraNA;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEquipoPadreCodNA;
        private Label label161;
        private Label label162;
        private Label label163;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAsignadoNA;
        private DevComponents.Editors.ComboItem comboItem56;
        private DevComponents.Editors.ComboItem comboItem57;
        private Label label164;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCatEqNA;
        private Label label165;
        private Label label166;
        private Label label167;
        private Label label168;
        private Label label169;
        private DevComponents.DotNetBar.Controls.TextBoxX tbObseracionNA;
        private Label label170;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIpNA;
        private Label label171;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProcesadorNA;
        private DevComponents.DotNetBar.Controls.TextBoxX tbModeloNA;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroOrdenCompraNA;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNombreEquipoNA;
        private Label label172;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMarcaNA;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroSerieNA;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNroControlPatrimonialNA;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaAsignacionAES;
        private Label label173;
        private RadioButton rbEditarEq;
        private RadioButton rbNuevoEq;
        private DevComponents.DotNetBar.ButtonX buttonX20;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DataGridViewTextBoxColumn cod_equipo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn ip_equipo;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn procesador;
        private DataGridViewTextBoxColumn nro_serie;
        private DataGridViewTextBoxColumn nro_control_patrimonial;
        private DataGridViewTextBoxColumn anio_adquisicion;
        private DataGridViewTextBoxColumn nro_orden_compra;
        private DataGridViewTextBoxColumn observacion;
        private DataGridViewTextBoxColumn activo;
        private DataGridViewTextBoxColumn cod_categoria;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column56;
        private DataGridViewTextBoxColumn Column57;
        private DevComponents.DotNetBar.Separator separator8;
        private DevComponents.DotNetBar.Separator separator10;
        private DevComponents.DotNetBar.Separator separator9;
        private DevComponents.DotNetBar.ButtonX btnConstAsg;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaAsignacionAESCCom;
        private Label label174;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        // private DataGridViewCellEventHandler DGVSoftware_CellContentClick_2;
        //private EventHandler btListarSoft_Click_1;
        // private EventHandler btnActualizarSoft_Click_1;
        // private EventHandler btnEliminarSoft_Click_1;
        // private EventHandler btnLimpiarSoft_Click_1;
        // private DataGridViewCellEventHandler DGVSede_CellContentClick;
        // private EventHandler btEliminarSede_Click;
        // private EventHandler btActualizarSede_Click;
        // private EventHandler btListarSede_Click;
        // private EventHandler btLimpiarSede_Click;
        // private EventHandler btRegistrarSede_Click;
        // private EventHandler tabPage13_Click;
        // private EventHandler btListarInst_Click;
        // private EventHandler btEliminarIns_Click;
        // private EventHandler btActualizarInst_Click;
        //  private EventHandler btLimpiarInst_Click;
        // private EventHandler btRegistrarIns_Click;
        //private EventHandler btListarCategoria_Click;
    }
}

