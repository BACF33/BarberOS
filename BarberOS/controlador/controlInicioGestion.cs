using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlInicioGestion
    {
        VistaInicioGestion controladaVista;
        vistaMenu menuForm;
        public ControlInicioGestion(VistaInicioGestion vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;
            //Si se presiona personal se abrirar un formulario vistaListaPersonalG
            controladaVista.btnPersonal.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaPersonalG(menuForm));
            //Si se presiona clientes se abrirar un formulario vistaListaClientesG
            controladaVista.btnClientes.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaClientesG(menuForm));

            controladaVista.btnProductos.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaCortesG(menuForm));

            controladaVista.btnPromo.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaPromocionesG(menuForm));



            //Si se presiona registros se abrirar un formulario vistaListaRegistrosG
            controladaVista.btnRegistros.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaRegistros(passedMenuForm));
        }
    }
}