using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class controlListaPersonal
    {
        vistaListaPersonal controladaVista;
        public controlListaPersonal(vistaListaPersonal enviadaVista) 
        {
            controladaVista = enviadaVista;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT userId, userName, userRole FROM tbUser";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                // Create a new instance of UserControl1
                                panelBarbero panelUsado = new panelBarbero();

                                // Set properties or text of the UserControl based on the data
                                panelUsado.lblId.Text = reader["userId"].ToString();
                                panelUsado.lblName.Text = reader["userName"].ToString();
                                panelUsado.lblRole.Text = reader["userRole"].ToString();

                                // Set the location of the UserControl
                                //panelUsado.Location = new System.Drawing.Point(10, yOffset);
                                //panelUsado.Width = this.controladaVista.flpPersonal.Width - 20; // Adjust width as needed
                                //panelUsado.Height = controlHeight;

                                // Add the UserControl to the Panel
                                controladaVista.flpPersonal.Controls.Add(panelUsado);

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
