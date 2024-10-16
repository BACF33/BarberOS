﻿using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlInicioBarbero
    {
        public ControlInicioBarbero(VistaInicioBarbero vistaPasada, vistaMenu menuPasado) 
        {
            vistaPasada.btnCortes.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaPublicarComunicado(menuPasado));
            vistaPasada.btnOrdenes.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaOrdenes(menuPasado));
        }
    }
}
