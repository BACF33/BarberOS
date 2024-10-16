using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Modelo.Dao
{
    internal class DaoOrdenes
    {
        public void Populate(VistaOrdenes vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Se ejecutara un query donde se obtendran los valores de la base de datos, se usa un inner join 
                    //dado a que userType es una llave foranea
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT orderId, u.userName, o.orderTime, o.orderText " +
                        "FROM orders o " +
                        "INNER JOIN users u ON u.userId = o.orderUser", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listEmpleados.Items.Clear();

                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["orderId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["orderTime"].ToString());
                            item.SubItems.Add(reader["orderText"].ToString());

                            vistaPasada.listEmpleados.Items.Add(item);
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

        public void PopulateUsers(VistaOrdenes vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT userName FROM users", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.cmbUsers.Items.Clear();

                        while (reader.Read())
                        {
                            vistaPasada.cmbUsers.Items.Add(reader["userName"].ToString());
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

        public void Insert(VistaOrdenes vistaPasada)
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
                    INSERT INTO orders (orderUser, orderTime, orderText)
                    VALUES (
                    (SELECT userId FROM users WHERE userName = @orderUser),
                    @orderTime,
                    @orderText
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@orderUser", vistaPasada.cmbUsers.Text);
                        cmd.Parameters.AddWithValue("@orderTime", vistaPasada.dtpTime.Value);
                        cmd.Parameters.AddWithValue("@orderText", vistaPasada.txtOrder.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    //Test
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(VistaOrdenes vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se ejecutara un query update donde se hara que  valores de la tabla usuarios en la base de datos
                    //sean iguales a los que estan en las textboxes
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE orders SET " +
                        "orderUser = (SELECT userId FROM users WHERE userName = @userName), " +
                        "orderTime = @orderDate, " +
                        "orderText = @orderText " +
                        "WHERE orderId = @selectedId", conexion))
                    {

                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@selectedId", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@userName", vistaPasada.cmbUsers.Text);
                        cmd.Parameters.AddWithValue("@orderDate", vistaPasada.dtpTime.Value);
                        cmd.Parameters.AddWithValue("@orderText", vistaPasada.txtOrder.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(VistaOrdenes vistaPasada)
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
                    string sql = "DELETE FROM orders WHERE orderId = @toDelete";

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
    }
}
