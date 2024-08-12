using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class controlListaPromociones
    {
        vistaListaPromociones controladaVista;
        public controlListaPromociones(vistaListaPromociones enviadaVista, vistaMenu pasadoMenu, dtoPanelProducto seleccionadoProducto)
        {
            controladaVista = enviadaVista;
            daoListaPromociones daoThis = new daoListaPromociones(enviadaVista, pasadoMenu, seleccionadoProducto);
        }
    }
}
