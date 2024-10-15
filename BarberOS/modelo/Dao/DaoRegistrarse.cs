using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarberOS.Modelo.Dao
{
    internal class DaoRegistrarse : DtoRegister
    {
        public void register(vistaRegister vistaPasada) 
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se designara una query para insertar en users parametros como los nuevos datos del usuario
                    string query = @"
                    INSERT INTO users (userName, userPassword, userPoints, userRole, userEmail, userImage, userRequiresRestart)
                    VALUES (
                    @userName, 
                    @userPassword, 
                    100, 
                    1,
                    @userEmail,
                    @userImage,
                    @userRequiresRestart
                    ) "
                    ;

                    MemoryStream archivoMemoria = new MemoryStream();
                    vistaPasada.picClientes.Image.Save(archivoMemoria, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] imageData = archivoMemoria.ToArray();

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usaran como parametros los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@userName", NewUser);
                        cmd.Parameters.AddWithValue("@userPassword", NewPassword);
                        cmd.Parameters.AddWithValue("@userEmail", NewEmail);
                        cmd.Parameters.AddWithValue("@userImage", imageData);
                        cmd.Parameters.AddWithValue("@userRequiresRestart", false);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                System.Windows.MessageBox.Show(ex.ToString());
            }
        }
    }
}
