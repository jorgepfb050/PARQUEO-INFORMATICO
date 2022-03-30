using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Reports;
using System.Text.RegularExpressions;

using Viewmodels;
using Microsoft.Reporting.WinForms;
using System.Web.UI.WebControls;
using WindowsFormsApplication1.Login;
using WindowsFormsApplication1;

using WindowsFormsApplication1.Login.ChildForms;
using WindowsFormsApplication1.Login.Helpers;
using Domain;
using Common;




using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Configuration;







namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private List<Form> listChildForms;
        private Form activeChildForm;//Obtiene o establece el formulario secundario mostrado actualmente.
        public Form1()
        {
            InitializeComponent();
            listChildForms = new List<Form>();
           

        }

        /**************************************
        *                                    *
        *       CODIGO DEL Equipo            * 
        *                                    *
        **************************************/
        #region
        private CTEquipo clsTEqupipo = new CTEquipo();
        //int para maneja el indice del dgv
        int keyEquipo = 0;

        public class Equi_comp { 
             public string equipo {get;set;} 
             
             public string serie {get;set;} 
             public string dni {get;set;} 
             public string nombre  {get;set;} 
             public string cod_equipo {get;set;}
             public string equipoPadreCod { get; set; } 
        
        }
        private void tbNombreEquipoNA_TextChanged(object sender, EventArgs e)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var dtListado = (from T0 in db.Equipos

                             select T0.equipo
                              ).Distinct().ToList();


            //cargar los datos para el autocomplete del textbox
            tbNombreEquipoNA.AutoCompleteMode = AutoCompleteMode.Suggest;//AutoCompleteMode.SuggestAppend; //Es el mas bonito
            AutoCompleteStringCollection accl = new AutoCompleteStringCollection();
            accl.AddRange(dtListado.ToArray()); //convertimos la lista en un Array 

            tbNombreEquipoNA.AutoCompleteCustomSource = accl;
            tbNombreEquipoNA.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void tbUnOrganica_TextChanged(object sender, EventArgs e)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var dtListado = (from T0 in db.Personals

                             select T0.unidad_organica
                              ).Distinct().ToList();


            //cargar los datos para el autocomplete del textbox
            tbUnOrganica.AutoCompleteMode = AutoCompleteMode.Suggest;//AutoCompleteMode.SuggestAppend; //Es el mas bonito
            AutoCompleteStringCollection accl = new AutoCompleteStringCollection();
            accl.AddRange(dtListado.ToArray()); //convertimos la lista en un Array 

            tbUnOrganica.AutoCompleteCustomSource = accl;
            tbUnOrganica.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void tbArea_TextChanged(object sender, EventArgs e)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var dtListado = (from T0 in db.Personals

                             select T0.area
                              ).Distinct().ToList();


            //cargar los datos para el autocomplete del textbox
            tbArea.AutoCompleteMode = AutoCompleteMode.Suggest;//AutoCompleteMode.SuggestAppend; //Es el mas bonito
            AutoCompleteStringCollection accl = new AutoCompleteStringCollection();
            accl.AddRange(dtListado.ToArray()); //convertimos la lista en un Array 

            tbArea.AutoCompleteCustomSource = accl;
            tbArea.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
      
        private void dgvEquipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //mostrar si esta asignado
            if (keyEquipo != 0)
            {
                 ModeloDatoDataContext db = new ModeloDatoDataContext();
                var eq_asig= (
                    from T0 in db.Registros join T1 in db.Personals on T0.doc_entry_personal equals T1.doc_entry_personal join T2 in db.Equipos on T0.cod_equipo equals T2.cod_equipo where T0.cod_equipo==keyEquipo select new
                    {
                        equipo=T2.equipo,
                        serie= T2.nro_serie,
                        dni=T1.dni,
                        nombre=T1.nombre_completo,
                        cod_equipo = T2.cod_equipo,
                        equipoPadreCod = T2.equipoPadreCod,

                    }).ToList();
                //lista de componentes
                var lst_comp = (from
                            T1 in db.Equipos
                                where T1.activo == "S" && T1.equipo == "MOUSE" || T1.equipo == "TECLADO" || T1.equipo == "MONITOR"
                                select new
                                {
                                    equipo = T1.equipo,
                                    serie = T1.nro_serie,
                                    dni = "",
                                    nombre = "",
                                    cod_equipo=T1.cod_equipo,
                                    equipoPadreCod=T1.equipoPadreCod,

                                }).ToList();

                List<Equi_comp> lst = new List<Equi_comp>();
                foreach (var nw in eq_asig)
                {
                    Equi_comp act = new Equi_comp();

                    act.equipo = Convert.ToString(nw.equipo);
                    act.serie = Convert.ToString(nw.serie);

                    act.dni = Convert.ToString(nw.dni);
                    act.nombre = Convert.ToString(nw.nombre);
                    act.cod_equipo = Convert.ToString(nw.cod_equipo);
                    act.equipoPadreCod = Convert.ToString(nw.equipoPadreCod);
                    lst.Add(act);
                    
                    foreach (var lcom in lst_comp)
                    {
                        if (Convert.ToString(nw.cod_equipo) == Convert.ToString(lcom.equipoPadreCod))
                        {
                            Equi_comp componente = new Equi_comp();

                            componente.equipo = Convert.ToString(lcom.equipo);
                            componente.serie = Convert.ToString(lcom.serie);

                            componente.dni = Convert.ToString(nw.dni);
                            componente.nombre = Convert.ToString(nw.nombre);
                            componente.cod_equipo = Convert.ToString(lcom.cod_equipo);
                            componente.equipoPadreCod = Convert.ToString(lcom.equipoPadreCod);                          

                            lst.Add(componente);


                        }
                    }


                }
                 //si es un componente el registro seleccionado
                var lstHijo=(
                    from T1 in db.Equipos where T1.cod_equipo == keyEquipo && (T1.equipo == "MOUSE" || T1.equipo == "TECLADO" || T1.equipo == "MONITOR") select T1
                    ).ToList();
                if (lstHijo.Count()>0)
                {
                    var lstPadre = (from
                         T2 in db.Equipos
                                    join T3 in db.Registros on T2.cod_equipo equals T3.cod_equipo
                                    join T4 in db.Personals on T3.doc_entry_personal equals T4.doc_entry_personal
                                    where T2.cod_equipo == lstHijo[0].equipoPadreCod
                                    select new
                                    {

                                        dni = T4.dni,
                                        nombre = T4.nombre_completo,

                                    }).ToList();
                    if (lstPadre.Count()>0)
                    {
                        MessageBox.Show("El/La " + lstHijo[0].equipo + " de serie: " + lstHijo[0].nro_serie + ", esta asignado a: " + lstPadre[0].nombre + ", con dni: " + lstPadre[0].dni);
                    }
 
                }
               

                if (lst.Count() > 0)
                {
                    MessageBox.Show("El/La " + lst[0].equipo + " de serie: " + lst[0].serie + ", esta asignado a: " + lst[0].nombre + ", con dni: " + lst[0].dni);
                }
               

               
            }
          
        }

        private void btRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                Equipo objEquipo = new Equipo();

                int nro = Convert.ToInt32((from s in db.Equipos where s.nro_serie == tbNroSerie.Text select s).Count().ToString());
                if (nro == 0)
                {
                    if (tbNombreEquipoNA.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el nombre de equipo");
                        tbNombreEquipoNA.Focus();

                    }
                    else
                    {
                        if (tbMarcaNA.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese la MarcaNA");
                            tbMarcaNA.Focus();
                        }
                        else
                        {
                            if (tbNroSerieNA.Text == string.Empty)
                            {
                                MessageBox.Show("Ingrese el Nro de Serie");
                                tbNroSerieNA.Focus();
                            }
                            else
                            {
                                if (tbModeloNA.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese el Modelo");
                                    tbModeloNA.Focus();
                                }
                                else
                                {
                                    if (tbNroControlPatrimonialNA.Text == string.Empty)
                                    {
                                        MessageBox.Show("Ingrese el Control Patrimonial");
                                        tbNroControlPatrimonialNA.Focus();
                                    }
                                    else
                                    {
                                        if (cbEstadoEquipoNA.Text == string.Empty)
                                        {
                                            MessageBox.Show("Ingrese el Estado de Equipo");
                                            cbEstadoEquipoNA.Focus();
                                        }
                                        else
                                        {
                                            if (cbAnioCompraNA.Text == string.Empty)
                                            {
                                                MessageBox.Show("Ingrese el Año de Compra");
                                                cbAnioCompraNA.Focus();
                                            }
                                            else
                                            {
                                                if (cbCatEqNA.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Ingrese la Categoria de equipo");
                                                    cbCatEqNA.Focus();
                                                }
                                                else
                                                {
                                                    int pcod_equipo = 0;
                                                    int count = (from s in db.Equipos select s).Count();
                                                    if (count == 0)
                                                    {
                                                        objEquipo.cod_equipo = pcod_equipo + 1;
                                                    }
                                                    else
                                                    {
                                                        objEquipo.cod_equipo = Convert.ToInt32(db.Equipos.Select(p => p.cod_equipo).Max()) + 1;
                                                    }

                                                    objEquipo.equipo = tbNombreEquipoNA.Text;
                                                    objEquipo.ip_equipo = tbIpNA.Text;
                                                    objEquipo.marca = tbMarcaNA.Text;
                                                    objEquipo.modelo = tbModeloNA.Text;
                                                    objEquipo.procesador = tbProcesadorNA.Text;
                                                    objEquipo.nro_serie = tbNroSerieNA.Text;
                                                    objEquipo.nro_control_patrimonial = tbNroControlPatrimonialNA.Text;
                                                    objEquipo.anio_adquisicion = cbAnioCompraNA.Text;
                                                    objEquipo.nro_orden_compra = tbNroOrdenCompraNA.Text;
                                                    objEquipo.observacion = tbObseracionNA.Text;
                                                    objEquipo.cod_categoria = Convert.ToInt32(cbCatEqNA.SelectedValue);


                                                    // registrar el campo cbEquipoPadreCod si el equipo es teclado, mause o monitor (categoria componete pc)
                                                    //validar para que se muestre el combo se muestra y registra el codigo. el combo recibe los codigos de cpu
                                                    objEquipo.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodNA.SelectedValue);


                                                    //al registrar por este medio no esta asignado
                                                    objEquipo.activo = "N";//Convert.ToString(cbAsignadoNA.SelectedItem.ToString());
                                                    objEquipo.estado = Convert.ToString(cbEstadoEquipoNA.SelectedItem.ToString());
                                                    objEquipo.service_tag = tbServiceTagNA.Text;
                                                    objEquipo.funcionamiento = tbFuncionamientoNA.Text;

                                                    DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                    switch (dr)
                                                    {
                                                        case DialogResult.Yes:
                                                            CTRegistro p_clsTRegistro = new CTRegistro();
                                                            clsTEqupipo.registrar(objEquipo);
                                                            limpiar();
                                                            MessageBox.Show("Registro realizado");
                                                            listar(); 
                                                            tbNombreEquipo.Focus();

                                                            break;
                                                        case DialogResult.No:
                                                            break;
                                                    }


                                                   
                                                }
 
                                            }
 
                                        }
 
                                    }
 
                                }
                            }
 
                            
                               


                        }
                 
 
                    }

                   
                   
                }
                else { MessageBox.Show("El Equipo ya esta registrado"); }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }



        }
        private void limpiar()
        {
            tbNombreEquipoNA.Text = string.Empty;
            tbIpNA.Text = string.Empty;
            tbMarcaNA.Text = string.Empty;
            tbModeloNA.Text = string.Empty;
            tbProcesadorNA.Text = string.Empty;
            tbNroSerieNA.Text = string.Empty;
            tbNroControlPatrimonialNA.Text = string.Empty;
            cbAnioCompraNA.SelectedIndex = -1;
            tbNroOrdenCompraNA.Text = string.Empty;
            tbObseracionNA.Text = string.Empty;
            cbAsignadoNA.SelectedIndex = -1;
            cbEquipoPadreCodNA.SelectedIndex = -1;
            cbCatEqNA.SelectedIndex = -1;
            tbServiceTagNA.Text = string.Empty;
            tbFuncionamientoNA.Text = string.Empty;
            cbEstadoEquipo.SelectedIndex = -1;
            cbEquipoPadreCodNA.Enabled = false;
        }
        private void listar()
        {
           // dgvEquipo.DataSource = null;
            
            CTEquipo ctequipo = new CTEquipo();
            dgvEquipo.AutoGenerateColumns = false;
            dgvEquipo.DataSource = ctequipo.listar();
        }

        private void btLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();

        }

        private void btActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
               

                int nro = Convert.ToInt32((from s in db.Equipos where s.nro_serie == tbNroSerie.Text select s).Count().ToString());
                if (nro == 0)
                {
                    if (tbNombreEquipoNA.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el nombre de equipo");
                        tbNombreEquipoNA.Focus();

                    }
                    else
                    {
                        if (tbMarcaNA.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese la MarcaNA");
                            tbMarcaNA.Focus();
                        }
                        else
                        {
                            if (tbNroSerieNA.Text == string.Empty)
                            {
                                MessageBox.Show("Ingrese el Nro de Serie");
                                tbNroSerieNA.Focus();
                            }
                            else
                            {
                                if (tbModeloNA.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese el Modelo");
                                    tbModeloNA.Focus();
                                }
                                else
                                {
                                    if (tbNroControlPatrimonialNA.Text == string.Empty)
                                    {
                                        MessageBox.Show("Ingrese el Control Patrimonial");
                                        tbNroControlPatrimonialNA.Focus();
                                    }
                                    else
                                    {
                                        if (cbEstadoEquipoNA.Text == string.Empty)
                                        {
                                            MessageBox.Show("Ingrese el Estado de Equipo");
                                            cbEstadoEquipoNA.Focus();
                                        }
                                        else
                                        {
                                            if (cbAnioCompraNA.Text == string.Empty)
                                            {
                                                MessageBox.Show("Ingrese el Año de Compra");
                                                cbAnioCompraNA.Focus();
                                            }
                                            else
                                            {
                                                if (cbCatEqNA.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Ingrese la Categoria de equipo");
                                                    cbCatEqNA.Focus();
                                                }
                                                else
                                                {
                                                    Equipo objEquipo_ = new Equipo();
                                                    objEquipo_.cod_equipo =  keyEquipo;
                                                   
                                                    objEquipo_.equipo = tbNombreEquipoNA.Text;
                                                    objEquipo_.ip_equipo = tbIpNA.Text;
                                                    objEquipo_.marca = tbMarcaNA.Text;
                                                    objEquipo_.modelo = tbModeloNA.Text;
                                                    objEquipo_.procesador = tbProcesadorNA.Text;
                                                    objEquipo_.nro_serie = tbNroSerieNA.Text;
                                                    objEquipo_.nro_control_patrimonial = tbNroControlPatrimonialNA.Text;
                                                    objEquipo_.anio_adquisicion = cbAnioCompraNA.Text;
                                                    objEquipo_.nro_orden_compra = tbNroOrdenCompraNA.Text;
                                                    objEquipo_.observacion = tbObseracionNA.Text;
                                                    objEquipo_.cod_categoria = Convert.ToInt32(cbCatEqNA.SelectedValue);


                                                    // registrar el campo cbEquipoPadreCod si el equipo es teclado, mause o monitor (categoria componete pc)
                                                    //validar para que se muestre el combo se muestra y registra el codigo. el combo recibe los codigos de cpu
                                                    objEquipo_.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodNA.SelectedValue);


                                                    //al registrar por este medio no esta asignado
                                                    objEquipo_.activo = Convert.ToString(cbAsignadoNA.SelectedItem.ToString());//"N";//Convert.ToString(cbAsignadoNA.SelectedItem.ToString());
                                                    objEquipo_.estado = Convert.ToString(cbEstadoEquipoNA.SelectedItem.ToString());
                                                    objEquipo_.service_tag = tbServiceTagNA.Text;
                                                    objEquipo_.funcionamiento = tbFuncionamientoNA.Text;

                                                    DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                                                    switch (dr)
                                                    {
                                                        case DialogResult.Yes:
                                                            CTEquipo _cteEquipo1_ = new CTEquipo();
                                                            _cteEquipo1_.actualizar(objEquipo_);
                                                            limpiar();
                                                            MessageBox.Show("Registro Actualizado");
                                                            listar();
                                                            tbNombreEquipo.Focus();

                                                            break;
                                                        case DialogResult.No:
                                                            break;
                                                    }



                                                }

                                            }

                                        }

                                    }

                                }
                            }





                        }


                    }



                }
                else { MessageBox.Show("El Equipo ya esta registrado"); }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

            
            
            
            
          /*  
            
            
            try
            {
                if (keyEquipo != 0 && tbNombreEquipo.Text != string.Empty)
                {
                    Equipo objEquipo = new Equipo();
                    objEquipo.cod_equipo = keyEquipo;
                    objEquipo.equipo = tbNombreEquipo.Text;
                    objEquipo.ip_equipo = tbIp.Text;
                    objEquipo.marca = tbMarca.Text;
                    objEquipo.modelo = tbModelo.Text;
                    objEquipo.procesador = tbProcesador.Text;
                    objEquipo.nro_serie = tbNroSerie.Text;
                    objEquipo.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                    objEquipo.anio_adquisicion = cbAnioCompra.Text;
                    objEquipo.nro_orden_compra = tbNroOrdenCompra.Text;
                    objEquipo.observacion = tbObseracion.Text;
                    objEquipo.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);

                    // registrar el campo cbEquipoPadreCod si el equipo es teclado, mause o monitor (categoria componete pc)
                    //validar para que se muestre el combo se muestra y registra el codigo. el combo recibe los codigos de cpu
                    objEquipo.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCod.SelectedValue);
                    objEquipo.estado = Convert.ToString(cbEstadoEquipo.SelectedItem);
                    objEquipo.activo = Convert.ToString(cbAsignado.SelectedItem);
                    objEquipo.service_tag = tbServiceTag.Text;

                    DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                           clsTEqupipo.actualizar(objEquipo);
                            limpiar();
                             MessageBox.Show("Registro actualizado");
                             listar();
                            break;
                        case DialogResult.No:
                            break;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la lista");
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }


            */


        }

        private void obtenerEquipo(int pkeyEquipo)
        {
            cargarAnioCompra_softAE(cbAnioCompraNA);
            CTEquipo clsTEqupipo_ = new CTEquipo();
            Equipo objeto = clsTEqupipo_.obtener(pkeyEquipo);

            tbNombreEquipoNA.Text = objeto.equipo;
            tbIpNA.Text = objeto.ip_equipo;
            tbMarcaNA.Text = objeto.marca;
            tbModeloNA.Text = objeto.modelo;
            tbProcesadorNA.Text = objeto.procesador;
            tbNroSerieNA.Text = objeto.nro_serie;
            tbNroControlPatrimonialNA.Text = objeto.nro_control_patrimonial;
            cbAnioCompraNA.Text = Convert.ToString(objeto.anio_adquisicion); //            cbAnioCompra.Text = Convert.ToString(sql3[0]._cbAnioCompra.ToString());
            tbNroOrdenCompraNA.Text = objeto.nro_orden_compra;
            tbObseracionNA.Text = objeto.observacion;
            cbAsignadoNA.Text = objeto.activo;
            cbEstadoEquipoNA.Text = objeto.estado;
            tbServiceTagNA.Text = objeto.service_tag;
            
            tbFuncionamientoNA.Text = objeto.funcionamiento;
            //obtener cbcat
            ModeloDatoDataContext db = new ModeloDatoDataContext();



            var sql1 = (from eq in db.Equipos
                        join cat in db.Categorias on eq.cod_categoria equals cat.cod_categoria
                        where eq.cod_equipo == pkeyEquipo
                        select new
                        {
                            cod_cat = eq.cod_categoria,
                            categ = cat.categoria,
                        }).ToList();

            cbCatEqNA.DataSource = sql1;
            cbCatEqNA.ValueMember = "cod_cat";
            cbCatEqNA.DisplayMember = "categ";


            //obtener padreid


            ModeloDatoDataContext dcd = new ModeloDatoDataContext();
            var keyPadreCod = (from eq2 in dcd.Equipos where eq2.cod_equipo == keyEquipo select eq2.equipoPadreCod).ToList();

            var sql = (from eq in dcd.Equipos
                       where eq.cod_equipo == keyPadreCod[0]
                       select new
                       {
                           id = eq.cod_equipo,
                           concatenado = (keyPadreCod[0] == 0) ? " " : eq.equipo + " Serie: " + eq.nro_serie,
                           // concatenado = (eq.equipoPadreCod == 0) ? "No es componente " : (eq.nro_serie + " -- " + eq.nombre),

                       }).ToList();

            cbEquipoPadreCodNA.DataSource = sql;
            cbEquipoPadreCodNA.ValueMember = "id";
            cbEquipoPadreCodNA.DisplayMember = "concatenado";



            //  lbvalue.Text = sql[0].id.ToString();
            // lbdisplay.Text = sql[0].concatenado.ToString();

        }


        private void btEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (keyEquipo != 0 && tbNombreEquipoNA.Text != string.Empty)
                {
                    clsTEqupipo.eliminar(keyEquipo);
                    limpiar();
                    MessageBox.Show("registro eliminado");
                    listar();

                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }


        }
        private void btListarEq_Click_1(object sender, EventArgs e)
        {
            listar();

        }

        private void dgvEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            foreach (DataGridViewRow row in dgvEquipo.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keyEquipo = int.Parse(row.Cells[0].Value.ToString());
                    obtenerEquipo(keyEquipo);

                }
            }


            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var sql = (from eq in db.Equipos where eq.equipoPadreCod == keyEquipo select eq).ToList();

            /*   if(sql[0].equipoPadreCod != 0)
               {
                   cbEquipoPadreCod.Visible = true;
                   lbEquipoPadreCod.Visible = true;
              
               }
               else
               {
                   cbEquipoPadreCod.Visible = false;
                   lbEquipoPadreCod.Visible = false;
               }
               */
            DGVComponentesPc.AutoGenerateColumns = false;
            DGVComponentesPc.DataSource = sql;




        }

        /*--------CARGAR DATOS EN CAMPO----*/

        private void cargarCategorias()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var listCategorias = from cat in dc.Categorias select cat; //new{ cat.cod_categoria, cat.categoria };
            cbCatEq.DataSource = listCategorias.ToList();
            cbCatEq.ValueMember = "cod_categoria";
            cbCatEq.DisplayMember = "categoria";

        }
        private void cargarEquipoPadre()
        {

            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var listEqPadre = (from eq in dc.Equipos
                               where eq.equipoPadreCod == 0
                               select new
                               {
                                   id = eq.cod_equipo,
                                   concatenado = eq.nro_serie + " - " + eq.equipo,
                               }).ToList();
            listEqPadre.Insert(0, new { id = 0, concatenado = "    " });

            cbEquipoPadreCod.DataSource = listEqPadre;
            cbEquipoPadreCod.ValueMember = "id";
            cbEquipoPadreCod.DisplayMember = "concatenado";


        }

        private void cbCatEq_MouseClick(object sender, MouseEventArgs e)
        {
            cargarCategorias();

        }
        private void cbEquipoPadreCod_MouseClick_1(object sender, MouseEventArgs e)
        {

            cargarEquipoPadre();

        }
        //mostra pestañas del control tab
        private void tabPage9_Click(object sender, EventArgs e)
        {
            //mostrar la pestaña
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
        private void setFilterInformation(string name)
        {
            ModeloDatoDataContext bd = new ModeloDatoDataContext();
            if (name == string.Empty)
            {
                dgvEquipo.DataSource = null;
                dgvEquipo.DataSource = dgvEquipo;
            }
            else
            {
                var result = (from eq in bd.Equipos where eq.nro_serie == "name" select eq).ToList();
                dgvEquipo.DataSource = result;
            }
        }
        private DataTable convertDgvToDT(DataGridView dgv)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dgv.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            return dt;
        }
        private void cbAnioCompra_Click_1(object sender, EventArgs e)
        {

            cargarAnioCompra();

        }
        private void cargarAnioCompra()
        {
            cbAnioCompra.DataSource = null;
            cbAnioCompra.Items.Clear();
            cbAnioCompra.Items.Add("S/A");
            int aActual = DateTime.Now.Year;


            for (int anio = 1999; anio <= aActual; anio++)
            {
                cbAnioCompra.Items.Add(Convert.ToString(anio));
            }
            cbAnioCompra.SelectedIndex = 0;

        }
        private void cbAnioCompra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese un Año", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }


        #endregion

        /**************************************
        *                                    *
        *       CODIGO DE CATEGORIA         * 
        *                                    *
        **************************************/
        #region

        CTCategoria clsTCategoria = new CTCategoria();
        //int para maneja el indice del dgv
        int keyEquipoCat = 0;


        private void btREgistrarCat_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                Categoria objCat = new Categoria();
                //int nroSof = Convert.ToInt32(db.Softwares.Count().ToString());
                int nro = Convert.ToInt32((from s in db.Categorias where s.categoria == tbNomCategoria.Text select s).Count().ToString());
                if (nro == 0)
                {
                    if (tbNomCategoria.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese una Categoría Valida");
                        tbNomCategoria.Focus();

                    }
                    else
                    {
                        if (cbActivoCat.Text == string.Empty)
                        {
                            MessageBox.Show("Indicar si esta activo");
                            cbActivoCat.Focus();
                        }
                        objCat.categoria = tbNomCategoria.Text;
                        objCat.observacion = tbDescripcionCat.Text;

                        objCat.activo = cbActivoCat.SelectedItem.ToString();

                        DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                clsTCategoria.registrar(objCat);
                                limpiarCat();
                                MessageBox.Show("Registro realizado");
                                listarCat();
                                tbNomCategoria.Focus();
                                break;
                            case DialogResult.No:
                                break;
                        }



                    }

                }
                else { MessageBox.Show("La Categoría ya existe"); tbNomCategoria.Focus(); }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }



        }
        private void btLimpiarCat_Click_1(object sender, EventArgs e)
        {
            limpiarCat();
            tbNomCategoria.Focus();
        }

        private void btActualizarCat_Click_1(object sender, EventArgs e)
        {



            try
            {
                if (keyEquipoCat != 0 && tbNomCategoria.Text != string.Empty)
                {


                    Categoria objCat = new Categoria();
                    objCat.cod_categoria = keyEquipoCat;
                    objCat.categoria = tbNomCategoria.Text;
                    objCat.observacion = tbDescripcionCat.Text;
                    objCat.activo = cbActivoCat.Text;

                    DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTCategoria.actualizar(objCat);
                            limpiarCat();
                            MessageBox.Show("Registro Actualizado");
                            listarCat();
                            tbNomCategoria.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }



                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }

        private void btEliminarCat_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (keyEquipoCat != 0 && tbNomCategoria.Text != string.Empty)
                {

                    DialogResult dr = MessageBox.Show("Desea Eliminar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTCategoria.eliminar(keyEquipoCat);
                            limpiarCat();
                            MessageBox.Show("registro eliminado");
                            listarCat();
                            tbNomCategoria.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }


                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                    tbNomCategoria.Focus();
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);

            }


        }
        private void limpiarCat()
        {

            tbNomCategoria.Text = string.Empty;
            tbDescripcionCat.Text = string.Empty; ;
            cbActivoCat.SelectedIndex = -1;
            DGVCategoria.DataSource = null;
        }
        private void listarCat()
        {
            DGVCategoria.AutoGenerateColumns = false;
            DGVCategoria.DataSource = clsTCategoria.listar();
        }

        private void DGVCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        public void obtenerCat(int pkeyEquipo)
        {
            Categoria objCat = clsTCategoria.obtener(pkeyEquipo);
            tbNomCategoria.Text = objCat.categoria;
            tbDescripcionCat.Text = objCat.observacion;
            cbActivoCat.Text = objCat.activo;
        }

        private void btListarCategoria_Click_1(object sender, EventArgs e)
        {
            listarCat();
            desableFormCategoria();
            rbNuevoCat.Checked = false;
            rbEditarCat.Checked = false;
            DGVCategoria.Enabled = true;
            btREgistrarCat.Enabled = false;
            btActualizarCat.Enabled = false;



        }
        private void desableFormCategoria()
        {
            tbNomCategoria.Enabled = false;
            tbDescripcionCat.Enabled = false;
            cbActivoCat.Enabled = false;
        }
        private void enableFormCategoria()
        {
            tbNomCategoria.Enabled = true;
            tbDescripcionCat.Enabled = true;
            cbActivoCat.Enabled = true;

        }
        private void DGVCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVCategoria.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keyEquipoCat = int.Parse(row.Cells[0].Value.ToString());
                    obtenerCat(keyEquipoCat);
                }
            }
        }





        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
        private void tbBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            buscarCategoria();
        }
        private void buscarCategoria()
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            if (tbBuscarCategoria.Text != string.Empty)
            {
                var sql = (from cat in db.Categorias
                           where cat.categoria.Contains(tbBuscarCategoria.Text) ||
                                 cat.observacion.Contains(tbBuscarCategoria.Text)
                           select cat).ToList();

                DGVCategoria.DataSource = sql;
            }
            else
            {
                listarCat();
            }
        }
        private void rbEditarCat_Click(object sender, EventArgs e)
        {
            btREgistrarCat.Enabled = false;
            btActualizarCat.Enabled = true;
            enableFormCategoria();

            listarCat();
            DGVCategoria.Enabled = true;
            tbNomCategoria.Focus();
        }

        private void rbNuevoCat_Click(object sender, EventArgs e)
        {
            btREgistrarCat.Enabled = true;
            btActualizarCat.Enabled = false;
            enableFormCategoria();
            limpiarCat();
            DGVCategoria.Enabled = false;
            listarCat();
            tbNomCategoria.Focus();

        }


        #endregion

        /**************************************
        *                                    *
        *       CODIGO DE SOFTWARE          * 
        *                                    *
        **************************************/
        #region
        CTSoftware clsTSoftware = new CTSoftware();
        //int para maneja el indice del dgv
        int keySoft = 0;


        private void btnRegistrarSoft_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                Software objSoft = new Software();
                //int nroSof = Convert.ToInt32(db.Softwares.Count().ToString());
                int nroSof = Convert.ToInt32((from s in db.Softwares where s.software == tbSoftware.Text select s).Count().ToString());
                if (nroSof == 0)
                {
                    if (tbSoftware.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el nombre del Software");
                        tbSoftware.Focus();
                    }
                    else
                    {
                        if (tbVersionSoft.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese a versión del software");
                            tbVersionSoft.Focus();

                        }
                        else
                        {
                            objSoft.software = tbSoftware.Text;
                            objSoft.version = tbVersionSoft.Text;

                            if (tbCantUsuarios.Text != string.Empty)
                            {
                                objSoft.cantidad_usuarios = Convert.ToInt32(tbCantUsuarios.Text);
                            }
                            else
                            {
                                objSoft.cantidad_usuarios = 0;
                            }

                            objSoft.nro_orden_compra = tbNroOCSoft.Text;
                            objSoft.anio_aquisicion = cbAnioAquisSoft.Text;
                            objSoft.observacion = tbObservacionSoft.Text;
                            objSoft.activo = cbActivoSoft.SelectedItem.ToString();

                            DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                    clsTSoftware.registrar(objSoft);
                                    MessageBox.Show("Registro realizado");
                                    limpiarSoft();
                                    listarSoft();
                                    tbSoftware.Focus();
                                    break;
                                case DialogResult.No:
                                    break;
                            }




                        }
                    }

                }
                else { MessageBox.Show("Ingrese un Software y versión Validos"); tbSoftware.Focus(); }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }


        }

        private void listarSoft()
        {
            DGVSoftware.AutoGenerateColumns = false;
            DGVSoftware.DataSource = clsTSoftware.listar();
        }

        private void DGVSoftware_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVSoftware.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keySoft = int.Parse(row.Cells[0].Value.ToString());
                    obtenerSoft(keySoft);
                }
            }
        }


        private void btnLimpiarSoft_Click(object sender, EventArgs e)
        {
            limpiarSoft();
        }
        private void DGVSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in DGVSoftware.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keySoft = int.Parse(row.Cells[0].Value.ToString());
                    obtenerSoft(keySoft);
                }
            }
        }

        private void btnActualizarSoft_Click(object sender, EventArgs e)
        {
            try
            {
                if (keySoft != 0 && tbSoftware.Text != string.Empty)
                {
                    Software objSoft = new Software();
                    objSoft.cod_software = keySoft;
                    objSoft.software = tbSoftware.Text;
                    objSoft.version = tbVersionSoft.Text;
                    if (tbCantUsuarios.Text != string.Empty)
                    {
                        objSoft.cantidad_usuarios = Convert.ToInt32(tbCantUsuarios.Text);
                    }
                    else
                    {
                        objSoft.cantidad_usuarios = 0;
                    }

                    objSoft.nro_orden_compra = tbNroOCSoft.Text;
                    objSoft.anio_aquisicion = cbAnioAquisSoft.Text;
                    objSoft.observacion = tbObservacionSoft.Text;
                    objSoft.activo = Convert.ToString(cbActivoSoft.SelectedItem);

                    DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTSoftware.actualizar(objSoft);
                            limpiarSoft();
                            MessageBox.Show("Registro actualizado");
                            listarSoft();
                            tbSoftware.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }



                }

                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                    tbSoftware.Focus();
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }
        }


        private void btnEliminarSoft_Click(object sender, EventArgs e)
        {
            try
            {
                if (keySoft != 0 && tbSoftware.Text != string.Empty)
                {
                    DialogResult dr = MessageBox.Show("Desea Eliminar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTSoftware.eliminar(keySoft);
                            limpiarSoft();
                            //keySoft = 0;
                            MessageBox.Show("registro eliminado");
                            listarSoft();
                            tbSoftware.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }


                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                    tbSoftware.Focus();
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }
        private void btListarSoft_Click(object sender, EventArgs e)
        {
            listarSoft();
            desableformSoft();
            rbNuevoSof.Checked = false;

            rbEditarSof.Checked = false;
            DGVSoftware.Enabled = true;
            btnRegistrarSoft.Enabled = false;
            btnActualizarSoft.Enabled = false;
            btnRegistrarSoft.Enabled = false;
            btnActualizarSoft.Enabled = false;

        }

        private void limpiarSoft()
        {
            tbSoftware.Text = string.Empty;
            tbVersionSoft.Text = string.Empty;
            tbCantUsuarios.Text = string.Empty;
            tbNroOCSoft.Text = string.Empty;
            cbAnioAquisSoft.Text = string.Empty;
            cbAnioAquisSoft.SelectedIndex = -1;
            tbObservacionSoft.Text = string.Empty;
            cbActivoSoft.SelectedIndex = -1;

            DGVSoftware.DataSource = null;


        }
        public void obtenerSoft(int pkeySoft)
        {
            Software objeto = clsTSoftware.obtener(pkeySoft);

            tbSoftware.Text = objeto.software;
            tbVersionSoft.Text = objeto.version;
            tbCantUsuarios.Text = Convert.ToString(objeto.cantidad_usuarios);
            tbNroOCSoft.Text = objeto.nro_orden_compra;
            cbAnioAquisSoft.Text = objeto.anio_aquisicion;
            tbObservacionSoft.Text = objeto.activo;
            cbActivoSoft.Text = objeto.activo;

        }
        private void tbBuscarSoft_TextChanged(object sender, EventArgs e)
        {
            buscarSoftware();
        }
        private void buscarSoftware()
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            if (tbBuscarSoft.Text != string.Empty)
            {
                var sql = (from sof in db.Softwares
                           where sof.software.Contains(tbBuscarSoft.Text) ||
                         sof.version.Contains(tbBuscarSoft.Text) ||
                         sof.nro_orden_compra.Contains(tbBuscarSoft.Text) ||
                         sof.anio_aquisicion.Contains(tbBuscarSoft.Text) ||
                         sof.observacion.Contains(tbBuscarSoft.Text)
                           select sof).ToList();

                DGVSoftware.DataSource = sql;
            }
            else
            {
                listarSoft();
            }
        }
        private void cbAnioAquisSoft_Click(object sender, EventArgs e)
        {
            cbAnioAquisSoft.Items.Add("S/A");
            int aActual = DateTime.Now.Year;


            for (int anio = 1999; anio <= aActual; anio++)
            {
                cbAnioAquisSoft.Items.Add(Convert.ToString(anio));
            }



        }

        private void tbCantUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }



        }
        private void cbAnioAquisSoft_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese un Año", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

        }

        private void rbNuevoSof_Click(object sender, EventArgs e)
        {
            btnRegistrarSoft.Enabled = true;
            btnActualizarSoft.Enabled = false;
            enableformSoft();
            limpiarSoft();
            listarSoft();
            DGVSoftware.Enabled = false;
            tbSoftware.Focus();

        }

        private void rbEditarSof_Click(object sender, EventArgs e)
        {
            btnRegistrarSoft.Enabled = false;
            btnActualizarSoft.Enabled = true;
            enableformSoft();
            listarSoft();
            DGVSoftware.Enabled = true;
            tbSoftware.Focus();
        }
        private void enableformSoft()
        {
            tbSoftware.Enabled = true;
            tbVersionSoft.Enabled = true;
            tbCantUsuarios.Enabled = true;
            tbNroOCSoft.Enabled = true;
            cbAnioAquisSoft.Enabled = true;
            tbObservacionSoft.Enabled = true;
            cbActivoSoft.Enabled = true;

        }
        private void desableformSoft()
        {
            tbSoftware.Enabled = false;
            tbVersionSoft.Enabled = false;
            tbCantUsuarios.Enabled = false;
            tbNroOCSoft.Enabled = false;
            cbAnioAquisSoft.Enabled = false;
            tbObservacionSoft.Enabled = false;
            cbActivoSoft.Enabled = false;

        }

        private void cbSoftware_SoftAE_Leave(object sender, EventArgs e)
        {
            if (cbSoftware_SoftAE.Text != string.Empty)
            {
                cargarAnioCompra_softAE(cbAnioCompraSoftAE);
                ModeloDatoDataContext db = new ModeloDatoDataContext();

                int reg_Sof = (from T0 in db.Softwares
                               where T0.software == cbSoftware_SoftAE.Text
                               select T0).Count();

                if (reg_Sof > 0)
                {
                    var sql = (from T0 in db.Softwares

                               where T0.software == cbSoftware_SoftAE.Text
                               select T0.cod_software).ToList();

                    obtenerSoft_softAE(sql[0]);
                    // tbVersionSoftAE.Focus();

                }
                else
                {

                    tbVersionSoftAE.Text = String.Empty;
                    tbCantidadUsSoftAE.Text = String.Empty;
                    tbOCSoftAE.Text = String.Empty;
                    cbAnioCompraSoftAE.SelectedIndex = -1;
                    tbObsvSoftAE.Text = String.Empty;
                    cbActivoSoftAE.SelectedIndex = -1;
                    dtFechaInstalacionSoftAE.Text = String.Empty;
                    dtFechaCaducidadSoftAE.Text = String.Empty;


                }



            }

        }

        #endregion


        /**************************************
        *                                     *
        *       CODIGO DE SEDE                * 
        *                                     *
        **************************************/

        #region
        CTSede clsTSede = new CTSede();
        int keySede = 0;


        private void btListarSede_Click_1(object sender, EventArgs e)
        {
            DGVSede.Enabled = true;
            DGVSede.AutoGenerateColumns = false;
            DGVSede.DataSource = clsTSede.listar();



            tbNombreSede.Enabled = false;
            tbDireccSede.Enabled = false;
            rbNuevaSede.Checked = false;
            rbEditarSede.Checked = false;
            tbNombreSede.Focus();
            btRegistrarSede.Enabled = false;
            btActualizarSede.Enabled = false;
        }

        private void btRegistrarSede_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                //int nroSof = Convert.ToInt32(db.Softwares.Count().ToString());
                int nro = Convert.ToInt32((from s in db.Sedes where s.nombre_sede == tbNombreSede.Text select s).Count().ToString());
                int cod_sede = Convert.ToInt32((from s in db.Sedes select s).Count().ToString());
                if (nro == 0)
                {
                    if (tbNombreSede.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el nombre de la sede");
                        tbNombreSede.Focus();
                    }
                    else
                    {
                        if (tbDireccSede.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese la dirección");
                            tbDireccSede.Focus();

                        }
                        else
                        {
                            Sede obj = new Sede();
                            if (cod_sede > 0)
                            {
                                /*int var_sede = db.Sedes.Select(p => p.c_sede).DefaultIfEmpty(0).Max();*/
                                int var_sede = Convert.ToInt32(db.Sedes.Select(p => p.c_sede).Max());
                                obj.c_sede = var_sede + 1;
                            }
                            else
                            {

                                obj.c_sede = cod_sede + 1;
                            }

                            obj.nombre_sede = tbNombreSede.Text;
                            obj.direccion = tbDireccSede.Text;
                            obj.observacion = tbObservSede.Text;
                            //obj.activo = cbActivoSede.SelectedItem.ToString();
                            // obj.c_distrito = Convert.ToInt32(cbDistritoJud_sede.SelectedValue);
                            // obj.c_provincia = Convert.ToInt32(cbProvincia_Sede.SelectedValue);
                            DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                    clsTSede.registrar(obj);
                                    limpiarSede();
                                    MessageBox.Show("Registro realizado");
                                    listarSede();
                                    tbNombreSede.Focus();

                                    break;
                                case DialogResult.No:
                                    break;
                            }



                        }

                    }

                }


                else { MessageBox.Show("La Sede ya existe"); tbNombreSede.Focus(); tbNombreSede.Focus(); }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }


        }

        private void btLimpiarSede_Click_1(object sender, EventArgs e)
        {
            limpiarSede();
        }

        private void btActualizarSede_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (keySede != 0 && tbNombreSede.Text != string.Empty)
                {
                    Sede obj = new Sede();
                    obj.c_sede = keySede;
                    obj.nombre_sede = tbNombreSede.Text;
                    obj.direccion = tbDireccSede.Text;
                    obj.observacion = tbObservSede.Text;

                    //obj.activo = cbActivoSede.SelectedItem.ToString();
                    //obj.c_distrito = Convert.ToInt32(cbDistritoJud_sede.SelectedValue);
                    //obj.c_provincia = Convert.ToInt32(cbProvincia_Sede.SelectedValue);
                    DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTSede.actualizar(obj);
                            limpiarSede();
                            MessageBox.Show("Registro actualizado");
                            listarSede();
                            tbNombreSede.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }



                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la lista");
                    tbNombreSede.Focus();
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }

        private void btEliminarSede_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (keySede != 0 && tbNombreSede.Text != string.Empty)
                {
                    DialogResult dr = MessageBox.Show("Desea Eliminar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTSede.eliminar(keySede);
                            limpiarSede();
                            MessageBox.Show("registro eliminado");
                            listarSede();
                            tbNombreSede.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }


                }
                else
                { MessageBox.Show("Seleciones un Registro de la lista"); }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }

        private void DGVSede_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVSede.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keySede = int.Parse(row.Cells[0].Value.ToString());
                    obtenerSede(keySede);
                }
            }

        }

        private void limpiarSede()
        {
            tbNombreSede.Text = string.Empty;
            tbDireccSede.Text = string.Empty;
            tbObservSede.Text = string.Empty;
            cbActivoSede.SelectedIndex = -1;
            cbDistritoJud_sede.SelectedIndex = -1;
            cbProvincia_Sede.SelectedIndex = -1;
            DGVSede.DataSource = null;

        }
        private void listarSede()
        {
            DGVSede.AutoGenerateColumns = false;
            DGVSede.DataSource = clsTSede.listar();
        }



        public void obtenerSede(int pkey)
        {
            Sede objeto = clsTSede.obtener(pkey);
            tbNombreSede.Text = objeto.nombre_sede;
            tbDireccSede.Text = objeto.direccion;
            tbObservSede.Text = objeto.observacion;
            cbActivoSede.Text = objeto.activo;

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql1 = (from T0 in db.Sedes

                        join T1 in db.Distritos
                        on T0.c_distrito equals T1.c_distrito

                        where (T0.c_sede == pkey)
                        select new
                        {
                            id_dist = T0.c_distrito,
                            nombre_dist = T1.x_nom_distrito,


                        }).ToList();

            cbDistritoJud_sede.DataSource = sql1;
            cbDistritoJud_sede.ValueMember = "id_dist";
            cbDistritoJud_sede.DisplayMember = "nombre_dist";

            var sql2 = (from T0 in db.Provincias

                        where (T0.c_provincia == objeto.c_provincia && T0.c_distrito == objeto.c_distrito)
                        select new
                        {

                            id_prov = T0.c_provincia,
                            nombre_prov = T0.x_nom_provincia,

                        }).ToList();

            cbProvincia_Sede.DataSource = sql2;
            cbProvincia_Sede.ValueMember = "id_prov";
            cbProvincia_Sede.DisplayMember = "nombre_prov";

        }
        private void tbBuscarSede_TextChanged(object sender, EventArgs e)
        {
            buscarSede();
        }

        private void buscarSede()
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            if (tbBuscarSede.Text != string.Empty)
            {
                var sql = (from sed in db.Sedes
                           where sed.nombre_sede.Contains(tbBuscarSede.Text) ||

                           sed.direccion.Contains(tbBuscarSede.Text) ||
                           sed.observacion.Contains(tbBuscarSede.Text)

                           select sed).ToList();

                DGVSede.DataSource = sql;
            }
            else
            {
                listarSede();
            }
        }
        private void cargarCBDistritoJud_Sede()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sql = (from s in dc.Distritos select s).ToList(); //new{ cat.cod_categoria, cat.categoria };
            cbDistritoJud_sede.DataSource = sql;
            cbDistritoJud_sede.ValueMember = "c_distrito";
            cbDistritoJud_sede.DisplayMember = "x_nom_distrito";
            cbDistritoJud_sede.SelectedValue = 24;



        }
        private void cargarCBProvincia_Sede()
        {
            if (cbDistritoJud_sede.SelectedIndex > 0)
            {
                int c_dis = Convert.ToInt32(cbDistritoJud_sede.SelectedValue);

                ModeloDatoDataContext dc = new ModeloDatoDataContext();
                int contador = (from s in dc.Provincias where s.c_distrito == c_dis select s).Count();
                if (contador > 0)
                {
                    var sql = (from s in dc.Provincias where s.c_distrito == c_dis select s).ToList(); //new{ cat.cod_categoria, cat.categoria };
                    cbProvincia_Sede.DataSource = sql;
                    cbProvincia_Sede.ValueMember = "c_provincia";
                    cbProvincia_Sede.DisplayMember = "x_nom_provincia";
                }
                else
                {
                    cbProvincia_Sede.DataSource = null;
                    cbProvincia_Sede.Items.Clear();

                }



            }



        }
        private void cbDistritoJud_sede_MouseClick(object sender, MouseEventArgs e)
        {



        }


        private void cbDistritoJud_sede_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCBProvincia_Sede();
        }
        private void cbDistritoJud_Instanc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbDistritoJud_sede_Click(object sender, EventArgs e)
        {
            cargarCBDistritoJud_Sede();

        }
        private void btLimpiarPersonal__Click(object sender, EventArgs e)
        {
            limpiarPersonal();
        }

        private void rbNuevaSede_Click(object sender, EventArgs e)
        {
            limpiarSede();
            DGVSede.Enabled = false;

            btListarSede.Enabled = true;
            btRegistrarSede.Enabled = true;
            btLimpiarSede.Enabled = true;
            btActualizarSede.Enabled = false;
            btEliminarSede.Enabled = true;
            btImpSede.Enabled = true;
            tbNombreSede.Enabled = true;
            tbDireccSede.Enabled = true;
            tbNombreSede.Focus();
            tbDniPersonal.Focus();
            listarSede();
        }

        private void rbEditarSede_Click(object sender, EventArgs e)
        {
            DGVSede.Enabled = true;
            btListarSede.Enabled = true;
            btRegistrarSede.Enabled = false;
            btLimpiarSede.Enabled = true;
            btActualizarSede.Enabled = true;
            btEliminarSede.Enabled = true;
            btImpSede.Enabled = true;
            tbNombreSede.Enabled = true;

            tbNombreSede.Enabled = true;
            tbDireccSede.Enabled = true;
            tbNombreSede.Focus();
            listarSede();


        }


        #endregion

        /**************************************
        *                                    *
        *       CODIGO DE INSTANCIA         * 
        *                                    *
        **************************************/
        #region

        CTInstancia clsTInstancia = new CTInstancia();

        int keyC_Sede_instancia = 0;
        string keyC_instancia = "";

        private void btListarInst_Click_1(object sender, EventArgs e)
        {

            DGVInstancia.Enabled = true;
            DGVInstancia.AutoGenerateColumns = false;
            //DGVInstancia.DataSource = clsTInstancia.listar();

            rbNuevaInst.Checked = false;
            rbEditarInst.Checked = false;

            cbSede_Instanc.Enabled = false;
            tbNombreInst.Enabled = false;

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql = (from T0 in db.Instancias
                       join T1 in db.Sedes on T0.c_sede equals T1.c_sede
                       orderby T1.nombre_sede, T0.nombre_instancia
                       select new
                       {
                           c_instancia = T0.c_instancia,
                           c_sede = T0.c_sede,
                           nombre_instancia = T0.nombre_instancia,
                           x_ubicacion_fisica = T0.x_ubicacion_fisica,
                           activo = T0.activo,
                           nro_instancia = T0.nro_instancia,
                           nombre_sede = T1.nombre_sede,
                       }).ToList();
            DGVInstancia.DataSource = sql;
            tbNombreInst.Focus();
            btRegistrarIns.Enabled = false;
            btActualizarInst.Enabled = false;
        }

        private void btRegistrarIns_Click_1(object sender, EventArgs e)
        {
            try
            {


                Instancia obj = new Instancia();
                ModeloDatoDataContext db = new ModeloDatoDataContext();



                if (tbNombreInst.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese el nombre de instancia");
                    tbNombreInst.Focus();
                }
                else
                {
                    if (cbSede_Instanc.Text == string.Empty)
                    {
                        MessageBox.Show("Seleccione una sede");
                        cbSede_Instanc.Focus();
                    }
                    else
                    {
                        int reg_inst = (from T0 in db.Instancias where T0.nombre_instancia == tbNombreInst.Text && T0.c_sede == Convert.ToInt32(cbSede_Instanc.SelectedValue) select T0).ToList().Count();

                        if (reg_inst != 0)
                        {
                            MessageBox.Show("El registro ya existe");
                            tbNombreInst.Focus();
                        }
                        else
                        {
                            obj.c_sede = Convert.ToInt32(cbSede_Instanc.SelectedValue);

                            var maxValue = (from T0 in db.Instancias orderby T0.c_instancia descending select T0.c_instancia).Take(1).ToList();





                            obj.c_instancia = Convert.ToString(Convert.ToInt32(maxValue[0].ToString()) + 1);


                            obj.nombre_instancia = tbNombreInst.Text;
                            obj.nro_instancia = tbNroInst.Text;
                            //obj.activo = cbActivoInst.SelectedItem.ToString();
                            obj.x_ubicacion_fisica = tbDirInstancia.Text;
                            DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                    clsTInstancia.registrar(obj);
                                    limpiarInstancia();
                                    MessageBox.Show("Registro realizado");
                                    listarInstancia();
                                    tbNombreInst.Focus();
                                    break;
                                case DialogResult.No:
                                    break;
                            }

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

        private void btLimpiarInst_Click_1(object sender, EventArgs e)
        {
            limpiarInstancia();
        }

        private void btActualizarInst_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (keyC_Sede_instancia != 0 && keyC_instancia != "" && tbNombreInst.Text != "")
                {
                    Instancia obj = new Instancia();
                    obj.c_instancia = keyC_instancia;
                    obj.c_sede = keyC_Sede_instancia;
                    obj.nombre_instancia = tbNombreInst.Text;
                    obj.nro_instancia = tbNroInst.Text;
                    obj.x_ubicacion_fisica = tbDirInstancia.Text;
                    if (Convert.ToInt32(cbSede_Instanc.SelectedValue) == keyC_Sede_instancia)//actualizar todo menos la sede
                    {
                        //obj.activo = cbActivoInst.SelectedItem.ToString();    

                        DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                clsTInstancia.actualizar(obj);
                                limpiarInstancia();
                                MessageBox.Show("Registro actualizado");
                                listarInstancia();
                                tbNombreInst.Focus();
                                break;
                            case DialogResult.No:
                                break;
                        }

                    }
                    else
                    {


                        DialogResult dr2 = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                        switch (dr2)
                        {
                            case DialogResult.Yes:
                                clsTInstancia.eliminar(keyC_Sede_instancia, keyC_instancia);

                                listarInstancia();
                                //crear la instancia
                                Instancia obj2 = new Instancia();
                                ModeloDatoDataContext db = new ModeloDatoDataContext();
                                int reg_inst = (from T0 in db.Instancias where T0.nombre_instancia == tbNombreInst.Text && T0.c_sede == Convert.ToInt32(cbSede_Instanc.SelectedValue) select T0).ToList().Count();

                                if (reg_inst != 0)
                                {
                                    MessageBox.Show("El registro ya existe");
                                }
                                else
                                {
                                    obj2.c_sede = Convert.ToInt32(cbSede_Instanc.SelectedValue);
                                    var maxValue = (from T0 in db.Instancias orderby T0.c_instancia descending select T0.c_instancia).Take(1).ToList();
                                    /* int cod = 10000;
                                     string pc_instancia = Convert.ToString(cod + (from T0 in db.Instancias
                                                                                   where T0.c_sede == Convert.ToInt32(cbSede_Instanc.SelectedValue)
                                                                                   select T0).Count() + 1);
                                     */

                                    obj2.c_instancia = Convert.ToString(Convert.ToInt32(maxValue[0].ToString()) + 1); // pc_instancia;


                                    obj2.nombre_instancia = tbNombreInst.Text;
                                    obj2.nro_instancia = tbNroInst.Text;
                                    //obj.activo = cbActivoInst.SelectedItem.ToString();
                                    obj2.x_ubicacion_fisica = tbDirInstancia.Text;

                                    clsTInstancia.registrar(obj2);


                                    //clsTInstancia.actualizar(obj);
                                    limpiarInstancia();
                                    MessageBox.Show("Registro actualizado");

                                    listarInstancia();
                                    tbNombreInst.Focus();

                                }
                                break;
                            case DialogResult.No:
                                break;
                        }


                    }




                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la lista");
                }
            }

            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }

        private void btEliminarIns_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (keyC_Sede_instancia != 0 && keyC_instancia != "" && tbNombreInst.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Desea Eliminar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTInstancia.eliminar(keyC_Sede_instancia, keyC_instancia);
                            limpiarInstancia();
                            MessageBox.Show("registro eliminado");
                            listarInstancia();
                            tbNombreInst.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }


                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }


        }
        private void DGVInstancia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVInstancia.Rows)
            {
                if (row.Index == e.RowIndex)
                {

                    keyC_Sede_instancia = int.Parse(row.Cells[0].Value.ToString());
                    keyC_instancia = (row.Cells[1].Value.ToString());
                    obtenerInstancia(keyC_Sede_instancia, keyC_instancia);
                }
            }
        }


        private void limpiarInstancia()
        {


            tbNombreInst.Text = string.Empty;
            tbNroInst.Text = string.Empty;
            // cbActivoInst.SelectedIndex = -1;

            //cbSede_Instanc.SelectedIndex = -1;
            tbDirInstancia.Text = string.Empty;
            DGVInstancia.DataSource = null;
        }
        private void listarInstancia()
        {
            DGVInstancia.AutoGenerateColumns = false;
            // DGVInstancia.DataSource = clsTInstancia.listar();

            DGVInstancia.Enabled = true;
            DGVInstancia.AutoGenerateColumns = false;
            //DGVInstancia.DataSource = clsTInstancia.listar();

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql = (from T0 in db.Instancias
                       join T1 in db.Sedes on T0.c_sede equals T1.c_sede
                       orderby T1.nombre_sede, T0.nombre_instancia
                       select new
                       {
                           c_instancia = T0.c_instancia,
                           c_sede = T0.c_sede,
                           nombre_instancia = T0.nombre_instancia,
                           x_ubicacion_fisica = T0.x_ubicacion_fisica,
                           activo = T0.activo,
                           nro_instancia = T0.nro_instancia,
                           nombre_sede = T1.nombre_sede,
                       }).ToList();
            DGVInstancia.DataSource = sql;
            tbNombreInst.Focus();


        }
        public void obtenerInstancia(int keyC_Sede_instancia, string keyC_instancia)
        {
            Instancia objeto = clsTInstancia.obtener(keyC_Sede_instancia, keyC_instancia);
            tbNombreInst.Text = objeto.nombre_instancia;
            tbNroInst.Text = objeto.nro_instancia;
            cbActivoInst.Text = objeto.activo;

            //obtener sede
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql = from T0 in db.Sedes
                      where T0.c_sede == objeto.c_sede
                      select new
                      {
                          c_sede = T0.c_sede,
                          nombre_sede = T0.nombre_sede,
                      };
            cbSede_Instanc.DataSource = sql.ToList();
            cbSede_Instanc.ValueMember = "c_sede";
            cbSede_Instanc.DisplayMember = "nombre_sede";
            tbDirInstancia.Text = objeto.x_ubicacion_fisica;


            /*      var sql = (from T0 in db.Instancias
                             join T1 in db.Distritos on T0.c_distrito equals T1.c_distrito
                             join T2 in db.Provincias on T0.c_provincia equals T2.c_provincia
                             join T3 in db.Sedes on T0.c_sede equals T3.c_sede
                             where T0.c_distrito == keyC_distrito && T0.c_provincia == keyC_provincia && T0.c_instancia == keyC_instancia
                             select new                       
                             {
                                 c_distrito = T0.c_distrito,
                                 nombre_dist = T1.x_nom_distrito,
                                 c_provincia= T0.c_provincia,
                                 nombre_prov= T2.x_nom_provincia,
                                 c_sede= T0.c_sede,
                                 nombre_sede= T3.nombre_sede,



                             }).ToList();
                  //obtener distrito
                  cbDistritoJud_Instanc.DataSource = sql;
                  cbDistritoJud_Instanc.ValueMember = "c_distrito";
                  cbDistritoJud_Instanc.DisplayMember = "nombre_dist";
                  //obtener provincia
                  cbDistritoJud_Instanc.DataSource = sql;
                  cbDistritoJud_Instanc.ValueMember = "c_provincia";
                  cbDistritoJud_Instanc.DisplayMember = "nombre_prov";

                  //obtener sede
                  cbDistritoJud_Instanc.DataSource = sql;
                  cbDistritoJud_Instanc.ValueMember = "c_sede";
                  cbDistritoJud_Instanc.DisplayMember = "nombre_sede";
             * */

        }

        private void tbInstancia_TextChanged(object sender, EventArgs e)
        {
            buscarInstancia();
        }
        private void buscarInstancia()
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            if (tbInstancia.Text != string.Empty)
            {
                var sql = (from inst in db.Instancias
                           where inst.nombre_instancia.Contains(tbInstancia.Text) ||
                           inst.nro_instancia.Contains(tbInstancia.Text) ||
                           inst.x_ubicacion_fisica.Contains(tbInstancia.Text) ||
                           Convert.ToString(inst.c_sede).Contains(tbInstancia.Text) ||
                             inst.c_instancia.Contains(tbInstancia.Text) ||
                              inst.x_ubicacion_fisica.Contains(tbInstancia.Text)
                           select inst).ToList();
                DGVInstancia.DataSource = sql;
            }
            else
            {
                listarInstancia();
            }
        }
        private void cargarCBDistritoJud_Instancia()
        {
            /* ModeloDatoDataContext dc = new ModeloDatoDataContext();
             var sql = (from s in dc.Distritos select s).ToList(); //new{ cat.cod_categoria, cat.categoria };
             cbDistritoJud_Instanc.DataSource = sql;
             cbDistritoJud_Instanc.ValueMember = "c_distrito";
             cbDistritoJud_Instanc.DisplayMember = "x_nom_distrito";*/

        }
        private void cbDistritoJud_Instanc_MouseClick(object sender, MouseEventArgs e)
        {
            cargarCBDistritoJud_Instancia();
        }

        private void cbSede_Instanc_Click(object sender, EventArgs e)
        {
            cargarCBSede_instancia();
        }
        private void cargarCBSede_instancia()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from T0 in dc.Sedes orderby T0.nombre_sede select T0).ToList();


            cbSede_Instanc.DataSource = sq;
            cbSede_Instanc.ValueMember = "c_sede";
            cbSede_Instanc.DisplayMember = "nombre_sede";

        }


        private void rbNuevaInst_Click(object sender, EventArgs e)
        {
            limpiarInstancia();
            DGVInstancia.Enabled = false;
            btListarInst.Enabled = true;
            btRegistrarIns.Enabled = true;
            btLimpiarInst.Enabled = true;
            btActualizarInst.Enabled = false;
            btEliminarIns.Enabled = true;
            btImpInstancia.Enabled = true;
            cbSede_Instanc.Enabled = true;

            cbSede_Instanc.Enabled = true;
            tbNombreInst.Enabled = true;
            tbNombreInst.Focus();
            listarInstancia();
            DGVInstancia.Enabled = false;


        }

        private void rbEditarInst_Click(object sender, EventArgs e)
        {
            DGVInstancia.Enabled = true;
            btListarInst.Enabled = true;
            btRegistrarIns.Enabled = false;
            btLimpiarInst.Enabled = true;
            btActualizarInst.Enabled = true;
            btEliminarIns.Enabled = true;
            btImpInstancia.Enabled = true;
            cbSede_Instanc.Enabled = false;

            cbSede_Instanc.Enabled = true;
            tbNombreInst.Enabled = true;
            tbNombreInst.Focus();
        }

        private void cbSede_Instanc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                tbNombreInst.Focus();
            }
        }


        #endregion


        /*************************************
        *                                    *
        *       CODIGO DE PERSONAL           *
        *                                    *
        **************************************/
        #region

        CTPersonal clsTPersonal = new CTPersonal();
        int keyPErsonal = 0;
        private void btRegistrarPersonal_Click(object sender, EventArgs e)
        {



        }

        private void btListarPersonal_Click(object sender, EventArgs e)
        {
            listarPersonal();
        }

        private void btLimpiarPersonal_Click(object sender, EventArgs e)
        {
            limpiarPersonal();
        }

        private void btActualizarPers_Click(object sender, EventArgs e)
        {

        }

        private void btEliminarPers_Click(object sender, EventArgs e)
        {


        }
        public void RemoveItemFromCache(Object sender, EventArgs e)
        {


        }
        //DataGridView DGVPersonal = new DataGridView();



        private void DGVPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVPersonal.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keyPErsonal = int.Parse(row.Cells[0].Value.ToString());
                    obtenerPersonal(keyPErsonal);

                }
            }

        }
        private void obtenerPersonal(int keyPErsonal)
        {

            Personal objeto = clsTPersonal.obtener(keyPErsonal);
            string tipo_personal = objeto.tipo_personal;
            if (tipo_personal == "A")
            {

                rbPerAdmi.Checked = true;
                label51.Visible = true;
                label52.Visible = true;
                tbUnOrganica.Visible = true;
                tbArea.Visible = true;
                tbNombrePersonal.Text = objeto.c_nombres;
                tbPaternoPersonal.Text = objeto.c_ape_paterno;
                tbMaternoPersonal.Text = objeto.c_ape_materno;
                dtPersonal.Text = objeto.fecha_ingreso;
                dtFechaNacPersonal.Text = objeto.fecha_nacimiento;
                tbEscalafon.Text = objeto.escalafon;
                dtFechaIngresoLaboral.Text = objeto.fecha_ingreso_lab;
                dtFechaTerminoLaboral.Text = objeto.fecha_termino_lab;
                tbUnOrganica.Text = objeto.unidad_organica;
                tbArea.Text = objeto.area;


                //obtener perfil
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                var sql1 = (
                           from T0 in db.Personals
                           join T1 in db.Perfils
                           on T0.c_perfil equals T1.c_perfil

                           where T0.doc_entry_personal == keyPErsonal
                           select new
                           {
                               id_perfil_ = T0.c_perfil,
                               perfil_ = T1.perfil,

                           }).ToList();

                cbPerfilPersonal.DataSource = sql1;
                cbPerfilPersonal.ValueMember = "id_perfil_";
                cbPerfilPersonal.DisplayMember = "perfil_";

                //sede
                var sql2 = (
                          from T0 in db.Personals
                          join T2 in db.Sedes on T0.c_sede equals T2.c_sede

                          where T0.doc_entry_personal == keyPErsonal
                          select new
                          {

                              id_sede = T0.c_sede,
                              nombre_sede = T2.nombre_sede,


                          }).ToList();

                cbSedePersonal.DataSource = sql2;
                cbSedePersonal.ValueMember = "id_sede";
                cbSedePersonal.DisplayMember = "nombre_sede";

                //intaancia
                var sql3 = (
                         from T0 in db.Personals
                         join T2 in db.Instancias on T0.c_instancia equals T2.c_instancia

                         where T0.doc_entry_personal == keyPErsonal
                         select new
                         {

                             id_inst = T0.c_sede,
                             nombre_inst = T2.nombre_instancia,

                         }).ToList();
                cbInstanciaPersonal.DataSource = sql3;
                cbInstanciaPersonal.ValueMember = "id_inst";
                cbInstanciaPersonal.DisplayMember = "nombre_inst";
                cbEstadoPersonal.Text = objeto.estado;
                tbDniPersonal.Text = objeto.dni;

                /* if (objeto.activo.Equals("N"))
                 {
                     dtFechaDescPErsonal.Visible = true;
                     tbMotivoDesacPersonal.Visible = true;
                     label70.Visible = true;
                     label65.Visible = true;
                     dtFechaDescPErsonal.Text = objeto.fecha_desactivacion;
                     tbMotivoDesacPersonal.Text = objeto.motivo_desactivacion;
                 }
                 else
                 {
                     dtFechaDescPErsonal.Visible = false;
                     tbMotivoDesacPersonal.Visible = false;
                     label70.Visible = false;
                     label65.Visible = false;
                     dtFechaDescPErsonal.Text = objeto.fecha_desactivacion;
                     tbMotivoDesacPersonal.Text = objeto.motivo_desactivacion;
 
                 }*/


            }
            else//juridiccional
            {
                limpiarPersonal();
                rbPerJur.Checked = true;
                label51.Visible = false;
                label52.Visible = false;
                tbUnOrganica.Visible = false;
                tbArea.Visible = false;
                cbInstanciaPersonal.Visible = true;
                tbNombrePersonal.Text = objeto.c_nombres;
                tbPaternoPersonal.Text = objeto.c_ape_paterno;
                tbMaternoPersonal.Text = objeto.c_ape_materno;
                dtPersonal.Text = objeto.fecha_ingreso;
                dtFechaNacPersonal.Text = objeto.fecha_nacimiento;
                tbEscalafon.Text = objeto.escalafon;
                dtFechaIngresoLaboral.Text = objeto.fecha_ingreso_lab;
                dtFechaTerminoLaboral.Text = objeto.fecha_termino_lab;


                //obtener perfil
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                var sql1 = (
                           from T0 in db.Personals
                           join T1 in db.Perfils
                           on T0.c_perfil equals T1.c_perfil

                           where T0.doc_entry_personal == keyPErsonal
                           select new
                           {
                               id_perfil_ = T0.c_perfil,
                               perfil_ = T1.perfil,

                           }).ToList();

                cbPerfilPersonal.DataSource = sql1;
                cbPerfilPersonal.ValueMember = "id_perfil_";
                cbPerfilPersonal.DisplayMember = "perfil_";

                //sede
                var sql2 = (
                          from T0 in db.Personals

                          join T2 in db.Sedes
                          on T0.c_sede equals T2.c_sede
                          join T3 in db.Instancias on T0.c_instancia equals T3.c_instancia
                          where T0.doc_entry_personal == keyPErsonal && T2.c_sede == T3.c_sede
                          select new
                          {

                              id_sede = T0.c_sede,
                              nombre_sede = T2.nombre_sede,
                              id_inst = T0.c_instancia,
                              nombre_inst = T3.nombre_instancia,

                          }).ToList();

                cbSedePersonal.DataSource = sql2;
                cbSedePersonal.ValueMember = "id_sede";
                cbSedePersonal.DisplayMember = "nombre_sede";


                cbInstanciaPersonal.DataSource = sql2;
                cbInstanciaPersonal.ValueMember = "id_inst";
                cbInstanciaPersonal.DisplayMember = "nombre_inst";
                cbEstadoPersonal.Text = objeto.estado;
                tbDniPersonal.Text = objeto.dni;

                /* if (objeto.activo.Equals("N"))
                 {
                     dtFechaDescPErsonal.Visible = true;
                     tbMotivoDesacPersonal.Visible = true;
                     label70.Visible = true;
                     label65.Visible = true;
                     dtFechaDescPErsonal.Text = objeto.fecha_desactivacion;
                     tbMotivoDesacPersonal.Text = objeto.motivo_desactivacion;
                 }
                 else
                 {
                     dtFechaDescPErsonal.Visible = false;
                     tbMotivoDesacPersonal.Visible = false;
                     label70.Visible = false;
                     label65.Visible = false;
                     dtFechaDescPErsonal.Text = objeto.fecha_desactivacion;
                     tbMotivoDesacPersonal.Text = objeto.motivo_desactivacion;
 
                 }*/
            }



        }

        private void cargarCBPerfil()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sql = (from per in dc.Perfils orderby per.perfil select per).ToList(); //new{ cat.cod_categoria, cat.categoria };
            cbPerfilPersonal.DataSource = sql;
            cbPerfilPersonal.ValueMember = "c_perfil";
            cbPerfilPersonal.DisplayMember = "perfil";

        }

        private void listarPersonal()
        {
            /* DGVPersonal.AutoGenerateColumns = false;
             DGVPersonal.DataSource = clsTPersonal.listar();
             ModeloDatoDataContext db = new ModeloDatoDataContext();
             var sql_PersonalGLB = (from T0 in db.Personals
                        join T1 in db.Sedes on T0.c_sede equals T1.c_sede
                       // join T2 in db.Instancias on T0.c_instancia equals T2.c_instancia

                        select new {
                            doc_entry_personal= T0.doc_entry_personal,
                           
                            c_nombres=T0.c_nombres,
                            c_ape_paterno= T0.c_ape_paterno,
                            c_ape_materno=T0.c_ape_materno,
                            nombre = T0.nombre_completo,
                            fecha_ingreso=T0.fecha_ingreso,
                          
                            c_perfil=T0.c_perfil,
                           activo="",
                            dni=T0.dni,
                           fecha_desactivacion="",
                           motivo_desactivacion="",
                            c_instancia=T0.c_instancia,
                            nombre_instancia="",//T2.nombre_instancia,
                            c_sede=T0.c_sede,
                            nombre_sede= T1.nombre_sede
                        

                        }).ToList();
             DGVPersonal.AutoGenerateColumns = false;
             DGVPersonal.DataSource = sql;
  
             */
        }
        private void limpiarPersonal()
        {


            tbNombrePersonal.Text = string.Empty;
            tbMaternoPersonal.Text = string.Empty;
            tbPaternoPersonal.Text = string.Empty;

            dtPersonal.Text = string.Empty;
            dtFechaNacPersonal.Text = string.Empty;
            tbEscalafon.Text = string.Empty;

            cbPerfilPersonal.SelectedIndex = -1;
            cbSedePersonal.SelectedIndex = -1;

            cbInstanciaPersonal.SelectedIndex = -1;
            cbEstadoPersonal.SelectedIndex = -1;
            tbDniPersonal.Text = string.Empty;
            dtFechaIngresoLaboral.Text = string.Empty;
            dtFechaTerminoLaboral.Text = string.Empty;
            tbUnOrganica.Text = string.Empty;
            tbArea.Text = string.Empty;





        }
        private void cbPerfil_MouseClick(object sender, MouseEventArgs e)
        {
            cargarCBPerfil();
        }
        private void tbPersonal_TextChanged(object sender, EventArgs e)
        {
            //  buscarPersonal();
        }
        private void buscarPersonal()
        {
            /*   
             ModeloDatoDataContext db = new ModeloDatoDataContext();
             if (tbPersonal.Text != string.Empty)
             {

               
                 var sql = (from T0 in db.Personals
                            join T1 in db.Sedes on T0.c_sede equals T1.c_sede
                            join T2 in db.Instancias on T0.c_instancia equals T2.c_instancia
                            where T0.c_nombres.Contains(tbPersonal.Text) ||
                           T0.c_ape_paterno.Contains(tbPersonal.Text) ||
                           T0.c_ape_materno.Contains(tbPersonal.Text) ||
                            T0.nombre_completo.Contains(tbPersonal.Text) ||
                           T0.fecha_ingreso.Contains(tbPersonal.Text) ||
                           T0.observacion.Contains(tbPersonal.Text) ||
                           T0.dni.Contains(tbPersonal.Text)
                            select new
                            {
                                doc_entry_personal = T0.doc_entry_personal,
                                c_usuario = T0.c_usuario,
                                c_nombres = T0.c_nombres,
                                c_ape_paterno = T0.c_ape_paterno,
                                c_ape_materno = T0.c_ape_materno,
                                nombre = T0.c_ape_paterno + " " + T0.c_ape_materno + " " + T0.c_nombres,
                                fecha_ingreso = T0.fecha_ingreso,
                                observacion = T0.observacion,
                                c_perfil = T0.c_perfil,
                                activo = T0.activo,
                                dni = T0.dni,
                                fecha_desactivacion = T0.fecha_desactivacion,
                                motivo_desactivacion = T0.motivo_desactivacion,
                                c_instancia = T0.c_instancia,
                                nombre_instancia = T2.nombre_instancia,
                                c_sede = T0.c_sede,
                                nombre_sede = T1.nombre_sede


                            });
                 DGVPersonal.AutoGenerateColumns = false;
                DGVPersonal.DataSource = sql.ToList();



                
               
             }
             else
             {
                 listarPersonal();
             }
          */
        }

        private void cargarCBSede_Personal()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sql = (from s in dc.Sedes orderby s.nombre_sede select new { c_sede = s.c_sede, nombre_sede = s.nombre_sede }).ToList(); //;
            sql.Insert(0, new { c_sede = 0, nombre_sede = "---seleccionar---" });
            cbSedePersonal.DataSource = sql;
            cbSedePersonal.ValueMember = "c_sede";
            cbSedePersonal.DisplayMember = "nombre_sede";


        }
        private void cargarCBInstancia_Personal()
        {
            if (cbSedePersonal.SelectedIndex > 0)
            {
                int c_sede = Convert.ToInt32(cbSedePersonal.SelectedValue);


                ModeloDatoDataContext dc = new ModeloDatoDataContext();
                int contador = (from inst in dc.Instancias where inst.c_sede == c_sede select inst).Count();
                if (contador > 0)
                {
                    var sql = (from inst in dc.Instancias where inst.c_sede == c_sede orderby inst.nombre_instancia select inst).ToList(); //new{ cat.cod_categoria, cat.categoria };


                    cbInstanciaPersonal.DataSource = sql;
                    cbInstanciaPersonal.ValueMember = "c_instancia";
                    cbInstanciaPersonal.DisplayMember = "nombre_instancia";
                }
                else
                {
                    cbInstanciaPersonal.DataSource = null;
                    cbInstanciaPersonal.Items.Clear();

                }

            }
            /*
             *  if (cbDistritoJud_sede.SelectedIndex > 0)
            {
                 int c_dis = Convert.ToInt32(cbDistritoJud_sede.SelectedValue);         
           
                ModeloDatoDataContext dc = new ModeloDatoDataContext();
                int contador = (from s in dc.Provincias where s.c_distrito == c_dis select s).Count();
                if (contador > 0)
                {
                    var sql = (from s in dc.Provincias where s.c_distrito == c_dis select s).ToList(); //new{ cat.cod_categoria, cat.categoria };
                    cbProvincia_Sede.DataSource = sql;
                    cbProvincia_Sede.ValueMember = "c_provincia";
                    cbProvincia_Sede.DisplayMember = "x_nom_provincia";
                }
                else
                {
                    cbProvincia_Sede.DataSource = null;
                    cbProvincia_Sede.Items.Clear();
 
                }
             * */


        }

        private void tbDniPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //if existe el dni cargar datos
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                int existe = (from T0 in db.Personals where T0.dni == tbDniPersonal.Text select T0).Count();
                var cod_personal = (from T0 in db.Personals where T0.dni == tbDniPersonal.Text select T0.doc_entry_personal).ToList();

                if (existe > 0)//existe dni--> cargar datos
                {
                    keyPErsonal = cod_personal[0];
                    obtenerPersonal(cod_personal[0]);

                    rbPerAdmi.Enabled = false;
                    rbPerJur.Enabled = false;

                    rbNuevaPersonal.Checked = false;
                    rbEditarPersonal.Checked = false;

                    if (rbPerJur.Checked)
                    {
                        cbInstanciaPersonal.Visible = true;
                    }
                    else
                    {
                        cbInstanciaPersonal.Visible = false;
                    }
                    desableFormPersonal();

                }

            }
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
        private void enableFormPersonal()
        {
            tbPaternoPersonal.Enabled = true;
            tbMaternoPersonal.Enabled = true;
            tbNombrePersonal.Enabled = true;
            tbUnOrganica.Enabled = true;
            tbArea.Enabled = true;
            dtFechaNacPersonal.Enabled = true;
            dtPersonal.Enabled = true;
            tbEscalafon.Enabled = true;
            cbEstadoPersonal.Enabled = true;
            cbSedePersonal.Enabled = true;
            cbPerfilPersonal.Enabled = true;
            dtFechaIngresoLaboral.Enabled = true;
            chbFTerminoLaboral.Enabled = true;
            dtFechaTerminoLaboral.Enabled = true;
            cbInstanciaPersonal.Enabled = true;

        }
        private void desableFormPersonal()
        {
            tbPaternoPersonal.Enabled = false;
            tbMaternoPersonal.Enabled = false;
            tbNombrePersonal.Enabled = false;
            tbUnOrganica.Enabled = false;
            tbArea.Enabled = false;
            dtFechaNacPersonal.Enabled = false;
            dtPersonal.Enabled = false;
            tbEscalafon.Enabled = false;
            cbEstadoPersonal.Enabled = false;
            cbSedePersonal.Enabled = false;
            cbPerfilPersonal.Enabled = false;
            dtFechaIngresoLaboral.Enabled = false;
            chbFTerminoLaboral.Enabled = false;
            dtFechaTerminoLaboral.Enabled = false;
            cbInstanciaPersonal.Enabled = false;
        }

        private void chbFTerminoLaboral_Click(object sender, EventArgs e)
        {
            if (chbFTerminoLaboral.Checked == true)
            {
                dtFechaTerminoLaboral.Visible = false;

            }
            else
            {
                dtFechaTerminoLaboral.Visible = true;
                dtFechaTerminoLaboral.Text = string.Empty;

            }
        }

        private void cbSedePersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

            cargarCBInstancia_Personal();
        }


        private void cbSedePersonal_Click(object sender, EventArgs e)
        {
            cargarCBSede_Personal();
        }

        private void cbActivoPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (cbActivoPersonal.SelectedItem.ToString().Equals("N"))
            {
           
                dtFechaDescPErsonal.Visible = true;
                tbMotivoDesacPersonal.Visible = true;
                label70.Visible = true;
                label65.Visible = true;

            }
            else
            {
                label70.Visible = false;
                dtFechaDescPErsonal.Visible = false;
                tbMotivoDesacPersonal.Visible = false;
                label65.Visible = false;
 
            }
            */
        }
        private void btGrabarPersonal__Click(object sender, EventArgs e)
        {

            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                Personal obj = new Personal();

                // int rowsPK = (from T0 in db.Personals where T0.c_nombres == tbNombrePersonal.Text && T0.c_sede == Convert.ToInt32(cbSedePersonal.SelectedValue) && T0.c_instancia == Convert.ToString(cbInstanciaPersonal.SelectedValue) select T0).Count();
                int rowsPK = (from T0 in db.Personals where T0.dni == tbDniPersonal.Text select T0).Count();

                if (rowsPK == 0)
                {
                    #region
                    if (tbDniPersonal.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el DNI");
                        tbDniPersonal.Focus();
                    }
                    else
                    {
                        if (tbPaternoPersonal.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese el apellido paterno");
                            tbPaternoPersonal.Focus();
                        }
                        else
                        {
                            if (tbMaternoPersonal.Text == string.Empty)
                            {
                                MessageBox.Show("Ingrese el apellido materno");
                                tbMaternoPersonal.Focus();
                            }
                            else
                            {
                                if (tbNombrePersonal.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese el nombre");
                                    tbNombrePersonal.Focus();
                                }
                                else
                                {
                                    if (tbUnOrganica.Text == string.Empty && rbPerAdmi.Checked == true)
                                    {
                                        MessageBox.Show("Ingrese la unidad organica");
                                        tbUnOrganica.Focus();
                                    }
                                    else
                                        if (tbArea.Text == string.Empty && rbPerAdmi.Checked == true)
                                        {
                                            MessageBox.Show("Ingrese el area");
                                            tbArea.Focus();
                                        }
                                        else
                                        {
                                            if (cbEstadoPersonal.Text == string.Empty)
                                            {
                                                MessageBox.Show("Indique El estado");
                                                cbEstadoPersonal.Focus();
                                            }
                                            else
                                            {
                                                if (cbSedePersonal.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Indique  la sede");
                                                    cbSedePersonal.Focus();
                                                }
                                                else
                                                {
                                                    if (cbSedePersonal.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Indique  la sede");
                                                        cbSedePersonal.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (cbInstanciaPersonal.Text == string.Empty && rbPerJur.Checked == true)
                                                        {
                                                            MessageBox.Show("Ingrese una instancia para el usuario");
                                                            cbInstanciaPersonal.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (cbPerfilPersonal.Text == string.Empty)
                                                            {
                                                                MessageBox.Show("Ingrese el perfil del usuario");
                                                                cbPerfilPersonal.Focus();
                                                            }
                                                            else
                                                            {

                                                                if (dtFechaTerminoLaboral.Text != string.Empty && dtFechaIngresoLaboral.Text != string.Empty)
                                                                {


                                                                    if (dtFechaTerminoLaboral.Value.Date.CompareTo(dtFechaIngresoLaboral.Value.Date) < 0)
                                                                    {

                                                                        MessageBox.Show("La fecha de término laboral tiene que ser mayor a la fecha de ingreso laboral");
                                                                        dtFechaTerminoLaboral.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        obj.c_nombres = tbNombrePersonal.Text;
                                                                        obj.c_ape_paterno = tbPaternoPersonal.Text;
                                                                        obj.c_ape_materno = tbMaternoPersonal.Text;
                                                                        obj.fecha_ingreso = dtPersonal.Value.Date.ToShortDateString();
                                                                        obj.c_perfil = Convert.ToString(cbPerfilPersonal.SelectedValue);
                                                                        obj.estado = cbEstadoPersonal.SelectedItem.ToString();
                                                                        obj.dni = tbDniPersonal.Text;
                                                                        obj.c_sede = Convert.ToInt32(cbSedePersonal.SelectedValue);

                                                                        obj.fecha_nacimiento = dtFechaNacPersonal.Value.Date.ToShortDateString();
                                                                        obj.escalafon = tbEscalafon.Text;
                                                                        obj.fecha_ingreso_lab = dtFechaIngresoLaboral.Value.Date.ToShortDateString();
                                                                        obj.fecha_termino_lab = dtFechaTerminoLaboral.Value.Date.ToShortDateString();

                                                                        obj.nombre_completo = tbPaternoPersonal.Text + " " + tbMaternoPersonal.Text + " " + tbNombrePersonal.Text;

                                                                        obj.unidad_organica = tbUnOrganica.Text;
                                                                        obj.area = tbArea.Text;



                                                                        if (rbPerAdmi.Checked == true)
                                                                        {
                                                                            obj.tipo_personal = "A";
                                                                            obj.c_instancia = "0";
                                                                        }
                                                                        else
                                                                        {
                                                                            if (rbPerJur.Checked == true)
                                                                            {
                                                                                obj.tipo_personal = "J";
                                                                                obj.c_instancia = Convert.ToString(cbInstanciaPersonal.SelectedValue);
                                                                                tbUnOrganica.Text = string.Empty;
                                                                                tbArea.Text = string.Empty;

                                                                            }
                                                                        }
                                                                        obj.unidad_organica = tbUnOrganica.Text;
                                                                        obj.area = tbArea.Text;


                                                                        DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                        switch (dr)
                                                                        {
                                                                            case DialogResult.Yes:
                                                                                clsTPersonal.registrar(obj);
                                                                                limpiarPersonal();
                                                                                MessageBox.Show("Registro realizado");
                                                                                listarPersonal();
                                                                                tbDniPersonal.Focus();
                                                                                break;
                                                                            case DialogResult.No:
                                                                                break;
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (dtFechaTerminoLaboral.Text == string.Empty && dtFechaIngresoLaboral.Text == string.Empty)
                                                                    {
                                                                        //registrar
                                                                        obj.c_nombres = tbNombrePersonal.Text;
                                                                        obj.c_ape_paterno = tbPaternoPersonal.Text;
                                                                        obj.c_ape_materno = tbMaternoPersonal.Text;
                                                                        obj.fecha_ingreso = dtPersonal.Value.Date.ToShortDateString();
                                                                        obj.c_perfil = Convert.ToString(cbPerfilPersonal.SelectedValue);
                                                                        obj.estado = cbEstadoPersonal.SelectedItem.ToString();
                                                                        obj.dni = tbDniPersonal.Text;
                                                                        obj.c_sede = Convert.ToInt32(cbSedePersonal.SelectedValue);

                                                                        obj.fecha_nacimiento = dtFechaNacPersonal.Value.Date.ToShortDateString();
                                                                        obj.escalafon = tbEscalafon.Text;
                                                                        obj.fecha_ingreso_lab = dtFechaIngresoLaboral.Value.Date.ToShortDateString();
                                                                        obj.fecha_termino_lab = dtFechaTerminoLaboral.Value.Date.ToShortDateString();

                                                                        obj.nombre_completo = tbPaternoPersonal.Text + " " + tbMaternoPersonal.Text + " " + tbNombrePersonal.Text;

                                                                        obj.unidad_organica = tbUnOrganica.Text;
                                                                        obj.area = tbArea.Text;



                                                                        if (rbPerAdmi.Checked == true)
                                                                        {
                                                                            obj.tipo_personal = "A";
                                                                            obj.c_instancia = "0";
                                                                        }
                                                                        else
                                                                        {
                                                                            if (rbPerJur.Checked == true)
                                                                            {
                                                                                obj.tipo_personal = "J";
                                                                                obj.c_instancia = Convert.ToString(cbInstanciaPersonal.SelectedValue);
                                                                                tbUnOrganica.Text = string.Empty;
                                                                                tbArea.Text = string.Empty;

                                                                            }
                                                                        }
                                                                        obj.unidad_organica = tbUnOrganica.Text;
                                                                        obj.area = tbArea.Text;


                                                                        DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                        switch (dr)
                                                                        {
                                                                            case DialogResult.Yes:
                                                                                clsTPersonal.registrar(obj);
                                                                                limpiarPersonal();
                                                                                MessageBox.Show("Registro realizado");
                                                                                listarPersonal();
                                                                                tbDniPersonal.Focus();
                                                                                break;
                                                                            case DialogResult.No:
                                                                                break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (dtFechaTerminoLaboral.Text != string.Empty && dtFechaIngresoLaboral.Text == string.Empty)
                                                                        {
                                                                            MessageBox.Show("ingrese fecha de ingreso laboral");
                                                                            dtFechaIngresoLaboral.Focus();

                                                                        }
                                                                        else
                                                                        {
                                                                            if (dtFechaTerminoLaboral.Text == string.Empty && dtFechaIngresoLaboral.Text != string.Empty)
                                                                            {
                                                                                //registrar
                                                                                obj.c_nombres = tbNombrePersonal.Text;
                                                                                obj.c_ape_paterno = tbPaternoPersonal.Text;
                                                                                obj.c_ape_materno = tbMaternoPersonal.Text;
                                                                                obj.fecha_ingreso = dtPersonal.Value.Date.ToShortDateString();
                                                                                obj.c_perfil = Convert.ToString(cbPerfilPersonal.SelectedValue);
                                                                                obj.estado = cbEstadoPersonal.SelectedItem.ToString();
                                                                                obj.dni = tbDniPersonal.Text;
                                                                                obj.c_sede = Convert.ToInt32(cbSedePersonal.SelectedValue);

                                                                                obj.fecha_nacimiento = dtFechaNacPersonal.Value.Date.ToShortDateString();
                                                                                obj.escalafon = tbEscalafon.Text;
                                                                                obj.fecha_ingreso_lab = dtFechaIngresoLaboral.Value.Date.ToShortDateString();
                                                                                obj.fecha_termino_lab = dtFechaTerminoLaboral.Value.Date.ToShortDateString();

                                                                                obj.nombre_completo = tbPaternoPersonal.Text + " " + tbMaternoPersonal.Text + " " + tbNombrePersonal.Text;

                                                                                obj.unidad_organica = tbUnOrganica.Text;
                                                                                obj.area = tbArea.Text;



                                                                                if (rbPerAdmi.Checked == true)
                                                                                {
                                                                                    obj.tipo_personal = "A";
                                                                                    obj.c_instancia = "0";
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (rbPerJur.Checked == true)
                                                                                    {
                                                                                        obj.tipo_personal = "J";
                                                                                        obj.c_instancia = Convert.ToString(cbInstanciaPersonal.SelectedValue);
                                                                                        tbUnOrganica.Text = string.Empty;
                                                                                        tbArea.Text = string.Empty;

                                                                                    }
                                                                                }
                                                                                obj.unidad_organica = tbUnOrganica.Text;
                                                                                obj.area = tbArea.Text;


                                                                                DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                                switch (dr)
                                                                                {
                                                                                    case DialogResult.Yes:
                                                                                        clsTPersonal.registrar(obj);
                                                                                        limpiarPersonal();
                                                                                        MessageBox.Show("Registro realizado");
                                                                                        listarPersonal();
                                                                                        tbDniPersonal.Focus();
                                                                                        break;
                                                                                    case DialogResult.No:
                                                                                        break;
                                                                                }

                                                                            }
                                                                        }

                                                                    }

                                                                }

                                                            }

                                                        }

                                                    }
                                                }

                                            }


                                        }


                                }




                            }

                        }

                    }
                    #endregion

                }





                else { MessageBox.Show("El registro ya existe"); }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }
        }

        private void btEditarPersonal__Click(object sender, EventArgs e)
        {

            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                int rowsPK = (from T0 in db.Personals where T0.dni == tbDniPersonal.Text && T0.c_sede == Convert.ToInt32(cbSedePersonal.SelectedValue) && T0.c_instancia == Convert.ToString(cbInstanciaPersonal.SelectedValue) select T0).Count();
                Personal obj = new Personal();
                //obj.doc_entry_personal = keyPErsonal;
                if (tbNombrePersonal.Text != string.Empty /*&& rowsPK == 0*/)
                {


                    #region
                    if (tbDniPersonal.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el DNI");
                        tbDniPersonal.Focus();
                    }
                    else
                    {
                        if (tbPaternoPersonal.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese el apellido paterno");
                            tbPaternoPersonal.Focus();
                        }
                        else
                        {
                            if (tbMaternoPersonal.Text == string.Empty)
                            {
                                MessageBox.Show("Ingrese el apellido materno");
                                tbMaternoPersonal.Focus();
                            }
                            else
                            {
                                if (tbNombrePersonal.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese el nombre");
                                    tbNombrePersonal.Focus();
                                }
                                else
                                {
                                    if (tbUnOrganica.Text == string.Empty && rbPerAdmi.Checked == true)
                                    {
                                        MessageBox.Show("Ingrese la unidad organica");
                                        tbUnOrganica.Focus();
                                    }
                                    else
                                        if (tbArea.Text == string.Empty && rbPerAdmi.Checked == true)
                                        {
                                            MessageBox.Show("Ingrese el area");
                                            tbArea.Focus();
                                        }
                                        else
                                        {
                                            if (cbEstadoPersonal.Text == string.Empty)
                                            {
                                                MessageBox.Show("Indique El estado");
                                                cbEstadoPersonal.Focus();
                                            }
                                            else
                                            {
                                                if (cbSedePersonal.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Indique  la sede");
                                                    cbSedePersonal.Focus();
                                                }
                                                else
                                                {
                                                    if (cbSedePersonal.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Indique  la sede");
                                                        cbSedePersonal.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (cbInstanciaPersonal.Text == string.Empty && rbPerJur.Checked == true)
                                                        {
                                                            MessageBox.Show("Ingrese una instancia para el usuario");
                                                            cbInstanciaPersonal.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (cbPerfilPersonal.Text == string.Empty)
                                                            {
                                                                MessageBox.Show("Ingrese el perfil del usuario");
                                                                cbPerfilPersonal.Focus();
                                                            }
                                                            else
                                                            {

                                                                if (dtFechaTerminoLaboral.Text != string.Empty && dtFechaIngresoLaboral.Text != string.Empty)
                                                                {


                                                                    if (dtFechaTerminoLaboral.Value.Date.CompareTo(dtFechaIngresoLaboral.Value.Date) < 0)
                                                                    {

                                                                        MessageBox.Show("Indique la fecha de término laboral tiene que ser mayor a la fecha de ingreso laboral");
                                                                        dtFechaTerminoLaboral.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        obj.doc_entry_personal = keyPErsonal;
                                                                        obj.c_nombres = tbNombrePersonal.Text;
                                                                        obj.c_ape_paterno = tbPaternoPersonal.Text;
                                                                        obj.c_ape_materno = tbMaternoPersonal.Text;
                                                                        obj.fecha_ingreso = dtPersonal.Value.Date.ToShortDateString();
                                                                        obj.c_perfil = Convert.ToString(cbPerfilPersonal.SelectedValue);
                                                                        obj.estado = cbEstadoPersonal.SelectedItem.ToString();
                                                                        obj.dni = tbDniPersonal.Text;
                                                                        obj.c_sede = Convert.ToInt32(cbSedePersonal.SelectedValue);

                                                                        obj.fecha_nacimiento = dtFechaNacPersonal.Value.Date.ToShortDateString();
                                                                        obj.escalafon = tbEscalafon.Text;
                                                                        obj.fecha_ingreso_lab = dtFechaIngresoLaboral.Value.Date.ToShortDateString();
                                                                        obj.fecha_termino_lab = dtFechaTerminoLaboral.Value.Date.ToShortDateString();

                                                                        obj.nombre_completo = tbPaternoPersonal.Text + " " + tbMaternoPersonal.Text + " " + tbNombrePersonal.Text;

                                                                        obj.unidad_organica = tbUnOrganica.Text;
                                                                        obj.area = tbArea.Text;



                                                                        if (rbPerAdmi.Checked == true)
                                                                        {
                                                                            obj.tipo_personal = "A";
                                                                            obj.c_instancia = "0";
                                                                        }
                                                                        else
                                                                        {
                                                                            if (rbPerJur.Checked == true)
                                                                            {
                                                                                obj.tipo_personal = "J";
                                                                                obj.c_instancia = Convert.ToString(cbInstanciaPersonal.SelectedValue);
                                                                                tbUnOrganica.Text = string.Empty;
                                                                                tbArea.Text = string.Empty;

                                                                            }
                                                                        }
                                                                        obj.unidad_organica = tbUnOrganica.Text;
                                                                        obj.area = tbArea.Text;


                                                                        DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                        switch (dr)
                                                                        {
                                                                            case DialogResult.Yes:
                                                                                clsTPersonal.actualizar(obj);
                                                                                limpiarPersonal();
                                                                                MessageBox.Show("Registro Actualizado");
                                                                                listarPersonal();
                                                                                tbDniPersonal.Focus();
                                                                                break;
                                                                            case DialogResult.No:
                                                                                break;
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (dtFechaTerminoLaboral.Text == string.Empty && dtFechaIngresoLaboral.Text == string.Empty)
                                                                    {
                                                                        //registrar
                                                                        obj.doc_entry_personal = keyPErsonal;
                                                                        obj.c_nombres = tbNombrePersonal.Text;
                                                                        obj.c_ape_paterno = tbPaternoPersonal.Text;
                                                                        obj.c_ape_materno = tbMaternoPersonal.Text;
                                                                        obj.fecha_ingreso = dtPersonal.Value.Date.ToShortDateString();
                                                                        obj.c_perfil = Convert.ToString(cbPerfilPersonal.SelectedValue);
                                                                        obj.estado = cbEstadoPersonal.SelectedItem.ToString();
                                                                        obj.dni = tbDniPersonal.Text;
                                                                        obj.c_sede = Convert.ToInt32(cbSedePersonal.SelectedValue);

                                                                        obj.fecha_nacimiento = dtFechaNacPersonal.Value.Date.ToShortDateString();
                                                                        obj.escalafon = tbEscalafon.Text;
                                                                        obj.fecha_ingreso_lab = dtFechaIngresoLaboral.Value.Date.ToShortDateString();
                                                                        obj.fecha_termino_lab = dtFechaTerminoLaboral.Value.Date.ToShortDateString();

                                                                        obj.nombre_completo = tbPaternoPersonal.Text + " " + tbMaternoPersonal.Text + " " + tbNombrePersonal.Text;

                                                                        obj.unidad_organica = tbUnOrganica.Text;
                                                                        obj.area = tbArea.Text;



                                                                        if (rbPerAdmi.Checked == true)
                                                                        {
                                                                            obj.tipo_personal = "A";
                                                                            obj.c_instancia = "0";
                                                                        }
                                                                        else
                                                                        {
                                                                            if (rbPerJur.Checked == true)
                                                                            {
                                                                                obj.tipo_personal = "J";
                                                                                obj.c_instancia = Convert.ToString(cbInstanciaPersonal.SelectedValue);
                                                                                tbUnOrganica.Text = string.Empty;
                                                                                tbArea.Text = string.Empty;

                                                                            }
                                                                        }
                                                                        obj.unidad_organica = tbUnOrganica.Text;
                                                                        obj.area = tbArea.Text;


                                                                        DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                        switch (dr)
                                                                        {
                                                                            case DialogResult.Yes:
                                                                                clsTPersonal.actualizar(obj);
                                                                                limpiarPersonal();
                                                                                MessageBox.Show("Registro actualizado");
                                                                                listarPersonal();
                                                                                tbDniPersonal.Focus();
                                                                                break;
                                                                            case DialogResult.No:
                                                                                break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (dtFechaTerminoLaboral.Text != string.Empty && dtFechaIngresoLaboral.Text == string.Empty)
                                                                        {
                                                                            MessageBox.Show("ingrese fecha de ingreso laboral");
                                                                            dtFechaIngresoLaboral.Focus();

                                                                        }
                                                                        else
                                                                        {
                                                                            if (dtFechaTerminoLaboral.Text == string.Empty && dtFechaIngresoLaboral.Text != string.Empty)
                                                                            {
                                                                                //registrar
                                                                                obj.doc_entry_personal = keyPErsonal;
                                                                                obj.c_nombres = tbNombrePersonal.Text;
                                                                                obj.c_ape_paterno = tbPaternoPersonal.Text;
                                                                                obj.c_ape_materno = tbMaternoPersonal.Text;
                                                                                obj.fecha_ingreso = dtPersonal.Value.Date.ToShortDateString();
                                                                                obj.c_perfil = Convert.ToString(cbPerfilPersonal.SelectedValue);
                                                                                obj.estado = cbEstadoPersonal.SelectedItem.ToString();
                                                                                obj.dni = tbDniPersonal.Text;
                                                                                obj.c_sede = Convert.ToInt32(cbSedePersonal.SelectedValue);

                                                                                obj.fecha_nacimiento = dtFechaNacPersonal.Value.Date.ToShortDateString();
                                                                                obj.escalafon = tbEscalafon.Text;
                                                                                obj.fecha_ingreso_lab = dtFechaIngresoLaboral.Value.Date.ToShortDateString();
                                                                                obj.fecha_termino_lab = dtFechaTerminoLaboral.Value.Date.ToShortDateString();

                                                                                obj.nombre_completo = tbPaternoPersonal.Text + " " + tbMaternoPersonal.Text + " " + tbNombrePersonal.Text;

                                                                                obj.unidad_organica = tbUnOrganica.Text;
                                                                                obj.area = tbArea.Text;



                                                                                if (rbPerAdmi.Checked == true)
                                                                                {
                                                                                    obj.tipo_personal = "A";
                                                                                    obj.c_instancia = "0";
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (rbPerJur.Checked == true)
                                                                                    {
                                                                                        obj.tipo_personal = "J";
                                                                                        obj.c_instancia = Convert.ToString(cbInstanciaPersonal.SelectedValue);
                                                                                        tbUnOrganica.Text = string.Empty;
                                                                                        tbArea.Text = string.Empty;

                                                                                    }
                                                                                }
                                                                                obj.unidad_organica = tbUnOrganica.Text;
                                                                                obj.area = tbArea.Text;


                                                                                DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                                switch (dr)
                                                                                {
                                                                                    case DialogResult.Yes:
                                                                                        clsTPersonal.actualizar(obj);
                                                                                        limpiarPersonal();
                                                                                        MessageBox.Show("Registro realizado");
                                                                                        listarPersonal();
                                                                                        tbDniPersonal.Focus();
                                                                                        break;
                                                                                    case DialogResult.No:
                                                                                        break;
                                                                                }

                                                                            }
                                                                        }

                                                                    }

                                                                }

                                                            }

                                                        }

                                                    }
                                                }

                                            }


                                        }


                                }




                            }

                        }

                    }
                    #endregion



                }
                else
                {
                    MessageBox.Show("Seleccione un registro");
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }

        private void btEliminarPersonal__Click(object sender, EventArgs e)
        {

            try
            {
                if (keyPErsonal != 0 && tbNombrePersonal.Text != string.Empty)
                {

                    DialogResult dr = MessageBox.Show("Desea Eliminar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTPersonal.eliminar(keyPErsonal);
                            limpiarPersonal();
                            MessageBox.Show("Registro eliminado");
                            listarPersonal();
                            tbDniPersonal.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }



                }
                else
                {
                    MessageBox.Show("Seleccione un registro");
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
                ;
            }

        }

        private void btSalirPersonal__Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tbDniPersonal_Leave(object sender, EventArgs e)
        {
            //if existe el dni cargar datos
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            int existe = (from T0 in db.Personals where T0.dni == tbDniPersonal.Text select T0).Count();
            var cod_personal = (from T0 in db.Personals where T0.dni == tbDniPersonal.Text select T0.doc_entry_personal).ToList();

            if (existe > 0)//existe dni--> cargar datos
            {
                keyPErsonal = cod_personal[0];
                obtenerPersonal(cod_personal[0]);

                rbPerAdmi.Enabled = false;
                rbPerJur.Enabled = false;

                rbNuevaPersonal.Checked = false;
                rbEditarPersonal.Checked = false;

                if (rbPerJur.Checked)
                {
                    cbInstanciaPersonal.Visible = true;
                }
                else
                {
                    cbInstanciaPersonal.Visible = false;
                }
                desableFormPersonal();

            }



        }
        private void rbAdministrativo_Click(object sender, EventArgs e)
        {
            label51.Visible = true;
            label52.Visible = true;
            tbUnOrganica.Visible = true;
            tbArea.Visible = true;
        }

        private void rbPerJur_Click(object sender, EventArgs e)
        {
            label51.Visible = false;
            label52.Visible = false;
            tbUnOrganica.Visible = false;
            tbArea.Visible = false;
            cbInstanciaPersonal.Visible = true;

            label71.Visible = true;
        }

        private void rbPerAdmi_Click(object sender, EventArgs e)
        {
            label51.Visible = true;
            label52.Visible = true;
            tbUnOrganica.Visible = true;
            tbArea.Visible = true;
            cbInstanciaPersonal.Visible = false;
            label71.Visible = false;

        }
        private void rbNuevaPersonal_Click(object sender, EventArgs e)
        {
            limpiarPersonal();
            btGrabarPersonal_.Enabled = true;
            btEditarPersonal_.Enabled = false;
            btEliminarPersonal_.Enabled = true;

            rbPerAdmi.Enabled = true;
            rbPerJur.Enabled = true;
            enableFormPersonal();

        }

        private void rbEditarPersonal_Click(object sender, EventArgs e)
        {
            btGrabarPersonal_.Enabled = false;
            btEditarPersonal_.Enabled = true;
            btEliminarPersonal_.Enabled = true;

            rbPerAdmi.Enabled = true;
            rbPerJur.Enabled = true;
            enableFormPersonal();

        }



        #endregion
        /**************************************
        *                                     *
        *       CODIGO DE PERFIL             * 
        *                                     *
        **************************************/
        #region

        CTPerfil clsTPerfil = new CTPerfil();
        string keyPerfil = string.Empty;
        private void btListarPerfil_Click(object sender, EventArgs e)
        {
            listarPerfil();
            tbNombrePerfil.Enabled = false;
            DGVPerfil.Enabled = true;
            rbNuevoPErfil.Checked = false;
            rbEditarPerfil.Checked = false;
            tbNombrePerfil.Focus();
            btRegistrarPerfil.Enabled = false;
            btActualizarPerfil.Enabled = false;


        }
        private void btRegistrarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();

                //int nroSof = Convert.ToInt32(db.Softwares.Count().ToString());
                int nro = Convert.ToInt32((from s in db.Perfils where s.perfil == tbNombrePerfil.Text select s).Count().ToString());
                if (nro == 0)
                {
                    if (tbNombrePerfil.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese un Perfil");
                        tbNombrePerfil.Focus();
                    }
                    else
                    {

                        Perfil obj = new Perfil();
                        /*generar codigo perfil*/
                        int cperfil = 10000;
                        obj.c_perfil = Convert.ToString((from s in db.Perfils select s).Count() + cperfil + 1);
                        obj.perfil = tbNombrePerfil.Text;
                        obj.observacion = tbObservPerfil.Text;

                        //obj.activo = cbActivoPerfil.SelectedItem.ToString();
                        DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                clsTPerfil.registrar(obj);
                                limpiarPerfil();
                                MessageBox.Show("Registro realizado");
                                listarPerfil();
                                tbNombrePerfil.Focus();
                                break;
                            case DialogResult.No:
                                break;
                        }







                    }


                }
                else { MessageBox.Show("El Perfil ya existe"); tbNombrePerfil.Focus(); }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }



        }

        private void btLimpiarPerfil_Click(object sender, EventArgs e)
        {
            limpiarPerfil();
            tbNombrePerfil.Focus();
        }

        private void btActualizarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (keyPerfil != string.Empty && tbNombrePerfil.Text != string.Empty)
                {
                    Perfil obj = new Perfil();
                    obj.c_perfil = keyPerfil;
                    obj.perfil = tbNombrePerfil.Text;
                    obj.observacion = tbObservPerfil.Text;
                    //obj.activo = cbActivoPerfil.SelectedItem.ToString();

                    DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTPerfil.actualizar(obj);
                            limpiarPerfil();
                            MessageBox.Show("Registro actualizado");
                            listarPerfil();
                            tbNombrePerfil.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }



                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la lista");
                }
            }


            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }


        }

        private void btEliminarPErfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (keyPerfil != string.Empty && tbNombrePerfil.Text != string.Empty)
                {

                    DialogResult dr = MessageBox.Show("Desea Borrar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsTPerfil.eliminar(keyPerfil);
                            limpiarPerfil();
                            MessageBox.Show("registro eliminado");
                            listarPerfil();
                            tbNombrePerfil.Focus();
                            break;
                        case DialogResult.No:
                            break;
                    }



                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVPerfil.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keyPerfil = Convert.ToString(row.Cells[0].Value);
                    obtenerPerfil(keyPerfil);
                }
            }
        }
        private void limpiarPerfil()
        {
            tbNombrePerfil.Text = string.Empty;
            tbObservPerfil.Text = string.Empty;
            cbActivoPerfil.SelectedIndex = -1;
            DGVPerfil.DataSource = null;

        }
        private void listarPerfil()
        {
            DGVPerfil.AutoGenerateColumns = false;
            DGVPerfil.DataSource = clsTPerfil.listar();
        }
        private void obtenerPerfil(string keyPerfil)
        {

            Perfil objeto = clsTPerfil.obtener(keyPerfil);
            tbNombrePerfil.Text = objeto.perfil;
            tbObservPerfil.Text = objeto.observacion;
            cbActivoPerfil.Text = objeto.activo;
        }

        private void tbPerfil_TextChanged(object sender, EventArgs e)
        {
            buscarPerfil();
        }

        private void buscarPerfil()
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            if (tbPerfil.Text != string.Empty)
            {
                var sql = (from perf in db.Perfils
                           where perf.perfil.Contains(tbPerfil.Text) ||
                           perf.observacion.Contains(tbPerfil.Text)
                           select perf).ToList();

                DGVPerfil.DataSource = sql;
            }
            else
            {
                listarPerfil();
            }
        }
        private void cbPerfilPersonal_MouseClick(object sender, MouseEventArgs e)
        {
            cargarCBPerfil();
        }

        private void rbNuevoPErfil_Click(object sender, EventArgs e)
        {
            limpiarPerfil();
            btListarPerfil.Enabled = true;
            btRegistrarPerfil.Enabled = true;
            btLimpiarPerfil.Enabled = true;
            btActualizarPerfil.Enabled = false;
            btEliminarPErfil.Enabled = true;
            btImpPerfil.Enabled = true;

            rbNuevoPErfil.Enabled = true;
            tbObservPerfil.Enabled = true;
            tbNombrePerfil.Enabled = true;
            DGVPerfil.Enabled = false;

            tbNombrePerfil.Focus();
            listarPerfil();



        }

        private void rbEditarPerfil_Click(object sender, EventArgs e)
        {
            tbNombrePerfil.Enabled = true;
            btListarPerfil.Enabled = true;
            btRegistrarPerfil.Enabled = false;
            btLimpiarPerfil.Enabled = true;
            btActualizarPerfil.Enabled = true;
            btEliminarPErfil.Enabled = true;
            btImpPerfil.Enabled = true;

            rbNuevoPErfil.Enabled = true;
            tbObservPerfil.Enabled = true;

            tbObservPerfil.Enabled = true;
            DGVPerfil.Enabled = true;
            tbNombrePerfil.Focus();
            listarPerfil();



        }


        #endregion

        /**************************************
        *                                     *
        *   CODIGO ASIGNACION DE EQUIPO       * 
        *                                     *
        **************************************/
        #region
        CTRegistro clsTRegistro = new CTRegistro();
        int keyRegistro = 0;
        int keyPersonalAE = 0;
        int keyEquipoAE = 0;
        int keyRegistro_CodEquipo = 0;
        int keyRegistro_doc_entry_personal = 0;

        private bool verificarIpLibre(string ip)//true libre, false en uso
        {
            if (tbIp.Text != string.Empty)
            {
                ModeloDatoDataContext bd = new ModeloDatoDataContext();
                var reg_ip = (from T0 in bd.Equipos
                              where T0.ip_equipo == tbIp.Text
                              select T0).ToList().Count();
                if (reg_ip > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }


            }
            else
                return false;
           
        }


        private void registrarAE()
        {

            
              
                try
                {
                    //verificar si el registro ya existe
                
                    ModeloDatoDataContext bd= new ModeloDatoDataContext();

                    var reg_existe = (from T0 in bd.Registros
                                      join T1 in bd.Equipos on T0.cod_equipo equals T1.cod_equipo
                                      join T3 in bd.Personals on T0.doc_entry_personal equals T3.doc_entry_personal
                                      where T1.nro_serie == tbNroSerie.Text && T3.dni == tbDniAE.Text
                                      select T0).ToList();


                    int count_reg_existe = reg_existe.Count();

                    //verificar si la ip existr                  
                       
                   


                    if (count_reg_existe > 0)
                    {
                        MessageBox.Show("El registro ya existe");
                        tbNombreEquipo.Focus();

                    }
                    else
                     {
                        //REGISTRO NO EXISTE
                        //1 verificar si el equipo esta creado?
                        //1.1 si esta creado
                        //  1.1.1, verificar si el equipo esta asignado? 
                            //  1.1.1.1 si esta signado; enviar error
                            //  1.1.1.2 no esta asignado, crear el registro de aisgnacion, actualizar el estado de equipo a no disponible, fin
                        //1.2 no esta creado
                        //  1.2.1 crear el equipo y registro de asignacion, actualizar estado de equipo a no dispponible
                   

                         int countEquipoCreado = (from T0 in bd.Equipos
                                         where T0.nro_serie == tbNroSerie.Text
                                         select T0).Count();

                         var asignado1 = (from T0 in bd.Equipos
                                          where T0.nro_serie == tbNroSerie.Text
                                          select T0).ToList();

                         //1 verificar si el equipo esta creado?
                         if (countEquipoCreado > 0)//1.1 si esta creado
                         #region
                         {
                             //  1.1.1, verificar si el equipo esta asignado? 
                             if (asignado1[0].activo != "N") //  1.1.1.1 si esta signado; enviar error
                             {
                                 var reg_existe2 = (from T0 in bd.Registros
                                                    join T1 in bd.Equipos on T0.cod_equipo equals T1.cod_equipo
                                                    join T3 in bd.Personals on T0.doc_entry_personal equals T3.doc_entry_personal
                                                    where T1.nro_serie == tbNroSerie.Text
                                                    select T3).ToList();
                                 MessageBox.Show("El equipo con serie: " + tbNroSerie.Text + " esta asignado a: " + reg_existe2[0].nombre_completo);
                                 tbNombreEquipo.Focus();
                             }
                             else //  1.1.1.2 no esta asignado, crear el registro de aisgnacion, actualizar el estado de equipo a no disponible, fin
                             {
                                 //validar nombre
                                 
                                  if (tbNombreEquipo.Text == string.Empty)
                                  {
                                         if (Convert.ToInt32(cbCatEq.SelectedValue) == 2 || Convert.ToInt32(cbCatEq.SelectedValue) == 6)
                                         {

                                             MessageBox.Show("Ingrese la nombre de equipo");
                                             tbNombreEquipo.Focus();

                                         }
                                         else
                                         {
                                             #region
                                             if (tbMarca.Text == string.Empty)
                                             {
                                                 MessageBox.Show("Ingrese la marca");
                                                 tbMarca.Focus();
                                             }
                                             else
                                             {
                                                 if (tbNroSerie.Text == string.Empty)
                                                 {
                                                     MessageBox.Show("Ingrese la serie");
                                                     tbNroSerie.Focus();
                                                 }
                                                 else
                                                 {
                                                     if (tbModelo.Text == string.Empty)
                                                     {
                                                         MessageBox.Show("Ingrese el modelo del equipo");
                                                         tbModelo.Focus();
                                                     }
                                                     else
                                                     {

                                                         if (tbNroControlPatrimonial.Text == string.Empty)
                                                         {
                                                             MessageBox.Show("Ingrese el cod patrimonial");
                                                             tbNroControlPatrimonial.Focus();
                                                         }
                                                         else
                                                         {
                                                             if (cbEstadoEquipo.Text == string.Empty)
                                                             {
                                                                 MessageBox.Show("Ingrese el Estado del equipo");
                                                                 cbEstadoEquipo.Focus();
                                                             }
                                                             else
                                                             {

                                                                 if (cbAnioCompra.Text == string.Empty)
                                                                 {
                                                                     MessageBox.Show("Ingrese el año de compra del equipo");
                                                                     cbAnioCompra.Focus();
                                                                 }
                                                                 else
                                                                 {
                                                                     if (dtFechaAsignacionAES.Text == string.Empty)
                                                                     {
                                                                         MessageBox.Show("Ingrese la Fecha de Asignación");
                                                                         dtFechaAsignacionAES.Focus();
                                                                     }
                                                                     else
                                                                     {
                                                                         ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                                         Equipo objEquipo = new Equipo();

                                                                         int nro = (from s in db.Equipos where s.nro_serie == tbNroSerie.Text select s).Count();


                                                                         //el equipo no esta creado, crear el equipo y asignarlo

                                                                         if (nro > 0) //el equipo esta registrado ya existe 
                                                                         {
                                                                             //verificar si el equipo esta asignado
                                                                             //despues de creado el equipo obtener el codequipo
                                                                             var _keyEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerie.Text select T0).ToList();
                                                                             keyEquipoAE = _keyEquipo[0].cod_equipo;
                                                                             string asignado = _keyEquipo[0].activo;

                                                                             //obtener el docentry de personal
                                                                             var _keyPersonalAE = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0).ToList();
                                                                             keyPersonalAE = _keyPersonalAE[0].doc_entry_personal;

                                                                             Registro reg = new Registro();
                                                                             reg.doc_entry_personal = keyPersonalAE;// Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                                             reg.cod_equipo = keyEquipoAE;// Convert.ToInt32(cbCodEquipoAE.SelectedValue);

                                                                             reg.fecha_registro = dtFechaAsignacionAES.Value.Date.ToShortDateString();
                                                                             reg.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");
                                                                             //asignar el equipo si y solo si el equipo no esta asignado     
                                                                             if (asignado == "S")//equipo asignado
                                                                             {
                                                                                 MessageBox.Show("La ASIGNACION YA EXISTE. El equipo de serie: " + _keyEquipo[0].nro_serie + ", esta asignado a: " + _keyPersonalAE[0].nombre_completo);
                                                                                 // MessageBox.Show("El equipo esta asignado");
                                                                             }
                                                                             else// equipo NO asignado
                                                                             {


                                                                                 DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                                 switch (dr)
                                                                                 {
                                                                                     case DialogResult.Yes:


                                                                                         //asignacion de ip
                                                                                         if (tbIp.Text != string.Empty)
                                                                                         {

                                                                                             var reg_ip = (from T0 in bd.Equipos
                                                                                                           where T0.ip_equipo == tbIp.Text
                                                                                                           select T0).ToList();
                                                                                             if (reg_ip.Count() <= 1) //la ip del equipo creado existe y es unica
                                                                                             {
                                                                                                 #region
                                                                                                 CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                                 p_clsTRegistro.registrar(reg);
                                                                                                 //Actualizar el equipo a asignado
                                                                                                 Equipo emp = new Equipo();
                                                                                                 emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                                 emp.activo = "S";
                                                                                                 if (Convert.ToInt32(cbCatEq.SelectedValue) == 1 || Convert.ToInt32(cbCatEq.SelectedValue) == 3 || Convert.ToInt32(cbCatEq.SelectedValue) == 4 || Convert.ToInt32(cbCatEq.SelectedValue) == 5)
                                                                                                 {
                                                                                                     emp.equipo = Convert.ToString(cbCatEq.Text);
                                                                                                 }
                                                                                                 else
                                                                                                 {
                                                                                                     emp.equipo = tbNombreEquipo.Text;

                                                                                                 }
                                                                                                 emp.ip_equipo = tbIp.Text;

                                                                                                 emp.marca = tbMarca.Text;
                                                                                                 emp.modelo = tbModelo.Text;
                                                                                                 emp.procesador = tbProcesador.Text;
                                                                                                 emp.nro_serie = tbNroSerie.Text;
                                                                                                 emp.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                                                                                                 emp.anio_adquisicion = cbAnioCompra.Text;
                                                                                                 emp.nro_orden_compra = tbNroOrdenCompra.Text;
                                                                                                 emp.observacion = tbObseracion.Text;
                                                                                                 emp.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                                 emp.funcionamiento = tbFuncionamiento.Text;

                                                                                                 emp.estado = cbEstadoEquipo.SelectedItem.ToString();
                                                                                                 emp.service_tag = tbServiceTag.Text;

                                                                                                 db.SubmitChanges();
                                                                                                 limpiarRegistro();
                                                                                                 MessageBox.Show("Registro realizado");
                                                                                                 if (cbCatEq.Text != string.Empty)
                                                                                                 {
                                                                                                     int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                                            listarRegistro(_cat);
                                                                                                 }
                                                                                                 tbNombreEquipo.Focus();

                                                                                                 #endregion
                                                                                             }
                                                                                             else//el ip esta asignado a mas de un equipo
                                                                                             {
                                                                                                 string ips = string.Empty;
                                                                                                 string nserie = string.Empty;
                                                                                                 for (int i = 0; i < reg_ip.Count(); i++)
                                                                                                 {
                                                                                                     ips = ips + ", " + reg_ip[i].ip_equipo.ToString();
                                                                                                     nserie = nserie + ", " + reg_ip[i].nro_serie.ToString();
                                                                                                 }
                                                                                                 MessageBox.Show("La IP: " + tbIp.Text + " Ya esta asignada (al)/(a los) equipo(s) de serie: " + nserie + " cambie de IP");
                                                                                                 //tbIp.Focus();
                                                                                                 //return;

                                                                                             }

                                                                                         }
                                                                                         else // equipo sin ip
                                                                                         {
                                                                                             #region

                                                                                             CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                             p_clsTRegistro.registrar(reg);
                                                                                             //Actualizar el equipo a asignado
                                                                                             Equipo emp = new Equipo();
                                                                                             emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                             emp.activo = "S";
                                                                                             if (Convert.ToInt32(cbCatEq.SelectedValue) == 1 || Convert.ToInt32(cbCatEq.SelectedValue) == 3 || Convert.ToInt32(cbCatEq.SelectedValue) == 4 || Convert.ToInt32(cbCatEq.SelectedValue) == 5)
                                                                                             {
                                                                                                 emp.equipo = Convert.ToString(cbCatEq.Text);
                                                                                             }
                                                                                             else
                                                                                             {
                                                                                                 emp.equipo = tbNombreEquipo.Text;

                                                                                             }

                                                                                             emp.ip_equipo = tbIp.Text;
                                                                                             emp.marca = tbMarca.Text;
                                                                                             emp.modelo = tbModelo.Text;
                                                                                             emp.procesador = tbProcesador.Text;
                                                                                             emp.nro_serie = tbNroSerie.Text;
                                                                                             emp.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                                                                                             emp.anio_adquisicion = cbAnioCompra.Text;
                                                                                             emp.nro_orden_compra = tbNroOrdenCompra.Text;
                                                                                             emp.observacion = tbObseracion.Text;
                                                                                             emp.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                             emp.funcionamiento = tbFuncionamiento.Text;

                                                                                             emp.estado = cbEstadoEquipo.SelectedItem.ToString();
                                                                                             emp.service_tag = tbServiceTag.Text;

                                                                                             db.SubmitChanges();
                                                                                             limpiarRegistro();
                                                                                             MessageBox.Show("Registro realizado");
                                                                                             if (cbCatEq.Text != string.Empty)
                                                                                             {
                                                                                                 int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                                        listarRegistro(_cat);
                                                                                             }
                                                                                             tbNombreEquipo.Focus();
                                                                                             #endregion


                                                                                         }

                                                                                         break;
                                                                                     case DialogResult.No:
                                                                                         break;


                                                                                 }

                                                                             }

                                                                         }
                                                                     }



                                                                 }



                                                             }
                                                         }



                                                     }

                                                 }

                                             }

                                             #endregion

                                         }

                                  }
                                 
                                 else
                                 {
                                     #region
                                     if (tbMarca.Text == string.Empty)
                                     {
                                         MessageBox.Show("Ingrese la marca");
                                         tbMarca.Focus();
                                     }
                                     else
                                     {
                                         if (tbNroSerie.Text == string.Empty)
                                         {
                                             MessageBox.Show("Ingrese la serie");
                                             tbNroSerie.Focus();
                                         }
                                         else
                                         {
                                             if (tbModelo.Text == string.Empty)
                                             {
                                                 MessageBox.Show("Ingrese el modelo del equipo");
                                                 tbModelo.Focus();
                                             }
                                             else
                                             {

                                                 if (tbNroControlPatrimonial.Text == string.Empty)
                                                 {
                                                     MessageBox.Show("Ingrese el cod patrimonial");
                                                     tbNroControlPatrimonial.Focus();
                                                 }
                                                 else
                                                 {
                                                     if (cbEstadoEquipo.Text == string.Empty)
                                                     {
                                                         MessageBox.Show("Ingrese el Estado del equipo");
                                                         cbEstadoEquipo.Focus();
                                                     }
                                                     else
                                                     {

                                                         if (cbAnioCompra.Text == string.Empty)
                                                         {
                                                             MessageBox.Show("Ingrese el año de compra del equipo");
                                                             cbAnioCompra.Focus();
                                                         }
                                                         else
                                                         {
                                                             if (dtFechaAsignacionAES.Text == string.Empty)
                                                             {
                                                                 MessageBox.Show("Ingrese la Fecha de Asignación");
                                                                 dtFechaAsignacionAES.Focus();
                                                             }
                                                             else
                                                             {
                                                                 ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                                 Equipo objEquipo = new Equipo();

                                                                 int nro = (from s in db.Equipos where s.nro_serie == tbNroSerie.Text select s).Count();


                                                                 //el equipo no esta creado, crear el equipo y asignarlo

                                                                 if (nro > 0) //el equipo esta registrado ya existe 
                                                                 {
                                                                     //verificar si el equipo esta asignado
                                                                     //despues de creado el equipo obtener el codequipo
                                                                     var _keyEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerie.Text select T0).ToList();
                                                                     keyEquipoAE = _keyEquipo[0].cod_equipo;
                                                                     string asignado = _keyEquipo[0].activo;

                                                                     //obtener el docentry de personal
                                                                     var _keyPersonalAE = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0).ToList();
                                                                     keyPersonalAE = _keyPersonalAE[0].doc_entry_personal;

                                                                     Registro reg = new Registro();
                                                                     reg.doc_entry_personal = keyPersonalAE;// Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                                     reg.cod_equipo = keyEquipoAE;// Convert.ToInt32(cbCodEquipoAE.SelectedValue);

                                                                     reg.fecha_registro = dtFechaAsignacionAES.Value.Date.ToShortDateString();
                                                                     reg.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");
                                                                     //asignar el equipo si y solo si el equipo no esta asignado     
                                                                     if (asignado == "S")//equipo asignado
                                                                     {
                                                                         MessageBox.Show("La ASIGNACION YA EXISTE. El equipo de serie: " + _keyEquipo[0].nro_serie + ", esta asignado a: " + _keyPersonalAE[0].nombre_completo);
                                                                         // MessageBox.Show("El equipo esta asignado");
                                                                     }
                                                                     else// equipo NO asignado
                                                                     {


                                                                         DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                         switch (dr)
                                                                         {
                                                                             case DialogResult.Yes:

                                                                               
                                                                                 //asignacion de ip
                                                                                 if (tbIp.Text != string.Empty)
                                                                                 {
                                                                                    
                                                                                     var reg_ip = (from T0 in bd.Equipos
                                                                                                   where T0.ip_equipo == tbIp.Text && T0.nro_serie == tbNroSerie.Text
                                                                                                   select T0).ToList();
                                                                                     if (reg_ip.Count() == 1) //la ip del equipo creado existe y es unica
                                                                                     {
                                                                                         #region
                                                                                         CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                         p_clsTRegistro.registrar(reg);
                                                                                         //Actualizar el equipo a asignado
                                                                                         Equipo emp = new Equipo();
                                                                                         emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                         emp.activo = "S";
                                                                                         if (Convert.ToInt32(cbCatEq.SelectedValue) == 1 || Convert.ToInt32(cbCatEq.SelectedValue) == 3 || Convert.ToInt32(cbCatEq.SelectedValue) == 4 || Convert.ToInt32(cbCatEq.SelectedValue) == 5)
                                                                                         {
                                                                                             emp.equipo = Convert.ToString(cbCatEq.Text);
                                                                                         }
                                                                                         else
                                                                                         {
                                                                                             emp.equipo = tbNombreEquipo.Text;

                                                                                         }
                                                                                         emp.ip_equipo = tbIp.Text;

                                                                                         emp.marca = tbMarca.Text;
                                                                                         emp.modelo = tbModelo.Text;
                                                                                         emp.procesador = tbProcesador.Text;
                                                                                         emp.nro_serie = tbNroSerie.Text;
                                                                                         emp.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                                                                                         emp.anio_adquisicion = cbAnioCompra.Text;
                                                                                         emp.nro_orden_compra = tbNroOrdenCompra.Text;
                                                                                         emp.observacion = tbObseracion.Text;
                                                                                         emp.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                         emp.funcionamiento = tbFuncionamiento.Text;

                                                                                         emp.estado = cbEstadoEquipo.SelectedItem.ToString();
                                                                                         emp.service_tag = tbServiceTag.Text;

                                                                                         db.SubmitChanges();
                                                                                         limpiarRegistro();
                                                                                         MessageBox.Show("Registro realizado");
                                                                                         if (cbCatEq.Text != string.Empty)
                                                                                         {
                                                                                             int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                                    listarRegistro(_cat);
                                                                                         }
                                                                                         tbNombreEquipo.Focus();

                                                                                         #endregion
                                                                                     }
                                                                                     else//el ip esta asignado a mas de un equipo
                                                                                     {
                                                                                         var reg_ips = (from T0 in bd.Equipos
                                                                                                       where T0.ip_equipo == tbIp.Text
                                                                                                       select T0).ToList();
                                                                                         string ips = string.Empty;
                                                                                         string nserie = string.Empty;
                                                                                         for (int i = 0; i < reg_ips.Count(); i++)
                                                                                         {
                                                                                             ips = ips + ", " + reg_ips[i].ip_equipo.ToString();
                                                                                             nserie = nserie + ", " + reg_ips[i].nro_serie.ToString();
                                                                                         }
                                                                                         MessageBox.Show("La IP: " + tbIp.Text + " Ya esta asignada (al)/(a los) equipo(s) de serie: "  + nserie + " cambie de IP");
                                                                                         tbIp.Focus();
                                                                                         //return;

                                                                                     }                                                                                    

                                                                                 }
                                                                                 else // equipo sin ip
                                                                                 {
                                                                                     #region

                                                                                     CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                     p_clsTRegistro.registrar(reg);
                                                                                     //Actualizar el equipo a asignado
                                                                                     Equipo emp = new Equipo();
                                                                                     emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                     emp.activo = "S";
                                                                                     if (Convert.ToInt32(cbCatEq.SelectedValue) == 1 || Convert.ToInt32(cbCatEq.SelectedValue) == 3 || Convert.ToInt32(cbCatEq.SelectedValue) == 4 || Convert.ToInt32(cbCatEq.SelectedValue) == 5)
                                                                                     {
                                                                                         emp.equipo = Convert.ToString(cbCatEq.Text);
                                                                                     }
                                                                                     else
                                                                                     {
                                                                                         emp.equipo = tbNombreEquipo.Text;

                                                                                     }

                                                                                     emp.ip_equipo = tbIp.Text;
                                                                                     emp.marca = tbMarca.Text;
                                                                                     emp.modelo = tbModelo.Text;
                                                                                     emp.procesador = tbProcesador.Text;
                                                                                     emp.nro_serie = tbNroSerie.Text;
                                                                                     emp.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                                                                                     emp.anio_adquisicion = cbAnioCompra.Text;
                                                                                     emp.nro_orden_compra = tbNroOrdenCompra.Text;
                                                                                     emp.observacion = tbObseracion.Text;
                                                                                     emp.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                     emp.funcionamiento = tbFuncionamiento.Text;

                                                                                     emp.estado = cbEstadoEquipo.SelectedItem.ToString();
                                                                                     emp.service_tag = tbServiceTag.Text;

                                                                                     db.SubmitChanges();
                                                                                     limpiarRegistro();
                                                                                     MessageBox.Show("Registro realizado");
                                                                                     if (cbCatEq.Text != string.Empty)
                                                                                     {
                                                                                         int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                                listarRegistro(_cat);
                                                                                     }
                                                                                     tbNombreEquipo.Focus();
                                                                                     #endregion


                                                                                 }

                                                                                 break;
                                                                             case DialogResult.No:
                                                                                 break;
                                                                         }

                                                                     }

                                                                 }
                                                             }



                                                         }



                                                     }
                                                 }



                                             }

                                         }

                                     }

                                     #endregion

                                 }

                              //  end 1.1.1.2 no esta asignado, crear el registro de aisgnacion, actualizar el estado de equipo a no disponible, fin

                             }

                             #endregion

                             //end si esta creado
                         }

                         else //1.2 no esta creado    
                         {                        
                            

                                 //  1.2.1 crear el equipo y registro de asignacion, actualizar estado de equipo a no dispponible

                                 if (tbNombreEquipo.Text == string.Empty)
                                 {
                                     if (Convert.ToInt32(cbCatEq.SelectedValue) == 2 || Convert.ToInt32(cbCatEq.SelectedValue) == 6)
                                     {

                                         MessageBox.Show("Ingrese la nombre de equipo");
                                         tbNombreEquipo.Focus();

                                     }
                                     else
                                     {
                                         #region

                                         if (tbMarca.Text == string.Empty)
                                         {
                                             MessageBox.Show("Ingrese la marca");
                                             tbMarca.Focus();
                                         }
                                         else
                                         {
                                             if (tbNroSerie.Text == string.Empty)
                                             {
                                                 MessageBox.Show("Ingrese la serie");
                                                 tbNroSerie.Focus();
                                             }
                                             else
                                             {
                                                 if (tbModelo.Text == string.Empty)
                                                 {
                                                     MessageBox.Show("Ingrese el modelo del equipo");
                                                     tbModelo.Focus();
                                                 }
                                                 else
                                                 {

                                                     if (tbNroControlPatrimonial.Text == string.Empty)
                                                     {
                                                         MessageBox.Show("Ingrese el cod patrimonial");
                                                         tbNroControlPatrimonial.Focus();
                                                     }
                                                     else
                                                     {
                                                         if (cbEstadoEquipo.Text == string.Empty)
                                                         {
                                                             MessageBox.Show("Ingrese el Estado del equipo");
                                                             cbEstadoEquipo.Focus();
                                                         }
                                                         else
                                                         {

                                                             if (cbAnioCompra.Text == string.Empty)
                                                             {
                                                                 MessageBox.Show("Ingrese el año de compra del equipo");
                                                                 cbAnioCompra.Focus();
                                                             }
                                                             else
                                                             {
                                                                 if (dtFechaAsignacionAES.Text == string.Empty)
                                                                 {
                                                                     MessageBox.Show("Ingrese la Fecha de Asignación");
                                                                     dtFechaAsignacionAES.Focus();
                                                                 }
                                                                 else
                                                                 {
                                                                     ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                                     Equipo objEquipo = new Equipo();

                                                                     int nro = (from s in db.Equipos where s.nro_serie == tbNroSerie.Text select s).Count();


                                                                     //el equipo no esta creado, crear el equipo y asignarlo

                                                                     if (nro == 0)
                                                                     {
                                                                         int pcod_equipo = 0;
                                                                         int count = (from s in db.Equipos select s).Count();
                                                                         if (count == 0)
                                                                         {
                                                                             objEquipo.cod_equipo = pcod_equipo + 1;
                                                                         }
                                                                         else
                                                                         {

                                                                             // objEquipo.cod_equipo = Convert.ToInt32(db.Equipos.Select(p => p.cod_equipo).Max()) + 1;
                                                                             objEquipo.cod_equipo = db.Equipos.Max(c => c.cod_equipo) + 1;
                                                                         }
                                                                         if (Convert.ToInt32(cbCatEq.SelectedValue) == 1 || Convert.ToInt32(cbCatEq.SelectedValue) == 3 || Convert.ToInt32(cbCatEq.SelectedValue) == 4 || Convert.ToInt32(cbCatEq.SelectedValue) == 5)
                                                                         {
                                                                             objEquipo.equipo = Convert.ToString(cbCatEq.Text);
                                                                         }
                                                                         else
                                                                         {
                                                                             objEquipo.equipo = tbNombreEquipo.Text;

                                                                         }
                                                                         if (tbIp.Text != string.Empty )
                                                                         {
                                                                             var reg_ip = (from T0 in bd.Equipos
                                                                                           where T0.ip_equipo == tbIp.Text
                                                                                           select T0).ToList();
                                                                             if (reg_ip.Count() <= 0)
                                                                             {
                                                                                 objEquipo.ip_equipo = tbIp.Text;
                                                                             }
                                                                             else//el ip ya esta asignado
                                                                             {
                                                                                 MessageBox.Show("La IP: " + tbIp.Text + " Ya se encuentra asignada (al)/(a la) " + reg_ip[0].equipo + " de serie: " + reg_ip[0].nro_serie + " cambie de IP");
                                                                                // tbIp.Focus();
                                                                                 return;
                                                                             }

                                                                         }
                                                                         else
                                                                         {
                                                                             objEquipo.ip_equipo = tbIp.Text;

                                                                         }

                                                                         objEquipo.marca = tbMarca.Text;
                                                                         objEquipo.modelo = tbModelo.Text;
                                                                         objEquipo.procesador = tbProcesador.Text;
                                                                         objEquipo.nro_serie = tbNroSerie.Text;
                                                                         objEquipo.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                                                                         objEquipo.anio_adquisicion = cbAnioCompra.Text;
                                                                         objEquipo.nro_orden_compra = tbNroOrdenCompra.Text;
                                                                         objEquipo.observacion = tbObseracion.Text;
                                                                         objEquipo.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                         objEquipo.funcionamiento = tbFuncionamiento.Text;
                                                                         objEquipo.activo = "N";//cbAsignado.SelectedItem.ToString();
                                                                         objEquipo.estado = cbEstadoEquipo.SelectedItem.ToString();
                                                                         objEquipo.service_tag = tbServiceTag.Text;

                                                                         DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                         switch (dr)
                                                                         {
                                                                             case DialogResult.Yes:
                                                                                 //registrar equipo con asignado=N
                                                                                 CTEquipo _clsTEqupipo = new CTEquipo();
                                                                                 _clsTEqupipo.registrar(objEquipo);


                                                                                 //despues de crear obtener el codequipo
                                                                                 var _keyEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerie.Text select T0).ToList();
                                                                                 keyEquipoAE = _keyEquipo[0].cod_equipo;
                                                                                 string asignado = _keyEquipo[0].activo;

                                                                                 //obtener el docentry de personal
                                                                                 var _keyPersonalAE = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0).ToList();
                                                                                 keyPersonalAE = _keyPersonalAE[0].doc_entry_personal;

                                                                                 Registro reg = new Registro();
                                                                                 reg.doc_entry_personal = keyPersonalAE;// Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                                                 reg.cod_equipo = keyEquipoAE;// Convert.ToInt32(cbCodEquipoAE.SelectedValue);

                                                                                 reg.fecha_registro = dtFechaAsignacionAES.Value.Date.ToShortDateString();
                                                                                 reg.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");


                                                                                 //asignar el equipo si y solo si el equipo no esta asignado
                                                                                 if (asignado == "N")
                                                                                 {
                                                                                     CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                     p_clsTRegistro.registrar(reg);
                                                                                     //equipo asignado
                                                                                     Equipo emp = new Equipo();
                                                                                     emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                     emp.activo = "S";
                                                                                     db.SubmitChanges();

                                                                                     limpiarRegistro();
                                                                                     MessageBox.Show("Registro realizado");
                                                                                     if (cbCatEq.Text != string.Empty)
                                                                                     {
                                                                                         int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                         listarRegistro(_cat);
                                                                                     }
                                                                                     tbNombreEquipo.Focus();
                                                                                 }
                                                                                 else
                                                                                 {
                                                                                     MessageBox.Show("El equipo de serie: " + _keyEquipo[0].nro_serie + ", esta asignado a: " + _keyPersonalAE[0].nombre_completo);
                                                                                 }



                                                                                 break;
                                                                             case DialogResult.No:
                                                                                 break;
                                                                         }

                                                                     }


                                                                 }


                                                             }



                                                         }
                                                     }



                                                 }

                                             }

                                         }

                                         #endregion
                                     }

                                 }
                                 else 
                                 {
                                     #region

                                     if (tbMarca.Text == string.Empty)
                                     {
                                         MessageBox.Show("Ingrese la marca");
                                         tbMarca.Focus();
                                     }
                                     else
                                     {
                                         if (tbNroSerie.Text == string.Empty)
                                         {
                                             MessageBox.Show("Ingrese la serie");
                                             tbNroSerie.Focus();
                                         }
                                         else
                                         {
                                             if (tbModelo.Text == string.Empty)
                                             {
                                                 MessageBox.Show("Ingrese el modelo del equipo");
                                                 tbModelo.Focus();
                                             }
                                             else
                                             {

                                                 if (tbNroControlPatrimonial.Text == string.Empty)
                                                 {
                                                     MessageBox.Show("Ingrese el cod patrimonial");
                                                     tbNroControlPatrimonial.Focus();
                                                 }
                                                 else
                                                 {
                                                     if (cbEstadoEquipo.Text == string.Empty)
                                                     {
                                                         MessageBox.Show("Ingrese el Estado del equipo");
                                                         cbEstadoEquipo.Focus();
                                                     }
                                                     else
                                                     {

                                                         if (cbAnioCompra.Text == string.Empty)
                                                         {
                                                             MessageBox.Show("Ingrese el año de compra del equipo");
                                                             cbAnioCompra.Focus();
                                                         }
                                                         else
                                                         {
                                                             if (dtFechaAsignacionAES.Text == string.Empty)
                                                             {
                                                                 MessageBox.Show("Ingrese la Fecha de Asignación");
                                                                 dtFechaAsignacionAES.Focus();
                                                             }
                                                             else
                                                             {
                                                                 ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                                 Equipo objEquipo = new Equipo();

                                                                 int nro = (from s in db.Equipos where s.nro_serie == tbNroSerie.Text select s).Count();


                                                                 //el equipo no esta creado, crear el equipo y asignarlo

                                                                 if (nro == 0)
                                                                 {
                                                                     int pcod_equipo = 0;
                                                                     int count = (from s in db.Equipos select s).Count();
                                                                     if (count == 0)
                                                                     {
                                                                         objEquipo.cod_equipo = pcod_equipo + 1;
                                                                     }
                                                                     else
                                                                     {

                                                                         // objEquipo.cod_equipo = Convert.ToInt32(db.Equipos.Select(p => p.cod_equipo).Max()) + 1;
                                                                         objEquipo.cod_equipo = db.Equipos.Max(c => c.cod_equipo) + 1;
                                                                     }
                                                                     if (Convert.ToInt32(cbCatEq.SelectedValue) == 1 || Convert.ToInt32(cbCatEq.SelectedValue) == 3 || Convert.ToInt32(cbCatEq.SelectedValue) == 4 || Convert.ToInt32(cbCatEq.SelectedValue) == 5)
                                                                     {
                                                                         objEquipo.equipo = Convert.ToString(cbCatEq.Text);
                                                                     }
                                                                     else
                                                                     {
                                                                         objEquipo.equipo = tbNombreEquipo.Text;

                                                                     }
                                                                     if (tbIp.Text != string.Empty)
                                                                     {
                                                                         var reg_ip = (from T0 in bd.Equipos
                                                                                       where T0.ip_equipo == tbIp.Text
                                                                                       select T0).ToList();
                                                                         if (reg_ip.Count() <= 0)
                                                                         {
                                                                             objEquipo.ip_equipo = tbIp.Text;
                                                                         }
                                                                         else//el ip ya esta asignado
                                                                         {
                                                                             MessageBox.Show("La IP: " + tbIp.Text + " Ya se encuentra asignada (al)/(a la) " + reg_ip[0].equipo + " de serie: " + reg_ip[0].nro_serie + " cambie de IP");
                                                                            // tbIp.Focus();
                                                                             return;
                                                                         }

                                                                     }
                                                                     else
                                                                     {
                                                                         objEquipo.ip_equipo = tbIp.Text;

                                                                     }

                                                                     objEquipo.marca = tbMarca.Text;
                                                                     objEquipo.modelo = tbModelo.Text;
                                                                     objEquipo.procesador = tbProcesador.Text;
                                                                     objEquipo.nro_serie = tbNroSerie.Text;
                                                                     objEquipo.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                                                                     objEquipo.anio_adquisicion = cbAnioCompra.Text;
                                                                     objEquipo.nro_orden_compra = tbNroOrdenCompra.Text;
                                                                     objEquipo.observacion = tbObseracion.Text;
                                                                     objEquipo.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                     objEquipo.funcionamiento = tbFuncionamiento.Text;
                                                                     objEquipo.activo = "N";//cbAsignado.SelectedItem.ToString();
                                                                     objEquipo.estado = cbEstadoEquipo.SelectedItem.ToString();
                                                                     objEquipo.service_tag = tbServiceTag.Text;

                                                                     DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                     switch (dr)
                                                                     {
                                                                         case DialogResult.Yes:
                                                                             //registrar equipo con asignado=N
                                                                             CTEquipo _clsTEqupipo = new CTEquipo();
                                                                             _clsTEqupipo.registrar(objEquipo);


                                                                             //despues de crear obtener el codequipo
                                                                             var _keyEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerie.Text select T0).ToList();
                                                                             keyEquipoAE = _keyEquipo[0].cod_equipo;
                                                                             string asignado = _keyEquipo[0].activo;

                                                                             //obtener el docentry de personal
                                                                             var _keyPersonalAE = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0).ToList();
                                                                             keyPersonalAE = _keyPersonalAE[0].doc_entry_personal;

                                                                             Registro reg = new Registro();
                                                                             reg.doc_entry_personal = keyPersonalAE;// Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                                             reg.cod_equipo = keyEquipoAE;// Convert.ToInt32(cbCodEquipoAE.SelectedValue);

                                                                             reg.fecha_registro = dtFechaAsignacionAES.Value.Date.ToShortDateString();
                                                                             reg.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");


                                                                             //asignar el equipo si y solo si el equipo no esta asignado
                                                                             if (asignado == "N")
                                                                             {
                                                                                 CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                 p_clsTRegistro.registrar(reg);
                                                                                 //equipo asignado
                                                                                 Equipo emp = new Equipo();
                                                                                 emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                 emp.activo = "S";
                                                                                 db.SubmitChanges();

                                                                                 limpiarRegistro();
                                                                                 MessageBox.Show("Registro realizado");
                                                                                 if (cbCatEq.Text != string.Empty)
                                                                                 {
                                                                                     int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                                     listarRegistro(_cat);
                                                                                 }
                                                                                 tbNombreEquipo.Focus();
                                                                             }
                                                                             else
                                                                             {
                                                                                 MessageBox.Show("El equipo de serie: " + _keyEquipo[0].nro_serie + ", esta asignado a: " + _keyPersonalAE[0].nombre_completo);
                                                                             }



                                                                             break;
                                                                         case DialogResult.No:
                                                                             break;
                                                                     }

                                                                 }


                                                             }


                                                         }



                                                     }
                                                 }



                                             }

                                         }

                                     }

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
        private void registrarAECCom()
        {



            try
            {
                //verificar si el registro ya existe

                ModeloDatoDataContext bd = new ModeloDatoDataContext();

                var reg_existe = (from T0 in bd.Registros
                                  join T1 in bd.Equipos on T0.cod_equipo equals T1.cod_equipo
                                  join T3 in bd.Personals on T0.doc_entry_personal equals T3.doc_entry_personal
                                  where T1.nro_serie == tbNroSerieCCom.Text && T3.dni == tbDniAE.Text
                                  select T0).ToList();


                int count_reg_existe = reg_existe.Count();

                //verificar si la ip existr                  




                if (count_reg_existe > 0)
                {
                    MessageBox.Show("El registro ya existe");
                    tbNombreEquipoCCom.Focus();

                }
                else
                {
                    //REGISTRO NO EXISTE
                    //1 verificar si el equipo esta creado?
                    //1.1 si esta creado
                    //  1.1.1, verificar si el equipo esta asignado? 
                    //  1.1.1.1 si esta signado; enviar error
                    //  1.1.1.2 no esta asignado, crear el registro de aisgnacion, actualizar el estado de equipo a no disponible, fin
                    //1.2 no esta creado
                    //  1.2.1 crear el equipo y registro de asignacion, actualizar estado de equipo a no dispponible


                    int countEquipoCreado = (from T0 in bd.Equipos
                                             where T0.nro_serie == tbNroSerieCCom.Text
                                             select T0).Count();

                    var asignado1 = (from T0 in bd.Equipos
                                     where T0.nro_serie == tbNroSerieCCom.Text
                                     select T0).ToList();

                    //1 verificar si el equipo esta creado?
                    if (countEquipoCreado > 0)//1.1 si esta creado
                    #region
                    {
                        //  1.1.1, verificar si el equipo esta asignado? 
                        if (asignado1[0].activo != "N") //  1.1.1.1 si esta signado; enviar error
                        {
                            var reg_existe2 = (from T0 in bd.Registros
                                               join T1 in bd.Equipos on T0.cod_equipo equals T1.cod_equipo
                                               join T3 in bd.Personals on T0.doc_entry_personal equals T3.doc_entry_personal
                                               where T1.nro_serie == tbNroSerieCCom.Text
                                               select T3).ToList();
                            MessageBox.Show("El equipo con serie: " + tbNroSerieCCom.Text + " esta asignado a: " + reg_existe2[0].nombre_completo);
                            tbNombreEquipoCCom.Focus();
                        }
                        else //  1.1.1.2 no esta asignado, crear el registro de aisgnacion, actualizar el estado de equipo a no disponible, fin
                        {
                            //validar nombre

                            if (tbNombreEquipoCCom.Text == string.Empty)
                            {
                                if (Convert.ToInt32(cbCatEqCCom.SelectedValue) != 7 )
                                {

                                    MessageBox.Show("Ingrese un componente: MONITOR || CPU || TECLADO");
                                    tbNombreEquipo.Focus();

                                }
                                else
                                {
                                    #region
                                    if (tbMarcaCCom.Text == string.Empty)
                                    {
                                        MessageBox.Show("Ingrese la marca");
                                        tbMarcaCCom.Focus();
                                    }
                                    else
                                    {
                                        if (tbNroSerieCCom.Text == string.Empty)
                                        {
                                            MessageBox.Show("Ingrese la serie");
                                            tbNroSerieCCom.Focus();
                                        }
                                        else
                                        {
                                            if (tbModeloCCom.Text == string.Empty)
                                            {
                                                MessageBox.Show("Ingrese el modelo del equipo");
                                                tbModeloCCom.Focus();
                                            }
                                            else
                                            {

                                                if (tbNroControlPatrimonialCCom.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Ingrese el cod patrimonial");
                                                    tbNroControlPatrimonialCCom.Focus();
                                                }
                                                else
                                                {
                                                    if (cbEstadoEquipoCCom.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Ingrese el Estado del equipo");
                                                        cbEstadoEquipoCCom.Focus();
                                                    }
                                                    else
                                                    {

                                                        if (cbAnioCompraCCom.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Ingrese el año de compra del equipo");
                                                            cbAnioCompraCCom.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (dtFechaAsignacionAESCCom.Text == string.Empty)
                                                            {
                                                                MessageBox.Show("Ingrese la Fecha de Asignación");
                                                                dtFechaAsignacionAESCCom.Focus();
                                                            }
                                                            else
                                                            {
                                                                ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                                Equipo objEquipo = new Equipo();

                                                                int nro = (from s in db.Equipos where s.nro_serie == tbNroSerieCCom.Text select s).Count();


                                                                //el equipo no esta creado, crear el equipo y asignarlo

                                                                if (nro > 0) //el equipo esta registrado ya existe 
                                                                {
                                                                    //verificar si el equipo esta asignado
                                                                    //despues de creado el equipo obtener el codequipo
                                                                    var _keyEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerieCCom.Text select T0).ToList();
                                                                    keyEquipoAE = _keyEquipo[0].cod_equipo;
                                                                    string asignado = _keyEquipo[0].activo;

                                                                    //obtener el docentry de personal
                                                                    var _keyPersonalAE = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0).ToList();
                                                                    keyPersonalAE = _keyPersonalAE[0].doc_entry_personal;

                                                                    Registro reg = new Registro();
                                                                    reg.doc_entry_personal = keyPersonalAE;// Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                                    reg.cod_equipo = keyEquipoAE;// Convert.ToInt32(cbCodEquipoAE.SelectedValue);

                                                                    reg.fecha_registro = dtFechaAsignacionAESCCom.Value.Date.ToShortDateString();
                                                                    reg.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");
                                                                    //asignar el equipo si y solo si el equipo no esta asignado     
                                                                    if (asignado == "S")//equipo asignado
                                                                    {
                                                                        MessageBox.Show("La ASIGNACION YA EXISTE. El equipo de serie: " + _keyEquipo[0].nro_serie + ", esta asignado a: " + _keyPersonalAE[0].nombre_completo);
                                                                        // MessageBox.Show("El equipo esta asignado");
                                                                    }
                                                                    else// equipo NO asignado
                                                                    {


                                                                        DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                        switch (dr)
                                                                        {
                                                                            case DialogResult.Yes:


                                                                                //asignacion de ip
                                                                                if (tbIpCCom.Text != string.Empty)
                                                                                {

                                                                                    var reg_ip = (from T0 in bd.Equipos
                                                                                                  where T0.ip_equipo == tbIpCCom.Text
                                                                                                  select T0).ToList();
                                                                                    if (reg_ip.Count() <= 1) //la ip del equipo creado existe y es unica
                                                                                    {
                                                                                        #region
                                                                                        CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                        p_clsTRegistro.registrar(reg);
                                                                                        //Actualizar el equipo a asignado
                                                                                        Equipo emp = new Equipo();
                                                                                        emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                        emp.activo = "S";
                                                                                        if (Convert.ToInt32(cbCatEqCCom.SelectedValue) == 1 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 3 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 4 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 5)
                                                                                        {
                                                                                            emp.equipo = Convert.ToString(cbCatEqCCom.Text);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            emp.equipo = tbNombreEquipoCCom.Text;

                                                                                        }
                                                                                        emp.ip_equipo = tbIpCCom.Text;

                                                                                        emp.marca = tbMarcaCCom.Text;
                                                                                        emp.modelo = tbModeloCCom.Text;
                                                                                        emp.procesador = tbProcesadorCCom.Text;
                                                                                        emp.nro_serie = tbNroSerieCCom.Text;
                                                                                        emp.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                                                                        emp.anio_adquisicion = cbAnioCompraCCom.Text;
                                                                                        emp.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                                                                        emp.observacion = tbObseracionCCom.Text;
                                                                                        emp.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                                                                        emp.funcionamiento = tbFuncionamientoCCom.Text;

                                                                                        emp.estado = cbEstadoEquipoCCom.SelectedItem.ToString();
                                                                                        emp.service_tag = tbServiceTagCCom.Text;
                                                                                        emp.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodCCom.Text);

                                                                                        db.SubmitChanges();
                                                                                        limpiarRegistroCCom();
                                                                                        MessageBox.Show("Registro realizado");
                                                                                       if (tbCodEqCComInf.Text != string.Empty)
                                                                                        {
                                                                                            int _cat = Convert.ToInt32(Convert.ToInt32(tbCodEqCComInf.Text));
                                                                                            listarRegistroCCom(_cat);
                                                                                        }
                                                                                        tbNombreEquipoCCom.Focus();

                                                                                        #endregion
                                                                                    }
                                                                                    else//el ip esta asignado a mas de un equipo
                                                                                    {
                                                                                        string ips = string.Empty;
                                                                                        string nserie = string.Empty;
                                                                                        for (int i = 0; i < reg_ip.Count(); i++)
                                                                                        {
                                                                                            ips = ips + ", " + reg_ip[i].ip_equipo.ToString();
                                                                                            nserie = nserie + ", " + reg_ip[i].nro_serie.ToString();
                                                                                        }
                                                                                        MessageBox.Show("La IP: " + tbIpCCom.Text + " Ya esta asignada (al)/(a los) equipo(s) de serie: " + nserie + " cambie de IP");
                                                                                        //tbIp.Focus();
                                                                                        //return;

                                                                                    }

                                                                                }
                                                                                else // equipo sin ip
                                                                                {
                                                                                    #region

                                                                                    CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                    p_clsTRegistro.registrar(reg);
                                                                                    //Actualizar el equipo a asignado
                                                                                    Equipo emp = new Equipo();
                                                                                    emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                    emp.activo = "S";
                                                                                    if (Convert.ToInt32(cbCatEqCCom.SelectedValue) == 1 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 3 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 4 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 5)
                                                                                    {
                                                                                        emp.equipo = Convert.ToString(cbCatEq.Text);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        emp.equipo = tbNombreEquipoCCom.Text;

                                                                                    }

                                                                                    emp.ip_equipo = tbIpCCom.Text;
                                                                                    emp.marca = tbMarcaCCom.Text;
                                                                                    emp.modelo = tbModeloCCom.Text;
                                                                                    emp.procesador = tbProcesadorCCom.Text;
                                                                                    emp.nro_serie = tbNroSerieCCom.Text;
                                                                                    emp.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                                                                    emp.anio_adquisicion = cbAnioCompraCCom.Text;
                                                                                    emp.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                                                                    emp.observacion = tbObseracionCCom.Text;
                                                                                    emp.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                                                                    emp.funcionamiento = tbFuncionamientoCCom.Text;

                                                                                    emp.estado = cbEstadoEquipoCCom.SelectedItem.ToString();
                                                                                    emp.service_tag = tbServiceTagCCom.Text;
                                                                                    emp.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodCCom.Text);

                                                                                    db.SubmitChanges();
                                                                                    limpiarRegistroCCom();
                                                                                    MessageBox.Show("Registro realizado");
                                                                                   if (tbCodEqCComInf.Text != string.Empty)
                                                                                    {
                                                                                        int _cat = Convert.ToInt32(Convert.ToInt32(tbCodEqCComInf.Text));
                                                                                        listarRegistroCCom(_cat);
                                                                                    }
                                                                                    tbNombreEquipoCCom.Focus();
                                                                                    #endregion


                                                                                }

                                                                                break;
                                                                            case DialogResult.No:
                                                                                break;


                                                                        }

                                                                    }

                                                                }
                                                            }



                                                        }



                                                    }
                                                }



                                            }

                                        }

                                    }

                                    #endregion

                                }

                            }

                            else
                            {
                                #region
                                if (tbMarcaCCom.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese la marca");
                                    tbMarcaCCom.Focus();
                                }
                                else
                                {
                                    if (tbNroSerieCCom.Text == string.Empty)
                                    {
                                        MessageBox.Show("Ingrese la serie");
                                        tbNroSerieCCom.Focus();
                                    }
                                    else
                                    {
                                        if (tbModeloCCom.Text == string.Empty)
                                        {
                                            MessageBox.Show("Ingrese el modelo del equipo");
                                            tbModeloCCom.Focus();
                                        }
                                        else
                                        {

                                            if (tbNroControlPatrimonialCCom.Text == string.Empty)
                                            {
                                                MessageBox.Show("Ingrese el cod patrimonial");
                                                tbNroControlPatrimonialCCom.Focus();
                                            }
                                            else
                                            {
                                                if (cbEstadoEquipoCCom.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Ingrese el Estado del equipo");
                                                    cbEstadoEquipoCCom.Focus();
                                                }
                                                else
                                                {

                                                    if (cbAnioCompraCCom.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Ingrese el año de compra del equipo");
                                                        cbAnioCompraCCom.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (dtFechaAsignacionAESCCom.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Ingrese la Fecha de Asignación");
                                                            dtFechaAsignacionAESCCom.Focus();
                                                        }
                                                        else
                                                        {
                                                            ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                            Equipo objEquipo = new Equipo();

                                                            int nro = (from s in db.Equipos where s.nro_serie == tbNroSerieCCom.Text select s).Count();


                                                            //el equipo no esta creado, crear el equipo y asignarlo

                                                            if (nro > 0) //el equipo esta registrado ya existe 
                                                            {
                                                                //verificar si el equipo esta asignado
                                                                //despues de creado el equipo obtener el codequipo
                                                                var _keyEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerieCCom.Text select T0).ToList();
                                                                keyEquipoAE = _keyEquipo[0].cod_equipo;
                                                                string asignado = _keyEquipo[0].activo;

                                                                //obtener el docentry de personal
                                                                var _keyPersonalAE = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0).ToList();
                                                                keyPersonalAE = _keyPersonalAE[0].doc_entry_personal;

                                                                Registro reg = new Registro();
                                                                reg.doc_entry_personal = keyPersonalAE;// Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                                reg.cod_equipo = keyEquipoAE;// Convert.ToInt32(cbCodEquipoAE.SelectedValue);

                                                                reg.fecha_registro = dtFechaAsignacionAESCCom.Value.Date.ToShortDateString();
                                                                reg.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");
                                                                //asignar el equipo si y solo si el equipo no esta asignado     
                                                                if (asignado == "S")//equipo asignado
                                                                {
                                                                    MessageBox.Show("La ASIGNACION YA EXISTE. El equipo de serie: " + _keyEquipo[0].nro_serie + ", esta asignado a: " + _keyPersonalAE[0].nombre_completo);
                                                                    // MessageBox.Show("El equipo esta asignado");
                                                                }
                                                                else// equipo NO asignado
                                                                {


                                                                    DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                    switch (dr)
                                                                    {
                                                                        case DialogResult.Yes:


                                                                            //asignacion de ip
                                                                            if (tbIpCCom.Text != string.Empty)
                                                                            {

                                                                                var reg_ip = (from T0 in bd.Equipos
                                                                                              where T0.ip_equipo == tbIpCCom.Text && T0.nro_serie == tbNroSerieCCom.Text
                                                                                              select T0).ToList();
                                                                                if (reg_ip.Count() == 1) //la ip del equipo creado existe y es unica
                                                                                {
                                                                                    #region
                                                                                    CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                    p_clsTRegistro.registrar(reg);
                                                                                    //Actualizar el equipo a asignado
                                                                                    Equipo emp = new Equipo();
                                                                                    emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                    emp.activo = "S";
                                                                                    if (Convert.ToInt32(cbCatEqCCom.SelectedValue) == 1 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 3 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 4 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 5)
                                                                                    {
                                                                                        emp.equipo = Convert.ToString(cbCatEqCCom.Text);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        emp.equipo = tbNombreEquipoCCom.Text;

                                                                                    }
                                                                                    emp.ip_equipo = tbIpCCom.Text;

                                                                                    emp.marca = tbMarcaCCom.Text;
                                                                                    emp.modelo = tbModeloCCom.Text;
                                                                                    emp.procesador = tbProcesadorCCom.Text;
                                                                                    emp.nro_serie = tbNroSerieCCom.Text;
                                                                                    emp.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                                                                    emp.anio_adquisicion = cbAnioCompraCCom.Text;
                                                                                    emp.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                                                                    emp.observacion = tbObseracionCCom.Text;
                                                                                    emp.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                                                                    emp.funcionamiento = tbFuncionamientoCCom.Text;

                                                                                    emp.estado = cbEstadoEquipoCCom.SelectedItem.ToString();
                                                                                    emp.service_tag = tbServiceTagCCom.Text;
                                                                                    emp.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodCCom.Text);
                                                                                    db.SubmitChanges();
                                                                                    limpiarRegistroCCom();
                                                                                    MessageBox.Show("Registro realizado");
                                                                                   if (tbCodEqCComInf.Text != string.Empty)
                                                                                    {
                                                                                        int _cat = Convert.ToInt32(Convert.ToInt32(tbCodEqCComInf.Text));
                                                                                        listarRegistroCCom(_cat);
                                                                                    }
                                                                                    tbNombreEquipoCCom.Focus();

                                                                                    #endregion
                                                                                }
                                                                                else//el ip esta asignado a mas de un equipo
                                                                                {
                                                                                    var reg_ips = (from T0 in bd.Equipos
                                                                                                   where T0.ip_equipo == tbIpCCom.Text
                                                                                                   select T0).ToList();
                                                                                    string ips = string.Empty;
                                                                                    string nserie = string.Empty;
                                                                                    for (int i = 0; i < reg_ips.Count(); i++)
                                                                                    {
                                                                                        ips = ips + ", " + reg_ips[i].ip_equipo.ToString();
                                                                                        nserie = nserie + ", " + reg_ips[i].nro_serie.ToString();
                                                                                    }
                                                                                    MessageBox.Show("La IP: " + tbIpCCom.Text + " Ya esta asignada (al)/(a los) equipo(s) de serie: " + nserie + " cambie de IP");
                                                                                    tbIpCCom.Focus();
                                                                                    //return;

                                                                                }

                                                                            }
                                                                            else // equipo sin ip
                                                                            {
                                                                                #region

                                                                                CTRegistro p_clsTRegistro = new CTRegistro();
                                                                                p_clsTRegistro.registrar(reg);
                                                                                //Actualizar el equipo a asignado
                                                                                Equipo emp = new Equipo();
                                                                                emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                                emp.activo = "S";
                                                                                if (Convert.ToInt32(cbCatEqCCom.SelectedValue) == 1 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 3 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 4 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 5)
                                                                                {
                                                                                    emp.equipo = Convert.ToString(cbCatEqCCom.Text);
                                                                                }
                                                                                else
                                                                                {
                                                                                    emp.equipo = tbNombreEquipoCCom.Text;

                                                                                }

                                                                                emp.ip_equipo = tbIpCCom.Text;
                                                                                emp.marca = tbMarcaCCom.Text;
                                                                                emp.modelo = tbModeloCCom.Text;
                                                                                emp.procesador = tbProcesadorCCom.Text;
                                                                                emp.nro_serie = tbNroSerieCCom.Text;
                                                                                emp.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                                                                emp.anio_adquisicion = cbAnioCompraCCom.Text;
                                                                                emp.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                                                                emp.observacion = tbObseracionCCom.Text;
                                                                                emp.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                                                                emp.funcionamiento = tbFuncionamientoCCom.Text;

                                                                                emp.estado = cbEstadoEquipoCCom.SelectedItem.ToString();
                                                                                emp.service_tag = tbServiceTagCCom.Text;
                                                                                emp.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodCCom.Text);
                                                                                db.SubmitChanges();
                                                                                limpiarRegistroCCom();
                                                                                MessageBox.Show("Registro realizado");
                                                                               if (tbCodEqCComInf.Text != string.Empty)
                                                                                {
                                                                                    int _cat = Convert.ToInt32(Convert.ToInt32(tbCodEqCComInf.Text));
                                                                                    listarRegistroCCom(_cat);
                                                                                }
                                                                                tbNombreEquipoCCom.Focus();
                                                                                #endregion


                                                                            }

                                                                            break;
                                                                        case DialogResult.No:
                                                                            break;
                                                                    }

                                                                }

                                                            }
                                                        }



                                                    }



                                                }
                                            }



                                        }

                                    }

                                }

                                #endregion

                            }

                            //  end 1.1.1.2 no esta asignado, crear el registro de aisgnacion, actualizar el estado de equipo a no disponible, fin

                        }

                    #endregion

                        //end si esta creado
                    }

                    else //1.2 no esta creado    
                    {


                        //  1.2.1 crear el equipo y registro de asignacion, actualizar estado de equipo a no dispponible

                        if (tbNombreEquipoCCom.Text == string.Empty)
                        {
                            if (Convert.ToInt32(cbCatEqCCom.SelectedValue) == 2 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 6)
                            {

                                MessageBox.Show("Ingrese la nombre de equipo");
                                tbNombreEquipoCCom.Focus();

                            }
                            else
                            {
                                #region

                                if (tbMarcaCCom.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese la marca");
                                    tbMarcaCCom.Focus();
                                }
                                else
                                {
                                    if (tbNroSerieCCom.Text == string.Empty)
                                    {
                                        MessageBox.Show("Ingrese la serie");
                                        tbNroSerieCCom.Focus();
                                    }
                                    else
                                    {
                                        if (tbModeloCCom.Text == string.Empty)
                                        {
                                            MessageBox.Show("Ingrese el modelo del equipo");
                                            tbModeloCCom.Focus();
                                        }
                                        else
                                        {

                                            if (tbNroControlPatrimonialCCom.Text == string.Empty)
                                            {
                                                MessageBox.Show("Ingrese el cod patrimonial");
                                                tbNroControlPatrimonialCCom.Focus();
                                            }
                                            else
                                            {
                                                if (cbEstadoEquipoCCom.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Ingrese el Estado del equipo");
                                                    cbEstadoEquipoCCom.Focus();
                                                }
                                                else
                                                {

                                                    if (cbAnioCompraCCom.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Ingrese el año de compra del equipo");
                                                        cbAnioCompraCCom.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (dtFechaAsignacionAESCCom.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Ingrese la Fecha de Asignación");
                                                            dtFechaAsignacionAESCCom.Focus();
                                                        }
                                                        else
                                                        {
                                                            ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                            Equipo objEquipo = new Equipo();

                                                            int nro = (from s in db.Equipos where s.nro_serie == tbNroSerieCCom.Text select s).Count();


                                                            //el equipo no esta creado, crear el equipo y asignarlo

                                                            if (nro == 0)
                                                            {
                                                                int pcod_equipo = 0;
                                                                int count = (from s in db.Equipos select s).Count();
                                                                if (count == 0)
                                                                {
                                                                    objEquipo.cod_equipo = pcod_equipo + 1;
                                                                }
                                                                else
                                                                {

                                                                    // objEquipo.cod_equipo = Convert.ToInt32(db.Equipos.Select(p => p.cod_equipo).Max()) + 1;
                                                                    objEquipo.cod_equipo = db.Equipos.Max(c => c.cod_equipo) + 1;
                                                                }
                                                                if (Convert.ToInt32(cbCatEqCCom.SelectedValue) == 1 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 3 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 4 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 5)
                                                                {
                                                                    objEquipo.equipo = Convert.ToString(cbCatEqCCom.Text);
                                                                }
                                                                else
                                                                {
                                                                    objEquipo.equipo = tbNombreEquipoCCom.Text;

                                                                }
                                                                if (tbIpCCom.Text != string.Empty)
                                                                {
                                                                    var reg_ip = (from T0 in bd.Equipos
                                                                                  where T0.ip_equipo == tbIpCCom.Text
                                                                                  select T0).ToList();
                                                                    if (reg_ip.Count() <= 0)
                                                                    {
                                                                        objEquipo.ip_equipo = tbIpCCom.Text;
                                                                    }
                                                                    else//el ip ya esta asignado
                                                                    {
                                                                        MessageBox.Show("La IP: " + tbIpCCom.Text + " Ya se encuentra asignada (al)/(a la) " + reg_ip[0].equipo + " de serie: " + reg_ip[0].nro_serie + " cambie de IP");
                                                                        // tbIp.Focus();
                                                                        return;
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    objEquipo.ip_equipo = tbIpCCom.Text;

                                                                }

                                                                objEquipo.marca = tbMarcaCCom.Text;
                                                                objEquipo.modelo = tbModeloCCom.Text;
                                                                objEquipo.procesador = tbProcesadorCCom.Text;
                                                                objEquipo.nro_serie = tbNroSerieCCom.Text;
                                                                objEquipo.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                                                objEquipo.anio_adquisicion = cbAnioCompraCCom.Text;
                                                                objEquipo.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                                                objEquipo.observacion = tbObseracionCCom.Text;
                                                                objEquipo.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                                                objEquipo.funcionamiento = tbFuncionamientoCCom.Text;
                                                                objEquipo.activo = "N";//cbAsignado.SelectedItem.ToString();
                                                                objEquipo.estado = cbEstadoEquipoCCom.SelectedItem.ToString();
                                                                objEquipo.service_tag = tbServiceTagCCom.Text;
                                                                objEquipo.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodCCom.Text);

                                                                DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                                switch (dr)
                                                                {
                                                                    case DialogResult.Yes:
                                                                        //registrar equipo con asignado=N
                                                                        CTEquipo _clsTEqupipo = new CTEquipo();
                                                                        _clsTEqupipo.registrar(objEquipo);


                                                                        //despues de crear obtener el codequipo
                                                                        var _keyEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerieCCom.Text select T0).ToList();
                                                                        keyEquipoAE = _keyEquipo[0].cod_equipo;
                                                                        string asignado = _keyEquipo[0].activo;

                                                                        //obtener el docentry de personal
                                                                        var _keyPersonalAE = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0).ToList();
                                                                        keyPersonalAE = _keyPersonalAE[0].doc_entry_personal;

                                                                        Registro reg = new Registro();
                                                                        reg.doc_entry_personal = keyPersonalAE;// Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                                        reg.cod_equipo = keyEquipoAE;// Convert.ToInt32(cbCodEquipoAE.SelectedValue);

                                                                        reg.fecha_registro = dtFechaAsignacionAESCCom.Value.Date.ToShortDateString();
                                                                        reg.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");


                                                                        //asignar el equipo si y solo si el equipo no esta asignado
                                                                        if (asignado == "N")
                                                                        {
                                                                            CTRegistro p_clsTRegistro = new CTRegistro();
                                                                            p_clsTRegistro.registrar(reg);
                                                                            //equipo asignado
                                                                            Equipo emp = new Equipo();
                                                                            emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                            emp.activo = "S";
                                                                            db.SubmitChanges();

                                                                            limpiarRegistro();
                                                                            MessageBox.Show("Registro realizado");
                                                                           if (tbCodEqCComInf.Text != string.Empty)
                                                                            {
                                                                                int _cat = Convert.ToInt32(Convert.ToInt32(tbCodEqCComInf.Text));
                                                                                listarRegistroCCom(_cat);
                                                                            }
                                                                            tbNombreEquipoCCom.Focus();
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("El equipo de serie: " + _keyEquipo[0].nro_serie + ", esta asignado a: " + _keyPersonalAE[0].nombre_completo);
                                                                        }



                                                                        break;
                                                                    case DialogResult.No:
                                                                        break;
                                                                }

                                                            }


                                                        }


                                                    }



                                                }
                                            }



                                        }

                                    }

                                }

                                #endregion
                            }

                        }
                        else
                        {
                            #region

                            if (tbMarcaCCom.Text == string.Empty)
                            {
                                MessageBox.Show("Ingrese la marca");
                                tbMarcaCCom.Focus();
                            }
                            else
                            {
                                if (tbNroSerieCCom.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese la serie");
                                    tbNroSerieCCom.Focus();
                                }
                                else
                                {
                                    if (tbModeloCCom.Text == string.Empty)
                                    {
                                        MessageBox.Show("Ingrese el modelo del equipo");
                                        tbModeloCCom.Focus();
                                    }
                                    else
                                    {

                                        if (tbNroControlPatrimonialCCom.Text == string.Empty)
                                        {
                                            MessageBox.Show("Ingrese el cod patrimonial");
                                            tbNroControlPatrimonialCCom.Focus();
                                        }
                                        else
                                        {
                                            if (cbEstadoEquipoCCom.Text == string.Empty)
                                            {
                                                MessageBox.Show("Ingrese el Estado del equipo");
                                                cbEstadoEquipoCCom.Focus();
                                            }
                                            else
                                            {

                                                if (cbAnioCompraCCom.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Ingrese el año de compra del equipo");
                                                    cbAnioCompraCCom.Focus();
                                                }
                                                else
                                                {
                                                    if (dtFechaAsignacionAESCCom.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Ingrese la Fecha de Asignación");
                                                        dtFechaAsignacionAESCCom.Focus();
                                                    }
                                                    else
                                                    {
                                                        ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                        Equipo objEquipo = new Equipo();

                                                        int nro = (from s in db.Equipos where s.nro_serie == tbNroSerieCCom.Text select s).Count();


                                                        //el equipo no esta creado, crear el equipo y asignarlo

                                                        if (nro == 0)
                                                        {
                                                            int pcod_equipo = 0;
                                                            int count = (from s in db.Equipos select s).Count();
                                                            if (count == 0)
                                                            {
                                                                objEquipo.cod_equipo = pcod_equipo + 1;
                                                            }
                                                            else
                                                            {

                                                                // objEquipo.cod_equipo = Convert.ToInt32(db.Equipos.Select(p => p.cod_equipo).Max()) + 1;
                                                                objEquipo.cod_equipo = db.Equipos.Max(c => c.cod_equipo) + 1;
                                                            }
                                                            if (Convert.ToInt32(cbCatEqCCom.SelectedValue) == 1 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 3 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 4 || Convert.ToInt32(cbCatEqCCom.SelectedValue) == 5)
                                                            {
                                                                objEquipo.equipo = Convert.ToString(cbCatEqCCom.Text);
                                                            }
                                                            else
                                                            {
                                                                objEquipo.equipo = tbNombreEquipoCCom.Text;

                                                            }
                                                            if (tbIpCCom.Text != string.Empty)
                                                            {
                                                                var reg_ip = (from T0 in bd.Equipos
                                                                              where T0.ip_equipo == tbIpCCom.Text
                                                                              select T0).ToList();
                                                                if (reg_ip.Count() <= 0)
                                                                {
                                                                    objEquipo.ip_equipo = tbIpCCom.Text;
                                                                }
                                                                else//el ip ya esta asignado
                                                                {
                                                                    MessageBox.Show("La IP: " + tbIpCCom.Text + " Ya se encuentra asignada (al)/(a la) " + reg_ip[0].equipo + " de serie: " + reg_ip[0].nro_serie + " cambie de IP");
                                                                    // tbIp.Focus();
                                                                    return;
                                                                }

                                                            }
                                                            else
                                                            {
                                                                objEquipo.ip_equipo = tbIpCCom.Text;

                                                            }

                                                            objEquipo.marca = tbMarcaCCom.Text;
                                                            objEquipo.modelo = tbModeloCCom.Text;
                                                            objEquipo.procesador = tbProcesadorCCom.Text;
                                                            objEquipo.nro_serie = tbNroSerieCCom.Text;
                                                            objEquipo.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                                            objEquipo.anio_adquisicion = cbAnioCompraCCom.Text;
                                                            objEquipo.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                                            objEquipo.observacion = tbObseracionCCom.Text;
                                                            objEquipo.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                                            objEquipo.funcionamiento = tbFuncionamientoCCom.Text;
                                                            objEquipo.activo = "N";//cbAsignado.SelectedItem.ToString();
                                                            objEquipo.estado = cbEstadoEquipoCCom.SelectedItem.ToString();
                                                            objEquipo.service_tag = tbServiceTagCCom.Text;
                                                            objEquipo.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodCCom.Text);
                                                            DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                            switch (dr)
                                                            {
                                                                case DialogResult.Yes:
                                                                    //registrar equipo con asignado=N
                                                                    CTEquipo _clsTEqupipo = new CTEquipo();
                                                                    _clsTEqupipo.registrar(objEquipo);


                                                                    //despues de crear obtener el codequipo
                                                                    var _keyEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerieCCom.Text select T0).ToList();
                                                                    keyEquipoAE = _keyEquipo[0].cod_equipo;
                                                                    string asignado = _keyEquipo[0].activo;

                                                                    //obtener el docentry de personal
                                                                    var _keyPersonalAE = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0).ToList();
                                                                    keyPersonalAE = _keyPersonalAE[0].doc_entry_personal;

                                                                    Registro reg = new Registro();
                                                                    reg.doc_entry_personal = keyPersonalAE;// Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                                    reg.cod_equipo = keyEquipoAE;// Convert.ToInt32(cbCodEquipoAE.SelectedValue);

                                                                    reg.fecha_registro = dtFechaAsignacionAESCCom.Value.Date.ToShortDateString();
                                                                    reg.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");


                                                                    //asignar el equipo si y solo si el equipo no esta asignado
                                                                    if (asignado == "N")
                                                                    {
                                                                        CTRegistro p_clsTRegistro = new CTRegistro();
                                                                        p_clsTRegistro.registrar(reg);
                                                                        //equipo asignado
                                                                        Equipo emp = new Equipo();
                                                                        emp = db.Equipos.Single(x => x.cod_equipo == keyEquipoAE);
                                                                        emp.activo = "S";
                                                                        db.SubmitChanges();

                                                                        limpiarRegistroCCom();
                                                                        MessageBox.Show("Registro realizado");
                                                                       if (tbCodEqCComInf.Text != string.Empty)
                                                                        {
                                                                            int _cat = Convert.ToInt32(Convert.ToInt32(tbCodEqCComInf.Text));
                                                                            listarRegistroCCom(_cat);
                                                                        }
                                                                        tbNombreEquipo.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("El equipo de serie: " + _keyEquipo[0].nro_serie + ", esta asignado a: " + _keyPersonalAE[0].nombre_completo);
                                                                    }



                                                                    break;
                                                                case DialogResult.No:
                                                                    break;
                                                            }

                                                        }


                                                    }


                                                }



                                            }
                                        }



                                    }

                                }

                            }

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
        private void btRegistrarAE_Click(object sender, EventArgs e)
        {
            registrarAE();
        }

        private void tbLimpiarAE_Click(object sender, EventArgs e)
        {
            limpiarRegistro();

        }

        private void tbActualizarAE_Click(object sender, EventArgs e)
        {
             try
            {




                            //obtener keyequipoAe a partir del keyregistro

                            //ModeloDatoDataContext db88 = new ModeloDatoDataContext();
                            // int existeCodEquipo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerie.Text select T0).Count();
                            //  var keyequipoAe = (from T0 in db88.Registros where T0.cod_registro == keyRegistro select new { cod_equipo=T0.cod_equipo, doc_entry_pers= T0.doc_entry_personal }).ToList();

                            //1 verificar que se selecione un registro
                            //2 verificar que no haya cambio de equipo-> obtener keys apartir del dni y serie. y verificar que sean los del registro.
                            if (keyRegistro != 0)//1 verificar que se selecione un registro
                            {
                                //2 verificar que no haya cambio de equipo
                                //2.1 no hay cambio de equipo
                                //2.2 hay cambio de equipo
                                ModeloDatoDataContext db88 = new ModeloDatoDataContext();
                                var keyesReg = (from T0 in db88.Registros where T0.cod_registro == keyRegistro select new { cod_equipo = T0.cod_equipo, doc_entry_pers = T0.doc_entry_personal }).ToList();
                                var serie = (from T0 in db88.Equipos where T0.cod_equipo == keyesReg[0].cod_equipo select T0.nro_serie).ToList();
                                var dni = (from T0 in db88.Personals where T0.doc_entry_personal == keyesReg[0].doc_entry_pers select T0.dni).ToList();
                                if (serie[0] == tbNroSerie.Text && dni[0] == tbDniAE.Text)//2.1 no hay cambio de equipo se actualizaran datos de reg y equipo q no sea serie
                                {

                                    //verificar si el quipo ya esta asignado
                                    ModeloDatoDataContext db = new ModeloDatoDataContext();
                                    int eq_activo = (from T0 in db.Equipos where T0.cod_equipo == Convert.ToInt32(cbCodEquipoAE.SelectedValue) && T0.activo == "S" select T0).Count();
                                    //si quiero actualizar otros datos que no sea cambio de equipo                    
                                    //si el codigo del equipo en el cb es igual al del registro
                                    int act_equipo = (from T0 in db.Registros where T0.cod_registro == keyRegistro && T0.cod_equipo == keyRegistro_CodEquipo select T0).Count();
                                    if (act_equipo > 0)//se puede actualizar otros datos que no son cambio de equipo
                                    {
                                        //actualizar equipo
                                        Equipo objEquipo = new Equipo();
                                        objEquipo.cod_equipo = keyRegistro_CodEquipo;
                                        //objEquipo.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCod.SelectedValue);
                                        objEquipo.equipo = tbNombreEquipo.Text;
                                        //actualizar ip
                                        if (tbIp.Text != string.Empty )
                                        {
                                            if (tbNroSerie.Text != string.Empty)
                                            {
                                                var reg_ip = (from T0 in db.Equipos
                                                              where T0.ip_equipo == tbIp.Text && T0.nro_serie == tbNroSerie.Text
                                                              select T0).ToList();
                                                if (reg_ip.Count() == 1)//mismo ip
                                                {
                                                    objEquipo.ip_equipo = tbIp.Text;
                                                }
                                                else//el ip ya esta asignado o no lo esta
                                                {
                                                    var reg_ips = (from T0 in db.Equipos
                                                                  where T0.ip_equipo == tbIp.Text
                                                                  select T0).ToList();
                                                    if (reg_ips.Count() > 0)//mismo ip
                                                    {
                                                        
                                                        MessageBox.Show("La IP: " + tbIp.Text + " Ya se encuentra asignada (al)/(a la) " + reg_ips[0].equipo + " de serie: " + reg_ips[0].nro_serie + " cambie de IP");
                                                        tbIp.Focus();
                                                        return;
                                                        
                                                    }
                                                    else//se actualiza el ip
                                                        objEquipo.ip_equipo = tbIp.Text;
                                                   
                                                }
 
                                            }                                         

                                        }
                                        else
                                        {
                                            objEquipo.ip_equipo = tbIp.Text;
 
                                        }
                                        
                                        objEquipo.marca = tbMarca.Text;
                                        objEquipo.modelo = tbModelo.Text;
                                        objEquipo.procesador = tbProcesador.Text;
                                        objEquipo.nro_serie = tbNroSerie.Text;
                                        objEquipo.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                                        objEquipo.anio_adquisicion = cbAnioCompra.Text;
                                        objEquipo.nro_orden_compra = tbNroOrdenCompra.Text;
                                        objEquipo.activo = "S";
                                        objEquipo.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);
                                        objEquipo.observacion = tbObseracion.Text;
                                        objEquipo.estado = Convert.ToString(cbEstadoEquipo.SelectedItem);
                                        objEquipo.service_tag = tbServiceTag.Text;
                                        objEquipo.funcionamiento = tbFuncionamiento.Text;

                                        //actualizar registro

                                        Registro obj = new Registro();
                                        obj.cod_registro = keyRegistro;
                                        obj.cod_equipo = keyRegistro_CodEquipo;
                                        obj.doc_entry_personal = keyRegistro_doc_entry_personal;   //Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                        obj.fecha_registro = dtFechaAsignacionAES.Value.Date.ToShortDateString();
                                        //obj.observacion = tbObservacionlAE.Text;
                                        obj.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");

                                        DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                                        switch (dr)
                                        {
                                            case DialogResult.Yes:
                                                CTEquipo p_clsTEqupipo = new CTEquipo();
                                                CTRegistro p_clsTRegistro = new CTRegistro();

                                                p_clsTEqupipo.actualizar(objEquipo);
                                                p_clsTRegistro.actualizar(obj);
                                                limpiarRegistro();
                                                MessageBox.Show("Registro Actualizado");
                                                tbNombreEquipo.Focus();
                                                if (cbCatEq.Text != string.Empty)
                                                {
                                                    int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                                    listarRegistro(_cat);
                                                }

                                                break;
                                            case DialogResult.No:
                                                break;
                                        }


                                    }

                                }
                                else
                                {
                                    if (serie[0] != tbNroSerie.Text && dni[0] == tbDniAE.Text)//2.2 cambio de equipo ya registrado
                                    {
                                        int countSerie = (from T0 in db88.Equipos where T0.nro_serie == tbNroSerie.Text select T0).Count();
                                        if (countSerie > 0)//verificar si el equipo existe
                                        {
                                            //verificar si el equipo no tiene componentes ni software asignado


                                            //verificar si hay algun equipo con software asignado
                                            ModeloDatoDataContext db = new ModeloDatoDataContext();
                                            int _eqSof = (from T0 in db.Equipo_softwares where T0.cod_equipo == keyRegistro_CodEquipo select T0).Count();
                                            int _eqPadre = (from T0 in db.Equipos where T0.equipoPadreCod == keyRegistro_CodEquipo select T0).Count();
                                            if (_eqSof > 0)
                                            {
                                                MessageBox.Show("No se puede Actualizar la asignacion, El equipo de serie: " + serie[0] + " tiene asignado software ");
                                            }
                                            else
                                            {
                                                if (_eqPadre > 0)
                                                {
                                                    MessageBox.Show("No se puede Actualizar la asignacion, El equipo de serie: " + serie[0] + " tiene asignado componentes");

                                                }
                                                else
                                                {
                                                    //actualizar equipo
                                                    Equipo objEquipo = new Equipo();
                                                    var cod_Equipo_nuevo = (from T0 in db.Equipos where T0.nro_serie == tbNroSerie.Text select T0).ToList();
                                                    objEquipo.cod_equipo = cod_Equipo_nuevo[0].cod_equipo;// keyRegistro_CodEquipo;//nuevo codigo
                                                    objEquipo.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCod.SelectedValue);
                                                    objEquipo.equipo = tbNombreEquipo.Text;
                                                    //actualizar ip
                                                    if (tbIp.Text != string.Empty)
                                                    {
                                                        if (tbNroSerie.Text != string.Empty)
                                                        {
                                                            var reg_ip = (from T0 in db.Equipos
                                                                          where T0.ip_equipo == tbIp.Text && T0.nro_serie == tbNroSerie.Text
                                                                          select T0).ToList();
                                                            if (reg_ip.Count() == 1)//mismo ip
                                                            {
                                                                objEquipo.ip_equipo = tbIp.Text;
                                                            }
                                                            else//el ip ya esta asignado o no lo esta
                                                            {
                                                                var reg_ips = (from T0 in db.Equipos
                                                                               where T0.ip_equipo == tbIp.Text
                                                                               select T0).ToList();
                                                                if (reg_ips.Count() > 0)//mismo ip
                                                                {

                                                                    MessageBox.Show("La IP: " + tbIp.Text + " Ya se encuentra asignada (al)/(a la) " + reg_ips[0].equipo + " de serie: " + reg_ips[0].nro_serie + " cambie de IP");
                                                                    tbIp.Focus();
                                                                    return;
                                                                }
                                                                else//se actualiza el ip
                                                                    objEquipo.ip_equipo = tbIp.Text;

                                                            }

                                                        }

                                                    }
                                                    else
                                                    {
                                                        objEquipo.ip_equipo = tbIp.Text;

                                                    }
                                                    objEquipo.marca = tbMarca.Text;
                                                    objEquipo.modelo = tbModelo.Text;
                                                    objEquipo.procesador = tbProcesador.Text;
                                                    objEquipo.nro_serie = tbNroSerie.Text;
                                                    objEquipo.nro_control_patrimonial = tbNroControlPatrimonial.Text;
                                                    objEquipo.anio_adquisicion = cbAnioCompra.Text;
                                                    objEquipo.nro_orden_compra = tbNroOrdenCompra.Text;


                                                    objEquipo.cod_categoria = Convert.ToInt32(cbCatEq.SelectedValue);
                                                    objEquipo.observacion = tbObseracion.Text;
                                                    objEquipo.estado = Convert.ToString(cbEstadoEquipo.SelectedItem);
                                                    objEquipo.service_tag = tbServiceTag.Text;
                                                    objEquipo.funcionamiento = tbFuncionamiento.Text;

                                                    //actualizar registro

                                                    //actualizar valores del registro
                                                    Registro obj = new Registro();
                                                    obj.cod_registro = keyRegistro;
                                                    obj.cod_equipo = Convert.ToInt32(cod_Equipo_nuevo[0].cod_equipo);
                                                    obj.doc_entry_personal = Convert.ToInt32(cbCodPersonalAE.SelectedValue);
                                                    obj.fecha_registro = dtFechaIngAE.Value.Date.ToShortDateString();
                                                    //obj.observacion = tbObservacionlAE.Text;
                                                    obj.fecha_sistema = DateTime.Now.ToString("dd/MM/yyyy");
                                                    DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                                                    switch (dr)
                                                    {
                                                        case DialogResult.Yes:
                                                            //actualizar el nuevo registro
                                                            CTRegistro _cTRegistro = new CTRegistro();
                                                            _cTRegistro.actualizar(obj);
                                                            //actualizar a disponible el equipo anterior
                                                            /*
                                                             serie[0]== tbNroSerie.Text
                                                             */

                                                            objEquipo.activo = "S";

                                                            //actualizar a disponible el equipo anterior
                                                            Equipo emp = new Equipo();
                                                            emp = db.Equipos.Single(x => x.cod_equipo == keyesReg[0].cod_equipo);
                                                            emp.activo = "N";
                                                            db.SubmitChanges();

                                                            //actualizar a no disponible el nuevo equipo
                                                            objEquipo.activo = "S";
                                                            Equipo emp2 = new Equipo();
                                                            /*emp2 = db.Equipos.Single(x => x.nro_serie == tbNroSerie.Text);
                                                            emp2.activo = "S";
                                                            db.SubmitChanges();*/


                                                            //actualizar equipo
                                                            CTEquipo _ctequipo = new CTEquipo();
                                                            _ctequipo.actualizar(objEquipo);


                                                            limpiarRegistro();
                                                            MessageBox.Show("Registro Actualizado");
                                                            tbNombreEquipo.Focus();
                                                            if (cbCatEq.Text != string.Empty)
                                                            {
                                                                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                                                listarRegistro(_cat);
                                                            }

                                                            break;
                                                        case DialogResult.No:
                                                            break;
                                                    }


                                                }
                                            }




                                        }
                                        else
                                        {
                                            MessageBox.Show("El equipo con la serie: " + tbNroSerie.Text + " NO existe. Antes de Hacer la reasignacion registrar el equipo en el modulo de Equipo");
                                        }
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Seleccione un Registro de la lista");
                            }


    
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }


        }

        private void tbEliminarAE_Click(object sender, EventArgs e)
        {
            try
            {


                if (keyRegistro != 0 && keyRegistro_CodEquipo != 0 && keyRegistro_doc_entry_personal != 0)
                {
                    //verificar si hay algun equipo con software asignado
                    ModeloDatoDataContext db = new ModeloDatoDataContext();
                    int _eqSof = (from T0 in db.Equipo_softwares where T0.cod_equipo == keyRegistro_CodEquipo select T0).Count();
                    var componentes = (from T0 in db.Equipos where T0.equipoPadreCod == keyRegistro_CodEquipo select T0).ToList();
                   
                 
                            var _cod = (from T0 in db.Registros
                                        where T0.cod_registro == keyRegistro
                                        select new
                                        {
                                            _codEq = T0.cod_equipo,


                                        }).ToList();

                     
                            DialogResult dr = MessageBox.Show("Desea Eliminar?", "Alerta...", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                   
                                    //verificar si el EQUIPO asignado al usuario actual, es padre de ALGUN componente asignado A a este USUARIO
                                    if (componentes.Count() > 0)
                                    {
                                        foreach (var comp in componentes)
                                        {
                                            var regComp = (from T0 in db.Registros where T0.cod_equipo == comp.cod_equipo && T0.doc_entry_personal == keyRegistro_doc_entry_personal select T0).ToList();
                                            if (regComp.Count() > 0)
                                            {
                                                CTRegistro crecomp = new CTRegistro();
                                                crecomp.eliminar(regComp[0].cod_registro);
 
                                            }
                                        }
                                        CTEquipo clsTEqupipo2 = new CTEquipo();
                                        CTRegistro clsTRegistro2 = new CTRegistro();
                                        //si tiene componentes eliminar la asignacion AL USUARIO de estos componentes
                                        //si no eliminar la asignacion del equipo 
                                        clsTRegistro2.eliminar(keyRegistro);
                                        //el equipo pasaria a no asignado y no se elimina el equipo
                                        //clsTEqupipo2.eliminar(_cod[0]._codEq);
                                        Equipo emp = new Equipo();
                                        emp = db.Equipos.Single(x => x.cod_equipo == _cod[0]._codEq);
                                        emp.activo = "N";
                                        emp.equipoPadreCod = 0;
                                        db.SubmitChanges();


                                        limpiarRegistro();
                                        MessageBox.Show("registro eliminado");
                                        if (cbCatEq.Text != string.Empty)
                                        {
                                            int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                            listarRegistro(_cat);
                                        }

                                        tbNombreEquipo.Focus();
 
                                    }
                                    else
                                    {
                                        CTEquipo clsTEqupipo2 = new CTEquipo();
                                        CTRegistro clsTRegistro2 = new CTRegistro();
                                        //si tiene componentes eliminar la asignacion AL USUARIO de estos componentes
                                        //si no eliminar la asignacion del equipo 
                                        clsTRegistro2.eliminar(keyRegistro);
                                        //el equipo pasaria a no asignado y no se elimina el equipo
                                        //clsTEqupipo2.eliminar(_cod[0]._codEq);
                                        Equipo emp = new Equipo();
                                        emp = db.Equipos.Single(x => x.cod_equipo == _cod[0]._codEq);
                                        emp.activo = "N";
                                        emp.equipoPadreCod = 0;
                                        db.SubmitChanges();


                                        limpiarRegistro();
                                        MessageBox.Show("registro eliminado");
                                        if (cbCatEq.Text != string.Empty)
                                        {
                                            int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                                            listarRegistro(_cat);
                                        }

                                        tbNombreEquipo.Focus();
                                    }
                                   
                                    break;
                                case DialogResult.No:
                                    break;
                            

                            }


                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }
        private void limpiarRegistro()
        {
            /*PARTE DEL EQUIPO*/
            // cbCatEq.SelectedIndex = -1;
            tbMarca.Text = string.Empty;
            tbModelo.Text = string.Empty;
            tbNroSerie.Text = string.Empty;
            tbProcesador.Text = string.Empty;
            tbNroControlPatrimonial.Text = string.Empty;
            cbEstadoEquipo.SelectedIndex = -1;
            tbNroOrdenCompra.Text = string.Empty;
            cbAnioCompra.SelectedIndex = -1;
            tbIp.Text = string.Empty;
            tbFuncionamiento.Text = string.Empty;
            tbObseracion.Text = string.Empty;
            cbAsignado.SelectedIndex = -1;
            tbNombreEquipo.Text = string.Empty;
            dtFechaAsignacionAES.Text = string.Empty;
            DGVRegistro.DataSource = null;


            /////////////////////
            /*
            dtFechaIngAE.Text = string.Empty;
            //tbObservacionlAE.Text = string.Empty;
            cbCodEquipoAE.SelectedIndex = -1;
            cbCodPersonalAE.SelectedIndex = -1;
            cbCodEquipoAE.DataSource=null;
            cbCodEquipoAE.Items.Clear();
            cbCodPersonalAE.DataSource = null;
            cbCodPersonalAE.Items.Clear();
            tbNombreAE.Text=string.Empty;
            tbDniAE.Text=string.Empty;
            tbSedeAE.Text=string.Empty;
            tbInstancAE.Text=string.Empty;
           // tbEquipoAE.Text=string.Empty;
           // tbMarcaAE.Text=string.Empty;
           // tbModeloAE.Text=string.Empty;
           // tbSerieAE.Text=string.Empty;
           // tbCodPatrAE.Text = string.Empty;
            tbPerfilAE.Text = string.Empty;
            */
           // dtFechaAsignacionAES.Value = DateTime.Now;

        }
        private void listarRegistro(int _cat)
        {
            if (tbDniAE.Text != string.Empty)
            {
                DGVRegistro.AutoGenerateColumns = false;
                ModeloDatoDataContext db = new ModeloDatoDataContext();

                var tipoPersonal = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0.tipo_personal).ToList();
                if (tipoPersonal[0] == "J")
                {
                    var sql = (from T0 in db.Registros
                               join T1 in db.Personals on T0.doc_entry_personal equals T1.doc_entry_personal
                               join T2 in db.Instancias on T1.c_instancia equals T2.c_instancia
                               join T3 in db.Equipos on T0.cod_equipo equals T3.cod_equipo
                               join T4 in db.Sedes on T1.c_sede equals T4.c_sede
                               where T1.dni == tbDniAE.Text && T3.cod_categoria == _cat
                               select new
                               {
                                   id = T0.cod_registro,
                                   cod_personal = T0.doc_entry_personal,
                                   dni = T1.dni,
                                   nombre_per = T1.c_ape_paterno + ' ' + T1.c_ape_materno + ' ' + T1.c_nombres,
                                   cod_sede = T1.c_sede,
                                   nombre_sede = T4.nombre_sede,
                                   cod_instancia = T1.c_instancia,
                                   nombre_instancia = T2.nombre_instancia,
                                   cod_equipo = T0.cod_equipo,
                                   nro_serie = T3.nro_serie,
                                   nro_control_patrimonial = T3.nro_control_patrimonial,
                                   nombre_equipo = T3.equipo,
                                   fecha_registro = T0.fecha_registro,
                                   fecha_sistema = T0.fecha_sistema,
                                   observacion = T3.observacion,
                                   marca = T3.marca,
                                   modelo = T3.modelo,
                                   serie = T3.nro_serie,
                                   procesador = T3.procesador,
                                   cod_patrimonial = T3.nro_control_patrimonial,
                                   estado = T3.estado,
                                   aniocompra = T3.anio_adquisicion,
                                   ip = T3.ip_equipo,                        

                               }).ToList();

                    DGVRegistro.DataSource = sql;
                }
                else
                {
                    var sql = (from T0 in db.Registros
                               join T1 in db.Personals on T0.doc_entry_personal equals T1.doc_entry_personal

                               join T3 in db.Equipos on T0.cod_equipo equals T3.cod_equipo
                               join T4 in db.Sedes on T1.c_sede equals T4.c_sede
                               where T1.dni == tbDniAE.Text && T3.cod_categoria == _cat
                               select new
                               {
                                   id = T0.cod_registro,
                                   cod_personal = T0.doc_entry_personal,
                                   dni = T1.dni,
                                   nombre_per = T1.c_ape_paterno + ' ' + T1.c_ape_materno + ' ' + T1.c_nombres,
                                   cod_sede = T1.c_sede,
                                   nombre_sede = T4.nombre_sede,
                                   cod_instancia = string.Empty,
                                   nombre_instancia = string.Empty,
                                   cod_equipo = T0.cod_equipo,
                                   nro_serie = T3.nro_serie,
                                   nro_control_patrimonial = T3.nro_control_patrimonial,
                                   nombre_equipo = T3.equipo,
                                   fecha_registro = T0.fecha_registro,
                                   fecha_sistema = T0.fecha_sistema,
                                   observacion = T3.observacion,
                                   marca = T3.marca,
                                   modelo = T3.modelo,
                                   serie = T3.nro_serie,
                                   procesador = T3.procesador,
                                   cod_patrimonial = T3.nro_control_patrimonial,
                                   estado = T3.estado,
                                   aniocompra = T3.anio_adquisicion,
                                   ip = T3.ip_equipo,



                               }).ToList();

                    DGVRegistro.DataSource = sql;

                }


            }

        }

        //------------------cargar pk y su descripcion
        //personal
        private void cargarPersonalAE()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from eq in dc.Personals

                      select new
                      {
                          id = eq.doc_entry_personal,
                          concatenado = eq.c_ape_paterno + " " + eq.c_ape_materno + " " + eq.c_nombres + " - " + eq.dni,
                      }).ToList();


            cbCodPersonalAE.DataSource = sq;
            cbCodPersonalAE.ValueMember = "id";
            cbCodPersonalAE.DisplayMember = "concatenado";
        }

        //sede
        private void cargarSedelAE()
        {
            /*
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from eq in dc.Sedes

                      select eq).ToList();

            cbCodSedelAE.DataSource = sq;
            cbCodSedelAE.ValueMember = "cod_sede";
            cbCodSedelAE.DisplayMember = "nombre_sede";
             * */
        }

        //instancia
        private void cargarInstanciaAE()
        {
            /*
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from eq in dc.Instancias

                      select eq).ToList();

            cbCodInstanciaAE.DataSource = sq;
            cbCodInstanciaAE.ValueMember = "cod_instancia";
            cbCodInstanciaAE.DisplayMember = "nombre_instancia";
             * */
        }

        //equipo
        private void cargarEquipoAE()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from eq in dc.Equipos

                      select new
                      {
                          id = eq.cod_equipo,
                          concatenado = eq.nro_serie + "/" + eq.equipo + "/" + eq.marca + "/" + eq.modelo + "/" + eq.nro_control_patrimonial,
                      }).ToList();


            cbCodEquipoAE.DataSource = sq;
            cbCodEquipoAE.ValueMember = "id";
            cbCodEquipoAE.DisplayMember = "concatenado";
        }

        private void cbCodPersonalAE_MouseClick(object sender, MouseEventArgs e)
        {
            cargarPersonalAE();
        }
        /*
        private void cbCodPersonalAE_MouseClick(object sender, MouseEventArgs e)
        {
            cargarPersonalAE();
        }
        */

        private void cbCodSedelAE_MouseClick(object sender, MouseEventArgs e)
        {
            cargarSedelAE();
        }

        private void cbCodInstanciaAE_MouseClick(object sender, MouseEventArgs e)
        {
            cargarInstanciaAE();
        }

        private void cbCodEquipoAE_MouseClick(object sender, MouseEventArgs e)
        {
            // cargarEquipoAE();
        }

        /* private void cbCodEquipoAE_MouseClick(object sender, MouseEventArgs e)
       {
          // cargarEquipoAE();
       }
       */
        private void btListaAE_Click(object sender, EventArgs e)
        {
            //int _categoria = Convert.ToInt32(cbCatEq.SelectedValue);
            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;
            desableFormAE();
            DGVRegistro.Enabled = true;


        }
        private void desableFormAE()
        {
            cbCatEq.Enabled = false;
            tbMarca.Enabled = false;
            tbNroSerie.Enabled = false;
            tbModelo.Enabled = false;
            tbProcesador.Enabled = false;
            cbAnioCompra.Enabled = false;
            tbIp.Enabled = false;
            tbFuncionamiento.Enabled = false;
            tbObseracion.Enabled = false;
            tbNroControlPatrimonial.Enabled = false;
            cbEstadoEquipo.Enabled = false;
            tbNroOrdenCompra.Enabled = false;
            tbNombreEquipo.Enabled = false;
            cbEquipoPadreCod.Enabled = false;
            cbAsignado.Enabled = false;
            tbServiceTag.Enabled = false;
            dtFechaAsignacionAES.Enabled = false;


        }
        private void enableFormAE()
        {
            cbCatEq.Enabled = true;
            tbMarca.Enabled = true;
            tbNroSerie.Enabled = true;
            tbModelo.Enabled = true;
            tbProcesador.Enabled = true;
            cbAnioCompra.Enabled = true;
            tbIp.Enabled = true;
            tbFuncionamiento.Enabled = true;
            tbObseracion.Enabled = true;
            tbNroControlPatrimonial.Enabled = true;
            cbEstadoEquipo.Enabled = true;
            tbNroOrdenCompra.Enabled = true;
            tbNombreEquipo.Enabled = true;
            cbEquipoPadreCod.Enabled = true;
            cbAsignado.Enabled = true;
            tbServiceTag.Enabled = true;
            dtFechaAsignacionAES.Enabled = true;



        }

        private void DGVRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVRegistro.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keyRegistro = int.Parse(row.Cells[0].Value.ToString());
                    keyRegistro_doc_entry_personal = int.Parse(row.Cells[1].Value.ToString());
                    keyRegistro_CodEquipo = int.Parse(row.Cells[2].Value.ToString());
                    cargarAnioCompra();
                    obtenerRegistro(keyRegistro);

                }
            }

        }
        private void obtenerRegistro(int keyRegistro)
        {

            //limpiarRegistro();
            Registro objeto = new Registro();
            CTRegistro _ctregistro = new CTRegistro();
            objeto = _ctregistro.obtener(keyRegistro);

            dtFechaAsignacionAES.Text = objeto.fecha_registro;
            //tbObservacionlAE.Text = objeto.observacion;
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql1 = (from T3 in db.Registros
                        join T0 in db.Personals on T3.doc_entry_personal equals T0.doc_entry_personal
                        join T4 in db.Perfils on T0.c_perfil equals T4.c_perfil
                        join T1 in db.Sedes on T0.c_sede equals T1.c_sede

                        where T3.cod_registro == keyRegistro
                        select new
                        {
                            id = T0.doc_entry_personal,
                            listado = Convert.ToString(T0.c_ape_paterno) + " " + Convert.ToString(T0.c_ape_materno) + " " + Convert.ToString(T0.c_nombres) + " | " + Convert.ToString(T0.dni) + " | " + Convert.ToString(T1.nombre_sede) + " | " + "" + " | " + T4.perfil,

                        }).ToList();



            //--ds personal--

            cbCodPersonalAE.DataSource = sql1;
            cbCodPersonalAE.ValueMember = "id";
            cbCodPersonalAE.DisplayMember = "listado";



            var sql2 = (from T0 in db.Registros
                        join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                        where T0.cod_registro == keyRegistro


                        select new
                        {
                            cod_equipo = T0.cod_equipo,
                            nombre_equipo = Convert.ToString(T1.equipo) + " | " + Convert.ToString(T1.marca) + " | " + Convert.ToString(T1.modelo) + " | " + Convert.ToString(T1.nro_serie) + " | " + Convert.ToString(T1.nro_control_patrimonial),

                        }).ToList();


            //--equipo
            cbCodEquipoAE.DataSource = sql2;
            cbCodEquipoAE.ValueMember = "cod_equipo";
            cbCodEquipoAE.DisplayMember = "nombre_equipo";

            String source = Convert.ToString(sql1[0].listado); //Original Text
            String[] result = source.Split('|');
            tbNombreAE.Text = Convert.ToString(result[0]);
            tbDniAE.Text = Convert.ToString(result[1]);
            tbSedeAE.Text = Convert.ToString(result[2]);
            tbInstancAE.Text = Convert.ToString(result[3]);
            tbPerfilAE.Text = Convert.ToString(result[4]);

            String source2 = Convert.ToString(sql2[0].nombre_equipo); ; //Original Text
            String[] result2 = source2.Split('|');
            /* tbEquipoAE.Text = Convert.ToString(result2[0]);
             tbMarcaAE.Text = Convert.ToString(result2[1]);
             tbModeloAE.Text = Convert.ToString(result2[2]);
             tbSerieAE.Text = Convert.ToString(result2[3]);
             tbCodPatrAE.Text = Convert.ToString(result2[4]);
             * */

            var sql3 = (from T0 in db.Registros
                        join T3 in db.Personals on T0.doc_entry_personal equals T3.doc_entry_personal
                        join T1 in db.Equipos on T0.cod_equipo equals T1.cod_equipo
                        join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                        where T0.cod_registro == keyRegistro
                        select new
                        {
                            _cod_equipo = T0.cod_equipo,
                            _dni = T3.dni,
                            _cbCodCatEq = T1.cod_categoria,
                            _cbCatEq = T2.categoria,
                            _tbNroSerie = T1.nro_serie,
                            _tbMarca = T1.marca,
                            _tbModelo = T1.modelo,
                            _tbProcesador = T1.procesador,
                            _tbNroControlPatrimonial = T1.nro_control_patrimonial,
                            _cbEstadoEquipo = T1.estado,
                            _tbNroOrdenCompra = T1.nro_orden_compra,
                            _cbAnioCompra = T1.anio_adquisicion,
                            _tbIp = T1.ip_equipo,
                            _tbFuncionamiento = T1.funcionamiento,
                            _tbObseracion = T1.observacion,
                            _asignado = T1.activo,
                            _equipo = T1.equipo,
                            _fechaIngreso=T3.fecha_ingreso,


                            //nombre_equipo = Convert.ToString(T1.equipo) + " | " + Convert.ToString(T1.marca) + " | " + Convert.ToString(T1.modelo) + " | " + Convert.ToString(T1.nro_serie) + " | " + Convert.ToString(T1.nro_control_patrimonial),

                        }).ToList();

            // _cod_equipo = sql3[0]._cod_equipo

            tbNroSerie.Text = Convert.ToString(sql3[0]._tbNroSerie);
            tbDniAE.Text = Convert.ToString(sql3[0]._dni);
            tbMarca.Text = Convert.ToString(sql3[0]._tbMarca);
            tbModelo.Text = Convert.ToString(sql3[0]._tbModelo);
            tbProcesador.Text = Convert.ToString(sql3[0]._tbProcesador);
            tbNroControlPatrimonial.Text = Convert.ToString(sql3[0]._tbNroControlPatrimonial);
            cbEstadoEquipo.Text = Convert.ToString(sql3[0]._cbEstadoEquipo);
            cbAnioCompra.Text = Convert.ToString(sql3[0]._cbAnioCompra.ToString());
            tbIp.Text = Convert.ToString(sql3[0]._tbIp);
            tbFuncionamiento.Text = Convert.ToString(sql3[0]._tbFuncionamiento);
            tbObseracion.Text = Convert.ToString(sql3[0]._tbObseracion);
            cbAsignado.Text = Convert.ToString(sql3[0]._asignado);
            tbNroOrdenCompra.Text = Convert.ToString(sql3[0]._tbNroOrdenCompra);
            tbNombreEquipo.Text = Convert.ToString(sql3[0]._equipo);
            dtFechaIngAE.Text = Convert.ToString(sql3[0]._fechaIngreso); 


            cbCatEq.DataSource = sql3;
            cbCatEq.ValueMember = "_cbCodCatEq";
            cbCatEq.DisplayMember = "_cbCatEq";



        }

        private void tbAsignacionEq_TextChanged(object sender, EventArgs e)
        {
            buscarAsignacionEq();
        }
        private void buscarAsignacionEq()
        {
            DGVRegistro.AutoGenerateColumns = false;
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            if (tbAsignacionEq.Text != string.Empty)
            {

                var sql = (from T0 in db.Registros
                           join T1 in db.Personals on T0.doc_entry_personal equals T1.doc_entry_personal
                           join T2 in db.Instancias on T1.c_instancia equals T2.c_instancia
                           join T3 in db.Equipos on T0.cod_equipo equals T3.cod_equipo
                           join T4 in db.Sedes on T1.c_sede equals T4.c_sede
                           where T1.dni.Contains(tbAsignacionEq.Text) ||
                               T1.c_nombres.Contains(tbAsignacionEq.Text) ||
                               T1.c_ape_paterno.Contains(tbAsignacionEq.Text) ||
                               T4.nombre_sede.Contains(tbAsignacionEq.Text) ||
                               T2.nombre_instancia.Contains(tbAsignacionEq.Text) ||
                               T3.nro_serie.Contains(tbAsignacionEq.Text) ||
                               T3.nro_control_patrimonial.Contains(tbAsignacionEq.Text) ||
                               T3.equipo.Contains(tbAsignacionEq.Text) ||
                               T0.fecha_registro.Contains(tbAsignacionEq.Text) ||
                               T0.fecha_sistema.Contains(tbAsignacionEq.Text) ||
                               T0.observacion.Contains(tbAsignacionEq.Text)
                           select new
                           {
                               id = T0.cod_registro,
                               cod_personal = T0.doc_entry_personal,
                               dni = T1.dni,
                               nombre_per = T1.c_nombres + ' ' + T1.c_ape_paterno + ' ' + T1.c_ape_materno,
                               cod_sede = T1.c_sede,
                               nombre_sede = T4.nombre_sede,
                               cod_instancia = T1.c_instancia,
                               nombre_instancia = T2.nombre_instancia,
                               cod_equipo = T0.cod_equipo,
                               nro_serie = T3.nro_serie,
                               nro_control_patrimonial = T3.nro_control_patrimonial,
                               nombre_equipo = T3.equipo,
                               fecha_registro = T0.fecha_registro,
                               fecha_sistema = T0.fecha_sistema,
                               observacion = T0.observacion,

                           }).ToList();



                DGVRegistro.DataSource = sql;



            }
            else
            {
                listarRegistro(Convert.ToInt32(cbCatEq.SelectedValue));
            }


        }

        private void cbCatEq_Click(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void tbDniAE_Leave(object sender, EventArgs e)
        {

            if (tbDniAE.Text != string.Empty)//existe dni--> cargar datos
            {
                //obtener codPersonal apartir del dni
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                var sql1 = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0.doc_entry_personal).ToList();
                keyPErsonal = sql1[0];
                obtenerPersonaAE(tbDniAE.Text);
                limpiarRegistro();
                superTabControl3.SelectedTabIndex = 6;
                superTabControl2.SelectedTabIndex = 3;
                //listarRegistro(1);
                //keyPErsonal = cod_personal[0];
            }
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;
        }

        private void tbDniAE_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                if (tbDniAE.Text != String.Empty)//existe dni--> cargar datos
                {
                    Refresh();
                    ModeloDatoDataContext db = new ModeloDatoDataContext();
                    var sql1 = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0.doc_entry_personal).ToList();
                    keyPErsonal = sql1[0];
                    obtenerPersonaAE(tbDniAE.Text);
                    limpiarRegistro();
                    superTabControl3.SelectedTabIndex = 6;
                    superTabControl2.SelectedTabIndex = 3;

                    Refresh();
                    // listarRegistro(1);
                    //keyPErsonal = cod_personal[0];
                }

            }
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;

        }
        private void obtenerPersonaAE(string dni)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            //obtener codPersonal apartir del dni
            var sql1 = (from T0 in db.Personals where T0.dni == dni select T0.doc_entry_personal).ToList();
            keyPErsonal = sql1[0];
            Personal objeto = clsTPersonal.obtener(keyPErsonal);
            tbNombreAE.Text = objeto.nombre_completo;
            dtFechaIngAE.Text = objeto.fecha_ingreso;
            //perfil
            var sql2 = (from T0 in db.Personals
                        join T1 in db.Perfils on T0.c_perfil equals T1.c_perfil
                        where T1.c_perfil == objeto.c_perfil
                        select new
                        {
                            _tbPerfilAE = T1.perfil,

                        }
                    ).ToList();

            tbPerfilAE.Text = Convert.ToString(sql2[0]._tbPerfilAE);
            //sede
            var sql3 = (from T0 in db.Personals
                        join T2 in db.Sedes on T0.c_sede equals T2.c_sede
                        where T0.c_sede == objeto.c_sede
                        select new
                        {
                            _tbSedeAE = T2.nombre_sede,
                        }
                   ).ToList();
            tbSedeAE.Text = Convert.ToString(sql3[0]._tbSedeAE);

            if (objeto.c_instancia != "0")
            {
                var sql4 = (from T0 in db.Personals
                            join T2 in db.Instancias on T0.c_instancia equals T2.c_instancia
                            where T0.c_instancia == objeto.c_instancia
                            select new
                            {
                                _tbInstancAE = T2.nombre_instancia,
                            }
                 ).ToList();

                tbInstancAE.Text = Convert.ToString(sql4[0]._tbInstancAE);

            }
            else
            {
                tbInstancAE.Text = string.Empty;

            }





        }

        private void tbCerrarAE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbEditarAE_Click(object sender, EventArgs e)
        {
            cargarAnioCompra_softAE(cbAnioCompraSoftAE);


            btRegistrarAE.Enabled = false;

            tbEliminarAE.Enabled = true;
            tbActualizarAE.Enabled = true;
            cbCatEq.Enabled = false;
            tbNroSerie.Enabled = true;
            tbMarca.Focus();
            tbMarca.Enabled = true;
            tbModelo.Enabled = true;
            tbProcesador.Enabled = true;
            tbNroControlPatrimonial.Enabled = true;
            cbEstadoEquipo.Enabled = true;
            tbNroOrdenCompra.Enabled = true;
            cbAnioCompra.Enabled = true;
            tbIp.Enabled = true;
            tbFuncionamiento.Enabled = true;
            tbObseracion.Enabled = true;

            cbEquipoPadreCod.Enabled = true;
            cbAsignado.Enabled = true;

            tbServiceTag.Enabled = true;

            dtFechaAsignacionAES.Enabled = true;

            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }
            DGVRegistro.Enabled = true;

            switch (superTabControl3.SelectedTabIndex)
            {
                case 0:
                    tbNombreEquipo.Enabled = false;
                    tbMarca.Focus();
                    break;

                case 1:
                    tbNombreEquipo.Enabled = true;
                    tbNombreEquipo.Focus();
                    tbProcesador.Enabled = false;
                    tbIp.Enabled = false;
                    break;
                case 2:
                    tbNombreEquipo.Enabled = false;
                    tbMarca.Focus();
                    break;
                case 3:
                    tbNombreEquipo.Enabled = false;
                    tbMarca.Focus();
                    tbProcesador.Enabled = false;
                    break;
                case 4:
                    tbNombreEquipo.Enabled = false;
                    tbMarca.Focus();
                    tbProcesador.Enabled = false;
                    break;
                case 5:
                    tbNombreEquipo.Enabled = true;
                    tbNombreEquipo.Focus();
                    tbProcesador.Enabled = false;
                    break;

            }
            /*
            if (superTabControl3.SelectedTabIndex == 0 || superTabControl3.SelectedTabIndex == 2 || superTabControl3.SelectedTabIndex == 3 || superTabControl3.SelectedTabIndex == 4)
            {
                tbNombreEquipo.Enabled = false;
                tbMarca.Focus();
            }
            else
            {
                tbNombreEquipo.Enabled = true;
                tbNombreEquipo.Focus();
            }
            */


        }

        private void rbNuevoAE_Click(object sender, EventArgs e)
        {

            cargarAnioCompra_softAE(cbAnioCompraNA);

            btRegistrarAE.Enabled = true;


            tbEliminarAE.Enabled = true;
            tbActualizarAE.Enabled = false;
            cbCatEq.Enabled = false;
            tbNroSerie.Enabled = true;

            tbMarca.Enabled = true;
            tbModelo.Enabled = true;
            tbProcesador.Enabled = true;
            tbNroControlPatrimonial.Enabled = true;
            cbEstadoEquipo.Enabled = true;
            tbNroOrdenCompra.Enabled = true;
            cbAnioCompra.Enabled = true;
            tbIp.Enabled = true;
            tbFuncionamiento.Enabled = true;
            tbObseracion.Enabled = true;

            cbEquipoPadreCod.Enabled = true;
            cbAsignado.Enabled = true;
            //tbNombreEquipo.Enabled = true;
            tbServiceTag.Enabled = true;
            dtFechaAsignacionAES.Enabled = true;
           
          
            

            limpiarRegistro();
            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }


            if (superTabControl3.SelectedTabIndex == 0 || superTabControl3.SelectedTabIndex == 2 || superTabControl3.SelectedTabIndex == 3 || superTabControl3.SelectedTabIndex == 4)
            {
                tbNombreEquipo.Enabled = false;
                tbMarca.Focus();
                cbCatEq.Enabled = false;
            }
            else
            {
                tbNombreEquipo.Enabled = true;
                tbNombreEquipo.Focus();
                cbCatEq.Enabled = true;
            }
            switch (superTabControl3.SelectedTabIndex)
            {
                case 0:
                    tbNombreEquipo.Enabled = false;
                    cbCatEq.Enabled = false;
                    tbMarca.Focus();
                    break;

                case 1:
                    tbNombreEquipo.Enabled = true;
                    tbNombreEquipo.Focus();
                    tbProcesador.Enabled = false;
                    tbIp.Enabled = false;
                    cbCatEq.Enabled = false;
                    break;
                case 2:
                    tbNombreEquipo.Enabled = false;
                    cbCatEq.Enabled = false;
                    tbMarca.Focus();
                    break;
                case 3:
                    tbNombreEquipo.Enabled = false;
                    tbMarca.Focus();
                    tbProcesador.Enabled = false;
                    cbCatEq.Enabled = false;
                    break;
                case 4:
                    tbNombreEquipo.Enabled = false;
                    tbMarca.Focus();
                    tbProcesador.Enabled = false;
                    cbCatEq.Enabled = false;
                    break;
                case 5:
                    tbNombreEquipo.Enabled = true;
                    tbProcesador.Enabled = true;
                    cbCatEq.Enabled = true;
                    tbNombreEquipo.Focus();

                    break;

            }
            DGVRegistro.Enabled = true;
            dtFechaAsignacionAES.Value = DateTime.Now;
          


        }
        ///ASIGNACION DE EQUIPO - TAB SOFTWARE

        int keyCodEquipoSoftware = 0;
        int keyCodEqSoft_softAE = 0;

        int keyCodSoft_softAE = 0;
        int keyCodEq_softAE = 0;


        private void DGVRegistro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rbNuevoAECCom.Checked = false;
            rbEditarAECCom.Checked = false;
            MessageBoxManager.Yes = "Sofware";

            MessageBoxManager.No = "Componente";
            MessageBoxManager.Register();

            DialogResult dr = MessageBox.Show("Elija que asignación desea hacer...", "ASIGNACION AL CPU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes://Asignacion de software
                    MessageBoxManager.Unregister();
                    stSoftware.Visible = true;
                    stComponente.Visible = false;
                    superTabControl2.SelectedTabIndex = 1;
                    //limpiar controles y deshabilitarlos
                    enableUnableAESoft(false);
                    limpiarSofwareAE();
                    foreach (DataGridViewRow row in DGVRegistro.Rows)
                    {
                        if (row.Index == e.RowIndex)
                        {
                            //keyRegistro = int.Parse(row.Cells[0].Value.ToString());
                            //keyRegistro_doc_entry_personal = int.Parse(row.Cells[1].Value.ToString());
                            keyCodEquipoSoftware = int.Parse(row.Cells[2].Value.ToString());
                            cargarEquipoSoftware(keyCodEquipoSoftware);
                            //listarSoftAE();
                            //obtenerSofware(keyRegistro);
                            listarSoftAE();

                            limpiarSofwareAE();
                            listarSoftAE();
                            rbNuevoSofAE.Checked = false;
                            rbEditarSofAE.Checked = false;

                        }
                    }
                    break;
                case DialogResult.No://Asignacion de componente
                    MessageBoxManager.Unregister();
                    stSoftware.Visible = false;
                    stComponente.Visible = true;
                    superTabControl2.SelectedTabIndex = 2;
                    //mostrar controles desabilitados y limpios
                    limpiarRegistroCCom();
                    enableUnenableComponentes(false);
                    cargarAnioCompraCCom();

                    foreach (DataGridViewRow row in DGVRegistro.Rows)
                    {
                        if (row.Index == e.RowIndex)
                        {
                            keyRegistro = int.Parse(row.Cells[0].Value.ToString());
                            // keyRegistro_doc_entry_personal = int.Parse(row.Cells[1].Value.ToString());
                            keyCodEquipoSoftware = int.Parse(row.Cells[2].Value.ToString());
                            cargarEquipoCComInf(keyCodEquipoSoftware);

                            /*CARGAR CATEGORIA*/
                            ModeloDatoDataContext db = new ModeloDatoDataContext();
                            int nroCat = (from T0 in db.Categorias select T0).Count();
                            if (nroCat != 0)
                            {
                                cargarCategoriasCCom();
                                cbCatEqCCom.SelectedIndex = 6;
                            }
                            //cargar codigo padre
                            cbEquipoPadreCodCCom.Text = Convert.ToString(keyCodEquipoSoftware);
                            if (tbCodEqCComInf.Text != string.Empty)
                            {
                                listarRegistroCCom(Convert.ToInt32(tbCodEqCComInf.Text));
                            }


                        }
                    }
                    break;
            }
            MessageBoxManager.Unregister();

            //


        }
        private void cargarEquipoSoftware(int keyCodEquipoSoftware)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql = from T0 in db.Equipos where T0.cod_equipo == keyCodEquipoSoftware select T0;

            Equipo objeto = clsTEqupipo.obtener(keyCodEquipoSoftware);
            tbCodEquipoSofAE.Text = Convert.ToString(objeto.cod_equipo);
            tbCatEqSoft.Text = objeto.Categoria.categoria;
            tbProcesadorSoft.Text = objeto.procesador;
            tbAnioCompraSoft.Text = Convert.ToString(objeto.anio_adquisicion);
            tbNroSerieSoft.Text = objeto.nro_serie;
            tbNroControlPatrimonialSoft.Text = objeto.nro_control_patrimonial;
            tbIpSoft.Text = objeto.ip_equipo;
            tbMarcaSoft.Text = objeto.marca;
            cbEstadoEquipoSoft.Text = objeto.estado;
            tbFuncionamientoSoft.Text = objeto.funcionamiento;
            tbModeloSoft.Text = objeto.modelo;
            tbNroOrdenCompraSoft.Text = objeto.nro_orden_compra;
            tbObseracionSoft.Text = objeto.observacion;




        }

        private void tbModeloSoft_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAnioCompraSoftAE_Click(object sender, EventArgs e)
        {
            cargarAnioCompra_softAE(cbAnioCompra);

        }

        private void tbAnioCompraSoftAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese un Año", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void btListaSoftAE_Click(object sender, EventArgs e)
        {
            listarSoftAE();
            rbNuevoSofAE.Checked = false;
            rbEditarSofAE.Checked = false;
            desableFormAS();

        }
        private void desableFormAS()
        {
            cbSoftware_SoftAE.Enabled = false;
            cbAnioCompraSoftAE.Enabled = false;
            tbVersionSoftAE.Enabled = false;
            tbCantidadUsSoftAE.Enabled = false;
            tbOCSoftAE.Enabled = false;
            cbAnioCompraSoftAE.Enabled = false;
            tbObsvSoftAE.Enabled = false;
            cbActivoSoftAE.Enabled = false;
            dtFechaInstalacionSoftAE.Enabled = false;
            dtFechaCaducidadSoftAE.Enabled = false;


        }
        private void enableFormAS()
        {
            cbSoftware_SoftAE.Enabled = true;
            cbAnioCompraSoftAE.Enabled = true;
            tbVersionSoftAE.Enabled = true;
            tbCantidadUsSoftAE.Enabled = true;
            tbOCSoftAE.Enabled = true;
            cbAnioCompraSoftAE.Enabled = true;
            tbObsvSoftAE.Enabled = true;
            cbActivoSoftAE.Enabled = true;
            dtFechaInstalacionSoftAE.Enabled = true;
            dtFechaCaducidadSoftAE.Enabled = true;


        }
        private void listarSoftAE()
        {
            if (tbCodEquipoSofAE.Text != String.Empty)
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                var sql = (from T0 in db.Equipo_softwares
                           join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                           where T0.cod_equipo == Convert.ToInt32(tbCodEquipoSofAE.Text)
                           select new
                           {
                               cod_equipo_software = T0.cod_equipo_software,
                               cod_software = T0.cod_software,
                               cod_equipo = T0.cod_equipo,
                               software = T1.software,
                               fecha_instalacion = T0.fecha_instalacion,
                               fecha_caducidad = T0.fecha_caducidad,
                               observacion = T0.observacion,
                           }
                 ).ToList();

                DGVSoftware_SodtAE.AutoGenerateColumns = false;
                DGVSoftware_SodtAE.DataSource = sql;
                //DGVSoftwareAE.DataSource = clsTSoftware.listar();

            }


        }

        private void btGrabarSoftAE_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                Software objSoft = new Software();

                int reg_soft = (from T0 in db.Softwares where T0.software == cbSoftware_SoftAE.Text select T0.cod_software).Count();


                if (reg_soft > 0) // se esta asignando un sofware existente
                {

                    int reg_sofAE = (from T0 in db.Equipo_softwares where T0.cod_equipo == keyCodEquipoSoftware && T0.cod_software == Convert.ToInt32(cbSoftware_SoftAE.SelectedValue) select T0.cod_software).Count();
                    if (reg_sofAE > 0)//si el software ya esta asignado
                    {
                        MessageBox.Show("El software ya esta asignado al equipo");
                    }
                    else//el software existe y no esta asignado
                    {
                        if (cbSoftware_SoftAE.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese el nombre del software");
                        }
                        else
                        {
                            if (cbAnioCompraSoftAE.Text == string.Empty)
                            {
                                MessageBox.Show("Ingrese el año de compra");
                            }
                            else
                            {

                                //registrar la asignacion de soft a un equipo
                                Equipo_software eq_soft = new Equipo_software();
                                CTEquipo_software _clsEqSoft = new CTEquipo_software();

                                var sql2 = (from T0 in db.Softwares where T0.software == cbSoftware_SoftAE.Text select T0.cod_software).ToList();

                                eq_soft.cod_software = sql2[0]; // Convert.ToInt32(cbSoftware_SoftAE.SelectedValue);
                                eq_soft.cod_equipo = keyCodEquipoSoftware;
                                eq_soft.fecha_instalacion = dtFechaInstalacionSoftAE.Value.Date.ToShortDateString();
                                eq_soft.fecha_caducidad = dtFechaCaducidadSoftAE.Value.ToShortDateString();
                                eq_soft.observacion = tbObsvSoftAE.Text;


                                DialogResult dr = MessageBox.Show("Desea Crear?", "Alerta...", MessageBoxButtons.YesNo);
                                switch (dr)
                                {
                                    case DialogResult.Yes:

                                        _clsEqSoft.registrar(eq_soft);
                                        MessageBox.Show("Registro realizado");
                                        limpiarSofwareAE();
                                        listarSoftAE();
                                        cbSoftware_SoftAE.Focus();
                                        break;
                                    case DialogResult.No:
                                        break;
                                }


                            }

                        }
                    }

                }
                else // se esta asignando un sofware no existente
                {
                    if (cbSoftware_SoftAE.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el nombre del software");
                    }
                    else
                    {
                        if (cbAnioCompraSoftAE.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese el año de compra");
                        }
                        else
                        {



                            objSoft.software = cbSoftware_SoftAE.Text; //tbnombreSoftAE.Text;
                            objSoft.version = tbVersionSoftAE.Text;

                            if (tbCantidadUsSoftAE.Text != string.Empty)
                            {
                                objSoft.cantidad_usuarios = Convert.ToInt32(tbCantidadUsSoftAE.Text);
                            }
                            else
                            {
                                objSoft.cantidad_usuarios = 0;
                            }
                            CTSoftware _clsTSoftware = new CTSoftware();
                            objSoft.nro_orden_compra = tbOCSoftAE.Text;
                            objSoft.anio_aquisicion = cbAnioCompraSoftAE.Text;
                            objSoft.observacion = tbObsvSoftAE.Text;
                            objSoft.activo = Convert.ToString(cbActivoSoftAE.SelectedItem);
                            _clsTSoftware.registrar(objSoft);




                            //registrar la asignacion de soft a un equipo
                            Equipo_software eq_soft = new Equipo_software();

                            var sql2 = (from T0 in db.Softwares where T0.software == cbSoftware_SoftAE.Text select T0.cod_software).ToList();

                            eq_soft.cod_software = sql2[0];
                            eq_soft.cod_equipo = keyCodEquipoSoftware;
                            eq_soft.fecha_instalacion = dtFechaInstalacionSoftAE.Value.Date.ToShortDateString();
                            eq_soft.fecha_caducidad = dtFechaCaducidadSoftAE.Value.ToShortDateString();
                            eq_soft.observacion = tbObsvSoftAE.Text;

                            DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                    CTEquipo_software _clsEqSoft = new CTEquipo_software();
                                    _clsEqSoft.registrar(eq_soft);
                                    MessageBox.Show("Registro realizado");
                                    limpiarSofwareAE();
                                    listarSoftAE();
                                    cbSoftware_SoftAE.Focus();

                                    break;
                                case DialogResult.No:
                                    break;
                            }





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

        private void tbCantidadUsSoftAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void rbNuevoSofAE_Click(object sender, EventArgs e)
        {

            btGrabarSoftAE.Enabled = true;
            btActualizarSoftAE.Enabled = false;
            btEliminarSoftAE.Enabled = true;

            tbnombreSoftAE.Enabled = true;
            tbVersionSoftAE.Enabled = true;
            tbCantidadUsSoftAE.Enabled = true;
            tbOCSoftAE.Enabled = true;
            cbAnioCompraSoftAE.Enabled = true;
            tbObsvSoftAE.Enabled = true;
            cbActivoSoftAE.Enabled = true;
            dtFechaInstalacionSoftAE.Enabled = true;
            dtFechaCaducidadSoftAE.Enabled = true;
            cbSoftware_SoftAE.Enabled = true;
            limpiarSofwareAE();
            listarSoftAE();


        }
        private void enableUnableAESoft(bool parm)
        {
            btGrabarSoftAE.Enabled = parm;
            btActualizarSoftAE.Enabled = parm;
            btEliminarSoftAE.Enabled = parm;

            tbnombreSoftAE.Enabled = parm;
            tbVersionSoftAE.Enabled = parm;
            tbCantidadUsSoftAE.Enabled = parm;
            tbOCSoftAE.Enabled = parm;
            cbAnioCompraSoftAE.Enabled = parm;
            tbObsvSoftAE.Enabled = parm;
            cbActivoSoftAE.Enabled = parm;
            dtFechaInstalacionSoftAE.Enabled = parm;
            dtFechaCaducidadSoftAE.Enabled = parm;
            cbSoftware_SoftAE.Enabled = parm;
         
 
        }

        private void rbEditarSofAE_Click(object sender, EventArgs e)
        {
            btGrabarSoftAE.Enabled = false;
            btActualizarSoftAE.Enabled = true;
            btEliminarSoftAE.Enabled = true;

            tbnombreSoftAE.Enabled = true;
            tbVersionSoftAE.Enabled = true;
            tbCantidadUsSoftAE.Enabled = true;
            tbOCSoftAE.Enabled = true;
            cbAnioCompraSoftAE.Enabled = true;
            tbObsvSoftAE.Enabled = true;
            cbActivoSoftAE.Enabled = true;
            dtFechaInstalacionSoftAE.Enabled = true;
            dtFechaCaducidadSoftAE.Enabled = true;
            cbSoftware_SoftAE.Enabled = false;
            listarSoftAE();

        }

        private void DGVSoftwareAE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVSoftware_SodtAE.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    cargarAnioCompra_softAE(cbAnioCompra);
                    keyCodEqSoft_softAE = int.Parse(row.Cells[0].Value.ToString());
                    keyCodSoft_softAE = int.Parse(row.Cells[1].Value.ToString());
                    keyCodEq_softAE = int.Parse(row.Cells[2].Value.ToString());
                    obtenerEqSoft_softAE(keyCodEqSoft_softAE);


                }
            }
        }
        private void cargarAnioCompra_softAE( ComboBox cb)
        {
            cb.DataSource = null;
            cb.Items.Clear();
            cb.Items.Add("S/A");
            int aActual = DateTime.Now.Year;


            for (int anio = 1999; anio <= aActual; anio++)
            {
                cb.Items.Add(Convert.ToString(anio));
            }
            cb.SelectedIndex = 0;

        }
        private void obtenerEqSoft_softAE(int keyCodEqSoft_softAE)
        {

            Equipo_software objeto = clsEqSoft.obtener(keyCodEqSoft_softAE);

            dtFechaInstalacionSoftAE.Text = objeto.fecha_instalacion;
            dtFechaCaducidadSoftAE.Text = objeto.fecha_caducidad;
            tbObsvSoftAE.Text = objeto.observacion;


            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var sql3 = (from T0 in db.Equipo_softwares
                        join T1 in db.Softwares on T0.cod_software equals T1.cod_software
                        where T0.cod_equipo_software == keyCodEqSoft_softAE

                        select new
                        {
                            _tbnombreSoftAE = T1.software,
                            _tbVersionSoftAE = T1.version,
                            _tbCantidadUsSoftAE = T1.cantidad_usuarios,
                            _tbOCSoftAE = T1.nro_orden_compra,
                            _cbAnioCompraSoftAE = T1.anio_aquisicion,
                            _tbObsvSoftAE = T0.observacion,
                            _cbActivoSoftAE = T1.activo,

                        }).ToList();

            cbSoftware_SoftAE.Text = sql3[0]._tbnombreSoftAE;
            tbVersionSoftAE.Text = sql3[0]._tbVersionSoftAE;
            tbCantidadUsSoftAE.Text = Convert.ToString(sql3[0]._tbCantidadUsSoftAE);
            tbOCSoftAE.Text = sql3[0]._tbOCSoftAE;
            cbAnioCompraSoftAE.Text = sql3[0]._cbAnioCompraSoftAE;
            tbObsvSoftAE.Text = sql3[0]._tbObsvSoftAE;
            cbActivoSoftAE.Text = sql3[0]._cbActivoSoftAE;




        }

        private void btActualizarSoftAE_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbMarcaSoft.Text == string.Empty && tbNroSerieSoft.Text == string.Empty)
                {
                    MessageBox.Show("Selecione un registro de la lista");
                }
                else
                {
                    if (keyCodSoft_softAE != 0 & keyCodEq_softAE != 0)
                    {
                        //verificar si el soft est aasignado
                        ModeloDatoDataContext db = new ModeloDatoDataContext();

                        //si quiero actualizar otros datos que no sea cambio de equipo                    
                        //si el codigo del equipo en el cb es igual al del registro
                        int reg_equiposoft = (from T0 in db.Equipo_softwares where T0.cod_equipo_software == keyCodEqSoft_softAE && T0.cod_software == keyCodSoft_softAE select T0).Count();
                        if (reg_equiposoft > 0)//se puede actualizar otros datos que no son cambio de software
                        {
                            //actualizar software
                            Software objeto = new Software();
                            objeto.cod_software = keyCodSoft_softAE;
                            objeto.software = cbSoftware_SoftAE.Text;
                            objeto.version = tbVersionSoftAE.Text;
                            objeto.cantidad_usuarios = Convert.ToInt32(tbCantidadUsSoftAE.Text);
                            objeto.nro_orden_compra = tbOCSoftAE.Text;
                            objeto.anio_aquisicion = cbAnioCompraSoftAE.Text;
                            objeto.observacion = tbObsvSoftAE.Text;
                            objeto.activo = cbActivoSoftAE.Text;
                            //objEquipo.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCod.SelectedValue);

                            //  limpiar();
                            // MessageBox.Show("Registro actualizado");
                            // listar();


                            //actualizar equiposoftware

                            Equipo_software obj = new Equipo_software();

                            obj.cod_equipo_software = keyCodEqSoft_softAE;
                            obj.cod_equipo = keyCodEq_softAE;
                            obj.cod_software = keyCodSoft_softAE;
                            obj.fecha_instalacion = dtFechaInstalacionSoftAE.Value.Date.ToShortDateString();
                            obj.fecha_caducidad = dtFechaCaducidadSoftAE.Value.ToShortDateString();
                            obj.observacion = tbObsvSoftAE.Text;



                            DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                    CTSoftware _clsTSoftware = new CTSoftware();
                                    CTEquipo_software _clsEqSoft = new CTEquipo_software();
                                    _clsTSoftware.actualizar(objeto);
                                    _clsEqSoft.actualizar(obj);
                                    //limpiarRegistro();
                                    MessageBox.Show("Registro Actualizado");
                                    listarSoftAE();

                                    limpiarSofwareAE();
                                    cbSoftware_SoftAE.Focus();

                                    break;
                                case DialogResult.No:
                                    break;
                            }


                        }
                        else
                        {
                            MessageBox.Show("Selecione un registro de la lista");
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

        private void btEliminarSoftAE_Click(object sender, EventArgs e)
        {
            /*
                    keyCodEqSoft_softAE = int.Parse(row.Cells[0].Value.ToString());
                    keyCodSoft_softAE = int.Parse(row.Cells[1].Value.ToString());
                    keyCodEq_softAE = int.Parse(row.Cells[2].Value.ToString());
             */
            try
            {

                if (keyCodEqSoft_softAE != 0 && keyCodSoft_softAE != 0 && keyCodEq_softAE != 0)
                {


                    DialogResult dr = MessageBox.Show("Desea Eliminar?", "Alerta...", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            clsEqSoft.eliminar(keyCodEqSoft_softAE);
                            //clsTSoftware.eliminar(keyCodSoft_softAE);


                            MessageBox.Show("registro eliminado");


                            limpiarSofwareAE();
                            listarSoftAE();
                            cbSoftware_SoftAE.Focus();

                            break;
                        case DialogResult.No:
                            break;
                    }



                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }
        }
        private void limpiarSofwareAE()
        {
            cbSoftware_SoftAE.DataSource = null;
            cbSoftware_SoftAE.Items.Clear();
            cbSoftware_SoftAE.Text = String.Empty;
            tbVersionSoftAE.Text = String.Empty;
            tbCantidadUsSoftAE.Text = String.Empty;
            tbOCSoftAE.Text = String.Empty;
            cbAnioCompraSoftAE.SelectedIndex = -1;
            tbObsvSoftAE.Text = String.Empty;
            cbActivoSoftAE.SelectedIndex = -1;
            dtFechaInstalacionSoftAE.Text = String.Empty;
            dtFechaCaducidadSoftAE.Text = String.Empty;
            DGVSoftware_SodtAE.DataSource = null;

        }

        private void btLimpiarSoftAE_Click(object sender, EventArgs e)
        {
            limpiarSofwareAE();
        }

        private void btCerrarSoftAE_Click(object sender, EventArgs e)
        {
            Close();
        }




        #endregion
        /**************************************
        *                                     *
        *   CODIGO DE ASIGNACION DE SOFTWARE  * 
        *                                     *
        **************************************/
        #region

        CTEquipo_software clsEqSoft = new CTEquipo_software();
        int keyCodEqSoft = 0;


        private void btListarAS_Click(object sender, EventArgs e)
        {
            listarEqSoft();
        }

        private void btRegistrarAS_Click(object sender, EventArgs e)
        {
            try
            {


                if (cbCodSoftAS.Text != string.Empty && cbCodEquipoAS.Text != string.Empty)
                {
                    Equipo_software eq_soft = new Equipo_software();
                    ModeloDatoDataContext db = new ModeloDatoDataContext();
                    int nro = Convert.ToInt32((from s in db.Equipo_softwares where s.cod_equipo == Convert.ToInt32(cbCodEquipoAS.SelectedValue) && s.cod_software == Convert.ToInt32(cbCodSoftAS.SelectedValue) select s).Count().ToString());
                    if (nro == 0)
                    {
                        eq_soft.fecha_instalacion = dtFechaInstalacionAS.Value.Date.ToShortDateString();
                        eq_soft.fecha_caducidad = dtFechaCaducidadAS.Value.ToShortDateString();
                        eq_soft.observacion = tbObseracion.Text;
                        eq_soft.cod_software = Convert.ToInt32(cbCodSoftAS.SelectedValue);
                        eq_soft.cod_equipo = Convert.ToInt32(cbCodEquipoAS.SelectedValue);

                        clsEqSoft.registrar(eq_soft);
                        limpiarEqSoft();
                        MessageBox.Show("Registro realizado");
                        listarEqSoft();

                    }
                    else

                    { MessageBox.Show("El registro ya existe"); }
                }
                else { MessageBox.Show("Ingrese un Registro Valido"); }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }

        private void btLimpiarAS_Click(object sender, EventArgs e)
        {
            limpiarEqSoft();
        }

        private void btActualizarAS_Click(object sender, EventArgs e)
        {
            try
            {


                if (keyCodEqSoft != 0 && cbCodSoftAS.Text != string.Empty && cbCodEquipoAS.Text != string.Empty)
                {

                    ModeloDatoDataContext db = new ModeloDatoDataContext();

                    Equipo_software obj = new Equipo_software();
                    obj.cod_equipo_software = keyCodEqSoft;
                    obj.cod_equipo = Convert.ToInt32(cbCodEquipoAS.SelectedValue);
                    obj.cod_software = Convert.ToInt32(cbCodSoftAS.SelectedValue);
                    obj.observacion = tbObservacionAS.Text;
                    obj.fecha_caducidad = dtFechaCaducidadAS.Value.Date.ToShortDateString();
                    obj.fecha_instalacion = dtFechaInstalacionAS.Value.Date.ToShortDateString();
                    clsEqSoft.actualizar(obj);
                    limpiarEqSoft();
                    MessageBox.Show("Registro Actualizado");
                    listarEqSoft();



                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la lista");
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }


        }

        private void btEliminarAS_Click(object sender, EventArgs e)
        {
            try
            {
                if (keyCodEqSoft != 0 && Convert.ToInt32(cbCodSoftAS.SelectedValue) > 0)
                {
                    clsEqSoft.eliminar(keyCodEqSoft);
                    limpiarEqSoft();
                    MessageBox.Show("registro eliminado");
                    listarEqSoft();
                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");
                }


            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

        }
        private void DGVAsignacionSoft_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGVAsignacionSoft.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    keyCodEqSoft = int.Parse(row.Cells[0].Value.ToString());
                    obtenerEqSoft(keyCodEqSoft);

                }
            }


        }
        private void limpiarEqSoft()
        {
            dtFechaInstalacionAS.Text = string.Empty;
            dtFechaCaducidadAS.Text = string.Empty;
            tbObservacionAS.Text = string.Empty;
            cbCodSoftAS.SelectedIndex = -1;
            cbCodEquipoAS.SelectedIndex = -1;
            textBoxX9.Text = string.Empty;
            textBoxX8.Text = string.Empty;
            textBoxX5.Text = string.Empty;
            textBoxX4.Text = string.Empty;
            textBoxX3.Text = string.Empty;
            textBoxX2.Text = string.Empty;
            textBoxX1.Text = string.Empty;
        }
        private void listarEqSoft()
        {
            DGVAsignacionSoft.AutoGenerateColumns = false;

            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var sql = (from es in db.Equipo_softwares
                       join eq in db.Equipos on es.cod_equipo equals eq.cod_equipo
                       join soft in db.Softwares on es.cod_software equals soft.cod_software

                       select new
                       {

                           codSofEq = es.cod_equipo_software,
                           codEqAS = eq.cod_equipo,
                           cod_software = soft.cod_software,
                           software = soft.software,
                           nomEquipoAS = "EQUIPO: " + eq.equipo + " | SERIE: " + eq.nro_serie + " | CPATRIMONIAL: " + eq.nro_control_patrimonial,
                           finstalacion = es.fecha_instalacion,
                           fcaducidad = es.fecha_caducidad,
                           observ = es.observacion,
                       }).ToList();

            DGVAsignacionSoft.DataSource = sql;
        }


        //personal
        private void cargarSoftwareAS()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from sof in dc.Softwares

                      select new
                      {
                          id = sof.cod_software,
                          concatenado = sof.software,
                      }).ToList();


            cbCodSoftAS.DataSource = sq;
            cbCodSoftAS.ValueMember = "id";
            cbCodSoftAS.DisplayMember = "concatenado";
        }

        //sede
        private void cargarEquipoAS()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var sq = (from eq in dc.Equipos

                      select new
                      {
                          id = eq.cod_equipo,
                          concatenado = eq.nro_serie + " - " + eq.equipo,
                      }).ToList();


            cbCodEquipoAS.DataSource = sq;
            cbCodEquipoAS.ValueMember = "id";
            cbCodEquipoAS.DisplayMember = "concatenado";
        }

        private void obtenerEqSoft(int keyCodEqSoft)
        {
            Equipo_software objeto = clsEqSoft.obtener(keyCodEqSoft);
            dtFechaInstalacionAS.Text = objeto.fecha_instalacion;
            dtFechaCaducidadAS.Text = objeto.fecha_caducidad;
            tbObservacionAS.Text = objeto.observacion;

            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var sql = (from es in db.Equipo_softwares
                       join eq in db.Equipos on es.cod_equipo equals eq.cod_equipo
                       join soft in db.Softwares on es.cod_software equals soft.cod_software
                       where es.cod_equipo_software == keyCodEqSoft

                       select new
                       {
                           cod_equipo = es.cod_equipo,
                           cod_software = es.cod_software,

                           software = soft.software + " | " + Convert.ToString(soft.version),

                           nombre_equipo = eq.equipo + " | " + eq.marca + " | " + eq.modelo + " | " + eq.nro_serie + " | " + eq.nro_control_patrimonial,
                           fecha_instalacion = es.fecha_instalacion,
                           fecha_caducidad = es.fecha_caducidad,
                           observacion = es.observacion,
                       }).ToList();


            //--ds cbCodSoftAS-

            cbCodSoftAS.DataSource = sql;
            cbCodSoftAS.ValueMember = "cod_software";
            cbCodSoftAS.DisplayMember = "software";

            //--ds cbCodEquipoAS
            cbCodEquipoAS.DataSource = sql;
            cbCodEquipoAS.ValueMember = "cod_equipo";
            cbCodEquipoAS.DisplayMember = "nombre_equipo";

            String source = Convert.ToString(sql[0].software); //Original Text
            String[] result = source.Split('|');
            textBoxX9.Text = Convert.ToString(result[0]);
            textBoxX8.Text = Convert.ToString(result[1]);


            String source2 = Convert.ToString(sql[0].nombre_equipo); ; //Original Text
            String[] result2 = source2.Split('|');
            textBoxX5.Text = Convert.ToString(result2[0]);
            textBoxX4.Text = Convert.ToString(result2[1]);
            textBoxX3.Text = Convert.ToString(result2[2]);
            textBoxX2.Text = Convert.ToString(result2[3]);
            textBoxX1.Text = Convert.ToString(result2[4]);



        }

        private void cbCodSoftAS_MouseClick(object sender, MouseEventArgs e)
        {
            cargarSoftwareAS();
        }

        private void cbCodEquipoAS_MouseClick(object sender, MouseEventArgs e)
        {
            cargarEquipoAS();
        }


        private void tbBuscarEquipo_KeyDown(object sender, KeyEventArgs e)
        {
            setFilterInformation(tbBuscarEquipo.Text);
        }

        private void tbAsignacionSoft_TextChanged(object sender, EventArgs e)
        {
            buscaAsignacionSof();
        }
        private void buscaAsignacionSof()
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            if (tbAsignacionSoft.Text != string.Empty)
            {


                var sql = (from es in db.Equipo_softwares
                           join eq in db.Equipos on es.cod_equipo equals eq.cod_equipo
                           join soft in db.Softwares on es.cod_software equals soft.cod_software
                           where soft.software.Contains(tbAsignacionSoft.Text) ||
                                 eq.nro_serie.Contains(tbAsignacionSoft.Text) ||
                                 eq.equipo.Contains(tbAsignacionSoft.Text) ||
                                 eq.ip_equipo.Contains(tbAsignacionSoft.Text) ||
                                 eq.marca.Contains(tbAsignacionSoft.Text) ||
                                 eq.modelo.Contains(tbAsignacionSoft.Text) ||
                                 eq.procesador.Contains(tbAsignacionSoft.Text) ||
                                 eq.nro_control_patrimonial.Contains(tbAsignacionSoft.Text) ||
                                 eq.anio_adquisicion.Contains(tbAsignacionSoft.Text) ||
                                 eq.nro_orden_compra.Contains(tbAsignacionSoft.Text) ||
                                 eq.observacion.Contains(tbAsignacionSoft.Text) ||
                                 eq.marca.Contains(tbAsignacionSoft.Text) ||
                                 es.fecha_instalacion.Contains(tbAsignacionSoft.Text) ||
                                 es.fecha_caducidad.Contains(tbAsignacionSoft.Text) ||
                                 es.observacion.Contains(tbAsignacionSoft.Text)

                           select new
                           {

                               codSofEq = es.cod_equipo_software,
                               codEqAS = eq.cod_equipo,
                               cod_software = soft.cod_software,
                               software = soft.software,
                               nomEquipoAS = "SERIE: " + eq.nro_serie + ",  " + eq.equipo,
                               finstalacion = es.fecha_instalacion,
                               fcaducidad = es.fecha_caducidad,
                               observ = es.observacion,
                           }).ToList();

                DGVAsignacionSoft.DataSource = sql;


            }
            else
            {
                listarEqSoft();
            }
        }

        private void tabEquipoVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            switch (tabEquipoVar.SelectedIndex)
            {
                case 0:
                    tabEquipoDGV.SelectedIndex = 0;
                    break;
                case 1:
                    tabEquipoDGV.SelectedIndex = 1;
                    break;
               
               
            }
             * */
        }

        private void tabEquipoDGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            switch (tabEquipoDGV.SelectedIndex)
            {
                case 0:
                    tabEquipoVar.SelectedIndex = 0;
                    break;
                case 1:
                    tabEquipoVar.SelectedIndex = 1;
                    break;


            }
             * */
        }


        private void tcListaSedeInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* switch (tcListaSedeInst.SelectedIndex)
             {
                 case 0:
                     tcSedeInst.SelectedIndex = 0;
                     break;
                 case 1:
                     tcSedeInst.SelectedIndex = 1;
                     break;


             }*/
        }

        private void tcSedeInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*switch (tcSedeInst.SelectedIndex)
            {
                case 0:
                    tcListaSedeInst.SelectedIndex = 0;
                    break;
                case 1:
                    tcListaSedeInst.SelectedIndex = 1;
                    break;


            }*/
        }

        private void tcPersonaperfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* switch (tcPersonaperfil.SelectedIndex)
             {
                 case 0:
                     tcListaPersonaPerfil.SelectedIndex = 0;
                     break;
                 case 1:
                     tcListaPersonaPerfil.SelectedIndex = 1;
                     break;


             }*/
        }

        private void tcListaPersonaPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*switch (tcListaPersonaPerfil.SelectedIndex)
            {
                case 0:
                    tcPersonaperfil.SelectedIndex = 0;
                    break;
                case 1:
                    tcPersonaperfil.SelectedIndex = 1;
                    break;


            }
             * */
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btListarSoft_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            //tabControlPrincipal.SelectedIndex = 0;
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            superTabControl1.SelectedTabIndex = 1;
            //tabControlPrincipal.SelectedIndex = 1;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            sideNav1.TabIndex = 2;
            //tabControlPrincipal.SelectedIndex = 3;
        }


        private void buttonX4_Click(object sender, EventArgs e)
        {
            //tabControlPrincipal.SelectedIndex = 4;
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            // tabControlPrincipal.SelectedIndex = 5;
        }

        ReportDataSource rs = new ReportDataSource();

        private void btImpSoft_Click(object sender, EventArgs e)
        {
            List<ImpresionSoft> lst = new List<ImpresionSoft>();
            lst.Clear();
            for (int i = 0; i < DGVSoftware.Rows.Count; i++)
            {
                lst.Add(new ImpresionSoft
                {
                    cod_software = Convert.ToString(DGVSoftware.Rows[i].Cells[0].Value),
                    software = Convert.ToString(DGVSoftware.Rows[i].Cells[1].Value),
                    version = Convert.ToString(DGVSoftware.Rows[i].Cells[2].Value),
                    cantidad_usuarios = Convert.ToString(DGVSoftware.Rows[i].Cells[3].Value),
                    nro_orden_compra = Convert.ToString(DGVSoftware.Rows[i].Cells[4].Value),
                    anio_aquisicion = Convert.ToString(DGVSoftware.Rows[i].Cells[5].Value),
                    activo = Convert.ToString(DGVSoftware.Rows[i].Cells[6].Value),
                    observacion = Convert.ToString(DGVSoftware.Rows[i].Cells[7].Value)
                });
            }

            rs.Name = "DataSet3";
            rs.Value = lst;
            FormSoftRep frm = new FormSoftRep();

            frm.RVSoftware.LocalReport.DataSources.Clear();
            frm.RVSoftware.LocalReport.DataSources.Add(rs);
            frm.RVSoftware.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report3Soft.rdlc";
            //frm.rvAsignacionSof.LocalReport.Refresh();


            frm.ShowDialog();



        }
        public class ImpresionSoft
        {
            public string cod_software { get; set; }
            public string software { get; set; }
            public string version { get; set; }
            public string cantidad_usuarios { get; set; }
            public string nro_orden_compra { get; set; }
            public string anio_aquisicion { get; set; }
            public string activo { get; set; }
            public string observacion { get; set; }

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Asignacion_equipo frm = new Asignacion_equipo();
            frm.Show();
           
        }
        public void generarActaEntrega()
        {

            {



                ModeloDatoDataContext db = new ModeloDatoDataContext();
                System.Windows.Forms.DataGridView dg = new System.Windows.Forms.DataGridView();
                Controls.Add(dg);
                List<ActaEnrega> lst = new List<ActaEnrega>();

                //listarPersonal();
                var sqlDNI = (from T0 in db.Personals
                              where T0.dni == tbDniAE.Text
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
                                          nombre_instancia = tbInstancAE.Text,
                                          c_sede = T2.c_sede,
                                          nombre_sede = tbSedeAE.Text,
                                          perfil = tbPerfilAE.Text,
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
                            ActaEnrega act = new ActaEnrega();

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
                                    ActaEnrega componente = new ActaEnrega();

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
        }

        private void btnConstAsg_Click(object sender, EventArgs e)
        {
            Form10ActaEntrega frm = new Form10ActaEntrega();
            frm.tbDniAE=tbDniAE.Text;
            frm.tbInstancAE = tbInstancAE.Text;
            frm.tbSedeAE = tbSedeAE.Text;
            frm.tbPerfilAE = tbPerfilAE.Text;
            frm.ShowDialog();

        }
        public class ActaEnrega {
            //equipo
            public string fechaRegUser{ get; set; }
            public string fechaRegSist { get; set; }
            public string cod_equipo { get; set; }
            public string equipo { get; set; }
            public string ip_equipo { get; set; }
            public string marca { get; set; }
            public string modelo { get; set; }
            public string procesador { get; set; }
            public string nro_serie { get; set; }
            public string nro_control_patrimonial { get; set; }
            public string anio_adquisicion { get; set; }
            public string nro_orden_compra { get; set; }
            public string observacion { get; set; }
            public string activo { get; set; }
            public string cod_categoria { get; set; }
            public string equipoPadreCod { get; set; }
            public string estadoEquipo { get; set; }
            //persona
            public string doc_entry_personal { get; set; }
            public string c_usuario { get; set; }
            public string c_nombres { get; set; }
            public string c_ape_paterno { get; set; }
            public string c_ape_materno { get; set; }
            public string nombre { get; set; }
            public string fecha_ingreso { get; set; }
          
            public string c_perfil { get; set; }
          
            public string dni { get; set; }
           
            public string nombre_instancia { get; set; }
            public string c_sede { get; set; }
            public string nombre_sede { get; set; }
            public string perfil { get; set; }
            public string estado { get; set; }
            public string escalafon { get; set; }
            public string unidad_organica { get; set; }
            public string area { get; set; }
            public string tipo_personal { get; set; }
            public string fecha_ingreso_lab { get; set; }
        
        }

        private void btReporteSoft_Click(object sender, EventArgs e)
        {
            Asignacion_soft form = new Asignacion_soft();
            form.Show();

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void btImpEquipo_Click(object sender, EventArgs e)
        {
            List<ImpresionEquipo> lst = new List<ImpresionEquipo>();
            lst.Clear();

            for (int i = 0; i < dgvEquipo.Rows.Count; i++)
            {
                lst.Add(new ImpresionEquipo
                {
                    cod_equipo = Convert.ToString(dgvEquipo.Rows[i].Cells[0].Value),
                    equipo = Convert.ToString(dgvEquipo.Rows[i].Cells[1].Value),
                    ip_equipo = Convert.ToString(dgvEquipo.Rows[i].Cells[2].Value),
                    marca = Convert.ToString(dgvEquipo.Rows[i].Cells[3].Value),
                    modelo = Convert.ToString(dgvEquipo.Rows[i].Cells[4].Value),
                    procesador = Convert.ToString(dgvEquipo.Rows[i].Cells[5].Value),
                    nro_serie = Convert.ToString(dgvEquipo.Rows[i].Cells[6].Value),
                    nro_control_patrimonial = Convert.ToString(dgvEquipo.Rows[i].Cells[7].Value),
                    anio_adquisicion = Convert.ToString(dgvEquipo.Rows[i].Cells[8].Value),
                    nro_orden_compra = Convert.ToString(dgvEquipo.Rows[i].Cells[9].Value),
                    observacion = Convert.ToString(dgvEquipo.Rows[i].Cells[10].Value),
                    activo = Convert.ToString(dgvEquipo.Rows[i].Cells[11].Value),
                    cod_categoria = Convert.ToString(dgvEquipo.Rows[i].Cells[12].Value),
                    equipoPadreCod = Convert.ToString(dgvEquipo.Rows[i].Cells[13].Value),
                    estadoEquipo = Convert.ToString(dgvEquipo.Rows[i].Cells[14].Value),


                });
            }

            rs.Name = "DataSet4";
            rs.Value = lst;
            FormEquipoRep frm = new FormEquipoRep();

            frm.RVEquipoRep.LocalReport.DataSources.Clear();
            frm.RVEquipoRep.LocalReport.DataSources.Add(rs);
            frm.RVEquipoRep.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report4Equipo.rdlc";
            frm.ShowDialog();

        }
        public class ImpresionEquipo
        {
            public string cod_equipo { get; set; }
            public string equipo { get; set; }
            public string ip_equipo { get; set; }
            public string marca { get; set; }
            public string modelo { get; set; }
            public string procesador { get; set; }
            public string nro_serie { get; set; }
            public string nro_control_patrimonial { get; set; }
            public string anio_adquisicion { get; set; }
            public string nro_orden_compra { get; set; }
            public string observacion { get; set; }
            public string activo { get; set; }
            public string cod_categoria { get; set; }
            public string equipoPadreCod { get; set; }
            public string estadoEquipo { get; set; }

        }

        private void btImpCat_Click(object sender, EventArgs e)
        {
            List<ImpresionCategoria> lst = new List<ImpresionCategoria>();
            lst.Clear();

            for (int i = 0; i < DGVCategoria.Rows.Count; i++)
            {
                lst.Add(new ImpresionCategoria
                {
                    cod_categoria = Convert.ToString(DGVCategoria.Rows[i].Cells[0].Value),
                    categoria = Convert.ToString(DGVCategoria.Rows[i].Cells[1].Value),
                    observacion = Convert.ToString(DGVCategoria.Rows[i].Cells[2].Value),
                    activo = Convert.ToString(DGVCategoria.Rows[i].Cells[3].Value)


                });
            }

            rs.Name = "DataSet5";
            rs.Value = lst;
            Form5CatRep frm = new Form5CatRep();

            frm.RVCategoria.LocalReport.DataSources.Clear();
            frm.RVCategoria.LocalReport.DataSources.Add(rs);
            frm.RVCategoria.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report5Cat.rdlc";
            frm.ShowDialog();

        }
        public class ImpresionCategoria
        {
            public string cod_categoria { get; set; }
            public string categoria { get; set; }
            public string observacion { get; set; }
            public string activo { get; set; }

        }

        private void btImpSede_Click(object sender, EventArgs e)
        {
            List<ImpresionSede> lst = new List<ImpresionSede>();
            lst.Clear();

            for (int i = 0; i < DGVSede.Rows.Count; i++)
            {
                lst.Add(new ImpresionSede
                {
                    c_sede = Convert.ToString(DGVSede.Rows[i].Cells[0].Value),
                    nombre_sede = Convert.ToString(DGVSede.Rows[i].Cells[1].Value),
                    direccion = Convert.ToString(DGVSede.Rows[i].Cells[2].Value),
                    observacion = Convert.ToString(DGVSede.Rows[i].Cells[3].Value),
                    activo = Convert.ToString(DGVSede.Rows[i].Cells[4].Value),
                    c_distrito = Convert.ToString(DGVSede.Rows[i].Cells[5].Value),
                    c_provincia = Convert.ToString(DGVSede.Rows[i].Cells[6].Value),



                });
            }

            rs.Name = "DataSet6";
            rs.Value = lst;
            Form6Sede frm = new Form6Sede();

            frm.RVSede.LocalReport.DataSources.Clear();
            frm.RVSede.LocalReport.DataSources.Add(rs);
            frm.RVSede.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report6Sede.rdlc";
            frm.ShowDialog();
        }
        public class ImpresionSede
        {
            public string c_sede { get; set; }
            public string nombre_sede { get; set; }
            public string direccion { get; set; }
            public string observacion { get; set; }
            public string activo { get; set; }
            public string c_distrito { get; set; }
            public string c_provincia { get; set; }


        }

        private void btImpInstancia_Click(object sender, EventArgs e)
        {
            List<ImpresionInstancia> lst = new List<ImpresionInstancia>();
            lst.Clear();

            for (int i = 0; i < DGVInstancia.Rows.Count; i++)
            {
                lst.Add(new ImpresionInstancia
                {
                    c_sede = Convert.ToString(DGVInstancia.Rows[i].Cells[0].Value),
                    c_instancia = Convert.ToString(DGVInstancia.Rows[i].Cells[1].Value),
                    nombre_sede = Convert.ToString(DGVInstancia.Rows[i].Cells[2].Value),

                    nombre_instancia = Convert.ToString(DGVInstancia.Rows[i].Cells[3].Value),
                    nro_instancia = Convert.ToString(DGVInstancia.Rows[i].Cells[4].Value),
                    x_ubicacion_fisica = Convert.ToString(DGVInstancia.Rows[i].Cells[5].Value),
                    activo = Convert.ToString(DGVInstancia.Rows[i].Cells[6].Value),
                });
            }

            rs.Name = "DataSet7";
            rs.Value = lst;
            Form7Instancia frm = new Form7Instancia();

            frm.RVInstancia.LocalReport.DataSources.Clear();
            frm.RVInstancia.LocalReport.DataSources.Add(rs);
            frm.RVInstancia.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report7Instancia.rdlc";
            frm.ShowDialog();

        }
        public class ImpresionInstancia
        {



            public string c_instancia { get; set; }
            public string c_sede { get; set; }
            public string nombre_instancia { get; set; }
            public string nombre_sede { get; set; }
            public string nro_instancia { get; set; }
            public string x_ubicacion_fisica { get; set; }
            public string activo { get; set; }



        }

        private void btImpPersonal_Click(object sender, EventArgs e)
        {
            List<ImpresionPersonal> lst = new List<ImpresionPersonal>();
            lst.Clear();

            for (int i = 0; i < DGVPersonal.Rows.Count; i++)
            {
                lst.Add(new ImpresionPersonal
                {
                    doc_entry_personal = Convert.ToString(DGVPersonal.Rows[i].Cells[0].Value),
                    c_usuario = Convert.ToString(DGVPersonal.Rows[i].Cells[1].Value),
                    c_nombres = Convert.ToString(DGVPersonal.Rows[i].Cells[2].Value),
                    c_ape_paterno = Convert.ToString(DGVPersonal.Rows[i].Cells[3].Value),
                    c_ape_materno = Convert.ToString(DGVPersonal.Rows[i].Cells[4].Value),
                    nombre = Convert.ToString(DGVPersonal.Rows[i].Cells[5].Value),
                    fecha_ingreso = Convert.ToString(DGVPersonal.Rows[i].Cells[6].Value),
                    observacion = Convert.ToString(DGVPersonal.Rows[i].Cells[7].Value),
                    c_perfil = Convert.ToString(DGVPersonal.Rows[i].Cells[8].Value),
                    activo = Convert.ToString(DGVPersonal.Rows[i].Cells[9].Value),
                    dni = Convert.ToString(DGVPersonal.Rows[i].Cells[10].Value),
                    fecha_desactivacion = Convert.ToString(DGVPersonal.Rows[i].Cells[11].Value),
                    motivo_desactivacion = Convert.ToString(DGVPersonal.Rows[i].Cells[12].Value),
                    c_instancia = Convert.ToString(DGVPersonal.Rows[i].Cells[13].Value),
                    nombre_instancia = Convert.ToString(DGVPersonal.Rows[i].Cells[14].Value),
                    c_sede = Convert.ToString(DGVPersonal.Rows[i].Cells[15].Value),
                    nombre_sede = Convert.ToString(DGVPersonal.Rows[i].Cells[16].Value)

                });
            }

            rs.Name = "DataSet1";
            rs.Value = lst;
            Form8Personal frm = new Form8Personal();

            frm.RVPersonal.LocalReport.DataSources.Clear();
            frm.RVPersonal.LocalReport.DataSources.Add(rs);
            frm.RVPersonal.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report8Personal.rdlc";
            frm.ShowDialog();


        }
        public class ImpresionPersonal
        {
            public string doc_entry_personal { get; set; }
            public string c_usuario { get; set; }
            public string c_nombres { get; set; }
            public string c_ape_paterno { get; set; }
            public string c_ape_materno { get; set; }
            public string nombre { get; set; }
            public string fecha_ingreso { get; set; }
            public string observacion { get; set; }
            public string c_perfil { get; set; }
            public string activo { get; set; }
            public string dni { get; set; }
            public string fecha_desactivacion { get; set; }
            public string motivo_desactivacion { get; set; }
            public string c_instancia { get; set; }
            public string nombre_instancia { get; set; }
            public string c_sede { get; set; }
            public string nombre_sede { get; set; }
            public string perfil { get; set; }
            public string estado { get; set; }
            public string fecha_nacimiento { get; set; }
            public string escalafon { get; set; }
            public string fecha_termino_lab { get; set; }
            public string unidad_organica { get; set; }
            public string area { get; set; }
            public string tipo_personal { get; set; }
            public string fecha_ingreso_lab { get; set; }

        }

        private void btImpPerfil_Click(object sender, EventArgs e)
        {
            List<ImpresionPerfil> lst1 = new List<ImpresionPerfil>();
            lst1.Clear();

            for (int i = 0; i < DGVPerfil.Rows.Count; i++)
            {
                lst1.Add(new ImpresionPerfil
                {
                    cod_perfil = Convert.ToString(DGVPerfil.Rows[i].Cells[0].Value),
                    perfil = Convert.ToString(DGVPerfil.Rows[i].Cells[1].Value),
                    observacion = Convert.ToString(DGVPerfil.Rows[i].Cells[2].Value),
                    activo = Convert.ToString(DGVPerfil.Rows[i].Cells[3].Value),


                });
            }

            rs.Name = "DataSet9";
            rs.Value = lst1;
            Form9Perfil frm = new Form9Perfil();

            frm.RVPerfil.LocalReport.DataSources.Clear();
            frm.RVPerfil.LocalReport.DataSources.Add(rs);
            frm.RVPerfil.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report9Perfil.rdlc";
            frm.ShowDialog();


        }
        public class ImpresionPerfil
        {
            public string cod_perfil { get; set; }
            public string perfil { get; set; }
            public string observacion { get; set; }
            public string activo { get; set; }

        }

        private void cbCodEquipoAE_KeyUp(object sender, KeyEventArgs e)
        {

            ModeloDatoDataContext dc = new ModeloDatoDataContext();

            var dtListado = (from eq in dc.Equipos

                             select new
                             {
                                 Id = eq.cod_equipo,
                                 listado = eq.equipo + " | " + eq.marca + " | " + eq.modelo + " | " + eq.nro_serie + " | " + eq.nro_control_patrimonial,
                             });


            /*
            cbCodEquipoAE.DataSource = sq;
            cbCodEquipoAE.ValueMember = "id";
            cbCodEquipoAE.DisplayMember = "concatenado";
             */


            string strText;
            strText = cbCodEquipoAE.Text;
            if (cbCodEquipoAE.Text == "")
            {
                this.cbCodEquipoAE.DataSource = dtListado.ToList();
                this.cbCodEquipoAE.ValueMember = "Id";
                this.cbCodEquipoAE.DisplayMember = "listado";
                cbCodEquipoAE.SelectedIndex = -1;
                cbCodEquipoAE.DroppedDown = false;
            }

            if (strText.Length > 2)
            {
                /*
                 * lista.Where(p => p.Nombre.Contains(txtNombre.Text)).ToList();
                 */
                cbCodEquipoAE.DataSource = (dtListado.Where(p => p.listado.Contains(strText))).ToList();
                this.cbCodEquipoAE.ValueMember = "Id";
                this.cbCodEquipoAE.DisplayMember = "listado";
                if (cbCodEquipoAE.Items.Count != 0)
                {
                    cbCodEquipoAE.DroppedDown = true;
                    cbCodEquipoAE.SelectedIndex = -1;
                    cbCodEquipoAE.Text = "";
                    cbCodEquipoAE.SelectedText = strText;
                    strText = "";
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    cbCodEquipoAE.DataSource = dtListado.ToList();
                    cbCodEquipoAE.ValueMember = "Id";
                    cbCodEquipoAE.DisplayMember = "listado";
                    cbCodEquipoAE.SelectedIndex = -1;
                    cbCodEquipoAE.Text = "";
                    cbCodEquipoAE.SelectedText = strText;
                    strText = "";
                    cbCodEquipoAE.DroppedDown = false;
                }
            }
        }

        private void cbCodPersonalAE_KeyUp(object sender, KeyEventArgs e)
        {

            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var dtListado = ((from T0 in db.Personals
                              join T3 in db.Perfils on T0.c_perfil equals T3.c_perfil
                              join T1 in db.Sedes on T0.c_sede equals T1.c_sede
                              join T2 in db.Instancias on T0.c_instancia equals T2.c_instancia
                              select new
                              {
                                  id = T0.doc_entry_personal,
                                  listado = T0.c_ape_paterno + " " + T0.c_ape_materno + " " + T0.c_nombres + " | " + T0.dni,// + " | " + T1.nombre_sede + " | " + T2.nombre_instancia + " | " + T3.perfil,
                                  nombres_ = T0.c_ape_paterno + " " + T0.c_ape_materno + " " + T0.c_nombres,
                                  dni = T0.dni,
                                  nombre_sede = T1.nombre_sede,
                                  nombre_instancia = T2.nombre_instancia,
                              }).Union(from T0 in db.Personals
                                       join T3 in db.Perfils on T0.c_perfil equals T3.c_perfil
                                       join T1 in db.Sedes on T0.c_sede equals T1.c_sede

                                       where T0.c_instancia == "0"
                                       select new
                                       {
                                           id = T0.doc_entry_personal,
                                           listado = T0.c_ape_paterno + " " + T0.c_ape_materno + " " + T0.c_nombres + " | " + T0.dni,// + " | " + T1.nombre_sede + " | " + T2.nombre_instancia + " | " + T3.perfil,
                                           nombres_ = T0.c_ape_paterno + " " + T0.c_ape_materno + " " + T0.c_nombres,
                                           dni = T0.dni,
                                           nombre_sede = T1.nombre_sede,
                                           nombre_instancia = "",
                                       }));
            /*
            cbCodEquipoAE.DataSource = sq;
            cbCodEquipoAE.ValueMember = "id";
            cbCodEquipoAE.DisplayMember = "concatenado";
             */


            string strText;
            strText = cbCodPersonalAE.Text;
            if (cbCodPersonalAE.Text == "")
            {
                this.cbCodPersonalAE.DataSource = dtListado.ToList();
                this.cbCodPersonalAE.ValueMember = "Id";
                this.cbCodPersonalAE.DisplayMember = "listado";
                cbCodPersonalAE.SelectedIndex = -1;
                cbCodPersonalAE.DroppedDown = false;



            }

            if (strText.Length > 2)
            {
                /*
                 * lista.Where(p => p.Nombre.Contains(txtNombre.Text)).ToList();
                 */
                cbCodPersonalAE.DataSource = (dtListado.Where(p => p.listado.Contains(strText))).ToList();
                this.cbCodPersonalAE.ValueMember = "Id";
                this.cbCodPersonalAE.DisplayMember = "listado";



                if (cbCodPersonalAE.Items.Count != 0)
                {
                    cbCodPersonalAE.DroppedDown = true;
                    cbCodPersonalAE.SelectedIndex = -1;
                    cbCodPersonalAE.Text = "";
                    cbCodPersonalAE.SelectedText = strText;



                    strText = "";
                    Cursor.Current = Cursors.Default;


                }
                else
                {
                    cbCodPersonalAE.DataSource = dtListado.ToList();
                    cbCodPersonalAE.ValueMember = "Id";
                    cbCodPersonalAE.DisplayMember = "listado";
                    cbCodPersonalAE.SelectedIndex = -1;
                    cbCodPersonalAE.Text = "";
                    cbCodPersonalAE.SelectedText = strText;
                    strText = "";
                    cbCodPersonalAE.DroppedDown = false;



                }
            }
        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void DGVInstancia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonX5_Click_1(object sender, EventArgs e)
        {
            // tcPersonaperfil tcp = new tcPersonaperfil();
        }

        private void cbCodPersonalAE_Click(object sender, EventArgs e)
        {

        }

        private void cbCodPersonalAE_Leave(object sender, EventArgs e)
        {

            if (cbCodPersonalAE.SelectedText != string.Empty)
            {
                String source = Convert.ToString(cbCodPersonalAE.SelectedText); ; //Original Text
                String[] result = source.Split('|');
                // tbNombreAE.Text = Convert.ToString(result[0]);
                //Regex.Replace(OldString, @"\s", "");

                tbDniAE.Text = Convert.ToString(Regex.Replace(result[1], @"\s", ""));
                //tbSedeAE.Text = Convert.ToString(result[2]);
                // tbInstancAE.Text = Convert.ToString(result[3]);
                // tbPerfilAE.Text = Convert.ToString(result[4]);

            }
            if (tbDniAE.Text != string.Empty)//existe dni--> cargar datos
            {
                //obtener codPersonal apartir del dni
                ModeloDatoDataContext db = new ModeloDatoDataContext();
                var sql1 = (from T0 in db.Personals where T0.dni == tbDniAE.Text select T0.doc_entry_personal).ToList();
                keyPErsonal = sql1[0];
                obtenerPersonaAE(tbDniAE.Text);
                limpiarRegistro();
                superTabControl3.SelectedTabIndex = 6;
                superTabControl2.SelectedTabIndex = 3;
                //listarRegistro(1);
                //keyPErsonal = cod_personal[0];
            }
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;



        }

        private void cbCodEquipoAE_Leave(object sender, EventArgs e)
        {
            if (cbCodEquipoAE.SelectedText != string.Empty)
            {
                String source = Convert.ToString(cbCodEquipoAE.SelectedText); ; //Original Text
                String[] result = source.Split('|');
                /* tbEquipoAE.Text =Convert.ToString(result[0]);
                 tbMarcaAE.Text = Convert.ToString(result[1]);
                 tbModeloAE.Text = Convert.ToString(result[2]);
                 tbSerieAE.Text = Convert.ToString(result[3]);
                 tbCodPatrAE.Text = Convert.ToString(result[4]);
                 */
            }
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void cbCodEquipoAS_KeyUp(object sender, KeyEventArgs e)
        {

            ModeloDatoDataContext dc = new ModeloDatoDataContext();

            var dtListado = (from eq in dc.Equipos

                             select new
                             {
                                 Id = eq.cod_equipo,
                                 listado = eq.equipo + " | " + eq.marca + " | " + eq.modelo + " | " + eq.nro_serie + " | " + eq.nro_control_patrimonial,
                             });


            string strText;
            strText = cbCodEquipoAS.Text;
            if (cbCodEquipoAS.Text == "")
            {
                this.cbCodEquipoAS.DataSource = dtListado.ToList();
                this.cbCodEquipoAS.ValueMember = "Id";
                this.cbCodEquipoAS.DisplayMember = "listado";
                cbCodEquipoAS.SelectedIndex = -1;
                cbCodEquipoAS.DroppedDown = false;
            }

            if (strText.Length > 2)
            {
                /*
                 * lista.Where(p => p.Nombre.Contains(txtNombre.Text)).ToList();
                 */
                cbCodEquipoAS.DataSource = (dtListado.Where(p => p.listado.Contains(strText))).ToList();
                this.cbCodEquipoAS.ValueMember = "Id";
                this.cbCodEquipoAS.DisplayMember = "listado";
                if (cbCodEquipoAS.Items.Count != 0)
                {
                    cbCodEquipoAS.DroppedDown = true;
                    cbCodEquipoAS.SelectedIndex = -1;
                    cbCodEquipoAS.Text = "";
                    cbCodEquipoAS.SelectedText = strText;
                    strText = "";
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    cbCodEquipoAS.DataSource = dtListado.ToList();
                    cbCodEquipoAS.ValueMember = "Id";
                    cbCodEquipoAS.DisplayMember = "listado";
                    cbCodEquipoAS.SelectedIndex = -1;
                    cbCodEquipoAS.Text = "";
                    cbCodEquipoAS.SelectedText = strText;
                    strText = "";
                    cbCodEquipoAS.DroppedDown = false;
                }
            }

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void cbCodEquipoAS_Leave(object sender, EventArgs e)
        {
            if (cbCodEquipoAS.SelectedText != string.Empty)
            {
                String source = Convert.ToString(cbCodEquipoAS.SelectedText); ; //Original Text
                String[] result = source.Split('|');
                textBoxX5.Text = result[0].ToString();
                textBoxX4.Text = result[1].ToString();
                textBoxX3.Text = result[2].ToString();
                textBoxX2.Text = result[3].ToString();
                textBoxX1.Text = result[4].ToString();

            }
        }


        private void cbCodSoftAS_KeyUp(object sender, KeyEventArgs e)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var dtListado2 = (from sof in db.Softwares
                              select new
                              {
                                  id = sof.cod_software,
                                  listado = sof.software + " | " + Convert.ToString(sof.version),
                              });





            string strText;
            strText = cbCodSoftAS.Text;
            if (cbCodSoftAS.Text == "")
            {
                cbCodSoftAS.DataSource = dtListado2.ToList();
                cbCodSoftAS.ValueMember = "id";
                cbCodSoftAS.DisplayMember = "listado";
                cbCodSoftAS.SelectedIndex = -1;
                cbCodSoftAS.DroppedDown = false;



            }

            if (strText.Length > 2)
            {

                cbCodSoftAS.DataSource = (dtListado2.Where(p => p.listado.Contains(strText))).ToList();
                this.cbCodSoftAS.ValueMember = "id";
                this.cbCodSoftAS.DisplayMember = "listado";



                if (cbCodSoftAS.Items.Count != 0)
                {
                    cbCodSoftAS.DroppedDown = true;
                    cbCodSoftAS.SelectedIndex = -1;
                    cbCodSoftAS.Text = "";
                    cbCodSoftAS.SelectedText = strText;



                    strText = "";
                    Cursor.Current = Cursors.Default;


                }
                else
                {
                    cbCodSoftAS.DataSource = dtListado2.ToList();
                    cbCodSoftAS.ValueMember = "id";
                    cbCodSoftAS.DisplayMember = "listado";
                    cbCodSoftAS.SelectedIndex = -1;
                    cbCodSoftAS.Text = "";
                    cbCodSoftAS.SelectedText = strText;
                    strText = "";
                    cbCodSoftAS.DroppedDown = false;

                }
            }
        }


        private void cbCodSoftAS2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cbCodSoftAS2_Leave(object sender, EventArgs e)
        {
            if (cbCodSoftAS.SelectedText != string.Empty)
            {
                String source = Convert.ToString(cbCodSoftAS.SelectedText); ; //Original Text
                String[] result = source.Split('|');
                textBoxX9.Text = result[0].ToString();
                textBoxX8.Text = result[1].ToString();
                //textBoxX7.Text = result[2].ToString();


            }
        }

        private void cbCodSoftAS_Click(object sender, EventArgs e)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var dtListado = (from T0 in db.Softwares

                             select new
                             {
                                 Id = T0.cod_software,
                                 listado = T0.cod_software + " | " + T0.software + " | " + T0.version,
                             }).ToList();

            cbCodSoftAS.DataSource = dtListado;
            cbCodSoftAS.ValueMember = "Id";
            cbCodSoftAS.DisplayMember = "listado";
            MessageBox.Show(Convert.ToString(dtListado[0].listado));
        }

        private void navigationPane1_Load(object sender, EventArgs e)
        {

        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            Asignacion_equipo form = new Asignacion_equipo();
            form.Show();
        }

        private void sideNavItem5_Click(object sender, EventArgs e)
        {

        }

        private void buttonX13_Click(object sender, EventArgs e)
        {

            Asignacion_soft form = new Asignacion_soft();
            form.Show();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {

        }

        private void cbActivoInst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonX11_Click(object sender, EventArgs e)
        {

            superTabControl1.SelectedPanel.TabIndex = 3;
            superTabControl1.TabIndex = 3;
            superTabControl1.SelectedTabIndex = 3;
            superTabControl1.Focus();
            //  superTabControl1.SelectedTab.Focused(sideNavItem2);
            // sideNavItem2
            //tabControlPrincipal.SelectedIndex = 1;
        }

        private void sideNavItem7_Click(object sender, EventArgs e)
        {
            limpiarPersonal();
        }


        private void buttonX4_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {

        }

        private void panelEx6_Click(object sender, EventArgs e)
        {

        }

        private void superTabControlPanel3_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem3_Click(object sender, EventArgs e)
        {

        }


        #endregion
        /******************************************************************/
        /**************ASIGNACION DE EQUIPO - TAB CPU**********************/
        /******************************************************************/
        #region
        private void stCPU_Click(object sender, EventArgs e)
        {

            cargarAnioCompra();
            cbAnioCompra.SelectedIndex = 0;
            stSoftware.Visible = false;
            stComponente.Visible = false;
           

        }

        private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }


        private void radioButton1_Click(object sender, EventArgs e)
        { }


        private void buttonX1_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX2_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX3_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void panelEx11_Click(object sender, EventArgs e)
        {

        }

        private void cbCodPersonalAE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSoftware_SoftAE_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void obtenerSoft_softAE(int keyCodSoft_softAE)
        {
            Software objeto = clsTSoftware.obtener(keyCodSoft_softAE);


            ModeloDatoDataContext db = new ModeloDatoDataContext();

            var sql3 = (from T0 in db.Softwares

                        where T0.cod_software == keyCodSoft_softAE

                        select new
                        {
                            _tbnombreSoftAE = T0.software,
                            _tbVersionSoftAE = T0.version,
                            _tbCantidadUsSoftAE = T0.cantidad_usuarios,
                            _tbOCSoftAE = T0.nro_orden_compra,
                            _cbAnioCompraSoftAE = T0.anio_aquisicion,
                            _tbObsvSoftAE = T0.observacion,
                            _cbActivoSoftAE = T0.activo,

                        }).ToList();

            cbSoftware_SoftAE.Text = sql3[0]._tbnombreSoftAE;
            tbVersionSoftAE.Text = sql3[0]._tbVersionSoftAE;
            tbCantidadUsSoftAE.Text = Convert.ToString(sql3[0]._tbCantidadUsSoftAE);
            tbOCSoftAE.Text = sql3[0]._tbOCSoftAE;
            cbAnioCompraSoftAE.Text = sql3[0]._cbAnioCompraSoftAE;
            tbObsvSoftAE.Text = sql3[0]._tbObsvSoftAE;
            cbActivoSoftAE.Text = sql3[0]._cbActivoSoftAE;
            dtFechaInstalacionSoftAE.Text = String.Empty;
            dtFechaCaducidadSoftAE.Text = String.Empty;

        }

        private void cbSoftware_SoftAE_Click_1(object sender, EventArgs e)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var dtListado = (from T0 in db.Softwares

                             select new
                             {
                                 id = T0.cod_software,
                                 listado = T0.software
                             });




            /*
            cbCodEquipoAE.DataSource = sq;
            cbCodEquipoAE.ValueMember = "id";
            cbCodEquipoAE.DisplayMember = "concatenado";
             */



            cbSoftware_SoftAE.DataSource = dtListado.ToList();
            cbSoftware_SoftAE.ValueMember = "Id";
            cbSoftware_SoftAE.DisplayMember = "listado";

        }

        private void cbSoftware_SoftAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);


        }

        private void stiCPU_Click(object sender, EventArgs e)
        {
            desableFormAE();
            limpiarRegistro();
            superTabControl2.SelectedTabIndex = 0;
            cbAnioCompraComp.Visible = true;
            //stSoftware.Visible = true;
            //stComponente.Visible = true;
            stFormEquipo.Visible = true;
            stFormEquipo.Text = "Información CPU";

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            int nroCat = (from T0 in db.Categorias select T0).Count();
            if (nroCat != 0)
            {

                cargarCategorias();
                cbCatEq.SelectedIndex = 0;

            }
            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }


            cargarAnioCompra();
            cbAnioCompra.SelectedIndex = 0;
            tbNroSerie.Focus();
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;
            btRegistrarAE.Enabled = false;
            tbActualizarAE.Enabled = false;



        }

        private void stiSistAudio_Click(object sender, EventArgs e)
        {
            desableFormAE();
            limpiarRegistro();

            superTabControl2.SelectedTabIndex = 0;
            stSoftware.Visible = false;
            stComponente.Visible = false;
            stFormEquipo.Visible = true;
            cbAnioCompraComp.Visible = false;
            stFormEquipo.Text = "Información Sistema de Audio";

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            int nroCat = (from T0 in db.Categorias select T0).Count();
            if (nroCat != 0)
            {
                cargarCategorias();
                cbCatEq.SelectedIndex = 1;
            }
            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }

            cargarAnioCompra();
            cbAnioCompra.SelectedIndex = 0;
            tbNroSerie.Focus();
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;
            btRegistrarAE.Enabled = false;
            tbActualizarAE.Enabled = false;


        }

        private void stiLaptop_Click(object sender, EventArgs e)
        {
            desableFormAE();
            limpiarRegistro();
            superTabControl2.SelectedTabIndex = 0;
            stSoftware.Visible = false;
            stComponente.Visible = false;
            stFormEquipo.Visible = true;
            cbAnioCompraComp.Visible = false;
            stFormEquipo.Text = "Información Laptop";

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            int nroCat = (from T0 in db.Categorias select T0).Count();
            if (nroCat != 0)
            {
                cargarCategorias();
                cbCatEq.SelectedIndex = 2;
            }
            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }
            cargarAnioCompra();
            cbAnioCompra.SelectedIndex = 0;
            tbNroSerie.Focus();
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;
            btRegistrarAE.Enabled = false;
            tbActualizarAE.Enabled = false;

        }

        private void stiImpresora_Click(object sender, EventArgs e)
        {
            desableFormAE();
            limpiarRegistro();
            superTabControl2.SelectedTabIndex = 0;
            stSoftware.Visible = false;
            stComponente.Visible = false;
            stFormEquipo.Visible = true;
            cbAnioCompraComp.Visible = false;
            stFormEquipo.Text = "Información Impresora";

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            int nroCat = (from T0 in db.Categorias select T0).Count();
            if (nroCat != 0)
            {
                cargarCategorias();
                cbCatEq.SelectedIndex = 3;
            }
            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }

            cargarAnioCompra();
            cbAnioCompra.SelectedIndex = 0;
            tbNroSerie.Focus();
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;
            btRegistrarAE.Enabled = false;
            tbActualizarAE.Enabled = false;

        }

        private void stiEscaner_Click(object sender, EventArgs e)
        {
            desableFormAE();
            limpiarRegistro();
            superTabControl2.SelectedTabIndex = 0;
            stSoftware.Visible = false;
            stComponente.Visible = false;
            stFormEquipo.Visible = true;
            cbAnioCompraComp.Visible = false;
            stFormEquipo.Text = "Información Scanner";

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            int nroCat = (from T0 in db.Categorias select T0).Count();
            if (nroCat != 0)
            {
                cargarCategorias();
                cbCatEq.SelectedIndex = 4;
            }
            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }
            cargarAnioCompra();
            cbAnioCompra.SelectedIndex = 0;
            tbNroSerie.Focus();
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;
            btRegistrarAE.Enabled = false;
            tbActualizarAE.Enabled = false;

        }

        private void superTabItem2_Click(object sender, EventArgs e)
        {
            superTabControl2.SelectedTabIndex = 5;

        }

        private void labelItem1_Click(object sender, EventArgs e)
        {

        }

        private void stSoftware_Click(object sender, EventArgs e)
        {
            tbCatEqSoft.Text = string.Empty;
            tbProcesadorSoft.Text = string.Empty;
            tbAnioCompraSoft.Text = string.Empty;
            tbModeloSoft.Text = string.Empty;
            tbCodEquipoSofAE.Text = string.Empty;
            tbNroSerieSoft.Text = string.Empty;
            tbNroControlPatrimonialSoft.Text = string.Empty;
            tbIpSoft.Text = string.Empty;
            tbNroOrdenCompraSoft.Text = string.Empty;
            tbMarcaSoft.Text = string.Empty;
            cbEstadoEquipoSoft.Text = string.Empty;
            cbEstadoEquipoSoft.SelectedIndex = -1;
            tbFuncionamientoSoft.Text = string.Empty;
            tbObseracionSoft.Text = string.Empty;
            DGVSoftware_SodtAE.DataSource = null;
            limpiarSofwareAE();


        }

        private void sideNavItem4_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCat();
        }

        private void sideNavItem3_CheckedChanged(object sender, EventArgs e)
        {
            //limpiarRegistro();
            // limpiarSofwareAE();
            limpiarInfEncabezadoEquipo();
        }
        private void limpiarInfEncabezadoEquipo()
        {
            tbDniAE.Text = string.Empty;
            tbNombreAE.Text = string.Empty;
            dtFechaIngAE.Text = string.Empty;
            tbPerfilAE.Text = string.Empty;
            tbSedeAE.Text = string.Empty;
            tbInstancAE.Text = string.Empty;
        }

        private void sideNavItem2_CheckedChanged(object sender, EventArgs e)
        {
            limpiarSoft();
        }

        private void sideNavItem8_CheckedChanged(object sender, EventArgs e)
        {
            limpiarSede();
        }

        private void sideNavItem9_CheckedChanged(object sender, EventArgs e)
        {
            limpiarInstancia();
            cbSede_Instanc.SelectedIndex = -1;
        }

        private void rbNuevaPerfil_CheckedChanged(object sender, EventArgs e)
        {
            limpiarPerfil();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           ManagePermissions();
           sideNav1.SideNavStrip.TabIndex=2;
            //sideNavItem8
        
        }

        private void buttonX5_Click_2(object sender, EventArgs e)
        {
            listarPerfil();
            List<ImpresionPerfil> lst1 = new List<ImpresionPerfil>();
            lst1.Clear();

            for (int i = 0; i < DGVPerfil.Rows.Count; i++)
            {
                lst1.Add(new ImpresionPerfil
                {
                    cod_perfil = Convert.ToString(DGVPerfil.Rows[i].Cells[0].Value),
                    perfil = Convert.ToString(DGVPerfil.Rows[i].Cells[1].Value),
                    observacion = Convert.ToString(DGVPerfil.Rows[i].Cells[2].Value),
                    activo = Convert.ToString(DGVPerfil.Rows[i].Cells[3].Value),


                });
            }

            rs.Name = "DataSet9";
            rs.Value = lst1;
            Form9Perfil frm = new Form9Perfil();

            frm.RVPerfil.LocalReport.DataSources.Clear();
            frm.RVPerfil.LocalReport.DataSources.Add(rs);
            frm.RVPerfil.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report9Perfil.rdlc";
            frm.ShowDialog();
        }

        private void buttonX4_Click_2(object sender, EventArgs e)
        {
            //listarPersonal();

            //
            DGVPersonal.AutoGenerateColumns = false;
            DGVPersonal.DataSource = clsTPersonal.listar();
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql = (from T0 in db.Personals
                       join T3 in db.Perfils on T0.c_perfil equals T3.c_perfil
                       join T1 in db.Sedes on T0.c_sede equals T1.c_sede
                       join T2 in db.Instancias on T0.c_instancia equals T2.c_instancia
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
                           nombre_instancia = T2.nombre_instancia,
                           c_sede = T0.c_sede,
                           nombre_sede = T1.nombre_sede,
                           //
                           perfil = T3.perfil,
                           estado = T0.estado,
                           fecha_nacimiento = T0.fecha_nacimiento,
                           escalafon = T0.escalafon,
                           fecha_termino_lab = T0.fecha_termino_lab,
                           unidad_organica = T0.unidad_organica,
                           area = T0.area,
                           tipo_personal = T0.tipo_personal == "A" ? "Administrativo" : "Jurisdiccional",
                           fecha_ingreso_lab = T0.fecha_ingreso_lab,


                       }).Union(
                                   from T0 in db.Personals
                                   join T3 in db.Perfils on T0.c_perfil equals T3.c_perfil
                                   join T1 in db.Sedes on T0.c_sede equals T1.c_sede
                                   where T0.c_instancia == "0"
                                   //join T2 in db.Instancias on T0.c_instancia equals T2.c_instancia
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
                                       nombre_instancia = "",//T2.nombre_instancia,
                                       c_sede = T0.c_sede,
                                       nombre_sede = T1.nombre_sede,
                                       //
                                       perfil = T3.perfil,
                                       estado = T0.estado,
                                       fecha_nacimiento = T0.fecha_nacimiento,
                                       escalafon = T0.escalafon,
                                       fecha_termino_lab = T0.fecha_termino_lab,
                                       unidad_organica = T0.unidad_organica,
                                       area = T0.area,
                                       tipo_personal = T0.tipo_personal == "A" ? "Administrativo" : "Jurisdiccional",
                                       fecha_ingreso_lab = T0.fecha_ingreso_lab,


                                   }).OrderBy(x => x.c_nombres);

            DGVPersonal.AutoGenerateColumns = false;
            DGVPersonal.DataSource = sql.ToList();


            List<ImpresionPersonal> lst = new List<ImpresionPersonal>();
            lst.Clear();


            for (int i = 0; i < DGVPersonal.Rows.Count; i++)
            {

                lst.Add(new ImpresionPersonal
                {
                    doc_entry_personal = Convert.ToString(DGVPersonal.Rows[i].Cells[0].Value),
                    c_usuario = Convert.ToString(DGVPersonal.Rows[i].Cells[1].Value),
                    c_nombres = Convert.ToString(DGVPersonal.Rows[i].Cells[2].Value),
                    c_ape_paterno = Convert.ToString(DGVPersonal.Rows[i].Cells[3].Value),
                    c_ape_materno = Convert.ToString(DGVPersonal.Rows[i].Cells[4].Value),
                    nombre = Convert.ToString(DGVPersonal.Rows[i].Cells[5].Value),
                    fecha_ingreso = Convert.ToString(DGVPersonal.Rows[i].Cells[6].Value),
                    observacion = Convert.ToString(DGVPersonal.Rows[i].Cells[7].Value),
                    c_perfil = Convert.ToString(DGVPersonal.Rows[i].Cells[8].Value),
                    activo = Convert.ToString(DGVPersonal.Rows[i].Cells[9].Value),
                    dni = Convert.ToString(DGVPersonal.Rows[i].Cells[10].Value),
                    fecha_desactivacion = Convert.ToString(DGVPersonal.Rows[i].Cells[11].Value),
                    motivo_desactivacion = Convert.ToString(DGVPersonal.Rows[i].Cells[12].Value),
                    c_instancia = Convert.ToString(DGVPersonal.Rows[i].Cells[13].Value),
                    nombre_instancia = Convert.ToString(DGVPersonal.Rows[i].Cells[14].Value),
                    c_sede = Convert.ToString(DGVPersonal.Rows[i].Cells[15].Value),
                    nombre_sede = Convert.ToString(DGVPersonal.Rows[i].Cells[16].Value),
                    perfil = Convert.ToString(DGVPersonal.Rows[i].Cells[17].Value),
                    estado = Convert.ToString(DGVPersonal.Rows[i].Cells[18].Value),
                    fecha_nacimiento = Convert.ToString(DGVPersonal.Rows[i].Cells[19].Value),
                    escalafon = Convert.ToString(DGVPersonal.Rows[i].Cells[20].Value),
                    fecha_termino_lab = Convert.ToString(DGVPersonal.Rows[i].Cells[21].Value),
                    unidad_organica = Convert.ToString(DGVPersonal.Rows[i].Cells[22].Value),
                    area = Convert.ToString(DGVPersonal.Rows[i].Cells[23].Value),
                    tipo_personal = Convert.ToString(DGVPersonal.Rows[i].Cells[24].Value),
                    fecha_ingreso_lab = Convert.ToString(DGVPersonal.Rows[i].Cells[25].Value)


                });
            }

            rs.Name = "DataSet1";
            rs.Value = lst;
            Form8Personal frm = new Form8Personal();

            frm.RVPersonal.LocalReport.DataSources.Clear();
            frm.RVPersonal.LocalReport.DataSources.Add(rs);
            frm.RVPersonal.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.Report8Personal.rdlc";
            frm.ShowDialog();
        }

        #endregion

        private void btReporteSoftAE_Click(object sender, EventArgs e)
        {
            Asignacion_soft form = new Asignacion_soft();
            form.Show();
        }

        private void superTabItem5_Click(object sender, EventArgs e)
        {

        }

        private void cbPerfilPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stiOtros_Click(object sender, EventArgs e)
        {
            desableFormAE();
            limpiarRegistro();
            superTabControl2.SelectedTabIndex = 0;
            stSoftware.Visible = false;
            stComponente.Visible = false;
            stFormEquipo.Visible = true;
            cbAnioCompraComp.Visible = false;
            stFormEquipo.Text = "Información de otros equipos";

            ModeloDatoDataContext db = new ModeloDatoDataContext();
            int nroCat = (from T0 in db.Categorias select T0).Count();
            if (nroCat != 0)
            {
                cargarCategorias();
                cbCatEq.SelectedIndex = 5;
            }
            if (cbCatEq.Text != string.Empty)
            {
                int _cat = Convert.ToInt32(cbCatEq.SelectedValue);
                listarRegistro(_cat);
            }
            cargarAnioCompra();
            cbAnioCompra.SelectedIndex = 0;
            tbNroSerie.Focus();
            rbNuevoAE.Checked = false;
            rbEditarAE.Checked = false;
            btRegistrarAE.Enabled = false;
            tbActualizarAE.Enabled = false;
            

        }
        /// <summary>
        /// ///////////////////////////////////COMPONENTES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        int keyRegistro_CodEquipoCCom = 0;

        private void btListaAECCom_Click(object sender, EventArgs e)
        {
            limpiarRegistroCCom();
            if (tbCodEqCComInf.Text != string.Empty)
            {
                listarRegistroCCom(Convert.ToInt32(tbCodEqCComInf.Text));
            }
            rbNuevoAECCom.Checked = false;
            rbEditarAECCom.Checked = false;
            desableFormAECCom();
            DGVRegistroCCom.Enabled = true;

        }
        private void desableFormAECCom()
        {
            tbMarcaCCom.Enabled = false;
            tbNroSerieCCom.Enabled = false;
            tbModeloCCom.Enabled = false;
            tbProcesadorCCom.Enabled = false;
            cbAnioCompraCCom.Enabled = false;
            tbIpCCom.Enabled = false;
            tbFuncionamientoCCom.Enabled = false;
            tbObseracionCCom.Enabled = false;
            tbNroControlPatrimonialCCom.Enabled = false;
            cbEstadoEquipoCCom.Enabled = false;
            tbNroOrdenCompraCCom.Enabled = false;
            tbNombreEquipoCCom.Enabled = false;
            cbEquipoPadreCodCCom.Enabled = false;
            cbAsignadoCCom.Enabled = false;
            tbServiceTagCCom.Enabled = false;

        }

        private void btRegistrarAECCom_Click(object sender, EventArgs e)
        {
             registrarAECCom();

            
                /*
                //guardar equipo
                #region
                try
                {


                    if (tbNombreEquipoCCom.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el nombre del equipo");
                        tbNombreEquipoCCom.Focus();
                    }
                    else
                    {
                        if (tbMarcaCCom.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese una marca");
                            tbMarcaCCom.Focus();
                        }
                        else
                        {
                            if (tbModeloCCom.Text == string.Empty)
                            {
                                MessageBox.Show("Ingrese el modelo del equipo");
                                tbModeloCCom.Focus();
                            }
                            else
                            {

                                if (tbNroSerieCCom.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese el Nro de Serie");
                                    tbNroSerieCCom.Focus();
                                }
                                else
                                {
                                    if (tbModeloCCom.Text == string.Empty)
                                    {
                                        MessageBox.Show("Ingrese el Modelo");
                                        tbModeloCCom.Focus();
                                    }
                                    else
                                    {
                                        if (cbEstadoEquipoCCom.Text == string.Empty)
                                        {
                                            MessageBox.Show("Ingrese el número de Estado del Equipo");
                                            cbEstadoEquipoCCom.Focus();
                                        }
                                        else
                                        {
                                            if (cbAnioCompraCCom.Text == string.Empty)
                                            {
                                                MessageBox.Show("Ingrese el Año de compra del Equipo");
                                                cbEstadoEquipoCCom.Focus();
                                            }
                                            else
                                            {
                                                #region

                                                ModeloDatoDataContext db = new ModeloDatoDataContext();
                                                CTEquipo _pCTEquipo = new CTEquipo();
                                                Equipo objEquipo = new Equipo();

                                                int nro = (from s in db.Equipos where s.nro_serie == tbNroSerieCCom.Text select s).Count();
                                                //el equipo no esta creado, crear el equipo y asignarlo
                                                if (nro == 0)
                                                {
                                                    int pcod_equipo = 0;
                                                    int count = (from s in db.Equipos select s).Count();
                                                    if (count == 0)
                                                    {
                                                        objEquipo.cod_equipo = pcod_equipo + 1;
                                                    }
                                                    else
                                                    {
                                                        objEquipo.cod_equipo = Convert.ToInt32(db.Equipos.Select(p => p.cod_equipo).Max()) + 1;
                                                    }

                                                    objEquipo.equipo = tbNombreEquipoCCom.Text;
                                                    objEquipo.ip_equipo = tbIpCCom.Text;
                                                    objEquipo.marca = tbMarcaCCom.Text;
                                                    objEquipo.modelo = tbModeloCCom.Text;
                                                    objEquipo.procesador = tbProcesadorCCom.Text;
                                                    objEquipo.nro_serie = tbNroSerieCCom.Text;
                                                    objEquipo.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                                    objEquipo.anio_adquisicion = cbAnioCompraCCom.Text;
                                                    objEquipo.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                                    objEquipo.observacion = tbObseracionCCom.Text;
                                                    objEquipo.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                                    objEquipo.funcionamiento = tbFuncionamientoCCom.Text;
                                                    objEquipo.activo = "S";//cbAsignado.SelectedItem.ToString();
                                                    objEquipo.estado = Convert.ToString(cbEstadoEquipoCCom.SelectedItem);
                                                    objEquipo.service_tag = tbServiceTagCCom.Text;
                                                    //objEquipo.equipoPadreCod = Convert.ToInt32(tbCodEqCComInf.Text);

                                                    if (cbEquipoPadreCodCCom.Text != string.Empty)
                                                    {
                                                        objEquipo.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodCCom.Text);
                                                    }




                                                    DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                    switch (dr)
                                                    {
                                                        case DialogResult.Yes:
                                                            _pCTEquipo.registrar(objEquipo);
                                                            limpiarRegistroCCom();
                                                            MessageBox.Show("Registro realizado");
                                                            if (tbCodEqCComInf.Text != string.Empty)
                                                            {
                                                                listarRegistroCCom(Convert.ToInt32(tbCodEqCComInf.Text));
                                                            }
                                                            tbNombreEquipoCCom.Focus();

                                                            break;
                                                        case DialogResult.No:
                                                            break;
                                                    }

                                                }
                                                else //ya existe 
                                                {

                                                    var pComp = (from s in db.Equipos where s.nro_serie == tbNroSerieCCom.Text select s).ToList();
                                                    string asignado = pComp[0].activo;
                                                    if (asignado == "N") //el equipo ya existe y no est asignado, crear el registro
                                                    {




                                                        DialogResult dr = MessageBox.Show("Desea Grabar?", "Alerta...", MessageBoxButtons.YesNo);
                                                        switch (dr)
                                                        {
                                                            case DialogResult.Yes:
                                                                Equipo emp = new Equipo();
                                                                var cod_equ = (from T1 in db.Equipos where T1.nro_serie == tbNroSerieCCom.Text select T1.cod_equipo).ToList();

                                                                emp = db.Equipos.Single(x => x.cod_equipo == cod_equ[0]);
                                                                emp.equipo = tbNombreEquipoCCom.Text;
                                                                emp.ip_equipo = tbIpCCom.Text;
                                                                emp.marca = tbMarcaCCom.Text;
                                                                emp.modelo = tbModeloCCom.Text;
                                                                emp.procesador = tbProcesadorCCom.Text;
                                                                emp.nro_serie = tbNroSerieCCom.Text;
                                                                emp.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                                                emp.anio_adquisicion = cbAnioCompraCCom.Text;
                                                                emp.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                                                emp.observacion = tbObseracionCCom.Text;
                                                                emp.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                                                emp.funcionamiento = tbFuncionamientoCCom.Text;
                                                                emp.activo = "S";//cbAsignado.SelectedItem.ToString();
                                                                emp.estado = Convert.ToString(cbEstadoEquipoCCom.SelectedItem);
                                                                emp.service_tag = tbServiceTagCCom.Text;
                                                                //objEquipo.equipoPadreCod = Convert.ToInt32(tbCodEqCComInf.Text);

                                                                if (cbEquipoPadreCodCCom.Text != string.Empty)
                                                                {
                                                                    emp.equipoPadreCod = Convert.ToInt32(cbEquipoPadreCodCCom.Text);
                                                                }
                                                                db.SubmitChanges();
                                                                limpiarRegistroCCom();
                                                                MessageBox.Show("Registro realizado");
                                                                if (tbCodEqCComInf.Text != string.Empty)
                                                                {
                                                                    listarRegistroCCom(Convert.ToInt32(tbCodEqCComInf.Text));
                                                                }
                                                                tbNombreEquipoCCom.Focus();

                                                                break;
                                                            case DialogResult.No:
                                                                break;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("El registro ya existe");
                                                    }

                                                }

                                                #endregion
 
                                            }

                                           

                                        }

                                    }
                                }



                            }

                        }

                    }





                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    MessageBox.Show(error);
                }
                #endregion

        */


            
        }
        private void limpiarRegistroCCom()
        {
            tbMarcaCCom.Text = string.Empty;
            tbModeloCCom.Text = string.Empty;
            tbNroSerieCCom.Text = string.Empty;
            tbProcesadorCCom.Text = string.Empty;
            tbNroControlPatrimonialCCom.Text = string.Empty;
            cbEstadoEquipoCCom.SelectedIndex = -1;
            tbNroOrdenCompraCCom.Text = string.Empty;
            cbAnioCompraCCom.SelectedIndex = -1;
            tbIpCCom.Text = string.Empty;
            tbFuncionamientoCCom.Text = string.Empty;
            tbObseracionCCom.Text = string.Empty;
            cbAsignadoCCom.SelectedIndex = -1;
            tbNombreEquipoCCom.SelectedIndex = -1;
            DGVRegistroCCom.DataSource = null;
            //cbEquipoPadreCodCCom.Text = string.Empty;


        }
        private void enableUnenableComponentes(bool parm)
        {

            tbMarcaCCom.Enabled = parm;
            tbModeloCCom.Enabled = parm;
            tbNroSerieCCom.Enabled = parm;
            tbProcesadorCCom.Enabled = parm;
            tbNroControlPatrimonialCCom.Enabled = parm;
            cbEstadoEquipoCCom.Enabled = parm;
            tbNroOrdenCompraCCom.Enabled = parm;
            cbAnioCompraCCom.Enabled = parm;
            tbIpCCom.Enabled = parm;
            tbFuncionamientoCCom.Enabled = parm;
            tbObseracionCCom.Enabled = parm;
            cbAsignadoCCom.Enabled = parm;
            tbNombreEquipoCCom.Enabled = parm;
            //DGVRegistroCCom.Enabled = parm;

           
        }
        private void cargarEquipoCComInf(int keyCodEquipo)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql = from T0 in db.Equipos where T0.cod_equipo == keyCodEquipo select T0;

            Equipo objEquipo = clsTEqupipo.obtener(keyCodEquipo);

            tbCodEqCComInf.Text = Convert.ToString(objEquipo.cod_equipo);
            cbCatEqCComInf.Text = objEquipo.equipo;
            tbIpCComInf.Text = objEquipo.ip_equipo;
            tbMarcaCComInf.Text = objEquipo.marca;
            tbModeloCComInf.Text = objEquipo.modelo;
            tbProcesadorCComInf.Text = objEquipo.procesador;
            tbNroSerieCComInf.Text = objEquipo.nro_serie;
            tbNroControlPatrimonialCComInf.Text = objEquipo.nro_control_patrimonial;
            cbAnioCompraCComInf.Text = objEquipo.anio_adquisicion;
            tbNroOrdenCompraCComInf.Text = objEquipo.nro_orden_compra;
            tbObseracionCComInf.Text = objEquipo.observacion;
            cbCatEqCComInf.Text = Convert.ToString(objEquipo.cod_categoria);
            tbFuncionamientoCComInf.Text = objEquipo.funcionamiento;
            //objEquipo.activo = "S";//cbAsignado.SelectedItem.ToString();
            cbEstadoEquipoCComInf.Text = objEquipo.estado;
            //tbServiceTagCComInf.Text = objEquipo.service_tag;


        }

        private void rbNuevoAECCom_Click(object sender, EventArgs e)
        {
            enableFormComponente();
            btRegistrarAECCom.Enabled = true;
            tbActualizarAECCom.Enabled = false;
           // DGVRegistroCCom.Enabled = false;
            limpiarRegistroCCom();
           
            if (tbCodEqCComInf.Text != string.Empty)
            {
                listarRegistroCCom(Convert.ToInt32(tbCodEqCComInf.Text));
            }
            tbNombreEquipoCCom.Focus();
            dtFechaAsignacionAESCCom.Value = DateTime.Now;

        }

        private void rbEditarAECCom_Click(object sender, EventArgs e)
        {
            enableFormComponente();
            btRegistrarAECCom.Enabled = false;
            tbActualizarAECCom.Enabled = true;
            DGVRegistroCCom.Enabled = true;
            tbNombreEquipoCCom.Focus();

        }
        private void enableFormComponente()
        {
            //cbEquipoPadreCodCComInf.Text =Convert.ToString(objEquipo.equipoPadreCod);
            //cbCatEqCCom.Enabled = false;
            tbIpCCom.Enabled = true;
            tbMarcaCCom.Enabled = true;
            tbModeloCCom.Enabled = true;
            tbProcesadorCCom.Enabled = true;
            tbNroSerieCCom.Enabled = true;
            tbNroControlPatrimonialCCom.Enabled = true;
            cbAnioCompraCCom.Enabled = true;
            tbNroOrdenCompraCCom.Enabled = true;
            tbObseracionCCom.Enabled = true;

            tbFuncionamientoCCom.Enabled = true;
            //cbAsignado.Enabled = true;
            cbEstadoEquipoCCom.Enabled = true;
            tbServiceTagCCom.Enabled = true;
            //cbEquipoPadreCodCCom.Enabled = true;
            tbServiceTagCCom.Enabled = true;
            tbNombreEquipoCCom.Enabled = true;



        }
        private void desableFormComponente()
        {

        }

        private void cbAnioCompraCCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese un Año", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void cbAnioCompraCCom_Click(object sender, EventArgs e)
        {
            cargarAnioCompraCCom();
        }

        private void cbCatEqCCom_Click(object sender, EventArgs e)
        {
            cargarCategoriasCCom();
        }
        private void cargarAnioCompraCCom()
        {
            cbAnioCompraCCom.DataSource = null;
            cbAnioCompraCCom.Items.Clear();
            cbAnioCompraCCom.Items.Add("S/A");
            int aActual = DateTime.Now.Year;


            for (int anio = 1999; anio <= aActual; anio++)
            {
                cbAnioCompraCCom.Items.Add(Convert.ToString(anio));
            }
            cbAnioCompraCCom.SelectedIndex = 0;

        }
        private void cargarCategoriasCCom()
        {
            ModeloDatoDataContext dc = new ModeloDatoDataContext();
            var listCategorias = from cat in dc.Categorias select cat; //new{ cat.cod_categoria, cat.categoria };
            cbCatEqCCom.DataSource = listCategorias.ToList();
            cbCatEqCCom.ValueMember = "cod_categoria";
            cbCatEqCCom.DisplayMember = "categoria";

        }
        private void listarRegistroCCom(int cod_equipo)
        {
            ModeloDatoDataContext db = new ModeloDatoDataContext();
            var sql = (from T0 in db.Equipos
                       where T0.equipoPadreCod == cod_equipo
                       select new
                       {
                           id = "",//T0.cod_registro,
                           cod_personal = "",// T0.doc_entry_personal,
                           cod_equipo = T0.cod_equipo,
                           dni = "",// T1.dni,
                           nombre_per = "",//T1.c_ape_paterno + ' ' + T1.c_ape_materno + ' ' + T1.c_nombres,
                           cod_sede = "",// T1.c_sede,
                           nombre_sede = "",// T4.nombre_sede,
                           cod_instancia = "",// T1.c_instancia,
                           nombre_instancia = "",// T2.nombre_instancia,                               
                           nro_serie = T0.nro_serie,
                           nro_control_patrimonial = T0.nro_control_patrimonial,
                           nombre_equipo = T0.equipo,
                           fecha_registro = "",//T0.fecha_registro,
                           fecha_sistema = "",// T0.fecha_sistema,
                           observacion = T0.observacion,
                           marca = T0.marca,
                           modelo = T0.modelo,
                           serie = T0.nro_serie,
                           procesador = T0.procesador,
                           cod_patrimonial = T0.nro_control_patrimonial,
                           estado = T0.estado,
                           aniocompra = T0.anio_adquisicion,
                           ip = T0.ip_equipo,

                       }).ToList();
            DGVRegistroCCom.AutoGenerateColumns = false;
            DGVRegistroCCom.DataSource = sql;

        }

        private void tbLimpiarAECCom_Click(object sender, EventArgs e)
        {
            limpiarRegistroCCom();
            tbNombreEquipoCCom.Focus();
        }

        private void DGVRegistroCCom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in DGVRegistroCCom.Rows)
            {
                if (row.Index == e.RowIndex)
                {

                    keyRegistro_CodEquipoCCom = int.Parse(row.Cells[2].Value.ToString());
                    //cargarAnioCompra();
                    obtenerRegistroCCom(keyRegistro_CodEquipoCCom);

                }
            }
        }
        private void obtenerRegistroCCom(int keyRegistro_CodEquipoCCom)
        {
            cargarCategoriasCCom();
            cargarAnioCompraCCom();
            //obtener equipo
            CTEquipo _ctequipo = new CTEquipo();
            Equipo objEquipo = _ctequipo.obtener(keyRegistro_CodEquipoCCom);
            // objEquipo.cod_equipo = pcod_equipo + 1;
            cbCatEqCCom.Text = objEquipo.equipo;
            tbIpCCom.Text = objEquipo.ip_equipo;
            tbMarcaCCom.Text = objEquipo.marca;
            tbModeloCCom.Text = objEquipo.modelo;
            tbProcesadorCCom.Text = objEquipo.procesador;
            tbNroSerieCCom.Text = objEquipo.nro_serie;
            tbNroControlPatrimonialCCom.Text = objEquipo.nro_control_patrimonial;
            cbAnioCompraCCom.Text = objEquipo.anio_adquisicion;
            tbNroOrdenCompraCCom.Text = objEquipo.nro_orden_compra;
            tbObseracionCCom.Text = objEquipo.observacion;
            cbCatEqCCom.SelectedValue = objEquipo.cod_categoria;
            tbFuncionamientoCCom.Text = objEquipo.funcionamiento;
            //objEquipo.activo = "S";//cbAsignado.SelectedItem.ToString();
            cbEstadoEquipoCCom.Text = objEquipo.estado;
            tbServiceTagCCom.Text = objEquipo.service_tag;
            // Convert.ToInt32(tbCodEqCComInf.Text=objEquipo.equipoPadreCod );
            // objEquipo.equipoPadreCod
            tbNombreEquipoCCom.Text = objEquipo.equipo;
            cbEquipoPadreCodCCom.Text = Convert.ToString(objEquipo.equipoPadreCod);
            cbAsignadoCCom.Text = objEquipo.activo;



        }

        private void tbActualizarAECCom_Click(object sender, EventArgs e)
        {

            //actualizar equipo
            #region
            try
            {
                if (keyRegistro_CodEquipoCCom != 0)
                {

                    if (tbNombreEquipoCCom.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el nombre del equipo");
                        tbNombreEquipoCCom.Focus();
                    }
                    else
                    {
                        if (tbMarcaCCom.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese una marca");
                            tbMarcaCCom.Focus();
                        }
                        else
                        {
                            if (tbModeloCCom.Text == string.Empty)
                            {
                                MessageBox.Show("Ingrese el modelo del equipo");
                                tbModeloCCom.Focus();
                            }
                            else
                            {

                                if (tbNroSerieCCom.Text == string.Empty)
                                {
                                    MessageBox.Show("Ingrese el Nro de Serie");
                                    tbNroSerieCCom.Focus();
                                }
                                else
                                {
                                    if (tbModeloCCom.Text == string.Empty)
                                    {
                                        MessageBox.Show("Ingrese el Modelo");
                                        tbModeloCCom.Focus();
                                    }
                                    else
                                    {
                                        if (cbEstadoEquipoCCom.Text == string.Empty)
                                        {
                                            MessageBox.Show("Ingrese el Equipo");
                                            cbEstadoEquipoCCom.Focus();
                                        }
                                        else
                                        {
                                            ModeloDatoDataContext db = new ModeloDatoDataContext();
                                            Equipo objEquipo7 = new Equipo();
                                            CTEquipo _CTEquipo = new CTEquipo();


                                            objEquipo7.cod_equipo = keyRegistro_CodEquipoCCom;

                                            objEquipo7.equipo = tbNombreEquipoCCom.Text;
                                            objEquipo7.ip_equipo = tbIpCCom.Text;
                                            objEquipo7.marca = tbMarcaCCom.Text;
                                            objEquipo7.modelo = tbModeloCCom.Text;
                                            objEquipo7.procesador = tbProcesadorCCom.Text;
                                            objEquipo7.nro_serie = tbNroSerieCCom.Text;
                                            objEquipo7.nro_control_patrimonial = tbNroControlPatrimonialCCom.Text;
                                            objEquipo7.anio_adquisicion = cbAnioCompraCCom.Text;
                                            objEquipo7.nro_orden_compra = tbNroOrdenCompraCCom.Text;
                                            objEquipo7.observacion = tbObseracionCCom.Text;


                                            objEquipo7.cod_categoria = Convert.ToInt32(cbCatEqCCom.SelectedValue);
                                            objEquipo7.funcionamiento = tbFuncionamientoCCom.Text;
                                            objEquipo7.activo = "S";//cbAsignado.SelectedItem.ToString();
                                            objEquipo7.estado = Convert.ToString(cbEstadoEquipoCCom.SelectedItem);
                                            objEquipo7.service_tag = tbServiceTagCCom.Text;
                                            objEquipo7.equipoPadreCod = Convert.ToInt32(tbCodEqCComInf.Text);
                                            //cbEquipoPadreCodCCom


                                            DialogResult dr = MessageBox.Show("Desea Actualizar?", "Alerta...", MessageBoxButtons.YesNo);
                                            switch (dr)
                                            {
                                                case DialogResult.Yes:
                                                    _CTEquipo.actualizar(objEquipo7);
                                                    limpiarRegistroCCom();
                                                    MessageBox.Show("Registro actualizado");
                                                    tbMarcaCCom.Focus();
                                                    if (tbCodEqCComInf.Text != string.Empty)
                                                    {
                                                        listarRegistroCCom(Convert.ToInt32(tbCodEqCComInf.Text));
                                                    }

                                                    tbNombreEquipoCCom.Focus();
                                                    break;
                                                case DialogResult.No:
                                                    break;
                                            }

                                        }



                                    }



                                }

                            }

                        }


                    }

                }



                else
                {
                    MessageBox.Show("Seleccione un registro de la lista");
                }








            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }
            #endregion

        }

        private void tbEliminarAECCom_Click(object sender, EventArgs e)
        {
            try 
            {
                if (keyRegistro_CodEquipoCCom != 0 && tbDniAE.Text != string.Empty)
                {
                    //1 verificar si el componente esta asignado al usuario
                    //1.1 si si el componente esta asignado al usuario=>eliminar el registro o asignacion, actualizar el equipo a N asignado y codPadre 0
                    //1.2  NO el componente no esta asignado al usuario=> actualizar el equipo a N asignado y codPadre 0

                    //1 verificar si el componente esta asignado al usuario
                    ModeloDatoDataContext db = new ModeloDatoDataContext();
                    var comp_asig = (from T0 in db.Registros
                                     join T1 in db.Personals on T0.doc_entry_personal equals T1.doc_entry_personal
                                     where T0.cod_equipo == keyRegistro_CodEquipoCCom && T1.dni == tbDniAE.Text
                                     select new
                                     {
                                         cod_registro = T0.cod_registro,
                                         cod_equipo = T0.cod_equipo,
                                         doc_entry_personal = T0.doc_entry_personal,
                                         fecha_registro = T0.fecha_registro,
                                         fecha_sistema = T0.fecha_sistema,
                                     }).ToList();


                    //1.1 si si el componente esta asignado al usuario=>eliminar el registro o asignacion, actualizar el equipo a N asignado y codPadre 0
                    if (comp_asig.Count() > 0)
                    {
                        DialogResult dr = MessageBox.Show("Desea Eliminar la Asignación?", "Alerta...", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                //el equipo pasaria a no asignado y sin padre                               
                                Equipo empcp = new Equipo();
                                empcp = db.Equipos.Single(x => x.cod_equipo == comp_asig[0].cod_equipo);
                                empcp.activo = "N";
                                empcp.equipoPadreCod = 0;
                                db.SubmitChanges();
                                //retirar el equipo
                                CTRegistro crecomp = new CTRegistro();
                                crecomp.eliminar(comp_asig[0].cod_registro);//registrar en el historial la desasignacion
                                

                                limpiarRegistroCCom();
                                MessageBox.Show("registro eliminado");
                                if (tbCodEqCComInf.Text != string.Empty)
                                {
                                    listarRegistroCCom(Convert.ToInt32(tbCodEqCComInf.Text));
                                }
                                tbNombreEquipoCCom.Focus();
                                break;
                            case DialogResult.No:
                                break;
                        }


                    }
                    else  //1.2  NO el componente no esta asignado al usuario=> actualizar el equipo a N asignado y codPadre 0
                    {
                        DialogResult dr = MessageBox.Show("Desea Eliminar la Asignación?", "Alerta...", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:

                                ModeloDatoDataContext bda = new ModeloDatoDataContext();
                                Equipo compSAs = new Equipo();
                                compSAs = bda.Equipos.Single(x => x.cod_equipo == keyRegistro_CodEquipoCCom);
                                compSAs.activo = "N";
                                compSAs.equipoPadreCod = 0;
                                bda.SubmitChanges();
                                //registrar en el historial la desasignacion en la tabla historial_registro

                                String connectionString = ConfigurationManager.ConnectionStrings["Models.Properties.Settings.PARQUEO03_30122021_pruebaConnectionString2"].ConnectionString;
                                
                                SqlConnection sqlConnection = new SqlConnection(connectionString);
                                using (SqlConnection con = new SqlConnection(connectionString))
                                 {
                                     using (SqlCommand cmd = new SqlCommand("sp_insert_component_desasignado_historiaReg", con))
                                     {
                                         cmd.CommandType = CommandType.StoredProcedure;

                                         cmd.Parameters.Add("@cod_equipo", SqlDbType.Int).Value = keyRegistro_CodEquipoCCom;
                                         cmd.Parameters.Add("@dni", SqlDbType.VarChar).Value = tbDniAE.Text;

                                         con.Open();
                                         cmd.ExecuteNonQuery();
                                     }
                                 }

                                limpiarRegistroCCom();
                                MessageBox.Show("registro eliminado");
                                if (tbCodEqCComInf.Text != string.Empty)
                                {
                                    listarRegistroCCom(Convert.ToInt32(tbCodEqCComInf.Text));
                                }
                                tbNombreEquipoCCom.Focus();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro de la Lista");

                }
           
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }

           
           
      
        }

        private void tbCerrarAECCom_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btReportEquipoCCom_Click(object sender, EventArgs e)
        {
            Asignacion_equipo form = new Asignacion_equipo();
            form.Show();
        }

        private void stComponente_Click(object sender, EventArgs e)
        {
            cargarAnioCompraCCom();
            tbMarcaCComInf.Text = string.Empty;
            tbNroSerieCComInf.Text = string.Empty;
            tbModeloCComInf.Text = string.Empty;
            tbProcesadorCComInf.Text = string.Empty;
            tbNroControlPatrimonialCComInf.Text = string.Empty;
            cbEstadoEquipoCComInf.Text = string.Empty;
            cbEstadoEquipoCComInf.SelectedIndex = -1;
            tbNroOrdenCompraCComInf.Text = string.Empty;
            cbAnioCompraCComInf.Text = string.Empty;
            tbIpCComInf.Text = string.Empty;
            tbFuncionamientoCComInf.Text = string.Empty;
            tbObseracionCComInf.Text = string.Empty;
            limpiarRegistroCCom();
            DGVRegistroCCom.DataSource = null;

            

        }

        private void SNIUsers_Click(object sender, EventArgs e)
        {
            /*FormUsers frmUsers = new FormUsers();
            frmUsers.ShowDialog();*/
            OpenChildFormCU<FormUserProfile>(null);//Si el control es un boton del menu lateral enviar el objeto remitente.
        }

        private void sideNavItem6_Click(object sender, EventArgs e)
        {
           /* FormUserProfile frmUserProfile = new FormUserProfile();
            frmUserProfile.ShowDialog();*/

            OpenChildForm<FormUsers>(null);//Si el control es un boton del menu lateral enviar el objeto remitente.

        }
        private void OpenChildFormCU<ChildForm>(object senderMenuButton) where ChildForm : Form, new()
        {
            System.Windows.Forms.Button menuButton = (System.Windows.Forms.Button)senderMenuButton;//Boton de donde se abre el formulario, puedes enviar un valor nulo, si no estas tratando de abrir un formulario desde un control diferente de los botones del menu lateral.
            Form form = listChildForms.OfType<ChildForm>().FirstOrDefault();//Buscar si el formulario ya está instanciado o se ha mostrado anteriormente.

            if (activeChildForm != null && form == activeChildForm)//Si el formulario es igual al formulario  actual activo, retornar ( no hacer nada).
                return;

            if (form == null)//Si el formulario no existe, entonces crear la instancia y mostrarla en el panel escritorio.
            {

                form = new ChildForm();// Instanciar formulario.   
                form.FormBorderStyle = FormBorderStyle.None;//Quitar el borde.
                form.TopLevel = false;//Indicar que el formulario no es de nivel superior  
                form.Dock = DockStyle.Fill; //Establecer el estilo de muelle en lleno (Rellenar el panel escritorio)          
                listChildForms.Add(form);//Agregar formulario secundario a la lista de formularios.

                if (menuButton != null)//Si el boton de menu es diferente a nulo:
                {
                    ActivateButton(menuButton);//Activar/Resaltar el boton.
                    form.FormClosed += (s, e) =>
                    {//Cuando del formulario se cierre, desactivar el boton.
                        DeactivateButton(menuButton);
                    };
                }
               // btnChildFormClose.Visible = true;//Mostrar el boton de cerrar formulario secundario.
            }

            CleanDesktop();//Eliminar el formulario secundario actual del panel escritorio
            panelDesktopCU.Controls.Add(form);//agregar formulario secundario al panel del escritorio
            panelDesktopCU.Tag = form;// Almacenar el formulario
            form.Show();//Mostrar el formulario 
            form.BringToFront();// Traer al frente
            form.Focus();//Enfocar el formulario
            //lblCaption.Text = form.Text;//Establecer el titulo del formulario.
            activeChildForm = form;//Establecer como formulario activo.
        }
        private void OpenChildForm<ChildForm>(object senderMenuButton) where ChildForm : Form, new()
        {
            System.Windows.Forms.Button menuButton = (System.Windows.Forms.Button)senderMenuButton;//Boton de donde se abre el formulario, puedes enviar un valor nulo, si no estas tratando de abrir un formulario desde un control diferente de los botones del menu lateral.
            Form form = listChildForms.OfType<ChildForm>().FirstOrDefault();//Buscar si el formulario ya está instanciado o se ha mostrado anteriormente.

            if (activeChildForm != null && form == activeChildForm)//Si el formulario es igual al formulario  actual activo, retornar ( no hacer nada).
                return;

            if (form == null)//Si el formulario no existe, entonces crear la instancia y mostrarla en el panel escritorio.
            {

                form = new ChildForm();// Instanciar formulario.   
                form.FormBorderStyle = FormBorderStyle.None;//Quitar el borde.
                form.TopLevel = false;//Indicar que el formulario no es de nivel superior  
                form.Dock = DockStyle.Fill; //Establecer el estilo de muelle en lleno (Rellenar el panel escritorio)          
                listChildForms.Add(form);//Agregar formulario secundario a la lista de formularios.

                if (menuButton != null)//Si el boton de menu es diferente a nulo:
                {
                    ActivateButton(menuButton);//Activar/Resaltar el boton.
                    form.FormClosed += (s, e) =>
                    {//Cuando del formulario se cierre, desactivar el boton.
                        DeactivateButton(menuButton);
                    };
                }
                //btnChildFormClose.Visible = true;//Mostrar el boton de cerrar formulario secundario.
            }
           
            CleanDesktop();//Eliminar el formulario secundario actual del panel escritorio
            panelDesktop.Controls.Add(form);//agregar formulario secundario al panel del escritorio
            panelDesktop.Tag = form;// Almacenar el formulario
            form.Show();//Mostrar el formulario 
            form.BringToFront();// Traer al frente
            form.Focus();//Enfocar el formulario
           // lblCaption.Text = form.Text;//Establecer el titulo del formulario.
            activeChildForm = form;//Establecer como formulario activo.
        }
        private void ActivateButton(System.Windows.Forms.Button menuButton)
        {
            menuButton.ForeColor = Color.FromArgb(0, 100, 182);
            //menuButton.BackColor = panelMenuHeader.BackColor;
        }
        private void DeactivateButton(System.Windows.Forms.Button menuButton)
        {
            menuButton.ForeColor = Color.DarkGray;
            //menuButton.BackColor = panelSideMenu.BackColor;
        }
         private void CleanDesktop()
        {//Limpiar el escritorio.

            if (activeChildForm != null)
            {
                activeChildForm.Hide();
                panelDesktop.Controls.Remove(activeChildForm);
            }
            /* Este método oculta y elimina el formulario secundario activo del panel escritorio,
            * por lo que solo habrá un formulario secundario abierto dentro del panel del escritorio,
            * ya que agregar un formulario nuevo elimina el formulario anterior y agrega el nuevo
            * formulario (Revise el método OpenChildForm).
            * Los formularios secundarios inactivos se almacenan en una lista genérica.

            * Creé estos métodos para deshacerme de las dudas ya que muchos piensan (incluido yo mismo) que
            * tener 20 o 50 formularios agregados dentro del panel escritorio afecta el rendimiento,
            * bueno, no me di cuenta de eso. De hecho, es posible agregar 10 mil controles dinámicamente
            * en una formulario mostrada y no hay límite si se agrega desde el constructor del formulario, 
            * para experimentar, agregué 100 mil etiquetas y 10 mil paneles con color aunque tardó más
            * de 10 minutos en mostrar (pc : 8 ram, cpu SixCore 3,50 GHz)
             y no hay ningún problema de rendimiento (consumió 20mb ram) y desplazarse por el formulario funciona bien.

            * Por lo tanto, si estos métodos parecen muy tediosos o difíciles de entender, puede utilizar 
            * los métodos para abrir un formulario secundario dentro del panel de Proyectos 
            * anteriores (tutoriales) que se muestran en YouTube, donde los formularios secundarios
            * se almacenan dentro del Panel escritorio, se superponen uno tras otro y se muestra uno (form.bringtofront ();).

            * Sin embargo, todavía no me parece apropiado agregar tantos formularios dentro de un panel 
            * considerando que un formulario predeterminado es de nivel superior y no me gusta la idea
            * de tener tantos controles en un panel (controles de formulario secundario ).

            * Como resultado, preferí almacenar los formularios secundarios en una lista genérica y 
            * agregar y mostrar solo un formulario en el panel escritorio :) */
        }
         private void ManagePermissions()
         {//Administrar los permisos de usuario, esto es simplemente una demostración,
             //Puedes eliminarlo si no lo necesitas.
             switch (ActiveUser.Position)
             {
                 case Positions.GeneralManager:
                     sideNavItem6.Enabled = false;//lista de usuarios
                     sideNavItem7.Enabled = true;//personal
                     rbNuevaPerfil.Enabled = true;//perfil de personal
                     sideNavItem9.Enabled = true;//instancia
                     sideNavItem8.Enabled = true;//sede
                     sideNavItem2.Enabled = true;//software
                     sideNavItem5.Enabled = false;//asignacion de software
                     sideNavItem3.Enabled = true;//asig de equipo y software
                     sideNavItem4.Enabled = true;//categoria de equipos
                     sideNavItem10.Enabled = true;//reportes
                     break;                
                case Positions.SystemAdministrator:
                     sideNavItem6.Enabled = true;//lista de usuarios
                     sideNavItem7.Enabled = true;//personal
                     rbNuevaPerfil.Enabled = true;//perfil de personal
                     sideNavItem9.Enabled = true;//instancia
                     sideNavItem8.Enabled = true;//sede
                     sideNavItem2.Enabled = true;//software
                     sideNavItem5.Enabled = false;//asignacion de software
                     sideNavItem3.Enabled = true;//asig de equipo y software
                     sideNavItem4.Enabled = true;//categoria de equipos
                     sideNavItem10.Enabled = true;//reportes
                     break;
                case Positions.digitizer:
                    sideNavItem6.Enabled = false;//lista de usuarios
                     sideNavItem7.Enabled = true;//personal
                     rbNuevaPerfil.Enabled = true;//perfil de personal
                     sideNavItem9.Enabled = true;//instancia
                     sideNavItem8.Enabled = true;//sede
                     sideNavItem2.Enabled = true;//software
                     sideNavItem5.Enabled = false;//asignacion de software
                     sideNavItem3.Enabled = true;//asig de equipo y software
                     sideNavItem4.Enabled = true;//categoria de equipos
                     sideNavItem10.Enabled = true;//reportes
                     break;
             }
         }

         private void Form1_FormClosing(object sender, FormClosingEventArgs e)
         {
            /* DialogResult dr = MessageBox.Show("¿ Desea Cerrar Sesón ?", "Alerta...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             switch (dr)
             {
                 case DialogResult.Yes:
                     Application.Exit();
                     break;
                 case DialogResult.No:
                     break;
             }*/
             Application.Exit();
         }

         private void sideNavItem11_Click(object sender, EventArgs e)
         {
             DialogResult dr = MessageBox.Show("¿ Desea Cerrar Sesón ?", "Alerta...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             switch (dr)
             {
                 case DialogResult.Yes:
                     Application.Exit();
                     break;
                 case DialogResult.No:
                     break;
             }
         }

         private void sideNavItem1_Click(object sender, EventArgs e)
         {

         }

         private void rbNuevoEq_Click(object sender, EventArgs e)
         {
             cargarAnioCompra_softAE(cbAnioCompraNA);

             btRegistrarEquipo.Enabled = true;
             btEliminarEquipo.Enabled = true;
             btActualizarEquipo.Enabled = false;

             tbNombreEquipoNA.Enabled = true;
             cbCatEqNA.Enabled = true;
             tbNroSerieNA.Enabled = true;

             tbMarcaNA.Enabled = true;
             tbModeloNA.Enabled = true;
             tbProcesadorNA.Enabled = true;
             tbNroControlPatrimonialNA.Enabled = true;
             cbEstadoEquipoNA.Enabled = true;
             tbNroOrdenCompraNA.Enabled = true;
             cbAnioCompraNA.Enabled = true;
             tbIpNA.Enabled = true;
             tbFuncionamientoNA.Enabled = true;
             tbObseracionNA.Enabled = true;
             //cbEquipoPadreCodNA.Enabled = true;
             cbAsignadoNA.Enabled = false;
           
             tbServiceTagNA.Enabled = true;
             limpiar();
             listar();
             dgvEquipo.Enabled = true;
             
         }

         private void rbEditarEq_Click(object sender, EventArgs e)
         {
             cargarAnioCompra_softAE(cbAnioCompraNA);


             btRegistrarEquipo.Enabled = false;
             btEliminarEquipo.Enabled = true;
             btActualizarEquipo.Enabled = true;

             tbNombreEquipoNA.Enabled = true;
             cbCatEqNA.Enabled = true;
             tbNroSerieNA.Enabled = true;
             tbMarcaNA.Focus();
             tbMarcaNA.Enabled = true;
             tbModeloNA.Enabled = true;
             tbProcesadorNA.Enabled = true;
             tbNroControlPatrimonialNA.Enabled = true;
             cbEstadoEquipoNA.Enabled = true;
             tbNroOrdenCompraNA.Enabled = true;
             cbAnioCompraNA.Enabled = true;
             tbIpNA.Enabled = true;
             tbFuncionamientoNA.Enabled = true;
             tbObseracionNA.Enabled = true;

             //cbEquipoPadreCodNA.Enabled = true;
             cbAsignadoNA.Enabled = false;

             tbServiceTagNA.Enabled = true;

             listar();

             dgvEquipo.Enabled = true;


         }

         private void cbCatEqNA_Click(object sender, EventArgs e)
         {
             ModeloDatoDataContext dc = new ModeloDatoDataContext();
             var listCategorias = from cat in dc.Categorias select cat; //new{ cat.cod_categoria, cat.categoria };
             cbCatEqNA.DataSource = listCategorias.ToList();
             cbCatEqNA.ValueMember = "cod_categoria";
             cbCatEqNA.DisplayMember = "categoria";
             cbCatEqNA.SelectedIndex = -1;

         }

         private void tbNroSerie_Leave(object sender, EventArgs e)
         {
             cargarSoloEquipoRegistradoAES();
             
         }

         private void cargarSoloEquipoRegistradoAES() 
         {
             ModeloDatoDataContext db = new ModeloDatoDataContext();
            int nro_eqXserie= (from T1 in db.Equipos  where T1.nro_serie == tbNroSerie.Text select T1).Count();
            
             if (tbNroSerie.Text != string.Empty )
             {
                 if (nro_eqXserie > 0)
                 {

                     var sql3 = (from T1 in db.Equipos
                                 join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                 where T1.nro_serie == tbNroSerie.Text

                                 select new
                                 {
                                     _cod_equipo = T1.cod_equipo,

                                     _cbCodCatEq = T1.cod_categoria,

                                     _tbNroSerie = T1.nro_serie,
                                     _tbMarca = T1.marca,
                                     _tbModelo = T1.modelo,
                                     _tbProcesador = T1.procesador,
                                     _tbNroControlPatrimonial = T1.nro_control_patrimonial,
                                     _cbEstadoEquipo = T1.estado,
                                     _tbNroOrdenCompra = T1.nro_orden_compra,
                                     _cbAnioCompra = T1.anio_adquisicion,
                                     _tbIp = T1.ip_equipo,
                                     _tbFuncionamiento = T1.funcionamiento,
                                     _tbObseracion = T1.observacion,
                                     _asignado = T1.activo,
                                     _equipo = T1.equipo,
                                     _cbCatEq = T2.categoria,

                                 }).ToList();

                     // _cod_equipo = sql3[0]._cod_equipo

                     // tbNroSerie.Text = Convert.ToString(sql3[0]._tbNroSerie);

                     tbMarca.Text = Convert.ToString(sql3[0]._tbMarca);
                     tbModelo.Text = Convert.ToString(sql3[0]._tbModelo);
                     tbProcesador.Text = Convert.ToString(sql3[0]._tbProcesador);
                     tbNroControlPatrimonial.Text = Convert.ToString(sql3[0]._tbNroControlPatrimonial);
                     cbEstadoEquipo.Text = Convert.ToString(sql3[0]._cbEstadoEquipo);
                     cbAnioCompra.Text = Convert.ToString(sql3[0]._cbAnioCompra.ToString());
                     tbIp.Text = Convert.ToString(sql3[0]._tbIp);
                     tbFuncionamiento.Text = Convert.ToString(sql3[0]._tbFuncionamiento);
                     tbObseracion.Text = Convert.ToString(sql3[0]._tbObseracion);
                     cbAsignado.Text = Convert.ToString(sql3[0]._asignado);
                     tbNroOrdenCompra.Text = Convert.ToString(sql3[0]._tbNroOrdenCompra);
                     tbNombreEquipo.Text = Convert.ToString(sql3[0]._equipo);



                     cbCatEq.DataSource = sql3;
                     cbCatEq.ValueMember = "_cbCodCatEq";
                     cbCatEq.DisplayMember = "_cbCatEq";




 
                 }





             }
         }

         private void tbNroSerieCCom_Leave(object sender, EventArgs e)
         {
             cargarSoloEquipoComponente();

         }

         private void tbNroSerieCCom_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == (char)13)
             {

                 Refresh();
                 cargarSoloEquipoComponente();
                 Refresh();



             }

         }


         private void cargarSoloEquipoComponente()
         {
             ModeloDatoDataContext db = new ModeloDatoDataContext();
             int nro_eqXserie = (from T1 in db.Equipos where T1.nro_serie == tbNroSerieCCom.Text && (T1.equipo == "TECLADO" || T1.equipo == "MOUSE" || T1.equipo == "MONITOR")  select T1).Count();

             if (tbNroSerieCCom.Text != string.Empty)//tbNroSerieCCom
             {
                 if (nro_eqXserie > 0)
                 {

                     var sql3 = (from T1 in db.Equipos
                                 join T2 in db.Categorias on T1.cod_categoria equals T2.cod_categoria
                                 where T1.nro_serie == tbNroSerieCCom.Text && (T1.equipo == "TECLADO" || T1.equipo == "MOUSE" || T1.equipo == "MONITOR")

                                 select new
                                 {
                                     _cod_equipo = T1.cod_equipo,

                                     _cbCodCatEq = T1.cod_categoria,

                                     _tbNroSerie = T1.nro_serie,
                                     _tbMarca = T1.marca,
                                     _tbModelo = T1.modelo,
                                     _tbProcesador = T1.procesador,
                                     _tbNroControlPatrimonial = T1.nro_control_patrimonial,
                                     _cbEstadoEquipo = T1.estado,
                                     _tbNroOrdenCompra = T1.nro_orden_compra,
                                     _cbAnioCompra = T1.anio_adquisicion,
                                     _tbIp = T1.ip_equipo,
                                     _tbFuncionamiento = T1.funcionamiento,
                                     _tbObseracion = T1.observacion,
                                     _asignado = T1.activo,
                                     _equipo = T1.equipo,
                                     _cbCatEq = T2.categoria,

                                 }).ToList();

                     // _cod_equipo = sql3[0]._cod_equipo

                     // tbNroSerie.Text = Convert.ToString(sql3[0]._tbNroSerie);

                     tbMarcaCCom.Text = Convert.ToString(sql3[0]._tbMarca);
                     tbModeloCCom.Text = Convert.ToString(sql3[0]._tbModelo);
                     tbProcesadorCCom.Text = Convert.ToString(sql3[0]._tbProcesador);
                     tbNroControlPatrimonialCCom.Text = Convert.ToString(sql3[0]._tbNroControlPatrimonial);
                     cbEstadoEquipoCCom.Text = Convert.ToString(sql3[0]._cbEstadoEquipo);
                     cbAnioCompraCCom.Text = Convert.ToString(sql3[0]._cbAnioCompra.ToString());
                     tbIpCCom.Text = Convert.ToString(sql3[0]._tbIp);
                     tbFuncionamientoCCom.Text = Convert.ToString(sql3[0]._tbFuncionamiento);
                     tbObseracionCCom.Text = Convert.ToString(sql3[0]._tbObseracion);
                     cbAsignadoCCom.Text = Convert.ToString(sql3[0]._asignado);
                     tbNroOrdenCompraCCom.Text = Convert.ToString(sql3[0]._tbNroOrdenCompra);
                     tbNombreEquipoCCom.Text = Convert.ToString(sql3[0]._equipo);
                     


                     cbCatEqCCom.DataSource = sql3;
                     cbCatEqCCom.ValueMember = "_cbCodCatEq";
                     cbCatEqCCom.DisplayMember = "_cbCatEq";





                 }





             }
         }
         private void tbNroSerie_KeyPress(object sender, KeyPressEventArgs e)
         {
            

             if (e.KeyChar == (char)13)
             {
                 
                     Refresh();
                     cargarSoloEquipoRegistradoAES();
                    
                     Refresh();
                 
               

             }
         }
       
        
         private void buttonX20_Click(object sender, EventArgs e)
         {
             Form10MovEquipo form10MovEquipo = new Form10MovEquipo();

             form10MovEquipo.Show();
         }

         private void reflectionImage1_Click(object sender, EventArgs e)
         {

         }

         private void panelEx10_Click(object sender, EventArgs e)
         {

         }

         private void tbNombreEquipo_TextChanged(object sender, EventArgs e)
         {
             ModeloDatoDataContext db = new ModeloDatoDataContext();

             var dtListado = (from T0 in db.Equipos
                              where T0.equipo != "CPU" && T0.equipo != "LAPTOP" && T0.equipo != "IMPRESORA" && T0.equipo != "SCANER"
                              select T0.equipo
                               ).Distinct().ToList();


             //cargar los datos para el autocomplete del textbox
             tbNombreEquipo.AutoCompleteMode = AutoCompleteMode.Suggest;//AutoCompleteMode.SuggestAppend; //Es el mas bonito
             AutoCompleteStringCollection accl = new AutoCompleteStringCollection();
             accl.AddRange(dtListado.ToArray()); //convertimos la lista en un Array 

             tbNombreEquipo.AutoCompleteCustomSource = accl;
             tbNombreEquipo.AutoCompleteSource = AutoCompleteSource.CustomSource;
         }

         private void cbEquipoPadreCodNA_KeyUp(object sender, KeyEventArgs e)
         {
             if (cbCatEqNA.Text != string.Empty && cbCatEqNA.Text == "COMPONENTE")
             {
                 cbEquipoPadreCodNA.Enabled = true;

                 ModeloDatoDataContext db = new ModeloDatoDataContext();

                 var dtListado = (from T0 in db.Equipos
                                  where T0.equipo == "CPU"

                                  select new
                                  {
                                      id = T0.cod_equipo,
                                      listado = "Serie: " + T0.nro_serie + ", NroPatrimonial: " + T0.nro_control_patrimonial,

                                  });
                 /*
                 cbCodEquipoAE.DataSource = sq;
                 cbCodEquipoAE.ValueMember = "id";
                 cbCodEquipoAE.DisplayMember = "concatenado";
                  */


                 string strText;
                 strText = cbEquipoPadreCodNA.Text;
                 if (cbEquipoPadreCodNA.Text == "")
                 {
                     this.cbEquipoPadreCodNA.DataSource = dtListado.ToList();
                     this.cbEquipoPadreCodNA.ValueMember = "Id";
                     this.cbEquipoPadreCodNA.DisplayMember = "listado";
                     cbEquipoPadreCodNA.SelectedIndex = -1;
                     cbEquipoPadreCodNA.DroppedDown = false;



                 }

                 if (strText.Length > 2)
                 {
                     /*
                      * lista.Where(p => p.Nombre.Contains(txtNombre.Text)).ToList();
                      */
                     cbEquipoPadreCodNA.DataSource = (dtListado.Where(p => p.listado.Contains(strText))).ToList();
                     this.cbEquipoPadreCodNA.ValueMember = "Id";
                     this.cbEquipoPadreCodNA.DisplayMember = "listado";



                     if (cbEquipoPadreCodNA.Items.Count != 0)
                     {
                         cbEquipoPadreCodNA.DroppedDown = true;
                         cbEquipoPadreCodNA.SelectedIndex = -1;
                         cbEquipoPadreCodNA.Text = "";
                         cbEquipoPadreCodNA.SelectedText = strText;



                         strText = "";
                         Cursor.Current = Cursors.Default;


                     }
                     else
                     {
                         cbEquipoPadreCodNA.DataSource = dtListado.ToList();
                         cbEquipoPadreCodNA.ValueMember = "Id";
                         cbEquipoPadreCodNA.DisplayMember = "listado";
                         cbEquipoPadreCodNA.SelectedIndex = -1;
                         cbEquipoPadreCodNA.Text = "";
                         cbEquipoPadreCodNA.SelectedText = strText;
                         strText = "";
                         cbEquipoPadreCodNA.DroppedDown = false;



                     }
                 }

             }
           

           
         }

         private void cbCatEqNA_Leave(object sender, EventArgs e)
         {
             if (cbCatEqNA.Text != string.Empty && cbCatEqNA.Text == "COMPONENTE")
             { cbEquipoPadreCodNA.Enabled = true; }
             else
             { cbEquipoPadreCodNA.Enabled = false; }

         }

        
      


        


    }
}

