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
            //Si se presiona actualizar se ejecutara la funcion execUpdate)
            pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
            //5 Se ejecutara el constructor del dao
            daoThis = new daoActualizarCliente(selectedId, pasadaVista);
        }

        public void execUpdate()
        {
            //5 Se ejecutara la funcion update del dao
            daoThis.update();
        }
    }
}