using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Microsoft.Reporting.WinForms;


namespace WindowsFormsApplication1.Reports
{
    public partial class Asignacion_soft : Form
    {
        ReportDataSource rs = new ReportDataSource();
        public Asignacion_soft()
        {
            InitializeComponent();
        }
        
        private void btGenerarRepSof_Click(object sender, EventArgs e)
        {
            
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            List<CAsignacionSof> lstAsignacion = new List<CAsignacionSof>();
            DataGridView dg = new DataGridView();

            if (rbRegSedeInstancia.Checked)
            {
                #region

                if (Convert.ToInt32(comboBoxEx1.SelectedValue) == 0) //si combo1 es ***todos***
                {
                    if (Convert.ToInt32(comboBoxEx2.SelectedValue) == 0)//si combo2 es ***todos***
                    {
                        //mostrar todo
                        dg.AutoGenerateColumns = false;                        
                        lstAsignacion.Clear();

                        var lst = (
                            from T0 in db.Equipo_softwares 
                            join T1 in db.Softwares on T0.cod_software equals T1.cod_software 
                            join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo
                            join T3 in db.Registros  on T2.cod_equipo equals T3.cod_equipo
                            join T6 in db.Personals on T3.doc_entry_personal equals T6.doc_entry_personal
                            join T4 in db.Sedes on T6.c_sede equals T4.c_sede
                            join T5 in db.Instancias on T6.c_instancia equals T5.c_instancia

                        select new
                        {

                            nombre_sede=T4.nombre_sede,
                            nombre_instancia=T5.nombre_instancia, 
                            equipo= T2.equipo,
                            nro_serie= T2.nro_serie, 
                            software= T1.software,
                            version=T1.version, 
                            cantidad_usuarios= T1.cantidad_usuarios, 
                            nro_orden_compra= T1.nro_orden_compra, 
                            anio_aquisicion= T1.anio_aquisicion,


                        }).Distinct().ToList();

                        dg.DataSource = lst;
                        for (int i = 0; i < dg.Rows.Count; i++)
                        {
                            lstAsignacion.Add(new CAsignacionSof
                            {
                                nombre_sede = dg.Rows[i].Cells[0].Value.ToString(),                                
                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                equipo = dg.Rows[i].Cells[3].Value.ToString(),
                                nro_serie = dg.Rows[i].Cells[4].Value.ToString(),
                                software = dg.Rows[i].Cells[5].Value.ToString(),
                                version = dg.Rows[i].Cells[6].Value.ToString(),
                                cantidad_usuarios = dg.Rows[i].Cells[7].Value.ToString(),
                                nro_orden_compra = dg.Rows[i].Cells[8].Value.ToString(),
                                anio_aquisicion = dg.Rows[i].Cells[9].Value.ToString(),
                                
                            });
                        }


                        rs.Name = "DataSet2";
                        rs.Value = lst;
                        Asignacion_soft frm = new Asignacion_soft();

                        frm.rvAsignacionSof.LocalReport.DataSources.Clear();
                        frm.rvAsignacionSof.LocalReport.DataSources.Add(rs);
                        frm.rvAsignacionSof.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report2Sof.rdlc";
                        //frm.rvAsignacionSof.LocalReport.Refresh();
                        frm.groupBox1.Visible = false;

                        frm.ShowDialog();


                    }
                    else
                    {
                        //filtar por instancia
                        dg.AutoGenerateColumns = false;
                        lstAsignacion.Clear();

                        var lst = (
                            from T0 in db.Equipo_softwares
                            join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                            join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo
                            join T3 in db.Registros on T2.cod_equipo equals T3.cod_equipo
                            join T6 in db.Personals on T3.doc_entry_personal equals T6.doc_entry_personal
                            join T4 in db.Sedes on T6.c_sede equals T4.c_sede
                            join T5 in db.Instancias on T6.c_instancia equals T5.c_instancia
                            where T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue)

                            select new
                            {

                                nombre_sede = T4.nombre_sede,
                                nombre_instancia = T5.nombre_instancia,
                                equipo = T2.equipo,
                                nro_serie = T2.nro_serie,
                                software = T1.software,
                                version = T1.version,
                                cantidad_usuarios = T1.cantidad_usuarios,
                                nro_orden_compra = T1.nro_orden_compra,
                                anio_aquisicion = T1.anio_aquisicion

                            }).Distinct().ToList();

                        dg.DataSource = lst;
                        for (int i = 0; i < dg.Rows.Count; i++)
                        {
                            lstAsignacion.Add(new CAsignacionSof
                            {
                                nombre_sede = dg.Rows[i].Cells[0].Value.ToString(),
                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                equipo = dg.Rows[i].Cells[3].Value.ToString(),
                                nro_serie = dg.Rows[i].Cells[4].Value.ToString(),
                                software = dg.Rows[i].Cells[5].Value.ToString(),
                                version = dg.Rows[i].Cells[6].Value.ToString(),
                                cantidad_usuarios = dg.Rows[i].Cells[7].Value.ToString(),
                                nro_orden_compra = dg.Rows[i].Cells[8].Value.ToString(),
                                anio_aquisicion = dg.Rows[i].Cells[9].Value.ToString(),

                            });
                        }


                        rs.Name = "DataSet2";
                        rs.Value = lst;
                        Asignacion_soft frm = new Asignacion_soft();

                        frm.rvAsignacionSof.LocalReport.DataSources.Clear();
                        frm.rvAsignacionSof.LocalReport.DataSources.Add(rs);
                        frm.rvAsignacionSof.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report2Sof.rdlc";
                        frm.rvAsignacionSof.LocalReport.Refresh();
                        frm.groupBox1.Visible = false;

                        frm.ShowDialog();
                      
                    }
                }
                else
                {
                    if (Convert.ToInt32(comboBoxEx2.SelectedValue) == 0)
                    {
                        //filtrar por sede
                        dg.AutoGenerateColumns = false;
                        lstAsignacion.Clear();

                        var lst = (
                               from T0 in db.Equipo_softwares
                               join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                               join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo
                               join T3 in db.Registros on T2.cod_equipo equals T3.cod_equipo
                               join T6 in db.Personals on T3.doc_entry_personal equals T6.doc_entry_personal
                               join T4 in db.Sedes on T6.c_sede equals T4.c_sede
                               join T5 in db.Instancias on T6.c_instancia equals T5.c_instancia
                            where T4.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue)

                            select new
                            {

                                nombre_sede = T4.nombre_sede,
                                nombre_instancia = T5.nombre_instancia,
                                equipo = T2.equipo,
                                nro_serie = T2.nro_serie,
                                software = T1.software,
                                version = T1.version,
                                cantidad_usuarios = T1.cantidad_usuarios,
                                nro_orden_compra = T1.nro_orden_compra,
                                anio_aquisicion = T1.anio_aquisicion

                            }).Distinct().ToList();

                        dg.DataSource = lst;
                        for (int i = 0; i < dg.Rows.Count; i++)
                        {
                            lstAsignacion.Add(new CAsignacionSof
                            {
                                nombre_sede = dg.Rows[i].Cells[0].Value.ToString(),
                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                equipo = dg.Rows[i].Cells[3].Value.ToString(),
                                nro_serie = dg.Rows[i].Cells[4].Value.ToString(),
                                software = dg.Rows[i].Cells[5].Value.ToString(),
                                version = dg.Rows[i].Cells[6].Value.ToString(),
                                cantidad_usuarios = dg.Rows[i].Cells[7].Value.ToString(),
                                nro_orden_compra = dg.Rows[i].Cells[8].Value.ToString(),
                                anio_aquisicion = dg.Rows[i].Cells[9].Value.ToString(),

                            });
                        }


                        rs.Name = "DataSet2";
                        rs.Value = lst;
                        Asignacion_soft frm = new Asignacion_soft();

                        frm.rvAsignacionSof.LocalReport.DataSources.Clear();
                        frm.rvAsignacionSof.LocalReport.DataSources.Add(rs);
                        frm.rvAsignacionSof.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report2Sof.rdlc";
                        frm.rvAsignacionSof.LocalReport.Refresh();
                        frm.groupBox1.Visible = false;

                        frm.ShowDialog();
                        
                    }
                    else
                    {
                        //filtrar por sede  e instancia
                        dg.AutoGenerateColumns = false;
                        lstAsignacion.Clear();

                        var lst = (
                              from T0 in db.Equipo_softwares
                              join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                              join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo
                              join T3 in db.Registros on T2.cod_equipo equals T3.cod_equipo
                              join T6 in db.Personals on T3.doc_entry_personal equals T6.doc_entry_personal
                              join T4 in db.Sedes on T6.c_sede equals T4.c_sede
                              join T5 in db.Instancias on T6.c_instancia equals T5.c_instancia
                            where T5.c_instancia == Convert.ToString(comboBoxEx2.SelectedValue) && T4.c_sede == Convert.ToInt32(comboBoxEx1.SelectedValue)

                            select new
                            {

                                nombre_sede = T4.nombre_sede,
                                nombre_instancia = T5.nombre_instancia,
                                equipo = T2.equipo,
                                nro_serie = T2.nro_serie,
                                software = T1.software,
                                version = T1.version,
                                cantidad_usuarios = T1.cantidad_usuarios,
                                nro_orden_compra = T1.nro_orden_compra,
                                anio_aquisicion = T1.anio_aquisicion

                            }).Distinct().ToList();

                        dg.DataSource = lst;
                        for (int i = 0; i < dg.Rows.Count; i++)
                        {
                            lstAsignacion.Add(new CAsignacionSof
                            {
                                nombre_sede = dg.Rows[i].Cells[0].Value.ToString(),
                                nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                                equipo = dg.Rows[i].Cells[3].Value.ToString(),
                                nro_serie = dg.Rows[i].Cells[4].Value.ToString(),
                                software = dg.Rows[i].Cells[5].Value.ToString(),
                                version = dg.Rows[i].Cells[6].Value.ToString(),
                                cantidad_usuarios = dg.Rows[i].Cells[7].Value.ToString(),
                                nro_orden_compra = dg.Rows[i].Cells[8].Value.ToString(),
                                anio_aquisicion = dg.Rows[i].Cells[9].Value.ToString(),

                            });
                        }


                        rs.Name = "DataSet2";
                        rs.Value = lst;
                        Asignacion_soft frm = new Asignacion_soft();

                        frm.rvAsignacionSof.LocalReport.DataSources.Clear();
                        frm.rvAsignacionSof.LocalReport.DataSources.Add(rs);
                        frm.rvAsignacionSof.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report2Sof.rdlc";
                        frm.rvAsignacionSof.LocalReport.Refresh();
                        frm.groupBox1.Visible = false;

                        frm.ShowDialog();
                        
                    }
                }

#endregion

            }
            else if (rbRegTodos.Checked)
            {
                #region

                dg.AutoGenerateColumns = false;
                lstAsignacion.Clear();

                var lst = (
                       from T0 in db.Equipo_softwares
                       join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                       join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo
                       join T3 in db.Registros on T2.cod_equipo equals T3.cod_equipo
                       join T6 in db.Personals on T3.doc_entry_personal equals T6.doc_entry_personal
                       join T4 in db.Sedes on T6.c_sede equals T4.c_sede
                       join T5 in db.Instancias on T6.c_instancia equals T5.c_instancia
                   

                    select new
                    {

                        nombre_sede = T4.nombre_sede,
                        nombre_instancia = T5.nombre_instancia,
                        equipo = T2.equipo,
                        nro_serie = T2.nro_serie,
                        software = T1.software,
                        version = T1.version,
                        cantidad_usuarios = T1.cantidad_usuarios,
                        nro_orden_compra = T1.nro_orden_compra,
                        anio_aquisicion = T1.anio_aquisicion,
                        unidad_organica = T6.unidad_organica,
                        area = T6.area,

                    }).Union  //
                    (
                       from T0 in db.Equipo_softwares
                       join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                       join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo
                       join T3 in db.Registros on T2.cod_equipo equals T3.cod_equipo
                       join T6 in db.Personals on T3.doc_entry_personal equals T6.doc_entry_personal
                       join T4 in db.Sedes on T6.c_sede equals T4.c_sede
                       //join T5 in db.Instancias on T6.c_instancia equals T5.c_instancia
                   

                    select new
                    {

                        nombre_sede = T4.nombre_sede,
                        nombre_instancia = "",//T5.nombre_instancia,
                        equipo = T2.equipo,
                        nro_serie = T2.nro_serie,
                        software = T1.software,
                        version = T1.version,
                        cantidad_usuarios = T1.cantidad_usuarios,
                        nro_orden_compra = T1.nro_orden_compra,
                        anio_aquisicion = T1.anio_aquisicion,
                        unidad_organica = T6.unidad_organica,
                        area = T6.area,

                    }).Distinct().ToList();

                dg.DataSource = lst;
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    lstAsignacion.Add(new CAsignacionSof
                    {
                        nombre_sede = dg.Rows[i].Cells[0].Value.ToString(),
                        nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                        equipo = dg.Rows[i].Cells[3].Value.ToString(),
                        nro_serie = dg.Rows[i].Cells[4].Value.ToString(),
                        software = dg.Rows[i].Cells[5].Value.ToString(),
                        version = dg.Rows[i].Cells[6].Value.ToString(),
                        cantidad_usuarios = dg.Rows[i].Cells[7].Value.ToString(),
                        nro_orden_compra = dg.Rows[i].Cells[8].Value.ToString(),
                        anio_aquisicion = dg.Rows[i].Cells[9].Value.ToString(),
                        unidad_organica = dg.Rows[i].Cells[10].Value.ToString(),
                        area = dg.Rows[i].Cells[11].Value.ToString(),

                    });
                }


