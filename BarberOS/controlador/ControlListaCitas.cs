using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlListaCitas
    {
        DaoListaCitas daoThis = new DaoListaCitas();
        VistaListaAgendas vistaControlada;
        public ControlListaCitas(VistaListaAgendas vistaPasada) 
        {
            vistaControlada = vistaPasada;
            daoThis.Populate(vistaPasada);
            vistaPasada.btnBorrar.Click += (sender, e) => Delete();
        }

        public void Delete()
        {
            daoThis.Delete(vistaControlada);
            daoThis.Populate(vistaControlada);
        }
    }
}
