using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlActualizarRegistro
    {
            DaoActualizarRegistro daoThis;
            public ControlActualizarRegistro(string selectedId, VistaActualizarRegistro pasadaVista)
            {
                pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
                daoThis = new DaoActualizarRegistro(selectedId, pasadaVista);
            }

            public void execUpdate()
            {
                daoThis.update();
            }
    }
}