                rs.Name = "DataSet2";
                rs.Value = lst;
                Asignacion_soft frm = new Asignacion_soft();

                frm.rvAsignacionSof.LocalReport.DataSources.Clear();
                frm.rvAsignacionSof.LocalReport.DataSources.Add(rs);
                frm.rvAsignacionSof.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report2Sof.rdlc";
                //frm.rvAsignacionSof.LocalReport.Refresh();
                frm.groupBox1.Visible = false;
                frm.ShowDialog();
               
#endregion
            }
            else if (rbRegEquipo.Checked)
            {
                #region
                dg.AutoGenerateColumns = false;
                lstAsignacion.Clear();

                var lst = (
                       from T0 in db.Equipo_softwares
                       join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                       join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo
                       join T3 in db.Registros on T2.cod_equipo equals T3.cod_equipo
                       join T6 in db.Personals on T3.doc_entry_personal equals T6.doc_entry_personal
                       join T4 in db.Sedes on T6.c_sede equals T4.c_sede
                       join T5 in db.Instancias on T6.c_instancia equals T5.c_instancia
                    where T2.cod_equipo == Convert.ToInt32(comboBoxEx1.SelectedValue)
                       select new
                       {

                           nombre_sede = T4.nombre_sede,
                           nombre_instancia = T5.nombre_instancia,
                           equipo = T2.equipo,
                           nro_serie = T2.nro_serie,
                           software = T1.software,
                           version = T1.version,
                           cantidad_usuarios = T1.cantidad_usuarios,
                           nro_orden_compra = T1.nro_orden_compra,
                           anio_aquisicion = T1.anio_aquisicion,
                           unidad_organica = T6.unidad_organica,
                           area = T6.area,

                       }).Union  //
                    (
                       from T0 in db.Equipo_softwares
                       join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                       join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo
                       join T3 in db.Registros on T2.cod_equipo equals T3.cod_equipo
                       join T6 in db.Personals on T3.doc_entry_personal equals T6.doc_entry_personal
                       join T4 in db.Sedes on T6.c_sede equals T4.c_sede
                       //join T5 in db.Instancias on T6.c_instancia equals T5.c_instancia
                       where T2.cod_equipo == Convert.ToInt32(comboBoxEx1.SelectedValue)


                       select new
                       {

                           nombre_sede = T4.nombre_sede,
                           nombre_instancia = "",//T5.nombre_instancia,
                           equipo = T2.equipo,
                           nro_serie = T2.nro_serie,
                           software = T1.software,
                           version = T1.version,
                           cantidad_usuarios = T1.cantidad_usuarios,
                           nro_orden_compra = T1.nro_orden_compra,
                           anio_aquisicion = T1.anio_aquisicion,
                           unidad_organica = T6.unidad_organica,
                           area = T6.area,

                       }).Distinct().ToList();

                dg.DataSource = lst;
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    lstAsignacion.Add(new CAsignacionSof
                    {
                        nombre_sede = dg.Rows[i].Cells[0].Value.ToString(),
                        nombre_instancia = dg.Rows[i].Cells[2].Value.ToString(),
                        equipo = dg.Rows[i].Cells[3].Value.ToString(),
                        nro_serie = dg.Rows[i].Cells[4].Value.ToString(),
                        software = dg.Rows[i].Cells[5].Value.ToString(),
                        version = dg.Rows[i].Cells[6].Value.ToString(),
                        cantidad_usuarios = dg.Rows[i].Cells[7].Value.ToString(),
                        nro_orden_compra = dg.Rows[i].Cells[8].Value.ToString(),
                        anio_aquisicion = dg.Rows[i].Cells[9].Value.ToString(),

                    });
                }


                rs.Name = "DataSet2";
                rs.Value = lst;
                Asignacion_soft frm = new Asignacion_soft();

                frm.rvAsignacionSof.LocalReport.DataSources.Clear();
                frm.rvAsignacionSof.LocalReport.DataSources.Add(rs);
                frm.rvAsignacionSof.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report2Sof.rdlc";
                //frm.rvAsignacionSof.LocalReport.Refresh();
                frm.groupBox1.Visible = false;
                frm.ShowDialog();
                #endregion

            }
               

          

        }
        public class CAsignacionSof
        {

            public string nombre_sede { get; set; }
            public string nombre_instancia { get; set; }
            public string equipo { get; set; }
            public string nro_serie { get; set; }
            public string software { get; set; }
            public string version { get; set; }
            public string cantidad_usuarios { get; set; }
            public string nro_orden_compra { get; set; }
            public string anio_aquisicion { get; set; }   
            public string unidad_organica { get; set; }
            public string area { get; set; }   
        }

        private void rbRegEquipo_Click(object sender, EventArgs e)
        {
            labelX1.Visible = true;
            labelX1.Text = "Serie de Equipo";
            comboBoxEx1.Visible = true;
            labelX2.Visible = false;
            comboBoxEx2.Visible = false;

            // cargarEquipo en el comboBoxEx1
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var listCategorias = from eq in dc.Equipos select new { cod_equipo = eq.cod_equipo, serie = eq.nro_serie + ' ' + eq.equipo }; 
            comboBoxEx1.DataSource = listCategorias.ToList();
            comboBoxEx1.ValueMember = "cod_equipo";
            comboBoxEx1.DisplayMember = "serie";

        }

        private void rbRegSedeInstancia_Click(object sender, EventArgs e)
        {

           
            labelX1.Visible = true;
            labelX1.Text = "Sede";
            comboBoxEx1.Visible = true;
            labelX2.Visible = true;
            labelX2.Text = "Instancia";
            comboBoxEx2.Visible = true;
            // cargar sede en el comboBoxEx1
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var listSede = (from T0 in dc.Sedes select new { cod_sede = T0.c_sede, nombre_sede = T0.nombre_sede }).ToList();
            listSede.Insert(0, new { cod_sede = 0, nombre_sede = "**Todos**" });
            comboBoxEx1.DataSource = listSede;
            comboBoxEx1.ValueMember = "cod_sede";
            comboBoxEx1.DisplayMember = "nombre_sede";
            // cargar instancia en el comboBoxEx2

            var listInstancia = (from T1 in dc.Instancias select new { cod_instancia = T1.c_instancia, nombre_instancia = T1.nombre_instancia }).ToList();
            listInstancia.Insert(0, new { cod_instancia = "0", nombre_instancia = "**Todos**" });
            comboBoxEx2.DataSource = listInstancia.ToList();
            comboBoxEx2.ValueMember = "cod_instancia";
            comboBoxEx2.DisplayMember = "nombre_instancia";
            
        }

        private void rbRegTodos_Click(object sender, EventArgs e)
        {
            labelX1.Visible = false;
            labelX2.Visible = false;
            comboBoxEx1.Visible = false;
            comboBoxEx2.Visible = false;
        }

        private void Asignacion_soft_Load(object sender, EventArgs e)
        {

            this.rvAsignacionSof.RefreshReport();
        }
    }
}
