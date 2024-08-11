﻿using BarberOS.Modelo.Dto;
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
    internal class daoLogin : dtoLogin
    {
        public int login() 
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("" +
                        "SELECT u.userPoints, r.roleName " +
                        "FROM users u " +
                        "INNER JOIN userRoles r ON u.userRole = r.roleId " +
                        "WHERE u.userName = @userName AND u.userPassword = @userPassword ", conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", Username);

                        cmd.Parameters.AddWithValue("@userPassword", Password);

                        SqlDataReader reader = cmd.ExecuteReader();

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
