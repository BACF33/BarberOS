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
    internal class daoActualizarCorte
    {
        string selectedId;
        vistaActualizarCortes pasadaVista;
        public daoActualizarCorte(string selectedId2, vistaActualizarCortes pasadaVista2) 
        {
            selectedId = selectedId2;
            pasadaVista = pasadaVista2;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM products WHERE productId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            pasadaVista.txtNuevoNombre.Text = reader["productName"].ToString();
                            pasadaVista.txtNuevoPrecio.Text = reader["productPrice"].ToString();
                            pasadaVista.txtNuevoTipo.Text = reader["productType"].ToString();
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE products SET productName = @productoNombre, productPrice = @productoPrecio, productType = @productoTipo WHERE productId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        cmd.Parameters.AddWithValue("@productoNombre", pasadaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@productoPrecio", pasadaVista.txtNuevoPrecio.Text);
                        cmd.Parameters.AddWithValue("@productoTipo", pasadaVista.txtNuevoTipo.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            pasadaVista.txtNuevoNombre.Text = reader["productName"].ToString();
                            pasadaVista.txtNuevoPrecio.Text = reader["productPrice"].ToString();
                            pasadaVista.txtNuevoTipo.Text = reader["productType"].ToString();
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
