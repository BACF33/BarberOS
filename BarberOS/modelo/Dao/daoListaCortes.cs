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
    internal class DaoListaCortes
    {
        public DaoListaCortes(VistaListaCortes enviadaVista, vistaMenu pasadoMenu)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT productId, productName, productPrice, productType FROM products";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string testId, testName, testPrecio, testTipo;

                                testId = reader["productId"].ToString();
                                testName = reader["productName"].ToString();
                                testPrecio = reader["productPrice"].ToString();
                                testTipo = reader["productType"].ToString();
                                PanelProducto panelUsado = new PanelProducto(pasadoMenu, testId, testName, testPrecio, testTipo);

                                enviadaVista.flpCabello.Controls.Add(panelUsado);

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
