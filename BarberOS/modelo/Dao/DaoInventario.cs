using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BarberOS.Modelo.Dao
{
    internal class DaoInventario
    {
        public void Obtener(VistaInventario vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Se ejecutara un query donde se obtendran los valores de la base de datos, se usa un inner join 
                    //dado a que userType es una llave foranea
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT p.productId, p.productName, p.productPrice, t.productTypeName, p.productImage " +
                        "FROM products p " +
                        "INNER JOIN productTypes t ON productType = t.productTypeId " +
                        "WHERE productType = 3", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listEmpleados.Items.Clear();

                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["productId"].ToString());
                            item.SubItems.Add(reader["productName"].ToString());
                            item.SubItems.Add(reader["productPrice"].ToString());
                            item.SubItems.Add(reader["productTypeName"].ToString());
                            item.SubItems.Add(reader["productImage"].ToString());
                            vistaPasada.listEmpleados.Items.Add(item);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        public void Insert(VistaInventario vistaPasada)
        {
            MemoryStream archivoMemoria = new MemoryStream();
            vistaPasada.picProducto.Image.Save(archivoMemoria, ImageFormat.Bmp);
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string query = @"
                    INSERT INTO products (productName, productPrice, productType, productQuantity)
                    VALUES (
                    @Nombre, 
                    @Precio, 
                    (SELECT productTypeId FROM productTypes WHERE productTypeName = @Tipo),
                    @Cantidad
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@Nombre", vistaPasada.txtName.Text);
                        cmd.Parameters.AddWithValue("@Precio", vistaPasada.txtPrice.Text);
                        cmd.Parameters.AddWithValue("@Tipo", "Producto");
                        cmd.Parameters.AddWithValue("@Cantidad", vistaPasada.txtQuant.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        public void Borrar(VistaInventario vistaPasada)
        {
            MemoryStream archivoMemoria = new MemoryStream();
            vistaPasada.picProducto.Image.Save(archivoMemoria, ImageFormat.Bmp);
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string query = @"
                    INSERT INTO products (productName, productPrice, productType, productQuantity)
                    VALUES (
                    @Nombre, 
                    @Precio, 
                    (SELECT productTypeId FROM productTypes WHERE productTypeName = @Tipo),
                    @Cantidad
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@Nombre", vistaPasada.txtName.Text);
                        cmd.Parameters.AddWithValue("@Precio", vistaPasada.txtPrice.Text);
                        cmd.Parameters.AddWithValue("@Tipo", "Producto");
                        cmd.Parameters.AddWithValue("@Cantidad", vistaPasada.txtQuant.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }
    }
}
