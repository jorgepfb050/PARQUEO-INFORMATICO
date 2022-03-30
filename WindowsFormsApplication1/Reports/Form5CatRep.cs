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
    public partial class Form5CatRep : Form
    {
        public Form5CatRep()
        {
            InitializeComponent();
        }

        private void Form5CatRep_Load(object sender, EventArgs e)
        {

            this.RVCategoria.RefreshReport();
        }
    }
}
