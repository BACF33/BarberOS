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
    public partial class PanelBarbero : UserControl
    {
        public PanelBarbero(string passedId, string passedName, string passedRole)
        {
            InitializeComponent();
            ControlPanelBarbero controladorPanelBarbero = new ControlPanelBarbero(this, passedId, passedName, passedRole);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
