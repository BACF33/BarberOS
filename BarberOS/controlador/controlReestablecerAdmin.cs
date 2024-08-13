using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlReestablecerAdmin
    {
        vistaReestablecerAdmin vistaControlada;
        daoRestablecerAdmin daoThis = new daoRestablecerAdmin();

        //3 Constructor para este controlador
        public controlReestablecerAdmin(vistaReestablecerAdmin pasadaVista) 
        {
            //4 Las funciones de la derecha se ejecutaran cuando en la vista el usuario presione los botones designados 

            //5 Si se presiona iniciar sesion se ejecutara la funcion checkAdmin)
            pasadaVista.btnRestablecer.Click += (sender, e) => checkAdmin();
            //6 Si se presiona restablecer se ejecutara la funcion checkAdmin)
            pasadaVista.btnDo.Click += (sender, e) => doChange();
            //7 Si se presiona recuerdas tu id se ejecutara la funcion checkAdmin)
            pasadaVista.btnRecoverId.Click += (sender, e) => checkId();
            vistaControlada = pasadaVista;
        }

        public void checkAdmin()
        {
            //1 Al dto o a la informacion que se usara en el query se le asigna la informacion que el usuario ingreso
            //en el textbox
            daoThis.Username = vistaControlada.txtUser.Text;

            //2 Similar a como se obtiene la informacion del usuario pero con la contraseña que antes se usa con sha256
            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(vistaControlada.txtPass.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.Password = builder.ToString();
            }

            //3 Se ejecutara la funcion restpass del dao y si devuelve 1 se volvera invisible el panel donde el admin debe iniciar sesion
            if (daoThis.restpass() == 1)
            {
                vistaControlada.pnl1.Visible = false;
            }
        }

        public void checkId()
        {
            daoThis.UserName2 = vistaControlada.txtUserId.Text;
            daoThis.Id = int.Parse(vistaControlada.txtRecoverId.Text); 

            if (daoThis.restPass2() == 1)
            {
                vistaControlada.pnl1.Visible = false;
            }
        }

        //Esto solo podra pasar si el panel que taba lo de reestablecer contraseña no es visible
        public void doChange()
        {
            //1 Al dto o a la informacion que se usara en el query se le asigna la informacion que el usuario ingreso
            //en el textbox
            daoThis.NewName = vistaControlada.txtNUser.Text;

            //2 Similar a como se obtiene la informacion del usuario pero con la contraseña que antes se usa con sha256
            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(vistaControlada.txtNPass.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.NewPass = builder.ToString();
            }

            //3 Se ejecutara la funcion dochange del dao donde se actualizara la contraseña a restablecer
            daoThis.doChange();
        }
    }
}