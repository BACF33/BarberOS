using BarberOS.Controlador;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaListaClientesG : Form
    {
        public VistaListaClientesG(vistaMenu passedMenu)
        {
            InitializeComponent();
            //1 El formulario creara su controlador
            ControlListaClientesG controladorVista = new ControlListaClientesG(this, passedMenu);
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

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
