using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlActualizarPromocion
    {
        daoActualizarPromocion daoThis;
        public controlActualizarPromocion(string selectedId, vistaActualizarPromocion pasadaVista)
        {
            //Cuando se presione el boton actualizar se ejecutara la funcion execUpdate
            pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
            //Se ejecutara el constructor de daoActualizarPromocion
            daoThis = new daoActualizarPromocion(selectedId, pasadaVista);
        }

        public void execUpdate()
        {
            //Se ejecutara la funcion update del dao
            daoThis.update();
        }
    }
}
