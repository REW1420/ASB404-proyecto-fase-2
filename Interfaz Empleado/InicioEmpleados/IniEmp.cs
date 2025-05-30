using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroClientes;
using Registro_Transacciones;
using Control_Préstamos;

namespace InicioEmpleados
{
    public partial class IniEmp : Form
    {

        public IniEmp()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginEmp loginEmp = new LoginEmp();
            this.Hide();
            loginEmp.Show();
        }

        private void RegCli_Click(object sender, EventArgs e)
        {
            Form Datos = new DatosCli(this);
            this.Hide();
            Datos.Show();
        }

        private void VerClientes_Click(object sender, EventArgs e)
        {
            VerClnts VerClientes= new VerClnts();
            this.Hide();
            VerClientes.Show();
        }

        private void Transacción_Click(object sender, EventArgs e)
        {
            Transacción Transacts= new Transacción(this);
            this.Hide();
            Transacts.Show();
        }

        private void Préstamo_Click(object sender, EventArgs e)
        {
            Préstamos préstamo = new Préstamos(this);
            this.Hide();
            préstamo.Show();
        }

        

    }
}
