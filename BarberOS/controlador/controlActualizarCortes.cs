using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlActualizarCortes
    {
        daoActualizarCorte daoThis;
        public controlActualizarCortes(string selectedId, vistaActualizarCortes pasadaVista) 
        {
            //Cuando se presione el botnon actualizar del formulario vistaActualizarortes se ejecutara la funcion execUpdate
            pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
            //Se ejecutara la el constructor del daoActualizarCorte
            daoThis = new daoActualizarCorte(selectedId, pasadaVista);
        }

        public void execUpdate()
        {
            //Se ejecutara la funcion update del presente dao
            daoThis.update();
        }
    }
}