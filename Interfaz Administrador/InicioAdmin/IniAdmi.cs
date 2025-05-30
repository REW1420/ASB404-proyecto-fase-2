using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Empleados;

namespace InicioAdmin
{
    public partial class IniAdmi : Form
    {
        public IniAdmi()
        {
            InitializeComponent();

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginAdmin Login = new LoginAdmin();
            this.Hide();
            Login.ShowDialog();
        }

        private void VerEmp_Click(object sender, EventArgs e)
        {
            VerEmp visEmp= new VerEmp(this);
            this.Hide();
            visEmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerClientes verClientes = new VerClientes(this);
            this.Hide();
            verClientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Paso1Emp datosEmp = new Paso1Emp(this);
            this.Hide();
            datosEmp.Show();
        }

        private void HistTra_Click(object sender, EventArgs e)
        {
            HistTransacts histTransacts = new HistTransacts(this);
            this.Hide();
            histTransacts.Show();
        }

       
    }
}
