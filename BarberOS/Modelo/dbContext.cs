using System;
using System.Data.SqlClient;


namespace BarberOS.Modelo
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {
                string server = "DESKTOP-9KMTQB1\\SQLEXPRESS";
                string database = "BarberOS";
                SqlConnection conexion = new SqlConnection("Server =" + server +
                                                                 "; DataBase = " + database +
                                                                 "; Integrated Security = true");
                conexion.Open();
                return conexion;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
