using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
                    //Se ejecutara un query donde se obtendran los valores de la base de datos, se usa un inner join 
                    //dado a que userType es una llave foranea
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT u.productId, u.productName, u.productType, r.roleName, " +
                        "FROM users u " +
                        "INNER JOIN userRoles r ON u.userRole = r.roleId " +
                        "WHERE r.roleName = 'Admin'", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listCortes.Items.Clear();

                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["userId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["userPassword"].ToString());
                            item.SubItems.Add(reader["userPoints"].ToString());
                            item.SubItems.Add(reader["roleName"].ToString());
                            item.SubItems.Add(reader["userEmail"].ToString());
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
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string query = @"
                    INSERT INTO users (userName, userPassword, userPoints, userRole, userEmail)
                    VALUES (
                    @Id, 
                    @Nombre, 
                    @Precio, 
                    @Tipo
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@Id", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@Nombre", vistaPasada.txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Precio", vistaPasada.txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@Tipo", vistaPasada.txtTipo.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
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
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se ejecutara un query update donde se hara que  valores de la tabla usuarios en la base de datos
                    //sean iguales a los que estan en las textboxes
                    using (SqlCommand cmd = new SqlCommand("" +
                        "UPDATE users SET " +
                        "userName = @userName, " +
                        "userPoints = @userPoints, " +
                        "userPassword = @userPassword, " +
                        "userRole = (SELECT roleId FROM userRoles WHERE roleName = @roleName), " +
                        "userEmail = @userEmail " +
                        "WHERE userId = @selectedId", conexion))
                    {
                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@selectedId", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@userName", vistaPasada.txtNombre.Text);
                        cmd.Parameters.AddWithValue("@userPassword", vistaPasada.txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@userPoints", vistaPasada.txtTipo.Text);

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
                    string sql = "DELETE FROM users WHERE userId = @toDelete";

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
                SELECT userId, userName, userPassword, userPoints, userRole, userEmail
                FROM users
                WHERE userName LIKE @searchingFor AND userRole = 1";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //4 Como parametro se utilizara el valor ingresado en la barra de busqueda
                        cmd.Parameters.AddWithValue("@searchingFor", "%" + searchingFor + "%");

                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listCortes.Items.Clear();

                        //5 Se anadiran a la tabla del formulario los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["userId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["userPassword"].ToString());
                            item.SubItems.Add(reader["userPoints"].ToString());
                            item.SubItems.Add(reader["userRole"].ToString());
                            item.SubItems.Add(reader["userEmail"].ToString());
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
