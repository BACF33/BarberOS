using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlListaClientesG
    {
        private vistaMenu menuForm;
        private vistaListaClientesG controladaVista;
        public controlListaClientesG(vistaListaClientesG vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;
            controladaVista.btnAProms.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaListaPromocionesG(passedMenuForm));
        }
    }
}
