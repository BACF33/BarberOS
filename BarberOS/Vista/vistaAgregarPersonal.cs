using BarberOS.Controlador;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaAgregarPersonal : Form
    {
        public vistaAgregarPersonal()
        {
            InitializeComponent();
            controlAgregarPersonal controladorVista = new controlAgregarPersonal(this);
        }
    }
}
