using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlRegister
    {
        vistaRegister controladaVista;
        daoRegister daoThis = new daoRegister();
        public controlRegister(vistaRegister pasadaVista) 
        {
            controladaVista = pasadaVista;
            controladaVista.btnRegister.Click += (sender, e) => register();
        }

        public void register() 
        {
            daoThis.NewUser = controladaVista.txtNewUser.Text;

            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(controladaVista.txtNewPass.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.NewPassword = builder.ToString();
            }

            daoThis.register();
        }
    }
}
