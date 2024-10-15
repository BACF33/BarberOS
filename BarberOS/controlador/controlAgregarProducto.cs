using BarberOS.Modelo.Dao;
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
    internal class ControlAgregarProducto
    {
        VistaAgregarProducto controladaVista = null;
        public ControlAgregarProducto(VistaAgregarProducto pasadaVista)
        {
            controladaVista = pasadaVista;
            //Cuando se presion agregar se ejecutara la funcion agregarProducto
            controladaVista.btnAgregar.Click += (sender, e) => agregarProducto();
        }

        public void agregarProducto()
        {
            //Se ejecutara el constructor de daoAgregarProducto para agregar los queries
            DaoAgregarProducto daoThis = new DaoAgregarProducto(controladaVista);
        }
    }
}
