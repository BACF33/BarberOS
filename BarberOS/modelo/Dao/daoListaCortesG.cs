using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BarberOS.Modelo.Dao
{
    internal class DaoListaCortesG
    {
        public void Populate(VistaListaCortesG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se define un query con inner joins para obtener los datos de la tabla
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT p.productId, p.productName, p.productPrice, t.productTypeName, p.productImage " +
                        "FROM products p " +
                        "INNER JOIN productTypes t ON productType = t.productTypeId ", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listCortes.Items.Clear();

                        ImageList imageList = new ImageList();
                        imageList.ImageSize = new System.Drawing.Size(64, 64);
                        vistaPasada.listCortes.SmallImageList = imageList;

                        int index = 0;

                        while (reader.Read())
                        {
                            //Se añadiran los daots obtenidos a la lista en la aplicacion
                            ListViewItem item = new ListViewItem(reader["productId"].ToString());
                            item.SubItems.Add(reader["productName"].ToString());
                            item.SubItems.Add(reader["productPrice"].ToString());
                            item.SubItems.Add(reader["productTypeName"].ToString());

                            //Se convierten los datos binarios de la imagen a imagen para poder ser vista
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

                            vistaPasada.listCortes.Items.Add(item);
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

        public void Insert(VistaListaCortesG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Se convierte la imagen a datos binarios para ingresarse en la tabla
                    MemoryStream archivoMemoria = new MemoryStream();
                    vistaPasada.picProducto.Image.Save(archivoMemoria, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] imageData = archivoMemoria.ToArray();

                    //Se define un insert para ingresar datos a la tabla
                    string query = @"
            INSERT INTO products (productName, productPrice, productType, productImage)
            VALUES (
            @Nombre, 
            @Precio, 
            (SELECT productTypeId FROM productTypes WHERE productTypeName = @Tipo), 
            @Imagen
            )";

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usan como parametros los valores del panel izquierdo
                        cmd.Parameters.AddWithValue("@Nombre", vistaPasada.txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Precio", vistaPasada.txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@Tipo", vistaPasada.cmbTipo.Text);
                        cmd.Parameters.AddWithValue("@Imagen", imageData);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(VistaListaCortesG vistaPasada)
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

                    //Se define un query para actualizar la tabla productos
                    using (SqlCommand cmd = new SqlCommand("" +
                        "UPDATE products SET " +
                        "productName = @Name, " +
                        "productPrice = @Price, " +
                        "productType = (SELECT productTypeId FROM productTypes WHERE productTypeName = @Type), " +
                        "productImage = @Image " +
                        "WHERE productId = @selectedId", conexion))
                    {
                        //Se usan como parametros los valores del panel izquierdo
                        cmd.Parameters.AddWithValue("@selectedId", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@Name", vistaPasada.txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Price", vistaPasada.txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@Type", vistaPasada.cmbTipo.Text);
                        cmd.Parameters.AddWithValue("@Image", imageBytes);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(VistaListaCortesG vistaPasada)
        {
            string selectedId = vistaPasada.listCortes.SelectedItems[0].Text;
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
                MessageBox.Show(ex.ToString());
            }
        }

        public void searchData(string searchingFor, VistaListaCortesG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    //3 Se ejecutara un query donde se seleccionaran toos los datos de la tabla usuarios donde 
                    //el nombre de usuario coincida con el ingresado
                    string sql = @"
                    SELECT p.productId, p.productName, p.productType, p.productPrice, t.productTypeName
                    FROM products p
                    INNER JOIN productTypes t ON p.productType = t.productTypeId
                    WHERE p.productName LIKE @searchingFor";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //4 Como parametro se utilizara el valor ingresado en la barra de busqueda
                        cmd.Parameters.AddWithValue("@searchingFor", "%" + searchingFor + "%");

                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listCortes.Items.Clear();

                        //5 Se anadiran a la tabla del formulario los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["productId"].ToString());
                            item.SubItems.Add(reader["productName"].ToString());
                            item.SubItems.Add(reader["productPrice"].ToString());
                            item.SubItems.Add(reader["productType"].ToString());
                            vistaPasada.listCortes.Items.Add(item);
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
