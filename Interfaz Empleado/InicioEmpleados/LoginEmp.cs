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
    public partial class LoginEmp : Form
    {
        public LoginEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniEmp Inicio = new IniEmp();
            this.Hide();
            Inicio.Show();
        }
    }
}
