using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlActualizarCortes
    {
        DaoActualizarCorte daoThis;
        public ControlActualizarCortes(string selectedId, VistaActualizarCortes pasadaVista) 
        {
            //Cuando se presione el botnon actualizar del formulario vistaActualizarortes se ejecutara la funcion execUpdate
            pasadaVista.btnActualizar.Click += (sender, e) => ExecUpdate();
            //Se ejecutara la el constructor del daoActualizarCorte
            daoThis = new DaoActualizarCorte(selectedId, pasadaVista);
        }

        public void ExecUpdate()
        {
            //Se ejecutara la funcion update del presente dao
            daoThis.update();
        }
    }
}