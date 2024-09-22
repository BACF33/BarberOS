using BarberOS.Controlador;
using BarberOS.Vistas;
using System;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaMenu : Form
    {
        public ControlMenu controladorMenu;
        //2 Este es un constructor, lo que esta dentro de el se ejecutara cuando se cree el formulario
        public vistaMenu()
        {
            InitializeComponent();
            //3 Como todos los formularios se creara un archivo de codigo para controlar todos los eventos en el formulario
            //como cuando el usuario presione un boton, le pasara al controlador el mismo para que esten conectados
            controladorMenu = new ControlMenu(this);
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

        private void vistaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCortes_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}