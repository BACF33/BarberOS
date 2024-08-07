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
            pasadaVista.btnActualizar.Click += (sender, e) => execUpdate();
            daoThis = new daoActualizarCorte(selectedId, pasadaVista);
        }

        public void execUpdate()
        {
            daoThis.update();
        }
    }
}