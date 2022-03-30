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
    public partial class Form9Perfil : Form
    {
        public Form9Perfil()
        {
            InitializeComponent();
        }

        private void Form9Perfil_Load(object sender, EventArgs e)
        {

            this.RVPerfil.RefreshReport();
        }
    }
}
