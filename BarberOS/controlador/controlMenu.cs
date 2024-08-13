using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    public class controlMenu
    {
        //4 Estas variables nulas se declaran aqui para que puedan usar en todo el archivo
        private Form currentForm = null;
        vistaMenu controladaVista = null;
        public dtoLogin userValues = null;

        //5 Este es el constructor del controlador del formulario menu, cuando el controlador se ejecute esto lo hara
        public controlMenu(vistaMenu vistaPasada)
        {
            controladaVista = vistaPasada;
            //6 Aqui se evaluara cuando el usuario presione uno de los botones del menu, dependiendo del que toque la 
            //funcion de la izquierda se evaluara (si toca el boton ingresar se creara un nuevo formulario login)
            controladaVista.btnInicio.Click += (sender, e) => AbrirFormulario(new vistaInicio(controladaVista));
            controladaVista.btnCortes.Click += (sender, e) => AbrirFormulario(new vistaListaCortes(controladaVista));
            controladaVista.btnBarberos.Click += (sender, e) => AbrirFormulario(new vistaListaPersonal());
            controladaVista.btnIngresar.Click += (sender, e) => AbrirFormulario(new vistaLogin(vistaPasada));
        }

        //7 Esta es una funcion para que el formulario que se abra quede a la derecha del menu y no como una nueva ventana
        public void AbrirFormulario(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                controladaVista.PanelContenedor.Controls.Remove(currentForm);
            }

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Opacity = 0.75;

            controladaVista.PanelContenedor.Controls.Add(form);
            controladaVista.PanelContenedor.Tag = form;
            form.Show();
            form.BringToFront();
        }
    }
}
