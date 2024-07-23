using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaListaPersonalG : Form
    {
        private vistaMenu mainForm;
        public vistaListaPersonalG(vistaMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void btnActualizarEmpleados_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void btnBorrarEmpleados_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void btnACortes_Click(object sender, EventArgs e)
        {
            mainForm.AbrirFormulario(new vistaListaCortesG(mainForm));
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

                        listEmpleados.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["userId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["userPass"].ToString());
                            item.SubItems.Add(reader["userRealName"].ToString());
                            item.SubItems.Add(reader["userRole"].ToString());
                            item.SubItems.Add(reader["userId"].ToString());
                            listEmpleados.Items.Add(item);
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

        public void deleteData()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "DELETE FROM tbUser WHERE userId = @toDelete";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@toDelete", txtToKill.Text);
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
