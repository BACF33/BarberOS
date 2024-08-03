using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class controlListaPromocionesG
    {
        private vistaMenu menuForm;
        private vistaListaPromocionesG controladaVista;
        public controlListaPromocionesG(vistaListaPromocionesG passedVista, vistaMenu passedMenu)
        {
            menuForm = passedMenu;
            controladaVista = passedVista;
            controladaVista.btnActualizarPromocion.Click += (sender, e) => getData();
            controladaVista.btnBorrarPromocion.Click += (sender, e) => deleteData();
            controladaVista.btnAgregarPromocion.Click += (sender, e) => insertData();
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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbPromociones", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        controladaVista.listPromociones.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["promocionId"].ToString());
                            item.SubItems.Add(reader["promocionNombre"].ToString());
                            item.SubItems.Add(reader["promocionPrecio"].ToString());
                            item.SubItems.Add(reader["promocionTipo"].ToString());
                            item.SubItems.Add(reader["promocionPoder"].ToString());
                            item.SubItems.Add(reader["promocionId"].ToString());
                            controladaVista.listPromociones.Items.Add(item);
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
            if (controladaVista.listPromociones.SelectedItems.Count > 0)
            {
                string selectedId = controladaVista.listPromociones.SelectedItems[0].Text;
                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        string sql = "DELETE FROM tbPromociones WHERE userId = @toDelete";

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

        public void insertData()
        {
            vistaAgregarPromocion agregarPromocion = new vistaAgregarPromocion();
            agregarPromocion.Show();
        }
    }
}
