using BarberOS.Modelo.Dao;
using BarberOS.Modelo.Dto;
using BarberOS.Vista;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlPanelProducto
    {
        DtoPanelProducto dtoThis = new DtoPanelProducto();
        public ControlPanelProducto(PanelProducto pasadoPanel, vistaMenu pasadoMenu, string passedId, string passedName, string passedPrice, string passedType, byte[] imageData)
        {
            //Los valores que se obtuvieron de una fila de la tabla de productos se le asignaran al panel (control de usuario) de un producto y se creara el control de usuario
            dtoThis.ProductoId = passedId;
            dtoThis.ProductoName = passedName;
            dtoThis.ProductoPrecio = passedPrice;
            dtoThis.ProductoTipo = passedType;
            dtoThis.ProductoImagen = imageData;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image convertida = Image.FromStream(ms);
                pasadoPanel.imgProducto.Image = convertida;
            }

            pasadoPanel.lblName.Text = dtoThis.ProductoName;
            pasadoPanel.lblPrice.Text = dtoThis.ProductoPrecio;

            //Cuando se presione comprar se mandara al usuario a la lista de promociones
            pasadoPanel.btnComprar.Click += (sender, e) => pasadoMenu.controladorMenu.AbrirFormulario(new VistaListaPromociones(pasadoMenu, dtoThis));
        }
    }
}
