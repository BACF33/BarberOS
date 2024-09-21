using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlPrimerUsoUsuario
    {
        DaoPrimerUsoUsuario primer = new DaoPrimerUsoUsuario();
        DaoMenu porNegocio = new DaoMenu();
        ControlMenu control;
        public ControlPrimerUsoUsuario(VistaPrimerUsoUsuario vistaPasada, ControlMenu pasadoControl)
        {
            control = pasadoControl;
            //Cuando se presione enviar se ejecutararegistrarformulario
            vistaPasada.btnEnviar.Click += (sender, e) => RegistrarFormulario(vistaPasada);
        }
        public void RegistrarFormulario(VistaPrimerUsoUsuario vistaPasada)
        {
            //Se ejecutara la funcion registrar del dao
            primer.Registrar(vistaPasada);
            //Se verificara si ademas no hay un negocio vinculado
            porNegocio.PrimerNegocio(control);
            
        }
    }
}
