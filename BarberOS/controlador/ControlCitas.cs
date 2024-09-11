using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlCitas
    {
        DaoCitas daoThis = new DaoCitas();
        vistaCitas vistaControlada;
        public ControlCitas(vistaCitas vistaPasada) 
        {
            vistaControlada = vistaPasada;
            vistaPasada.btnAgendar.Click += (sender, e) => Agendar();
        }

        public void Agendar() 
        {
            daoThis.Insertar(vistaControlada);
        }
    }
}
