using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlComunicados
    {
        DaoComunicados daoThis = new DaoComunicados();
        public ControlComunicados(VistaComunicados vistaPasada) 
        {
            daoThis.Obtener(vistaPasada);


        }
    }
}
