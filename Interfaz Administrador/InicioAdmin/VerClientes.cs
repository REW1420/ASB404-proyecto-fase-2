using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioAdmin
{
    public partial class VerClientes : Form
    {
        private Form Inicadmin;
        public VerClientes(Form inicadmin)
        {
            InitializeComponent();
            Inicadmin = inicadmin;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Inicadmin != null)
            {
                Inicadmin.Show();
            }
        }
    }
}
