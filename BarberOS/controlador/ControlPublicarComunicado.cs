﻿using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlPublicarComunicado
    {
        DaoPublicarComunicado daoThis = new DaoPublicarComunicado();

        public ControlPublicarComunicado(VistaPublicarComunicado vistaPasada) 
        {
            daoThis.Obtener(vistaPasada);
        }
    }
}
