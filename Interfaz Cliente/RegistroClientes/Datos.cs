using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroClientes
{
    
    public partial class DatosCli : Form
    {
        private Form LoginCli;

        public DatosCli()
        {
            InitializeComponent();
        }

        public DatosCli(Form Logincli)
        {
            InitializeComponent();
            LoginCli = Logincli;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(LoginCli != null)
            {
                LoginCli.ShowDialog();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DirecCli FormDirec = new DirecCli(this, LoginCli);
            this.Hide();
            FormDirec.Show();
        }

        
    }
}
