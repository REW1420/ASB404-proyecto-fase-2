using Registro_Empleados;
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
    public partial class VerEmp : Form
    {
        private Form InicAdmin;
      
        public VerEmp(Form inicAdmin)
        {
            InitializeComponent();
            InicAdmin = inicAdmin;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (InicAdmin != null)
            { 
                InicAdmin.Show();
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {

        }
    }
}
