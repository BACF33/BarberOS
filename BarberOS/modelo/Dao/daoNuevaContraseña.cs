using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dao
{
    internal class daoNuevaContraseña
    {
        public void nuevaContaseña(vistaNuevaContraseña vistaPasada, string user)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE users SET userPassword = @userPass WHERE userName = @userName", conexion))
                    {
                        using (SHA256 crypt = SHA256.Create())
                        {
                            byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(vistaPasada.txtNueva.Text));
                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < bytes.Length; i++)
                                builder.Append(bytes[i].ToString("X2"));
                            vistaPasada.txtNueva.Text = builder.ToString();
                        }

                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@userPass", vistaPasada.txtNueva.Text);
                        cmd.Parameters.AddWithValue("@userName", user);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
