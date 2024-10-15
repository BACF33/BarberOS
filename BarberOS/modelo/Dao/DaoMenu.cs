using BarberOS.Controlador;
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
    public class DaoMenu
    {
        public void VerificarPrimerUso(ControlMenu controlPasado)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Query que hara un select * a la tabla de usuarios
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM users", conexion))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Se han mostrado datos");
                            PrimerNegocio(controlPasado);
                        }
                        else
                        {
                            //Si no detecta datos se ejecuta lo de primer uso
                            controlPasado.AbrirFormulario(new VistaPrimerUsoUsuario(controlPasado));
                            controlPasado.controladaVista.pnlAgendar.Visible = false;
                            controlPasado.controladaVista.pnlBarberos.Visible = false;
                            controlPasado.controladaVista.pnlCortes.Visible = false; 
                            controlPasado.controladaVista.btnCurrentUser.Visible = false;
                            controlPasado.controladaVista.pnlInicio.Visible = false;
                            controlPasado.controladaVista.pnlIngresar.Visible = false;
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception)
            {
                controlPasado.AbrirFormulario(new VistaConfigServidor(controlPasado.controladaVista));
            }
        }

        public void PrimerNegocio(ControlMenu controlPasado)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Query que hara un select * a la tabla de negocios
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM business", conexion))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Se ha registrado un negocio");
                        }
                        else
                        {
                            //Si no detecta datos se ejecuta lo de primer uso
                            controlPasado.AbrirFormulario(new VistaPrimerUsoNegocio());
                            controlPasado.controladaVista.pnlAgendar.Visible = false;
                            controlPasado.controladaVista.pnlBarberos.Visible = false;
                            controlPasado.controladaVista.pnlCortes.Visible = false;
                            controlPasado.controladaVista.btnCurrentUser.Visible = false;
                            controlPasado.controladaVista.pnlInicio.Visible = false;
                            controlPasado.controladaVista.pnlIngresar.Visible = false;
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