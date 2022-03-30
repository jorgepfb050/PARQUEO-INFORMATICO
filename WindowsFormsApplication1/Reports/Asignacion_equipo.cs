using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using WindowsFormsApplication1.Reports;
using Microsoft.Reporting.WinForms;
using Models;

namespace WindowsFormsApplication1.Reports
{
    public partial class Asignacion_equipo : Form
    {
        ReportDataSource rs = new ReportDataSource();
        //var de tipo array de parametros
        ParameterFields parametros = new ParameterFields();
        //var de tipo parametro
        ParameterField miParametro = new ParameterField();
        //para guardar el valor que va ir en el parametro
        ParameterDiscreteValue valor = new ParameterDiscreteValue();
        public Asignacion_equipo()
        {
            InitializeComponent();         
            desableRBRepAE();
            

        }
        private void desableRBRepAE()
        {
            rbRegTodos.Checked=false;
            rbRegSedeInstancia.Checked=false;
            rbUnidadOrganicaArea.Checked=false;
            rbRegPorsona.Checked=false;
            rbRegCategoria.Checked=false;
            rbEquip.Checked = false;

            rbRegTodos.Enabled = false;
            rbRegSedeInstancia.Enabled = false;
            rbUnidadOrganicaArea.Enabled = false;
            rbRegPorsona.Enabled = false;
            rbRegCategoria.Enabled = false;
            rbEquip.Enabled = false;
        }
        private void enableRBRepAE()
        {
            rbRegTodos.Checked = false;
            rbRegSedeInstancia.Checked = false;
            rbUnidadOrganicaArea.Checked = false;
            rbRegPorsona.Checked = false;
            rbRegCategoria.Checked = false;
            rbEquip.Checked = false;

            rbRegTodos.Enabled = true;
            rbRegSedeInstancia.Enabled = true;
            rbUnidadOrganicaArea.Enabled = true;
            rbRegPorsona.Enabled = true;
            rbRegCategoria.Enabled = true;
            rbEquip.Enabled = true;
        }
        private void btGenerarRepReg1_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                List<CAsignacionEqui> lstAsignacion = new List<CAsignacionEqui>();
                DataGridView dg = new DataGridView();


                if (rbDetalladoAE.Checked == false && rbResumenAE.Checked == false)
                {
                    MessageBox.Show("Marque en Detallado o Resumen");
                    rbDetalladoAE.Focus();
                }
                else
                {
                  

                    if (rbDetalladoAE.Checked == true && rbResumenAE.Checked == false)//reporte detallado
                    {

                        if (rbRegSedeInstancia.Checked)
                        {
                            #region

                            if (Convert.ToInt32(comboBoxEx1.SelectedValue) == 0) //si combo1 es ***todos***
                            {
                                if (Convert.ToString(comboBoxEx2.SelectedValue) == "0")//si combo2 es ***todos***
                                {
                                    if (Convert.ToString(comboBoxEx3.SelectedValue) == "0")//si combo3 es ***todos***
                                    {
                                        //mostrar todo
                                        #region                                       
                                       

                                        dg.AutoGenerateColumns = false;
                                        dg.DataSource = null;
                                        lstAsignacion.Clear();
                                        

                                        var lst = ((
                                                from T0 in db.Registros
                                                join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                where
                                                (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                             
                                                                            
                                                orderby T5.nombre_completo, T2.categoria
                                                select new
                                                {
                                                    categoria = T2.categoria,
                                                    nombre_sede = T3.nombre_sede,
                                                    nombre_instancia = T4.nombre_instancia, 
                                                    nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                    perfil = T6.perfil,
                                                    equipo = T1.equipo,
                                                    marca = T1.marca,
                                                    modelo = T1.modelo,
                                                    nro_serie = T1.nro_serie,
                                                    nro_control_patrimonial = T1.nro_control_patrimonial,
                                                    activo = T1.activo,
                                                    nro_orden_compra = T1.nro_orden_compra,
                                                    anio_adquisicion = T1.anio_adquisicion,
                                                    unidad_organica = T5.unidad_organica,
                                                    area = T5.area,

                                                    funcionamiento = T1.funcionamiento,
                                                    observacion = T1.observacion,
                                                    procesador = T1.procesador,
                                                    estado = T1.estado,
                                                    cod_equipo = T1.cod_equipo,
                                                    equipoPadreCod = T1.equipoPadreCod,
                                                }).Union(
                                                  from T0 in db.Registros
                                                  join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                  join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                  join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                  //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                  join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                  join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                  where T5.c_instancia == "0"
                                                  && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                  //&& (DateTime.Now.Year - (T1.anio_adquisicion=="S/A"?0:Convert.ToInt32(T1.anio_adquisicion)) >= (Convert.ToInt32(tbAnioAntig.Text)))
                                                  orderby T5.nombre_completo, T2.categoria
                                                  select new
                                                  {
                                                      categoria = T2.categoria,
                                                      nombre_sede = T3.nombre_sede,
                                                      nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                      nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                      perfil = T6.perfil,
                                                      equipo = T1.equipo,
                                                      marca = T1.marca,
                                                      modelo = T1.modelo,
                                                      nro_serie = T1.nro_serie,
                                                      nro_control_patrimonial = T1.nro_control_patrimonial,
                                                      activo = T1.activo,
                                                      nro_orden_compra = T1.nro_orden_compra,
                                                      anio_adquisicion = T1.anio_adquisicion,
                                                      unidad_organica = T5.unidad_organica,
                                                      area = T5.area,

                                                      funcionamiento = T1.funcionamiento,
                                                      observacion = T1.observacion,
                                                      procesador = T1.procesador,
                                                      estado = T1.estado,
                                                      cod_equipo = T1.cod_equipo,
                                                      equipoPadreCod = T1.equipoPadreCod,

                                                  })).ToList();

                                        
                                        //lista de componentes
                                        var lst_comp=(from
                                                  T1 in db.Equipos
                                                      where T1.activo == "S" && T1.equipo == "MOUSE" || T1.equipo == "TECLADO"||T1.equipo=="MONITOR"
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

                                                      funcionamiento ="",
                                                      observacion = T1.observacion,
                                                      procesador = T1.procesador,
                                                      estado = T1.estado,
                                                      cod_equipo = T1.cod_equipo,
                                                      equipoPadreCod = T1.equipoPadreCod,

                                                  }).ToList();

                                        //recorrer lst e insertar lst_comp 
                                        List<CAsignacionEqui> lista = new List<CAsignacionEqui>();
                                       
                                         foreach(var nw in lst)
                                         {
                                             CAsignacionEqui listaregi = new CAsignacionEqui();
                                             if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                             {
                                                 listaregi.categoria = nw.categoria;
                                                 listaregi.nombre_sede = nw.nombre_sede;
                                                 listaregi.nombre_instancia = nw.nombre_instancia;
                                                 listaregi.nombre = nw.nombre;
                                                 listaregi.perfil = nw.perfil;
                                                 listaregi.equipo = nw.equipo;
                                                 listaregi.marca = nw.marca;
                                                 listaregi.modelo = nw.modelo;
                                                 listaregi.nro_serie = nw.nro_serie;
                                                 listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                 listaregi.activo = nw.activo;
                                                 listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                 listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                 listaregi.unidad_organica = nw.unidad_organica;
                                                 listaregi.area = nw.area;
                                                 listaregi.funcionamiento = nw.funcionamiento;
                                                 listaregi.observacion = nw.observacion;
                                                 listaregi.procesador = nw.procesador;
                                                 listaregi.estado = nw.estado;
                                                 listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                 listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                 lista.Add(listaregi);
                                                 foreach (var lcom in lst_comp)
                                                 {
                                                     if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                     {
                                                         CAsignacionEqui componente = new CAsignacionEqui();

                                                         componente.categoria = lcom.categoria;
                                                         componente.nombre_sede = lcom.nombre_sede;
                                                         componente.nombre_instancia = lcom.nombre_instancia;
                                                         componente.nombre = lcom.nombre;
                                                         componente.perfil = lcom.perfil;
                                                         componente.equipo = lcom.equipo;
                                                         componente.marca = lcom.marca;
                                                         componente.modelo = lcom.modelo;
                                                         componente.nro_serie = lcom.nro_serie;
                                                         componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                         componente.activo = lcom.activo;
                                                         componente.nro_orden_compra = lcom.nro_orden_compra;
                                                         componente.anio_adquisicion = lcom.anio_adquisicion;
                                                         componente.unidad_organica = lcom.unidad_organica;
                                                         componente.area = lcom.area;
                                                         componente.funcionamiento = lcom.funcionamiento;
                                                         componente.observacion = lcom.observacion;
                                                         componente.procesador = lcom.procesador;
                                                         componente.estado = lcom.estado;
                                                         componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                         componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                         lista.Add(componente);

                                                     }
                                                 }
 
                                             }

                                         }
                                         //agregar componentes de TREGISTRO que no tengan padre
                                         foreach (var nw in lst)
                                         {
                                             CAsignacionEqui listaregi = new CAsignacionEqui();

                                             if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                             {

                                                 listaregi.categoria = nw.categoria;
                                                 listaregi.nombre_sede = nw.nombre_sede;
                                                 listaregi.nombre_instancia = nw.nombre_instancia;
                                                 listaregi.nombre = nw.nombre;
                                                 listaregi.perfil = nw.perfil;
                                                 listaregi.equipo = nw.equipo;
                                                 listaregi.marca = nw.marca;
                                                 listaregi.modelo = nw.modelo;
                                                 listaregi.nro_serie = nw.nro_serie;
                                                 listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                 listaregi.activo = nw.activo;
                                                 listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                 listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                 listaregi.unidad_organica = nw.unidad_organica;
                                                 listaregi.area = nw.area;
                                                 listaregi.funcionamiento = nw.funcionamiento;
                                                 listaregi.observacion = nw.observacion;
                                                 listaregi.procesador = nw.procesador;
                                                 listaregi.estado = nw.estado;
                                                 listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                 listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                 lista.Add(listaregi);
                                             }

                                         }

                                            
                                            

                                        dg.DataSource = lista;
                                        for (int i = 0; i < dg.Rows.Count; i++)
                                        {
                                            lstAsignacion.Add(new CAsignacionEqui
                                            {
                                                categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                area = dg.Rows[i].Cells[14].Value.ToString(),
                                                funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                estado = dg.Rows[i].Cells[18].Value.ToString()
                                            });
                                        }


                                        rs.Name = "DataSet11";
                                        rs.Value = lista;
                                        Asignacion_equipo frm = new Asignacion_equipo();

                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                        frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                        frm.rvAsignacionEquipo.LocalReport.Refresh();
                                        frm.groupBox1.Visible = false;

                                        frm.ShowDialog();
                                        #endregion
                                    }
                                    else
                                    {
                                        //mostrar todas las sedee, instancias y selecionar una categoria
                                        #region
                                        dg.AutoGenerateColumns = false;
                                        lstAsignacion.Clear();

                                        var lst = ((
                                          from T0 in db.Registros
                                          join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                          join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                          join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                          join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                          join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                          join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                          where (T2.cod_categoria == Convert.ToUInt32(comboBoxEx3.SelectedValue))
                                          && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                          orderby T5.nombre_completo, T2.categoria
                                          select new
                                          {
                                              categoria = T2.categoria,
                                              nombre_sede = T3.nombre_sede,
                                              nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                              nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                              perfil = T6.perfil,
                                              equipo = T1.equipo,
                                              marca = T1.marca,
                                              modelo = T1.modelo,
                                              nro_serie = T1.nro_serie,
                                              nro_control_patrimonial = T1.nro_control_patrimonial,
                                              activo = T1.activo,
                                              nro_orden_compra = T1.nro_orden_compra,
                                              anio_adquisicion = T1.anio_adquisicion,
                                              unidad_organica = T5.unidad_organica,
                                              area = T5.area,
                                              funcionamiento = T1.funcionamiento,
                                              observacion = T1.observacion,
                                              procesador = T1.procesador,
                                              estado = T1.estado,
                                              cod_equipo = T1.cod_equipo,
                                              equipoPadreCod = T1.equipoPadreCod,
                                          }).Union(
                                            from T0 in db.Registros
                                            join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                            join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                            join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                            //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                            join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                            join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                            where T5.c_instancia == "0" && (T2.cod_categoria == Convert.ToUInt32(comboBoxEx3.SelectedValue))
                                            && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                            
                                            orderby T5.nombre_completo, T2.categoria
                                            select new
                                            {
                                                categoria = T2.categoria,
                                                nombre_sede = T3.nombre_sede,
                                                nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                perfil = T6.perfil,
                                                equipo = T1.equipo,
                                                marca = T1.marca,
                                                modelo = T1.modelo,
                                                nro_serie = T1.nro_serie,
                                                nro_control_patrimonial = T1.nro_control_patrimonial,
                                                activo = T1.activo,
                                                nro_orden_compra = T1.nro_orden_compra,
                                                anio_adquisicion = T1.anio_adquisicion,
                                                unidad_organica = T5.unidad_organica,
                                                area = T5.area,
                                                funcionamiento = T1.funcionamiento,
                                                observacion = T1.observacion,
                                                procesador = T1.procesador,
                                                estado = T1.estado,
                                                cod_equipo = T1.cod_equipo,
                                                equipoPadreCod = T1.equipoPadreCod,
                                            })).ToList();

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

                                        //recorrer lst e insertar lst_comp 
                                        List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();
                                            if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                            {
                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                                foreach (var lcom in lst_comp)
                                                {
                                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                    {
                                                        CAsignacionEqui componente = new CAsignacionEqui();

                                                        componente.categoria = lcom.categoria;
                                                        componente.nombre_sede = lcom.nombre_sede;
                                                        componente.nombre_instancia = lcom.nombre_instancia;
                                                        componente.nombre = lcom.nombre;
                                                        componente.perfil = lcom.perfil;
                                                        componente.equipo = lcom.equipo;
                                                        componente.marca = lcom.marca;
                                                        componente.modelo = lcom.modelo;
                                                        componente.nro_serie = lcom.nro_serie;
                                                        componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                        componente.activo = lcom.activo;
                                                        componente.nro_orden_compra = lcom.nro_orden_compra;
                                                        componente.anio_adquisicion = lcom.anio_adquisicion;
                                                        componente.unidad_organica = lcom.unidad_organica;
                                                        componente.area = lcom.area;
                                                        componente.funcionamiento = lcom.funcionamiento;
                                                        componente.observacion = lcom.observacion;
                                                        componente.procesador = lcom.procesador;
                                                        componente.estado = lcom.estado;
                                                        componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                        componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                        lista.Add(componente);

                                                    }
                                                }
                                            }

                                        }
                                        //agregar componentes de TREGISTRO que no tengan padre
                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();

                                            if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                            {

                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                            }

                                        }




                                        dg.DataSource = lista;
                                       

                                       
                                        for (int i = 0; i < dg.Rows.Count; i++)
                                        {
                                            lstAsignacion.Add(new CAsignacionEqui
                                            {
                                                categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                area = dg.Rows[i].Cells[14].Value.ToString(),
                                                funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                estado = dg.Rows[i].Cells[18].Value.ToString()
                                            });
                                        }


                                        rs.Name = "DataSet11";
                                        rs.Value = lista;
                                        Asignacion_equipo frm = new Asignacion_equipo();

                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                        frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                        frm.rvAsignacionEquipo.LocalReport.Refresh();
                                        frm.groupBox1.Visible = false;

                                        frm.ShowDialog();
                                        #endregion
                                    }

                                }
                                else
                                {
                                    if (Convert.ToString(comboBoxEx3.SelectedValue) == "0")//si combo3 es ***todos***
                                    {
                                        //filtar por instancia
                                        #region

                                        dg.AutoGenerateColumns = false;
                                        lstAsignacion.Clear();

                                        var lst = ((
                                         from T0 in db.Registros
                                         join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                         join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                         join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                         join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                         join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                         join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                         where (T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue))
                                         && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                         orderby T5.nombre_completo, T2.categoria
                                         select new
                                         {
                                             categoria = T2.categoria,
                                             nombre_sede = T3.nombre_sede,
                                             nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                             nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                             perfil = T6.perfil,
                                             equipo = T1.equipo,
                                             marca = T1.marca,
                                             modelo = T1.modelo,
                                             nro_serie = T1.nro_serie,
                                             nro_control_patrimonial = T1.nro_control_patrimonial,
                                             activo = T1.activo,
                                             nro_orden_compra = T1.nro_orden_compra,
                                             anio_adquisicion = T1.anio_adquisicion,
                                             unidad_organica = T5.unidad_organica,
                                             area = T5.area,
                                             funcionamiento = T1.funcionamiento,
                                             observacion = T1.observacion,
                                             procesador = T1.procesador,
                                             estado = T1.estado,
                                             cod_equipo = T1.cod_equipo,
                                             equipoPadreCod = T1.equipoPadreCod,

                                         }).Union(
                                           from T0 in db.Registros
                                           join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                           join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                           join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                           //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                           join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                           join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                           where T5.c_instancia == "0" && (T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue))
                                          && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                           orderby T5.nombre_completo, T2.categoria

                                           select new
                                           {
                                               categoria = T2.categoria,
                                               nombre_sede = T3.nombre_sede,
                                               nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                               nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                               perfil = T6.perfil,
                                               equipo = T1.equipo,
                                               marca = T1.marca,
                                               modelo = T1.modelo,
                                               nro_serie = T1.nro_serie,
                                               nro_control_patrimonial = T1.nro_control_patrimonial,
                                               activo = T1.activo,
                                               nro_orden_compra = T1.nro_orden_compra,
                                               anio_adquisicion = T1.anio_adquisicion,
                                               unidad_organica = T5.unidad_organica,
                                               area = T5.area,
                                               funcionamiento = T1.funcionamiento,
                                               observacion = T1.observacion,
                                               procesador = T1.procesador,
                                               estado = T1.estado,
                                               cod_equipo = T1.cod_equipo,
                                               equipoPadreCod = T1.equipoPadreCod,
                                           })).ToList();



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

                                        //recorrer lst e insertar lst_comp 
                                        List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();
                                            if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                            {
                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                                foreach (var lcom in lst_comp)
                                                {
                                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                    {
                                                        CAsignacionEqui componente = new CAsignacionEqui();

                                                        componente.categoria = lcom.categoria;
                                                        componente.nombre_sede = lcom.nombre_sede;
                                                        componente.nombre_instancia = lcom.nombre_instancia;
                                                        componente.nombre = lcom.nombre;
                                                        componente.perfil = lcom.perfil;
                                                        componente.equipo = lcom.equipo;
                                                        componente.marca = lcom.marca;
                                                        componente.modelo = lcom.modelo;
                                                        componente.nro_serie = lcom.nro_serie;
                                                        componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                        componente.activo = lcom.activo;
                                                        componente.nro_orden_compra = lcom.nro_orden_compra;
                                                        componente.anio_adquisicion = lcom.anio_adquisicion;
                                                        componente.unidad_organica = lcom.unidad_organica;
                                                        componente.area = lcom.area;
                                                        componente.funcionamiento = lcom.funcionamiento;
                                                        componente.observacion = lcom.observacion;
                                                        componente.procesador = lcom.procesador;
                                                        componente.estado = lcom.estado;
                                                        componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                        componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                        lista.Add(componente);

                                                    }
                                                }
                                            }

                                        }

                                        //agregar componentes de TREGISTRO que no tengan padre
                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();

                                            if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                            {

                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                            }

                                        }



                                        dg.DataSource = lista;

                                        
                                        for (int i = 0; i < dg.Rows.Count; i++)
                                        {
                                            lstAsignacion.Add(new CAsignacionEqui
                                            {
                                                categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                area = dg.Rows[i].Cells[14].Value.ToString(),
                                                funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                estado = dg.Rows[i].Cells[18].Value.ToString()
                                            });
                                        }


                                        rs.Name = "DataSet11";
                                        rs.Value = lista;
                                        Asignacion_equipo frm = new Asignacion_equipo();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                        frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                        frm.groupBox1.Visible = false;
                                        frm.ShowDialog();
                                        #endregion
                                    }
                                    else
                                    {
                                        #region
                                        //filtar por instancia
                                        dg.AutoGenerateColumns = false;
                                        lstAsignacion.Clear();

                                        var lst = ((
                                     from T0 in db.Registros
                                     join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                     join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                     join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                     join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                     join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                     join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                     where T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue) && (T2.cod_categoria == Convert.ToInt32(comboBoxEx3.SelectedValue))
                                     && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                    
                                     orderby T5.nombre_completo, T2.categoria

                                     select new
                                     {
                                         categoria = T2.categoria,
                                         nombre_sede = T3.nombre_sede,
                                         nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                         nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                         perfil = T6.perfil,
                                         equipo = T1.equipo,
                                         marca = T1.marca,
                                         modelo = T1.modelo,
                                         nro_serie = T1.nro_serie,
                                         nro_control_patrimonial = T1.nro_control_patrimonial,
                                         activo = T1.activo,
                                         nro_orden_compra = T1.nro_orden_compra,
                                         anio_adquisicion = T1.anio_adquisicion,
                                         unidad_organica = T5.unidad_organica,
                                         area = T5.area,
                                         funcionamiento = T1.funcionamiento,
                                         observacion = T1.observacion,
                                         procesador = T1.procesador,
                                         estado = T1.estado,
                                         cod_equipo = T1.cod_equipo,
                                         equipoPadreCod = T1.equipoPadreCod,

                                     }).Union(
                                       from T0 in db.Registros
                                       join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                       join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                       join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                       //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                       join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                       join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                       where T5.c_instancia == "0" && T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx3.SelectedValue)
                                       && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                       orderby T5.nombre_completo, T2.categoria

                                       select new
                                       {
                                           categoria = T2.categoria,
                                           nombre_sede = T3.nombre_sede,
                                           nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                           nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                           perfil = T6.perfil,
                                           equipo = T1.equipo,
                                           marca = T1.marca,
                                           modelo = T1.modelo,
                                           nro_serie = T1.nro_serie,
                                           nro_control_patrimonial = T1.nro_control_patrimonial,
                                           activo = T1.activo,
                                           nro_orden_compra = T1.nro_orden_compra,
                                           anio_adquisicion = T1.anio_adquisicion,
                                           unidad_organica = T5.unidad_organica,
                                           area = T5.area,
                                           funcionamiento = T1.funcionamiento,
                                           observacion = T1.observacion,
                                           procesador = T1.procesador,
                                           estado = T1.estado,
                                           cod_equipo = T1.cod_equipo,
                                           equipoPadreCod = T1.equipoPadreCod,
                                       })).ToList();
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

