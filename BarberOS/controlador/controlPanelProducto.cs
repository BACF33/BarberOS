using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;

namespace BarberOS.Controlador
{
    internal class controlPanelProducto
    {
        dtoPanelProducto dtoThis = new dtoPanelProducto();
        public controlPanelProducto(panelProducto pasadoPanel, vistaMenu pasadoMenu, string passedId, string passedName, string passedPrice, string passedType)
        {
            dtoThis.ProductoId = passedId;
            dtoThis.ProductoName = passedName;
            dtoThis.ProductoPrecio = passedPrice;
            dtoThis.ProductoTipo = passedType;

            pasadoPanel.lblName.Text = dtoThis.ProductoName;
            pasadoPanel.lblPrice.Text = dtoThis.ProductoPrecio;

            pasadoPanel.btnComprar.Click += (sender, e) => pasadoMenu.controladorMenu.AbrirFormulario(new vistaListaPromociones(pasadoMenu, dtoThis));
        }
    }
}
