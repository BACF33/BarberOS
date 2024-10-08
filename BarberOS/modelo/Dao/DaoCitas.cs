using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Modelo.Dao
{
    internal class DaoCitas
    {
        //Funcion que insertara en la base de datos valores encontrados en los textboxes de la vista de citas
        public void Insertar(vistaCitas vistaPasada)
        {
                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        string query = @"
                        INSERT INTO appointments (appointmentDate, appointmentTime)
                        VALUES(
                        @Fecha, 
                        @Hora
                        )";

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            //Se usara la string selectedId como parametro
                            cmd.Parameters.AddWithValue("@Fecha", vistaPasada.dtpFecha.Value);
                            cmd.Parameters.AddWithValue("@Hora", vistaPasada.dtpHora.Value);
                            int rowsAffected = cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
    }
}
