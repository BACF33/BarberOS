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
    internal class daoListaRegistros
    {
        public daoListaRegistros(vistaListaRegistros controladaVista) 
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbRegistro", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        controladaVista.listRegistros.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["registroId"].ToString());

                            item.SubItems.Add(reader["registroProductoNombre"].ToString());
                            item.SubItems.Add(reader["registroProductoTipo"].ToString());
                            item.SubItems.Add(reader["registroProductoPrecio"].ToString());

                            item.SubItems.Add(reader["registroPromocionNombre"].ToString());
                            item.SubItems.Add(reader["registroPromocionPrecio"].ToString());
                            item.SubItems.Add(reader["registroPromocionPoder"].ToString());


                            controladaVista.listRegistros.Items.Add(item);
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
