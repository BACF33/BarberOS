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
            //Aqui se evaluara cuando el usuario presione uno de los botones del menu, dependiendo del que toque la 
            //funcion de la izquierda se evaluara (si toca el boton agendar se ejecutara agendar())
            vistaPasada.btnAgendar.Click += (sender, e) => Agendar();
        }

        public void Agendar()
        {
            //Se verificara si el usuario ha iniciado sesion o no revisando el usuario actual
            if (menuControlado.btnCurrentUser.Text != "No has iniciado sesion")
                daoThis.Insertar(vistaControlada); //En caso de que haya iniciado sesion se ejecutara la funcion insertar del dao
            else
            {
                //De lo contrario mostrara un mensaje y el programa se volvera a vista inicio
                MessageBox.Show("Es necesario iniciar sesion");
                menuControlado.controladorMenu.AbrirFormulario(new VistaInicio(menuControlado));
            }
        }
    }
}
