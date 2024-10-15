using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Modelo.Dao
{
    internal class DaoNuevoPost
    {
        public void Obtener(VistaNuevoPost vistaPasada, vistaMenu menuThis)
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
                        "SELECT userName, userImage " +
                        "FROM users " +
                        "WHERE userName = @userName ", conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", menuThis.btnCurrentUser.Text);

                        SqlDataReader reader = cmd.ExecuteReader();
                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        byte[] imageData;
                        if (reader.Read())
                        {
                            vistaPasada.txtPoster.Text = reader["userName"].ToString();
                            imageData = reader["userImage"] as byte[];

                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                Image convertida = Image.FromStream(ms);
                                vistaPasada.picPerfil.Image = convertida;
                            }

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

        public void Insertar(VistaNuevoPost vistaPasada, vistaMenu menuThis)
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
                    INSERT INTO announcements (announcementText, announcementPoster)
                    VALUES (
                    @announcementText , 
                    (SELECT userId FROM users WHERE userName = @announcementPoster)
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@announcementText", vistaPasada.txtTexto.Text);
                        cmd.Parameters.AddWithValue("@announcementPoster", menuThis.btnCurrentUser.Text);
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
    }
}
