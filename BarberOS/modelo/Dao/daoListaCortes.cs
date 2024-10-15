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
        //Funcion que al ejecutarse obtendra valores sobre la lista de productos, a partir de estos valores creara paneles de productos con los valores obtenidos
        public DaoListaCortes(VistaListaCortes enviadaVista, vistaMenu pasadoMenu)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT productId, productName, productPrice, productType, productImage FROM products";

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
                                byte[] imageData = reader["productImage"] as byte[];

                                PanelProducto panelUsado = new PanelProducto(pasadoMenu, testId, testName, testPrecio, testTipo, imageData);

                                //Despues de crear los paneles de productos estos se añadiran a un flowlayoutpanel para que puedan verse en forma de lista
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
