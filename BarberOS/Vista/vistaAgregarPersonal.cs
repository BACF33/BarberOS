using BarberOS.Controlador;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaAgregarPersonal : Form
    {
        public VistaAgregarPersonal()
        {
            InitializeComponent();
            ControlAgregarPersonal controladorVista = new ControlAgregarPersonal(this);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        private void nuevoNombreV(object sender, KeyPressEventArgs e)
        {
            if (txtNuevoNombre.TextLength > 49)
                e.Handled = true;
        }

        private void nuevosPuntosV(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (txtNuevoFull.TextLength > 5)
                e.Handled = true;
        }

        private void nuevoNumeroV(object sender, KeyPressEventArgs e)
        {
            if (txtNuevoNumero.TextLength > 49)
                e.Handled = true;
        }

        private void nuevaContraseñaV(object sender, KeyPressEventArgs e)
        {
            if (txtNuevaContraseña.TextLength > 499)
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
