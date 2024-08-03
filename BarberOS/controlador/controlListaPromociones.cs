using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class controlListaPromociones
    {
        vistaListaPromociones controladaVista;
        public controlListaPromociones(vistaListaPromociones enviadaVista, vistaMenu pasadoMenu)
        {
            controladaVista = enviadaVista;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT promocionId, promocionNombre, promocionTipo, promocionPrecio, promocionPoder FROM tbPromociones";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                // Create a new instance of UserControl1
                                panelPromocion panelUsado = new panelPromocion(pasadoMenu);

                                // Set properties or text of the UserControl based on the data
                                panelUsado.lblName.Text = reader["promocionNombre"].ToString();
                                panelUsado.lblPoder.Text = reader["promocionPoder"].ToString();
                                panelUsado.lblPrecio.Text = reader["promocionPrecio"].ToString();
                                panelUsado.lblTipo.Text = reader["promocionTipo"].ToString();

                                // Set the location of the UserControl
                                //panelUsado.Location = new System.Drawing.Point(10, yOffset);
                                //panelUsado.Width = this.controladaVista.flpPersonal.Width - 20; // Adjust width as needed
                                //panelUsado.Height = controlHeight;

                                // Add the UserControl to the Panel
                                controladaVista.flpPromociones.Controls.Add(panelUsado);

                                // Update vertical offset for the next UserControl
                                //yOffset += controlHeight + spacing;
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
