using BarberOS.Controlador;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Vistas
{
    public partial class vistaInicio : Form
    {
        public vistaInicio(vistaMenu menuForm)
        {
            InitializeComponent();
            controlInicio controladorInicio = new controlInicio(this, menuForm);
        }
    }
}
