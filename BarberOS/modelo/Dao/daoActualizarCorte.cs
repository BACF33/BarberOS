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
            //6 Se obtendra la id de la fila de la tabla al que el usuario le dio click en el formulario vistaListaCortesG
            selectedId = selectedId2;
            pasadaVista = pasadaVista2;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //7 Se ejecutara un query que obtenga la informacion que tenga la casilla con la id seleccionada
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM products WHERE productId = @selectedId", conexion))
                    {
                        //Como parametro en el select sera la id seleccionada en la vista
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            //A los textboxes presentes se les asignaran los valores que se obtuvieron de la base de datos
                            //asi el usuario vera que valores tenian antes de modificarse
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
                    //Se ejecutara un query update donde se hara que  valores de la tabla usuarios en la base de datos
                    //sean iguales a los que estan en las textboxes
                    using (SqlCommand cmd = new SqlCommand("UPDATE products SET productName = @productoNombre, productPrice = @productoPrecio, productType = @productoTipo WHERE productId = @selectedId", conexion))
                    {
                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        cmd.Parameters.AddWithValue("@productoNombre", pasadaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@productoPrecio", pasadaVista.txtNuevoPrecio.Text);
                        cmd.Parameters.AddWithValue("@productoTipo", pasadaVista.txtNuevoTipo.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        //Aqui se ejecuta, no hay procesos adicionales aparte de la query por lo que esta vacio
                        while (reader.Read())
                        {
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