                                        //recorrer lst e insertar lst_comp 
                                        List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();
                                            if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                            {
                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                                foreach (var lcom in lst_comp)
                                                {
                                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                    {
                                                        CAsignacionEqui componente = new CAsignacionEqui();

                                                        componente.categoria = lcom.categoria;
                                                        componente.nombre_sede = lcom.nombre_sede;
                                                        componente.nombre_instancia = lcom.nombre_instancia;
                                                        componente.nombre = lcom.nombre;
                                                        componente.perfil = lcom.perfil;
                                                        componente.equipo = lcom.equipo;
                                                        componente.marca = lcom.marca;
                                                        componente.modelo = lcom.modelo;
                                                        componente.nro_serie = lcom.nro_serie;
                                                        componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                        componente.activo = lcom.activo;
                                                        componente.nro_orden_compra = lcom.nro_orden_compra;
                                                        componente.anio_adquisicion = lcom.anio_adquisicion;
                                                        componente.unidad_organica = lcom.unidad_organica;
                                                        componente.area = lcom.area;
                                                        componente.funcionamiento = lcom.funcionamiento;
                                                        componente.observacion = lcom.observacion;
                                                        componente.procesador = lcom.procesador;
                                                        componente.estado = lcom.estado;
                                                        componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                        componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                        lista.Add(componente);

                                                    }
                                                }
                                            }

                                        }
                                        //agregar componentes de TREGISTRO que no tengan padre
                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();

