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
    internal class DaoListaPromociones
    {
        public DaoListaPromociones(VistaListaPromociones enviadaVista, vistaMenu pasadoMenu, DtoPanelProducto seleccionadoProducto)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT " +
                    "promotionId, " +
                    "promotionName, " +
                    "promotionPrice, " +
                    "promotionPower, " +
                    "promotionType, " +
                    "(SELECT promotionTypeName FROM promotionTypes WHERE promotionTypeId = promotions.promotionType) AS promotionTypeName " +
                    "FROM promotions";

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
                                testType = reader["promotionTypeName"].ToString();
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
