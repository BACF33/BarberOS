using BarberOS.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaListaPromocionesG : Form
    {
        public VistaListaPromocionesG(vistaMenu passedMenu)
        {
            InitializeComponent();
            ControlListaPromocionesG controladorVista = new ControlListaPromocionesG(this, passedMenu);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarPromocion2_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarPromocion_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarPromocion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPromocion_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
