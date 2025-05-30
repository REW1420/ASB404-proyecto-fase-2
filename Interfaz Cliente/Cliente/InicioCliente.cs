using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Transacciones;
using Control_Préstamos;

namespace Cliente
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoginCli FormLogin = new LoginCli(this);
            this.Hide();
            FormLogin.ShowDialog();
        }

        private void Transacción_Click(object sender, EventArgs e)
        {
            Form Transacts= new Transacción(this);
            this.Hide();
            Transacts.Show();

        }

        private void Préstamo_Click(object sender, EventArgs e)
        {
            Préstamos Prestamos = new Préstamos(this);
            this.Hide();
            Prestamos.Show();
        }

        private void Movimientos_Click(object sender, EventArgs e)
        {
            Form Historial = new Historial();
            this.Hide();
            Historial.Show();
        }

    }
}
