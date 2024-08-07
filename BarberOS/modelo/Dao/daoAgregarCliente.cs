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
    internal class daoAgregarCliente
    {
        public daoAgregarCliente(vistaAgregarCliente controladaVista)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "INSERT INTO tbUser (userName, userPass, userPoints, userRole) " +
                                 "VALUES (@userName, @userPass, @userPoints, @userRole)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", controladaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@userPass", controladaVista.txtNuevaContraseña.Text);
                        cmd.Parameters.AddWithValue("@userPoints", controladaVista.txtNuevoFull.Text);
                        cmd.Parameters.AddWithValue("@userRole", controladaVista.txtNuevoCargo.Text);

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
