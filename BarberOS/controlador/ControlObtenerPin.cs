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
        vistaMenu menuControlado;

        int pin2;
        string user2;
        public ControlObtenerPin(int pin, VistaInsertarPin vistaPasada, string user, vistaMenu menuPasado) 
        {
            menuControlado = menuPasado;
            pin2 = pin;
            user2 = user;
            vistaControlada = vistaPasada;
            //Al presionarse el boton confirmar se ejecutara verifyPin
            vistaPasada.btnConfirmar.Click += (sender, e) => verifyPin();
        }

        private void verifyPin() 
        {
            //Se verificara que el ping ingresado por el usuario sea el mismo que se le envio a su email
            if (vistaControlada.txtPin.Text == pin2.ToString())
            {
                menuControlado.controladorMenu.AbrirFormulario(new VistaNuevaContraseña(user2));
            }
        }
    }
}
