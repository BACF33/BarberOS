using BarberOS.Controlador;
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
    public partial class VistaPublicarComunicado : Form
    {
        public VistaPublicarComunicado(vistaMenu menuPasado)
        {
            InitializeComponent();
            new ControlPublicarComunicado(this, menuPasado);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_3(object sender, PaintEventArgs e)
        {

        }
    }
}
