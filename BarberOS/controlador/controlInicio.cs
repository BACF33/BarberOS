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
    //Test
    internal class ControlInicio
    {
        VistaInicio controladaVista = null;
        vistaMenu menuForm;
        public ControlInicio(VistaInicio vistaPasada, vistaMenu passedMenu)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenu;
            //Aqui se evaluara cuando el usuario presione uno de los botones del menu, dependiendo del que toque la 
            //funcion de la izquierda se evaluara (si toca el boton cortes se creara un nuevo formulario cortes)
            controladaVista.btnBarberos.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaCortes(menuForm));
            controladaVista.btnBarberos.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaListaPersonal());
            controladaVista.btnComunicados.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaComunicados());
            controladaVista.btnAgendar.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new vistaCitas(menuForm));
        }
    }
}
