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
        //c//
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}