using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Modelo.Dao
{
    internal class DaoPublicarComunicado
    {
        public void Obtener(VistaPublicarComunicado vistaPasada)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT a.announcementText, u.userName, a.announcementPrivacy, u.userImage " +
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
                                testPoster = reader["userName"].ToString();
                                testPrivacy = reader["announcementPrivacy"].ToString();
                                byte[] imageData = reader["userImage"] as byte[];

                                PanelComunicado panelUsado = new PanelComunicado(testText, testPoster, testPrivacy, imageData);
                                panelUsado.Dock = DockStyle.Right;

                                //Despues de crear los paneles de productos estos se añadiran a un flowlayoutpanel para que puedan verse en forma de lista
                                vistaPasada.flpComunicados.Controls.Add(panelUsado);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
