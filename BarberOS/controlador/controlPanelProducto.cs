using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlPanelProducto
    {
        panelProducto controladoPanel = null;
        vistaMenu menu = null;
        public controlPanelProducto(panelProducto pasadoPanel, vistaMenu pasadoMenu)
        {
            controladoPanel = pasadoPanel;
            menu = pasadoMenu;
            controladoPanel.btnComprar.Click += (sender, e) => menu.controladorMenu.AbrirFormulario(new vistaListaPromociones(menu));
        }
    }
}
