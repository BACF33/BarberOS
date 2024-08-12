using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlActualizarRegistro
    {
            daoActualizarRegistro daoThis;
            public controlActualizarRegistro(string selectedId, vistaActualizarPromocion pasadaVista)
            {
                pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
                //daoThis = new daoActualizarRegistro(selectedId, pasadaVista);
            }

            public void execUpdate()
            {
                //daoThis.update();
            }
    }
}
