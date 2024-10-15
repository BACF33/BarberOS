using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Controlador
{
    internal class ControlReestablecerPreguntas
    {
        DaoReestablecerPreguntas daoThis = new DaoReestablecerPreguntas();
        vistaRestablecerPreguntas vistaControlada;
        vistaMenu menu;
        public ControlReestablecerPreguntas(vistaRestablecerPreguntas vistaPasada, vistaMenu menuPasado) 
        {
            vistaControlada = vistaPasada;
            menu = menuPasado;
            daoThis.PopulateQuestions(vistaControlada);
            vistaControlada.btnRestablecer.Click += (sender, e) => Restablecer();
        }

        public void Restablecer() 
        {
            if (daoThis.Restpass(vistaControlada) == 1)
            {
                menu.controladorMenu.AbrirFormulario(new VistaNuevaContraseña(vistaControlada.txtUser.Text));
            }
            else
                MessageBox.Show("Mal");
        }
    }
}
