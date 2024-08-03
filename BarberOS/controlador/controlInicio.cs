using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class controlInicio
    {
        vistaInicio controladaVista = null;
        vistaMenu menuForm;
        public controlInicio(vistaInicio vistaPasada, vistaMenu passedMenu)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenu;

            controladaVista.btnCortes.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaCortes(menuForm));
            controladaVista.btnBarberos.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaPersonal());
        }
    }
}
