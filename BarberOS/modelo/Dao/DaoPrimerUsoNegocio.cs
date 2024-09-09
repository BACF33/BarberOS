using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Modelo.Dao
{
    internal class DaoPrimerUsoNegocio
    {
        public void Registrar(VistaPrimerUsoNegocio vistaPasada)
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
                    INSERT INTO business (businessName, businessEmail, businessText)
                    VALUES (
                    @businessName, 
                    @businessEmail, 
                    @businessMotto
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@businessName", vistaPasada.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@businessEmail", vistaPasada.txtEmail.Text);
                        cmd.Parameters.AddWithValue("@businessMotto", vistaPasada.txtLema.Text);
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
