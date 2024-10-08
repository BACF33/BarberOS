 using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using BarberOS.Vistas;
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
    internal class ControlLogin
    {
        DaoLogin daoThis = new DaoLogin();
        vistaMenu menuForm = null;
        vistaLogin controladaVista;

        //Tambien constructor del controlador de login, cuando controlLogin se crea lo que esta dentro se ejecutara
        public ControlLogin(vistaLogin passedVista, vistaMenu passedMenu) 
        {
            controladaVista = passedVista;
            menuForm = passedMenu;

            //Si el usuario le da a salir despues de haber iniciado sesion toda la informacion sobre el es borrada
            //y los apartados visuales son restaurados
            if (menuForm.btnIngresar.Text == "SALIR")
            {
                menuForm.btnIngresar.Text = "INGRESAR";
                menuForm.controladorMenu.userValues.Username = null;
                menuForm.controladorMenu.userValues.Password = null;
                menuForm.controladorMenu.userValues.Role = null;
                menuForm.controladorMenu.userValues.Points = 0;
                menuForm.btnCurrentUser.Text = "No has iniciado sesion";
            }
            //Las funciones de la derecha se ejecutaran cuando en la vista el usuario presione los botones designados 

            //Si se presiona ingresar se ejecutara la funcion login)
            controladaVista.btnLogin.Click += (sender, e) => login();
            //Si se presiona restablecer se ejecutara la funcion reestablecerContraseña)
            controladaVista.btnRestPass.Click += (sender, e) => reestablecerContraseña();
            //Si se presiona registrarse se ejecutara register
            controladaVista.btnCreate.Click += (sender, e) => register();                   
        }

        public void reestablecerContraseña()
        {
            //Se abrira como nueva ventana un formulario vistaReestablecerAdmin
            menuForm.controladorMenu.AbrirFormulario(new vistaRestablecerCorreo(menuForm));
        }

        public void login()
        {

            //Al dto o a la informacion que se usara en el query se le asigna la informacion que el usuario ingreso
            //en el textbox
            daoThis.Username = controladaVista.txtUser.Text;

            //Similar a como se obtiene la informacion del usuario pero con la contraseña que antes se usa con sha256
            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(controladaVista.txtPassword.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.Password = builder.ToString();
            }

            //Se ejecutara la funcion login del dao, el valor que este regrese se lo hara a la variable answer
            int answer = daoThis.login();
            //Si el valor obtenido por answer es 1 (inicio de sesion correcto esto se ejecuta)

            if(answer == 1 && daoThis.FirstLogin == false)
            {
                menuForm.btnIngresar.Text = "SALIR"; 
                menuForm.btnCurrentUser.Text = daoThis.Username;

                menuForm.controladorMenu.userValues = daoThis;
                //Aqui evalua si el tipo del usuario que inicio sesion era cliente o admin, dependiendo de eso mandara
                //a un formulario diferente
                if (daoThis.Role == "Cliente")
                {
                    menuForm.controladorMenu.AbrirFormulario(new VistaInicio(menuForm));

                }
                else
                {
                    menuForm.controladorMenu.AbrirFormulario(new VistaInicioGestion(menuForm));
                    menuForm.pnlBarberos.Visible = false;
                    menuForm.pnlCortes.Visible = false;
                    menuForm.pnlAgendar.Visible = false;
                    menuForm.pnlInicio.Visible = false;
                }
            }
            else if (answer == 1 && daoThis.FirstLogin == true)
            {
                menuForm.controladorMenu.AbrirFormulario(new VistaPrimerLogin(daoThis.Username, menuForm));
            }
            //Si el valor obtenido por answer no es 1 (inicio de sesion incorrecto esto se ejecuta)
            else
                MessageBox.Show($"Probable estes ingresando mal las credenciales, vuelve a intentarlo", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void register()
        {
            //Se abrira un formulario vistaRegister
            menuForm.controladorMenu.AbrirFormulario(new vistaRegister());
        }
    }
}