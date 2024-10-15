using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dto
{
    public class DtoRecuperar
    {
        private SmtpClient cliente;

        protected string remitente { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int puerto { get; set; }
        protected bool ssl { get; set; }

        protected void IniciarCliente()
        {
            cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential(remitente, password);
            cliente.Host = host;
            cliente.Port = puerto;
            cliente.EnableSsl = ssl;
        }

        public void EnviarCorreo(string asunto, string contenido, List<string> destino)
        {
            var mensaje = new MailMessage();
            try
            {
                mensaje.From = new MailAddress(remitente);
                foreach(string mail in destino)
                {
                    mensaje.To.Add(mail);
                }
                mensaje.Subject = asunto;
                mensaje.Body = contenido;
                mensaje.Priority = MailPriority.Normal;
                cliente.Send(mensaje);
            }
            catch (Exception){}
            finally
            { 
                mensaje.Dispose();
                cliente.Dispose();
            }
        }

        public string restablecer(string solicitando)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM usuarios WHERE userName = @userName or userEmail = @userEmail";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userName", solicitando);
                        cmd.Parameters.AddWithValue("@userEmail", solicitando);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string userName = reader.GetString(1);
                            string userEMail = reader.GetString(3);
                            string userPassword = reader.GetString(5);

                            var servicioCorreo = new DtoServicioCorreo();
                            servicioCorreo.EnviarCorreo(
                                asunto: "Reestablecimiento de contraseña",
                                contenido: "Test",
                                destino: new List<string> { userEMail }
                                );
                            return "test";
                        }
                        else
                            return "testF";
                    }
                }
            }
            catch (Exception)
            {
                return "testF2";
            }
        }
    }
}
