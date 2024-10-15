using BarberOS.Controlador;
using BarberOS.Modelo.Dto;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class PanelPromocion : UserControl
    {
        vistaMenu vistaMenua = null;
        public PanelPromocion(vistaMenu pasadoMenu, DtoPanelProducto seleccionadoProducto, int testId, string testName, string testPower, string testType)
        {
            InitializeComponent();
            vistaMenua = pasadoMenu;
            ControlPanelPromocion controladorVista = new ControlPanelPromocion(this, pasadoMenu, seleccionadoProducto, testId, testName, testPower, testType);
        }

    }
}
