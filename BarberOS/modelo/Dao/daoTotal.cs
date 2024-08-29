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
    internal class DaoTotal
    {
        public DaoTotal(DtoPanelPromocion pasadaPromocion, DtoPanelProducto pasadoProducto) 
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "INSERT INTO registries (registryProductName, registryProductPrice, registryPromotionName, registryPromotionPower) " +
                                 "VALUES (@productName, @productPrice, @promotionName, @promotionPower) ";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@productName", pasadoProducto.ProductoId);
                        cmd.Parameters.AddWithValue("@productPrice", pasadoProducto.ProductoId);
                        cmd.Parameters.AddWithValue("@promotionName", pasadaPromocion.PromocionId);
                        cmd.Parameters.AddWithValue("@promotionPower", pasadaPromocion.PromocionId);
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