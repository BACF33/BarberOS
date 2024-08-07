using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlActualizarPersonal
    {
        daoActualizarPersonal daoThis;
        public controlActualizarPersonal(string selectedId, vistaActualizarPersonal pasadaVista)
        {
            pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
            daoThis = new daoActualizarPersonal(selectedId, pasadaVista);
        }

        public void execUpdate()
        {
            daoThis.update();
        }
    }
}
