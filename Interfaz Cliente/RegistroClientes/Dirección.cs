using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroClientes
{
    public partial class DirecCli : Form
    {
        private Form Paso1;
        private Form LoginC;

        public DirecCli(Form Datos1, Form loginC)
        {
            InitializeComponent();
            Paso1 = Datos1;
            LoginC = loginC;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DatosFCli DatosF = new DatosFCli(this, Paso1, LoginC);
            this.Hide();
            DatosF.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
             Form DatosCli = new DatosCli(this);
            this.Hide();
            DatosCli.Show();
        }


        private void BCancelar4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (LoginC != null)
            {
                LoginC.Show();
            }
        }
    }
}
