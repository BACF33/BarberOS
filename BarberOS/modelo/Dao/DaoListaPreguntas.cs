using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Modelo.Dao
{
    internal class DaoListaPreguntas
    {
        public void insertar(vistaListaPreguntas vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string query = @"
                    INSERT INTO questions (questionUserName, questionHome, questionB, userRole, userEmail, userBirthPlace)
                    VALUES (
                    @userName, 
                    @userPassword, 
                    @userPoints, 
                    (SELECT roleId FROM userRoles WHERE roleName = @roleName),
                    @userEmail,
                    @userBirthPlace
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@userName", vistaPasada.txtUser.Text);
                        cmd.Parameters.AddWithValue("@userHome", vistaPasada.txtHome.Text);
                        cmd.Parameters.AddWithValue("@userBirth", vistaPasada.txtBirth.Text);
                        cmd.Parameters.AddWithValue("@userSchool", vistaPasada.txtSchool.Text);
                        cmd.Parameters.AddWithValue("@userFavorite", vistaPasada.txtFavorite.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    //Test
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
