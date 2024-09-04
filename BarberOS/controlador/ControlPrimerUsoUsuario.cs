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
        public ControlPrimerUsoUsuario(VistaPrimerUsoUsuario vistaPasada)
        {
            vistaPasada.btnEnviar.Click += (sender, e) => RegistrarFormulario();
        }
        public void RegistrarFormulario()
        {
          
        }
    }
}
