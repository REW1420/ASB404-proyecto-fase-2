using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Empleados
{
    public partial class Paso1Emp : Form
    {
        private Form InicAd;
        public Paso1Emp(Form inicAd)
        {
            InitializeComponent();
            InicAd = inicAd;
            
        }

        public Paso1Emp()
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DirecEmp DiEmp = new DirecEmp(this);
            DiEmp.Show();
        }


        private void BCancelar_Click(object sender, EventArgs e)
        {
            if (InicAd!=null)
            { 
                InicAd.Show();
            }
        }

    }
}
