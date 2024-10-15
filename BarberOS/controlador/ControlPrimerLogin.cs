using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System.Windows.Controls;

namespace BarberOS.Controlador
{
    internal class ControlPrimerLogin
    {
        VistaPrimerLogin vistaControlada;
        DaoPrimerLogin daoThis = new DaoPrimerLogin();
        vistaMenu menu;
        public ControlPrimerLogin(VistaPrimerLogin vistaPasada, string userPasado, vistaMenu pasadoMenu)
        {
            vistaControlada = vistaPasada;
            menu = pasadoMenu;
            //Cuando se presione nueva se ejecutara insert
            vistaControlada.btnNueva.Click += (sender, e) => Insert(userPasado);
        }

        public void Insert(string userPasado)
        {
            //Se ejecutara insert y abrira el formulario de vista login
            daoThis.Insert(vistaControlada, userPasado);
            menu.controladorMenu.AbrirFormulario(new vistaLogin(menu));
        }
    }
}
