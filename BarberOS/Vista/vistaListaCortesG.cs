using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaListaCortesG : Form
    {
        private vistaMenu mainForm;
        public vistaListaCortesG(vistaMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnACortes_Click(object sender, System.EventArgs e)
        {
            mainForm.AbrirFormulario(new vistaListaPersonalG(mainForm));
        }

        private void btnAgregarCortes_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void btnActualizarCortes_Click(object sender, EventArgs e)
        {
            getData();
        }
        private void btnBorrarCortes_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        public void getData()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbCortes", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        listCortes.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["corteId"].ToString());
                            item.SubItems.Add(reader["corteNombre"].ToString());
                            item.SubItems.Add(reader["cortePrecio"].ToString());
                            item.SubItems.Add(reader["corteTipo"].ToString());
                            item.SubItems.Add(reader["corteDisponible"].ToString());
                            item.SubItems.Add(reader["corteId"].ToString());
                            listCortes.Items.Add(item);
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
                    string sql = "INSERT INTO tbCortes (corteNombre, cortePrecio, corteTipo, corteDisponible) " +
                                 "VALUES (@corteName, @cortePrecio, @corteTipo, @corteDisponible)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@corteNombre", txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@cortePrecio", txtNuevoPrecio.Text);
                        cmd.Parameters.AddWithValue("@corteTipo", txtNuevoTipo.Text);
                        cmd.Parameters.AddWithValue("@corteDisponible", txtNuevoDisponible.Text);

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
                    string sql = "DELETE FROM tbCortes WHERE corteId = @toDelete";

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