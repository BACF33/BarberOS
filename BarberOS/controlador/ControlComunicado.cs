using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlComunicado
    {
        public ControlComunicado(string testText, string testPoster, string testPrivacy, PanelComunicado vistaPasada, byte[] imageData) 
        {

            vistaPasada.txtPoster.Text = testPoster;
            vistaPasada.txtTexto.Text = testText;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image convertida = Image.FromStream(ms);
                vistaPasada.picPerfil.Image = convertida;
            }
        }
    }
}
