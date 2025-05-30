using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Transacciones
{
    public partial class Transacción : Form
    {
        private Form FormIniCli;

        public Transacción()
        {
        }

        public Transacción(Form _FormInicli)
        {
            InitializeComponent();
            FormIniCli = _FormInicli;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            this.Close();

            if(FormIniCli != null)
            {
                FormIniCli.Show();
            }


        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transacción realizada con éxito", "Transacción Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