                                            if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                            {

                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                            }

                                        }





                                        dg.DataSource = lista;

                                        
                                        for (int i = 0; i < dg.Rows.Count; i++)
                                        {
                                            lstAsignacion.Add(new CAsignacionEqui
                                            {
                                                categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                area = dg.Rows[i].Cells[14].Value.ToString(),
                                                funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                estado = dg.Rows[i].Cells[18].Value.ToString()
                                            });
                                        }


                                        rs.Name = "DataSet11";
                                        rs.Value = lista;
                                        Asignacion_equipo frm = new Asignacion_equipo();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                        frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                        frm.groupBox1.Visible = false;
                                        frm.ShowDialog();
                                        #endregion
                                    }
                                }
                            }
                            else
                            {
                                if (Convert.ToInt32(comboBoxEx2.SelectedValue) == 0)
                                {

                                    if (Convert.ToString(comboBoxEx3.SelectedValue) == "0")
                                    {
                                        //filtrar por sede                 
                                        #region

                                        dg.AutoGenerateColumns = false;
                                        lstAsignacion.Clear();

                                        var lst = ((
                                         from T0 in db.Registros
                                         join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                         join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                         join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                         join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                         join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                         join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                         where T5.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue)
                                        && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (Convert.ToInt32(tbAnioAntig.Text)))
                                         orderby T5.nombre_completo, T2.categoria

                                         select new
                                         {
                                             categoria = T2.categoria,
                                             nombre_sede = T3.nombre_sede,
                                             nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                             nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                             perfil = T6.perfil,
                                             equipo = T1.equipo,
                                             marca = T1.marca,
                                             modelo = T1.modelo,
                                             nro_serie = T1.nro_serie,
                                             nro_control_patrimonial = T1.nro_control_patrimonial,
                                             activo = T1.activo,
                                             nro_orden_compra = T1.nro_orden_compra,
                                             anio_adquisicion = T1.anio_adquisicion,
                                             unidad_organica = T5.unidad_organica,
                                             area = T5.area,
                                             funcionamiento = T1.funcionamiento,
                                             observacion = T1.observacion,
                                             procesador = T1.procesador,
                                             estado = T1.estado,
                                             cod_equipo = T1.cod_equipo,
                                             equipoPadreCod = T1.equipoPadreCod,
                                         }).Union(
                                           from T0 in db.Registros
                                           join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                           join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                           join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                           //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                           join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                           join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                           where T5.c_instancia == "0" && T5.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue)
                                          && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= Convert.ToInt32(tbAnioAntig.Text))
                                           orderby T5.nombre_completo, T2.categoria
                                           select new
                                           {
                                               categoria = T2.categoria,
                                               nombre_sede = T3.nombre_sede,
                                               nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                               nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                               perfil = T6.perfil,
                                               equipo = T1.equipo,
                                               marca = T1.marca,
                                               modelo = T1.modelo,
                                               nro_serie = T1.nro_serie,
                                               nro_control_patrimonial = T1.nro_control_patrimonial,
                                               activo = T1.activo,
                                               nro_orden_compra = T1.nro_orden_compra,
                                               anio_adquisicion = T1.anio_adquisicion,
                                               unidad_organica = T5.unidad_organica,
                                               area = T5.area,
                                               funcionamiento = T1.funcionamiento,
                                               observacion = T1.observacion,
                                               procesador = T1.procesador,
                                               estado = T1.estado,
                                               cod_equipo = T1.cod_equipo,
                                               equipoPadreCod = T1.equipoPadreCod,
                                           })).ToList();

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

                                        //recorrer lst e insertar lst_comp 
                                        List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();
                                            if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                            {
                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                                foreach (var lcom in lst_comp)
                                                {
                                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                    {
                                                        CAsignacionEqui componente = new CAsignacionEqui();

                                                        componente.categoria = lcom.categoria;
                                                        componente.nombre_sede = lcom.nombre_sede;
                                                        componente.nombre_instancia = lcom.nombre_instancia;
                                                        componente.nombre = lcom.nombre;
                                                        componente.perfil = lcom.perfil;
                                                        componente.equipo = lcom.equipo;
                                                        componente.marca = lcom.marca;
                                                        componente.modelo = lcom.modelo;
                                                        componente.nro_serie = lcom.nro_serie;
                                                        componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                        componente.activo = lcom.activo;
                                                        componente.nro_orden_compra = lcom.nro_orden_compra;
                                                        componente.anio_adquisicion = lcom.anio_adquisicion;
                                                        componente.unidad_organica = lcom.unidad_organica;
                                                        componente.area = lcom.area;
                                                        componente.funcionamiento = lcom.funcionamiento;
                                                        componente.observacion = lcom.observacion;
                                                        componente.procesador = lcom.procesador;
                                                        componente.estado = lcom.estado;
                                                        componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                        componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                        lista.Add(componente);

                                                    }
                                                }

                                            }

                                        }

                                        //agregar componentes de TREGISTRO que no tengan padre
                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();

                                            if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                            {

                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                            }

                                        }



                                        dg.DataSource = lista;

                                     
                                        for (int i = 0; i < dg.Rows.Count; i++)
                                        {
                                            lstAsignacion.Add(new CAsignacionEqui
                                            {
                                                categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                area = dg.Rows[i].Cells[14].Value.ToString(),
                                                funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                estado = dg.Rows[i].Cells[18].Value.ToString()

                                            });
                                        }


                                        rs.Name = "DataSet11";
                                        rs.Value = lista;
                                        Asignacion_equipo frm = new Asignacion_equipo();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                        frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";

                                        frm.groupBox1.Visible = false;
                                        frm.ShowDialog();
                                        #endregion
                                    }

                                    //--------
                                    else
                                    {
                                        //filtrar por sede y categoria
                                        #region


                                        dg.AutoGenerateColumns = false;
                                        lstAsignacion.Clear();

                                        var lst = ((
                                           from T0 in db.Registros
                                           join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                           join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                           join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                           join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                           join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                           join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                           where T5.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx3.SelectedValue)
                                           && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                           orderby T5.nombre_completo, T2.categoria

                                           select new
                                           {
                                               categoria = T2.categoria,
                                               nombre_sede = T3.nombre_sede,
                                               nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                               nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                               perfil = T6.perfil,
                                               equipo = T1.equipo,
                                               marca = T1.marca,
                                               modelo = T1.modelo,
                                               nro_serie = T1.nro_serie,
                                               nro_control_patrimonial = T1.nro_control_patrimonial,
                                               activo = T1.activo,
                                               nro_orden_compra = T1.nro_orden_compra,
                                               anio_adquisicion = T1.anio_adquisicion,
                                               unidad_organica = T5.unidad_organica,
                                               area = T5.area,
                                               funcionamiento = T1.funcionamiento,
                                               observacion = T1.observacion,
                                               procesador = T1.procesador,
                                               estado = T1.estado,
                                               cod_equipo = T1.cod_equipo,
                                               equipoPadreCod = T1.equipoPadreCod,

                                           }).Union(
                                             from T0 in db.Registros
                                             join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                             join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                             join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                             //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                             join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                             join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                             where T5.c_instancia == "0" && T5.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx3.SelectedValue)
                                             && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                             orderby T5.nombre_completo, T2.categoria
                                             select new
                                             {
                                                 categoria = T2.categoria,
                                                 nombre_sede = T3.nombre_sede,
                                                 nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                 nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                 perfil = T6.perfil,
                                                 equipo = T1.equipo,
                                                 marca = T1.marca,
                                                 modelo = T1.modelo,
                                                 nro_serie = T1.nro_serie,
                                                 nro_control_patrimonial = T1.nro_control_patrimonial,
                                                 activo = T1.activo,
                                                 nro_orden_compra = T1.nro_orden_compra,
                                                 anio_adquisicion = T1.anio_adquisicion,
                                                 unidad_organica = T5.unidad_organica,
                                                 area = T5.area,
                                                 funcionamiento = T1.funcionamiento,
                                                 observacion = T1.observacion,
                                                 procesador = T1.procesador,
                                                 estado = T1.estado,
                                                 cod_equipo = T1.cod_equipo,
                                                 equipoPadreCod = T1.equipoPadreCod,
                                             })).ToList();

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

                                        //recorrer lst e insertar lst_comp 
                                        List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();
                                            if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                            {
                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                                foreach (var lcom in lst_comp)
                                                {
                                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                    {
                                                        CAsignacionEqui componente = new CAsignacionEqui();

                                                        componente.categoria = lcom.categoria;
                                                        componente.nombre_sede = lcom.nombre_sede;
                                                        componente.nombre_instancia = lcom.nombre_instancia;
                                                        componente.nombre = lcom.nombre;
                                                        componente.perfil = lcom.perfil;
                                                        componente.equipo = lcom.equipo;
                                                        componente.marca = lcom.marca;
                                                        componente.modelo = lcom.modelo;
                                                        componente.nro_serie = lcom.nro_serie;
                                                        componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                        componente.activo = lcom.activo;
                                                        componente.nro_orden_compra = lcom.nro_orden_compra;
                                                        componente.anio_adquisicion = lcom.anio_adquisicion;
                                                        componente.unidad_organica = lcom.unidad_organica;
                                                        componente.area = lcom.area;
                                                        componente.funcionamiento = lcom.funcionamiento;
                                                        componente.observacion = lcom.observacion;
                                                        componente.procesador = lcom.procesador;
                                                        componente.estado = lcom.estado;
                                                        componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                        componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                        lista.Add(componente);

                                                    }
                                                }
                                            }
                                           
                                        }

                                        //agregar componentes de TREGISTRO que no tengan padre
                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();

                                            if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                            {

                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                            }

                                        }




                                        dg.DataSource = lista;
                                        
                                        for (int i = 0; i < dg.Rows.Count; i++)
                                        {
                                            lstAsignacion.Add(new CAsignacionEqui
                                            {
                                                categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                area = dg.Rows[i].Cells[14].Value.ToString(),
                                                funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                estado = dg.Rows[i].Cells[18].Value.ToString()
                                            });
                                        }


                                        rs.Name = "DataSet11";
                                        rs.Value = lista;
                                        Asignacion_equipo frm = new Asignacion_equipo();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                        frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";

                                        frm.groupBox1.Visible = false;
                                        frm.ShowDialog();
                                        #endregion

                                    }

                                    //---
                                }

                                else
                                {

                                    if (Convert.ToString(comboBoxEx3.SelectedValue) == "0")
                                    {//filtrar por sede  e instancia
                                        #region

                                        dg.AutoGenerateColumns = false;
                                        lstAsignacion.Clear();

                                        var lst = ((
                                     from T0 in db.Registros
                                     join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                     join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                     join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                     join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                     join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                     join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                     where T5.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue) && T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue)
                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                     orderby T5.nombre_completo, T2.categoria

                                     select new
                                     {
                                         categoria = T2.categoria,
                                         nombre_sede = T3.nombre_sede,
                                         nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                         nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                         perfil = T6.perfil,
                                         equipo = T1.equipo,
                                         marca = T1.marca,
                                         modelo = T1.modelo,
                                         nro_serie = T1.nro_serie,
                                         nro_control_patrimonial = T1.nro_control_patrimonial,
                                         activo = T1.activo,
                                         nro_orden_compra = T1.nro_orden_compra,
                                         anio_adquisicion = T1.anio_adquisicion,
                                         unidad_organica = T5.unidad_organica,
                                         area = T5.area,
                                         funcionamiento = T1.funcionamiento,
                                         observacion = T1.observacion,
                                         procesador = T1.procesador,
                                         estado = T1.estado,
                                         cod_equipo = T1.cod_equipo,
                                         equipoPadreCod = T1.equipoPadreCod,
                                     }).Union(
                                       from T0 in db.Registros
                                       join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                       join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                       join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                       //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                       join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                       join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                       where T5.c_instancia == "0" && T5.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue) && T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue)
                                       && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                       orderby T5.nombre_completo, T2.categoria
                                       select new
                                       {
                                           categoria = T2.categoria,
                                           nombre_sede = T3.nombre_sede,
                                           nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                           nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                           perfil = T6.perfil,
                                           equipo = T1.equipo,
                                           marca = T1.marca,
                                           modelo = T1.modelo,
                                           nro_serie = T1.nro_serie,
                                           nro_control_patrimonial = T1.nro_control_patrimonial,
                                           activo = T1.activo,
                                           nro_orden_compra = T1.nro_orden_compra,
                                           anio_adquisicion = T1.anio_adquisicion,
                                           unidad_organica = T5.unidad_organica,
                                           area = T5.area,
                                           funcionamiento = T1.funcionamiento,
                                           observacion = T1.observacion,
                                           procesador = T1.procesador,
                                           estado = T1.estado,
                                           cod_equipo = T1.cod_equipo,
                                           equipoPadreCod = T1.equipoPadreCod,
                                       })).ToList();


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

                                        //recorrer lst e insertar lst_comp 
                                        List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();
                                            if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                            {

                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                                foreach (var lcom in lst_comp)
                                                {
                                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                    {
                                                        CAsignacionEqui componente = new CAsignacionEqui();

                                                        componente.categoria = lcom.categoria;
                                                        componente.nombre_sede = lcom.nombre_sede;
                                                        componente.nombre_instancia = lcom.nombre_instancia;
                                                        componente.nombre = lcom.nombre;
                                                        componente.perfil = lcom.perfil;
                                                        componente.equipo = lcom.equipo;
                                                        componente.marca = lcom.marca;
                                                        componente.modelo = lcom.modelo;
                                                        componente.nro_serie = lcom.nro_serie;
                                                        componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                        componente.activo = lcom.activo;
                                                        componente.nro_orden_compra = lcom.nro_orden_compra;
                                                        componente.anio_adquisicion = lcom.anio_adquisicion;
                                                        componente.unidad_organica = lcom.unidad_organica;
                                                        componente.area = lcom.area;
                                                        componente.funcionamiento = lcom.funcionamiento;
                                                        componente.observacion = lcom.observacion;
                                                        componente.procesador = lcom.procesador;
                                                        componente.estado = lcom.estado;
                                                        componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                        componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                        lista.Add(componente);

                                                    }
                                                }
                                            }
                                        }
                                        //agregar componentes de TREGISTRO que no tengan padre
                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();

                                            if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                            {

                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                            }

                                        }





                                        dg.DataSource = lista;

                                        
                                        for (int i = 0; i < dg.Rows.Count; i++)
                                        {
                                            lstAsignacion.Add(new CAsignacionEqui
                                            {
                                                categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                area = dg.Rows[i].Cells[14].Value.ToString(),
                                                funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                estado = dg.Rows[i].Cells[18].Value.ToString()
                                            });
                                        }


                                        rs.Name = "DataSet11";
                                        rs.Value = lista;
                                        Asignacion_equipo frm = new Asignacion_equipo();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                        frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                        frm.groupBox1.Visible = false;
                                        frm.ShowDialog();
                                        #endregion
                                    }
                                    else
                                    {
                                        //filtrar por sede  e instancia categoria
                                        #region

                                        dg.AutoGenerateColumns = false;
                                        lstAsignacion.Clear();

                                        var lst = ((
                                                                from T0 in db.Registros
                                                                join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                                join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                                join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                                join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                                join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                                join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                                where T5.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue) && T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx3.SelectedValue)
                                                                && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                                orderby T5.nombre_completo, T2.categoria

                                                                select new
                                                                {
                                                                    categoria = T2.categoria,
                                                                    nombre_sede = T3.nombre_sede,
                                                                    nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                                    nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                                    perfil = T6.perfil,
                                                                    equipo = T1.equipo,
                                                                    marca = T1.marca,
                                                                    modelo = T1.modelo,
                                                                    nro_serie = T1.nro_serie,
                                                                    nro_control_patrimonial = T1.nro_control_patrimonial,
                                                                    activo = T1.activo,
                                                                    nro_orden_compra = T1.nro_orden_compra,
                                                                    anio_adquisicion = T1.anio_adquisicion,
                                                                    unidad_organica = T5.unidad_organica,
                                                                    area = T5.area,
                                                                    funcionamiento = T1.funcionamiento,
                                                                    observacion = T1.observacion,
                                                                    procesador = T1.procesador,
                                                                    estado = T1.estado,
                                                                    cod_equipo = T1.cod_equipo,
                                                                    equipoPadreCod = T1.equipoPadreCod,


                                                                }).Union(
                                                                  from T0 in db.Registros
                                                                  join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                                  join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                                  join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                                  //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                                  join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                                  join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                                  where T5.c_instancia == "0" && T5.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue) && T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx3.SelectedValue)
                                                                  && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                                  orderby T5.nombre_completo, T2.categoria
                                                                  select new
                                                                  {
                                                                      categoria = T2.categoria,
                                                                      nombre_sede = T3.nombre_sede,
                                                                      nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                                      nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                                      perfil = T6.perfil,
                                                                      equipo = T1.equipo,
                                                                      marca = T1.marca,
                                                                      modelo = T1.modelo,
                                                                      nro_serie = T1.nro_serie,
                                                                      nro_control_patrimonial = T1.nro_control_patrimonial,
                                                                      activo = T1.activo,
                                                                      nro_orden_compra = T1.nro_orden_compra,
                                                                      anio_adquisicion = T1.anio_adquisicion,
                                                                      unidad_organica = T5.unidad_organica,
                                                                      area = T5.area,
                                                                      funcionamiento = T1.funcionamiento,
                                                                      observacion = T1.observacion,
                                                                      procesador = T1.procesador,
                                                                      estado = T1.estado,
                                                                      cod_equipo = T1.cod_equipo,
                                                                      equipoPadreCod = T1.equipoPadreCod,

                                                                  })).ToList();

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

                                        //recorrer lst e insertar lst_comp 
                                        List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();
                                            if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                            {
                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                                foreach (var lcom in lst_comp)
                                                {
                                                    if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                    {
                                                        CAsignacionEqui componente = new CAsignacionEqui();

                                                        componente.categoria = lcom.categoria;
                                                        componente.nombre_sede = lcom.nombre_sede;
                                                        componente.nombre_instancia = lcom.nombre_instancia;
                                                        componente.nombre = lcom.nombre;
                                                        componente.perfil = lcom.perfil;
                                                        componente.equipo = lcom.equipo;
                                                        componente.marca = lcom.marca;
                                                        componente.modelo = lcom.modelo;
                                                        componente.nro_serie = lcom.nro_serie;
                                                        componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                        componente.activo = lcom.activo;
                                                        componente.nro_orden_compra = lcom.nro_orden_compra;
                                                        componente.anio_adquisicion = lcom.anio_adquisicion;
                                                        componente.unidad_organica = lcom.unidad_organica;
                                                        componente.area = lcom.area;
                                                        componente.funcionamiento = lcom.funcionamiento;
                                                        componente.observacion = lcom.observacion;
                                                        componente.procesador = lcom.procesador;
                                                        componente.estado = lcom.estado;
                                                        componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                        componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                        lista.Add(componente);

                                                    }
                                                }
                                            }
                                           
                                        }
                                        //agregar componentes de TREGISTRO que no tengan padre
                                        foreach (var nw in lst)
                                        {
                                            CAsignacionEqui listaregi = new CAsignacionEqui();

                                            if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                            {

                                                listaregi.categoria = nw.categoria;
                                                listaregi.nombre_sede = nw.nombre_sede;
                                                listaregi.nombre_instancia = nw.nombre_instancia;
                                                listaregi.nombre = nw.nombre;
                                                listaregi.perfil = nw.perfil;
                                                listaregi.equipo = nw.equipo;
                                                listaregi.marca = nw.marca;
                                                listaregi.modelo = nw.modelo;
                                                listaregi.nro_serie = nw.nro_serie;
                                                listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                listaregi.activo = nw.activo;
                                                listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                listaregi.unidad_organica = nw.unidad_organica;
                                                listaregi.area = nw.area;
                                                listaregi.funcionamiento = nw.funcionamiento;
                                                listaregi.observacion = nw.observacion;
                                                listaregi.procesador = nw.procesador;
                                                listaregi.estado = nw.estado;
                                                listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                lista.Add(listaregi);
                                            }

                                        }





                                        dg.DataSource = lista;

                                        
                                        for (int i = 0; i < dg.Rows.Count; i++)
                                        {
                                            lstAsignacion.Add(new CAsignacionEqui
                                            {
                                                categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                area = dg.Rows[i].Cells[14].Value.ToString(),
                                                funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                estado = dg.Rows[i].Cells[18].Value.ToString()
                                            });
                                        }


                                        rs.Name = "DataSet11";
                                        rs.Value = lista;
                                        Asignacion_equipo frm = new Asignacion_equipo();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                        frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                        frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                        frm.groupBox1.Visible = false;
                                        frm.ShowDialog();
                                        #endregion
                                    }

                                }
                            }

                            #endregion
                        }

                        else if (rbRegTodos.Checked)
                        {
                            #region
                            dg.AutoGenerateColumns = false;
                            lstAsignacion.Clear();
                            var lst = ((
                                    from T0 in db.Registros
                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                    where (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ?0:Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty?0:Convert.ToInt32(tbAnioAntig.Text)))
                                    orderby T5.nombre_completo, T2.categoria
                                    select new
                                    {
                                        categoria = T2.categoria,
                                        nombre_sede = T3.nombre_sede,
                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                        perfil = T6.perfil,
                                        equipo = T1.equipo,
                                        marca = T1.marca,
                                        modelo = T1.modelo,
                                        nro_serie = T1.nro_serie,
                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                        activo = T1.activo,
                                        nro_orden_compra = T1.nro_orden_compra,
                                        anio_adquisicion = T1.anio_adquisicion,
                                        unidad_organica = T5.unidad_organica,
                                        area = T5.area,
                                        funcionamiento = T1.funcionamiento,
                                        observacion = T1.observacion,
                                        procesador = T1.procesador,
                                        estado = T1.estado,
                                        cod_equipo = T1.cod_equipo,
                                        equipoPadreCod = T1.equipoPadreCod,
                                    }).Union(
                                      from T0 in db.Registros
                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                      where T5.c_instancia == "0"
                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                      orderby T5.nombre_completo, T2.categoria
                                      select new
                                      {
                                          categoria = T2.categoria,
                                          nombre_sede = T3.nombre_sede,
                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                          perfil = T6.perfil,
                                          equipo = T1.equipo,
                                          marca = T1.marca,
                                          modelo = T1.modelo,
                                          nro_serie = T1.nro_serie,
                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                          activo = T1.activo,
                                          nro_orden_compra = T1.nro_orden_compra,
                                          anio_adquisicion = T1.anio_adquisicion,
                                          unidad_organica = T5.unidad_organica,
                                          area = T5.area,
                                          funcionamiento = T1.funcionamiento,
                                          observacion = T1.observacion,
                                          procesador = T1.procesador,
                                          estado = T1.estado,
                                          cod_equipo = T1.cod_equipo,
                                          equipoPadreCod = T1.equipoPadreCod,
                                      })).ToList();
                            //var lstrest = lst.Union(lst2).ToList();

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

                            //recorrer lst e insertar lst_comp 
                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                            foreach (var nw in lst)
                            {
                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                {
                                    listaregi.categoria = nw.categoria;
                                    listaregi.nombre_sede = nw.nombre_sede;
                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                    listaregi.nombre = nw.nombre;
                                    listaregi.perfil = nw.perfil;
                                    listaregi.equipo = nw.equipo;
                                    listaregi.marca = nw.marca;
                                    listaregi.modelo = nw.modelo;
                                    listaregi.nro_serie = nw.nro_serie;
                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                    listaregi.activo = nw.activo;
                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                    listaregi.unidad_organica = nw.unidad_organica;
                                    listaregi.area = nw.area;
                                    listaregi.funcionamiento = nw.funcionamiento;
                                    listaregi.observacion = nw.observacion;
                                    listaregi.procesador = nw.procesador;
                                    listaregi.estado = nw.estado;
                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                    lista.Add(listaregi);
                                    foreach (var lcom in lst_comp)
                                    {
                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                        {
                                            CAsignacionEqui componente = new CAsignacionEqui();

                                            componente.categoria = lcom.categoria;
                                            componente.nombre_sede = lcom.nombre_sede;
                                            componente.nombre_instancia = lcom.nombre_instancia;
                                            componente.nombre = lcom.nombre;
                                            componente.perfil = lcom.perfil;
                                            componente.equipo = lcom.equipo;
                                            componente.marca = lcom.marca;
                                            componente.modelo = lcom.modelo;
                                            componente.nro_serie = lcom.nro_serie;
                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                            componente.activo = lcom.activo;
                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                            componente.unidad_organica = lcom.unidad_organica;
                                            componente.area = lcom.area;
                                            componente.funcionamiento = lcom.funcionamiento;
                                            componente.observacion = lcom.observacion;
                                            componente.procesador = lcom.procesador;
                                            componente.estado = lcom.estado;
                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                            lista.Add(componente);

                                        }
                                    }
                                }
                               
                            }
                            //agregar componentes de TREGISTRO que no tengan padre
                            foreach (var nw in lst)
                            {
                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                {

                                    listaregi.categoria = nw.categoria;
                                    listaregi.nombre_sede = nw.nombre_sede;
                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                    listaregi.nombre = nw.nombre;
                                    listaregi.perfil = nw.perfil;
                                    listaregi.equipo = nw.equipo;
                                    listaregi.marca = nw.marca;
                                    listaregi.modelo = nw.modelo;
                                    listaregi.nro_serie = nw.nro_serie;
                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                    listaregi.activo = nw.activo;
                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                    listaregi.unidad_organica = nw.unidad_organica;
                                    listaregi.area = nw.area;
                                    listaregi.funcionamiento = nw.funcionamiento;
                                    listaregi.observacion = nw.observacion;
                                    listaregi.procesador = nw.procesador;
                                    listaregi.estado = nw.estado;
                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                    lista.Add(listaregi);
                                }

                            }




                            dg.DataSource = lista;
                            
                            for (int i = 0; i < dg.Rows.Count; i++)
                            {
                                lstAsignacion.Add(new CAsignacionEqui
                                {
                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                });
                            }


                            rs.Name = "DataSet11";
                            rs.Value = lista;
                            Asignacion_equipo frm = new Asignacion_equipo();
                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                            frm.groupBox1.Visible = false;
                            frm.ShowDialog();
                            #endregion

                        }

                        else if (rbRegPorsona.Checked)
                        {
                            #region
                            dg.AutoGenerateColumns = false;
                            lstAsignacion.Clear();

                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.doc_entry_personal == Convert.ToInt32(comboBoxEx1.SelectedValue)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                 
                                                    orderby T5.nombre_completo, T2.categoria

                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && (T5.doc_entry_personal == Convert.ToInt32(comboBoxEx1.SelectedValue))
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,
                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,
                                                      })).ToList();

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

                            //recorrer lst e insertar lst_comp 
                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                            foreach (var nw in lst)
                            {
                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                {
                                    listaregi.categoria = nw.categoria;
                                    listaregi.nombre_sede = nw.nombre_sede;
                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                    listaregi.nombre = nw.nombre;
                                    listaregi.perfil = nw.perfil;
                                    listaregi.equipo = nw.equipo;
                                    listaregi.marca = nw.marca;
                                    listaregi.modelo = nw.modelo;
                                    listaregi.nro_serie = nw.nro_serie;
                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                    listaregi.activo = nw.activo;
                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                    listaregi.unidad_organica = nw.unidad_organica;
                                    listaregi.area = nw.area;
                                    listaregi.funcionamiento = nw.funcionamiento;
                                    listaregi.observacion = nw.observacion;
                                    listaregi.procesador = nw.procesador;
                                    listaregi.estado = nw.estado;
                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                    lista.Add(listaregi);
                                    foreach (var lcom in lst_comp)
                                    {
                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                        {
                                            CAsignacionEqui componente = new CAsignacionEqui();

                                            componente.categoria = lcom.categoria;
                                            componente.nombre_sede = lcom.nombre_sede;
                                            componente.nombre_instancia = lcom.nombre_instancia;
                                            componente.nombre = lcom.nombre;
                                            componente.perfil = lcom.perfil;
                                            componente.equipo = lcom.equipo;
                                            componente.marca = lcom.marca;
                                            componente.modelo = lcom.modelo;
                                            componente.nro_serie = lcom.nro_serie;
                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                            componente.activo = lcom.activo;
                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                            componente.unidad_organica = lcom.unidad_organica;
                                            componente.area = lcom.area;
                                            componente.funcionamiento = lcom.funcionamiento;
                                            componente.observacion = lcom.observacion;
                                            componente.procesador = lcom.procesador;
                                            componente.estado = lcom.estado;
                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                            lista.Add(componente);

                                        }
                                    }

                                }
                               
                            }
                            //agregar componentes de TREGISTRO que no tengan padre
                            foreach (var nw in lst)
                            {
                                 CAsignacionEqui listaregi = new CAsignacionEqui();
     
                                 if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                 {

                                     listaregi.categoria = nw.categoria;
                                     listaregi.nombre_sede = nw.nombre_sede;
                                     listaregi.nombre_instancia = nw.nombre_instancia;
                                     listaregi.nombre = nw.nombre;
                                     listaregi.perfil = nw.perfil;
                                     listaregi.equipo = nw.equipo;
                                     listaregi.marca = nw.marca;
                                     listaregi.modelo = nw.modelo;
                                     listaregi.nro_serie = nw.nro_serie;
                                     listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                     listaregi.activo = nw.activo;
                                     listaregi.nro_orden_compra = nw.nro_orden_compra;
                                     listaregi.anio_adquisicion = nw.anio_adquisicion;
                                     listaregi.unidad_organica = nw.unidad_organica;
                                     listaregi.area = nw.area;
                                     listaregi.funcionamiento = nw.funcionamiento;
                                     listaregi.observacion = nw.observacion;
                                     listaregi.procesador = nw.procesador;
                                     listaregi.estado = nw.estado;
                                     listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                     listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                     lista.Add(listaregi);
                                 }
 
                            }



                            dg.DataSource = lista;
                            
                            for (int i = 0; i < dg.Rows.Count; i++)
                            {
                                lstAsignacion.Add(new CAsignacionEqui
                                {
                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                });
                            }


                            rs.Name = "DataSet11";
                            rs.Value = lista;
                            Asignacion_equipo frm = new Asignacion_equipo();
                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                            frm.groupBox1.Visible = false;
                            frm.ShowDialog();
                            #endregion
                        }
                        else if (rbRegCategoria.Checked)
                        {
                            #region
                            dg.AutoGenerateColumns = false;
                            lstAsignacion.Clear();

                            var lst = ((
                                    from T0 in db.Registros
                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                    where T1.cod_categoria == Convert.ToInt32(comboBoxEx1.SelectedValue)
                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                    orderby T5.nombre_completo, T2.categoria

                                    select new
                                    {
                                        categoria = T2.categoria,
                                        nombre_sede = T3.nombre_sede,
                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                        perfil = T6.perfil,
                                        equipo = T1.equipo,
                                        marca = T1.marca,
                                        modelo = T1.modelo,
                                        nro_serie = T1.nro_serie,
                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                        activo = T1.activo,
                                        nro_orden_compra = T1.nro_orden_compra,
                                        anio_adquisicion = T1.anio_adquisicion,
                                        unidad_organica = T5.unidad_organica,
                                        area = T5.area,
                                        funcionamiento = T1.funcionamiento,
                                        observacion = T1.observacion,
                                        procesador = T1.procesador,
                                        estado = T1.estado,
                                        cod_equipo = T1.cod_equipo,
                                        equipoPadreCod = T1.equipoPadreCod,
                                    }).Union(
                                      from T0 in db.Registros
                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                      where T5.c_instancia == "0" && T1.cod_categoria == Convert.ToInt32(comboBoxEx1.SelectedValue)
                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                      orderby T5.nombre_completo, T2.categoria
                                      select new
                                      {
                                          categoria = T2.categoria,
                                          nombre_sede = T3.nombre_sede,
                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                          perfil = T6.perfil,
                                          equipo = T1.equipo,
                                          marca = T1.marca,
                                          modelo = T1.modelo,
                                          nro_serie = T1.nro_serie,
                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                          activo = T1.activo,
                                          nro_orden_compra = T1.nro_orden_compra,
                                          anio_adquisicion = T1.anio_adquisicion,
                                          unidad_organica = T5.unidad_organica,
                                          area = T5.area,
                                          funcionamiento = T1.funcionamiento,
                                          observacion = T1.observacion,
                                          procesador = T1.procesador,
                                          estado = T1.estado,
                                          cod_equipo = T1.cod_equipo,
                                          equipoPadreCod = T1.equipoPadreCod,
                                      })).ToList();

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

                            //recorrer lst e insertar lst_comp 
                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                            foreach (var nw in lst)
                            {
                                CAsignacionEqui listaregi = new CAsignacionEqui();
                               // if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                {
                                    listaregi.categoria = nw.categoria;
                                    listaregi.nombre_sede = nw.nombre_sede;
                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                    listaregi.nombre = nw.nombre;
                                    listaregi.perfil = nw.perfil;
                                    listaregi.equipo = nw.equipo;
                                    listaregi.marca = nw.marca;
                                    listaregi.modelo = nw.modelo;
                                    listaregi.nro_serie = nw.nro_serie;
                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                    listaregi.activo = nw.activo;
                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                    listaregi.unidad_organica = nw.unidad_organica;
                                    listaregi.area = nw.area;
                                    listaregi.funcionamiento = nw.funcionamiento;
                                    listaregi.observacion = nw.observacion;
                                    listaregi.procesador = nw.procesador;
                                    listaregi.estado = nw.estado;
                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                    lista.Add(listaregi);
                                    foreach (var lcom in lst_comp)
                                    {
                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                        {
                                            CAsignacionEqui componente = new CAsignacionEqui();
                                            var comp_reg = (from T0 in db.Registros where T0.cod_equipo == lcom.cod_equipo select T0).ToList();
                                            if (comp_reg.Count() <= 0)
                                            {
                                                componente.categoria = lcom.categoria;
                                                componente.nombre_sede = lcom.nombre_sede;
                                                componente.nombre_instancia = lcom.nombre_instancia;
                                                componente.nombre = lcom.nombre;
                                                componente.perfil = lcom.perfil;
                                                componente.equipo = lcom.equipo;
                                                componente.marca = lcom.marca;
                                                componente.modelo = lcom.modelo;
                                                componente.nro_serie = lcom.nro_serie;
                                                componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                componente.activo = lcom.activo;
                                                componente.nro_orden_compra = lcom.nro_orden_compra;
                                                componente.anio_adquisicion = lcom.anio_adquisicion;
                                                componente.unidad_organica = lcom.unidad_organica;
                                                componente.area = lcom.area;
                                                componente.funcionamiento = lcom.funcionamiento;
                                                componente.observacion = lcom.observacion;
                                                componente.procesador = lcom.procesador;
                                                componente.estado = lcom.estado;
                                                componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                lista.Add(componente);
                                            }
                                           

                                        }
                                    }
                                }
                                
                            }
                          




                            dg.DataSource = lista;

                          

                           
                            
                            for (int i = 0; i < dg.Rows.Count; i++)
                            {
                                lstAsignacion.Add(new CAsignacionEqui
                                {
                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                });
                            }


                            rs.Name = "DataSet11";
                            rs.Value = lista;
                            Asignacion_equipo frm = new Asignacion_equipo();
                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                            frm.groupBox1.Visible = false;
                            frm.ShowDialog();
                            #endregion

                        }
                        else if (rbEquip.Checked)
                        {
                            #region
                            dg.AutoGenerateColumns = false;
                            lstAsignacion.Clear();

                          
                            if (comboBoxEx1.Text != string.Empty)
                            {
                                //obtener codequipo
                                int pcod_equipo = Convert.ToInt32(comboBoxEx1.SelectedValue);
                                var nro_componente = (from T0 in db.Equipos where T0.cod_equipo == pcod_equipo && T0.cod_categoria == 7 select T0).ToList();
                                 //1verificar si es componente o no
                                if (nro_componente.Count() > 0)//es un componente
                                {
                                    MessageBox.Show("Es un comp");
                                    //identificar a su padre
                                    int cod_Padre = 0;
                                    var codPadre = (from T0 in db.Equipos where T0.cod_equipo == pcod_equipo && T0.cod_categoria == 7 select T0).ToList();
                                    cod_Padre =Convert.ToInt32(codPadre[0].equipoPadreCod);
                                    //ver si su cpu esta asignado
                                    //si elcpu esta asignado, mostrar datos del componente y mostrar datos de la persona responsable
                                    #region
                                    var lst = ((
                                                  from T0 in db.Registros
                                                  join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                  join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                  join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                  join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                  join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                  join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                  where T0.cod_equipo == cod_Padre
                                                  && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                  orderby T5.nombre_completo, T2.categoria

                                                  select new
                                                  {
                                                      categoria = "COMPONENTE",
                                                      nombre_sede = T3.nombre_sede,
                                                      nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                      nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                      perfil = T6.perfil,
                                                      equipo = nro_componente[0].equipo,
                                                      marca = nro_componente[0].marca,
                                                      modelo = nro_componente[0].modelo,
                                                      nro_serie = nro_componente[0].nro_serie,
                                                      nro_control_patrimonial = nro_componente[0].nro_control_patrimonial,
                                                      activo = nro_componente[0].activo,
                                                      nro_orden_compra = nro_componente[0].nro_orden_compra,
                                                      anio_adquisicion = nro_componente[0].anio_adquisicion,
                                                      unidad_organica = T5.unidad_organica,
                                                      area = T5.area,
                                                      funcionamiento = nro_componente[0].funcionamiento,
                                                      observacion = nro_componente[0].observacion,
                                                      procesador = nro_componente[0].procesador,
                                                      estado = nro_componente[0].estado,
                                                      cod_equipo = nro_componente[0].cod_equipo,
                                                      equipoPadreCod = nro_componente[0].equipoPadreCod,
                                                  }).Union(
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.c_instancia == "0" && (T0.cod_equipo == cod_Padre)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = "COMPONENTE",
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = nro_componente[0].equipo,
                                                        marca = nro_componente[0].marca,
                                                        modelo = nro_componente[0].modelo,
                                                        nro_serie = nro_componente[0].nro_serie,
                                                        nro_control_patrimonial = nro_componente[0].nro_control_patrimonial,
                                                        activo = nro_componente[0].activo,
                                                        nro_orden_compra = nro_componente[0].nro_orden_compra,
                                                        anio_adquisicion = nro_componente[0].anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = nro_componente[0].funcionamiento,
                                                        observacion = nro_componente[0].observacion,
                                                        procesador = nro_componente[0].procesador,
                                                        estado = nro_componente[0].estado,
                                                        cod_equipo = nro_componente[0].cod_equipo,
                                                        equipoPadreCod = nro_componente[0].equipoPadreCod,
                                                    })).ToList();



                                    dg.DataSource = lst;

                                    for (int i = 0; i < dg.Rows.Count; i++)
                                    {
                                        lstAsignacion.Add(new CAsignacionEqui
                                        {
                                            categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                            nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                            nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                            nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                            perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                            equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                            marca = dg.Rows[i].Cells[6].Value.ToString(),
                                            modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                            nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                            nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                            activo = dg.Rows[i].Cells[10].Value.ToString(),
                                            nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                            anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                            unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                            area = dg.Rows[i].Cells[14].Value.ToString(),
                                            funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                            observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                            procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                            estado = dg.Rows[i].Cells[18].Value.ToString()
                                        });
                                    }


                                    rs.Name = "DataSet11";
                                    rs.Value = lst;
                                    Asignacion_equipo frm = new Asignacion_equipo();
                                    frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                    frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                    frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                    frm.groupBox1.Visible = false;
                                    frm.ShowDialog();
                                    #endregion
 
                                }
                                else // no es componente
                                {
                                    #region
                                    var lst = ((
                                                  from T0 in db.Registros
                                                  join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                  join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                  join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                  join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                  join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                  join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                  where T0.cod_equipo == Convert.ToInt32(comboBoxEx1.SelectedValue)
                                                  //&& (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                  orderby T5.nombre_completo, T2.categoria

                                                  select new
                                                  {
                                                      categoria = T2.categoria,
                                                      nombre_sede = T3.nombre_sede,
                                                      nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                      nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                      perfil = T6.perfil,
                                                      equipo = T1.equipo,
                                                      marca = T1.marca,
                                                      modelo = T1.modelo,
                                                      nro_serie = T1.nro_serie,
                                                      nro_control_patrimonial = T1.nro_control_patrimonial,
                                                      activo = T1.activo,
                                                      nro_orden_compra = T1.nro_orden_compra,
                                                      anio_adquisicion = T1.anio_adquisicion,
                                                      unidad_organica = T5.unidad_organica,
                                                      area = T5.area,
                                                      funcionamiento = T1.funcionamiento,
                                                      observacion = T1.observacion,
                                                      procesador = T1.procesador,
                                                      estado = T1.estado,
                                                      cod_equipo = T1.cod_equipo,
                                                      equipoPadreCod = T1.equipoPadreCod,
                                                  }).Union(
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.c_instancia == "0" && (T0.cod_equipo == Convert.ToInt32(comboBoxEx1.SelectedValue))
                                                    //&& (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    })).ToList();



                                    dg.DataSource = lst;

                                    for (int i = 0; i < dg.Rows.Count; i++)
                                    {
                                        lstAsignacion.Add(new CAsignacionEqui
                                        {
                                            categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                            nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                            nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                            nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                            perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                            equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                            marca = dg.Rows[i].Cells[6].Value.ToString(),
                                            modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                            nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                            nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                            activo = dg.Rows[i].Cells[10].Value.ToString(),
                                            nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                            anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                            unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                            area = dg.Rows[i].Cells[14].Value.ToString(),
                                            funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                            observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                            procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                            estado = dg.Rows[i].Cells[18].Value.ToString()
                                        });
                                    }


                                    rs.Name = "DataSet11";
                                    rs.Value = lst;
                                    Asignacion_equipo frm = new Asignacion_equipo();
                                    frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                    frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                    frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                    frm.groupBox1.Visible = false;
                                    frm.ShowDialog();
                                    #endregion

                                }
                         
 
                            }
                           

                          
                            #endregion
                        }
                        //unidad organica y area
                        //
                        //
                        else if (rbUnidadOrganicaArea.Checked) //
                        {
                            #region

                            if (Convert.ToInt32(comboBoxEx1.SelectedValue) == 0) //si combo1 sede es ***todos***
                            {
                                if (Convert.ToString(comboBoxEx2.SelectedValue) == "0")//si combo2 und_organica es ***todos***
                                {
                                    if (Convert.ToString(comboBoxEx3.SelectedValue) == "0")//si combo3 area es ***todos***
                                    {
                                        if (Convert.ToString(comboBoxEx4.SelectedValue) == "0")//si combo4 categoria es ***todos***
                                        {
                                            //mostrar todo
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    orderby T5.nombre_completo, T2.categoria
                                                    where (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0"
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();
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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                               
                                            }
                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }
                                          




                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                        else
                                        {
                                            //filtrar por categoria
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                                
                                            }
                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }


                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                    }
                                    else// opcion combo3 area 
                                    {
                                        if (Convert.ToString(comboBoxEx4.SelectedValue) == "0")////si combo4 categoria es ***todos***
                                        {
                                            //filtrar por area
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where (T5.area == Convert.ToString(comboBoxEx3.SelectedValue))
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where (T5.c_instancia == "0") && (T5.area == Convert.ToString(comboBoxEx3.SelectedValue))
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
 
                                            }
                                            //agregar componentes de TREGISTRO que no tengan padre
                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }




                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                        else///hay una opcion en combo4 categoria filtrar por area y categoria
                                        {
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,
                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                               
                                            }


                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }


                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }

                                    }

                                }
                                else//una opcion en combo2 und_organica////
                                {
                                    if (Convert.ToString(comboBoxEx3.SelectedValue) == "0")//si combo3 area es ***todos***
                                    {
                                        if (Convert.ToString(comboBoxEx4.SelectedValue) == "0")//si combo4 categoria es ***todos***
                                        {
                                            //filtrar por unidad organica
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                               
                                            }
                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }



                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                        else
                                        {
                                            //filtrar por categoria y uni organica
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                    && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                   && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                      && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                            }



                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }

                                            dg.DataSource = lista;
                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                    }
                                    else// una opcion combo3 area  
                                    {
                                        if (Convert.ToString(comboBoxEx4.SelectedValue) == "0")////si combo4 categoria es ***todos***
                                        {
                                            //filtrar por area y und organica
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.area == Convert.ToString(comboBoxEx3.SelectedValue)
                                                    && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                   && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.area == Convert.ToString(comboBoxEx3.SelectedValue)
                                                      && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                     && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                               if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                            }


                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }

                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                        else///hay una opcion en combo4 categoria filtrar por area - categoria -und orga
                                        {
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                    && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                   && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                      && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                                
                                            }


                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }
                                            dg.DataSource = lista;
                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }

                                    }

                                }
                            }
                            else//una opcion combo1 sede
                            {
                                if (Convert.ToString(comboBoxEx2.SelectedValue) == "0")//si combo2 und_organica es ***todos***
                                {
                                    if (Convert.ToString(comboBoxEx3.SelectedValue) == "0")//si combo3 area es ***todos***
                                    {
                                        if (Convert.ToString(comboBoxEx4.SelectedValue) == "0")//si combo4 categoria es ***todos***
                                        {
                                            //mostrar todo
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                   && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();


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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                               
                                            }

                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }

                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                        else
                                        {
                                            //filtrar por categoria y sede
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue) && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                      && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                               
                                            }


                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }


                                            dg.DataSource = lista;
                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                    }
                                    else// opcion combo3 area 
                                    {
                                        if (Convert.ToString(comboBoxEx4.SelectedValue) == "0")////si combo4 categoria es ***todos***
                                        {
                                            //filtrar por area y sede
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                   // && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                     // && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                               
                                            }

                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }

                                            dg.DataSource = lista;
                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                        else///hay una opcion en combo4 categoria filtrar por area y categoria y sede
                                        {
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                   && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                      &&(DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();


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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                               // if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                               
                                            }
                                          

                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }

                                    }

                                }
                                else//una opcion en combo2 und_organica////
                                {
                                    if (Convert.ToString(comboBoxEx3.SelectedValue) == "0")//si combo3 area es ***todos***
                                    {
                                        if (Convert.ToString(comboBoxEx4.SelectedValue) == "0")//si combo4 categoria es ***todos***
                                        {
                                            //filtrar por unidad organica y sede
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue) && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                   && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                      && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                                
                                            }
                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }

                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                        else
                                        {
                                            //filtrar por categoria y uni organica y sede
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                    && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                    && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                   // && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                      && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                      && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();


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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                               if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                                
                                            }

                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }

                                            dg.DataSource = lista;

                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                    }
                                    else// una opcion combo3 area  
                                    {
                                        if (Convert.ToString(comboBoxEx4.SelectedValue) == "0")////si combo4 categoria es ***todos***
                                        {
                                            //filtrar por area y und organica y sede
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.area == Convert.ToString(comboBoxEx3.SelectedValue)
                                                    && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                    && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.area == Convert.ToString(comboBoxEx3.SelectedValue)
                                                      && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                      && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                               if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                            }
                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }



                                            dg.DataSource = lista;
                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lst;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }
                                        else///hay una opcion en combo4 categoria filtrar por area - categoria -und orga-sede
                                        {
                                            #region
                                            dg.AutoGenerateColumns = false;
                                            lstAsignacion.Clear();
                                            var lst = ((
                                                    from T0 in db.Registros
                                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                    where T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                    && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                    && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                    && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                    orderby T5.nombre_completo, T2.categoria
                                                    select new
                                                    {
                                                        categoria = T2.categoria,
                                                        nombre_sede = T3.nombre_sede,
                                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                        perfil = T6.perfil,
                                                        equipo = T1.equipo,
                                                        marca = T1.marca,
                                                        modelo = T1.modelo,
                                                        nro_serie = T1.nro_serie,
                                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                                        activo = T1.activo,
                                                        nro_orden_compra = T1.nro_orden_compra,
                                                        anio_adquisicion = T1.anio_adquisicion,
                                                        unidad_organica = T5.unidad_organica,
                                                        area = T5.area,
                                                        funcionamiento = T1.funcionamiento,
                                                        observacion = T1.observacion,
                                                        procesador = T1.procesador,
                                                        estado = T1.estado,
                                                        cod_equipo = T1.cod_equipo,
                                                        equipoPadreCod = T1.equipoPadreCod,
                                                    }).Union(
                                                      from T0 in db.Registros
                                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                                      where T5.c_instancia == "0" && T5.area == Convert.ToString(comboBoxEx3.SelectedValue) && T2.cod_categoria == Convert.ToInt32(comboBoxEx4.SelectedValue)
                                                      && T5.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue)
                                                      && T3.c_sede == Convert.ToUInt32(comboBoxEx1.SelectedValue)
                                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                                      orderby T5.nombre_completo, T2.categoria
                                                      select new
                                                      {
                                                          categoria = T2.categoria,
                                                          nombre_sede = T3.nombre_sede,
                                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                                          perfil = T6.perfil,
                                                          equipo = T1.equipo,
                                                          marca = T1.marca,
                                                          modelo = T1.modelo,
                                                          nro_serie = T1.nro_serie,
                                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                                          activo = T1.activo,
                                                          nro_orden_compra = T1.nro_orden_compra,
                                                          anio_adquisicion = T1.anio_adquisicion,
                                                          unidad_organica = T5.unidad_organica,
                                                          area = T5.area,

                                                          funcionamiento = T1.funcionamiento,
                                                          observacion = T1.observacion,
                                                          procesador = T1.procesador,
                                                          estado = T1.estado,
                                                          cod_equipo = T1.cod_equipo,
                                                          equipoPadreCod = T1.equipoPadreCod,

                                                      })).ToList();

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

                                            //recorrer lst e insertar lst_comp 
                                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                                if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                                {
                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                    foreach (var lcom in lst_comp)
                                                    {
                                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                                        {
                                                            CAsignacionEqui componente = new CAsignacionEqui();

                                                            componente.categoria = lcom.categoria;
                                                            componente.nombre_sede = lcom.nombre_sede;
                                                            componente.nombre_instancia = lcom.nombre_instancia;
                                                            componente.nombre = lcom.nombre;
                                                            componente.perfil = lcom.perfil;
                                                            componente.equipo = lcom.equipo;
                                                            componente.marca = lcom.marca;
                                                            componente.modelo = lcom.modelo;
                                                            componente.nro_serie = lcom.nro_serie;
                                                            componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                            componente.activo = lcom.activo;
                                                            componente.nro_orden_compra = lcom.nro_orden_compra;
                                                            componente.anio_adquisicion = lcom.anio_adquisicion;
                                                            componente.unidad_organica = lcom.unidad_organica;
                                                            componente.area = lcom.area;
                                                            componente.funcionamiento = lcom.funcionamiento;
                                                            componente.observacion = lcom.observacion;
                                                            componente.procesador = lcom.procesador;
                                                            componente.estado = lcom.estado;
                                                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                            lista.Add(componente);

                                                        }
                                                    }
                                                }
                                                
                                            }

                                            //agregar componentes de TREGISTRO que no tengan padre
                                            foreach (var nw in lst)
                                            {
                                                CAsignacionEqui listaregi = new CAsignacionEqui();

                                                if ((nw.equipo == "MOUSE" || nw.equipo == "TECLADO" || nw.equipo == "MONITOR") && ((String.IsNullOrEmpty(nw.equipoPadreCod.ToString()) || nw.equipoPadreCod.ToString() == "0")))
                                                {

                                                    listaregi.categoria = nw.categoria;
                                                    listaregi.nombre_sede = nw.nombre_sede;
                                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                                    listaregi.nombre = nw.nombre;
                                                    listaregi.perfil = nw.perfil;
                                                    listaregi.equipo = nw.equipo;
                                                    listaregi.marca = nw.marca;
                                                    listaregi.modelo = nw.modelo;
                                                    listaregi.nro_serie = nw.nro_serie;
                                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                                    listaregi.activo = nw.activo;
                                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                                    listaregi.unidad_organica = nw.unidad_organica;
                                                    listaregi.area = nw.area;
                                                    listaregi.funcionamiento = nw.funcionamiento;
                                                    listaregi.observacion = nw.observacion;
                                                    listaregi.procesador = nw.procesador;
                                                    listaregi.estado = nw.estado;
                                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                                    lista.Add(listaregi);
                                                }

                                            }
                                            dg.DataSource = lista;
                                            
                                            for (int i = 0; i < dg.Rows.Count; i++)
                                            {
                                                lstAsignacion.Add(new CAsignacionEqui
                                                {
                                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                                });
                                            }
                                            rs.Name = "DataSet11";
                                            rs.Value = lista;
                                            Asignacion_equipo frm = new Asignacion_equipo();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Clear();
                                            frm.rvAsignacionEquipo.LocalReport.DataSources.Add(rs);
                                            frm.rvAsignacionEquipo.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report1.rdlc";
                                            frm.rvAsignacionEquipo.LocalReport.Refresh();
                                            frm.groupBox1.Visible = false;
                                            frm.ShowDialog();
                                            #endregion
                                        }

                                    }

                                }


                            }
                            #endregion
                        }

                    }
                    if (rbDetalladoAE.Checked == false && rbResumenAE.Checked == true)//reportes de resumen
                    {
                        //MessageBox.Show("reportes en resume");
                        if (rbRegTodos.Checked)
                        {
                            #region
                            dg.AutoGenerateColumns = false;
                            lstAsignacion.Clear();
                            var lst = ((
                                    from T0 in db.Registros
                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                    where (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                    orderby T5.nombre_completo, T2.categoria
                                    select new
                                    {
                                        categoria = T2.categoria,
                                        nombre_sede = T3.nombre_sede,
                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                        perfil = T6.perfil,
                                        equipo = T1.equipo,
                                        marca = T1.marca,
                                        modelo = T1.modelo,
                                        nro_serie = T1.nro_serie,
                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                        activo = T1.activo,
                                        nro_orden_compra = T1.nro_orden_compra,
                                        anio_adquisicion = T1.anio_adquisicion,
                                        unidad_organica = T5.unidad_organica,
                                        area = T5.area,
                                        funcionamiento = T1.funcionamiento,
                                        observacion = T1.observacion,
                                        procesador = T1.procesador,
                                        estado = T1.estado,
                                        cod_equipo = T1.cod_equipo,
                                        equipoPadreCod = T1.equipoPadreCod,
                                    }).Union(
                                      from T0 in db.Registros
                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                      where T5.c_instancia == "0"
                                      && (DateTime.Now.Year - (T1.anio_adquisicion == "S/A"?0:Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                      orderby T5.nombre_completo, T2.categoria
                                      select new
                                      {
                                          categoria = T2.categoria,
                                          nombre_sede = T3.nombre_sede,
                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                          perfil = T6.perfil,
                                          equipo = T1.equipo,
                                          marca = T1.marca,
                                          modelo = T1.modelo,
                                          nro_serie = T1.nro_serie,
                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                          activo = T1.activo,
                                          nro_orden_compra = T1.nro_orden_compra,
                                          anio_adquisicion = T1.anio_adquisicion,
                                          unidad_organica = T5.unidad_organica,
                                          area = T5.area,
                                          funcionamiento = T1.funcionamiento,
                                          observacion = T1.observacion,
                                          procesador = T1.procesador,
                                          estado = T1.estado,
                                          cod_equipo = T1.cod_equipo,
                                          equipoPadreCod = T1.equipoPadreCod,
                                      })).ToList();
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

                            //recorrer lst e insertar lst_comp 
                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                            foreach (var nw in lst)
                            {
                                CAsignacionEqui listaregi = new CAsignacionEqui();
                                //if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                {
                                    listaregi.categoria = nw.categoria;
                                    listaregi.nombre_sede = nw.nombre_sede;
                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                    listaregi.nombre = nw.nombre;
                                    listaregi.perfil = nw.perfil;
                                    listaregi.equipo = nw.equipo;
                                    listaregi.marca = nw.marca;
                                    listaregi.modelo = nw.modelo;
                                    listaregi.nro_serie = nw.nro_serie;
                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                    listaregi.activo = nw.activo;
                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                    listaregi.unidad_organica = nw.unidad_organica;
                                    listaregi.area = nw.area;
                                    listaregi.funcionamiento = nw.funcionamiento;
                                    listaregi.observacion = nw.observacion;
                                    listaregi.procesador = nw.procesador;
                                    listaregi.estado = nw.estado;
                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                    lista.Add(listaregi);
                                    foreach (var lcom in lst_comp)
                                    {
                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                        {
                                            CAsignacionEqui componente = new CAsignacionEqui();

                                            var comp_reg = (from T0 in db.Registros where T0.cod_equipo == lcom.cod_equipo select T0).ToList();
                                            if (comp_reg.Count() <= 0)
                                            {
                                                componente.categoria = nw.categoria;
                                                componente.nombre_sede = nw.nombre_sede;
                                                componente.nombre_instancia = nw.nombre_instancia;
                                                componente.nombre = nw.nombre;
                                                componente.perfil = nw.perfil;
                                                componente.equipo = lcom.equipo;
                                                componente.marca = lcom.marca;
                                                componente.modelo = lcom.modelo;
                                                componente.nro_serie = lcom.nro_serie;
                                                componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                componente.activo = lcom.activo;
                                                componente.nro_orden_compra = lcom.nro_orden_compra;
                                                componente.anio_adquisicion = lcom.anio_adquisicion;
                                                componente.unidad_organica = nw.unidad_organica;
                                                componente.area = nw.area;
                                                componente.funcionamiento = nw.funcionamiento;
                                                componente.observacion = lcom.observacion;
                                                componente.procesador = lcom.procesador;
                                                componente.estado = lcom.estado;
                                                componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                lista.Add(componente);
                                            }                                        
                                          

                                        }
                                    }
                                }
                               
                            }
                       


                            dg.DataSource = lista;


                          

                            
                            for (int i = 0; i < dg.Rows.Count; i++)
                            {
                                lstAsignacion.Add(new CAsignacionEqui
                                {
                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                });
                            }


                            rs.Name = "DataSet111";
                            rs.Value = lista;
                            Asignacion_equipo_Rsm frm = new Asignacion_equipo_Rsm();
                            frm.rvAsignacionEquipo_Rsm.LocalReport.DataSources.Clear();
                            frm.rvAsignacionEquipo_Rsm.LocalReport.DataSources.Add(rs);
                            frm.rvAsignacionEquipo_Rsm.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportJC01Resumentotal.rdlc";
                            //frm.groupBox1.Visible_Rsm = false;
                            frm.ShowDialog();
                            #endregion

                        }
                        else if (rbRegSedeInstancia.Checked)
                        {
                            //MessageBox.Show("reportes en resume");
                            #region
                            dg.AutoGenerateColumns = false;
                            lstAsignacion.Clear();
                            var lst = ((
                                    from T0 in db.Registros
                                    join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                    join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                    join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                    join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia
                                    join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                    join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                    where (DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                    orderby T5.nombre_completo, T2.categoria
                                    select new
                                    {
                                        categoria = T2.categoria,
                                        nombre_sede = T3.nombre_sede,
                                        nombre_instancia = T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                        nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                        perfil = T6.perfil,
                                        equipo = T1.equipo,
                                        marca = T1.marca,
                                        modelo = T1.modelo,
                                        nro_serie = T1.nro_serie,
                                        nro_control_patrimonial = T1.nro_control_patrimonial,
                                        activo = T1.activo,
                                        nro_orden_compra = T1.nro_orden_compra,
                                        anio_adquisicion = T1.anio_adquisicion,
                                        unidad_organica = T5.unidad_organica,
                                        area = T5.area,
                                        funcionamiento = T1.funcionamiento,
                                        observacion = T1.observacion,
                                        procesador = T1.procesador,
                                        estado = T1.estado,
                                        cod_equipo = T1.cod_equipo,
                                        equipoPadreCod = T1.equipoPadreCod,
                                    })).ToList();
                            //var lstrest = lst.Union(lst2).ToList();
                            //lista de componentes
                            var lst_comp = (from
                                        T1 in db.Equipos
                                            where T1.activo == "S" && T1.equipo == "MOUSE" || T1.equipo == "TECLADO" || T1.equipo == "MONITOR"
                                            select new
                                            {
                                                categoria = "",//tabla padre
                                                nombre_sede = "",//tabla padre
                                                nombre_instancia = "",//tabla padre
                                                nombre = "",//tabla padre
                                                perfil = "",//tabla padre
                                                equipo = T1.equipo,
                                                marca = T1.marca,
                                                modelo = T1.modelo,
                                                nro_serie = T1.nro_serie,
                                                nro_control_patrimonial = T1.nro_control_patrimonial,
                                                activo = T1.activo,
                                                nro_orden_compra = T1.nro_orden_compra,
                                                anio_adquisicion = T1.anio_adquisicion,
                                                unidad_organica = "",//tabla padre
                                                area = "",//tabla padre

                                                funcionamiento = "",//tabla padre
                                                observacion = T1.observacion,
                                                procesador = T1.procesador,
                                                estado = T1.estado,
                                                cod_equipo = T1.cod_equipo,
                                                equipoPadreCod = T1.equipoPadreCod,

                                            }).ToList();

                            //recorrer lst e insertar lst_comp 
                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                            foreach (var nw in lst)
                            {
                                CAsignacionEqui listaregi = new CAsignacionEqui();
                               // if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                {
                                    listaregi.categoria = nw.categoria;
                                    listaregi.nombre_sede = nw.nombre_sede;
                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                    listaregi.nombre = nw.nombre;
                                    listaregi.perfil = nw.perfil;
                                    listaregi.equipo = nw.equipo;
                                    listaregi.marca = nw.marca;
                                    listaregi.modelo = nw.modelo;
                                    listaregi.nro_serie = nw.nro_serie;
                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                    listaregi.activo = nw.activo;
                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                    listaregi.unidad_organica = nw.unidad_organica;
                                    listaregi.area = nw.area;
                                    listaregi.funcionamiento = nw.funcionamiento;
                                    listaregi.observacion = nw.observacion;
                                    listaregi.procesador = nw.procesador;
                                    listaregi.estado = nw.estado;
                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                    lista.Add(listaregi);
                                    foreach (var lcom in lst_comp)
                                    {
                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                        {
                                            CAsignacionEqui componente = new CAsignacionEqui();
                                            var comp_reg = (from T0 in db.Registros where T0.cod_equipo == lcom.cod_equipo select T0).ToList();
                                            if (comp_reg.Count() <= 0)
                                            {
                                                componente.categoria = nw.categoria;
                                                componente.nombre_sede = nw.nombre_sede;
                                                componente.nombre_instancia = nw.nombre_instancia;
                                                componente.nombre = nw.nombre;
                                                componente.perfil = nw.perfil;
                                                componente.equipo = lcom.equipo;
                                                componente.marca = lcom.marca;
                                                componente.modelo = lcom.modelo;
                                                componente.nro_serie = lcom.nro_serie;
                                                componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                componente.activo = lcom.activo;
                                                componente.nro_orden_compra = lcom.nro_orden_compra;
                                                componente.anio_adquisicion = lcom.anio_adquisicion;
                                                componente.unidad_organica = nw.unidad_organica;
                                                componente.area = nw.area;
                                                componente.funcionamiento = nw.funcionamiento;
                                                componente.observacion = lcom.observacion;
                                                componente.procesador = lcom.procesador;
                                                componente.estado = lcom.estado;
                                                componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                lista.Add(componente);
                                            }
                                           

                                        }
                                    }
                                }
                               
                            }

                           

                            dg.DataSource = lista;
                            for (int i = 0; i < dg.Rows.Count; i++)
                            {
                                lstAsignacion.Add(new CAsignacionEqui
                                {
                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                });
                            }


                            rs.Name = "DataSet111";
                            rs.Value = lista;
                            Asignacion_equipo_Rsm frm = new Asignacion_equipo_Rsm();
                            frm.rvAsignacionEquipo_Rsm.LocalReport.DataSources.Clear();
                            frm.rvAsignacionEquipo_Rsm.LocalReport.DataSources.Add(rs);
                            frm.rvAsignacionEquipo_Rsm.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportJC02ResumenSedeInst.rdlc";
                            //frm.groupBox1.Visible_Rsm = false;
                            frm.ShowDialog();
                            #endregion
                        }
                        else if (rbUnidadOrganicaArea.Checked)
                        {
                            //mostrar todo
                            #region
                            dg.AutoGenerateColumns = false;
                            lstAsignacion.Clear();
                            var lst = (from T0 in db.Registros
                                      join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                                      join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                      join T5 in db.Personals on T0.doc_entry_personal equals T5.doc_entry_personal
                                      //join T4 in db.Instancias on T5.c_instancia equals T4.c_instancia                        
                                      join T3 in db.Sedes on T5.c_sede equals T3.c_sede
                                      join T6 in db.Perfils on T5.c_perfil equals T6.c_perfil
                                      where T5.c_instancia == "0" 
                                      &&(DateTime.Now.Year - (T1.anio_adquisicion == "S/A" ? 0 : Convert.ToInt32(T1.anio_adquisicion)) >= (tbAnioAntig.Text == string.Empty ? 0 : Convert.ToInt32(tbAnioAntig.Text)))
                                      orderby T5.nombre_completo, T2.categoria
                                      select new
                                      {
                                          categoria = T2.categoria,
                                          nombre_sede = T3.nombre_sede,
                                          nombre_instancia = "",//T4.nombre_instancia, //(from T4 in db.Instancias where T4.c_instancia == T5.c_instancia select T4.nombre_instancia).Count() > 0 ? db.Instancias.Where(x => x.c_instancia == T5.c_instancia).Select(x => x.nombre_instancia).ToList()[0] : "no",// db.Instancias.Where(x=> x.c_instancia == T5.c_instancia).Select(x=>x.nombre_instancia).ToString() // Convert.ToString((from T4 in db.Instancias where T4.c_instancia==T5.c_instancia select T4.nombre_instancia).ToList()[0])
                                          nombre = T5.c_ape_paterno + " " + T5.c_ape_materno + " " + T5.c_nombres,
                                          perfil = T6.perfil,
                                          equipo = T1.equipo,
                                          marca = T1.marca,
                                          modelo = T1.modelo,
                                          nro_serie = T1.nro_serie,
                                          nro_control_patrimonial = T1.nro_control_patrimonial,
                                          activo = T1.activo,
                                          nro_orden_compra = T1.nro_orden_compra,
                                          anio_adquisicion = T1.anio_adquisicion,
                                          unidad_organica = T5.unidad_organica,
                                          area = T5.area,

                                          funcionamiento = T1.funcionamiento,
                                          observacion = T1.observacion,
                                          procesador = T1.procesador,
                                          estado = T1.estado,
                                          cod_equipo = T1.cod_equipo,
                                          equipoPadreCod = T1.equipoPadreCod,

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

                            //recorrer lst e insertar lst_comp 
                            List<CAsignacionEqui> lista = new List<CAsignacionEqui>();

                            foreach (var nw in lst)
                            {
                                CAsignacionEqui listaregi = new CAsignacionEqui();
                               // if (nw.equipo != "MOUSE" && nw.equipo != "TECLADO" && nw.equipo != "MONITOR")
                                {

                                    listaregi.categoria = nw.categoria;
                                    listaregi.nombre_sede = nw.nombre_sede;
                                    listaregi.nombre_instancia = nw.nombre_instancia;
                                    listaregi.nombre = nw.nombre;
                                    listaregi.perfil = nw.perfil;
                                    listaregi.equipo = nw.equipo;
                                    listaregi.marca = nw.marca;
                                    listaregi.modelo = nw.modelo;
                                    listaregi.nro_serie = nw.nro_serie;
                                    listaregi.nro_control_patrimonial = nw.nro_control_patrimonial;
                                    listaregi.activo = nw.activo;
                                    listaregi.nro_orden_compra = nw.nro_orden_compra;
                                    listaregi.anio_adquisicion = nw.anio_adquisicion;
                                    listaregi.unidad_organica = nw.unidad_organica;
                                    listaregi.area = nw.area;
                                    listaregi.funcionamiento = nw.funcionamiento;
                                    listaregi.observacion = nw.observacion;
                                    listaregi.procesador = nw.procesador;
                                    listaregi.estado = nw.estado;
                                    listaregi.cod_equipo = Convert.ToString(nw.cod_equipo);
                                    listaregi.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                                    lista.Add(listaregi);
                                    foreach (var lcom in lst_comp)
                                    {
                                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                                        {
                                            CAsignacionEqui componente = new CAsignacionEqui();
                                            var comp_reg = (from T0 in db.Registros where T0.cod_equipo == lcom.cod_equipo select T0).ToList();
                                            if (comp_reg.Count() <= 0)
                                            {
                                                componente.categoria = nw.categoria;
                                                componente.nombre_sede = nw.nombre_sede;
                                                componente.nombre_instancia = nw.nombre_instancia;
                                                componente.nombre = nw.nombre;
                                                componente.perfil = nw.perfil;
                                                componente.equipo = lcom.equipo;
                                                componente.marca = lcom.marca;
                                                componente.modelo = lcom.modelo;
                                                componente.nro_serie = lcom.nro_serie;
                                                componente.nro_control_patrimonial = lcom.nro_control_patrimonial;
                                                componente.activo = lcom.activo;
                                                componente.nro_orden_compra = lcom.nro_orden_compra;
                                                componente.anio_adquisicion = lcom.anio_adquisicion;
                                                componente.unidad_organica = nw.unidad_organica;
                                                componente.area = nw.area;
                                                componente.funcionamiento = nw.funcionamiento;
                                                componente.observacion = lcom.observacion;
                                                componente.procesador = lcom.procesador;
                                                componente.estado = lcom.estado;
                                                componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                                                componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);
                                                lista.Add(componente);
                                            }
                                          

                                        }
                                    }

                                }
                            }
                          



                            dg.DataSource = lista;




                            
                            
                            for (int i = 0; i < dg.Rows.Count; i++)
                            {
                                lstAsignacion.Add(new CAsignacionEqui
                                {
                                    categoria = dg.Rows[i].Cells[0].Value.ToString(),
                                    nombre_sede = dg.Rows[i].Cells[1].Value.ToString(),
                                    nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                    nombre = dg.Rows[i].Cells[3].Value.ToString(),
                                    perfil = dg.Rows[i].Cells[4].Value.ToString(),
                                    equipo = dg.Rows[i].Cells[5].Value.ToString(),
                                    marca = dg.Rows[i].Cells[6].Value.ToString(),
                                    modelo = dg.Rows[i].Cells[7].Value.ToString(),
                                    nro_serie = dg.Rows[i].Cells[8].Value.ToString(),
                                    nro_control_patrimonial = dg.Rows[i].Cells[9].Value.ToString(),
                                    activo = dg.Rows[i].Cells[10].Value.ToString(),
                                    nro_orden_compra = dg.Rows[i].Cells[11].Value.ToString(),
                                    anio_adquisicion = dg.Rows[i].Cells[12].Value.ToString(),
                                    unidad_organica = dg.Rows[i].Cells[13].Value.ToString(),
                                    area = dg.Rows[i].Cells[14].Value.ToString(),
                                    funcionamiento = dg.Rows[i].Cells[15].Value.ToString(),
                                    observacion = dg.Rows[i].Cells[16].Value.ToString(),
                                    procesador = dg.Rows[i].Cells[17].Value.ToString(),
                                    estado = dg.Rows[i].Cells[18].Value.ToString()
                                });
                            }
                            rs.Name = "DataSet111";
                            rs.Value = lista;
                            Asignacion_equipo_Rsm frm = new Asignacion_equipo_Rsm();
                            frm.rvAsignacionEquipo_Rsm.LocalReport.DataSources.Clear();
                            frm.rvAsignacionEquipo_Rsm.LocalReport.DataSources.Add(rs);
                            frm.rvAsignacionEquipo_Rsm.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportJC03ResumenUndOrg.rdlc";
                            frm.rvAsignacionEquipo_Rsm.LocalReport.Refresh();
                           // frm.groupBox1.Visible = false;
                            frm.ShowDialog();
                            #endregion
 
                        }


                    }
                       

                    

                }
          
 
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }
            



        }

        private void Asignacion_equipo_Load(object sender, EventArgs e)
        {
           
            rvAsignacionEquipo.RefreshReport();
        }
        public class CAsignacionEqui
        {

            public string categoria { get; set; }
            public string nombre_sede { get; set; }
            public string nombre_instancia { get; set; }
            public string nombre { get; set; }
            public string perfil { get; set; }
            public string equipo { get; set; }
            public string marca { get; set; }
            public string modelo { get; set; }
            public string nro_serie { get; set; }
            public string nro_control_patrimonial { get; set; }
            public string activo { get; set; }
            public string nro_orden_compra { get; set; }
            public string anio_adquisicion { get; set; }
            public string unidad_organica { get; set; }
            public string area { get; set; }
            public string funcionamiento { get; set; }
            public string observacion { get; set; }
            public string procesador { get; set; }
            public string estado { get; set; }
            public string cod_equipo { get; set; }
            public string equipoPadreCod { get; set; }
            


        }

        private void rbRegTodos_Click(object sender, EventArgs e)
        {
            labelX1.Visible = false;
            labelX2.Visible = false;
            labelX3.Visible = false;
            comboBoxEx3.Visible = false;
            comboBoxEx1.Visible = false;
            comboBoxEx2.Visible = false;
            labelX4.Visible = false;
            labelX4.Visible = false;
            comboBoxEx4.Visible = false;
        }

        private void rbRegCategoria_Click(object sender, EventArgs e)
        {
            labelX3.Visible = false;
            comboBoxEx3.Visible = false;
            labelX2.Visible = false;
            comboBoxEx2.Visible = false;
            labelX1.Visible = true;
            labelX1.Text = "Categoria";
            comboBoxEx1.Visible = true;
            // cargarCategoria en el comboBoxEx1
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var listCategorias = from cat in dc.Categorias select cat; //new{ cat.cod_categoria, cat.categoria };
            comboBoxEx1.DataSource = listCategorias.ToList();
            comboBoxEx1.ValueMember = "cod_categoria";
            comboBoxEx1.DisplayMember = "categoria";
            labelX4.Visible = false;
            labelX4.Visible = false;
            comboBoxEx4.Visible = false;
        }

        private void rbRegPorsona_Click(object sender, EventArgs e)
        {
            labelX3.Visible = false;
            comboBoxEx3.Visible = false;
            labelX1.Visible = true;
            labelX1.Text = "Buscar por Nombre o DNI: ";
            comboBoxEx1.Visible = true;
            comboBoxEx2.Visible = false;
            labelX2.Visible = false;
            // cargarPersona
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from T0 in dc.Personals
                     // join T1 in dc.Instancias on eq.c_instancia equals T1.c_instancia
                     // join T2 in dc.Sedes on eq.c_sede equals T2.c_sede

                      select new
                      {
                          id = T0.doc_entry_personal,
                          concatenado =  T0.nombre_completo+" DNI: "+ T0.dni,
                      }).ToList();


            comboBoxEx1.DataSource = sq;
            comboBoxEx1.ValueMember = "id";
            comboBoxEx1.DisplayMember = "concatenado";
            labelX4.Visible = false;
            labelX4.Visible = false;
            comboBoxEx4.Visible = false;
        }

        private void rbRegSedeInstancia_Click(object sender, EventArgs e)
        {

            if (rbDetalladoAE.Checked == true)
            {
                labelX1.Visible = true;
                labelX1.Text = "Sede";
                comboBoxEx1.DataSource = null;
                comboBoxEx1.Items.Clear();
                comboBoxEx1.Visible = true;
                labelX2.Visible = true;
                labelX2.Text = "Instancia";
                comboBoxEx2.DataSource = null;
                comboBoxEx2.Items.Clear();
                comboBoxEx2.Visible = true;
                labelX3.Visible = true;
                labelX3.Text = "Categoria";
                comboBoxEx3.DataSource = null;
                comboBoxEx3.Items.Clear();
                comboBoxEx3.Visible = true;
                labelX4.Visible = false;
                labelX4.Visible = false;
                comboBoxEx4.Visible = false;
                // cargar sede en el comboBoxEx1
                //  ModeloDatoDataContext dc = new ModeloDatoDataContext();
                // var listSede = (from T0 in dc.Sedes select new { cod_sede = T0.c_sede, nombre_sede = T0.nombre_sede }).ToList();

                //  listSede.Insert(0, new { cod_sede = 0, nombre_sede = "**Todos**" });
                // listSede.Insert(1, new { cod_sede = 1, nombre_sede = "**Selecionar**" });

                //comboBoxEx1.DataSource = listSede;
                // comboBoxEx1.ValueMember = "cod_sede";
                // comboBoxEx1.DisplayMember = "nombre_sede";
                // comboBoxEx1.SelectedIndex = 1;
                cargarSedeComboBoxEx1();
                cargarCategoriaRep();



                /*
                            comboBoxEx2.Items.Add("**Seleccionar**");
                            comboBoxEx2.SelectedValue = 0;
                            comboBoxEx2.SelectedIndex = 0;
           
                */


                //  comboBoxEx3.DisplayMember = "nombre_sede";
                /*          comboBoxEx3.Items.Add("**Seleccionar**");
                          comboBoxEx3.SelectedValue = 0;
                          comboBoxEx3.SelectedIndex = 0;
              */



                // cargar instancia en el comboBoxEx2
                /* var listInstancia = (from T1 in dc.Instancias  select new { cod_instancia = T1.c_instancia, nombre_instancia = T1.nombre_instancia }).ToList();
                 listInstancia.Insert(0, new { cod_instancia = "0", nombre_instancia = "**Todos**" });
                 comboBoxEx2.DataSource = listInstancia.ToList();
                 comboBoxEx2.ValueMember = "cod_instancia";
                 comboBoxEx2.DisplayMember = "nombre_instancia";
                 * */
            }
            if (rbResumenAE.Checked == true)
            {
                labelX1.Visible = false;
                //labelX1.Text = "Sede";
                //comboBoxEx1.DataSource = null;
                //comboBoxEx1.Items.Clear();
                comboBoxEx1.Visible = false;
                labelX2.Visible = false;
                //labelX2.Text = "Instancia";
                //comboBoxEx2.DataSource = null;
                //comboBoxEx2.Items.Clear();
                comboBoxEx2.Visible = false;
                labelX3.Visible = false;
                //labelX3.Text = "Categoria";
                //comboBoxEx3.DataSource = null;
               // comboBoxEx3.Items.Clear();
                comboBoxEx3.Visible = false;
                labelX4.Visible = false;
                labelX4.Visible = false;
                comboBoxEx4.Visible = false;               
                //cargarSedeComboBoxEx1();
               // cargarCategoriaRep();
            }

          
             
        }
        private void cargarUnidadOganica()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var list = (from T0 in dc.Personals where T0.unidad_organica != "" && T0.area != "" select new { id = T0.unidad_organica, undOrg = T0.unidad_organica }).Distinct().ToList();
            list.Insert(0, new { id = "0", undOrg = "**Todos**" });

            comboBoxEx2.DataSource = list;
            comboBoxEx2.ValueMember = "id";
            comboBoxEx2.DisplayMember = "undOrg";
            //comboBoxEx2.SelectedIndex = 1;

           // comboBoxEx3.DataSource = list;
           // comboBoxEx3.ValueMember = "cod_persona";
            //comboBoxEx3.DisplayMember = "area";
            //comboBoxEx3.SelectedIndex = 1;
        }
        private void cargarArea()
        {
            
           
                ModeloDatoDataContext dc = new ModeloDatoDataContext();
                var list = (from T1 in dc.Personals where T1.unidad_organica == Convert.ToString(comboBoxEx2.SelectedValue) && T1.unidad_organica != "" && T1.area != "" select new { id = T1.area, area= T1.area }).ToList();
                list.Insert(0, new { id = "0", area = "**Todos**" });
                comboBoxEx3.DataSource = list.ToList();
                comboBoxEx3.ValueMember = "id";
                comboBoxEx3.DisplayMember = "area";
                
            
           
        }
        private void cargarSedeComboBoxEx1()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var listSede = (from T0 in dc.Sedes select new { cod_sede = T0.c_sede, nombre_sede = T0.nombre_sede }).ToList();
            listSede.Insert(0, new { cod_sede = 0, nombre_sede = "**Todos**" });
            comboBoxEx1.DataSource = listSede;
            comboBoxEx1.ValueMember = "cod_sede";
            comboBoxEx1.DisplayMember = "nombre_sede";
            comboBoxEx1.SelectedIndex = 1;
        }
       
        private void cargarInstanciaComboBoxEx2()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            if (comboBoxEx1.SelectedIndex > 0)
            {
                var listInstancia = (from T1 in dc.Instancias where T1.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue) select new { cod_instancia = T1.c_instancia, nombre_instancia = T1.nombre_instancia }).ToList();
                listInstancia.Insert(0, new { cod_instancia = "0", nombre_instancia = "**Todos**" });
                comboBoxEx2.DataSource = listInstancia.ToList();
                comboBoxEx2.ValueMember = "cod_instancia";
                comboBoxEx2.DisplayMember = "nombre_instancia";
            //    comboBoxEx1.SelectedIndex = 0;
            }
          
           
        }

        private void rbCpuComponentes_Click(object sender, EventArgs e)
        {
            labelX1.Visible = true;
            labelX1.Text = "Serie o cod Patrimonial: ";
            comboBoxEx1.DataSource = null;
            comboBoxEx1.Items.Clear();
            comboBoxEx1.Visible = true;
            labelX2.Visible = false;
            labelX2.Text = "";
            comboBoxEx2.DataSource = null;
            comboBoxEx2.Items.Clear();
            comboBoxEx2.Visible = false;
            labelX3.Visible = false;           
            comboBoxEx3.Visible = false;
            //cargarSedeComboBoxEx1();
            labelX4.Visible = false;
            labelX4.Visible = false;
            comboBoxEx4.Visible = false;
            //cargarInstanciaComboBoxEx2();
            //cargarCategoriaRep();
            //cargarequipo
            // cargarPersona
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from T0 in dc.Equipos
                      

                      select new
                      {
                          id = T0.cod_equipo,
                          concatenado = T0.equipo + ", Serie: " + T0.nro_serie + " cod_patrimonial: " + T0.nro_control_patrimonial,                         
                      }).ToList();


            comboBoxEx1.DataSource = sq;
            comboBoxEx1.ValueMember = "id";
            comboBoxEx1.DisplayMember = "concatenado";



        }

        private void comboBoxEx1_Click(object sender, EventArgs e)
        {
            if (rbRegSedeInstancia.Checked)
            {
                cargarSedeComboBoxEx1();
            }
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbRegSedeInstancia.Checked || rbEquip.Checked)
            {
                cargarInstanciaComboBoxEx2();
            }
           
        }

        private void comboBoxEx3_Click(object sender, EventArgs e)
        {
            cargarCategoriaRep();
        }
        private void cargarCategoriaRep()
        {
            //cargar las categorias
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var listCategorias = (from cat in dc.Categorias select new { cod_categoria = cat.cod_categoria, categoria = cat.categoria }).ToList(); //new{ cat.cod_categoria, cat.categoria };
            listCategorias.Insert(0, new { cod_categoria = 0, categoria = "**Todos**" });
            comboBoxEx3.DataSource = listCategorias.ToList();
            comboBoxEx3.ValueMember = "cod_categoria";
            comboBoxEx3.DisplayMember = "categoria";
            comboBoxEx3.SelectedIndex = 0;
 
        }

        private void rbUnidadOrganicaArea_Click(object sender, EventArgs e)
        {
            if (rbDetalladoAE.Checked == true)
            {
                labelX1.Visible = true;
                labelX1.Text = "Sede";
                comboBoxEx1.DataSource = null;
                comboBoxEx1.Items.Clear();
                comboBoxEx1.Visible = true;
                labelX2.Visible = true;
                labelX2.Text = "Unidad orgánica";
                comboBoxEx2.DataSource = null;
                comboBoxEx2.Items.Clear();
                comboBoxEx2.Visible = true;
                labelX3.Visible = true;
                labelX3.Text = "Area";
                comboBoxEx3.DataSource = null;
                comboBoxEx3.Items.Clear();
                comboBoxEx3.Visible = true;
                labelX4.Visible = true;
                labelX4.Text = "Categoria";
                comboBoxEx4.DataSource = null;
                comboBoxEx4.Items.Clear();
                comboBoxEx4.Visible = true;
                // cargar sede en el comboBoxEx1
                //  ModeloDatoDataContext dc = new ModeloDatoDataContext();
                // var listSede = (from T0 in dc.Sedes select new { cod_sede = T0.c_sede, nombre_sede = T0.nombre_sede }).ToList();

                //  listSede.Insert(0, new { cod_sede = 0, nombre_sede = "**Todos**" });
                // listSede.Insert(1, new { cod_sede = 1, nombre_sede = "**Selecionar**" });

                //comboBoxEx1.DataSource = listSede;
                // comboBoxEx1.ValueMember = "cod_sede";
                // comboBoxEx1.DisplayMember = "nombre_sede";
                // comboBoxEx1.SelectedIndex = 1;
                cargarSedeComboBoxEx1();
                //cargarCategoriaRep();
                //cargar las categorias
                ModeloDatoDataContext dc = new ModeloDatoDataContext();
                var listCategorias = (from cat in dc.Categorias select new { cod_categoria = cat.cod_categoria, categoria = cat.categoria }).ToList(); //new{ cat.cod_categoria, cat.categoria };
                listCategorias.Insert(0, new { cod_categoria = 0, categoria = "**Todos**" });
                comboBoxEx4.DataSource = listCategorias.ToList();
                comboBoxEx4.ValueMember = "cod_categoria";
                comboBoxEx4.DisplayMember = "categoria";
                comboBoxEx4.SelectedIndex = 0;
                //
                cargarUnidadOganica();
                cargarArea();
           
            }
            if (rbResumenAE.Checked == true)
            {
                labelX1.Visible = false;
                //labelX1.Text = "Sede";
                //comboBoxEx1.DataSource = null;
                //comboBoxEx1.Items.Clear();
                comboBoxEx1.Visible = false;
                labelX2.Visible = false;
                //labelX2.Text = "Unidad orgánica";
                //comboBoxEx2.DataSource = null;
                //comboBoxEx2.Items.Clear();
                comboBoxEx2.Visible = false;
                labelX3.Visible = false;
                //labelX3.Text = "Area";
                //comboBoxEx3.DataSource = null;
                //comboBoxEx3.Items.Clear();
                comboBoxEx3.Visible = false;
                labelX4.Visible = false;
                //labelX4.Text = "Categoria";
                //comboBoxEx4.DataSource = null;
                //comboBoxEx4.Items.Clear();
                comboBoxEx4.Visible = false;
               
                cargarSedeComboBoxEx1();
               
                //ModeloDatoDataContext dc = new ModeloDatoDataContext();
                //var listCategorias = (from cat in dc.Categorias select new { cod_categoria = cat.cod_categoria, categoria = cat.categoria }).ToList(); //new{ cat.cod_categoria, cat.categoria };
                //listCategorias.Insert(0, new { cod_categoria = 0, categoria = "**Todos**" });
                //comboBoxEx4.DataSource = listCategorias.ToList();
                //comboBoxEx4.ValueMember = "cod_categoria";
                //comboBoxEx4.DisplayMember = "categoria";
                //comboBoxEx4.SelectedIndex = 0;
                //
                //cargarUnidadOganica();
                //cargarArea();
           
 
            }

            
        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbUnidadOrganicaArea.Checked)
            {
                if (comboBoxEx2.SelectedIndex > 0)
                {
                    cargarArea();
                }
            
                
            }
        }

        private void comboBoxEx1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void buscarNombreDNI()
        {
            

               
        }

        private void comboBoxEx1_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbRegPorsona.Checked)
            {
                #region
                if (comboBoxEx1.Text != string.Empty)
                {
                    ModeloDatoDataContext db = new ModeloDatoDataContext();

                    var dtListado = (from T0 in db.Personals

                                     select new
                                     {
                                         id = T0.doc_entry_personal,
                                         listado = T0.nombre_completo + " Dni: " + T0.dni,

                                     });



                    string strText;
                    strText = comboBoxEx1.Text;
                    if (comboBoxEx1.Text == "")
                    {
                        this.comboBoxEx1.DataSource = dtListado.ToList();
                        this.comboBoxEx1.ValueMember = "Id";
                        this.comboBoxEx1.DisplayMember = "listado";
                        comboBoxEx1.SelectedIndex = -1;
                        comboBoxEx1.DroppedDown = false;



                    }

                    if (strText.Length > 2)
                    {
                        /*
                         * lista.Where(p => p.Nombre.Contains(txtNombre.Text)).ToList();
                         */
                        comboBoxEx1.DataSource = (dtListado.Where(p => p.listado.Contains(strText))).ToList();
                        this.comboBoxEx1.ValueMember = "Id";
                        this.comboBoxEx1.DisplayMember = "listado";



                        if (comboBoxEx1.Items.Count != 0)
                        {
                            comboBoxEx1.DroppedDown = true;
                            comboBoxEx1.SelectedIndex = -1;
                            comboBoxEx1.Text = "";
                            comboBoxEx1.SelectedText = strText;
                            strText = "";
                            Cursor.Current = Cursors.Default;


                        }
                        else
                        {
                            comboBoxEx1.DataSource = dtListado.ToList();
                            comboBoxEx1.ValueMember = "Id";
                            comboBoxEx1.DisplayMember = "listado";
                            comboBoxEx1.SelectedIndex = -1;
                            comboBoxEx1.Text = "";
                            comboBoxEx1.SelectedText = strText;
                            strText = "";
                            comboBoxEx1.DroppedDown = false;

                        }
                    }

                }
                #endregion
            }
            if (rbEquip.Checked)
            {
                #region
                if (comboBoxEx1.Text != string.Empty)
                {
                    ModeloDatoDataContext db = new ModeloDatoDataContext();

                    var dtListado = (from T0 in db.Equipos

                                     select new
                                     {
                                         id = T0.cod_equipo,
                                         listado = T0.equipo + ", Serie: " + T0.nro_serie + " cod_patrimonial: " + T0.nro_control_patrimonial,

                                     });



                    string strText;
                    strText = comboBoxEx1.Text;
                    if (comboBoxEx1.Text == "")
                    {
                        this.comboBoxEx1.DataSource = dtListado.ToList();
                        this.comboBoxEx1.ValueMember = "Id";
                        this.comboBoxEx1.DisplayMember = "listado";
                        comboBoxEx1.SelectedIndex = -1;
                        comboBoxEx1.DroppedDown = false;



                    }

                    if (strText.Length > 2)
                    {
                        /*
                         * lista.Where(p => p.Nombre.Contains(txtNombre.Text)).ToList();
                         */
                        comboBoxEx1.DataSource = (dtListado.Where(p => p.listado.Contains(strText))).ToList();
                        this.comboBoxEx1.ValueMember = "Id";
                        this.comboBoxEx1.DisplayMember = "listado";



                        if (comboBoxEx1.Items.Count != 0)
                        {
                            comboBoxEx1.DroppedDown = true;
                            comboBoxEx1.SelectedIndex = -1;
                            comboBoxEx1.Text = "";
                            comboBoxEx1.SelectedText = strText;
                            strText = "";
                            Cursor.Current = Cursors.Default;


                        }
                        else
                        {
                            comboBoxEx1.DataSource = dtListado.ToList();
                            comboBoxEx1.ValueMember = "Id";
                            comboBoxEx1.DisplayMember = "listado";
                            comboBoxEx1.SelectedIndex = -1;
                            comboBoxEx1.Text = "";
                            comboBoxEx1.SelectedText = strText;
                            strText = "";
                            comboBoxEx1.DroppedDown = false;

                        }
                    }

                }
                #endregion
 
            }

        }

        private void rbDetalladoAE_Click(object sender, EventArgs e)
        {
            enableRBRepAE();
            //mostrar reportes disponibles
            rbRegPorsona.Visible = true;
            rbRegCategoria.Visible = true;
            rbEquip.Visible = true;

        }

        private void rbResumenAE_Click(object sender, EventArgs e)
        {
            enableRBRepAE();
            //mostrar reportes disponibles
            rbRegPorsona.Visible=false;
            rbRegCategoria.Visible=false;
            rbEquip.Visible = false;
        }

        private void tbAnioAntig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

        }

    }
                                
}
                             