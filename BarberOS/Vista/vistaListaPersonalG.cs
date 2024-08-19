using BarberOS.Controlador;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaListaPersonalG : Form
    {
        public vistaListaPersonalG(vistaMenu menuForm)
        {
            InitializeComponent();
            controlListaPersonalG controladorVista = new controlListaPersonalG(this, menuForm);
        }

        private void vistaListaPersonalG_Load(object sender, EventArgs e)
        {

        }
    }
}
