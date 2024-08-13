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

                    string sql = @"
                SELECT r.registryId, 
                       p.productName, p.productPrice, 
                       prm.promotionName, prm.promotionPower,
                       r.registryTotal
                FROM registries r
                INNER JOIN products p ON r.registryProductName = p.productId
                INNER JOIN promotions prm ON r.registryPromotionName = prm.promotionId";

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

        public void searchData(string searchingFor, vistaListaRegistros vistaPasada)
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
                SELECT registryId, registryProductName, registryProductPrice, registryPromotionName, registryPromotionPower
                FROM registries
                WHERE registryId LIKE @searchingFor";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //4 Como parametro se utilizara el valor ingresado en la barra de busqueda
                        cmd.Parameters.AddWithValue("@searchingFor", "%" + searchingFor + "%");

                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listRegistros.Items.Clear();

                        //5 Se anadiran a la tabla del formulario los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["registryId"].ToString());
                            item.SubItems.Add(reader["registryProductName"].ToString());
                            item.SubItems.Add(reader["registryProductPrice"].ToString());
                            item.SubItems.Add(reader["registryPromotionName"].ToString());
                            item.SubItems.Add(reader["registryPromotionPower"].ToString());
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
