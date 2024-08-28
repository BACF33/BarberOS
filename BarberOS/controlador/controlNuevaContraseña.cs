using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlNuevaContraseña
    {
        vistaNuevaContraseña vistaControlada;
        daoNuevaContraseña daoThis;
        string user;
        public controlNuevaContraseña(vistaNuevaContraseña vistaPasada, string userPasado)
        {
            vistaControlada = vistaPasada;
            daoThis = new daoNuevaContraseña();
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
