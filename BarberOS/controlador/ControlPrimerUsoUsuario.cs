using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlPrimerUsoUsuario
    {
        DaoPrimerUsoUsuario primer = new DaoPrimerUsoUsuario();
        DaoMenu porNegocio = new DaoMenu();
        ControlMenu control;
        VistaPrimerUsoUsuario vistaControlada;

        public ControlPrimerUsoUsuario(VistaPrimerUsoUsuario vistaPasada, ControlMenu pasadoControl)
        {
            vistaControlada = vistaPasada;
            control = pasadoControl;
            //Cuando se presione enviar se ejecutararegistrarformulario
            vistaPasada.btnEnviar.Click += (sender, e) => RegistrarFormulario(vistaPasada);
            vistaPasada.imgSeleccionada.Click += (sender, e) => LoadImage();
        }
        public void RegistrarFormulario(VistaPrimerUsoUsuario vistaPasada)
        {
            if(vistaControlada.txtContraseña.Text.Equals("") || vistaControlada.txtEmail.Text.Equals("") || vistaControlada.txtName.Text.Equals("") || vistaControlada.txtPuntos.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                //Se ejecutara la funcion registrar del dao
                primer.Registrar(vistaPasada);
                //Se verificara si ademas no hay un negocio vinculado
                porNegocio.PrimerNegocio(control);


            }
        }

        //Funcion para que cuando el usuario presione la picturebox abra el explorador de archivos y el usuario suba una imagen al picturebox
        public void LoadImage()
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                vistaControlada.imgSeleccionada.Image = Image.FromFile(dialogo.FileName);
                vistaControlada.imgSeleccionada.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

    }
}
