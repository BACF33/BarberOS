﻿using BarberOS.Controlador;
using BarberOS.Modelo.Dto;
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
    public partial class VistaListaPromociones : Form
    {
        public VistaListaPromociones(vistaMenu pasadoMenu, DtoPanelProducto seleccionadoProducto)
        {
            InitializeComponent();
            ControlListaPromociones controladorVista = new ControlListaPromociones(this, pasadoMenu, seleccionadoProducto);
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
