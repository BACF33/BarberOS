using BarberOS.Controlador;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaListaPersonalG : Form
    {
     //Test
     public VistaListaPersonalG(vistaMenu menuForm)
        {
            InitializeComponent();
            ControlListaPersonalG controladorVista = new ControlListaPersonalG(this, menuForm);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void SoloPuntos(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Test
        private void btnACortes_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
