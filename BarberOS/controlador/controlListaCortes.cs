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
            //Solo se ejecutara la funcion del constructor del dao para obtener los cortes
            DaoListaCortes daoThis = new DaoListaCortes(enviadaVista, pasadoMenu);
        }
    }//s
}