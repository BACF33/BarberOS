using BarberOS.Controlador;
using BarberOS.Vistas;
using System;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaMenu : Form
    {
        public controlMenu controladorMenu;
        public vistaMenu()
        {
            InitializeComponent();
            controladorMenu = new controlMenu(this);
        }
    }
}