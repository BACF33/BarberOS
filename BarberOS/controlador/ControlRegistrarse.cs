using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlRegistrarse
    {
        vistaRegister controladaVista;
        DaoRegistrarse daoThis = new DaoRegistrarse();
        public ControlRegistrarse(vistaRegister pasadaVista) 
        {
            controladaVista = pasadaVista;
            //Cuando se presione el boton de registrarse se ejecutara la funcion reister
            controladaVista.btnRegister.Click += (sender, e) => register();
            controladaVista.picClientes.Click += (sender, e) => LoadImage();
        }

        public void register() 
        {
            //El dto usuario del dao o los datos que usara para los queries sera asignado al textbox usuario
            daoThis.NewUser = controladaVista.txtNewUser.Text;

            //Se realizara algo similar a lo anterior pero con la contrasena y antes la encriptara
            using (SHA256 crypt = SHA256.Create())
            {
                byte[] bytes = crypt.ComputeHash(Encoding.UTF8.GetBytes(controladaVista.txtNewPass.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("X2"));
                daoThis.NewPassword = builder.ToString();
            }

            daoThis.NewEmail = controladaVista.txtNewMail.Text;

            //Se ejecutara la funcion register del dao
            daoThis.register(controladaVista);
        }

        public void LoadImage()
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                controladaVista.picClientes.Image = Image.FromFile(dialogo.FileName);
                controladaVista.picClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
