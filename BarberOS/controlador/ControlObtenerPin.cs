using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlObtenerPin
    {
        VistaInsertarPin vistaControlada;
        int pin2;
        string user2;
        public ControlObtenerPin(int pin, VistaInsertarPin vistaPasada, string user) 
        {
            pin2 = pin;
            user2 = user;
            vistaControlada = vistaPasada;
            vistaPasada.btnConfirmar.Click += (sender, e) => verifyPin();
        }

        private void verifyPin() 
        {
            if (vistaControlada.txtPin.Text == pin2.ToString())
            {
                VistaNuevaContraseña nPass = new VistaNuevaContraseña(user2);
                nPass.Show();
                vistaControlada.Close();
            }


        }
    }
}
