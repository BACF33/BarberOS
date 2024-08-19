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
        //8 Constructo del formulario login, cuando se cree se ejecutara lo de aqui
        public vistaLogin(vistaMenu passedMenuForm) 
       {
            InitializeComponent();
            //9 Como todas las vistas se creara el controlador para el formulario vistaLogin y se pasara a si mismo,
            //tambien se pasara el menu para que pueda acceder a su funcion para abrir formularios a su derecha con la
            //funcion AbrirFormulario (ver controlMenu)
            controlLogin controladorLogin = new controlLogin(this, passedMenuForm);
        }
    }
}