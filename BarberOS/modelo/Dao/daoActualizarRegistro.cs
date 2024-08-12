using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dao
{
    internal class daoActualizarRegistro
    {
        string selectedId;
        vistaActualizarRegistro pasadaVista;
        public daoActualizarRegistro(string selectedId2, vistaActualizarRegistro pasadaVista2)
        {
            selectedId = selectedId2;
            pasadaVista = pasadaVista2;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM registries WHERE registryId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            pasadaVista.tx
                            pasadaVista.tx.Text = reader["promotionName"].ToString();
                            pasadaVista.txtPNProducto.Text = reader["promotionPrice"].ToString();
                            pasadaVista.txtNNPromocion.Text = reader["promotionType"].ToString();
                        }
                        MessageBox.Show("test");
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE promotions SET promotionName = @promocionNombre, promotionPrice = @promocionPrecio, promotionType = @promocionTipo WHERE promotionId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        cmd.Parameters.AddWithValue("@promocionNombre", pasadaVista.txtNNProducto.Text);
                        cmd.Parameters.AddWithValue("@promocionPrecio", pasadaVista.txtPNProducto.Text);
                        cmd.Parameters.AddWithValue("@promocionTipo", pasadaVista.txtNNPromocion.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            pasadaVista.txtNNProducto.Text = reader["promotionName"].ToString();
                            pasadaVista.txtPNProducto.Text = reader["promotionPrice"].ToString();
                            pasadaVista.txtNNPromocion.Text = reader["promotionType"].ToString();
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

