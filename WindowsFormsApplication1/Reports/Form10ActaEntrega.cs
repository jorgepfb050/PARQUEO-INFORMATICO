using Microsoft.Reporting.WinForms;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1.Reports
{
    public partial class Form10ActaEntrega : Form
    {
        public Form10ActaEntrega()
        {
            InitializeComponent();
        }
        ReportDataSource rs = new ReportDataSource();
        public string tbDniAE;
        public string tbInstancAE;
        public string tbSedeAE;
        public string tbPerfilAE;
        private void Form10ActaEntrega_Load(object sender, EventArgs e)
        {

           // this.RVActaEntrega.RefreshReport();
        }
    
        private BindingSource bindingSourceUM = new BindingSource();
        private SqlDataAdapter dataAdapterUM = new SqlDataAdapter();
        int keyUMdgv = 0;

        private void btGenerarRepReg1_Click(object sender, EventArgs e)
        {
            //llamar metodo de asignacion
            Form1 frm = new Form1();
           

            if (rbtnAllAsg.Checked == true)
            {
                generarActaEntregafae(tbDniAE, tbInstancAE, tbSedeAE, tbPerfilAE);
            }
            else if (rbtnTime.Checked == true)
            {
                generarActaEntregafaeFecha(tbDniAE, tbInstancAE, tbSedeAE, tbPerfilAE,dtFechaAsignacionDesde.Text);
 
            }

        }

        public void generarActaEntregafae(string tbDniAE,string tbInstancAE,string tbSedeAE,string tbPerfilAE)
        {
            try
            {



                ModeloDatoDataContext db = new ModeloDatoDataContext();
                System.Windows.Forms.DataGridView dg = new System.Windows.Forms.DataGridView();
                Controls.Add(dg);
                List<WindowsFormsApplication1.Form1.ActaEnrega> lst = new List<WindowsFormsApplication1.Form1.ActaEnrega>();

                //listarPersonal();
                var sqlDNI = (from T0 in db.Personals
                              where T0.dni == tbDniAE
                              select T0).ToList();

                //verificar si el dni existe
                if (sqlDNI.Count() > 0)
                {

                    var sqlDniReg = (from T0 in db.Registros
                                     where T0.doc_entry_personal == sqlDNI[0].doc_entry_personal
                                     select T0).ToList();

                    if (sqlDniReg.Count() > 0)//existe un registro para el dni
                    {

                        dg.AutoGenerateColumns = false;
                        //dg.AllowUserToAddRows = false;
                        dg.DataSource = null;
                        lst.Clear();


                        var sqlreg = (from T0 in db.Registros
                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                      join T2 in db.Personals on T0.doc_entry_personal equals T2.doc_entry_personal
                                      where T0.doc_entry_personal == sqlDniReg[0].doc_entry_personal 
                                      select new
                                      {
                                          fechaRegUser = T0.fecha_registro,
                                          fechaRegSist = T0.fecha_sistema,
                                          cod_equipo = T0.cod_equipo,
                                          equipo = T1.equipo,
                                          ip_equipo = T1.ip_equipo,
                                          marca = T1.marca,
                                          modelo = T1.modelo,
                                          procesador = T1.procesador,
                                          nro_serie = T1.nro_serie,
                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                          anio_adquisicion = T1.anio_adquisicion,
                                          nro_orden_compra = T1.nro_orden_compra,
                                          observacion = T1.observacion,
                                          activo = T1.activo,
                                          cod_categoria = T1.cod_categoria,
                                          equipoPadreCod = T1.equipoPadreCod,
                                          estadoEquipo = T1.estado,
                                          doc_entry_personal = T0.doc_entry_personal,
                                          c_usuario = T2.c_usuario,
                                          c_nombres = T2.c_nombres,
                                          c_ape_paterno = T2.c_ape_paterno,
                                          c_ape_materno = T2.c_ape_materno,
                                          nombre = T2.nombre_completo,
                                          fecha_ingreso = T2.fecha_ingreso,
                                          c_perfil = T2.c_perfil,
                                          dni = T2.dni,
                                          nombre_instancia = tbInstancAE,
                                          c_sede = T2.c_sede,
                                          nombre_sede = tbSedeAE,
                                          perfil = tbPerfilAE,
                                          estado = T2.estado,
                                          escalafon = T2.escalafon,
                                          unidad_organica = T2.unidad_organica,
                                          area = T2.area,
                                          tipo_personal = T2.tipo_personal,
                                          fecha_ingreso_lab = T2.fecha_ingreso,
                                      }).ToList();

                        //lista de componentes
                        var lst_comp = (from
                                    T1 in db.Equipos
                                        where T1.activo == "S" && T1.equipo == "MOUSE" || T1.equipo == "TECLADO" || T1.equipo == "MONITOR"
                                        select new
                                        {
                                            categoria = "",
                                            nombre_sede = "",
                                            nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                            nombre = "",
                                            perfil = "",
                                            equipo = T1.equipo,
                                            marca = T1.marca,
                                            modelo = T1.modelo,
                                            nro_serie = T1.nro_serie,
                                            nro_control_patrimonial = T1.nro_control_patrimonial,
                                            activo = T1.activo,
                                            nro_orden_compra = T1.nro_orden_compra,
                                            anio_adquisicion = T1.anio_adquisicion,
                                            unidad_organica = "",
                                            area = "",

                                            funcionamiento = "",
                                            observacion = T1.observacion,
                                            procesador = T1.procesador,
                                            estado = T1.estado,
                                            cod_equipo = T1.cod_equipo,
                                            equipoPadreCod = T1.equipoPadreCod,

                                        }).ToList();

                        dg.DataSource = sqlreg;
                        //dg.Refresh();
                        foreach (var nw in sqlreg)
                        {
                            WindowsFormsApplication1.Form1.ActaEnrega act = new WindowsFormsApplication1.Form1.ActaEnrega();
                            //no agregar componente con padre
                            if ((nw.equipo != "MOUSE" & nw.equipo != "TECLADO" & nw.equipo != "MONITOR") /*|| nw.equipoPadreCod.ToString() == null || nw.equipoPadreCod.ToString()=="0"*/)
                            {
                                act.fechaRegUser = Convert.ToString(nw.fechaRegUser);
                                act.fechaRegSist = Convert.ToString(nw.fechaRegSist);

                                act.cod_equipo = Convert.ToString(nw.cod_equipo);
                                act.equipo = Convert.ToString(nw.equipo);
                                act.ip_equipo = Convert.ToString(nw.ip_equipo);
                                act.marca = Convert.ToString(nw.marca);
                                act.modelo = Convert.ToString(nw.modelo);
                                act.procesador = Convert.ToString(nw.procesador);
                                act.nro_serie = Convert.ToString(nw.nro_serie);
                                act.nro_control_patrimonial = Convert.ToString(nw.nro_control_patrimonial);
                                act.anio_adquisicion = Convert.ToString(nw.anio_adquisicion);
                                act.nro_orden_compra = Convert.ToString(nw.nro_orden_compra);
                                act.observacion = Convert.ToString(nw.observacion);
                                act.activo = Convert.ToString(nw.activo);
                                act.cod_categoria = Convert.ToString(nw.cod_categoria);
                                act.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                act.estadoEquipo = Convert.ToString(nw.estadoEquipo);
                                act.doc_entry_personal = Convert.ToString(nw.doc_entry_personal);
                                act.c_usuario = Convert.ToString(nw.c_usuario);
                                act.c_nombres = Convert.ToString(nw.c_nombres);
                                act.c_ape_paterno = Convert.ToString(nw.c_ape_paterno);
                                act.c_ape_materno = Convert.ToString(nw.c_ape_materno);
                                act.nombre = Convert.ToString(nw.nombre);
                                act.fecha_ingreso = Convert.ToString(nw.fecha_ingreso);
                                act.c_perfil = Convert.ToString(nw.c_perfil);
                                act.dni = Convert.ToString(nw.dni);
                                act.nombre_instancia = Convert.ToString(nw.nombre_instancia);
                                act.c_sede = Convert.ToString(nw.c_sede);
                                act.nombre_sede = Convert.ToString(nw.nombre_sede);
                                act.perfil = Convert.ToString(nw.perfil);
                                act.estado = Convert.ToString(nw.estado);
                                act.escalafon = Convert.ToString(nw.escalafon);
                                act.unidad_organica = Convert.ToString(nw.unidad_organica);
                                act.area = Convert.ToString(nw.area);
                                act.tipo_personal = Convert.ToString(nw.tipo_personal);
                                act.fecha_ingreso_lab = Convert.ToString(nw.fecha_ingreso_lab);
                                lst.Add(act);
                                foreach (var lcom in lst_comp)
                                {
                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                    {
                                        WindowsFormsApplication1.Form1.ActaEnrega componente = new WindowsFormsApplication1.Form1.ActaEnrega();

                                        componente.fechaRegUser = Convert.ToString(nw.fechaRegUser);
                                        componente.fechaRegSist = Convert.ToString(nw.fechaRegSist);
                                        componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                        componente.equipo = Convert.ToString(lcom.equipo);
                                        componente.ip_equipo = "";
                                        componente.marca = Convert.ToString(lcom.marca);
                                        componente.modelo = Convert.ToString(lcom.modelo);
                                        componente.procesador = Convert.ToString(lcom.procesador);
                                        componente.nro_serie = Convert.ToString(lcom.nro_serie);
                                        componente.nro_control_patrimonial = Convert.ToString(lcom.nro_control_patrimonial);
                                        componente.anio_adquisicion = Convert.ToString(lcom.anio_adquisicion);
                                        componente.nro_orden_compra = Convert.ToString(lcom.nro_orden_compra);
                                        componente.observacion = Convert.ToString(lcom.observacion);
                                        componente.activo = Convert.ToString(lcom.activo);
                                        componente.cod_categoria = "";
                                        componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                        componente.estadoEquipo = Convert.ToString(lcom.estado);
                                        componente.doc_entry_personal = Convert.ToString(act.doc_entry_personal);
                                        componente.c_usuario = Convert.ToString(act.c_usuario);
                                        componente.c_nombres = Convert.ToString(act.c_nombres);
                                        componente.c_ape_paterno = Convert.ToString(act.c_ape_paterno);
                                        componente.c_ape_materno = Convert.ToString(act.c_ape_materno);
                                        componente.nombre = Convert.ToString(act.nombre);
                                        componente.fecha_ingreso = Convert.ToString(act.fecha_ingreso);
                                        componente.c_perfil = Convert.ToString(act.c_perfil);
                                        componente.dni = Convert.ToString(act.dni);
                                        componente.nombre_instancia = Convert.ToString(act.nombre_instancia);
                                        componente.c_sede = Convert.ToString(act.c_sede);
                                        componente.nombre_sede = Convert.ToString(act.nombre_sede);
                                        componente.perfil = Convert.ToString(act.perfil);
                                        componente.estado = Convert.ToString(act.estado);
                                        componente.escalafon = Convert.ToString(act.escalafon);
                                        componente.unidad_organica = Convert.ToString(act.unidad_organica);
                                        componente.area = Convert.ToString(act.area);
                                        componente.tipo_personal = Convert.ToString(act.tipo_personal);
                                        componente.fecha_ingreso_lab = Convert.ToString(act.fecha_ingreso_lab);

                                        lst.Add(componente);


                                    }
                                }


                            }



                        }
                        //agregar componentes que no tienen padre y estan en TREGISTRO
                        foreach (var nw in sqlreg)
                        {
                            WindowsFormsApplication1.Form1.ActaEnrega act = new WindowsFormsApplication1.Form1.ActaEnrega();
                            //no agregar componente con padre
                            if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && (( String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                            {
                                act.fechaRegUser = Convert.ToString(nw.fechaRegUser);
                                act.fechaRegSist = Convert.ToString(nw.fechaRegSist);

                                act.cod_equipo = Convert.ToString(nw.cod_equipo);
                                act.equipo = Convert.ToString(nw.equipo);
                                act.ip_equipo = Convert.ToString(nw.ip_equipo);
                                act.marca = Convert.ToString(nw.marca);
                                act.modelo = Convert.ToString(nw.modelo);
                                act.procesador = Convert.ToString(nw.procesador);
                                act.nro_serie = Convert.ToString(nw.nro_serie);
                                act.nro_control_patrimonial = Convert.ToString(nw.nro_control_patrimonial);
                                act.anio_adquisicion = Convert.ToString(nw.anio_adquisicion);
                                act.nro_orden_compra = Convert.ToString(nw.nro_orden_compra);
                                act.observacion = Convert.ToString(nw.observacion);
                                act.activo = Convert.ToString(nw.activo);
                                act.cod_categoria = Convert.ToString(nw.cod_categoria);
                                act.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                act.estadoEquipo = Convert.ToString(nw.estadoEquipo);
                                act.doc_entry_personal = Convert.ToString(nw.doc_entry_personal);
                                act.c_usuario = Convert.ToString(nw.c_usuario);
                                act.c_nombres = Convert.ToString(nw.c_nombres);
                                act.c_ape_paterno = Convert.ToString(nw.c_ape_paterno);
                                act.c_ape_materno = Convert.ToString(nw.c_ape_materno);
                                act.nombre = Convert.ToString(nw.nombre);
                                act.fecha_ingreso = Convert.ToString(nw.fecha_ingreso);
                                act.c_perfil = Convert.ToString(nw.c_perfil);
                                act.dni = Convert.ToString(nw.dni);
                                act.nombre_instancia = Convert.ToString(nw.nombre_instancia);
                                act.c_sede = Convert.ToString(nw.c_sede);
                                act.nombre_sede = Convert.ToString(nw.nombre_sede);
                                act.perfil = Convert.ToString(nw.perfil);
                                act.estado = Convert.ToString(nw.estado);
                                act.escalafon = Convert.ToString(nw.escalafon);
                                act.unidad_organica = Convert.ToString(nw.unidad_organica);
                                act.area = Convert.ToString(nw.area);
                                act.tipo_personal = Convert.ToString(nw.tipo_personal);
                                act.fecha_ingreso_lab = Convert.ToString(nw.fecha_ingreso_lab);
                                lst.Add(act);
                            }

                        }


                        rs.Name = "DataSet1";
                        rs.Value = lst;
                        Form10ActaEntregaRV frm = new Form10ActaEntregaRV();

                        frm.RVActaEntrega.LocalReport.DataSources.Clear();
                        frm.RVActaEntrega.LocalReport.DataSources.Add(rs);
                        frm.RVActaEntrega.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report10ActaEntrega.rdlc";
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("El dni no tiene equipos asignados");
                    }


                }
                else
                {
                    MessageBox.Show("El dni no esta registrado");
                }
                //obtener el doc_entry_personal apartir del dni





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void generarActaEntregafaeFecha(string tbDniAE, string tbInstancAE, string tbSedeAE, string tbPerfilAE, string fecha)
        {
            try
            {


                
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                System.Windows.Forms.DataGridView dg = new System.Windows.Forms.DataGridView();
                Controls.Add(dg);
                List<WindowsFormsApplication1.Form1.ActaEnrega> lst = new List<WindowsFormsApplication1.Form1.ActaEnrega>();

                //listarPersonal();
                var sqlDNI = (from T0 in db.Personals
                              where T0.dni == tbDniAE
                              select T0).ToList();

                //verificar si el dni existe
                if (sqlDNI.Count() > 0)
                {

                    var sqlDniReg = (from T0 in db.Registros
                                     where T0.doc_entry_personal == sqlDNI[0].doc_entry_personal
                                     select T0).ToList();

                    if (sqlDniReg.Count() > 0)//existe un registro para el dni
                    {

                        dg.AutoGenerateColumns = false;
                        //dg.AllowUserToAddRows = false;
                        dg.DataSource = null;
                        lst.Clear();


                        var sqlreg = (from T0 in db.Registros
                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                      join T2 in db.Personals on T0.doc_entry_personal equals T2.doc_entry_personal
                                      where T0.doc_entry_personal == sqlDniReg[0].doc_entry_personal && T0.fecha_registro == fecha
                                      select new
                                      {
                                          fechaRegUser = T0.fecha_registro,
                                          fechaRegSist = T0.fecha_sistema,
                                          cod_equipo = T0.cod_equipo,
                                          equipo = T1.equipo,
                                          ip_equipo = T1.ip_equipo,
                                          marca = T1.marca,
                                          modelo = T1.modelo,
                                          procesador = T1.procesador,
                                          nro_serie = T1.nro_serie,
                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                          anio_adquisicion = T1.anio_adquisicion,
                                          nro_orden_compra = T1.nro_orden_compra,
                                          observacion = T1.observacion,
                                          activo = T1.activo,
                                          cod_categoria = T1.cod_categoria,
                                          equipoPadreCod = T1.equipoPadreCod,
                                          estadoEquipo = T1.estado,
                                          doc_entry_personal = T0.doc_entry_personal,
                                          c_usuario = T2.c_usuario,
                                          c_nombres = T2.c_nombres,
                                          c_ape_paterno = T2.c_ape_paterno,
                                          c_ape_materno = T2.c_ape_materno,
                                          nombre = T2.nombre_completo,
                                          fecha_ingreso = T2.fecha_ingreso,
                                          c_perfil = T2.c_perfil,
                                          dni = T2.dni,
                                          nombre_instancia = tbInstancAE,
                                          c_sede = T2.c_sede,
                                          nombre_sede = tbSedeAE,
                                          perfil = tbPerfilAE,
                                          estado = T2.estado,
                                          escalafon = T2.escalafon,
                                          unidad_organica = T2.unidad_organica,
                                          area = T2.area,
                                          tipo_personal = T2.tipo_personal,
                                          fecha_ingreso_lab = T2.fecha_ingreso,
                                      }).ToList();

                        //lista de componentes
                        var lst_comp = (from
                                    T1 in db.Equipos
                                        where T1.activo == "S" && T1.equipo == "MOUSE" || T1.equipo == "TECLADO" || T1.equipo == "MONITOR"
                                        select new
                                        {
                                            categoria = "",
                                            nombre_sede = "",
                                            nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                            nombre = "",
                                            perfil = "",
                                            equipo = T1.equipo,
                                            marca = T1.marca,
                                            modelo = T1.modelo,
                                            nro_serie = T1.nro_serie,
                                            nro_control_patrimonial = T1.nro_control_patrimonial,
                                            activo = T1.activo,
                                            nro_orden_compra = T1.nro_orden_compra,
                                            anio_adquisicion = T1.anio_adquisicion,
                                            unidad_organica = "",
                                            area = "",

                                            funcionamiento = "",
                                            observacion = T1.observacion,
                                            procesador = T1.procesador,
                                            estado = T1.estado,
                                            cod_equipo = T1.cod_equipo,
                                            equipoPadreCod = T1.equipoPadreCod,

                                        }).ToList();

                        dg.DataSource = sqlreg;
                        //dg.Refresh();
                        foreach (var nw in sqlreg)
                        {
                            WindowsFormsApplication1.Form1.ActaEnrega act = new WindowsFormsApplication1.Form1.ActaEnrega();

                                act.fechaRegUser = Convert.ToString(nw.fechaRegUser);
                                act.fechaRegSist = Convert.ToString(nw.fechaRegSist);

                                act.cod_equipo = Convert.ToString(nw.cod_equipo);
                                act.equipo = Convert.ToString(nw.equipo);
                                act.ip_equipo = Convert.ToString(nw.ip_equipo);
                                act.marca = Convert.ToString(nw.marca);
                                act.modelo = Convert.ToString(nw.modelo);
                                act.procesador = Convert.ToString(nw.procesador);
                                act.nro_serie = Convert.ToString(nw.nro_serie);
                                act.nro_control_patrimonial = Convert.ToString(nw.nro_control_patrimonial);
                                act.anio_adquisicion = Convert.ToString(nw.anio_adquisicion);
                                act.nro_orden_compra = Convert.ToString(nw.nro_orden_compra);
                                act.observacion = Convert.ToString(nw.observacion);
                                act.activo = Convert.ToString(nw.activo);
                                act.cod_categoria = Convert.ToString(nw.cod_categoria);
                                act.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                act.estadoEquipo = Convert.ToString(nw.estadoEquipo);
                                act.doc_entry_personal = Convert.ToString(nw.doc_entry_personal);
                                act.c_usuario = Convert.ToString(nw.c_usuario);
                                act.c_nombres = Convert.ToString(nw.c_nombres);
                                act.c_ape_paterno = Convert.ToString(nw.c_ape_paterno);
                                act.c_ape_materno = Convert.ToString(nw.c_ape_materno);
                                act.nombre = Convert.ToString(nw.nombre);
                                act.fecha_ingreso = Convert.ToString(nw.fecha_ingreso);
                                act.c_perfil = Convert.ToString(nw.c_perfil);
                                act.dni = Convert.ToString(nw.dni);
                                act.nombre_instancia = Convert.ToString(nw.nombre_instancia);
                                act.c_sede = Convert.ToString(nw.c_sede);
                                act.nombre_sede = Convert.ToString(nw.nombre_sede);
                                act.perfil = Convert.ToString(nw.perfil);
                                act.estado = Convert.ToString(nw.estado);
                                act.escalafon = Convert.ToString(nw.escalafon);
                                act.unidad_organica = Convert.ToString(nw.unidad_organica);
                                act.area = Convert.ToString(nw.area);
                                act.tipo_personal = Convert.ToString(nw.tipo_personal);
                                act.fecha_ingreso_lab = Convert.ToString(nw.fecha_ingreso_lab);
                                lst.Add(act);
                                foreach (var lcom in lst_comp)
                                {
                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                    {
                                        WindowsFormsApplication1.Form1.ActaEnrega componente = new WindowsFormsApplication1.Form1.ActaEnrega();
                                        //no ingresar los asignados los que esten em registro
                                        var comp_reg= (from T0 in db.Registros where T0.cod_equipo==lcom.cod_equipo select T0).ToList();
                                        if (comp_reg.Count() <= 0)
                                        {
                                            componente.fechaRegUser = Convert.ToString(nw.fechaRegUser);
                                            componente.fechaRegSist = Convert.ToString(nw.fechaRegSist);
                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                            componente.equipo = Convert.ToString(lcom.equipo);
                                            componente.ip_equipo = "";
                                            componente.marca = Convert.ToString(lcom.marca);
                                            componente.modelo = Convert.ToString(lcom.modelo);
                                            componente.procesador = Convert.ToString(lcom.procesador);
                                            componente.nro_serie = Convert.ToString(lcom.nro_serie);
                                            componente.nro_control_patrimonial = Convert.ToString(lcom.nro_control_patrimonial);
                                            componente.anio_adquisicion = Convert.ToString(lcom.anio_adquisicion);
                                            componente.nro_orden_compra = Convert.ToString(lcom.nro_orden_compra);
                                            componente.observacion = Convert.ToString(lcom.observacion);
                                            componente.activo = Convert.ToString(lcom.activo);
                                            componente.cod_categoria = "";
                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                            componente.estadoEquipo = Convert.ToString(lcom.estado);
                                            componente.doc_entry_personal = Convert.ToString(act.doc_entry_personal);
                                            componente.c_usuario = Convert.ToString(act.c_usuario);
                                            componente.c_nombres = Convert.ToString(act.c_nombres);
                                            componente.c_ape_paterno = Convert.ToString(act.c_ape_paterno);
                                            componente.c_ape_materno = Convert.ToString(act.c_ape_materno);
                                            componente.nombre = Convert.ToString(act.nombre);
                                            componente.fecha_ingreso = Convert.ToString(act.fecha_ingreso);
                                            componente.c_perfil = Convert.ToString(act.c_perfil);
                                            componente.dni = Convert.ToString(act.dni);
                                            componente.nombre_instancia = Convert.ToString(act.nombre_instancia);
                                            componente.c_sede = Convert.ToString(act.c_sede);
                                            componente.nombre_sede = Convert.ToString(act.nombre_sede);
                                            componente.perfil = Convert.ToString(act.perfil);
                                            componente.estado = Convert.ToString(act.estado);
                                            componente.escalafon = Convert.ToString(act.escalafon);
                                            componente.unidad_organica = Convert.ToString(act.unidad_organica);
                                            componente.area = Convert.ToString(act.area);
                                            componente.tipo_personal = Convert.ToString(act.tipo_personal);
                                            componente.fecha_ingreso_lab = Convert.ToString(act.fecha_ingreso_lab);

                                            lst.Add(componente);
 
                                        }

                                      


                                    }
                                }
                            

                         


                        }


                        rs.Name = "DataSet1";
                        rs.Value = lst;
                        Form10ActaEntregaRV frm = new Form10ActaEntregaRV();

                        frm.RVActaEntrega.LocalReport.DataSources.Clear();
                        frm.RVActaEntrega.LocalReport.DataSources.Add(rs);
                        frm.RVActaEntrega.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report10ActaEntrega.rdlc";
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("El dni no tiene equipos asignados");
                    }


                }
                else
                {
                    MessageBox.Show("El dni no esta registrado");
                }
                //obtener el doc_entry_personal apartir del dni





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            dtFechaAsignacionDesde.Value = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void GetData()
        {
            try
            {
                if (tbDniAE != string.Empty)
                {
                    // Specify a connection string.
                    // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                    // Replace "Integrated Security=True" with user login information if necessary.
                    //string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                    //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MMyconn"].ConnectionString;

                    /*string connectionString = "Data Source=172.17.208.73;Initial Catalog=PARQUEO03_30122021_prueba;" +
                   "Integrated Security=True";
                     * */
                    String connectionString = ConfigurationManager.ConnectionStrings["Models.Properties.Settings.PARQUEO03_30122021_pruebaConnectionString2"].ConnectionString;


                    // Create a new data adapter based on the specified query.

                    string selectCommand = "select	fecha_registro,fecha_registro_hhmm,cod_equipo,equipo,ip_equipo,marca,modelo,procesador,nro_serie,nro_control_patrimonial,anio_adquisicion,nro_orden_compra,observacion_equipo ,activo,cod_categoria   ,equipoPadreCod ,estado_equipo,doc_entry_personal ,c_usuario,c_nombres ,c_ape_paterno,c_ape_materno ,nombre_completo ,fecha_ingreso  ,c_perfil    ,dni    ,c_instancia   ,c_sede ,c_sede       ,c_perfil ,estado_personal   ,escalafon ,unidad_organica    ,area       ,tipo_personal       ,fecha_ingreso_lab, movimiento from Historico_registro_equipo where dni =" + tbDniAE + " and movimiento='DESASIGNADO' order by fecha_registro_hhmm";

                    dataAdapterUM = new SqlDataAdapter(selectCommand, connectionString);

                    // Create a command builder to generate SQL update, insert, and
                    // delete commands based on selectCommand.
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterUM);

                    // Populate a new data table and bind it to the BindingSource.
                    DataTable table = new DataTable();

                    dataAdapterUM.Fill(table);
                    bindingSourceUM.DataSource = table;

                    // Resize the DataGridView columns to fit the newly loaded content.
                    DGVEqActa.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
 
                }
               

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void listarUM()
        {
            DGVEqActa.DataSource = bindingSourceUM;
            GetData();

        }

        private void rbtActaRetiro_Click(object sender, EventArgs e)
        {
            btnActaEntrega.Visible = false;
            btnActaRetiro.Visible = true;
            gbActaEntrega.Enabled = false;
            gbActaRetiro.Enabled = true;
            listarUM();

        }
        private void selectRowsDGV()
        {

       
            //recibir los datos de fila seleccionados
            if (DGVEqActa.SelectedRows.Count <= 0)//Contar si hay filas seleccionadas
            {
                MessageBox.Show("No hay filas seleccionadas!",
                    "Generando el reporte...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Generar reporte de equipos " +
                    " seleccionados?", "Preguntar", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    DataGridViewSelectedRowCollection Selecciondas = DGVEqActa.SelectedRows;

                    // llenar la lista
                    List<WindowsFormsApplication1.Form1.ActaEnrega> lst = new List<WindowsFormsApplication1.Form1.ActaEnrega>();
                    lst.Clear();


                   
                   
                   
                    foreach (DataGridViewRow i in Selecciondas)// Recorrer los datos adquiridos
                    {
                       

                        ///
                        WindowsFormsApplication1.Form1.ActaEnrega act = new WindowsFormsApplication1.Form1.ActaEnrega();

                        act.fechaRegUser = Convert.ToString(i.Cells[0].Value.ToString());
                        act.fechaRegSist = Convert.ToString(i.Cells[1].Value.ToString());

                        act.cod_equipo = Convert.ToString(i.Cells[2].Value.ToString());
                        act.equipo = Convert.ToString(i.Cells[3].Value.ToString());
                        act.ip_equipo = Convert.ToString(i.Cells[4].Value.ToString());
                        act.marca = Convert.ToString(i.Cells[5].Value.ToString());
                        act.modelo = Convert.ToString(i.Cells[6].Value.ToString());
                        act.procesador = Convert.ToString(i.Cells[7].Value.ToString());
                        act.nro_serie = Convert.ToString(i.Cells[8].Value.ToString());
                        act.nro_control_patrimonial = Convert.ToString(i.Cells[9].Value.ToString());
                        act.anio_adquisicion = Convert.ToString(i.Cells[10].Value.ToString());
                        act.nro_orden_compra = Convert.ToString(i.Cells[11].Value.ToString());
                        act.observacion = Convert.ToString(i.Cells[12].Value.ToString());
                        act.activo = Convert.ToString(i.Cells[13].Value.ToString());
                        act.cod_categoria = Convert.ToString(i.Cells[14].Value.ToString());
                        act.equipoPadreCod = Convert.ToString(i.Cells[15].Value.ToString());
                        act.estadoEquipo = Convert.ToString(i.Cells[16].Value.ToString());
                        act.doc_entry_personal = Convert.ToString(i.Cells[17].Value.ToString());
                        act.c_usuario = Convert.ToString(i.Cells[18].Value.ToString());
                        act.c_nombres = Convert.ToString(i.Cells[19].Value.ToString());
                        act.c_ape_paterno = Convert.ToString(i.Cells[20].Value.ToString());
                        act.c_ape_materno = Convert.ToString(i.Cells[21].Value.ToString());
                        act.nombre = Convert.ToString(i.Cells[022].Value.ToString());
                        act.fecha_ingreso = Convert.ToString(i.Cells[23].Value.ToString());
                        act.c_perfil = Convert.ToString(i.Cells[24].Value.ToString());
                        act.dni = Convert.ToString(i.Cells[25].Value.ToString());
                        act.nombre_instancia = Convert.ToString(i.Cells[26].Value.ToString());
                        act.c_sede = Convert.ToString(i.Cells[27].Value.ToString());
                        act.nombre_sede = Convert.ToString(i.Cells[28].Value.ToString());
                        act.perfil = Convert.ToString(i.Cells[29].Value.ToString());
                        act.estado = Convert.ToString(i.Cells[30].Value.ToString());
                        act.escalafon = Convert.ToString(i.Cells[31].Value.ToString());
                        act.unidad_organica = Convert.ToString(i.Cells[32].Value.ToString());
                        act.area = Convert.ToString(i.Cells[33].Value.ToString());
                        act.tipo_personal = Convert.ToString(i.Cells[34].Value.ToString());
                        act.fecha_ingreso_lab = Convert.ToString(i.Cells[35].Value.ToString());
                        lst.Add(act);                       

                    }
                    rs.Name = "DataSet1";
                    rs.Value = lst;
                    Form10ActaEntregaRV frm = new Form10ActaEntregaRV();

                    frm.RVActaEntrega.LocalReport.DataSources.Clear();
                    frm.RVActaEntrega.LocalReport.DataSources.Add(rs);
                    frm.RVActaEntrega.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report10ActaRetiro.rdlc";
                    frm.ShowDialog();
                    
                }

            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            selectRowsDGV();
        }

        private void rbtnActaEntrega_Click(object sender, EventArgs e)
        {
            btnActaEntrega.Visible = true;
            btnActaRetiro.Visible = false;
            gbActaEntrega.Enabled = true;
            gbActaRetiro.Enabled = false;
        }

        private void rbtnActaRetiroFecha_Click(object sender, EventArgs e)
        {
            dtActaRetiro.Visible = true;
            DGVEqActa.ClearSelection();
        }

        private void rbtnActaRetiroTodos_Click(object sender, EventArgs e)
        {
            dtActaRetiro.Visible = false;
            //seleccionar todos los registros
           
            DGVEqActa.SelectAll();
          
           
        }

        private void dtActaRetiro_Leave(object sender, EventArgs e)
        {
            //recorrer grid
            if (dtActaRetiro.Text != string.Empty)
            {
                DGVEqActa.ClearSelection();
                foreach (DataGridViewRow row in DGVEqActa.Rows)
                {
                    /*
                    MessageBox.Show(row.Cells["Pago"].Value.ToString());
                    MessageBox.Show(row.Cells["Cantidad"].Value.ToString());
                    MessageBox.Show(row.Cells["Observaciones"].Value.ToString());
                     */
                    //agregar a la coleccion de selecionados si cumple con la condicion->fecha
                    if (row.Cells[0].Value.ToString() == dtActaRetiro.Text)
                    {
                        row.Selected = true;
                       // row.Rows(2).IsSelected = true;

                    }
                      

                }
 
            }
           
        }
        


    

    }
}
