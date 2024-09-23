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
    internal class DaoComunicados
    {
        public void Obtener(VistaComunicados vistaPasada)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT announcementText, announcementPoster, announcementPrivacy FROM announcements";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string testText, testPoster, testPrivacy;

                                testText = reader["announcementText"].ToString();
                                testPoster = reader["announcementPoster"].ToString();
                                testPrivacy = reader["announcementPrivacy"].ToString();

                                PanelComunicado panelUsado = new PanelComunicado(testText, testPoster, testPrivacy);

                                vistaPasada.flpComunicados.Controls.Add(panelUsado);

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
