using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;
using BarberOS.Vistas;
using BarberOS.Controlador;

namespace BarberOS.Vista
{
    public partial class vistaLogin : Form
    {
        public vistaLogin(vistaMenu passedMenuForm) 
       {
            InitializeComponent();
            controlLogin controladorLogin = new controlLogin(this, passedMenuForm);
        }
    }
}