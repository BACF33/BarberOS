using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using BarberOS.Vistas;

namespace BarberOS.Controlador
{
    internal class controlTotal
    {
        public controlTotal(vistaMenu pasadoMenu, vistaRecompensas enviadaVista, panelPromocion pasadaPromocion, string passedName, string passedPrice) 
        {

            enviadaVista.btnConfirmar.Click += (sender, e) => ConfirmarYSalir(pasadoMenu, pasadaPromocion, passedName, passedPrice);

            panelProducto testBarbero = new panelProducto(pasadoMenu, passedName, passedPrice, " ", " ");
            enviadaVista.flpPromocion.Controls.Add(pasadaPromocion);
            enviadaVista.flpPromocion.Controls.Add(testBarbero);
        }
        public void ConfirmarYSalir(vistaMenu pasadoMenu, panelPromocion pasadaPromocion, string passedName, string passedPrice) 
        {
            new daoControlTotal(pasadaPromocion, passedName, passedPrice);
            pasadoMenu.controladorMenu.AbrirFormulario(new vistaInicio(pasadoMenu));

        }
    }
}