using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using BarberOS.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlCitas
    {
        DaoCitas daoThis = new DaoCitas();
        vistaCitas vistaControlada;
        vistaMenu menuControlado;
        public ControlCitas(vistaCitas vistaPasada, vistaMenu menuPasado) 
        {
            menuControlado = menuPasado;
            vistaControlada = vistaPasada;
            //Cuando se presione el boton agendar se ejecutara la funcion agendar
            vistaPasada.btnAgendar.Click += (sender, e) => Agendar();
        }

        public void Agendar()
        {
            //Se ejecutara la funcion insertar del dao
            if (menuControlado.btnCurrentUser.Text != "No has iniciado sesion")
                daoThis.Insertar(vistaControlada);
            else
            {
                MessageBox.Show("Es necesario iniciar sesion");
                menuControlado.controladorMenu.AbrirFormulario(new VistaInicio(menuControlado));
            }
        }
    }
}
