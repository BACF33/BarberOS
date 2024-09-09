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
            vistaPasada.btnEnviar.Click += (sender, e) => RegistrarFormulario(vistaPasada);
        }
        public void RegistrarFormulario(VistaPrimerUsoUsuario vistaPasada)
        {
            primer.Registrar(vistaPasada);
            porNegocio.PrimerNegocio(control);
            
        }
    }
}
