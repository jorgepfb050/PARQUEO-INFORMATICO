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
using WindowsFormsApplication1.Reports;


namespace WindowsFormsApplication1.Reports
{
    public partial class FormListaEquipo : Form
    {
        public FormListaEquipo()
        {
            InitializeComponent();
        }

        public int keyEquipo=0;
        public string nombre_equipo = string.Empty;
        public string serie = string.Empty;

        private void FormListaEquipo_Load(object sender, EventArgs e)
        {
            CTEquipo ctequipo = new CTEquipo();
            dgvEquipo.AutoGenerateColumns = false;
            dgvEquipo.DataSource = ctequipo.listar();
        }

        private void dgvEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void tbBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            buscarEquipo();
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

           

            Close();         


        }

       

        private void FormListaEquipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form10MovEquipo form = new Form10MovEquipo();
            form.keyEquipo = keyEquipo;
            form.nombre_equipo = nombre_equipo;
            form.serie = serie;
            form.tbEquipo.Text = nombre_equipo;
            
          

        }
       
        private void FormListaEquipo_FormClosed(object sender, FormClosedEventArgs e)
        {

            Form10MovEquipo form = new Form10MovEquipo();
            form.keyEquipo = keyEquipo;
            form.nombre_equipo = nombre_equipo;
            form.serie = serie;
            form.tbEquipo.Text = nombre_equipo;
            
        }


    }
}
