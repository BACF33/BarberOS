using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlListaPregunas
    {
        DaoListaPreguntas daoThis = new DaoListaPreguntas();
        vistaListaPreguntas vistaControlada;
        public ControlListaPregunas(vistaListaPreguntas vistaPasada) 
        {
            vistaPasada.btnAgregar.Click += (sender, e) => daoThis.insertar(vistaPasada);
        }
    }
}
