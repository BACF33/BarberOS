using BarberOS.Controlador;
using System;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaInicioGestion : Form
    {
        private vistaMenu menuForm;
        public vistaInicioGestion(vistaMenu passedForm)
        {
            InitializeComponent();
            controlInicioGestion controladorInicioGestion = new controlInicioGestion(this, menuForm);
        }
    }
}
