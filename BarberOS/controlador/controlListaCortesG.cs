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

namespace BarberOS.Controlador
{
    internal class controlListaCortesG
    {
        private vistaMenu menuForm;
        private vistaListaCortesG controladaVista;

        public controlListaCortesG(vistaListaCortesG pasadaVista, vistaMenu passedMenuForm)
        {
            controladaVista = pasadaVista;
            menuForm = passedMenuForm;
            controladaVista.btnActualizarEmpleados.Click += (sender, e) => getData();
            controladaVista.btnBorrarEmpleados.Click += (sender, e) => deleteData();
            controladaVista.btnAPersonal.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaListaPersonalG(passedMenuForm));
            getData();
        }

        public void getData()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbProductos", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        controladaVista.listCortes.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["productoId"].ToString());
                            item.SubItems.Add(reader["productoNombre"].ToString());
                            item.SubItems.Add(reader["productoPrecio"].ToString());
                            item.SubItems.Add(reader["productoTipo"].ToString());
                            item.SubItems.Add(reader["productoId"].ToString());
                            controladaVista.listCortes.Items.Add(item);
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

        public void deleteData()
        {
            if (controladaVista.listCortes.SelectedItems.Count > 0)
            {
                string selectedId = controladaVista.listCortes.SelectedItems[0].Text;
                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        string sql = "DELETE FROM tbProductos WHERE productoId = @toDelete";

                        using (SqlCommand cmd = new SqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@toDelete", selectedId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                getData();
            }
        }
    }
}