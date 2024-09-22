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
            //Si se presiona personal se abrira un formulario vistaListaPersonalG
            controladaVista.btnPersonal.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaPersonalG(menuForm));
            //Si se presiona clientes se abrirar un formulario vistaListaClientesG
            controladaVista.btnClientes.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaClientesG(menuForm));

            //Si se presiona productos se abrira un formulario vistaListaCortesG
            controladaVista.btnProductos.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaCortesG(menuForm));

            //Si se presiona promociones se abrira un formulario vistaListaPromocionesG
            controladaVista.btnPromo.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaPromocionesG(menuForm));

            controladaVista.btnPreguntas.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaPreguntas(menuForm));

            controladaVista.btnRegistros.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaRegistros(passedMenuForm));

            controladaVista.btnAgenda.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaAgendas(passedMenuForm));

            controladaVista.btnInventario.Click += (sender,e) => menuForm.controladorMenu.AbrirFormulario(new VistaInventario(passedMenuForm));

            controladaVista.btnServidor.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaConfigServidor(passedMenuForm));

            controladaVista.btnComunicados.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaComunicadosG(passedMenuForm));
        }
    }
}