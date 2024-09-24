using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlActualizarPersonal
    {
        DaoActualizarPersonal daoThis;
        public ControlActualizarPersonal(string selectedId, VistaActualizarPersonal pasadaVista)
        {
            //Si se presiona actualizar se ejecutara la funcion execUpdate)
            pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
            //5 Se ejecutara el constructor del dao
            daoThis = new DaoActualizarPersonal(selectedId, pasadaVista);
        }

        public void execUpdate()
        {
            //5 Se ejecutara la funcion update del dao
            daoThis.update();
        }
    }
}
