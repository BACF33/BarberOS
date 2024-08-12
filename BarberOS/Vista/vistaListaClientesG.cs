using BarberOS.Controlador;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaListaClientesG : Form
    {
        public vistaListaClientesG(vistaMenu passedMenu)
        {
            InitializeComponent();
            controlListaClientesG controladorVista = new controlListaClientesG(this, passedMenu);
        }
    }
}
