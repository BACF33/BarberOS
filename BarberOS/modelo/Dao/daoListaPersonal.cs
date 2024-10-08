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
    internal class DaoListaPersonal
    {
        //Funcion que al ejecutarse obtendra valores sobre la lista de productos, a partir de estos valores creara paneles de productos con los valores obtenidos
        public DaoListaPersonal(VistaListaPersonal enviadaVista)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //Se define un query para obtener todos los no clientes de la tabla usuarios
                    string query = "SELECT userId, userName, userRole, userImage FROM users WHERE userRole = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string testId, testName, testRole;

                                testId = reader["userId"].ToString();
                                testName = reader["userName"].ToString();
                                testRole = reader["userRole"].ToString();
                                byte[] imageData = reader["userImage"] as byte[];
                                PanelBarbero panelUsado = new PanelBarbero(testId, testName, testRole, imageData);

                                //Despues de crear los paneles de productos estos se añadiran a un flowlayoutpanel para que puedan verse en forma de lista
                                enviadaVista.flpPersonal.Controls.Add(panelUsado);
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
