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
    internal class controlListaPersonal
    {
        vistaListaPersonal controladaVista;
        public controlListaPersonal(vistaListaPersonal enviadaVista) 
        {
            controladaVista = enviadaVista;

            daoListaPersonal daoThis = new daoListaPersonal(enviadaVista);
        }
    }
}
