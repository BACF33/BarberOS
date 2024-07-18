using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaListaBarbero : Form
    {
        public vistaListaBarbero()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            //ListViewItem lista = new ListViewItem(txtNuevoNombre.Text);
            //lista.SubItems.Add(txtNuevaContraseña.Text);
            //lista.SubItems.Add(txtNuevoFull.Text);
            //lista.SubItems.Add(txtNuevoCargo.Text); 
            //listEmpleados.Items.Add(lista);
            insertData();
        }

        public void getData()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbUser", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Clear existing items in ListView
                        listEmpleados.Items.Clear();

                        // Read data and populate ListView
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["userId"].ToString());
                            item.SubItems.Add(reader["userId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["userPass"].ToString());
                            item.SubItems.Add(reader["userRealName"].ToString());
                            item.SubItems.Add(reader["userRole"].ToString());
                            listEmpleados.Items.Add(item);
                        }

                        reader.Close(); // Close the reader
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void insertData()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "INSERT INTO tbUser (userName, userPass, userRealName, userRole) " +
                                 "VALUES (@userName, @userPass, @userRealName, @userRole)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@userPass", txtNuevaContraseña.Text);
                        cmd.Parameters.AddWithValue("@userRealName", txtNuevoFull.Text);
                        cmd.Parameters.AddWithValue("@userRole", txtNuevoCargo.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizarEmpleados_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
