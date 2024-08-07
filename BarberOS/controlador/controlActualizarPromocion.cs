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
            pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
            daoThis = new daoActualizarPromocion(selectedId, pasadaVista);
        }

        public void execUpdate()
        {
            daoThis.update();
        }
    }
}
