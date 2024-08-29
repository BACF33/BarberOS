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
    public partial class VistaActualizarPromocion : Form
    {
        public VistaActualizarPromocion(string selectedId)
        {
            InitializeComponent();
            ControlActualizarPromocion controladorVista = new ControlActualizarPromocion(selectedId, this);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        private void nuevoNombreV(object sender, KeyPressEventArgs e)
        {
            if (txtNNProducto.TextLength > 49)
                e.Handled = true;
        }

        private void nuevoDescuentoV(object sender, KeyPressEventArgs e)
        {
            if (txtNNPromocion.TextLength > 49)
                e.Handled = true;
        }

        private void nuevoPrecioV(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (txtPNProducto.TextLength > 5)
                e.Handled = true;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
