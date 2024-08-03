using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class controlAgregarProducto
    {
        vistaAgregarProducto controladaVista = null;
        public controlAgregarProducto(vistaAgregarProducto pasadaVista)
        {
            controladaVista = pasadaVista;
            controladaVista.btnAgregar.Click += (sender, e) => agregarPersonal();
        }

        public void agregarPersonal()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "INSERT INTO tbProductos (productoNombre, productoPrecio, productoTipo) " +
                                 "VALUES (@productoNombre, @productoPrecio, @productoTipo)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
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
