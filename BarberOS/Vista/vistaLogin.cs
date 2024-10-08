  using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;
using BarberOS.Vistas;
using BarberOS.Controlador;

namespace BarberOS.Vista
{
    public partial class vistaLogin : Form
    {
        //Este es un constructor, lo que esta dentro de el se ejecutara cuando se cree el formulario
        public vistaLogin(vistaMenu passedMenuForm)
        {
            InitializeComponent();
            //Como todos los formularios se creara un archivo de codigo "controlador" para controlar todos los eventos en el formulario
            //como cuando el usuario presione un boton, al crear el controlador se le pasara a este la vista como referencia (no copia) para que esten conectados
            ControlLogin controladorLogin = new ControlLogin(this, passedMenuForm);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        //Funcion para que en algunos textboxes no sea posible insertar caracteres aparte de letras
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuevaContraseñaV(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Codigo que anulara los comandos ctrC y ctrlV que puedan suceder en este formulario
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestPass_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
