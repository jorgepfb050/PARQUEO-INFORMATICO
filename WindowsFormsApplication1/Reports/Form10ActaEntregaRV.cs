using System;
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
    public partial class Form10ActaEntregaRV : Form
    {
        public Form10ActaEntregaRV()
        {
            InitializeComponent();
        }

        private void Form10ActaEntregaRV_Load(object sender, EventArgs e)
        {

            this.RVActaEntrega.RefreshReport();
        }
    }
}
