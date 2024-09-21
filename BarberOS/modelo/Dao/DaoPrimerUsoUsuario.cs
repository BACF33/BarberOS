using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Modelo.Dao
{
    internal class DaoPrimerUsoUsuario
    {
    public void Registrar(VistaPrimerUsoUsuario vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string query = @"
                    INSERT INTO users (userName, userPassword, userPoints, userRole, userEmail, userBirthPlace)
                    VALUES (
                    @userName, 
                    @userPassword, 
                    @userPoints, 
                    (SELECT roleId FROM userRoles WHERE roleName = @roleName),
                    @userEmail,
                    @userBirthPlace
                    )";

                    //Se encripta la contraseña
                    string password = vistaPasada.txtContraseña.Text;
                    using (SHA256 crypt = SHA256.Create())
                    {
                        byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < bytes.Length; i++)
                            builder.Append(bytes[i].ToString("X2"));
                        password = builder.ToString();
                    }

                    //Se encrip
                    string lugar = vistaPasada.txtLugar.Text;
                    using (SHA256 crypt = SHA256.Create())
                    {
                        byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(lugar));
                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < bytes.Length; i++)
                            builder.Append(bytes[i].ToString("X2"));
                        lugar = builder.ToString();
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@userName", vistaPasada.txtName.Text);
                        cmd.Parameters.AddWithValue("@userPassword", password);
                        cmd.Parameters.AddWithValue("@userPoints", vistaPasada.txtPuntos.Text);
                        cmd.Parameters.AddWithValue("@roleName", "Admin");
                        cmd.Parameters.AddWithValue("@userEmail", vistaPasada.txtEmail.Text);
                        cmd.Parameters.AddWithValue("@userBirthPlace", lugar);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    //Test
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
