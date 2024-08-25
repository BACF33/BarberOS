using BarberOS.Controlador;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaListaClientesG : Form
    {
        public vistaListaClientesG(vistaMenu passedMenu)
        {
            InitializeComponent();
            //1 El formulario creara su controlador
            controlListaClientesG controladorVista = new controlListaClientesG(this, passedMenu);
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
    }
}
