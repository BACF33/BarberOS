using BarberOS.Controlador;
using System;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaInicioGestion : Form
    {
        public VistaInicioGestion(vistaMenu passedForm)
        {
            InitializeComponent();
            //vistaInicioGestion creara su controlador al ser creada usando el constructor
            ControlInicioGestion controladorInicioGestion = new ControlInicioGestion(this, passedForm);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}