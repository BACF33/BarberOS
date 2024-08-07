using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;

namespace BarberOS.Controlador
{
    internal class controlPanelProducto
    {
        panelProducto testPanel = null;
        public controlPanelProducto(panelProducto pasadoPanel, vistaMenu pasadoMenu, string pasadaId, string pasadoName, string pasadoPrecio)
        {
            testPanel = pasadoPanel;
            pasadoPanel.btnComprar.Click += (sender, e) => pasadoMenu.controladorMenu.AbrirFormulario(new vistaListaPromociones(pasadoMenu, pasadoName, pasadoPrecio));

            dtoPanelProducto infoEste = new dtoPanelProducto();

            infoEste.ProductoName = pasadoName;
            infoEste.ProductoPrecio = pasadoPrecio;

            pasadoPanel.lblName.Text = pasadoName;
            pasadoPanel.lblPrice.Text = pasadoPrecio;
        }


        //public void populate()
        //{
        //    daoPanelProducto daoThis = new daoPanelProducto();
        //}
    }
}
