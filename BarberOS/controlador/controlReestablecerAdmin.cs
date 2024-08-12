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
        public controlReestablecerAdmin(vistaReestablecerAdmin pasadaVista) 
        { 
            pasadaVista.btnRestablecer.Click += (sender, e) => checkAdmin();
            pasadaVista.btnDo.Click += (sender, e) => doChange();
            pasadaVista.btnRecoverId.Click += (sender, e) => checkId();
            vistaControlada = pasadaVista;
        }

        public void checkAdmin()
        {
            daoThis.Username = vistaControlada.txtUser.Text;

            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(vistaControlada.txtPass.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.Password = builder.ToString();
            }

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

        public void doChange()
        {
            daoThis.NewName = vistaControlada.txtNUser.Text;

            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(vistaControlada.txtNPass.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.NewPass = builder.ToString();
            }

            daoThis.doChange();
        }
    }
}
