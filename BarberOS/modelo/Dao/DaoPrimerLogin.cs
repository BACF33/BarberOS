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
    internal class DaoPrimerLogin
    {
        public DaoPrimerLogin(VistaPrimerLogin vistaPasada, int idPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se ejecutara un query update donde se hara que  valores de la tabla usuarios en la base de datos
                    //sean iguales a los que estan en las textboxes
                    using (SqlCommand cmd = new SqlCommand("" +
                        "userPassword = @userPassword, " +
                        "userRequiresRestart = @newState " +
                        "WHERE userId = @selectedId", conexion))
                    {

                        string password = vistaPasada.txtNueva.Text;
                        using (SHA256 crypt = SHA256.Create())
                        {
                            byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < bytes.Length; i++)
                                builder.Append(bytes[i].ToString("X2"));
                            password = builder.ToString();
                        }


                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@newPassword", vistaPasada.txtNueva);
                        cmd.Parameters.AddWithValue("@newState", false);
                        cmd.Parameters.AddWithValue("@selectedId", idPasada);

                        cmd.ExecuteNonQuery();
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
