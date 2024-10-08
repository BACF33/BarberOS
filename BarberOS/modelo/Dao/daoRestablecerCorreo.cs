using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Modelo.Dao
{
    internal class DaoRestablecerCorreo
    {
        //Funcion para verificar si el correo que esta siendo usado para restablecer contraseña esta vinclado con el usuario al que se le cambiara la contraseña
        public bool verificarCorreo(string usuario, string correo)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE userName = @usuarioV AND userEmail = @correoV", conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuarioV", usuario);
                        cmd.Parameters.AddWithValue("@correoV", correo);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            reader.Close();
                            return true;
                        }
                        else
                        {
                            reader.Close();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
