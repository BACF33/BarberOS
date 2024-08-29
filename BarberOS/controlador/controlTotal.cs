using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using BarberOS.Vistas;

namespace BarberOS.Controlador
{
    internal class ControlTotal
    {
        public ControlTotal(vistaMenu pasadoMenu, VistaRecompensas enviadaVista, DtoPanelPromocion pasadaPromocion, DtoPanelProducto seleccionadoProducto) 
        {

            enviadaVista.btnConfirmar.Click += (sender, e) => ConfirmarYSalir(pasadoMenu, pasadaPromocion, seleccionadoProducto);

            PanelProducto testBarbero = new PanelProducto(pasadoMenu, seleccionadoProducto.ProductoId, seleccionadoProducto.ProductoName, seleccionadoProducto.ProductoPrecio, seleccionadoProducto.ProductoTipo);

            PanelPromocion testPromocion = new PanelPromocion(pasadoMenu, seleccionadoProducto, pasadaPromocion.PromocionId, pasadaPromocion.PromocionName, pasadaPromocion.PromocionPoder, pasadaPromocion.PromocionTipo);


            enviadaVista.flpPromocion.Controls.Add(testPromocion);
            enviadaVista.flpPromocion.Controls.Add(testBarbero);
        }
        public void ConfirmarYSalir(vistaMenu pasadoMenu, DtoPanelPromocion pasadaPromocion, DtoPanelProducto seleccionadoProducto) 
        {
            new DaoTotal(pasadaPromocion, seleccionadoProducto);
            pasadoMenu.controladorMenu.AbrirFormulario(new VistaInicio(pasadoMenu));

        }
    }
}