using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlNuevaContraseña
    {
        VistaNuevaContraseña vistaControlada;
        DaoNuevaContraseña daoThis;
        string user;
        public ControlNuevaContraseña(VistaNuevaContraseña vistaPasada, string userPasado)
        {
            vistaControlada = vistaPasada;
            daoThis = new DaoNuevaContraseña();
            user = userPasado;
            vistaPasada.btnNueva.Click += (sender, e) => nuevaContraseña();
        }

        public void nuevaContraseña()
        {
            daoThis.nuevaContaseña(vistaControlada, user);
            vistaControlada.Close();
        }
    }
}
