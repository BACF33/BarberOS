using BarberOS.Modelo.Dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarberOS.Modelo.Dao
{
    internal class DaoRegistrarse : DtoRegister
    {
        public void register() 
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se designara una query para insertar en users parametros como los nuevos datos del usuario
                    string query = @"
                    INSERT INTO users (userName, userPassword, userPoints, userRole, userEmail, userRequiresRestart)
                    VALUES (
                    @userName, 
                    @userPassword, 
                    100, 
                    1,
                    @userEmail,
                    @userRequiresRestart
                    ) "
                    ;

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usaran como parametros los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@userName", NewUser);
                        cmd.Parameters.AddWithValue("@userPassword", NewPassword);
                        cmd.Parameters.AddWithValue("@userEmail", NewEmail);
                        cmd.Parameters.AddWithValue("@userRequiresRestart", true);

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
