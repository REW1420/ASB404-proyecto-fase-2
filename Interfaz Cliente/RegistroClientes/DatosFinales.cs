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
    public partial class DatosFCli : Form
    {
        private Form Paso1;
        private Form Paso2;
        private Form Login;
        public DatosFCli(Form Paso1datos, Form Paso2Dir, Form login)
        {
            InitializeComponent();
            Paso1 = Paso1datos;
            Paso2 = Paso2Dir;
            Login = login;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DirecCli Direc = new DirecCli(this, Paso1);
            this.Hide();
            Direc.Show();
        }

        private void BCancelar5_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Login != null)
            { 
                Login.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.SelectedItem.ToString(), out int cantidad))
            { 
                for (int i=1; i<=4; i++)
                {
                    this.Controls.Find("Bene" + i, true).FirstOrDefault()?.Hide();
                    this.Controls.Find("LblParent"+i, true).FirstOrDefault()?.Hide();
                    this.Controls.Find("TxtNomCom" + i, true).FirstOrDefault()?.Hide();
                    this.Controls.Find("Parentesco" + i, true).FirstOrDefault()?.Hide();
                }

                for (int i=1; i<=cantidad; i++) 
                {
                    this.Controls.Find("Bene" + i, true).FirstOrDefault()?.Show();
                    this.Controls.Find("LblParent" + i, true).FirstOrDefault()?.Show();
                    this.Controls.Find("TxtNomCom" + i, true).FirstOrDefault()?.Show();
                    this.Controls.Find("Parentesco" + i, true).FirstOrDefault()?.Show();

                }

                float porcentaje=100f/cantidad;
                LblPorcentaje.Text = $"El {porcentaje:0.##}% de tus finanzas serán atribuidos a tus beneficiarios si falleces";
            }
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuenta creada con éxito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
