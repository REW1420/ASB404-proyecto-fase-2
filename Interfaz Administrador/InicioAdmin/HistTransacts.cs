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
    public partial class HistTransacts : Form
    {
        private Form IniAdmin;
        public HistTransacts(Form iniAdmin)
        {
            InitializeComponent();
            IniAdmin = iniAdmin;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (IniAdmin != null)
            {
                IniAdmin.Show();
            }
        }
    }
}
