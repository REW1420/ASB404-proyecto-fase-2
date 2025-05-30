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

namespace Cliente
{
    public partial class LoginCli : Form
    {
        private Form DatosC;

        public LoginCli(Form DatosCl)
        {
            InitializeComponent();
            DatosC = DatosCl;
        }

        public LoginCli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio IniCli = new Inicio();
            this.Hide();
            IniCli.ShowDialog();
        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            DatosCli Datoscl = new DatosCli(this);
            this.Hide();
            Datoscl.ShowDialog();

        }
    }
}
