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
    internal class daoAgregarProducto
    {
        public daoAgregarProducto(vistaAgregarProducto controladaVista)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se ejecutara un query donde se insertara a la tabla de la base de datos los valores ingresados por
                    //el usuario en los textboxes
                    string sql = "INSERT INTO products (productName, productPrice, productType) " +
                                 "VALUES (@productoNombre, @productoPrecio, @productoTipo)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //Como parametros se utilizaran los valores obtenidos anteriormente de los textboxes
                        cmd.Parameters.AddWithValue("@productoNombre", controladaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@productoPrecio", controladaVista.txtNuevoPrecio.Text);
                        cmd.Parameters.AddWithValue("@productoTipo", controladaVista.txtNuevoTipo.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
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
