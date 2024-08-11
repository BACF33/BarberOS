using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class controlLogin
    {
        daoLogin daoThis = new daoLogin();
        vistaMenu menuForm = null;
        vistaLogin controladaVista;
        public controlLogin(vistaLogin passedVista, vistaMenu passedMenu) 
        {
            controladaVista = passedVista;
            menuForm = passedMenu;

            controladaVista.btnLogin.Click += (sender, e) => login();
            controladaVista.btnRestPass.Click += (sender, e) => reestablecerContraseña();
        }

        public void reestablecerContraseña()
        {
            vistaReestablecerAdmin restpass = new vistaReestablecerAdmin();
            restpass.Show();
        }

        public void login()
        {

            daoThis.Username = controladaVista.txtUser.Text;

            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(controladaVista.txtPassword.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.Password = builder.ToString();
            }

            int answer = daoThis.login();
            if(answer == 1)
            {
                menuForm.btnInicio.Visible = false;
                menuForm.btnBarberos.Visible = false;
                menuForm.btnCortes.Visible = false;
                menuForm.btnIngresar.Text = "SALIR"; 
                menuForm.btnCurrentUser.Text = daoThis.Username;

                menuForm.controladorMenu.userValues = daoThis;
                if (daoThis.Role == "Cliente")
                    menuForm.controladorMenu.AbrirFormulario(new vistaPerfilUsuario());
                else
                    menuForm.controladorMenu.AbrirFormulario(new vistaInicioGestion(menuForm));
            }
            else
                MessageBox.Show("Login fallido");
        }
    }
}
