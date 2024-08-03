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
    internal class controlAgregarPromocion
    {
        vistaAgregarPromocion controladaVista = null;
        public controlAgregarPromocion (vistaAgregarPromocion pasadaVista)
        {
            controladaVista = pasadaVista;
            controladaVista.btnAgregar.Click += (sender, e) => agregarPersonal();
        }

        public void agregarPersonal()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "INSERT INTO tbPromociones (promocionNombre, promocionPrecio, promocionPoder, promocionTipo) " +
                                 "VALUES (@promocionNombre, @promocionPrecio, @promocionPoder, @promocionTipo)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
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
