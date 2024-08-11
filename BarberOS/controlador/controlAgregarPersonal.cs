using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class controlAgregarPersonal
    {
        vistaAgregarPersonal controladaVista = null;
        public controlAgregarPersonal(vistaAgregarPersonal pasadaVista)
        {
            controladaVista = pasadaVista;
            controladaVista.btnAgregar.Click += (sender, e) => agregarPersonal();
        }

        public void agregarPersonal() 
        {
            daoAgregarPersonal daoThis = new daoAgregarPersonal();
            daoThis.UserName = controladaVista.txtNuevoNombre.Text;

            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(controladaVista.txtNuevaContraseña.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.Password = builder.ToString();
            }

            daoThis.Points = int.Parse(controladaVista.txtNuevoFull.Text);
            daoThis.Role = controladaVista.txtNuevoCargo.Text;
            daoThis.insert ();
        }
    }
}
