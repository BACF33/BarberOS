﻿using BarberOS.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaAgregarProducto : Form
    {
        public vistaAgregarProducto()
        {
            InitializeComponent();
            controlAgregarProducto controladorVista = new controlAgregarProducto(this);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        private void nuevoNombreV(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (txtNuevoNombre.TextLength > 49)
                e.Handled = true;
        }


        private void nuevoPrecioV(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if(txtNuevoPrecio.TextLength > 5)
                e.Handled = true;
        }

        private void nuevoTipoV(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (txtNuevoTipo.TextLength > 10)
                e.Handled = true;
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
