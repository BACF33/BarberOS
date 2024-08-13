using BarberOS.Modelo.Dto;
using BarberOS.Vista;
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
    internal class daoAgregarCliente : dtoAgregarPersonal
    {
        public void agregar()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    //Se ejecutara un query donde se insertara a la tabla de la base de datos los valores ingresados por
                    //el usuario en los textboxes
                    string query = @"
                    INSERT INTO users (userName, userPassword, userPoints, userRole)
                    VALUES (
                    @userName, 
                    @userPassword, 
                    @userPoints, 
                    (SELECT roleId FROM userRoles WHERE roleName = @roleName)
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Como parametros se utilizaran los valores obtenidos anteriormente de los textboxes
                        cmd.Parameters.AddWithValue("@userName", UserName);
                        cmd.Parameters.AddWithValue("@userPassword", Password);
                        cmd.Parameters.AddWithValue("@userPoints", Points);
                        cmd.Parameters.AddWithValue("@roleName", "Cliente");

                        int rowsAffected = cmd.ExecuteNonQuery();
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
