using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioEmpleados
{
    public partial class VerClnts : Form
    {
        public VerClnts()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            IniEmp inicioEmpleados = new IniEmp();
            this.Hide();
            inicioEmpleados.Show();
        }

        private void VerClnts_Load(object sender, EventArgs e)
        {

        }
    }
}
