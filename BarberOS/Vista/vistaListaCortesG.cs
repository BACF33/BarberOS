using BarberOS.Controlador;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaListaCortesG : Form
    {
        public vistaListaCortesG(vistaMenu menuForm)
        {
            InitializeComponent();
            controlListaCortesG controladorVista = new controlListaCortesG(this, menuForm);
        }
    }

}