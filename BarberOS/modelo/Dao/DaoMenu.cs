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
                    //7 Se ejecutara un query que obtenga la informacion que tenga la casilla con la id seleccionada
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE userId= 999", conexion))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Se han mostrado datos");
                        }
                        else

                        {
                            controlPasado.AbrirFormulario(new VistaPrimerUsoUsuario());
                            controlPasado.controladaVista.btnAgendar.Visible = false;
                            controlPasado.controladaVista.btnBarberos.Visible = false;
                            controlPasado.controladaVista.btnCortes.Visible = false; 
                            controlPasado.controladaVista.btnCurrentUser.Visible = false;
                            controlPasado.controladaVista.btnInicio.Visible = false;
                            controlPasado.controladaVista.btnIngresar.Visible = false;
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

