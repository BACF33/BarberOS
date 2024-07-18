using BarberOS.Vistas;
using System;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaMenu : Form
    {
        private Form currentForm = null;

        public vistaMenu()
        {
            InitializeComponent();
        }

        public void AbrirFormulario(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                PanelContenedor.Controls.Remove(currentForm);
            }

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Opacity = 0.75;

            PanelContenedor.Controls.Add(form);
            PanelContenedor.Tag = form;
            form.Show();
            form.BringToFront();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new vistaLogin(this));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new vistaInicio());
        }

        private void btnBarberos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new vistaBarberos());
        }

        private void btnCortes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new vistaCortes());
        }
    }
}