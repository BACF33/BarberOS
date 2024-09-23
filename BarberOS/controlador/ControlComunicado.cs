using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlComunicado
    {
        public ControlComunicado(string testText, string testPoster, string testPrivacy, PanelComunicado vistaPasada) 
        {
            vistaPasada.txtPoster.Text = testPoster;
            vistaPasada.txtTexto.Text = testText;
        }
    }
}
