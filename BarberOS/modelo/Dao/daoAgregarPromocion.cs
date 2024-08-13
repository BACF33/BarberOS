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
    internal class daoAgregarPromocion
    {
        public daoAgregarPromocion(vistaAgregarPromocion controladaVista)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    conexion.Open();
                    //Se ejecutara un query donde se insertara a la tabla de la base de datos los valores ingresados por
                    //el usuario en los textboxes
                    string sql = "INSERT INTO promotions (promotionName, promotionPrice, promotionPower, promotionType) " +
                                 "VALUES (@promocionNombre, @promocionPrecio, @promocionPoder, @promocionTipo)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //Como parametros se utilizaran los valores obtenidos anteriormente de los textboxes
                        cmd.Parameters.AddWithValue("@promocionNombre", controladaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@promocionPrecio", controladaVista.txtNuevoPrecio.Text);
                        cmd.Parameters.AddWithValue("@promocionTipo", controladaVista.txtNuevoTipo.Text);
                        cmd.Parameters.AddWithValue("@promocionPoder", controladaVista.txtNuevoPoder.Text);

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
