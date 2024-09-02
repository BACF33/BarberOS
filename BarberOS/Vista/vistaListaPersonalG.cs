using BarberOS.Controlador;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaListaPersonalG : Form
    {
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

        private void btnACortes_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarEmpleados2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VistaListaPersonalG_Load(object sender, EventArgs e)
        {

        }
    }
}
