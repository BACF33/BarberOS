using BarberOS.Controlador;
using System;
using System.Configuration;
using System.Data.SqlClient;
//using System.Windows;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaListaCortesG : Form
    {
        public VistaListaCortesG(vistaMenu menuForm)
        {
            InitializeComponent();
            ControlListaCortesG controladorVista = new ControlListaCortesG(this, menuForm);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            //No permite ni copiar ni pegar
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void listCortes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}