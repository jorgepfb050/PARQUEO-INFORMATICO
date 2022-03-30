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
    public partial class FormSoftRep : Form
    {
        public FormSoftRep()
        {
            InitializeComponent();
        }

        private void FormSoftRep_Load(object sender, EventArgs e)
        {

            this.RVSoftware.RefreshReport();
        }
    }
}
