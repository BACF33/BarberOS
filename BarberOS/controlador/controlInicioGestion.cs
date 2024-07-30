using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlInicioGestion
    {
        vistaInicioGestion controladaVista;
        vistaMenu menuForm;
        public controlInicioGestion(vistaInicioGestion vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;
            controladaVista.btnPersonal.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaPersonalG(menuForm));
        }
    }
}
