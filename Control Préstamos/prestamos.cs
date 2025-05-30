using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Préstamos
{
    public partial class Préstamos : Form
    {
        private Form IniEmple1;

        public Préstamos()
        {
        }

        public Préstamos( Form FormIniEmple_)
        {
            InitializeComponent();
            IniEmple1 = FormIniEmple_;
        }

        private void Préstamos_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            if (IniEmple1 != null)
            {
                IniEmple1.Show();
            }
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Préstamo realizado con éxito, el dinero será tranferido a su cuenta en un lapso de 1 a 2 días, ¡Gracias por contar con FonaVit.SV!", "Préstamo Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
