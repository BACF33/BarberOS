using System;
using System.Windows.Forms;
using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using BarberOS.Modelo;

namespace BarberOS.Controlador
{
    //Clase
    public class controladorLogin
    {
        //Objeto de vista vacio que luego sera del objeto de la vista que pasamos anteriormente para poder manipularlo
        vistaLogin objLogin;
        //Constructor
        public controladorLogin(vistaLogin aVista)
        {
            //Asignacion de la vista local a la que pasamos como argumento
            objLogin = aVista;
            //Evaluacion de input, si blanco es verdadero las funciones de la derecha se ejecutan
            objLogin.btnIngresar.Click += new EventHandler(DataAccess);
            objLogin.btnExit.Click += new EventHandler(QuitApplication);
            objLogin.txtUser.Enter += new EventHandler(EnterUser);
            objLogin.txtUser.Leave += new EventHandler(LeaveUser);
            objLogin.txtPassword.Enter += new EventHandler(EnterPassword);
            objLogin.txtPassword.Leave += new EventHandler(LeavePassword);
            objLogin.btnTest.Click += new EventHandler(TestConnection);
        }

        //Cerrar la aplicacion, solo eso dado a que presiono la x
        private void QuitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Acceder a la base de datos
        private void DataAccess(object sender, EventArgs e)
        {
            //Se crea un objeto dao (notarse que su rango es solo esta funcion) 
            DaoLogin daoData = new DaoLogin();
            //Con la funcion login del objeto dao se obtiene un codigo sobre la conexion
            int answer = daoData.Login();
            MessageBox.Show(answer.ToString());
        }

        private void EnterUser(object sender, EventArgs e)
        {
            //Verifica si el usuario ingresado en el textbox existe en la base de datos
            if (objLogin.txtUser.Text.Trim().Equals("Usuario"))
            {
                objLogin.txtUser.Clear();
                objLogin.lblUser.Visible = true;
            }
        }

        private void LeaveUser(object sender, EventArgs e)
        {
            if (objLogin.txtUser.Text.Trim().Equals(""))
            {
                objLogin.txtUser.Text = "Usuario";
                objLogin.lblUser.Visible = false;
            }
        }

        private void EnterPassword(object sender, EventArgs e)
        {
            if (objLogin.txtPassword.Text.Trim().Equals("Contraseña"))
            {
                objLogin.txtPassword.Clear();
                objLogin.lblPassword.Visible = true;
                //ObjLogin.txtPassword.PasswordChar = '*';
                objLogin.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void LeavePassword(object sender, EventArgs e)
        {
            if (objLogin.txtPassword.Text.Trim().Equals(""))
            {
                objLogin.lblPassword.Visible = false;
                objLogin.txtPassword.Text = "Contraseña";
                objLogin.txtPassword.PasswordChar = '\0';
            }
        }

        private void TestConnection(object sender, EventArgs e)
        {
            //Se hace referencia a la clase dbContext y su método getConnection y se evalúa
            // si el retorno es nulo o no, en caso de ser nulo se mostrará el primer mensaje
            //de lo contrario se mostrará el código del segmento else.
            if (dbContext.getConnection() == null)
            {
                MessageBox.Show("No fue posible realizar la conexión al servidor y/o la base de datos.", "Conexión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("La conexión al servidor y la base de datos se ha ejecutado correctamente.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
