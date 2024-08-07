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
    internal class daoActualizarCliente
    {
        string selectedId;
        vistaActualizarCliente pasadaVista;
        public daoActualizarCliente(string selectedId2, vistaActualizarCliente pasadaVista2)
        {
            selectedId = selectedId2;
            pasadaVista = pasadaVista2;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbUser WHERE userId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            pasadaVista.txtNuevoNombre.Text = reader["userName"].ToString();
                            pasadaVista.txtNuevoPrecio.Text = reader["userPoints"].ToString();
                            pasadaVista.txtNuevoTipo.Text = reader["userRole"].ToString();
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

        public void update()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE tbUser SET userName = @userName, userPoints = @userPoints, userRole = @userRole WHERE userId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        cmd.Parameters.AddWithValue("@userName", pasadaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@userPoints", pasadaVista.txtNuevoPrecio.Text);
                        cmd.Parameters.AddWithValue("@userType", pasadaVista.txtNuevoTipo.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            pasadaVista.txtNuevoNombre.Text = reader["userName"].ToString();
                            pasadaVista.txtNuevoPrecio.Text = reader["userPoints"].ToString();
                            pasadaVista.txtNuevoTipo.Text = reader["userType"].ToString();
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
    }
}
