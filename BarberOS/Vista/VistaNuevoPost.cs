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
    public partial class VistaNuevoPost : Form
    {
        public VistaNuevoPost(vistaMenu menuPasado)
        {
            InitializeComponent();
            new ControlNuevoPost(this, menuPasado);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
