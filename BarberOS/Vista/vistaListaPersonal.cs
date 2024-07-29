using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarberOS.Vista;

namespace BarberOS.Vista
{
    public partial class vistaListaPersonal : Form
    {
        private vistaMenu mainForm;
        vistaListaPersonalG fuenteInfoPersonal;

        public vistaListaPersonal()
        {
            InitializeComponent();
            fuenteInfoPersonal = new vistaListaPersonalG(mainForm);
        }

        private void cargarProductos()
        {
        }
    }
}
