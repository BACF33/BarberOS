using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class controlAgregarPersonal
    {
        vistaAgregarPersonal controladaVista = null;
        public controlAgregarPersonal(vistaAgregarPersonal pasadaVista)
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
                    string sql = "INSERT INTO tbUser (userName, userPass, userRealName, userRole) " +
                                 "VALUES (@userName, @userPass, @userRealName, @userRole)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", controladaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@userPass", controladaVista.txtNuevaContraseña.Text);
                        cmd.Parameters.AddWithValue("@userRealName", controladaVista.txtNuevoFull.Text);
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
