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
    internal class daoListaRegistrosG
    {
        vistaListaRegistros controladaVista;

        public daoListaRegistrosG(vistaListaRegistros pasadaVista) 
        {
            controladaVista = pasadaVista;
        }
        public void getData()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    // Simplified SQL query with JOINs
                    string sql = @"
                SELECT r.registryId, 
                       p.productName, p.productPrice, 
                       prm.promotionName, prm.promotionPower,
                       r.registryTotal
                FROM registries r
                JOIN products p ON r.productName = p.productId
                JOIN promotions prm ON r.promotionName = prm.promotionId";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        controladaVista.listRegistros.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["registryId"].ToString())
                            {
                                SubItems = {
                            reader["productName"].ToString(),
                            reader["productPrice"].ToString(),
                            reader["promotionName"].ToString(),
                            reader["promotionPower"].ToString(),
                            reader["registryTotal"].ToString()
                        }
                            };
                            controladaVista.listRegistros.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteData(vistaListaRegistros vistaPasada)
        {
            string selectedId = vistaPasada.listRegistros.SelectedItems[0].Text;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "DELETE FROM registries WHERE registryId = @toDelete";

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
        }

    }
}
