using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlActualizarPromocion
    {
        DaoActualizarPromocion daoThis;
        public ControlActualizarPromocion(string selectedId, VistaActualizarPromocion pasadaVista)
        {
            //Cuando se presione el boton actualizar se ejecutara la funcion execUpdate
            pasadaVista.btnActualizar.Click += (sender, e) => ExecUpdate();
            //Se ejecutara el constructor de daoActualizarPromocion
            daoThis = new DaoActualizarPromocion(selectedId, pasadaVista);
        }

        public void ExecUpdate()
        {
            //Se ejecutara la funcion update del dao
            daoThis.update();
        }
    }
}
