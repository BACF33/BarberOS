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
        }
    }
}
