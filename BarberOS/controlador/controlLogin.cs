using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class controlLogin
    {
        vistaMenu menuForm = null;
        vistaLogin controladaVista;
        public controlLogin(vistaLogin passedVista, vistaMenu passedMenu) 
        {
            controladaVista = passedVista;
            menuForm = passedMenu;

            controladaVista.btnLogin.Click += (sender, e) => login();
        }

        public void login()
        {
            daoLogin daoDa = new daoLogin();

            daoDa.Username = controladaVista.txtUser.Text;
            daoDa.Password = controladaVista.txtPassword.Text;
            int answer = daoDa.login();
            if(answer == 1)
            {
                menuForm.btnInicio.Visible = false;
                menuForm.btnBarberos.Visible = false;
                menuForm.btnCortes.Visible = false;
                menuForm.btnIngresar.Text = "SALIR"; 
                menuForm.btnCurrentUser.Text = daoDa.Username;

                menuForm.controladorMenu.userValues = daoDa;

                menuForm.controladorMenu.AbrirFormulario(new vistaInicioGestion(menuForm));
            }
            else
                MessageBox.Show("Login fallido");
        }
    }
}
