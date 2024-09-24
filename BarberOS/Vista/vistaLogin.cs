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
        //8 Constructo del formulario login, cuando se cree se ejecutara lo de aqui
        public vistaLogin(vistaMenu passedMenuForm)
        {
            InitializeComponent();
            //9 Como todas las vistas se creara el controlador para el formulario vistaLogin y se pasara a si mismo,
            //tambien se pasara el menu para que pueda acceder a su funcion para abrir formularios a su derecha con la
            //funcion AbrirFormulario (ver controlMenu)
            ControlLogin controladorLogin = new ControlLogin(this, passedMenuForm);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuevaContraseñaV(object sender, KeyPressEventArgs e)
        {
            //if (txtPassword.TextLength > 49)
            e.Handled = true;
        }

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
