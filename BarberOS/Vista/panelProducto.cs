using BarberOS.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class PanelProducto : UserControl
    {
        public PanelProducto(vistaMenu pasadoMenu, string passedId, string passedName, string passedPrice, string passedType, byte[] imageData)
        {
            InitializeComponent();
            ControlPanelProducto pProducto = new ControlPanelProducto(this, pasadoMenu, passedId, passedName, passedPrice, passedType, imageData);    
        }
    }
}
