using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class controlPanelPromocion
    {
        panelPromocion controladoPanel = null;
        vistaMenu menu = null;
        string pasadoName2 = null;
        string pasadoPrecio2 = null;
        public controlPanelPromocion(panelPromocion pasadoPanel, vistaMenu pasadoMenu, string pasadoName, string pasadoPrecio)
        {
            dtoPanelPromocion infoEste = new dtoPanelPromocion();

            //infoEste.PromocionName = passedId;
            //infoEste.BarberoName = passedName;
            //infoEste.BarberoRole = passedRole;





            controladoPanel = pasadoPanel;
            menu = pasadoMenu;
            pasadoName2 = pasadoName;
            pasadoPrecio2 = pasadoPrecio;

            controladoPanel.btnAplicar.Click += (sender, e) => evaluarPuntosUsuario();
        }
        public void evaluarPuntosUsuario()
        {
            //if (menu.controladorMenu.userValues.Points < ) 
            //{ 

            //}
            menu.controladorMenu.AbrirFormulario(new vistaRecompensas(controladoPanel, menu, pasadoName2, pasadoPrecio2));
        }
    }
}
