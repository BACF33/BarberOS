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
    internal class daoControlTotal
    {
        public daoControlTotal(panelPromocion pasadaPromocion, string passedName, string passedPrice) 
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "INSERT INTO tbRegistro (registroProductoNombre, registroProductoPrecio, registroPromocionNombre, registroPromocionPrecio, registroPromocionPoder) " +
                                 "VALUES (@registroProductoNombre, @registroProductoPrecio, @registroPromocionNombre, @registroPromocionPrecio, @registroPromocionPoder)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@registroProductoNombre", passedName);
                        cmd.Parameters.AddWithValue("@registroProductoPrecio", passedPrice);
                        cmd.Parameters.AddWithValue("@registroPromocionNombre", pasadaPromocion.lblName.Text);
                        cmd.Parameters.AddWithValue("@registroPromocionPrecio", pasadaPromocion.lblPrecio.Text);
                        cmd.Parameters.AddWithValue("@registroPromocionPoder", pasadaPromocion.lblPoder.Text);
                        MessageBox.Show("Bien");
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
