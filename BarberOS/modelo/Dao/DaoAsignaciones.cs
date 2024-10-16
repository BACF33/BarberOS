﻿using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Modelo.Dao
{
    internal class DaoAsignaciones
    {
        public void Obtener(vistaMenu menuPasado, VistaAsignaciones vistaPasada)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT orderDate, orderText," +
                        "FROM announcements a" +
                        "WHERE orderName = @userName ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", menuPasado.btnCurrentUser.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string testText;
                                DateTime testDateTime;

                                testText = reader["orderText"].ToString();
                                testDateTime = (DateTime)reader["orderDate"];

                                PanelAsignacion panelUsado = new PanelAsignacion(testText, testDateTime, menuPasado);
                                panelUsado.Dock = DockStyle.Right;

                                vistaPasada.flpAsignaciones.Controls.Add(panelUsado);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
