using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlNuevoPost
    {
        DaoNuevoPost daoThis = new DaoNuevoPost();

        public ControlNuevoPost(VistaNuevoPost vistaPasada, vistaMenu menuPasado) 
        {
            daoThis.Obtener(vistaPasada, menuPasado);
            vistaPasada.btnPost.Click += (sender, e) =>
            {
                daoThis.Insertar(vistaPasada, menuPasado);
                menuPasado.controladorMenu.AbrirFormulario(new VistaPublicarComunicado(menuPasado));
            };
        }
    }
}
