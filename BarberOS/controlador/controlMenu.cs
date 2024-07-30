using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    public class controlMenu
    {
        private Form currentForm = null;
        vistaMenu controladaVista;

        public controlMenu(vistaMenu vistaPasada)
        {
            controladaVista = vistaPasada;
            controladaVista.btnInicio.Click += (sender, e) => AbrirFormulario(new vistaInicio());
            controladaVista.btnCortes.Click += (sender, e) => AbrirFormulario(new vistaCortes());
            controladaVista.btnBarberos.Click += (sender, e) => AbrirFormulario(new vistaBarberos());
            controladaVista.btnIngresar.Click += (sender, e) => AbrirFormulario(new vistaLogin(controladaVista));
        }

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
