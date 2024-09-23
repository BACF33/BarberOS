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
                    string query = "SELECT a.announcementText, a.announcementPoster, a.announcementPrivacy, u.userImage " +
                        "FROM announcements a " +
                        "INNER JOIN users u ON userId = announcementPoster";

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
                                byte[] imageData = reader["userImage"] as byte[];

                                PanelComunicado panelUsado = new PanelComunicado(testText, testPoster, testPrivacy, imageData);

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
