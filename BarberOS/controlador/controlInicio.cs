﻿using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    //Test
    internal class ControlInicio
    {
        VistaInicio controladaVista = null;
        vistaMenu menuForm;
        public ControlInicio(VistaInicio vistaPasada, vistaMenu passedMenu)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenu;

            controladaVista.btnBarberos.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaCortes(menuForm));
            controladaVista.btnBarberos.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaPersonal());
        }
    }
}
