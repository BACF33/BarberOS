using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dto
{
    public class DtoPanelProducto
    {
        private string productoId;
        private string productoName;
        private string productoPrecio;
        private string productoTipo;
        private byte[] productoImagen;

        public string ProductoId { get => productoId; set => productoId = value; }
        public string ProductoName { get => productoName; set => productoName = value; }
        public string ProductoPrecio { get => productoPrecio; set => productoPrecio = value; }
        public string ProductoTipo { get => productoTipo; set => productoTipo = value; }
        public byte[] ProductoImagen { get => productoImagen; set => productoImagen = value; }
    }
}
