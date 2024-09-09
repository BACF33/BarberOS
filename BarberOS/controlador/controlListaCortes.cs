using BarberOS.Modelo.Dao;
using BarberOS.Vista;

namespace BarberOS.Controlador
{
    internal class ControlListaCortes
    {
        VistaListaCortes controladaVista;
        public ControlListaCortes(VistaListaCortes enviadaVista, vistaMenu pasadoMenu)
        {
            controladaVista = enviadaVista;
            DaoListaCortes daoThis = new DaoListaCortes(enviadaVista, pasadoMenu);
        }
    }//s
}