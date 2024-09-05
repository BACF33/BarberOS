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
    internal class DaoListaRegistrosG
    {
        public void Populate(VistaListaRegistros vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Se ejecutara un query donde se obtendran los valores de la base de datos, se usa un inner join 
                    //dado a que userType es una llave foranea
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT r.registryId, u.userName, p.productName, p.productPrice, pr.promotionName, pr.promotionPower, r.total " +
                        "FROM registries r " +
                        "INNER JOIN users u ON r.userId = u.userId " +
                        "INNER JOIN products p ON r.productId = p.productId " +
                        "INNER JOIN promotions pr ON r.promotion = pr.promotionId", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listRegistros.Items.Clear();

                        // Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["registryId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["productName"].ToString());
                            item.SubItems.Add(reader["productPrice"].ToString());
                            item.SubItems.Add(reader["promotionName"].ToString());
                            item.SubItems.Add(reader["promotionPower"].ToString());
                            item.SubItems.Add(reader["total"].ToString());
                            vistaPasada.listRegistros.Items.Add(item);
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

        public void Insert(VistaListaRegistros vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string query = @"
                    INSERT INTO registries (userId, productId, promotion, total)
                    VALUES (
                    (SELECT userId FROM users WHERE userName = @userName),
                    (SELECT productId FROM products WHERE productName = @productName),
                    (SELECT promotionId FROM promotions WHERE promotionName = @promotionName),
                    @total
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@userName", vistaPasada.txtUser.Text);
                        cmd.Parameters.AddWithValue("@productName", vistaPasada.txtProduct.Text);
                        cmd.Parameters.AddWithValue("@promotionName", vistaPasada.txtPromotion.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(VistaListaRegistros vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se ejecutara un query update donde se hara que  valores de la tabla usuarios en la base de datos
                    //sean iguales a los que estan en las textboxes
                    using (SqlCommand cmd = new SqlCommand("" +
                        "UPDATE promotions SET " +
                        "promotionName = @Name, " +
                        "promotionPrice = @Price, " +
                        "promotionPower = @Power, " +
                        "promotionType = (SELECT promotionTypeId FROM promotionTypes WHERE promotionTypeName = @Type)" +
                        "WHERE promotionId = @selectedId", conexion))
                    {
                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@selectedId", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@Name", vistaPasada.txtUser.Text);
                        cmd.Parameters.AddWithValue("@Price", vistaPasada.txtProduct.Text);
                        cmd.Parameters.AddWithValue("@Power", vistaPasada.txtPromotion.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(VistaListaRegistros vistaPasada)
        {
            string selectedId = vistaPasada.listRegistros.SelectedItems[0].Text;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string sql = "DELETE FROM promotions WHERE promotionId = @toDelete";

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

        public void searchData(string searchingFor, VistaListaRegistros vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    //3 Se ejecutara un query donde se seleccionaran toos los datos de la tabla usuarios donde 
                    //el nombre de usuario coincida con el ingresado
                    string sql = "SELECT  p.promotionId, p.promotionName, p.promotionPrice, t.promotionTypeName " +
                        "FROM promotions p " +
                        "INNER JOIN promotionTypes t ON promotionType = t.promotionTypeId LIKE @searchingFor AND userRole = 1 ";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //4 Como parametro se utilizara el valor ingresado en la barra de busqueda
                        cmd.Parameters.AddWithValue("@searchingFor", "%" + searchingFor + "%");

                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listRegistros.Items.Clear();

                        //5 Se anadiran a la tabla del formulario los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["promotionId"].ToString());
                            item.SubItems.Add(reader["promotionName"].ToString());
                            item.SubItems.Add(reader["promotionPrice"].ToString());
                            item.SubItems.Add(reader["promotionPower"].ToString());
                            item.SubItems.Add(reader["promotionType"].ToString());
                            vistaPasada.listRegistros.Items.Add(item);
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
