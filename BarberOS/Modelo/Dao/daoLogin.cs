using System;
using System.Windows.Forms;
using BarberOS.Modelo.Dto;
using System.Data.SqlClient;
using System.Data;

namespace BarberOS.Modelo.Dao
{
    //Esta clase (dao) es hija de (dto) por lo que dto se ejecuta aqui
    public class DaoLogin : DtoLogin
    {
        //Un tipo de dato que rastrea el comando ejecutado actual
        SqlCommand command = new SqlCommand();

        public int Login()
        {
            try
            {
                //Funcion para conectarse a la base de datos
                command.Connection = getConnection();
                command.CommandText = "sp_Login";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userName", UserName);
                command.Parameters.AddWithValue("@userPass", UserPass);
                string result = command.ExecuteScalar().ToString();
                return result == UserName ? 1 : 0;
            }
            //Si lo de arriba falla (el intento) lo de abajo se ejecuta)
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            //Cerrar la conexion, se ejecuta sin importar el caso ejecutado
            finally { getConnection().Close(); }
        }
    }
}