using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class ControlAsignaciones
    {
        DaoAsignaciones daoThis = new DaoAsignaciones();
        public ControlAsignaciones(VistaAsignaciones pasadaVista, vistaMenu pasadoMenu) 
        {
            MessageBox.Show("test");
            daoThis.Obtener(pasadoMenu, pasadaVista);
            pasadaVista.btnVolver.Click += (sender, e) => pasadoMenu.controladorMenu.AbrirFormulario(new VistaInicioBarbero(pasadoMenu));
        }
    }
}
