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
            //Cuando se presion agregar se ejecutara la funcion agregarCliente
            controladaVista.btnAgregar.Click += (sender, e) => agregarCliente();
        }

        public void agregarCliente()
        {
            daoAgregarCliente daoThis = new daoAgregarCliente();

            //1 Al dto o a la informacion que se usara en el query se le asigna la informacion que el usuario ingreso
            //en el textbox
            daoThis.UserName = controladaVista.txtNuevoNombre.Text;

            //2 Similar a como se obtiene la informacion del usuario pero con la contraseña que antes se usa con sha256
            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(controladaVista.txtNuevaContraseña.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.Password = builder.ToString();
            }

            //3 Similar a como se obtiene la informacion del usuario pero con puntos
            daoThis.Points = int.Parse(controladaVista.txtNuevoFull.Text);

            daoThis.Phone = controladaVista.txtNuevoNumero.Text;

            //4 Se ejecutara la funcion agregar del dao
            daoThis.agregar();
        }
    }
}