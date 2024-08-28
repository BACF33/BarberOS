using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlGetPin
    {
        vistaInsertarPin vistaControlada;
        int pin2;
        string user2;
        public controlGetPin(int pin, vistaInsertarPin vistaPasada, string user) 
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
                vistaNuevaContraseña nPass = new vistaNuevaContraseña(user2);
                nPass.Show();
                vistaControlada.Close();
            }


        }
    }
}
