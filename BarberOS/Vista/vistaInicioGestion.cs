using System;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaInicioGestion : Form
    {
        private vistaMenu mainForm;
        public vistaInicioGestion(vistaMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            mainForm.AbrirFormulario(new vistaListaBarbero());
        }
    }
}
