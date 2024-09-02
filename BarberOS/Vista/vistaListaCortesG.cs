using BarberOS.Controlador;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaListaCortesG : Form
    {
        public VistaListaCortesG(vistaMenu menuForm)
        {
            InitializeComponent();
            ControlListaCortesG controladorVista = new ControlListaCortesG(this, menuForm);
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

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAPersonal_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VistaListaCortesG_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }

}