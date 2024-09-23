using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Modelo.Dao
{
    internal class DaoListaComunicadosG
    {
        public void Agregar(VistaListaComunicadosG vistaPasada, vistaMenu menuPasado)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {

                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string query = @"
                    INSERT INTO announcements (announcementText, announcementPoster, announcementPrivacy)
                    VALUES (
                    @announcementText, 
                    (SELECT userId FROM users WHERE userName = @announcementPoster),
                    @announcementPrivacy 
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@announcementText", vistaPasada.txtText.Text);
                        cmd.Parameters.AddWithValue("@announcementPoster", menuPasado.btnCurrentUser.Text);
                        cmd.Parameters.AddWithValue("@announcementPrivacy", vistaPasada.cmbPrivacy.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    //Test
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Obtener(VistaListaComunicadosG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Se ejecutara un query donde se obtendran los valores de la base de datos, se usa un inner join 
                    //dado a que userType es una llave foranea
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT a.announcementId, a.announcementText, u.userName, a.announcementPrivacy " +
                        "FROM announcements a " +
                        "INNER JOIN users u ON u.userId = a.announcementPoster ", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listComunicados.Items.Clear();

                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["announcementId"].ToString());
                            item.SubItems.Add(reader["announcementText"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["announcementPrivacy"].ToString());
                            vistaPasada.listComunicados.Items.Add(item);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Borrar(VistaListaComunicadosG vistaPasada)
        {
            string selectedId = vistaPasada.listComunicados.SelectedItems[0].Text;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string sql = "DELETE FROM announcements WHERE announcementId = @toDelete";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@toDelete", selectedId);
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
