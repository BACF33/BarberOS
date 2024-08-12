using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using BarberOS.Vistas;

namespace BarberOS.Controlador
{
    internal class controlTotal
    {
        public controlTotal(vistaMenu pasadoMenu, vistaRecompensas enviadaVista, dtoPanelPromocion pasadaPromocion, dtoPanelProducto seleccionadoProducto) 
        {

            enviadaVista.btnConfirmar.Click += (sender, e) => ConfirmarYSalir(pasadoMenu, pasadaPromocion, seleccionadoProducto);

            panelProducto testBarbero = new panelProducto(pasadoMenu, seleccionadoProducto.ProductoId, seleccionadoProducto.ProductoName, seleccionadoProducto.ProductoPrecio, seleccionadoProducto.ProductoTipo);

            panelPromocion testPromocion = new panelPromocion(pasadoMenu, seleccionadoProducto, pasadaPromocion.PromocionId, pasadaPromocion.PromocionName, pasadaPromocion.PromocionPoder, pasadaPromocion.PromocionTipo);


            enviadaVista.flpPromocion.Controls.Add(testPromocion);
            enviadaVista.flpPromocion.Controls.Add(testBarbero);
        }
        public void ConfirmarYSalir(vistaMenu pasadoMenu, dtoPanelPromocion pasadaPromocion, dtoPanelProducto seleccionadoProducto) 
        {
            new daoTotal(pasadaPromocion, seleccionadoProducto);
            pasadoMenu.controladorMenu.AbrirFormulario(new vistaInicio(pasadoMenu));

        }
    }
}