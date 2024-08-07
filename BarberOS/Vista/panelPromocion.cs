using BarberOS.Controlador;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class panelPromocion : UserControl
    {
        vistaMenu vistaMenua = null;
        public panelPromocion(vistaMenu pasadoMenu, string pasadoName, string pasadoPrecio)
        {
            InitializeComponent();
            vistaMenua = pasadoMenu;
            controlPanelPromocion controladorVista = new controlPanelPromocion(this, pasadoMenu, pasadoName, pasadoPrecio);
        }

    }
}
