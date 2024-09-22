using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlListaComunicadosG
    {
        DaoListaComunicadosG daoThis = new DaoListaComunicadosG();
        VistaListaComunicadosG vistaControlada;

        public ControlListaComunicadosG(VistaListaComunicadosG vistaPasada, vistaMenu menuPasado) 
        {
            vistaControlada = vistaPasada;
            daoThis.Obtener(vistaControlada);
            vistaPasada.btnAgregar.Click += (sender, e) => Agregar();
        }

        public void Agregar() 
        {
            daoThis.Agregar(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }
    }
}
