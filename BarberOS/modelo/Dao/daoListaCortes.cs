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
    internal class daoListaCortes
    {
        public daoListaCortes(vistaListaCortes enviadaVista, vistaMenu pasadoMenu)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT productoId, productoNombre, productoPrecio, productoTipo FROM tbProductos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string testId, testName, testPrecio, testTipo;

                                testId = reader["productoId"].ToString();
                                testName = reader["productoNombre"].ToString();
                                testPrecio = reader["productoPrecio"].ToString();
                                testTipo = reader["productoTipo"].ToString();
                                panelProducto panelUsado = new panelProducto(pasadoMenu, testId, testName, testPrecio, testTipo);

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
