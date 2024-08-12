using BarberOS.Controlador;
using BarberOS.Modelo.Dto;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class panelPromocion : UserControl
    {
        vistaMenu vistaMenua = null;
        public panelPromocion(vistaMenu pasadoMenu, dtoPanelProducto seleccionadoProducto, int testId, string testName, string testPower, string testType)
        {
            InitializeComponent();
            vistaMenua = pasadoMenu;
            controlPanelPromocion controladorVista = new controlPanelPromocion(this, pasadoMenu, seleccionadoProducto, testId, testName, testPower, testType);
        }

    }
}
