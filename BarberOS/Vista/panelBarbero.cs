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
    public partial class panelBarbero : UserControl
    {
        public panelBarbero(string passedId, string passedName, string passedRole)
        {
            InitializeComponent();
            controlPanelBarbero controladorPanelBarbero = new controlPanelBarbero(this, passedId, passedName, passedRole);
        }
    }
}
