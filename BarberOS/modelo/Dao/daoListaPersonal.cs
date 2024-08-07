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
    internal class daoListaPersonal
    {
        public daoListaPersonal(vistaListaPersonal enviadaVista)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT userId, userName, userRole FROM tbUser WHERE userRole = 'Admin'";

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
                                panelBarbero panelUsado = new panelBarbero(testId, testName, testRole);

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
