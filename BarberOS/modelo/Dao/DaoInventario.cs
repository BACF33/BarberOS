using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
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
                    using (SqlCommand cmd = new SqlCommand("SELECT p.productId, p.productName, p.productPrice, p.productQuantity, p.productImage " +
                        "FROM products p " +
                        "WHERE productType = 3", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listEmpleados.Items.Clear();

                        ImageList imageList = new ImageList();
                        imageList.ImageSize = new System.Drawing.Size(64, 64);
                        vistaPasada.listEmpleados.SmallImageList = imageList;

                        int index = 0;

                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["productId"].ToString());
                            item.SubItems.Add(reader["productName"].ToString());
                            item.SubItems.Add(reader["productPrice"].ToString());
                            item.SubItems.Add(reader["productQuantity"].ToString());
                            item.SubItems.Add(reader["productImage"].ToString());

                            if (!DBNull.Value.Equals(reader["productImage"]))
                            {
                                byte[] imageData = (byte[])reader["productImage"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    Image productImage = Image.FromStream(ms);
                                    imageList.Images.Add(productImage);
                                }
                                item.ImageIndex = index;
                                index++;
                            }

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
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    MemoryStream archivoMemoria = new MemoryStream();
                    vistaPasada.picProducto.Image.Save(archivoMemoria, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] imageData = archivoMemoria.ToArray();

                    string query = @"
                    INSERT INTO products (productName, productPrice, productType, productQuantity, productImage)
                    VALUES (
                    @Nombre, 
                    @Precio, 
                    @Tipo,
                    @Cantidad,
                    @Imagen
                    )";

                    conexion.Open();
                    

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@Nombre", vistaPasada.txtName.Text);
                        cmd.Parameters.AddWithValue("@Precio", vistaPasada.txtPrice.Text);
                        cmd.Parameters.AddWithValue("@Tipo", 3);
                        cmd.Parameters.AddWithValue("@Cantidad", vistaPasada.txtQuant.Text);
                        cmd.Parameters.AddWithValue("@Imagen", imageData);

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
            string selectedId = vistaPasada.listEmpleados.SelectedItems[0].Text;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string sql = "DELETE FROM products WHERE productId = @toDelete";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@toDelete", selectedId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        public void Update(VistaInventario vistaPasada)
        {
            MemoryStream archivoMemoria = new MemoryStream();
            vistaPasada.picProducto.Image.Save(archivoMemoria, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageBytes = archivoMemoria.ToArray();

            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("" +
                        "UPDATE products SET " +
                        "productName = @Name, " +
                        "productPrice = @Price, " +
                        "productQuantity = @Quant, " +
                        "productImage = @Image " +
                        "WHERE productId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@Name", vistaPasada.txtName.Text);
                        cmd.Parameters.AddWithValue("@Price", vistaPasada.txtPrice.Text);
                        cmd.Parameters.AddWithValue("@Quant", vistaPasada.txtQuant.Text);
                        cmd.Parameters.AddWithValue("@Image", imageBytes);

                        cmd.ExecuteNonQuery();
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
