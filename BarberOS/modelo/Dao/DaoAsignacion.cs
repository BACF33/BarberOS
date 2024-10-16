using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Modelo.Dao
{
    internal class DaoAsignacion
    {
        public void Eliminar(PanelAsignacion pasadoPanel)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string sql = "DELETE FROM orders WHERE orderId = @toDelete";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@toDelete", pasadoPanel.controladorThis.panelId);
                        MessageBox.Show(pasadoPanel.controladorThis.panelId.ToString());
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
