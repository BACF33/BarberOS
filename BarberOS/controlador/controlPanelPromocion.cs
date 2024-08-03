using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlPanelPromocion
    {
        panelPromocion controladoPanel = null;
        vistaMenu menu = null;

        public controlPanelPromocion(panelPromocion pasadoPanel, vistaMenu pasadoMenu)
        {
            controladoPanel = pasadoPanel;
            menu = pasadoMenu;
            controladoPanel.btnAplicar.Click += (sender, e) => menu.controladorMenu.AbrirFormulario(new vistaRecompensas());
        }
    }
}
