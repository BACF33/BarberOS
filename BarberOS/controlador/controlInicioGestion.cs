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

            if (menuForm.controladorMenu.userValues.Role == "Cliente")
            {
                controladaVista.btnPersonal.Visible = false;
                controladaVista.btnClientes.Visible = false;
                controladaVista.btnRegistros.Visible = false;
            }





            controladaVista.btnPersonal.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaPersonalG(menuForm));
            controladaVista.btnClientes.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaClientesG(menuForm));
            controladaVista.btnRegistros.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaRegistros());
        }
    }
}
