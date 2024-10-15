using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class ControlListaPersonal
    {
        public ControlListaPersonal(VistaListaPersonal enviadaVista) 
        {
            //Solo se ejecutara la funcion del constructor del dao para obtener los personales
            DaoListaPersonal daoThis = new DaoListaPersonal(enviadaVista);
        }
    }
}
