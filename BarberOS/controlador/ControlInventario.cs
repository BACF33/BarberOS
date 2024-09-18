using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlInventario
    {
        vistaMenu menuControlado;
        VistaInventario vistaControlada;
        DaoInventario daoThis = new DaoInventario();

        public ControlInventario(vistaMenu menuPasado, VistaInventario vistaPasada) 
        {
            menuControlado = menuPasado;
            vistaControlada = vistaPasada;

            daoThis.Obtener(vistaControlada);

            vistaPasada.btnAgregar.Click += (sender, e) => Insert();
        }

        public void Insert()
        {
            daoThis.Insert(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }

        public void Delete() 
        {
            //daoThis.
            //daoThis.Obtener(vistaControlada);
        }
    }
}
