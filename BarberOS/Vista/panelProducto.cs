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
    public partial class panelProducto : UserControl
    {
        public panelProducto(vistaMenu pasadoMenu, string passedId, string passedName, string passedPrice, string passedTipo)
        {
            InitializeComponent();
            controlPanelProducto pProducto = new controlPanelProducto(this, pasadoMenu, passedId, passedName, passedPrice);    
        }
    }
}
