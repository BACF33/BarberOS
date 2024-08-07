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
    internal class controlAgregarPromocion
    {
        vistaAgregarPromocion controladaVista = null;
        public controlAgregarPromocion (vistaAgregarPromocion pasadaVista)
        {
            controladaVista = pasadaVista;
            controladaVista.btnAgregar.Click += (sender, e) => agregarPersonal();
        }

        public void agregarPersonal()
        {
            daoAgregarPromocion daoThis = new daoAgregarPromocion(controladaVista);
        }
    }
}
