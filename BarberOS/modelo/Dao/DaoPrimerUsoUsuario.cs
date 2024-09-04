﻿using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dao
{
    internal class DaoPrimerUsoUsuario
    {
    public void Registrar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO users ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string testId, testName, testPrice, testPower, testType;
                                testId = reader["promotionId"].ToString();
                                testName = reader["promotionName"].ToString();
                                testPrice = reader["promotionPrice"].ToString();
                                testPower = reader["promotionPower"].ToString();
                                testType = reader["promotionType"].ToString();
                                PanelPromocion panelUsado = new PanelPromocion(pasadoMenu, seleccionadoProducto, int.Parse(testId), testName, testPower, testType);

                                enviadaVista.flpPromociones.Controls.Add(panelUsado);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
