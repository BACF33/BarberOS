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
            //Cuando se presione el boton nueva se ejecutara nuevacontraseña
            vistaPasada.btnNueva.Click += (sender, e) => nuevaContraseña();
        }

        public void nuevaContraseña()
        {
            //Se ejecutara la funcion nuevacontraseña del dao y se cerrara el formulario activo
            daoThis.nuevaContaseña(vistaControlada, user);
            vistaControlada.Close();
        }
    }
}
