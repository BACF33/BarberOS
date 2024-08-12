using BarberOS.Controlador;
using System;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaInicioGestion : Form
    {
        public vistaInicioGestion(vistaMenu passedForm)
        {
            InitializeComponent();
            controlInicioGestion controladorInicioGestion = new controlInicioGestion(this, passedForm);
        }

    }
}
