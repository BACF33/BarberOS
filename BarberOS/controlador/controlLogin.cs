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
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT userName FROM tbUser WHERE userName=@userName AND userPass=@userPass", conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", controladaVista.txtUser.Text);
                        cmd.Parameters.AddWithValue("@userPass", controladaVista.txtPassword.Text);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Login exitoso");
                            menuForm.controladorMenu.AbrirFormulario(new vistaInicioGestion(menuForm));
                        }
                        else
                        {
                            MessageBox.Show("Login fallido");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
