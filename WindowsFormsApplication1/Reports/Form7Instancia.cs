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
    public partial class Form7Instancia : Form
    {
        public Form7Instancia()
        {
            InitializeComponent();
        }

        private void Form6Instancia_Load(object sender, EventArgs e)
        {

            this.RVInstancia.RefreshReport();
        }
    }
}
