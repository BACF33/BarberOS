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
        //Se declaran variables en un bloque exterior para que puedan ser usadas en todo el archivo, la mayoria nulas para luego asignarlas a las correspondientes
        VistaInicioGestion controladaVista;
        vistaMenu menuForm;
        public ControlInicioGestion(VistaInicioGestion vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;

            //Aqui se evaluara cuando el usuario presione uno de los botones del menu, dependiendo del que toque la 
            //funcion de la izquierda se evaluara (si toca el boton personal se creara un nuevo formulario vista liste personal g)
            controladaVista.btnPersonal.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaPersonalG(menuForm));
            controladaVista.btnClientes.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaClientesG(menuForm));
            controladaVista.btnProductos.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaCortesG(menuForm));
            controladaVista.btnPromo.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaPromocionesG(menuForm));
            controladaVista.btnPreguntas.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaListaPreguntas(menuForm));
            controladaVista.btnRegistros.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaRegistros(passedMenuForm));
            controladaVista.btnAgenda.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaAgendas(passedMenuForm));
            controladaVista.btnInventario.Click += (sender,e) => menuForm.controladorMenu.AbrirFormulario(new VistaInventario(passedMenuForm));
            controladaVista.btnServidor.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaConfigServidor(passedMenuForm));
            controladaVista.btnComunicados.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaComunicadosG(passedMenuForm));
            controladaVista.btnOrdenes.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaOrdenes(passedMenuForm));
        }
    }
}