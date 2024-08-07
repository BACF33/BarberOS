using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using BarberOS.Vistas;
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
    internal class controlAgregarPersonal
    {
        vistaAgregarPersonal controladaVista = null;
        public controlAgregarPersonal(vistaAgregarPersonal pasadaVista)
        {
            controladaVista = pasadaVista;
            controladaVista.btnAgregar.Click += (sender, e) => agregarPersonal();
        }

        public void agregarPersonal() 
        {
            daoAgregarPersonal daoThis = new daoAgregarPersonal(controladaVista);
        }
    }
}
