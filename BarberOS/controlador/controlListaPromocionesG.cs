using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlListaPromocionesG
    {
        private vistaMenu menuForm;
        private vistaListaPromocionesG controladaVista;
        public controlListaPromocionesG(vistaListaPromocionesG passedVista, vistaMenu passedMenu)
        {
            menuForm = passedMenu;
            controladaVista = passedVista;
            controladaVista.btnAClientes.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaClientesG(menuForm));
        }
    }
}
