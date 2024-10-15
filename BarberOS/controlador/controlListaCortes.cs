using BarberOS.Modelo.Dao;
using BarberOS.Vista;

namespace BarberOS.Controlador
{
    internal class ControlListaCortes
    {
        //Se declaran variables en un bloque exterior para que puedan ser usadas en todo el archivo, la mayoria nulas para luego asignarlas a las correspondientes
        VistaListaCortes controladaVista;
        public ControlListaCortes(VistaListaCortes enviadaVista, vistaMenu pasadoMenu)
        {
            controladaVista = enviadaVista;
            //Solo se ejecutara la funcion del constructor del dao para obtener los cortes
            DaoListaCortes daoThis = new DaoListaCortes(enviadaVista, pasadoMenu);
        }
    }
}