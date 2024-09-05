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
        public DaoTotal(DtoPanelPromocion pasadaPromocion, DtoPanelProducto pasadoProducto, vistaMenu pasadoMenu) 
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string query = @"
                    INSERT INTO registries (userId, productId, promotion, total)
                    VALUES (
                    (SELECT userId FROM users WHERE userName = @userName),
                    (SELECT productId FROM products WHERE productName = @productName),
                    (SELECT promotionId FROM promotions WHERE promotionName = @promotionName),
                    @total
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", pasadoMenu.btnCurrentUser.Text);
                        cmd.Parameters.AddWithValue("@productName", pasadoProducto.ProductoName);
                        cmd.Parameters.AddWithValue("@promotionName", pasadaPromocion.PromocionName);
                        cmd.Parameters.AddWithValue("@total", pasadaPromocion.PromocionId);
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