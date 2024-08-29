using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlActualizarCliente
    {
        DaoActualizarCliente daoThis;
        public ControlActualizarCliente(string selectedId, VistaActualizarCliente pasadaVista)
        {
            //Si se presiona actualizar se ejecutara la funcion ExecUpdate)
            pasadaVista.btnActualizar.Click += (sender, e) => ExecUpdate();
            //5 Se ejecutara el constructor del dao
            daoThis = new DaoActualizarCliente(selectedId, pasadaVista);
        }

        public void ExecUpdate()
        {
            //5 Se ejecutara la funcion update del dao
            daoThis.Update();
        }
    }
}