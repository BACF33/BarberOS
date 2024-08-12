﻿using BarberOS.Modelo.Dto;
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
        dtoPanelProducto seleccionadoProducto = null;
        dtoPanelPromocion infoEste = new dtoPanelPromocion();

        public controlPanelPromocion(panelPromocion pasadoPanel, vistaMenu pasadoMenu, dtoPanelProducto pasadoProducto, int testId, string testName, string testPower, string testType)
        {

            infoEste.PromocionId = testId;
            infoEste.PromocionName = testName;
            infoEste.PromocionPoder = testPower;
            infoEste.PromocionTipo = testType;

            controladoPanel = pasadoPanel;
            menu = pasadoMenu;
            seleccionadoProducto = pasadoProducto;

            controladoPanel.btnAplicar.Click += (sender, e) => evaluarPuntosUsuario();
        }
        public void evaluarPuntosUsuario()
        {
            menu.controladorMenu.AbrirFormulario(new vistaRecompensas(infoEste, menu, seleccionadoProducto));
        }
    }
}
