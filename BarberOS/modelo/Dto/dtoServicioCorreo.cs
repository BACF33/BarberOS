using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dto
{
    public class dtoServicioCorreo : dtoRecuperar
    {
        public dtoServicioCorreo() 
        {
            remitente = "bacubias76@gmail.com";
            password = "czfn rlzl hveh ifan";
            host = "smtp.gmail.com";
            ssl = true;
            IniciarCliente();
        }
    }
}
