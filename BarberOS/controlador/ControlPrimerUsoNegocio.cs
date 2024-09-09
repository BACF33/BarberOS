using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlPrimerUsoNegocio
    {
        DaoPrimerUsoNegocio daoThis = new DaoPrimerUsoNegocio();
        public ControlPrimerUsoNegocio(VistaPrimerUsoNegocio vistaPasada) 
        {
            vistaPasada.btnEnviar.Click += (sender, e) => daoThis.Registrar(vistaPasada);
        }
    }
}
