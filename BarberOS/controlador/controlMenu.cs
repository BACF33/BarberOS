using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    public class ControlMenu
    {
        //Se declaran variables en un bloque exterior para que puedan ser usadas en todo el archivo, la mayoria nulas para luego asignarlas a las correspondientes
        private Form currentForm = null;
         public vistaMenu controladaVista = null;
        public DtoLogin userValues = null;
        public DaoMenu daoThis = new DaoMenu();

        //Constructor del controlador del formulario menu, cuando el controlador se cree esto se ejecutara
        public ControlMenu(vistaMenu vistaPasada)
        {
            controladaVista = vistaPasada;

            //Del dao asociado con este se ejecutara la funcion para verificar el primer uso del sistema
            daoThis.VerificarPrimerUso(this);


            //Aqui se evaluara cuando el usuario presione uno de los botones del menu, dependiendo del que toque la 
            //funcion de la izquierda se evaluara (si toca el boton ingresar se creara un nuevo formulario login)
            controladaVista.btnInicio.Click += (sender, e) => AbrirFormulario(new VistaInicio(controladaVista));
            controladaVista.btnCortes.Click += (sender, e) => AbrirFormulario(new VistaListaCortes(controladaVista));
            controladaVista.btnBarberos.Click += (sender, e) => AbrirFormulario(new VistaListaPersonal());
            controladaVista.btnIngresar.Click += (sender, e) => AbrirFormulario(new vistaLogin(vistaPasada));
            controladaVista.btnAgendar.Click += (sender, e) => AbrirFormulario(new vistaCitas(vistaPasada));

        }

        //Funcion para que en caso de que se tenga que abrir un formulario este lo haga en un panel a la derecha de los elementos del menu y no como una nueva ventana
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

            //Dependiendo del valor de donde se muestra el usuario actual algunos seran visibles o no
            if (controladaVista.btnIngresar.Text != "SALIR")
            {
                controladaVista.pnlBarberos.Visible = true; 
                controladaVista.pnlCortes.Visible = true;
                controladaVista.pnlAgendar.Visible = true;
                controladaVista.pnlInicio.Visible = true;
            }
        }
    }
}
