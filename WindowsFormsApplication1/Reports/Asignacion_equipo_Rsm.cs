﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Reports
{
    public partial class Asignacion_equipo_Rsm : Form
    {
        public Asignacion_equipo_Rsm()
        {
            InitializeComponent();
        }

        private void Asignacion_equipo_Rsm_Load(object sender, EventArgs e)
        {       
                     
            this.rvAsignacionEquipo_Rsm.RefreshReport();
        }
    }
}
