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
            //Si se presiona personal se abrirar un formulario vistaListaPersonalG
            controladaVista.btnPersonal.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaPersonalG(menuForm));
            //Si se presiona clientes se abrirar un formulario vistaListaClientesG
            controladaVista.btnClientes.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaClientesG(menuForm));
            //Si se presiona registros se abrirar un formulario vistaListaRegistrosG
            controladaVista.btnRegistros.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaRegistros());
        }
    }
}
