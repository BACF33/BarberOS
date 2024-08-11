using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
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
            vistaControlada = pasadaVista;
        }

        public void checkAdmin()
        {
            daoThis.Username = vistaControlada.txtUser.Text;
            daoThis.Password = vistaControlada.txtPass.Text;

            if (daoThis.restpass() == 1)
            {
                vistaControlada.pnl1.Visible = false;
            }
        }

        public void doChange()
        {
            daoThis.NewName = vistaControlada.txtNUser.Text;
            daoThis.NewPass = vistaControlada.txtNPass.Text;
            daoThis.doChange();
        }
    }
}
