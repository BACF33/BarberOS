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
    public partial class panelPromocion : UserControl
    {
        public panelPromocion(vistaMenu pasadoMenu)
        {
            InitializeComponent();
            controlPanelPromocion controladorVista = new controlPanelPromocion(this, pasadoMenu);
        }
    }
}
