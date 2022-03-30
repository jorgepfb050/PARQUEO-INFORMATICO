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
    public partial class Form10MovEquipo : Form
    {
        public Form10MovEquipo()
        {
            InitializeComponent();
        }
       
       public int keyEquipo = 0;
       public string nombre_equipo = string.Empty;
       public string serie = string.Empty;

       ModeloDatoDataContext db = new ModeloDatoDataContext();
       List<CHistRegistro> lstAsignacion = new List<CHistRegistro>();
       DataGridView dg = new DataGridView();
       ReportDataSource rs = new ReportDataSource();

        private void btGenerarRepReg1_Click(object sender, EventArgs e)
        {
            
            if (rbPorEquipo.Checked == false && rbPorpersona.Checked == false)
            {
                MessageBox.Show("Seleciones un tipo de reporte");

            }
            else
            {
                if (rbPorEquipo.Checked == true)
                {
                    #region





                    dg.AutoGenerateColumns = false;
                    lstAsignacion.Clear();
                    var lst = (
                            from T0 in db.Historico_registro_equipos

                            select T0
                            ).ToList();
                  



                  
                    dg.DataSource = lst;
                    for (int i = 0; i < dg.Rows.Count; i++)
                    {
                        lstAsignacion.Add(new CHistRegistro
                        {

                            doc_entry_hist_Reg_Eq = Convert.ToString(dg.Rows[i].Cells[0].Value.ToString()),
                            cod_registro = Convert.ToString(dg.Rows[i].Cells[1].Value.ToString()),
                            doc_entry_personal = Convert.ToString(dg.Rows[i].Cells[2].Value.ToString()),
                            cod_equipo = Convert.ToString(dg.Rows[i].Cells[3].Value.ToString()),
                            fecha_registro = Convert.ToDateTime((dg.Rows[i].Cells[4].Value.ToString())),

                            fecha_sistema = Convert.ToDateTime(dg.Rows[i].Cells[5].Value.ToString()), //DateTime.ParseExact
                            observacion_registro = Convert.ToString(dg.Rows[i].Cells[6].Value.ToString()),
                            c_usuario = Convert.ToString(dg.Rows[i].Cells[7].Value.ToString()),
                            c_nombres = Convert.ToString(dg.Rows[i].Cells[8].Value.ToString()),
                            c_ape_paterno = Convert.ToString(dg.Rows[i].Cells[9].Value.ToString()),
                            c_ape_materno = dg.Rows[i].Cells[10].Value.ToString(),
                            fecha_ingreso = dg.Rows[i].Cells[11].Value.ToString(),
                            c_perfil = Convert.ToString(dg.Rows[i].Cells[12].Value.ToString()),
                            estado_personal = Convert.ToString(dg.Rows[i].Cells[13].Value.ToString()),
                            dni = Convert.ToString(dg.Rows[i].Cells[14].Value.ToString()),
                            c_sede = Convert.ToString(dg.Rows[i].Cells[15].Value.ToString()),
                            c_instancia = Convert.ToString(dg.Rows[i].Cells[16].Value.ToString()),
                            fecha_nacimiento = Convert.ToString(dg.Rows[i].Cells[17].Value.ToString()),
                            escalafon = Convert.ToString(dg.Rows[i].Cells[18].Value.ToString()),
                            fecha_ingreso_lab = Convert.ToString(dg.Rows[i].Cells[19].Value.ToString()),
                            fecha_termino_lab = Convert.ToString(dg.Rows[i].Cells[20].Value.ToString()),
                            nombre_completo = Convert.ToString(dg.Rows[i].Cells[21].Value.ToString()),
                            unidad_organica = Convert.ToString(dg.Rows[i].Cells[22].Value.ToString()),
                            area = Convert.ToString(dg.Rows[i].Cells[23].Value.ToString()),
                            tipo_personal = Convert.ToString(dg.Rows[i].Cells[24].Value.ToString()),
                            equipoPadreCod = Convert.ToString(dg.Rows[i].Cells[25].Value.ToString()),
                            equipo = Convert.ToString(dg.Rows[i].Cells[26].Value.ToString()),
                            ip_equipo = Convert.ToString(dg.Rows[i].Cells[27].Value.ToString()),
                            marca = Convert.ToString(dg.Rows[i].Cells[28].Value.ToString()),
                            modelo = Convert.ToString(dg.Rows[i].Cells[29].Value.ToString()),
                            procesador = Convert.ToString(dg.Rows[i].Cells[30].Value.ToString()),
                            nro_serie = Convert.ToString(dg.Rows[i].Cells[31].Value.ToString()),
                            nro_control_patrimonial = Convert.ToString(dg.Rows[i].Cells[32].Value.ToString()),
                            anio_adquisicion = Convert.ToString(dg.Rows[i].Cells[33].Value.ToString()),
                            nro_orden_compra = Convert.ToString(dg.Rows[i].Cells[34].Value.ToString()),
                            activo = Convert.ToString(dg.Rows[i].Cells[35].Value.ToString()),
                            cod_categoria = Convert.ToString(dg.Rows[i].Cells[36].Value.ToString()),
                            observacion_equipo = Convert.ToString(dg.Rows[i].Cells[37].Value.ToString()),
                            fecha_desactivacion = Convert.ToString(dg.Rows[i].Cells[38].Value.ToString()),
                            estado_equipo = Convert.ToString(dg.Rows[i].Cells[39].Value.ToString()),
                            service_tag = Convert.ToString(dg.Rows[i].Cells[40].Value.ToString()),
                            funcionamiento = Convert.ToString(dg.Rows[i].Cells[41].Value.ToString()),
                            movimiento = Convert.ToString(dg.Rows[i].Cells[42].Value.ToString()),
                            fecha_registro_hhmm = Convert.ToString(dg.Rows[i].Cells[43].Value.ToString()),

                        });
                    }
                    
    



                     
                        if (tbEquipo.Text == string.Empty)//todas las series, filtar solo por fechas
                        {
                            if (dtFechaAsignacionHasta.Value.Date.CompareTo(dtFechaAsignacionDesde.Value.Date) < 0)
                            {

                                MessageBox.Show("La fecha HASTA tiene que ser mayor a la fecha DESDE");
                                
                            }
                            else
                            {                               



                                ReportParameter[] parametros = new ReportParameter[2];

                                parametros[0] = new ReportParameter("fechaDesde", dtFechaAsignacionDesde.Value.Date.ToString("dd/MM/yyyy"));
                                parametros[1] = new ReportParameter("fechaHasta", dtFechaAsignacionHasta.Value.Date.ToString("dd/MM/yyyy")); //ToShortDateString()

                                MessageBox.Show(parametros[1].Values.ToString());

                                rs.Name = "DataSet1";
                                rs.Value = lst;
                                Form11MovEqRep frm = new Form11MovEqRep();
                                frm.ReportMovEqui.LocalReport.DataSources.Clear();
                                frm.ReportMovEqui.LocalReport.DataSources.Add(rs);
                                if (rbFechaRegSit.Checked== true)
                                {
                                    frm.ReportMovEqui.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportMov10EqFFdatatimeSist.rdlc";//fecha del sistema
                                    frm.ReportMovEqui.LocalReport.SetParameters(parametros);

                                    //frm.groupBox1.Visible_Rsm = false;
                                    frm.ShowDialog();
                                }

                                if (rbFechaRegUsuario.Checked == true)
                                {
                                    frm.ReportMovEqui.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportMov10EqFFdatatimeUser.rdlc";//fecha del sistema
                                    frm.ReportMovEqui.LocalReport.SetParameters(parametros);

                                    //frm.groupBox1.Visible_Rsm = false;
                                    frm.ShowDialog();
                                }
 
                              }
                                
                           
                        }
                        else //filtrar por serie y fechas
                        {
                            if (dtFechaAsignacionHasta.Value.Date.CompareTo(dtFechaAsignacionDesde.Value.Date) < 0)
                            {

                                MessageBox.Show("La fecha HASTA tiene que ser mayor a la fecha DESDE");

                            }
                            else
                            {



                                ReportParameter[] parametros = new ReportParameter[3];
                                parametros[0] = new ReportParameter("fechaDesde", dtFechaAsignacionDesde.Value.Date.ToShortDateString());
                                parametros[1] = new ReportParameter("fechaHasta", dtFechaAsignacionHasta.Value.Date.ToShortDateString());
                                parametros[2] = new ReportParameter("serie", tbEquipo.Text);

                               
                                rs.Name = "DataSet1";
                                rs.Value = lst;
                                Form11MovEqRep frm = new Form11MovEqRep();
                                frm.ReportMovEqui.LocalReport.DataSources.Clear();
                                frm.ReportMovEqui.LocalReport.DataSources.Add(rs);
                                if (rbFechaRegSit.Checked == true)
                                {
                                    frm.ReportMovEqui.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportMov10EqSFFdatatimeSist.rdlc";
                                    frm.ReportMovEqui.LocalReport.SetParameters(parametros);

                                    //frm.groupBox1.Visible_Rsm = false;
                                    frm.ShowDialog();

                                }
                                if (rbFechaRegUsuario.Checked == true)
                                {
                                    frm.ReportMovEqui.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportMov10EqSFFdatatimeUser.rdlc";
                                    frm.ReportMovEqui.LocalReport.SetParameters(parametros);

                                    //frm.groupBox1.Visible_Rsm = false;
                                    frm.ShowDialog();
                                }
                               
                            }

                        }


                    #endregion

                }

                if (rbPorpersona.Checked == true)
                {
                    #region




                    dg.AutoGenerateColumns = false;
                    lstAsignacion.Clear();
                    var lst = (
                            from T0 in db.Historico_registro_equipos

                            select T0).ToList();
                    //var lstrest = lst.Union(lst2).ToList();


                    dg.DataSource = lst;
                   
                    for (int i = 0; i < dg.Rows.Count; i++)
                    {
                        lstAsignacion.Add(new CHistRegistro
                        {

                            doc_entry_hist_Reg_Eq = Convert.ToString(dg.Rows[i].Cells[0].Value.ToString()),
                            cod_registro = Convert.ToString(dg.Rows[i].Cells[1].Value.ToString()),
                            doc_entry_personal = Convert.ToString(dg.Rows[i].Cells[2].Value.ToString()),
                            cod_equipo = Convert.ToString(dg.Rows[i].Cells[3].Value.ToString()),
                            fecha_registro = Convert.ToDateTime((dg.Rows[i].Cells[4].Value.ToString())),
                            fecha_sistema =Convert.ToDateTime(dg.Rows[i].Cells[5].Value.ToString()),
                            observacion_registro = Convert.ToString(dg.Rows[i].Cells[6].Value.ToString()),
                            c_usuario = Convert.ToString(dg.Rows[i].Cells[7].Value.ToString()),
                            c_nombres = Convert.ToString(dg.Rows[i].Cells[8].Value.ToString()),
                            c_ape_paterno = Convert.ToString(dg.Rows[i].Cells[9].Value.ToString()),
                            c_ape_materno = dg.Rows[i].Cells[10].Value.ToString(),
                            fecha_ingreso = dg.Rows[i].Cells[11].Value.ToString(),
                            c_perfil = Convert.ToString(dg.Rows[i].Cells[12].Value.ToString()),
                            estado_personal = Convert.ToString(dg.Rows[i].Cells[13].Value.ToString()),
                            dni = Convert.ToString(dg.Rows[i].Cells[14].Value.ToString()),
                            c_sede = Convert.ToString(dg.Rows[i].Cells[15].Value.ToString()),
                            c_instancia = Convert.ToString(dg.Rows[i].Cells[16].Value.ToString()),
                            fecha_nacimiento = Convert.ToString(dg.Rows[i].Cells[17].Value.ToString()),
                            escalafon = Convert.ToString(dg.Rows[i].Cells[18].Value.ToString()),
                            fecha_ingreso_lab = Convert.ToString(dg.Rows[i].Cells[19].Value.ToString()),
                            fecha_termino_lab = Convert.ToString(dg.Rows[i].Cells[20].Value.ToString()),
                            nombre_completo = Convert.ToString(dg.Rows[i].Cells[21].Value.ToString()),
                            unidad_organica = Convert.ToString(dg.Rows[i].Cells[22].Value.ToString()),
                            area = Convert.ToString(dg.Rows[i].Cells[23].Value.ToString()),
                            tipo_personal = Convert.ToString(dg.Rows[i].Cells[24].Value.ToString()),
                            equipoPadreCod = Convert.ToString(dg.Rows[i].Cells[25].Value.ToString()),
                            equipo = Convert.ToString(dg.Rows[i].Cells[26].Value.ToString()),
                            ip_equipo = Convert.ToString(dg.Rows[i].Cells[27].Value.ToString()),
                            marca = Convert.ToString(dg.Rows[i].Cells[28].Value.ToString()),
                            modelo = Convert.ToString(dg.Rows[i].Cells[29].Value.ToString()),
                            procesador = Convert.ToString(dg.Rows[i].Cells[30].Value.ToString()),
                            nro_serie = Convert.ToString(dg.Rows[i].Cells[31].Value.ToString()),
                            nro_control_patrimonial = Convert.ToString(dg.Rows[i].Cells[32].Value.ToString()),
                            anio_adquisicion = Convert.ToString(dg.Rows[i].Cells[33].Value.ToString()),
                            nro_orden_compra = Convert.ToString(dg.Rows[i].Cells[34].Value.ToString()),
                            activo = Convert.ToString(dg.Rows[i].Cells[35].Value.ToString()),
                            cod_categoria = Convert.ToString(dg.Rows[i].Cells[36].Value.ToString()),
                            observacion_equipo = Convert.ToString(dg.Rows[i].Cells[37].Value.ToString()),
                            fecha_desactivacion = Convert.ToString(dg.Rows[i].Cells[38].Value.ToString()),
                            estado_equipo = Convert.ToString(dg.Rows[i].Cells[39].Value.ToString()),
                            service_tag = Convert.ToString(dg.Rows[i].Cells[40].Value.ToString()),
                            funcionamiento = Convert.ToString(dg.Rows[i].Cells[41].Value.ToString()),
                            movimiento = Convert.ToString(dg.Rows[i].Cells[42].Value.ToString()),
                            fecha_registro_hhmm = Convert.ToString(dg.Rows[i].Cells[43].Value.ToString()),

                        });
                    }
                





                    if (tbPersona.Text == string.Empty)//todas los dni, filtar solo por fechas
                    {
                        if (dtFechaAsignacionHasta.Value.Date.CompareTo(dtFechaAsignacionDesde.Value.Date) < 0)
                        {

                            MessageBox.Show("La fecha HASTA tiene que ser mayor a la fecha DESDE");

                        }
                        else
                        {



                            ReportParameter[] parametros = new ReportParameter[2];

                            parametros[0] = new ReportParameter("fechaDesde", dtFechaAsignacionDesde.Value.Date.ToString("dd/MM/yyyy"));
                            parametros[1] = new ReportParameter("fechaHasta", dtFechaAsignacionHasta.Value.Date.ToString("dd/MM/yyyy")); //ToShortDateString()

                            MessageBox.Show(parametros[1].Values.ToString());

                            rs.Name = "DataSet1";
                            rs.Value = lst;
                            Form11MovEqRep frm = new Form11MovEqRep();
                            frm.ReportMovEqui.LocalReport.DataSources.Clear();
                            frm.ReportMovEqui.LocalReport.DataSources.Add(rs);
                            if (rbFechaRegSit.Checked == true)
                            {
                                frm.ReportMovEqui.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportMov10PerFFdatatimeSist.rdlc";//fecha del sistema
                                frm.ReportMovEqui.LocalReport.SetParameters(parametros);

                                //frm.groupBox1.Visible_Rsm = false;
                                frm.ShowDialog();
                            }

                            if (rbFechaRegUsuario.Checked == true)
                            {
                                frm.ReportMovEqui.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportMov10PerFFdatatimeUser.rdlc";//fecha del sistema
                                frm.ReportMovEqui.LocalReport.SetParameters(parametros);

                                //frm.groupBox1.Visible_Rsm = false;
                                frm.ShowDialog();
                            }

                        }


                    }
                    else //filtrar por serie y fechas
                    {
                        if (dtFechaAsignacionHasta.Value.Date.CompareTo(dtFechaAsignacionDesde.Value.Date) < 0)
                        {

                            MessageBox.Show("La fecha HASTA tiene que ser mayor a la fecha DESDE");

                        }
                        else
                        {



                            ReportParameter[] parametros = new ReportParameter[3];
                            parametros[0] = new ReportParameter("fechaDesde", dtFechaAsignacionDesde.Value.Date.ToShortDateString());
                            parametros[1] = new ReportParameter("fechaHasta", dtFechaAsignacionHasta.Value.Date.ToShortDateString());
                            parametros[2] = new ReportParameter("persona", tbPersona.Text);


                            rs.Name = "DataSet1";
                            rs.Value = lst;
                            Form11MovEqRep frm = new Form11MovEqRep();
                            frm.ReportMovEqui.LocalReport.DataSources.Clear();
                            frm.ReportMovEqui.LocalReport.DataSources.Add(rs);
                            if (rbFechaRegSit.Checked == true)
                            {
                                frm.ReportMovEqui.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportMov10PerSFFdatatimeSist.rdlc";
                                frm.ReportMovEqui.LocalReport.SetParameters(parametros);

                                //MessageBox.Show(" es fUs " + lst[2274].fecha_registro + " fSist " + lst[2274].fecha_sistema);
                                //frm.groupBox1.Visible_Rsm = false;
                                frm.ShowDialog();

                            }
                            if (rbFechaRegUsuario.Checked == true)
                            {
                                frm.ReportMovEqui.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.ReportMov10PerSFFdatatimeUser.rdlc";
                                frm.ReportMovEqui.LocalReport.SetParameters(parametros);

                                //frm.groupBox1.Visible_Rsm = false;
                                frm.ShowDialog();
                            }

                        }

                    }


                    #endregion

                }

               
                
 
            }

            
            
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btListarPersona_Click(object sender, EventArgs e)
        {
            gbMatriz.Visible = true;
            dgvEquipo.Visible = false;
            tbBuscarEquipo.Visible = false;


            gbMatrizPersona.Visible = true;
            tbBuscarPersona.Visible = true;
            DGVPersonal.Visible = true;
          
          
            mostrarListaPersona();
            
          

        }
        private void mostrarListaPersona()
        {

            //listarPersonal();

            //
            /*CTPersonal clsTPersonal = new CTPersonal();
            DGVPersonal.AutoGenerateColumns = false;
            DGVPersonal.DataSource = clsTPersonal.listar();
             * * */
            ModeloDatoDataContext db = new ModeloDatoDataContext();
             
            var sql = (from T0 in db.Personals
                       
                       select new
                       {
                           doc_entry_personal = T0.doc_entry_personal,

                           c_nombres = T0.c_nombres,
                           c_ape_paterno = T0.c_ape_paterno,
                           c_ape_materno = T0.c_ape_materno,
                           nombre = T0.nombre_completo,
                           fecha_ingreso = T0.fecha_ingreso,
                           c_perfil = T0.c_perfil,
                           activo = "",
                           dni = T0.dni,
                           fecha_desactivacion = "",
                           motivo_desactivacion = "",
                           c_instancia = T0.c_instancia,
                           nombre_instancia = "",
                           c_sede = T0.c_sede,
                           nombre_sede = "",
                           //
                           perfil = "",
                           estado = T0.estado,
                           fecha_nacimiento = T0.fecha_nacimiento,
                           escalafon = T0.escalafon,
                           fecha_termino_lab = T0.fecha_termino_lab,
                           unidad_organica = T0.unidad_organica,
                           area = T0.area,
                           tipo_personal = "",
                           fecha_ingreso_lab = T0.fecha_ingreso_lab,


                       }).OrderBy(x => x.c_nombres);

            DGVPersonal.AutoGenerateColumns = false;
            DGVPersonal.DataSource = sql.ToList();
           
 
        }
      
        private void btListarEquipo_Click(object sender, EventArgs e)
        {
            gbMatriz.Visible = true;
         
            dgvEquipo.Visible = true;
            tbBuscarEquipo.Visible = true;

            gbMatrizPersona.Visible = false;
            DGVPersonal.Visible = false;
            tbBuscarPersona.Visible = false;

            mostrarListaEquipo();

           

        }
        private void mostrarListaEquipo()
        {
            CTEquipo ctequipo = new CTEquipo();
            dgvEquipo.AutoGenerateColumns = false;
            dgvEquipo.DataSource = ctequipo.listar();
 
        }

        private void dgvEquipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvEquipo.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keyEquipo = int.Parse(row.Cells[0].Value.ToString());
                    nombre_equipo = Convert.ToString(row.Cells[1].Value.ToString());
                    serie = Convert.ToString(row.Cells[6].Value.ToString());


                }
            }
            tbEquipo.Text = serie;
            gbMatriz.Visible = false;
        }

        private void tbBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            buscarEquipo();
        }
        private void buscarEquipo()
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            if (tbBuscarEquipo.Text != string.Empty)
            {
                var sql = (from eq in db.Equipos
                           where eq.equipo.Contains(tbBuscarEquipo.Text) ||
                            eq.ip_equipo.Contains(tbBuscarEquipo.Text) ||
                            eq.marca.Contains(tbBuscarEquipo.Text) ||
                            eq.modelo.Contains(tbBuscarEquipo.Text) ||
                            eq.procesador.Contains(tbBuscarEquipo.Text) ||
                            eq.nro_serie.Contains(tbBuscarEquipo.Text) ||
                            eq.nro_control_patrimonial.Contains(tbBuscarEquipo.Text) ||
                            eq.anio_adquisicion.Contains(tbBuscarEquipo.Text) ||
                            eq.observacion.Contains(tbBuscarEquipo.Text) ||
                            eq.nro_orden_compra.Contains(tbBuscarEquipo.Text)
                           select eq).ToList();

                dgvEquipo.DataSource = sql;
            }
            else
            {
                listar();
            }

        }
        private void listar()
        {
            // dgvEquipo.DataSource = null;

            CTEquipo ctequipo = new CTEquipo();
            dgvEquipo.AutoGenerateColumns = false;

            dgvEquipo.DataSource = ctequipo.listar();
        }



        private void buscarPersona()
        {

            if (tbBuscarPersona.Text != string.Empty)
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();


                var sql = (from T0 in db.Personals

                           where
                           
                            T0.dni.Contains(tbBuscarPersona.Text)
                              || T0.nombre_completo.Contains(tbBuscarPersona.Text)
                              || T0.c_nombres.Contains(tbBuscarPersona.Text)
                              || T0.c_ape_paterno.Contains(tbBuscarPersona.Text)
                              || T0.c_ape_materno.Contains(tbBuscarPersona.Text)
                           select new
                           {
                               doc_entry_personal = T0.doc_entry_personal,

                               c_nombres = T0.c_nombres,
                               c_ape_paterno = T0.c_ape_paterno,
                               c_ape_materno = T0.c_ape_materno,
                               nombre = T0.nombre_completo,
                               fecha_ingreso = T0.fecha_ingreso,
                               c_perfil = T0.c_perfil,
                               activo = "",
                               dni = T0.dni,
                               fecha_desactivacion = "",
                               motivo_desactivacion = "",
                               c_instancia = T0.c_instancia,
                               nombre_instancia = "",
                               c_sede = T0.c_sede,
                               nombre_sede = "",
                               //
                               perfil = "",
                               estado = T0.estado,
                               fecha_nacimiento = T0.fecha_nacimiento,
                               escalafon = T0.escalafon,
                               fecha_termino_lab = T0.fecha_termino_lab,
                               unidad_organica = T0.unidad_organica,
                               area = T0.area,
                               tipo_personal = "",
                               fecha_ingreso_lab = T0.fecha_ingreso_lab,


                           }).OrderBy(x => x.c_nombres);


               // DGVPersonal.AutoGenerateColumns = false;
                DGVPersonal.DataSource = sql.ToList();

            }
            else 
            {
                mostrarListaPersona();
            }
           
        }
       
        private void tbBuscarPersona_TextChanged(object sender, EventArgs e)
        {
            buscarPersona();
        }

       int keyPersonal = 0;
        string nombrePers = string.Empty;
        string dni = string.Empty;

        private void DGVPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVPersonal.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keyPersonal = int.Parse(row.Cells[0].Value.ToString());
                    nombrePers = Convert.ToString(row.Cells[5].Value.ToString());
                    dni = Convert.ToString(row.Cells[10].Value.ToString());


                }
            }
            tbPersona.Text = dni;
            gbMatriz.Visible = false;
        }

        public class CHistRegistro
        {
            public string  doc_entry_hist_Reg_Eq { get; set; }
	        public string cod_registro  { get; set; }
	        public string doc_entry_personal { get; set; }
	        public string cod_equipo { get; set; }
	        public DateTime fecha_registro { get; set; }
            public DateTime fecha_sistema { get; set; }
	        public string observacion_registro { get; set; }
	        public string c_usuario { get; set; }
	        public string c_nombres { get; set; }
	        public string c_ape_paterno { get; set; }
	        public string c_ape_materno { get; set; }
	        public string fecha_ingreso { get; set; }
	        public string c_perfil { get; set; }
	        public string estado_personal { get; set; }
	        public string dni { get; set; }
	        public string c_sede { get; set; }
	        public string c_instancia { get; set; }
	        public string fecha_nacimiento { get; set; }
	        public string escalafon { get; set; }
	        public string fecha_ingreso_lab { get; set; }
	        public string fecha_termino_lab { get; set; }
	        public string nombre_completo { get; set; }
	        public string unidad_organica { get; set; }
	        public string area { get; set; }
	        public string tipo_personal { get; set; }
	        public string equipoPadreCod { get; set; }
	        public string equipo { get; set; }
	        public string ip_equipo { get; set; }
	        public string marca { get; set; }
	        public string modelo { get; set; }
	        public string procesador { get; set; }
	        public string nro_serie { get; set; }
	        public string nro_control_patrimonial { get; set; }
	        public string anio_adquisicion { get; set; }
	        public string nro_orden_compra { get; set; }
	        public string activo { get; set; }
	        public string cod_categoria { get; set; }
	        public string observacion_equipo { get; set; }
	        public string fecha_desactivacion { get; set; }
	        public string estado_equipo { get; set; }
	        public string service_tag { get; set; }
            public string funcionamiento { get; set; }
            public string movimiento { get; set; }
            public string fecha_registro_hhmm { get; set; }
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPorEquipo_Click(object sender, EventArgs e)
        {
           
                tbPersona.Enabled = false;
                tbEquipo.Enabled = true;
                btListarPersona.Enabled = false;
                btListarEquipo.Enabled = true;
         
               
            

        }

        private void rbPorpersona_Click(object sender, EventArgs e)
        {
        
                tbPersona.Enabled = true;
                tbEquipo.Enabled = false;
                btListarPersona.Enabled = true;
                btListarEquipo.Enabled = false;

          

        }

        private void DGVPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
