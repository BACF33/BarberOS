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
    internal class DaoLogin : DtoLogin
    {
        public int login() 
        {
            //4 Se usara try para obtener un posible error con catch
            try
            {
                //5 Se usara la string cnn en app.config para conectarse a la base de datos
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //5 Se abrira la conexion y en la base de datos se ejecutara este query de select con inner join dado
                    //a que los roles de usuario estan en una tabla diferente, asi se mostrara como texto
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("" +
                        "SELECT u.userPoints, r.roleName " +
                        "FROM users u " +
                        "INNER JOIN userRoles r ON u.userRole = r.roleId " +
                        "WHERE u.userName = @userName AND (u.userPassword = @userPassword OR u.userBirthPlace = @userPassword)", conexion))
                    {
                        //6 El query usa parametros cuyos valores son los datos obtenidos anteriormente en el control
                        //el username y el password
                        cmd.Parameters.AddWithValue("@userName", Username);

                        cmd.Parameters.AddWithValue("@userPassword", Password);

                        SqlDataReader reader = cmd.ExecuteReader();

                        //7 Si existen datos que cumplan con los requisitos del query (hay datos con el mismo username y
                        //password ingresados el inicio de sesion fue correcto se regresa 1, si no 0
                        if (reader.Read())
                        {
                            Role = reader["roleName"].ToString();
                            Points = (int)reader["userPoints"];
                            return 1;
                        }
                        else
                            return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}
