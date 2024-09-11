using BarberOS.Modelo.Dao;
using BarberOS.Vista;

namespace BarberOS.Controlador
{
    internal class ControlPrimerLogin
    {
        VistaPrimerLogin vistaControlada;
        DaoPrimerLogin daoThis;
        public ControlPrimerLogin(VistaPrimerLogin vistaPasada)
        {
            vistaControlada = vistaPasada;
            //vistaControlada.btnNueva.Click += daoThis.
        }
    }
}
