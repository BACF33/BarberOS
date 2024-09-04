﻿using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    public class ControlMenu
    {
        //4 Estas variables nulas se declaran aqui para que puedan usar en todo el archivo
        private Form currentForm = null;
         public vistaMenu controladaVista = null;
        public DtoLogin userValues = null;
        public DaoMenu daoThis = new DaoMenu();

        //5 Este es el constructor del controlador del formulario menu, cuando el controlador se ejecute esto lo hara
        public ControlMenu(vistaMenu vistaPasada)
        {
            controladaVista = vistaPasada;

            daoThis.VerificarPrimerUso(this);

            //6 Aqui se evaluara cuando el usuario presione uno de los botones del menu, dependiendo del que toque la 
            //funcion de la izquierda se evaluara (si toca el boton ingresar se creara un nuevo formulario login)
            controladaVista.btnInicio.Click += (sender, e) => AbrirFormulario(new VistaInicio(controladaVista));
            controladaVista.btnCortes.Click += (sender, e) => AbrirFormulario(new VistaListaCortes(controladaVista));
            controladaVista.btnBarberos.Click += (sender, e) => AbrirFormulario(new VistaListaPersonal());
            controladaVista.btnIngresar.Click += (sender, e) => AbrirFormulario(new vistaLogin(vistaPasada));
            controladaVista.btnAgendar.Click += (sender, e) => AbrirFormulario(new VistaPrimerUsoUsuario());

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

            if (controladaVista.btnIngresar.Text == "SALIR")
            {
                controladaVista.btnBarberos.Visible = false; 
                controladaVista.btnCortes.Visible = false;
                controladaVista.btnAgendar.Visible = false;
                controladaVista.btnInicio.Visible = false;
                //Lo que sea 
            }

               
            
        }
    }
}
