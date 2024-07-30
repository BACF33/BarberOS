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

        private void vistaInicio_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
