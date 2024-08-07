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
    internal class daoActualizarPromocion
    {
        string selectedId;
        vistaActualizarPromocion pasadaVista;
        public daoActualizarPromocion(string selectedId2, vistaActualizarPromocion pasadaVista2)
        {
            selectedId = selectedId2;
            pasadaVista = pasadaVista2;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbPromociones WHERE promocionId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            pasadaVista.txtNuevoNombre.Text = reader["promocionNombre"].ToString();
                            pasadaVista.txtNuevoPrecio.Text = reader["promocionPrecio"].ToString();
                            pasadaVista.txtNuevoTipo.Text = reader["promocionTipo"].ToString();
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE tbPromociones SET promocionNombre = @promocionNombre, promocionPrecio = @promocionPrecio, promocionTipo = @promocionTipo WHERE promocionId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        cmd.Parameters.AddWithValue("@promocionNombre", pasadaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@promocionPrecio", pasadaVista.txtNuevoPrecio.Text);
                        cmd.Parameters.AddWithValue("@promocionTipo", pasadaVista.txtNuevoTipo.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            pasadaVista.txtNuevoNombre.Text = reader["promocionNombre"].ToString();
                            pasadaVista.txtNuevoPrecio.Text = reader["promocionPrecio"].ToString();
                            pasadaVista.txtNuevoTipo.Text = reader["promocionTipo"].ToString();
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
