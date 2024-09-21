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
    internal class ControlPanelPromocion
    {
        PanelPromocion controladoPanel = null;
        vistaMenu menu = null;
        DtoPanelProducto seleccionadoProducto = null;
        DtoPanelPromocion infoEste = new DtoPanelPromocion();

        public ControlPanelPromocion(PanelPromocion pasadoPanel, vistaMenu pasadoMenu, DtoPanelProducto pasadoProducto, int testId, string testName, string testPower, string testType)
        {
            //Los valores que se obtuvieron de una fila de la tabla de promociones se le asignaran al panel (control de usuario) de una promocion y se creara el control de usuario

            infoEste.PromocionId = testId;
            infoEste.PromocionName = testName;
            infoEste.PromocionPoder = testPower;
            infoEste.PromocionTipo = testType;

            pasadoPanel.lblName.Text = testName;
            pasadoPanel.lblPoder.Text = testPower;
            pasadoPanel.lblTipo.Text = testType;


            controladoPanel = pasadoPanel;
            menu = pasadoMenu;
            seleccionadoProducto = pasadoProducto;

            //Cuando se presione aplicar se ejecutara evaluarpuntosusuario que lo enviara a la vista para confirmar compra
            controladoPanel.btnAplicar.Click += (sender, e) => evaluarPuntosUsuario();
        }
        public void evaluarPuntosUsuario()
        {
            menu.controladorMenu.AbrirFormulario(new VistaRecompensas(infoEste, menu, seleccionadoProducto));
        }
    }
}
