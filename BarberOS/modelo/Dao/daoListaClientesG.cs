using BarberOS.Vista;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BarberOS.Modelo.Dao
{
    internal class DaoListaClientesG
    {
        public void Populate(VistaListaClientesG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Se ejecutara un query donde se obtendran los valores de la base de datos, se usa un inner join 
                    //dado a que userType es una llave foranea
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT u.userId, u.userName, u.userPassword, u.userPoints, r.roleName, u.userEmail, u.userBirthPlace " +
                        "FROM users u " +
                        "INNER JOIN userRoles r ON u.userRole = r.roleId " +
                        "WHERE r.roleName = 'Cliente'", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listClientes.Items.Clear();

                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["userId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["userPassword"].ToString());
                            item.SubItems.Add(reader["userPoints"].ToString());
                            item.SubItems.Add(reader["roleName"].ToString());
                            item.SubItems.Add(reader["userEmail"].ToString());
                            item.SubItems.Add(reader["userBirthPlace"].ToString());
                            vistaPasada.listClientes.Items.Add(item);
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

        public void Insert(VistaListaClientesG vistaPasada)
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
                    @userName, 
                    @userPassword, 
                    @userPoints, 
                    (SELECT roleId FROM userRoles WHERE roleName = @roleName),
                    @userEmail,
                    @userBirthPlace
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {

                        string password = vistaPasada.txtContraseña.Text;
                        using (SHA256 crypt = SHA256.Create())
                        {
                            byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < bytes.Length; i++)
                                builder.Append(bytes[i].ToString("X2"));
                            password = builder.ToString();
                        }

                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@userName", vistaPasada.txtName.Text);
                        cmd.Parameters.AddWithValue("@userPassword", password);
                        cmd.Parameters.AddWithValue("@userPoints", vistaPasada.txtPuntos.Text);
                        cmd.Parameters.AddWithValue("@roleName", "Cliente");
                        cmd.Parameters.AddWithValue("@userEmail", vistaPasada.txtEmail.Text);
                        cmd.Parameters.AddWithValue("@userBirthPlace", vistaPasada.txtLugar.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(VistaListaClientesG vistaPasada)
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
                        "userEmail = @userEmail, " +
                        "userBirthPlace = @userBirthPlace " +
                        "WHERE userId = @selectedId", conexion))
                    {

                        string password = vistaPasada.txtContraseña.Text;
                        using (SHA256 crypt = SHA256.Create())
                        {
                            byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < bytes.Length; i++)
                                builder.Append(bytes[i].ToString("X2"));
                            password = builder.ToString();
                        }

                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@selectedId", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@userName", vistaPasada.txtName.Text);
                        cmd.Parameters.AddWithValue("@userPassword", password);
                        cmd.Parameters.AddWithValue("@userPoints", vistaPasada.txtPuntos.Text);
                        cmd.Parameters.AddWithValue("@roleName", "Cliente");
                        cmd.Parameters.AddWithValue("@userEmail", vistaPasada.txtEmail.Text);
                        cmd.Parameters.AddWithValue("@userBirthPlace", vistaPasada.txtLugar.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(VistaListaClientesG vistaPasada)
        {
            string selectedId = vistaPasada.listClientes.SelectedItems[0].Text;
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

        public void searchData(string searchingFor, VistaListaClientesG vistaPasada)
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
                SELECT userId, userName, userPassword, userPoints, userRole, userEmail, userBirthPlace
                FROM users
                WHERE userName LIKE @searchingFor AND userRole = 2";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //4 Como parametro se utilizara el valor ingresado en la barra de busqueda
                        cmd.Parameters.AddWithValue("@searchingFor", "%" + searchingFor + "%");

                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listClientes.Items.Clear();

                        //5 Se anadiran a la tabla del formulario los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["userId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["userPassword"].ToString());
                            item.SubItems.Add(reader["userPoints"].ToString());
                            item.SubItems.Add(reader["userRole"].ToString());
                            item.SubItems.Add(reader["userEmail"].ToString());
                            item.SubItems.Add(reader["userBirthPlace"].ToString());
                            vistaPasada.listClientes.Items.Add(item);
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