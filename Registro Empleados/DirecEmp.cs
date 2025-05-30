using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Empleados
{
    public partial class DirecEmp : Form
    {
        private Form InicAdmin;

        public DirecEmp(Form IniAd)
        {
            InitializeComponent();
            InicAdmin = IniAd;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paso1Emp paso1 = new Paso1Emp();
            paso1.Show();
        }


        private void BCancelar2_Click(object sender, EventArgs e)
        {
            if (InicAdmin!= null)
            { 
                InicAdmin.Show();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado ha sido registrado con éxito", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (InicAdmin != null)
            {
                InicAdmin.Show();
            }
        }
    }
}
