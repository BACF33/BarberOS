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
            vistaControlada.btnNueva.Click += (sender, e) => Insert(userPasado);
        }

        public void Insert(string userPasado)
        {
            daoThis.Insert(vistaControlada, userPasado);
            menu.controladorMenu.AbrirFormulario(new vistaLogin(menu));
        }
    }
}
