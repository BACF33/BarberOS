using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlAgregarPromocion
    {
        VistaAgregarPromocion controladaVista = null;
        public ControlAgregarPromocion (VistaAgregarPromocion pasadaVista)
        {
            controladaVista = pasadaVista;
            //Cuando se presion agregar se ejecutara la funcion agregarPersonal
            controladaVista.btnAgregar.Click += (sender, e) => agregarPersonal();
        }

        public void agregarPersonal()
        {
            //Se ejecutara el constructor del dao donde se agregaran los queries
            DaoAgregarPromocion daoThis = new DaoAgregarPromocion(controladaVista);
        }
    }
}
