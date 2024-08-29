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
    internal class ControlListaPromociones
    {
        VistaListaPromociones controladaVista;
        public ControlListaPromociones(VistaListaPromociones enviadaVista, vistaMenu pasadoMenu, DtoPanelProducto seleccionadoProducto)
        {
            controladaVista = enviadaVista;
            DaoListaPromociones daoThis = new DaoListaPromociones(enviadaVista, pasadoMenu, seleccionadoProducto);
        }
    }
}
