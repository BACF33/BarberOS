using BarberOS.Modelo.Dao;
using BarberOS.Vista;

namespace BarberOS.Controlador
{
    internal class controlListaCortes
    {
        vistaListaCortes controladaVista;
        public controlListaCortes(vistaListaCortes enviadaVista, vistaMenu pasadoMenu)
        {
            controladaVista = enviadaVista;
            daoListaCortes daoThis = new daoListaCortes(enviadaVista, pasadoMenu);
        }
    }
}