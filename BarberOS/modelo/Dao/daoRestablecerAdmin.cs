using BarberOS.Controlador;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BarberOS.Modelo.Dto;

namespace BarberOS.Modelo.Dao
{
    internal class daoRestablecerAdmin : dtoRestablecerAdmin
    {
        public int restpass()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT userName, userPoints, userRole FROM users WHERE userName=@userName AND userPassword=@userPassword AND userRole = 1", conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", Username);
                        cmd.Parameters.AddWithValue("@userPassword", Password);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                            return 1;
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
        public void doChange()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE users SET userPassword = @userPassword WHERE userName = @userName", conexion))
                    {
                        cmd.Parameters.AddWithValue("@userPassword", NewPass);
                        cmd.Parameters.AddWithValue("@userName", NewName);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                        }

                        reader.Close();
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