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
    public partial class vistaListaClientesG : Form
    {
        public vistaListaClientesG(vistaMenu passedMenu)
        {
            InitializeComponent();
            controlListaClientesG controladorVista = new controlListaClientesG(this, passedMenu);
        }
    }
}
