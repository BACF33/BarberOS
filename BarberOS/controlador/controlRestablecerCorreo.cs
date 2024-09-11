using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BarberOS.Vista;
using System.Windows;
using BarberOS.Modelo.Dao;

namespace BarberOS.Controlador
{
    internal class ControlRestablecerCorreo
    {
        DaoRestablecerCorreo daoThis = new DaoRestablecerCorreo();
        vistaRestablecerCorreo vistaControlada;
        public ControlRestablecerCorreo(vistaRestablecerCorreo vistaPasada, vistaMenu menuPasado)
        {
            vistaControlada = vistaPasada;
            vistaControlada.btnEnviar.Click += (sender, e) => Enviar();
            vistaControlada.btnOtro.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new 
VistaReestablecerAdmin());
            vistaControlada.btnPreguntas.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new
vistaRestablecerPreguntas(menuPasado));
        }
        public void SendEmail(string recipientEmail, string subject, string body)
        {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential("bacubias76@gmail.com", "czfn rlzl hveh ifan");
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(recipientEmail);
                mailMessage.To.Add(recipientEmail);
                mailMessage.Subject = subject;
                mailMessage.Body = body;

                smtpClient.Send(mailMessage);
        }

        private void getPin(int pin)
        {
            VistaInsertarPin insertarPin = new VistaInsertarPin(pin, vistaControlada.txtUser.Text);
            insertarPin.Show();
            vistaControlada.Close();
        }


        private void Enviar()
        {
            Random rnd = new Random();
            int pin = rnd.Next(99999);

            if (daoThis.verificarCorreo(vistaControlada.txtUser.Text, vistaControlada.txtEmail.Text))
            {
                SendEmail(vistaControlada.txtEmail.Text, "Test asunto mvc", "Test contenido mvc " + pin);
                getPin(pin);
            }
            else
                MessageBox.Show("El correo no es valido");
        }
    }
}