using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlOrdenes
    {
        DaoOrdenes daoThis = new DaoOrdenes();

        public ControlOrdenes(vistaMenu pasadoMenu, VistaOrdenes vistaPasada) 
        {
            daoThis.Populate(vistaPasada);
            daoThis.PopulateUsers(vistaPasada);

            vistaPasada.btnAgregar.Click += (sender, e) =>
            {
                daoThis.Insert(vistaPasada);
                daoThis.Populate(vistaPasada);
            };

            vistaPasada.btnActualizar2.Click += (sender, e) =>
            {
                daoThis.Update(vistaPasada);
                daoThis.Populate(vistaPasada);
            };

            vistaPasada.btnBorrar.Click += (sender, e) =>
            {
                daoThis.Delete(vistaPasada);
                daoThis.Populate(vistaPasada);
            };
        }
    }
}
