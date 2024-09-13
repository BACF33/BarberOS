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
    public partial class VistaListaRespuestas : Form
    {
        public VistaListaRespuestas(vistaMenu menuPasado)

        {
            InitializeComponent();
            new ControlListaRespuestas(this, menuPasado);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
