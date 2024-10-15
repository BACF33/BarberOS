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
            //Cuando se presione enviar se ejecutara la funcion registrar donde se registrara el nogicio asociado
            vistaPasada.btnEnviar.Click += (sender, e) => daoThis.Registrar(vistaPasada);
        }
    }
}
