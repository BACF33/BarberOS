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
            //Solo se ejecutara la funcion del constructor del dao para obtener los comunicados
            daoThis.Obtener(vistaPasada);
        }
    }
}
