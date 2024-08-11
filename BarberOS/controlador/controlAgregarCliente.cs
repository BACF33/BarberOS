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
    internal class controlAgregarCliente
    {
        vistaAgregarCliente controladaVista = null;
        public controlAgregarCliente(vistaAgregarCliente pasadaVista)
        {
            controladaVista = pasadaVista;
            controladaVista.btnAgregar.Click += (sender, e) => agregarProducto();
        }

        public void agregarProducto()
        {
            daoAgregarCliente daoThis = new daoAgregarCliente();
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
            daoThis.agregar();
        }
    }
}
