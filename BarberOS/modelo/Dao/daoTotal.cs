using BarberOS.Modelo.Dto;
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
    internal class daoTotal
    {
        public daoTotal(dtoPanelPromocion pasadaPromocion, dtoPanelProducto pasadoProducto) 
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "INSERT INTO registries (registryProductName, registryProductPrice, registryPromotionName, registryPromotionPower) " +
                                 "VALUES (@registryProductName, @registryProductPrice, @registryPromotionName, @registryPromotionPower) ";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@registryProductName", pasadoProducto.ProductoId);
                        cmd.Parameters.AddWithValue("@registryProductPrice", pasadoProducto.ProductoId);
                        cmd.Parameters.AddWithValue("@registryPromotionName", pasadaPromocion.PromocionId);
                        cmd.Parameters.AddWithValue("@registryPromotionPower", pasadaPromocion.PromocionId);
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
