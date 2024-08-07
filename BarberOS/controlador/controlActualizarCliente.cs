using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlActualizarCliente
    {
        daoActualizarCliente daoThis;
        public controlActualizarCliente(string selectedId, vistaActualizarCliente pasadaVista)
        {
            pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
            daoThis = new daoActualizarCliente(selectedId, pasadaVista);
        }

        public void execUpdate()
        {
            daoThis.update();
        }
    }
}
