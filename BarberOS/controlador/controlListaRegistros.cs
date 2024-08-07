using BarberOS.Modelo.Dao;
using BarberOS.Vista;

namespace BarberOS.Controlador
{
    internal class controlListaRegistros
    {
        public controlListaRegistros(vistaListaRegistros controladaVista) 
        {
            daoListaRegistros daoThis = new daoListaRegistros(controladaVista);
        }
    }
}