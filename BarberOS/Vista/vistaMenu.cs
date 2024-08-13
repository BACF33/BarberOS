using BarberOS.Controlador;
using BarberOS.Vistas;
using System;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaMenu : Form
    {
        public controlMenu controladorMenu;
        //2 Este es un constructor, lo que esta dentro de el se ejecutara cuando se cree el formulario
        public vistaMenu()
        {
            InitializeComponent();
            //3 Como todos los formularios se creara un archivo de codigo para controlar todos los eventos en el formulario
            //como cuando el usuario presione un boton, le pasara al controlador el mismo para que esten conectados
            controladorMenu = new controlMenu(this);
        }

    }
}