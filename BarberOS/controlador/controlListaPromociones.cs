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
        public controlListaPromociones(vistaListaPromociones enviadaVista, vistaMenu pasadoMenu, string seleccionadoNombre, string seleccionadoPrecio)
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
                                panelPromocion panelUsado = new panelPromocion(pasadoMenu, seleccionadoNombre, seleccionadoPrecio);
                                panelUsado.lblName.Text = reader["promocionNombre"].ToString();
                                panelUsado.lblPoder.Text = reader["promocionPoder"].ToString();
                                panelUsado.lblPrecio.Text = reader["promocionPrecio"].ToString();
                                panelUsado.lblTipo.Text = reader["promocionTipo"].ToString();
                                controladaVista.flpPromociones.Controls.Add(panelUsado);
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
